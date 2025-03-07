﻿Imports Microsoft.Reporting.WinForms
Imports System.Xml
Public Class frmReporteadorAUS
    Dim dtReportes As New DataTable
    Dim Acumulado As String
    Dim NombreReporte As String = ""
    Dim BuscaReporte As String = ""
    Dim UltimaActualizacion As Date
    Dim dtTemp As New DataTable
    Dim LocalRangoFInicial As Date
    Dim LocalRangoFFinal As Date

    Public Function FiltrosAcumulados() As String
        Dim FL As String = ""
        Dim i As Integer

        Try
            lstFiltros.Items.Clear()
            For i = 0 To NFiltros - 1
                FL = FL & IIf(i > 0, " AND (", "(") & Filtros(2, i) & ")"
                lstFiltros.Items.Add(Filtros(2, i))
            Next
            'If FL.Length > 0 Then
            '    FL = " WHERE " & FL
            'End If
        Catch ex As Exception
            FL = "ERROR"
        End Try

        Return FL & IIf(FL.Trim = "", FiltroXUsuario, " AND " & FiltroXUsuario)
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

    Private Sub frmReporteadorAUS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NFiltros = 0
        Me.Dispose()
    End Sub

    Private Sub frmReporteadorAUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtPersonalVW As New DataTable
        Try
            'MCR 4/NOV/2015
            'Tomar fecha/hora de última actualización de datos
            UltimaActualizacion = Now
            'Guardar valores de rango de fechas para usar en bitácora
            'Ya que son variables globales que se utilizan en otras formas
            LocalRangoFInicial = RangoFInicial
            LocalRangoFFinal = RangoFFinal
            '***************************************************

            lblFechas.Text = FechaCortaLetra(RangoFInicial) & " A " & FechaCortaLetra(RangoFFinal)

            'Dim _campos_AUS As String = "*"
            'Dim dtquery As DataTable = sqlExecute("select * from kiosco.dbo.variables where variable = 'QUERY_AUS'")
            'If dtquery.Rows.Count > 0 Then
            ' _campos_AUS = dtquery.Rows(0)("valor")
            ' End If

            'dtResultadoAUS = sqlExecute("SELECT " & _campos_AUS & " FROM AUSENTISMOVW WHERE FECHA between '" & FechaSQL(RangoFInicial) & "' and '" & FechaSQL(RangoFFinal) & _
            '                          "'", "ta")

            dtResultadoAUS = sqlExecute("Select * from reporteador_ausentismo WHERE FECHA between '" & FechaSQL(RangoFInicial) & "' and '" & FechaSQL(RangoFFinal) & "' ORDER BY RELOJ", "TA")

            chkRecientes.Text = "Ver últimos 10 reportes utilizados por el usuario " & Usuario.ToUpper
            chkRecientes.Checked = False
            txtActivos.Value = RangoFFinal
            txtBajas.Value = RangoFFinal

            Acumulado = FiltrosAcumulados()

            'MCR 5/NOV/2015
            'No considerar los tipos de reporte de Time Allocation (S = TAlloc creados por usuario, T = Generales de TAlloc)
            cmbTipoReportes.DataSource = sqlExecute("SELECT * FROM tipo_reportes WHERE tipo NOT IN ('S','T') ORDER BY tipo", "TA")
            cmbTipoReportes.SelectedValue = "X"

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkBajas_CheckedChanged(sender As Object, e As EventArgs) Handles chkBajas.CheckedChanged
        Try
            Dim I As Integer = -1
            If chkBajas.Checked Then
                chkActivos.Checked = False
                chkTodos.Checked = False
                txtBajas.Focus()

            Else
                'Actualiza lista de filtros
                Dim x As Integer

                For x = 0 To NFiltros - 1
                    If Filtros(1, x) = "BAJAS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstFiltros.Items.RemoveAt(I)

                For x = I To NFiltros - 1
                    Filtros(1, x) = Filtros(1, x + 1)
                    Filtros(2, x) = Filtros(2, x + 1)
                Next
                NFiltros = NFiltros - 1
                ReDim Preserve Filtros(2, x)
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
                txtActivos.Focus()
            Else
                'Actualiza lista de filtros
                Dim x As Integer

                For x = 0 To NFiltros - 1
                    If Filtros(1, x) = "ACTIVOS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstFiltros.Items.RemoveAt(I)

                For x = I To NFiltros - 1
                    Filtros(1, x) = Filtros(1, x + 1)
                    Filtros(2, x) = Filtros(2, x + 1)
                Next
                NFiltros = NFiltros - 1
                ReDim Preserve Filtros(2, x)
            End If
            chkTodos.Checked = Not (chkActivos.Checked Or chkBajas.Checked Or chkOtrosFiltros.Checked)
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try
            If chkTodos.Checked Then
                chkActivos.Checked = False
                chkBajas.Checked = False
                chkOtrosFiltros.Checked = False
                lstFiltros.Items.Clear()
                NFiltros = 0
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

            'MCR 3/NOV/2015
            'Estandarizar y dejar de utilizar TAA, solamente TA como identificador de Time&Attendance
            'Dentro de perfiles, TimeAllocation está junto a Time&Attendance
            If chkRecientes.Checked Then
                Cadena = "SELECT RTRIM(reportes.NOMBRE) AS NOMBRE,reportes.TIPO," & _
                    "(100*VECES_ACCESO)/((SELECT MAX(veces_acceso) FROM reportes)+1) AS 'Frecuencia'," & _
                    "reportes_recientes.FECHA,FILTRAR,username FROM REPORTES RIGHT JOIN reportes_recientes ON " & _
                    "reportes.nombre = reportes_recientes.nombre WHERE reportes_recientes.usuario = '" & _
                    Usuario & "' AND reportes.NOMBRE IN " & _
                    "(SELECT CONTROL FROM SEGURIDAD.dbo.PERMISOS WHERE " & IIf(FiltrarTipo, " reportes.tipo='" & cmbTipoReportes.SelectedValue & "' AND ", "") & _
                    " cod_perfil " & Perfil & " AND permisos.modulo = 'TA'  and permisos.acceso = 1)" & _
                   IIf(BuscaReporte.Length = 0, "", " AND dbo.EliminaAcentos(reportes.nombre) LIKE '%" & BuscaReporte & "%' ") & _
                    "ORDER BY reportes_recientes.fecha DESC,nombre"
            Else
                Cadena = "SELECT RTRIM(reportes.NOMBRE) AS NOMBRE,reportes.TIPO," & _
                    "(100*VECES_ACCESO)/((SELECT MAX(veces_acceso) FROM reportes)+1) AS Frecuencia,reportes.FECHA,FILTRAR,username " & _
                    "FROM REPORTES WHERE reportes.INDIVIDUAL = 2 AND reportes.NOMBRE IN " & _
                    "(SELECT CONTROL FROM SEGURIDAD.dbo.PERMISOS WHERE " & IIf(FiltrarTipo, " reportes.tipo='" & cmbTipoReportes.SelectedValue & "' AND ", "") & _
                    IIf(FiltrarTipo, " reportes.tipo='" & cmbTipoReportes.SelectedValue & "' AND ", " NOT reportes.tipo IN ('S','T') AND ") & _
                    " cod_perfil " & Perfil & " AND permisos.modulo = 'TA' and permisos.acceso = 1)" & _
                    IIf(BuscaReporte.Length = 0, "", " AND dbo.EliminaAcentos(reportes.nombre) LIKE '%" & BuscaReporte & "%' ") & _
                    " ORDER BY reportes.nombre"
            End If
            dtReportes = New DataTable
            dtReportes = sqlExecute(Cadena, "ta")
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
                'Actualiza lista de Orden
                If NOrden < 0 Then NOrden = 0
                For x = 0 To NOrden - 1
                    If Orden(1, x) = "RELOJ" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NOrden
                    NOrden = NOrden + 1

                    If UBound(Orden, 2) < NOrden Then
                        ReDim Preserve Orden(2, NOrden)
                    End If
                End If

                Orden(1, I) = "RELOJ"
                Orden(2, I) = TipoOrden

                lstOrden.Items.Clear()
                For x = 0 To NOrden - 1
                    lstOrden.Items.Add(Orden(1, x) & " (" & Orden(2, x) & ")")
                Next
                chkNombre.Checked = False
                sbReloj.Focus()
            Else
                'Actualiza lista de orden


                For x = 0 To NOrden - 1
                    If Orden(1, x) = "RELOJ" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstOrden.Items.RemoveAt(I)

                For x = I To NOrden - 1
                    Orden(1, x) = Orden(1, x + 1)
                    Orden(2, x) = Orden(2, x + 1)
                Next
                NOrden = NOrden - 1
                ReDim Preserve Orden(2, x)
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
                'Actualiza lista de Orden
                If NOrden < 0 Then NOrden = 0
                For x = 0 To NOrden - 1
                    If Orden(1, x) = "NOMBRES" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NOrden
                    NOrden = NOrden + 1

                    If UBound(Orden, 2) < NOrden Then
                        ReDim Preserve Orden(2, NOrden)
                    End If
                End If

                Orden(1, I) = "NOMBRES"
                Orden(2, I) = TipoOrden

                lstOrden.Items.Clear()
                For x = 0 To NOrden - 1
                    lstOrden.Items.Add(Orden(1, x) & " (" & Orden(2, x) & ")")
                Next

                chkReloj.Checked = False
                sbReloj.Focus()
            Else
                'Actualiza lista de orden

                For x = 0 To NOrden - 1
                    If Orden(1, x) = "NOMBRES" Then
                        I = x
                        Exit For
                    End If
                Next

                If I < 0 Then Exit Sub
                lstOrden.Items.RemoveAt(I)

                For x = I To NOrden - 1
                    Orden(1, x) = Orden(1, x + 1)
                    Orden(2, x) = Orden(2, x + 1)
                Next
                NOrden = NOrden - 1
                ReDim Preserve Orden(2, x)
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
            Dim x As Integer
            frmFiltroAUS.ShowDialog(Me)
            Acumulado = FiltrosAcumulados()

            chkOtrosFiltros.Checked = NFiltros > 0

            Filtro = ""
            lstFiltros.Items.Clear()
            For x = 0 To NFiltros - 1
                lstFiltros.Items.Add(Filtros(2, x))
            Next
            If x = 0 Then
                chkTodos.Checked = True
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub txtActivos_Validated(sender As Object, e As EventArgs) Handles txtActivos.Validated
        Try
            Dim Filtro As String
            Dim I As Integer = -1
            If chkActivos.Checked Then
                'chkBajas.Checked = False
                'txtActivos.Focus()
                Filtro = " ALTA <= '" & FechaSQL(txtActivos.Value) & "' AND (BAJA IS NULL OR BAJA > '" & FechaSQL(txtActivos.Value) & "')"


                'Actualiza lista de filtros

                For x = 0 To NFiltros - 1
                    If Filtros(1, x) = "ACTIVOS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NFiltros
                    NFiltros = NFiltros + 1

                    If UBound(Filtros, 2) < NFiltros Then
                        ReDim Preserve Filtros(2, NFiltros)
                    End If
                End If

                Filtros(1, I) = "ACTIVOS"
                Filtros(2, I) = Filtro

                Filtro = ""
                lstFiltros.Items.Clear()
                For x = 0 To NFiltros - 1
                    lstFiltros.Items.Add(Filtros(2, x))
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

        EncabezadoReporte = lblFechas.Text.Trim
        FiltroReporte = FiltrosAUSAcumulados()
        OrdenReporte = OrdenAcumulado()

        'MCR 4/NOV/2015
        'Revisar bitácora por cambios desde última actualización de datos
        ConsultaBitacora(dtResultadoAUS, UltimaActualizacion)

        My.Application.DoEvents()
        'bgwReporte.RunWorkerAsync()

        bgwReporte_DoWork()
        bgwReporte_RunWorkerCompleted()
    End Sub

    Private Function FiltrosAUSAcumulados() As String
        Dim FL As String = ""
        Dim i As Integer
        Try
            lstFiltros.Items.Clear()
            For i = i To NFiltros - 1
                FL = FL & IIf(i > 0, " AND (", "(") & Filtros(2, i) & ")"
                lstFiltros.Items.Add(Filtros(2, i))
            Next
            'If FL.Length > 0 Then
            '    FL = " WHERE " & FL
            'End If
        Catch ex As Exception
            FL = "ERROR"
        End Try

        Return FL & IIf(FL.Trim = "", FiltroXUsuario, IIf(FiltroXUsuario.Trim <> "", " AND " & FiltroXUsuario, ""))
    End Function

    Private Sub Mientras()
        Dim dtReporte As New DataTable
        Dim r As Integer
        Dim i As Integer
        Dim Tipo As String
        Try
            r = dgReportes.CurrentCell.RowIndex
            If r < 0 Then Exit Sub
            NombreReporte = dgReportes.Item("nombre", r).Value
            Tipo = dgReportes.Item("tipo", r).Value

            dtTemporal = sqlExecute("UPDATE reportes SET veces_acceso = veces_acceso + 1, fecha = GETDATE()   WHERE nombre = '" & NombreReporte.Trim & "'", "TA")

            dtTemporal = sqlExecute("SELECT COUNT(nombre) AS cuantos FROM reportes_recientes WHERE usuario = '" & Usuario & "'", "TA")
            If dtTemporal.Rows.Item(0).Item("cuantos") = 10 Then
                dtTemporal = sqlExecute("DELETE FROM reportes_recientes WHERE fecha = (SELECT MIN(fecha) FROM reportes_recientes WHERE usuario = '" & Usuario & "') AND usuario = '" & Usuario & "'", "TA")
            End If

            dtTemporal = sqlExecute("SELECT nombre FROM reportes_recientes WHERE usuario = '" & Usuario & "' AND nombre = '" & NombreReporte.Trim & "'", "TA")
            If dtTemporal.Rows.Count > 0 Then
                dtTemporal = sqlExecute("UPDATE reportes_recientes SET fecha = GETDATE() WHERE usuario = '" & Usuario & "' AND nombre = '" & NombreReporte.Trim & "'", "TA")
            Else
                dtTemporal = sqlExecute("INSERT INTO reportes_recientes (usuario,fecha,nombre) VALUES ('" & Usuario & "',GETDATE(), '" & NombreReporte & "')", "TA")
            End If

            FiltroReporte = FiltrosAcumulados()
            OrdenReporte = OrdenAcumulado()

            Dim dtResultadoTAFiltro As New DataSet
            dtResultadoTAFiltro.Merge(dtResultadoTA.Select(FiltroReporte))

            If dtResultadoTAFiltro.Tables.Count = 0 Then
                dtFiltroTA = New DataTable
            Else
                dtFiltroTA = dtResultadoTAFiltro.Tables(0)
                dtResultadoTAFiltro.Tables(0).TableName = "TA"
                dtFiltroTA.DefaultView.Sort = OrdenReporte
            End If

            If Tipo = "U" Then
                dtDisponibles = sqlExecute("SELECT UPPER(cod_campo) AS campo,upper(left(nombre,1)) + lower(substring(nombre,2,75)) AS nombre,tipo FROM campos ORDER BY nombre", "TA")
                'MCR 3/NOV/2015
                'Estandarizar y dejar de utilizar TAA, solamente TA como identificador de Time&Attendance
                ReporteadorFuente = "TA"
                dtReporte = sqlExecute("SELECT * FROM reportes WHERE nombre = '" & NombreReporte.Trim & "'", "TA")
                If dtReporte.Rows.Count < 1 Then Exit Sub
                frmVistaPrevia.ReporteDinamico(dtReporte.Rows(0), dtFiltroTA, NombreReporte)
            Else

                frmVistaPrevia.LlamarReporte(NombreReporte, dtFiltroTA)
                frmVistaPrevia.ShowDialog()
            End If

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
        End Try
    End Sub



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
        frmOrden.ShowDialog()


        i = NOrden
        lstOrden.Items.Clear()
        For x = 0 To NOrden - 1
            lstOrden.Items.Add(Orden(1, x) & " (" & Orden(2, x) & ")")
            If Orden(1, x) = "RELOJ" Then
                r = True
                sbReloj.Value = Orden(2, x) = "ASC"
                chkReloj.Checked = True
                i = i - 1
            ElseIf Orden(1, x) = "NOMBRES" Then
                n = True
                sbReloj.Value = Orden(2, x) = "ASC"
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
        Me.Close()
        Me.Dispose()
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


                For x = i To NOrden - 1
                    Orden(1, x) = Orden(1, x + 1)
                    Orden(2, x) = Orden(2, x + 1)
                Next
                NOrden = NOrden - 1
                ReDim Preserve Orden(2, x)

                lstOrden.Items.Clear()
                For x = 0 To NOrden - 1
                    lstOrden.Items.Add(Orden(1, x) & "(" & Orden(2, x) & ")")
                Next
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub lstOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrden.SelectedIndexChanged

    End Sub

    Private Sub txtBajas_Validated(sender As Object, e As EventArgs) Handles txtBajas.Validated
        Try
            Dim Filtro As String
            Dim I As Integer = -1
            If chkBajas.Checked Then
                'chkBajas.Checked = False
                'txtActivos.Focus()
                Filtro = " BAJA <= '" & FechaSQL(txtActivos.Value) & "' AND NOT BAJA IS NULL"


                'Actualiza lista de filtros

                For x = 0 To NFiltros - 1
                    If Filtros(1, x) = "BAJAS" Then
                        I = x
                        Exit For
                    End If
                Next

                If I = -1 Then
                    I = NFiltros
                    NFiltros = NFiltros + 1

                    If UBound(Filtros, 2) < NFiltros Then
                        ReDim Preserve Filtros(2, NFiltros)
                    End If
                End If

                Filtros(1, I) = "BAJAS"
                Filtros(2, I) = Filtro

                Filtro = ""
                lstFiltros.Items.Clear()
                For x = 0 To NFiltros - 1
                    lstFiltros.Items.Add(Filtros(2, x))
                    'Filtro = Filtro & IIf(Filtro.Length = 0, "", " AND ") & Filtros(2, x)
                Next
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
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

            'Inicializar campos disponibles
            dtDisponibles = New DataTable
            dtDisponibles = sqlExecute("SELECT UPPER(cod_campo) AS campo,upper(left(nombre,1)) + lower(substring(nombre,2,75)) AS nombre,tipo FROM campos ORDER BY nombre", "TA")
            'MCR 3/NOV/2015
            'Estandarizar y dejar de utilizar TAA, solamente TA como identificador de Time&Attendance
            ReporteadorFuente = "TA"
            frmCrearReporteDinamico.ShowDialog()

            'Revisar si se seleccionó CANCELAR
            If dtReporteDinamico.Columns.Count = 0 Then Exit Sub

            drInfoReporte = dtReporteDinamico.Rows(0)
            dtReportes.ImportRow(drInfoReporte)
            dtReportes.AcceptChanges()

            Titulo = drInfoReporte("nombre").ToString.Trim

            FiltroReporte = FiltrosAcumulados()
            OrdenReporte = OrdenAcumulado()

            If FiltroReporte.ToUpper.Contains("COD_COMP") Then
                'Si no se incluye filtro, tomar el primero de la tabla
                i = FiltroReporte.ToUpper.IndexOf("COD_COMP")
                f = FiltroReporte.ToUpper.IndexOf(")", i)

                c = FiltroReporte.ToUpper.Substring(i, f - i + 1)

                dtCompa = sqlExecute("SELECT COD_COMP, RTRIM(NOMBRE) AS NOMBRE, RFC, REG_PAT, INFONAVIT, LOGO, GUIA, DIRECCION, COLONIA, CIUDAD, ESTADO, COD_POSTAL, TELEFONO1, REP_LEGAL ,PUESTO FROM personal.dbo.cias WHERE " & c)

            Else
                dtCompa = sqlExecute("SELECT TOP 1 COD_COMP,RTRIM(NOMBRE) AS NOMBRE,RFC,REG_PAT,INFONAVIT,LOGO,GUIA FROM personal.dbo.cias WHERE cia_default = 1")
            End If

            dtCampos = sqlExecute("select upper(cod_campo) as campo,nombre,tipo FROM campos", "TA")
            dtCampos.PrimaryKey = New DataColumn() {dtCampos.Columns("campo")}


            Campos = Split(IIf(IsDBNull(drInfoReporte("campos")), "", drInfoReporte("campos")), ",")
            Grupo1 = IIf(IsDBNull(drInfoReporte("grupo1")), "", drInfoReporte("grupo1").ToString.Trim)
            Grupo2 = IIf(IsDBNull(drInfoReporte("grupo2")), "", drInfoReporte("grupo2").ToString.Trim)
            Grupo3 = IIf(IsDBNull(drInfoReporte("grupo3")), "", drInfoReporte("grupo3").ToString.Trim)
            MostrarDetalle = IIf(IsDBNull(drInfoReporte("mostrar_detalle")), 0, drInfoReporte("mostrar_detalle"))
            MostrarResumen = IIf(IsDBNull(drInfoReporte("mostrar_resumen")), 0, drInfoReporte("mostrar_resumen"))


            Dim dtResultadoTAFiltro As New DataSet
            dtResultadoTAFiltro.Merge(dtResultadoTA.Select(FiltroReporte))

            If dtResultadoTAFiltro.Tables.Count = 0 Then
                dtFiltroTA = New DataTable
            Else
                dtFiltroTA = dtResultadoTAFiltro.Tables(0)
                dtResultadoTAFiltro.Tables(0).TableName = "TA"
                dtFiltroTA.DefaultView.Sort = OrdenReporte
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

            For Each dRow As DataRow In dtFiltroTA.Rows
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

                    dtDatos.Rows.Add({dRow("reloj"), dr("nombre").ToString.Trim, Valor, G1, G2, G3})
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
            frmVistaPrevia.Show(Me)

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try

    End Sub

    Private Sub dgReportes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportes.CellClick
        Try
            Dim r As Integer
            r = e.RowIndex
            If r < 0 Then Exit Sub
            gpFiltros.Enabled = IIf(IsDBNull(dgReportes.Item("FILTRAR", r).Value), Enabled, dgReportes.Item("FILTRAR", r).Value)
            pnlRango.Visible = IIf(IsDBNull(dgReportes.Item("FILTRAR", r).Value), Enabled, dgReportes.Item("FILTRAR", r).Value)
        Catch ex As Exception
            gpFiltros.Enabled = True
            pnlRango.Visible = True
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
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
            If MessageBox.Show("¿Está seguro de eliminar el reporte " & NombreReporte & "?", "Borrar reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dtTemporal = sqlExecute("DELETE FROM reportes WHERE nombre = '" & NombreReporte.Trim & "'", "TA")
                dgReportes.Rows.RemoveAt(dgReportes.CurrentCell.RowIndex)
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub cmbTipoReportes_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoReportes.TextChanged
        CargarReportes()
    End Sub

    'Private Sub bgwReporte_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwReporte.DoWork
    Private Sub bgwReporte_DoWork()
        Dim dtReporte As New DataTable
        Dim r As Integer
        'Dim i As Integer
        Dim Tipo As String
        Try
            r = dgReportes.CurrentCell.RowIndex
            If r < 0 Then Exit Sub
            NombreReporte = dgReportes.Item("nombre", r).Value.ToString.Trim
            'bgwReporte.ReportProgress(0, NombreReporte)

            Tipo = dgReportes.Item("tipo", r).Value

            sqlExecute("UPDATE reportes SET veces_acceso = veces_acceso + 1, fecha = GETDATE()   WHERE nombre = '" & NombreReporte.Trim & "'", "ta")

            dtTemporal = sqlExecute("SELECT COUNT(nombre) AS cuantos FROM reportes_recientes WHERE usuario = '" & Usuario & "'", "ta")
            If dtTemporal.Rows.Item(0).Item("cuantos") = 10 Then
                sqlExecute("DELETE FROM reportes_recientes WHERE fecha = (SELECT MIN(fecha) FROM reportes_recientes WHERE usuario = '" & _
                           Usuario & "') AND usuario = '" & Usuario & "'", "ta")
            End If

            dtTemporal = sqlExecute("SELECT nombre FROM reportes_recientes WHERE usuario = '" & Usuario & "' AND nombre = '" & _
                                    NombreReporte.Trim & "'", "ta")
            If dtTemporal.Rows.Count > 0 Then
                sqlExecute("UPDATE reportes_recientes SET fecha = GETDATE() WHERE usuario = '" & Usuario & "' AND nombre = '" & _
                           NombreReporte.Trim & "'", "ta")
            Else
                sqlExecute("INSERT INTO reportes_recientes (usuario,fecha,nombre) VALUES ('" & Usuario & "',GETDATE(),'" & NombreReporte.Trim & "')", _
                           "ta")
            End If

            dtFiltroPersonal = dtResultadoAUS.Clone
            For Each dR As DataRow In dtResultadoAUS.Select(FiltroReporte, OrdenReporte)
                dtFiltroPersonal.ImportRow(dR)
            Next


            Dim compania_filtro As String = ""
            Try
                Dim i_ As Integer
                Dim f As Integer

                If FiltroReporte.ToUpper.Contains("COD_COMP") Then
                    'Si no se incluye filtro, tomar el primero de la tabla
                    i_ = FiltroReporte.ToUpper.IndexOf("COD_COMP")
                    f = FiltroReporte.ToUpper.IndexOf(")", i_)

                    compania_filtro = FiltroReporte.ToUpper.Substring(i_, f - i_ + 1)

                    Dim dtCompa As DataTable = sqlExecute("SELECT COD_COMP, NOMBRE, RFC, REG_PAT, INFONAVIT, LOGO, GUIA, DIRECCION, COLONIA, CIUDAD, ESTADO, COD_POSTAL, TELEFONO1, REP_LEGAL ,PUESTO FROM personal.dbo.cias WHERE " & compania_filtro)
                    If dtCompa.Rows.Count > 0 Then
                        compania_filtro = dtCompa.Rows(0)("cod_comp")
                    Else
                        compania_filtro = ""
                    End If

                ElseIf FiltroReporte.ToUpper.Contains("COMPANIA") Then
                    'Si no se incluye filtro, tomar el primero de la tabla
                    i_ = FiltroReporte.ToUpper.IndexOf("COMPANIA")
                    f = FiltroReporte.ToUpper.IndexOf(")", i_)

                    compania_filtro = FiltroReporte.ToUpper.Substring(i_, f - i_ + 1)
                    compania_filtro = compania_filtro.Replace("COMPANIA", "NOMBRE")

                    Dim dtCompa As DataTable = sqlExecute("SELECT COD_COMP, NOMBRE, RFC, REG_PAT, INFONAVIT, LOGO, GUIA, DIRECCION, COLONIA, CIUDAD, ESTADO, COD_POSTAL, TELEFONO1, REP_LEGAL ,PUESTO FROM personal.dbo.cias WHERE " & compania_filtro)
                    If dtCompa.Rows.Count > 0 Then
                        compania_filtro = dtCompa.Rows(0)("cod_comp")
                    Else
                        compania_filtro = ""
                    End If
                End If
            Catch ex As Exception
                ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
            End Try

            If Tipo = "U" Then
                dtDisponibles = sqlExecute("SELECT UPPER(cod_campo) AS campo,personal.dbo.IniciaMayuscula(nombre) AS nombre,tipo " & _
                                           "FROM campos_AUS ORDER BY nombre", "TA")
                'MCR 3/NOV/2015
                'Estandarizar y dejar de utilizar TAA, solamente TA como identificador de Time&Attendance
                ReporteadorFuente = "TA"
                dtReporte = sqlExecute("SELECT * FROM reportes WHERE nombre = '" & NombreReporte & "'", "ta")
                If dtReporte.Rows.Count < 1 Then Exit Sub
                frmVistaPrevia.ReporteDinamico(dtReporte.Rows(0), dtFiltroPersonal, NombreReporte)
            ElseIf Tipo = "X" Then
                PreparaDatos(NombreReporte, dtFiltroPersonal)
            Else
                frmVistaPrevia.LlamarReporte(NombreReporte.Trim, dtFiltroPersonal, compania_filtro)
                'bgwReporte.ReportProgress(100)
                frmVistaPrevia.Show(Me)
            End If

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub bgwReporte_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwReporte.ProgressChanged
        lblAvance.Text = "... PREPARANDO ..." & vbCrLf & CType(e.UserState, String)
        If e.ProgressPercentage = 100 Then
            gpAvance.Visible = False
            pbAvance.IsRunning = False
        End If
    End Sub

    'Private Sub bgwReporte_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporte.RunWorkerCompleted
    Private Sub bgwReporte_RunWorkerCompleted()
        Try
            Dim r As Integer = 0

            CargarReportes()
            For I = 0 To dgReportes.Rows.Count - 1
                If dgReportes.Item("nombre", I).Value = NombreReporte Then
                    r = I
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

    Private Sub frmReporteadorTA_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        gpAvance.Left = (Me.Width - gpAvance.Size.Width) / 2
        pnlCentrarControles.Left = (Me.Width - pnlCentrarControles.Size.Width) / 2
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        BuscaReporte = EliminaAcentos(txtBusca.Text.Trim)
        CargarReportes()
    End Sub

    ''' <summary>
    ''' Proceso para actualizar datos antes de ejecutar reporte MCR (4/NOV/2015)
    ''' </summary>
    Private Function ConsultaBitacora(ByVal dtTabla As DataTable, ByVal FechaTope As Date) As Boolean
        Dim dtBitacora As New DataTable
        Dim dtAsist As New DataTable
        Dim dRow As DataRow
        Dim dSeleccionados() As DataRow

        Try
            'Buscar en asist, los números de reloj que se hayan analizado a partir de la última actualización, 
            'y que pertenezcan al rango de fechas del reporteador
            dtAsist = sqlExecute("SELECT DISTINCT reloj FROM asist WHERE " & _
                                 "fha_ent_hor BETWEEN '" & FechaSQL(LocalRangoFInicial) & "' AND '" & FechaSQL(LocalRangoFFinal) & _
                                 "' AND RTRIM(RTRIM(CONVERT(char,fecha,121)) +' ' + hora) >= '" & FechaHoraSQL(UltimaActualizacion, True, False) & "'", _
                                 "ta")
            For Each dRow In dtAsist.Rows
                'Buscar los registros ya integrados al datatable, que estén entre los modificados
                dSeleccionados = dtTabla.Select("reloj = '" & dRow("reloj").ToString.Trim & "'")
                For Each dSel As DataRow In dSeleccionados
                    'Borrar los registros del empleado que se haya modificado
                    'Considerando que algunos registros se agregan, otros se eliminan cuando se analiza en TA
                    dtTabla.Rows.Remove(dSel)
                Next

                'Tomar nuevamente todos los datos del empleado, en el rango de fechas
                dtBitacora = sqlExecute("SELECT * FROM TAVW WHERE " & _
                                        "RELOJ= '" & dRow("RELOJ") & "' AND " & _
                                        "fha_ent_hor between '" & FechaSQL(LocalRangoFInicial) & "' AND '" & FechaSQL(LocalRangoFFinal) & "'", "TA")

                For Each dRec As DataRow In dtBitacora.Rows
                    'Importar cada registro en el rango
                    dtTabla.ImportRow(dRec)
                Next
            Next

            'Tomar fecha/hora de última actualización de datos
            UltimaActualizacion = Now

            Return True
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
            Return False
        End Try
    End Function
End Class