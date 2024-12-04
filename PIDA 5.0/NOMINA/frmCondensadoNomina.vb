Public Class frmCondensadoNomina

    Dim Acumulado As String
    Dim AnoPerListados As String = ""

    Dim _ano_condensado As String = ""
    Dim _periodo_condensado As String = ""

    Dim directorio_archivos As String = ""

    Dim prefijo As String = ""

    Private Sub CargarReportesCondensado(tipo As String)
        'Cargar reportes condensado
        Try
            Dim dtReportes As DataTable = sqlExecute("select * from condensado where activo = 1 and (tipo = 'T' or tipo = '" & tipo & "') order by orden", "nomina")
            dgvCondensado.AutoGenerateColumns = False
            dgvCondensado.DataSource = dtReportes
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmCondensadoNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim dtCondensado As DataTable = sqlExecute("select * from condensado", "nomina")
            If dtCondensado.Rows.Count <= 0 Then
                MessageBox.Show("El condensado de nómina no está disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If

            If PeriodosReporteador.Count > 1 Then
                MessageBox.Show("Por favor seleccione solamente un periodo para el condensado de nómina", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If

            directorio_archivos = My.Computer.FileSystem.SpecialDirectories.Desktop

            Dim tipo As String = PeriodosReporteador(0).Substring(6, 1)

            CargarReportesCondensado(tipo)
            TipoPerSelec = tipo

            dtNominaCondensado = New DataTable

            bgw.WorkerReportsProgress = True
            bgwGenerar.WorkerReportsProgress = True


            'Utilizar el OVER para que el máximo no sea por grupo, sino en general           

            'Dim drow As DataRow
            Dim ArchivoFoto As String = ""
            Dim dtTemp As New DataTable

            gpAvance.Visible = True
            pbAvance.IsRunning = True

            Me.Cursor = Cursors.WaitCursor

            ' Application.DoEvents()
            If CiaReporteador = "***" Then
                CiaReporteador = ""
                lblCia.Text = "CONSOLIDADO"
            Else
                dtTemp = sqlExecute("SELECT nombre FROM cias WHERE cod_comp = '" & CiaReporteador & "'")
                prefijo &= CiaReporteador.Trim & Space(1)

                lblCia.Text = RTrim(dtTemp.Rows(0).Item("nombre"))
                CiaReporteador = "''" & CiaReporteador.Trim & "''"



            End If

            bgw.WorkerReportsProgress = True
            bgwGenerar.WorkerReportsProgress = True

            For Each I In PeriodosReporteador
                lstPeriodos.Items.Add(I.Substring(0, 4) & "-" & I.Substring(4, 2) & "-" & I.Substring(6, 1))
                AnoPerListados = AnoPerListados & IIf(AnoPerListados.Length > 0, ", ", "") & I.Substring(0, 4) & "-" & I.Substring(4, 2)
            Next


            directorio_archivos = My.Computer.FileSystem.SpecialDirectories.Desktop
            'If PeriodosReporteador.Length > 0 Then

            '    prefijo &= PeriodosReporteador(0) & Space(1)

            '    directorio_archivos &= "\Reportes\" & PeriodosReporteador(0).Substring(0, 4) & "\" & PeriodosReporteador(0).Substring(4, 2) & "\"
            '    If Not IO.Directory.Exists(directorio_archivos) Then
            '        IO.Directory.CreateDirectory(directorio_archivos)
            '    End If
            TextBox1.Text = directorio_archivos.Trim & "\"
            'End If


            AnoPerListados = IIf(AnoPerListados.Contains(","), "PERIODOS ", "PERIODO ") & AnoPerListados

            My.Application.DoEvents()
            bgw.RunWorkerAsync()

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        Finally
            'gpAvance.Visible = False
            'pbAvance.IsRunning = False
        End Try
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork
        Dim A As String
        Dim P As String
        Dim T As String

        dtNominaCondensado = Nothing
        Try

            For Each I In PeriodosReporteador
                A = I.Substring(0, 4)
                P = I.Substring(4, 2)
                T = I.Substring(6, 1)

                _ano_condensado = A
                _periodo_condensado = P

                bgw.ReportProgress(0, "... CARGANDO ..." & vbCrLf & "Nómina " & I)
                dtResultadoNomina = sqlExecute("EXEC ReporteadorNominaTipoPeriodo @Cia = '" & CiaReporteador & "',@ano = '" & A & "', @periodo = '" & P & _
                                         "',@Nivel = '" & NivelConsulta & "', @reloj = '', @TipoPeriodo = '" & T & "'", "nomina")
                dtResultadoNomina.Columns.Add("periodos")

                If IsNothing(dtNominaCondensado) Then
                    dtNominaCondensado = dtResultadoNomina.Clone
                End If

                If dtResultadoNomina.Rows.Count = 0 Then
                    Exit Sub
                End If

                Dim perc As Integer = 0
                For Each dRow As DataRow In dtResultadoNomina.Rows
                    '.Select(FiltroXUsuario)
                    bgw.ReportProgress(Math.Truncate(perc / dtResultadoNomina.Rows.Count), "Reloj " & dRow.Item("reloj"))
                    Application.DoEvents()

                    dtResultado.ImportRow(dRow)
                    perc += 1
                Next
                dtNominaCondensado.Merge(dtResultadoNomina)
            Next

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub bgwGenerar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwGenerar.DoWork
        Try
            For Each row As DataGridViewRow In dgvCondensado.Rows

                Dim id_formato As String = row.Cells("ColumnFormato").Value
                Dim incluir As Boolean = row.Cells("ColumnGenerar").Value
                Dim reporte As String = row.Cells("ColumnNombre").Value


                bgwGenerar.ReportProgress(0, reporte.Trim)

                If incluir Then
                    Dim dtInfoFormato As DataTable = sqlExecute("select * from condensado where id_formato = '" & id_formato.Trim & "'", "nomina")
                    If dtInfoFormato.Rows.Count > 0 Then

                        Dim id_reporte As String = RTrim(dtInfoFormato(0)("id_reporte"))
                        Dim filtro As String = RTrim(dtInfoFormato.Rows(0)("filtro"))
                        Dim detalle_reporte As String = RTrim(dtInfoFormato.Rows(0)("archivo"))
                        Dim detalle_reporte_2 As String = RTrim(dtInfoFormato.Rows(0)("detalle"))

                        Dim extension As String = RTrim(dtInfoFormato.Rows(0)("extension"))

                        Dim dtReporte As DataTable = sqlExecute("select * from reportes where id_reporte = '" & id_reporte & "'", "nomina")
                        If dtReporte.Rows.Count > 0 Then
                            Dim nombre_reporte As String = RTrim(dtReporte.Rows(0)("nombre"))

                            'CondensadoGenerar(nombre_reporte, id_reporte, filtro, prefijo & id_formato.Trim & Space(1) & reporte, detalle_reporte)
                            CondensadoGenerar(nombre_reporte, id_reporte, filtro, prefijo & id_formato.Trim & Space(1) & reporte, extension, detalle_reporte, detalle_reporte_2)
                        Else
                            MessageBox.Show("No se encontró el reporte especificado: " & id_reporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                    Else
                        MessageBox.Show("No se encontró el formato especificado: " & reporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                My.Application.DoEvents()

            Next
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw.ProgressChanged
        lblAvance.Text = CType(e.UserState, String)
    End Sub

    Private Sub bgwGenerar_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwGenerar.ProgressChanged
        lblAvance.Text = CType(e.UserState, String)
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        habilitar_interfaz()
    End Sub

    Private Sub bgwGenerar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGenerar.RunWorkerCompleted
        habilitar_interfaz()
        Process.Start("explorer.exe", directorio_archivos)
    End Sub

    Private Sub habilitar_interfaz()
        pbAvance.IsRunning = False
        gpAvance.Visible = False
        btnGenerar.Enabled = True
        cbTodo.Enabled = True
        btnSalir.Enabled = True
        btnDirectorio.Enabled = True
        dgvCondensado.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try

            btnDirectorio.PerformClick()

            btnGenerar.Enabled = False
            cbTodo.Enabled = False
            btnSalir.Enabled = False
            btnDirectorio.Enabled = False
            dgvCondensado.Enabled = False
            gpAvance.Visible = True
            pbAvance.IsRunning = True
            Me.Cursor = Cursors.WaitCursor

            EncabezadoReporte = AnoPerListados

            Dim EncabezadoReporteTMP As String = EncabezadoReporte.Replace("PERIODOS", "PERIODO").Replace("PERIODO", "").Trim

            bgwGenerar.RunWorkerAsync()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CondensadoGenerar(reporte As String, id_reporte As String, filtro As String, nombre_archivo_reporte As String, extension As String, Optional detalle_reporte As String = "", Optional detalle_reporte_2 As String = "")
        Dim dtReporte As New DataTable

        Try

            dtFiltroPersonal = dtNominaCondensado.Clone
            For Each dR As DataRow In dtNominaCondensado.Select(filtro)
                dtFiltroPersonal.ImportRow(dR)
            Next
            nombre_archivo_reporte = directorio_archivos & _ano_condensado & _periodo_condensado & Space(1) & nombre_archivo_reporte.Trim & "." & extension

            detalle_reporte = detalle_reporte.Replace("[directorio]", directorio_archivos)

            frmVistaPrevia.LlamarReporte(reporte, dtFiltroPersonal, CiaReporteador.Replace("''", ""), {detalle_reporte, _ano_condensado, _periodo_condensado, detalle_reporte_2}, False, nombre_archivo_reporte)

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnDirectorio.Click
        Try
            Dim fbd As New FolderBrowserDialog
            fbd.SelectedPath = directorio_archivos
            If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
                directorio_archivos = fbd.SelectedPath.Trim & "\"
            End If

            TextBox1.Text = directorio_archivos

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbTodo_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodo.CheckedChanged
        Try
            For Each row As DataGridViewRow In dgvCondensado.Rows
                row.Cells("ColumnGenerar").Value = IIf(cbTodo.Checked, 1, 0)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class