﻿Public Class frmPrestamoGlobalH
    Dim dtArticulos As New DataTable

    Private Sub frmPrestamoGlobalH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Value = Today
        dtArticulos = sqlExecute("SELECT articulos.COD_ART as 'Código',articulos.NOMBRE as 'Nombre',articulos.COD_CLAS as 'Código clasificación',clasificacion.nombre as 'Clasificación' FROM  articulos LEFT JOIN clasificacion on articulos.COD_CLAS = clasificacion.COD_CLAS", "HERRAMIENTAS")
        cmbHerramientas.DataSource = dtArticulos
        ' frmReporteadorHerramientas.Close()

    End Sub
    Private Sub btnBuscaArchivo_Click(sender As Object, e As EventArgs) Handles btnBuscaArchivo.Click
        Dim Archivo As String
        Dim dlgArchivo As New OpenFileDialog
        dlgArchivo.Multiselect = False
        dlgArchivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Try
            Dim lDialogResult As DialogResult = dlgArchivo.ShowDialog()
            If lDialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                Archivo = dlgArchivo.FileName
            End If

            If System.IO.File.Exists(Archivo) = False Then
                MessageBox.Show("El archivo '" & Archivo & "' no existe. Favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            txtArchivo.Text = Archivo
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
        End Try

    End Sub
    Private Sub btnBuscaLista_Click(sender As Object, e As EventArgs) Handles btnBuscaLista.Click
        Dim FL As String = ""
        ' Dim Temporal1, Temporal2 As String
        Dim filtros_temp(2, NFiltros) As String
        Dim nFiltros_temp As Integer

        nFiltros_temp = NFiltros
        NFiltros = 0
        If nFiltros_temp > 0 Then
            For i = 0 To nFiltros_temp - 1
                filtros_temp(1, i) = Filtros(1, i)
                filtros_temp(2, i) = Filtros(2, i)
                '**********************
                'Temporal1 = 
                'Temporal2 = 
                'filtros_temp(1, i) = Temporal1
                'filtros_temp(2, i) = Temporal2
            Next
        End If
        If nFiltros_temp > 0 Then
            For i = 0 To nFiltros_temp - 1
                Filtros(1, i) = Nothing
                Filtros(2, i) = Nothing
            Next
        End If
        frmTrabajando.Show(Me)
        frmTrabajando.Avance.Value = 0
        frmTrabajando.Avance.IsRunning = False
        frmTrabajando.lblAvance.Text = "Preparando datos..."
        Application.DoEvents()
        'dtResultado = sqlExecute("EXEC MaestroPersonal @Nivel = " & NivelConsulta & ", @Reloj = ''")
        dtResultado = ConsultaPersonalVW("SELECT RELOJ AS 'RELOJ',NOMBRES AS 'Nombre',* FROM personalVW WHERE BAJA IS NULL")

        frmTrabajando.Avance.IsRunning = True

        'For Each dRow As DataRow In dtResultado.Rows
        '    frmTrabajando.lblAvance.Text = "Reloj " & dRow.Item("reloj")
        '    Application.DoEvents()

        '    dRow.Item("sactual") = IIf(IIf(IsDBNull(dRow.Item("nivel_seguridad")), 0, dRow.Item("nivel_seguridad")) <= NivelSueldos, dRow.Item("sactual"), 0)
        '    dRow.Item("integrado") = IIf(IIf(IsDBNull(dRow.Item("nivel_seguridad")), 0, dRow.Item("nivel_seguridad")) <= NivelSueldos, dRow.Item("integrado"), 0)
        '    dRow.Item("pro_var") = IIf(IIf(IsDBNull(dRow.Item("nivel_seguridad")), 0, dRow.Item("nivel_seguridad")) <= NivelSueldos, dRow.Item("pro_var"), 0)
        '    dRow.Item("factor_int") = IIf(IIf(IsDBNull(dRow.Item("nivel_seguridad")), 0, dRow.Item("nivel_seguridad")) <= NivelSueldos, dRow.Item("factor_int"), 0)
        '    dRow.Item("sal_ant") = IIf(IIf(IsDBNull(dRow.Item("nivel_seguridad")), 0, dRow.Item("nivel_seguridad")) <= NivelSueldos, dRow.Item("sal_ant"), 0)
        'Next
        ActivoTrabajando = False

        frmTrabajando.Close()
        frmTrabajando.Dispose()
        frmFiltroGlobal.ShowDialog()
        If NFiltros > 0 Then
            Dim i As Integer
            Try
                For i = 0 To NFiltros - 1
                    FL = FL & IIf(i > 0, " AND (", "(") & Filtros(2, i) & ")"
                Next
                dtTemporal = consultapersonalvw("SELECT RELOJ from personalvw WHERE " & FL & " AND BAJA IS NULL")
                FL = ""
                For i = 0 To dtTemporal.Rows.Count - 1
                    FL = FL & IIf(i > 0, ",", "") & dtTemporal.Rows.Item(i).Item("Reloj")
                Next
                txtLista.Text = FL
                NFiltros = 0
            Catch ex As Exception
                FL = "ERROR"
            End Try
        End If
        If NFiltros > 0 Then
            For i = 0 To NFiltros - 1
                Filtros(1, i) = ""
                Filtros(2, i) = ""
            Next
        End If
        If nFiltros_temp > 0 Then
            For i = 0 To nFiltros_temp - 1
                Filtros(1, i) = filtros_temp(1, i)
                Filtros(2, i) = filtros_temp(2, i)
            Next
        End If
        NFiltros = nFiltros_temp
    End Sub
    Private Sub btnArchivo_CheckedChanged(sender As Object, e As EventArgs) Handles btnArchivo.CheckedChanged
        btnBuscaArchivo.Enabled = btnArchivo.Checked
        txtArchivo.Enabled = btnArchivo.Checked
        txtLista.Enabled = btnLista.Checked
        btnBuscaLista.Enabled = btnLista.Checked
        If btnArchivo.Checked Then
            txtArchivo.Focus()
        End If
    End Sub

    Private Sub btnLista_CheckedChanged(sender As Object, e As EventArgs) Handles btnLista.CheckedChanged
        btnBuscaArchivo.Enabled = btnArchivo.Checked
        txtArchivo.Enabled = btnArchivo.Checked
        txtLista.Enabled = btnLista.Checked
        btnBuscaLista.Enabled = btnLista.Checked
        If btnLista.Checked Then
            txtLista.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtTemp As New DataTable
        Dim dtArticulo As New DataTable
        Dim dtEmpleado As New DataTable
        Dim ArLista() As String
        Dim ArErrores(,) As String
        Dim FechaReemplazo As Date
        Dim ArticulosDisponibles As Integer
        Dim ArticulosSolicitados As Integer
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim d As Integer
        Dim Archivo As String = ""
        Dim objReader As System.IO.StreamReader = Nothing
        Dim LN As String
        Dim CodigoArticulo As String = ""
        Try
            If Math.Abs(DateDiff(DateInterval.Day, txtFecha.Value, Today)) > 15 Then
                MessageBox.Show("La diferencia entre la fecha de préstamo y el día de hoy, no puede ser mayor a 15 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFecha.Focus()
                Exit Sub
            End If
            If btnArchivo.Checked Then
                Archivo = txtArchivo.Text
                If System.IO.File.Exists(Archivo) = False Then
                    MessageBox.Show("El archivo '" & Archivo & "' no existe. Favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                objReader = New System.IO.StreamReader(Archivo)
                x = 0
                y = objReader.BaseStream.Length
                cpActualizacion.Maximum = 100
                cpActualizacion.Visible = True
                Application.DoEvents()
                ReDim ArLista(1000)

                Do Until objReader.EndOfStream
                    LN = objReader.ReadLine
                    ArLista(x) = LN.Substring(0, LN.Length)
                    x = x + 1
                    If UBound(ArLista) < x Then
                        ReDim Preserve ArLista(x)
                    End If
                Loop
                x = x - 1
                ReDim Preserve ArLista(x)
            Else
                ArLista = txtLista.Text.Split(",")
                x = ArLista.Length - 1
            End If
            ReDim ArErrores(x, 2)
            d = 0
            z = 0
            cpActualizacion.Maximum = x

            CodigoArticulo = cmbHerramientas.SelectedValue
            dtArticulo = sqlExecute("SELECT * FROM articulos WHERE COD_ART = '" & CodigoArticulo & "'", "HERRAMIENTAS")
            FechaReemplazo = txtFecha.Value.AddDays(dtArticulo.Rows(0).Item("DIAS_REP"))
            ArticulosDisponibles = dtArticulo.Rows(0).Item("IN_STOCK")
            ArticulosSolicitados = ArLista.Length * txtCantidad.Value

            If ArticulosSolicitados > ArticulosDisponibles Then
                MessageBox.Show("La cantidad de artículos a prestar es mayor a la cantidad disponible de articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For y = 0 To x
                    If ArLista(y).Length > LongReloj Then
                        Reloj = ArLista(y).Substring(0, LongReloj)
                    Else
                        Reloj = ArLista(y).PadLeft(LongReloj, "0")
                    End If

                    dtEmpleado = sqlExecute("SELECT BAJA from personalvw WHERE reloj = '" & Reloj & "'")
                    If dtEmpleado.Rows.Count = 0 Then
                        ArErrores(z, 0) = ArLista(y)
                        ArErrores(z, 1) = "Empleado no localizado"
                        z = z + 1
                    Else
                        If IsDBNull(dtEmpleado.Rows(0).Item("BAJA")) Then
                            cpActualizacion.Value = y
                            cpActualizacion.Text = Reloj
                            Application.DoEvents()
                            Dim hora As TimeSpan = DateTime.Now.TimeOfDay
                            sqlExecute("INSERT INTO articulos_por_empleado (ID,RELOJ,COD_ART,FECHA_SAL,FECHA_ENT,CONTROL,OBSERVACION,CANTIDAD,ENTREGADO) " & _
                                       "VALUES ('" & GenerarID() & "','" & Reloj & "','" & CodigoArticulo & "','" & FechaSQL(txtFecha.Value) & "','" & FechaSQL(FechaReemplazo) & _
                                       "','PM','Préstamo masivo'," & txtCantidad.Value & "," & IIf(dtArticulo.Rows(0).Item("DIAS_REP") = 0, 1, 0) & ")" _
                                       , "HERRAMIENTAS")
                            sqlExecute("UPDATE articulos SET IN_STOCK = IN_STOCK - " & txtCantidad.Value & ",OUT_STOCK = OUT_STOCK + " & _
                                       txtCantidad.Value & " WHERE COD_ART = '" & CodigoArticulo & "'", "HERRAMIENTAS")
                            d = d + 1
                        Else
                            ArErrores(z, 0) = ArLista(y)
                            ArErrores(z, 1) = "Empleado es baja"
                            z = z + 1
                        End If
                    End If
                Next
            End If
            cpActualizacion.Visible = False
            If z > 0 Then
                Dim Lista As String = ""
                For x = 0 To z - 1
                    Lista = Lista & vbCrLf & "  " & ArErrores(x, 0) & " " & ArErrores(x, 1)
                Next
                MessageBox.Show("Se detectaron errores durante la carga, estos empleados no se agregaron a la lista de préstamos: " & Lista, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If d > 0 Then
                MessageBox.Show(d.ToString & " de " & (x + 1).ToString & " empleados se agregaron CORRECTAMENTE a la lista de préstamos", "CORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



            txtArchivo.Clear()
            txtLista.Clear()
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
        End Try
    End Sub
    Private Function GenerarID() As String
        Return Date.Now.ToString.Replace(" ", "").Replace("/", "").Replace(".", "").Replace(":", "").Replace("PM", "").Replace("AM", "").Replace(",", "").Replace("pm", "").Replace("am", "")
    End Function
End Class