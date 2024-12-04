﻿
Imports Microsoft.Reporting.WinForms
Imports System.Xml
Public Class frmReporteadorNomina
    Dim dtReportes As New DataTable
    Dim Acumulado As String
    Dim AnoPerListados As String = ""
    Dim NombreReporte As String = ""
    Dim BuscaReporte As String = ""

    Private Function FiltrosNominaAcumulados() As String
        Dim FL As String = ""
        Dim i As Integer
        Try
            lstFiltros.Items.Clear()
            For i = 0 To NFiltrosNomina - 1
                FL = FL & IIf(i > 0, " AND (", "(") & FiltrosNomina(2, i) & ")"
                lstFiltros.Items.Add(FiltrosNomina(2, i))
            Next
            'If FL.Length > 0 Then
            '    FL = " WHERE " & FL
            'End If
        Catch ex As Exception
            FL = "ERROR"
        End Try

        Return FL
    End Function

    Private Function OrdenAcumulado() As String

        Dim FL As String = ""
        Dim i As Integer
        Try
            For i = 0 To lstOrden.Items.Count - 1
                FL = FL & IIf(i > 0, ",", "") & lstOrden.Items(i)
            Next
            FL = FL.Replace("(", "")
            FL = FL.Replace(")", "")
            If FL = "" Then
                FL = "RELOJ ASC"
            End If

            'FL = " ORDER BY " & FL
        Catch ex As Exception
            FL = "ERROR"
        End Try

        Return FL

    End Function

    Private Sub frmReporteador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        NFiltrosNomina = 0
        Me.Dispose()
    End Sub

    Private Sub frmReporteador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTipoReportes.DataSource = sqlExecute("SELECT * FROM tipo_reportes ORDER BY tipo", "nomina")
            cmbTipoReportes.SelectedValue = "X"

            dtNominaReporteador = New DataTable

            bgw.WorkerReportsProgress = True
            'Utilizar el OVER para que el máximo no sea por grupo, sino en general
            chkRecientes.Text = "Ver últimos 10 reportes utilizados por el usuario " & Usuario.ToUpper
            chkRecientes.Checked = False
            txtActivos.Value = Today
            txtBajas.Value = Today

            Acumulado = FiltrosNominaAcumulados()

            'Dim drow As DataRow
            Dim ArchivoFoto As String = ""
            Dim dtTemp As New DataTable

            gpAvance.Visible = True
            pbAvance.IsRunning = True
            gpReportes.Enabled = False
            gpFiltros.Enabled = False
            gpOrden.Enabled = False
            gpControles.Enabled = False

            Me.Cursor = Cursors.WaitCursor

            ' Application.DoEvents()
            If CiaReporteador = "***" Then
                CiaReporteador = ""
                lblCia.Text = "CONSOLIDADO"
            Else
                dtTemp = sqlExecute("SELECT nombre FROM cias WHERE cod_comp = '" & CiaReporteador & "'")
                lblCia.Text = dtTemp.Rows(0).Item("nombre")
                CiaReporteador = "''" & CiaReporteador.Trim & "''"
            End If
            bgw.WorkerReportsProgress = True

            For Each I In PeriodosReporteador
                lstPeriodos.Items.Add(I.Substring(0, 4) & "-" & I.Substring(4, 2))
                AnoPerListados = AnoPerListados & IIf(AnoPerListados.Length > 0, ", ", "") & I.Substring(0, 4) & "-" & I.Substring(4, 2)
            Next
            AnoPerListados = IIf(AnoPerListados.Contains(","), "PERIODOS ", "PERIODO ") & AnoPerListados

            My.Application.DoEvents()
            bgw.RunWorkerAsync()



            'For Each I In PeriodosReporteador
            '    Dim A As String = ""
            '    Dim P As String = ""
            '    A = I.Substring(0, 4)
            '    P = I.Substring(4, 2)

            '    lstPeriodos.Items.Add(A & "-" & P)
            '    lstPeriodos.TopIndex = lstPeriodos.Items.Count - 1
            '    frmTrabajando.lblAvance.Text = "Nómina " & I
            '    Application.DoEvents()
            '    dtResultadoNomina = sqlExecute("EXEC reporteadornomina @Cia = '" & CiaReporteador & "',@ano = '" & A & "', @periodo = '" & P & _
            '                             "',@Nivel = " & NivelConsulta & ",@reloj = ''", "nomina")
            '    dtNominaReporteador.Merge(dtResultadoNomina)
            'Next
            chkActivos.Checked = True
            FiltroActivos()

            chkReloj.Checked = True
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
        Finally
            'gpAvance.Visible = False
            'pbAvance.IsRunning = False
        End Try
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork
        Dim A As String
        Dim P As String
        Dim T As String
        dtNominaReporteador = Nothing

        If (AcumularNom) Then ' Acumular nomina varios periodos
            Try

                bgw.ReportProgress(0, "... CARGANDO ..." & vbCrLf & "Nómina " & "")
                AcumulaPeriodos(aniosRepNom, persRepNom) ' AOS -- Acumula los periodos para el año  mandado
                A = aniosRepNom
                P = ""
                T = ""

                Dim QE As String = "EXEC ReporteadorAcumula @Cia = '',@ano = " & A & _
                         ",@Nivel = '" & NivelConsulta & "', @reloj = ''"
                dtResultadoNomina = sqlExecute(QE, "nomina")
                dtResultadoNomina.Columns.Add("periodos")

                If IsNothing(dtNominaReporteador) Then dtNominaReporteador = dtResultadoNomina.Clone

                If dtResultadoNomina.Rows.Count = 0 Then Exit Sub

                Dim perc As Integer = 0
                For Each dRow As DataRow In dtResultadoNomina.Rows
                    '.Select(FiltroXUsuario)
                    Try

                        bgw.ReportProgress(Math.Truncate(perc / dtResultadoNomina.Rows.Count), "Reloj " & dRow.Item("reloj"))
                        Application.DoEvents()

                        dtResultado.ImportRow(dRow)
                        perc += 1

                    Catch ex As Exception

                    End Try

                Next
                dtNominaReporteador.Merge(dtResultadoNomina)


            Catch ex As Exception
                ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
            End Try



            'Dim totPer As Integer = 0
            'Dim anios As String = ""
            'Dim periodos As String = ""
            'Dim tipos_perido As String = ""
            'totPer = PeriodosReporteador.Count

            'Try
            '    For Each x In PeriodosReporteador
            '        A = x.Substring(0, 4)
            '        P = x.Substring(4, 2)
            '        T = x.Substring(6, 1)

            '        If (Not anios.Contains(A)) Then anios = anios & "'" & A.Trim & "',"
            '        If (Not periodos.Contains(P)) Then periodos = periodos & "'" & P.Trim & "',"
            '        If (Not tipos_perido.Contains(T)) Then tipos_perido = tipos_perido & "'" & T.Trim & "',"

            '    Next

            '    anios = anios.TrimStart(",")
            '    anios = anios.TrimEnd(",")
            '    periodos = periodos.TrimStart(",")
            '    periodos = periodos.TrimEnd(",")
            '    tipos_perido = tipos_perido.TrimStart(",")
            '    tipos_perido = tipos_perido.TrimEnd(",")


            'Catch ex As Exception
            '    ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
            'End Try

        End If

        If (Not AcumularNom) Then  ' Generar para solo un periodo
            Try

                For Each I In PeriodosReporteador
                    A = I.Substring(0, 4)
                    P = I.Substring(4, 2)
                    T = I.Substring(6, 1)

                    bgw.ReportProgress(0, "... CARGANDO ..." & vbCrLf & "Nómina " & I)
                    Dim QE As String = "EXEC ReporteadorNominaTipoPeriodo @Cia = '" & CiaReporteador & "',@ano = '" & A & "', @periodo = '" & P & _
                                             "',@Nivel = '" & NivelConsulta & "', @reloj = '', @TipoPeriodo = '" & T & "'"
                    dtResultadoNomina = sqlExecute(QE, "nomina")
                    dtResultadoNomina.Columns.Add("periodos")

                    If IsNothing(dtNominaReporteador) Then
                        dtNominaReporteador = dtResultadoNomina.Clone
                    End If

                    'frmTrabajando.Avance.IsRunning = True

                    If dtResultadoNomina.Rows.Count = 0 Then
                        Exit Sub
                    End If

                    Dim perc As Integer = 0
                    For Each dRow As DataRow In dtResultadoNomina.Rows
                        '.Select(FiltroXUsuario)
                        Try

                            bgw.ReportProgress(Math.Truncate(perc / dtResultadoNomina.Rows.Count), "Reloj " & dRow.Item("reloj"))
                            Application.DoEvents()

                            dtResultado.ImportRow(dRow)
                            perc += 1

                        Catch ex As Exception

                        End Try

                    Next
                    dtNominaReporteador.Merge(dtResultadoNomina)
                Next

            Catch ex As Exception
                ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
            End Try
        End If
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw.ProgressChanged
        lblAvance.Text = CType(e.UserState, String)
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        pbAvance.IsRunning = False
        gpAvance.Visible = False

        gpControles.Enabled = True
        gpReportes.Enabled = True
        gpFiltros.Enabled = True
        gpOrden.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub chkBajas_CheckedChanged(sender As Object, e As EventArgs) Handles chkBajas.CheckedChanged
        Try
            Dim I As Integer = -1
            If chkBajas.Checked Then
                chkActivos.Checked = False
                chkTodos.Checked = False
                FiltroBajas()
                txtBajas.Focus()

            Else
                'Actualiza lista de FiltrosNomina
                Dim x As Integer

                For x = 0 To NFiltrosNomina - 1
                    If FiltrosNomina(1, x) = "BAJAS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstFiltros.Items.RemoveAt(I)

                For x = I To NFiltrosNomina - 1
                    FiltrosNomina(1, x) = FiltrosNomina(1, x + 1)
                    FiltrosNomina(2, x) = FiltrosNomina(2, x + 1)
                Next
                NFiltrosNomina = NFiltrosNomina - 1
                ReDim Preserve FiltrosNomina(2, x)
            End If
            chkTodos.Checked = Not (chkActivos.Checked Or chkBajas.Checked Or chkOtrosFiltros.Checked)
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivos.CheckedChanged
        Try
            'Dim Filtro As String
            Dim I As Integer = -1
            If chkActivos.Checked Then
                chkBajas.Checked = False
                chkTodos.Checked = False
                'Agregado
                FiltroActivos()
                txtActivos.Focus()
            Else
                'Actualiza lista de FiltrosNomina
                Dim x As Integer

                For x = 0 To NFiltrosNomina - 1
                    If FiltrosNomina(1, x) = "ACTIVOS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstFiltros.Items.RemoveAt(I)

                For x = I To NFiltrosNomina - 1
                    FiltrosNomina(1, x) = FiltrosNomina(1, x + 1)
                    FiltrosNomina(2, x) = FiltrosNomina(2, x + 1)
                Next
                NFiltrosNomina = NFiltrosNomina - 1
                ReDim Preserve FiltrosNomina(2, x)
            End If
            chkTodos.Checked = Not (chkActivos.Checked Or chkBajas.Checked Or chkOtrosFiltros.Checked)
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub txtBajas_Click(sender As Object, e As EventArgs) Handles txtBajas.Click

    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try
            If chkTodos.Checked Then
                chkActivos.Checked = False
                chkBajas.Checked = False
                chkOtrosFiltros.Checked = False
                lstFiltros.Items.Clear()
                NFiltrosNomina = 0
            End If

            If Not (chkActivos.Checked Or chkBajas.Checked Or chkOtrosFiltros.Checked) Then
                chkTodos.Checked = True
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkRecientes_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecientes.CheckedChanged
        CargarReportes()

    End Sub

    Private Sub dgReportes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CargarReportes()
        Dim FiltrarTipo As Boolean
        Dim Cadena As String
        Dim D As Integer
        Dim O As Windows.Forms.SortOrder
        Try
            FiltrarTipo = cmbTipoReportes.SelectedValue <> "X"
            dtReportes = New DataTable
            If dgReportes.SortedColumn Is Nothing Then
                D = 0
                O = SortOrder.Ascending
            Else
                D = dgReportes.SortedColumn.Index
                O = dgReportes.SortOrder
            End If

            Cadena = "SELECT RTRIM(reportes.NOMBRE) AS NOMBRE,reportes.TIPO," & _
               "(100*VECES_ACCESO)/((SELECT MAX(veces_acceso) FROM reportes)+1) AS Frecuencia,reportes.FECHA " & _
               "FROM REPORTES WHERE reportes.NOMBRE IN " & _
               "(SELECT CONTROL FROM SEGURIDAD.dbo.PERMISOS WHERE " & IIf(FiltrarTipo, " reportes.tipo='" & cmbTipoReportes.SelectedValue & "' AND ", "") & _
               " cod_perfil " & Perfil & " AND permisos.modulo = 'NOM'  and permisos.acceso = 1)" & _
               IIf(BuscaReporte.Length = 0, "", " AND personal.dbo.EliminaAcentos(reportes.nombre) LIKE '%" & BuscaReporte & "%' ") & _
               " ORDER BY reportes.nombre"

            dtReportes = New DataTable
            dtReportes = sqlExecute(Cadena, "nomina")
            dgReportes.DataSource = dtReportes
            'dgReportes.Columns("username").Visible = False
            'dgReportes.Sort(dgReportes.Columns.Item(D), O)
            If dgReportes.Rows.Count > 0 Then
                'dgReportes.Rows.Item(1).Visible = False
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub



    Private Sub chkReloj_CheckedChanged(sender As Object, e As EventArgs) Handles chkReloj.CheckedChanged
        Try
            Dim I As Integer = -1
            Dim TipoOrden As String = IIf(sbReloj.Value, "ASC", "DESC")
            Dim x As Integer = 0

            If chkReloj.Checked Then
                'Actualiza lista de OrdenNomina
                If NOrdenNomina < 0 Then NOrdenNomina = 0
                For x = 0 To NOrdenNomina - 1
                    If OrdenNomina(1, x) = "RELOJ" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NOrdenNomina
                    NOrdenNomina = NOrdenNomina + 1
                    If OrdenNomina Is Nothing Then
                        ReDim OrdenNomina(2, NOrdenNomina)
                    ElseIf UBound(OrdenNomina, 2) < NOrdenNomina Then
                        ReDim Preserve OrdenNomina(2, NOrdenNomina)
                    End If

                End If

                OrdenNomina(1, I) = "RELOJ"
                OrdenNomina(2, I) = TipoOrden

                lstOrden.Items.Clear()
                For x = 0 To NOrdenNomina - 1
                    lstOrden.Items.Add(OrdenNomina(1, x) & " (" & OrdenNomina(2, x) & ")")
                Next
                chkNombre.Checked = False
                sbReloj.Focus()
            Else
                'Actualiza lista de OrdenNomina


                For x = 0 To NOrdenNomina - 1
                    If OrdenNomina(1, x) = "RELOJ" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstOrden.Items.RemoveAt(I)

                For x = I To NOrdenNomina - 1
                    OrdenNomina(1, x) = OrdenNomina(1, x + 1)
                    OrdenNomina(2, x) = OrdenNomina(2, x + 1)
                Next
                NOrdenNomina = NOrdenNomina - 1
                ReDim Preserve OrdenNomina(2, x)
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkNombre_CheckedChanged(sender As Object, e As EventArgs) Handles chkNombre.CheckedChanged
        Try
            Dim I As Integer = -1
            Dim TipoOrden As String = IIf(sbNombre.Value, "ASC", "DESC")
            Dim x As Integer = 0

            If chkNombre.Checked Then
                'Actualiza lista de OrdenNomina
                If NOrdenNomina < 0 Then NOrdenNomina = 0
                For x = 0 To NOrdenNomina - 1
                    If OrdenNomina(1, x) = "NOMBRES" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NOrdenNomina
                    NOrdenNomina = NOrdenNomina + 1

                    If UBound(OrdenNomina, 2) < NOrdenNomina Then
                        ReDim Preserve OrdenNomina(2, NOrdenNomina)
                    End If
                End If

                OrdenNomina(1, I) = "NOMBRES"
                OrdenNomina(2, I) = TipoOrden

                lstOrden.Items.Clear()
                For x = 0 To NOrdenNomina - 1
                    lstOrden.Items.Add(OrdenNomina(1, x) & " (" & OrdenNomina(2, x) & ")")
                Next

                chkReloj.Checked = False
                sbReloj.Focus()
            Else
                'Actualiza lista de OrdenNomina


                For x = 0 To NOrdenNomina - 1
                    If OrdenNomina(1, x) = "NOMBRES" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstOrden.Items.RemoveAt(I)

                For x = I To NOrdenNomina - 1
                    OrdenNomina(1, x) = OrdenNomina(1, x + 1)
                    OrdenNomina(2, x) = OrdenNomina(2, x + 1)
                Next
                NOrdenNomina = NOrdenNomina - 1
                ReDim Preserve OrdenNomina(2, x)
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkReportesUsuario_CheckedChanged(sender As Object, e As EventArgs)
        CargarReportes()
    End Sub

    Private Sub chkOtrosFiltros_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtrosFiltros.CheckedChanged
        chkTodos.Checked = Not (chkActivos.Checked Or chkBajas.Checked Or chkOtrosFiltros.Checked)
    End Sub

    Private Sub btnSeleccionarFiltros_Click(sender As Object, e As EventArgs) Handles btnSeleccionarFiltros.Click
        Try
            Dim Filtro As String
            frmFiltroNomina.ShowDialog()
            Acumulado = FiltrosNominaAcumulados()

            chkOtrosFiltros.Checked = NFiltrosNomina > 0

            Filtro = ""
            lstFiltros.Items.Clear()
            For x = 0 To NFiltrosNomina - 1
                lstFiltros.Items.Add(FiltrosNomina(2, x))
            Next
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub txtActivos_Click(sender As Object, e As EventArgs) Handles txtActivos.Click

    End Sub

    Private Sub txtActivos_Validated(sender As Object, e As EventArgs) Handles txtActivos.Validated
        FiltroActivos()
    End Sub
    Private Sub FiltroActivos()
        Try
            Dim Filtro As String
            Dim I As Integer = -1
            If chkActivos.Checked Then
                'chkBajas.Checked = False
                'txtActivos.Focus()
                Filtro = " ALTA <= '" & FechaSQL(txtActivos.Value) & "' AND (BAJA IS NULL OR BAJA > '" & FechaSQL(txtActivos.Value) & "')"


                'Actualiza lista de FiltrosNomina

                For x = 0 To NFiltrosNomina - 1
                    If FiltrosNomina(1, x) = "ACTIVOS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NFiltrosNomina
                    NFiltrosNomina = NFiltrosNomina + 1

                    If FiltrosNomina Is Nothing Then
                        ReDim Preserve FiltrosNomina(2, NFiltrosNomina)
                    Else
                        If UBound(FiltrosNomina, 2) < NFiltrosNomina Then
                            ReDim Preserve FiltrosNomina(2, NFiltrosNomina)
                        End If
                    End If
                End If

                FiltrosNomina(1, I) = "ACTIVOS"
                FiltrosNomina(2, I) = Filtro

                Filtro = ""
                lstFiltros.Items.Clear()
                For x = 0 To NFiltrosNomina - 1
                    lstFiltros.Items.Add(FiltrosNomina(2, x))
                    'Filtro = Filtro & IIf(Filtro.Length = 0, "", " AND ") & FiltrosNomina(2, x)
                Next
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub FiltroBajas()
        Try
            Dim Filtro As String
            Dim I As Integer = -1
            If chkBajas.Checked Then
                'chkBajas.Checked = False
                'txtActivos.Focus()
                Filtro = " BAJA <= '" & FechaSQL(txtActivos.Value) & "' AND NOT BAJA IS NULL"


                'Actualiza lista de filtros

                For x = 0 To NFiltrosNomina - 1
                    If FiltrosNomina(1, x) = "BAJAS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NFiltrosNomina
                    NFiltrosNomina = NFiltrosNomina + 1

                    If UBound(FiltrosNomina, 2) < NFiltrosNomina Then
                        ReDim Preserve FiltrosNomina(2, NFiltrosNomina)
                    End If
                End If

                FiltrosNomina(1, I) = "BAJAS"
                FiltrosNomina(2, I) = Filtro

                Filtro = ""
                lstFiltros.Items.Clear()
                For x = 0 To NFiltrosNomina - 1
                    lstFiltros.Items.Add(FiltrosNomina(2, x))
                    'Filtro = Filtro & IIf(Filtro.Length = 0, "", " AND ") & Filtros(2, x)
                Next
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        gpAvance.Visible = True
        pbAvance.IsRunning = True
        gpReportes.Enabled = False
        gpFiltros.Enabled = False
        gpOrden.Enabled = False
        gpControles.Enabled = False

        Me.Cursor = Cursors.WaitCursor
        'bgwReporte.WorkerReportsProgress = True

        EncabezadoReporte = AnoPerListados

        Dim EncabezadoReporteTMP As String = EncabezadoReporte.Replace("PERIODOS", "PERIODO").Replace("PERIODO", "").Trim
        

        FiltroReporte = FiltrosNominaAcumulados()
        OrdenReporte = OrdenAcumulado()

        My.Application.DoEvents()
        'bgwReporte.RunWorkerAsync()
        CargaDatos()

    End Sub


    'BACKUP ANTES DE AGREGAR BACKGROUNDWORKER
    'Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click 
    '    Dim dtReporte As New DataTable
    '    Dim r As Integer
    '    Dim i As Integer
    '    Dim idReporte As Integer
    '    Dim Nombre As String
    '    Dim Tipo As String
    '    Try
    '        r = dgReportes.CurrentCell.RowIndex
    '        If r < 0 Then Exit Sub
    '        idReporte = dgReportes.Item("id", r).Value
    '        Nombre = dgReportes.Item(1, r).Value
    '        'Si en el nombre incluye "(AUDITORÍA)", quitarlo porque el nombre del archivo no lo incluye
    '        Nombre = Nombre.Replace("(AUDITORÍA)", "").Trim

    '        Tipo = dgReportes.Item("tipo", r).Value

    '        sqlExecute("UPDATE reportes SET veces_acceso = veces_acceso + 1, fecha = GETDATE()   WHERE nombre = '" & nombre.trim & "'")

    '        dtTemporal = sqlExecute("SELECT COUNT(idReporte) AS cuantos FROM reportes_recientes WHERE usuario = '" & Usuario & "'")
    '        If dtTemporal.Rows.Item(0).Item("cuantos") = 10 Then
    '            sqlExecute("DELETE FROM reportes_recientes WHERE fecha = (SELECT MIN(fecha) FROM reportes_recientes WHERE usuario = '" & Usuario & "') AND usuario = '" & Usuario & "'")
    '        End If

    '        dtTemporal = sqlExecute("SELECT idReporte FROM reportes_recientes WHERE usuario = '" & Usuario & "' AND nombre = '" & nombre.trim & "'")
    '        If dtTemporal.Rows.Count > 0 Then
    '            sqlExecute("UPDATE reportes_recientes SET fecha = GETDATE() WHERE usuario = '" & Usuario & "' AND nombre = '" & nombre.trim & "'")
    '        Else
    '            sqlExecute("INSERT INTO reportes_recientes VALUES (" & idReporte & ",'" & Usuario & "',GETDATE())")
    '        End If

    '        FiltroReporte = FiltrosNominaAcumulados()
    '        OrdenReporte = OrdenAcumulado()

    '        'Dim dtResultadoFiltro As New DataSet
    '        'dtResultadoFiltro.Merge(dtResultadoNomina.Select(FiltroReporte, OrdenReporte))

    '        'If dtResultadoFiltro.Tables.Count = 0 Then
    '        '    dtFiltroPersonal = New DataTable
    '        'Else
    '        '    dtFiltroPersonal = dtResultadoFiltro.Tables(0)
    '        '    dtResultadoFiltro.Tables(0).TableName = "Nomina"
    '        '    dtFiltroPersonal.DefaultView.Sort = OrdenReporte
    '        'End If

    '        dtFiltroPersonal = dtNominaReporteador.Clone
    '        For Each dR As DataRow In dtNominaReporteador.Select(FiltroReporte, OrdenReporte)
    '            dtFiltroPersonal.ImportRow(dR)
    '        Next

    '        If Tipo = "U" Then
    '            dtDisponibles = sqlExecute("(SELECT UPPER(cod_campo) AS campo,personal.dbo.IniciaMayuscula(nombre) AS nombre FROM campos UNION SELECT UPPER(campo),personal.dbo.IniciaMayuscula(nombre) AS nombre FROM auxiliares) ORDER BY nombre")
    '            ReporteadorFuente = "NOMINA"
    '            dtReporte = sqlExecute("SELECT * FROM reportes WHERE nombre = '" & Nombre & "'")
    '            If dtReporte.Rows.Count < 1 Then Exit Sub
    '            frmVistaPrevia.ReporteDinamico(dtReporte.Rows(0), dtFiltroPersonal, Nombre)
    '        Else
    '            frmVistaPrevia.LlamarReporte(Nombre, dtFiltroPersonal)
    '            frmVistaPrevia.ShowDialog()
    '        End If

    '        CargarReportes()
    '        For i = 0 To dgReportes.Rows.Count - 1
    '            If dgReportes.Item("id", i).Value = idReporte Then
    '                r = i
    '                Exit For
    '            End If
    '        Next
    '        dgReportes.CurrentCell = dgReportes.Item(1, r)


    '    Catch ex As Exception
    '        ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
    '    End Try
    'End Sub

    Private Sub sbReloj_Validated(sender As Object, e As EventArgs)

    End Sub
    Private Sub sbReloj_ValueChanged(sender As Object, e As EventArgs) Handles sbReloj.ValueChanged
        Try
            Dim TipoOrden As String
            Dim I As Integer = -1
            TipoOrden = IIf(sbReloj.Value, "ASC", "DESC")
            'Hacerlo falso, luego verdadero, para activar el "CheckedChanged"
            If chkReloj.Checked Then
                chkReloj.Checked = False
                chkReloj.Checked = True
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub sbNombre_ValueChanged(sender As Object, e As EventArgs) Handles sbNombre.ValueChanged
        Try
            Dim TipoOrden As String
            Dim I As Integer = -1
            TipoOrden = IIf(sbNombre.Value, "ASC", "DESC")
            'Hacerlo falso, luego verdadero, para activar el "CheckedChanged"
            If chkNombre.Checked Then
                chkNombre.Checked = False
                chkNombre.Checked = True
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        On Error GoTo ErrS
        Dim r As Boolean, n As Boolean
        Dim i As Integer
        ' Dim TipoOrden As String
        frmOrdenNomina.ShowDialog()


        i = NOrdenNomina
        lstOrden.Items.Clear()
        For x = 0 To NOrdenNomina - 1
            lstOrden.Items.Add(OrdenNomina(1, x) & " (" & OrdenNomina(2, x) & ")")
            If OrdenNomina(1, x) = "RELOJ" Then
                r = True
                sbReloj.Value = OrdenNomina(2, x) = "ASC"
                chkReloj.Checked = True
                i = i - 1
            ElseIf OrdenNomina(1, x) = "NOMBRES" Then
                n = True
                sbReloj.Value = OrdenNomina(2, x) = "ASC"
                chkNombre.Checked = True
                i = i - 1
            End If
        Next
        chkReloj.Checked = r
        chkNombre.Checked = n
        chkOtroOrden.Checked = i > 0
        Exit Sub
ErrS:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        SubirElemento(lstOrden)
    End Sub

    Private Sub btnBajar_Click(sender As Object, e As EventArgs) Handles btnBajar.Click
        BajarElemento(lstOrden)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub lstOrden_KeyUp(sender As Object, e As KeyEventArgs) Handles lstOrden.KeyUp
        Try
            Dim i As Integer
            Dim x As Integer
            If e.KeyValue = Keys.Delete Then
                i = lstOrden.SelectedIndex
                If lstOrden.SelectedItem.ToString.Substring(0, 5) = "RELOJ" Then
                    chkReloj.Checked = False
                ElseIf lstOrden.SelectedItem.ToString.Substring(0, 7) = "NOMBRES" Then
                    chkNombre.Checked = False
                End If

                If i < 0 Then Exit Sub
                If i = 0 Then
                    lstOrden.Items.Clear()
                Else
                    lstOrden.Items.RemoveAt(i)
                End If


                For x = i To NOrdenNomina - 1
                    OrdenNomina(1, x) = OrdenNomina(1, x + 1)
                    OrdenNomina(2, x) = OrdenNomina(2, x + 1)
                Next
                NOrdenNomina = NOrdenNomina - 1
                ReDim Preserve OrdenNomina(2, x)

                lstOrden.Items.Clear()
                For x = 0 To NOrdenNomina - 1
                    lstOrden.Items.Add(OrdenNomina(1, x) & "(" & OrdenNomina(2, x) & ")")
                Next
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub lstOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrden.SelectedIndexChanged

    End Sub

    Private Sub txtBajas_Validated(sender As Object, e As EventArgs) Handles txtBajas.Validated

        FiltroBajas()

        'Try
        '    Dim Filtro As String
        '    Dim I As Integer = -1
        '    If chkBajas.Checked Then
        '        'chkBajas.Checked = False
        '        'txtActivos.Focus()
        '        Filtro = " BAJA <= '" & FechaSQL(txtActivos.Value) & "' AND NOT BAJA IS NULL"


        '        'Actualiza lista de FiltrosNomina

        '        For x = 0 To NFiltrosNomina - 1
        '            If FiltrosNomina(1, x) = "BAJAS" Then
        '                I = x
        '                Exit For
        '            End If
        '        Next

        '        If I = -1 Then
        '            I = NFiltrosNomina
        '            NFiltrosNomina = NFiltrosNomina + 1

        '            If UBound(FiltrosNomina, 2) < NFiltrosNomina Then
        '                ReDim Preserve FiltrosNomina(2, NFiltrosNomina)
        '            End If
        '        End If

        '        FiltrosNomina(1, I) = "BAJAS"
        '        FiltrosNomina(2, I) = Filtro

        '        Filtro = ""
        '        lstFiltros.Items.Clear()
        '        For x = 0 To NFiltrosNomina - 1
        '            lstFiltros.Items.Add(FiltrosNomina(2, x))
        '            'Filtro = Filtro & IIf(Filtro.Length = 0, "", " AND ") & FiltrosNomina(2, x)
        '        Next
        '    End If
        'Catch ex As Exception
        '    ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        'End Try
    End Sub

    Private Sub gpReportes_Click(sender As Object, e As EventArgs) Handles gpReportes.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim Reporte As String = DireccionReportes & "Reporte dinámico.rdl"
            Dim c As String
            Dim i As Integer = 0
            Dim f As Integer = 0
            Dim Campos() As String
            Dim Grupo1 As String
            Dim Grupo2 As String
            Dim Grupo3 As String
            Dim MostrarDetalle As Byte
            Dim MostrarResumen As Byte
            Dim Titulo As String

            Dim dtCampos As New DataTable
            Dim dtCompa As New DataTable
            Dim dtDatos As New DataTable
            Dim drInfoReporte As DataRow

            'Inicializar datos de campos antes de iniciar
            dtDisponibles = New DataTable
            dtDisponibles = sqlExecute("(SELECT UPPER(cod_campo) AS campo,personal.dbo.IniciaMayuscula(nombre) AS nombre FROM campos UNION SELECT UPPER(campo),personal.dbo.IniciaMayuscula(nombre) AS nombre FROM auxiliares) ORDER BY nombre")
            ReporteadorFuente = "NOMINA"
            'frmCrearReporteDinamico.ShowDialog()

            'Revisar si se seleccionó CANCELAR
            If dtReporteDinamico.Columns.Count = 0 Then Exit Sub

            drInfoReporte = dtReporteDinamico.Rows(0)
            dtReportes.ImportRow(drInfoReporte)
            dtReportes.AcceptChanges()

            Titulo = drInfoReporte("nombre")

            FiltroReporte = FiltrosNominaAcumulados()
            OrdenReporte = OrdenAcumulado()

            If FiltroReporte.ToUpper.Contains("COD_COMP") Then
                'Si no se incluye filtro, tomar el primero de la tabla
                i = FiltroReporte.ToUpper.IndexOf("COD_COMP")
                f = FiltroReporte.ToUpper.IndexOf(")", i)

                c = FiltroReporte.ToUpper.Substring(i, f - i + 1)

                dtCompa = sqlExecute("SELECT COD_COMP, NOMBRE, RFC, REG_PAT, INFONAVIT, LOGO, GUIA, DIRECCION, COLONIA, CIUDAD, ESTADO, COD_POSTAL, TELEFONO1, REP_LEGAL ,PUESTO FROM personal.dbo.cias WHERE " & c)

            Else
                dtCompa = sqlExecute("SELECT TOP 1 COD_COMP,NOMBRE,RFC,REG_PAT,INFONAVIT,LOGO,GUIA FROM personal.dbo.cias WHERE cias_default = 1")
            End If

            dtCampos = sqlExecute("select upper(cod_campo) as campo,nombre,tipo FROM campos UNION select upper(campo),nombre,'char' as tipo from auxiliares")
            dtCampos.PrimaryKey = New DataColumn() {dtCampos.Columns("campo")}


            Campos = Split(IIf(IsDBNull(drInfoReporte("campos")), "", drInfoReporte("campos")), ",")
            Grupo1 = IIf(IsDBNull(drInfoReporte("grupo1")), "", drInfoReporte("grupo1").ToString.Trim)
            Grupo2 = IIf(IsDBNull(drInfoReporte("grupo2")), "", drInfoReporte("grupo2").ToString.Trim)
            Grupo3 = IIf(IsDBNull(drInfoReporte("grupo3")), "", drInfoReporte("grupo3").ToString.Trim)
            MostrarDetalle = IIf(IsDBNull(drInfoReporte("mostrar_detalle")), 0, drInfoReporte("mostrar_detalle"))
            MostrarResumen = IIf(IsDBNull(drInfoReporte("mostrar_resumen")), 0, drInfoReporte("mostrar_resumen"))


            Dim dtResultadoFiltro As New DataSet
            dtResultadoFiltro.Merge(dtResultadoNomina.Select(FiltroReporte))

            If dtResultadoFiltro.Tables.Count = 0 Then
                dtFiltroPersonal = New DataTable
            Else
                dtFiltroPersonal = dtResultadoFiltro.Tables(0)
                dtResultadoFiltro.Tables(0).TableName = "Personal"
                dtFiltroPersonal.DefaultView.Sort = OrdenReporte
            End If

            Dim x As Integer
            Dim Columnas(5) As DataColumn

            'Crear estructura de datos
            dtDatos = New DataTable("Datos")
            Columnas(0) = New DataColumn("reloj", System.Type.GetType("System.String"))
            Columnas(1) = New DataColumn("campo", System.Type.GetType("System.String"))
            Columnas(2) = New DataColumn("valor", System.Type.GetType("System.String"))
            Columnas(3) = New DataColumn("grupo1", System.Type.GetType("System.String"))
            Columnas(4) = New DataColumn("grupo2", System.Type.GetType("System.String"))
            Columnas(5) = New DataColumn("grupo3", System.Type.GetType("System.String"))

            For x = 0 To UBound(Columnas)
                dtDatos.Columns.Add(Columnas(x))
            Next
            Dim G1 As String = ""
            Dim G2 As String = ""
            Dim G3 As String = ""
            Dim Valor As String = ""
            Dim dr As DataRow

            For Each dRow As DataRow In dtFiltroPersonal.Rows
                If Grupo1 = "<Ninguno>" Then
                    G1 = ""
                Else
                    dr = dtCampos.Rows.Find(Grupo1)
                    If IsNothing(dr) Then
                        G1 = Grupo1 & " " & dRow(Grupo1)
                    Else
                        G1 = dr.Item("nombre").ToString.Trim & " " & dRow(Grupo1)
                    End If
                End If
                If Grupo2 = "<Ninguno>" Then
                    G2 = ""
                Else
                    dr = dtCampos.Rows.Find(Grupo2)
                    If IsNothing(dr) Then
                        G2 = Grupo2 & " " & dRow(Grupo2)
                    Else
                        G2 = dr.Item("nombre").ToString.Trim & " " & dRow(Grupo2)
                    End If
                End If
                If Grupo3 = "<Ninguno>" Then
                    G3 = ""
                Else
                    dr = dtCampos.Rows.Find(Grupo3)
                    If IsNothing(dr) Then
                        G3 = Grupo3 & " " & dRow(Grupo3)
                    Else
                        G3 = dr.Item("nombre").ToString.Trim & " " & dRow(Grupo3)
                    End If
                End If
                For x = 0 To UBound(Campos)
                    dr = dtCampos.Rows.Find(Campos(x))
                    If Not IsNothing(dr) Then
                        If dr("tipo").ToString.Trim = "num" Then
                            Try
                                Valor = String.Format("{0:0.00}", dRow(Campos(x)))
                            Catch ex As Exception
                                Valor = String.Format("{0:0.00}", 0)
                            End Try
                        Else
                            Valor = IIf(IsDBNull(dRow(Campos(x))), "", dRow(Campos(x)))
                        End If
                    Else
                        Valor = IIf(IsDBNull(dRow(Campos(x))), "", dRow(Campos(x)))
                    End If
                   
                    dtDatos.Rows.Add({dRow("reloj"), Campos(x), Valor, G1, G2, G3})
                Next
            Next

            'Limpiar el ReportViewer, por si hubiera algún reporte cargado
            frmVistaPrevia.vwrReportes.Clear()
            'Indicar que se ejecutarán reportes de forma local (no desde servidor SSRS)
            frmVistaPrevia.vwrReportes.ProcessingMode = ProcessingMode.Local
            frmVistaPrevia.vwrReportes.LocalReport.ReportPath = Reporte
            frmVistaPrevia.vwrReportes.LocalReport.DataSources.Clear()

            frmVistaPrevia.vwrReportes.LocalReport.DataSources.Add(New ReportDataSource("Datos", dtDatos))
            frmVistaPrevia.vwrReportes.LocalReport.DataSources.Add(New ReportDataSource("Compañía", dtCompa))

            Dim Parametros(0) As ReportParameter

            Parametros(0) = New ReportParameter("TITULO", Titulo)

            frmVistaPrevia.vwrReportes.LocalReport.EnableExternalImages = True
            frmVistaPrevia.vwrReportes.LocalReport.SetParameters(Parametros)
            frmVistaPrevia.vwrReportes.RefreshReport()
            frmVistaPrevia.ShowDialog()

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
        End Try

    End Sub

    Private Sub dgReportes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportes.CellClick
        'Try
        '    Dim r As Integer
        '    r = e.RowIndex
        '    If r < 0 Then Exit Sub
        '    gpFiltros.Enabled = IIf(IsDBNull(dgReportes.Item("FILTRAR", r).Value), Enabled, dgReportes.Item("FILTRAR", r).Value)
        'Catch ex As Exception
        '    gpFiltros.Enabled = True
        '                ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        'End Try
    End Sub

    Private Sub dgReportes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportes.CellDoubleClick
        btnGenerar.PerformClick()
    End Sub


    Private Sub dgReportes_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportes.CellEnter
        Try
            Dim i As Integer
            Dim t As String
            Dim u As String
            i = dgReportes.CurrentRow.Index
            t = dgReportes.Item("tipo", i).Value
            u = IIf(IsDBNull(dgReportes.Item("username", i).Value), "", dgReportes.Item("username", i).Value)

            'Permitir borrar solo los reportes creados por el usuario actual
            btnBorrar.Visible = (t.Trim = "U" And u.Trim = Usuario)
        Catch ex As Exception
            btnBorrar.Visible = False

                        ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            NombreReporte = dgReportes.Item("nombre", dgReportes.CurrentCell.RowIndex).Value.ToString.Trim
            If MessageBox.Show("¿Está seguro de eliminar el reporte " & Nombrereporte & "?", "Borrar reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sqlExecute("DELETE FROM reportes WHERE nombre = '" & Nombrereporte.Trim & "'")
                dgReportes.Rows.RemoveAt(dgReportes.CurrentCell.RowIndex)
            End If
        Catch ex As Exception
                        ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub CargaDatos()
        Dim dtReporte As New DataTable
        Dim r As Integer
        'Dim i As Integer
        'Dim idReporte As Integer
        Dim Reporte As String
        Dim Tipo As String
        Try
            r = dgReportes.CurrentCell.RowIndex
            If r < 0 Then Exit Sub
            NombreReporte = dgReportes.Item("nombre", r).Value
            'Si en el nombre incluye "(AUDITORÍA)", quitarlo porque el nombre del archivo no lo incluye
            Reporte = NombreReporte.Replace("(AUDITORÍA)", "").Trim
            'bgwReporte.ReportProgress(0, NombreReporte)

            Tipo = dgReportes.Item("tipo", r).Value

            sqlExecute("UPDATE reportes SET veces_acceso = veces_acceso + 1, fecha = GETDATE()   WHERE nombre = '" & NombreReporte.Trim & "'", "nomina")

            dtTemporal = sqlExecute("SELECT COUNT(nombre) AS cuantos FROM reportes_recientes WHERE usuario = '" & Usuario & "'", "nomina")
            If dtTemporal.Rows.Item(0).Item("cuantos") = 10 Then
                sqlExecute("DELETE FROM reportes_recientes WHERE fecha = (SELECT MIN(fecha) FROM reportes_recientes WHERE usuario = '" & Usuario & "') AND usuario = '" & Usuario & "'", "nomina")
            End If

            dtTemporal = sqlExecute("SELECT nombre FROM reportes_recientes WHERE usuario = '" & Usuario & "' AND nombre = '" & NombreReporte.Trim & "'", "nomina")
            If dtTemporal.Rows.Count > 0 Then
                sqlExecute("UPDATE reportes_recientes SET fecha = GETDATE() WHERE usuario = '" & Usuario & "' AND nombre = '" & NombreReporte.Trim & "'", "nomina")
            Else
                sqlExecute("INSERT INTO reportes_recientes (usuario,fecha,nombre) VALUES ('" & Usuario & "',GETDATE(),'" & NombreReporte.Trim & "')", "nomina")
            End If

            dtFiltroPersonal = dtNominaReporteador.Clone
            For Each dR As DataRow In dtNominaReporteador.Select(FiltroReporte, OrdenReporte)
                dtFiltroPersonal.ImportRow(dR)
            Next

            If Tipo = "U" Then
                dtDisponibles = sqlExecute("(SELECT UPPER(cod_campo) AS campo,personal.dbo.IniciaMayuscula(nombre) AS nombre FROM campos UNION SELECT UPPER(campo),personal.dbo.IniciaMayuscula(nombre) AS nombre FROM auxiliares) ORDER BY nombre")
                ReporteadorFuente = "NOMINA"
                dtReporte = sqlExecute("SELECT * FROM reportes WHERE nombre = '" & NombreReporte.Trim & "'", "nomina")
                If dtReporte.Rows.Count < 1 Then Exit Sub
                frmVistaPrevia.ReporteDinamico(dtReporte.Rows(0), dtFiltroPersonal, NombreReporte)
            ElseIf Tipo = "X" Then
                dtDisponibles = sqlExecute("(SELECT UPPER(cod_campo) AS campo,personal.dbo.IniciaMayuscula(nombre) AS nombre FROM campos UNION SELECT UPPER(campo),personal.dbo.IniciaMayuscula(nombre) AS nombre FROM auxiliares) ORDER BY nombre")
                ReporteadorFuente = "NOMINA"
                dtReporte = sqlExecute("SELECT * FROM reportes WHERE nombre = '" & NombreReporte.Trim & "'", "nomina")
                If dtReporte.Rows.Count < 1 Then Exit Sub
                PreparaDatos(NombreReporte, dtFiltroPersonal)
            ElseIf Reporte = "Recibo nómina" Then
                generar_recibos(dtFiltroPersonal)
            ElseIf Reporte = "Acumulado Mensual" Then  'Jose R Hdez 4 Marzo 2020 Reportes mensuales
                AcumuladoMensual(dtFiltroPersonal)
                MessageBox.Show("Reporte de Acumulado Mensual generado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Reporte = "Retroactivos" Then
                genera_retroactivos()
                MessageBox.Show("Reporte de retroactivos generado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Reporte = "Nomina detalle excel" Then
                Dim dtDatos As New DataTable
                Dim anio As String = ""
                Dim per As String = ""
                Dim tipo_per As String = ""

                NominaProExcel_2(dtDatos, dtFiltroPersonal, False, True, "Nómina detalle excel", False, "", anio, per, tipo_per, AnoPerListados)
                MessageBox.Show("Reporte de Nomina detalle excel generado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                frmVistaPrevia.LlamarReporte(Reporte, dtFiltroPersonal, CiaReporteador.Replace("''", ""))
                ' bgwReporte.ReportProgress(100)
                frmVistaPrevia.ShowDialog()
            End If
            CargaCompleta()
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    'Private Sub bgwReporte_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwReporte.ProgressChanged
    '    lblAvance.Text = "... PREPARANDO ..." & vbCrLf & CType(e.UserState, String)
    '    If e.ProgressPercentage = 100 Then
    '        gpAvance.Visible = False
    '        pbAvance.IsRunning = False
    '    End If
    'End Sub

    Private Sub CargaCompleta()
        ' bgwReporte_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporte.RunWorkerCompleted
        Try
            Dim r As Integer = 0

            CargarReportes()
            For i = 0 To dgReportes.Rows.Count - 1
                If dgReportes.Item("nombre", i).Value = NombreReporte Then
                    r = i
                    Exit For
                End If
            Next
            dgReportes.CurrentCell = dgReportes.Item(1, r)

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        Finally
            pbAvance.IsRunning = False
            gpAvance.Visible = False

            gpControles.Enabled = True
            gpReportes.Enabled = True
            gpFiltros.Enabled = True
            gpOrden.Enabled = True
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub cmbTipoReportes_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoReportes.TextChanged
        CargarReportes()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmReporteadorNomina_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        gpAvance.Left = (Me.Width - gpAvance.Size.Width) / 2
        pnlCentrarControles.Left = (Me.Width - pnlCentrarControles.Size.Width) / 2
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        BuscaReporte = EliminaAcentos(txtBusca.Text.Trim)
        CargarReportes()
    End Sub
End Class