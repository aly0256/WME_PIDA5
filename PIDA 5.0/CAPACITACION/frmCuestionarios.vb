﻿Public Class frmCuestionarios
#Region "Declaraciones"
    Dim dtLista As New DataTable        'Lista de datos para grid
    Dim dtRegistro As New DataTable     'Mantiene el registro actual
    Dim colListaRespuestas As New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Dim dtPreguntas As New DataTable

    Dim DesdeGrid As Boolean
    Dim Editar As Boolean
    Dim Agregar As Boolean

    Dim IDPreguntas As String
    Dim IDAnt As String
    Dim dtCambios As New DataTable
    Dim AgregarPregunta As Boolean = False
#End Region

    Private Sub frmCuestionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtLista = sqlExecute("SELECT cod_cuestionario as 'Código',Nombre FROM cuestionarios", "CAPACITACION")
        dtLista.DefaultView.Sort = "Código"
        dgTabla.DataSource = dtLista
        dgTabla.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        dtRegistro = sqlExecute("SELECT TOP 1 * FROM cuestionarios ORDER BY cod_cuestionario ASC ", "CAPACITACION")

        'Agregar datos a columna combo de tipo de respuestas
        'Esta configuración no se puede agregar en modo de edición, solo en código
        colListaRespuestas.DataSource = sqlExecute("SELECT cod_respuesta,RTRIM(nombre) AS nombre FROM tipos_respuestas ORDER BY nombre", "CAPACITACION")
        colListaRespuestas.ValueMember = "cod_respuesta"
        colListaRespuestas.DisplayMember = "nombre"
        colListaRespuestas.DataPropertyName = "cod_respuesta"
        colListaRespuestas.Name = "colTipoRespuesta"
        colListaRespuestas.Width = 150
        colListaRespuestas.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'colRespuesta.AutoCompleteSource = AutoCompleteSource.ListItems
        colListaRespuestas.DropDownStyle = ComboBoxStyle.DropDownList
        colListaRespuestas.HeaderText = "Tipo de respuesta"
        dgCuestionario.Columns.Add(colListaRespuestas)
        '***********************************************************************
        MostrarInformacion()

        Exit Sub
ErrLoad:
        MessageBox.Show(Err.Number & ".- " & Err.Description)
    End Sub
    Private Sub HabilitarBotones()
        Dim NoRec As Boolean
        NoRec = dgTabla.Rows.Count = 0
        btnPrimero.Enabled = Not (Agregar Or Editar Or NoRec)
        btnAnterior.Enabled = Not (Agregar Or Editar Or NoRec)
        btnSiguiente.Enabled = Not (Agregar Or Editar Or NoRec)
        btnUltimo.Enabled = Not (Agregar Or Editar Or NoRec)

        btnReporte.Enabled = Not (Agregar Or Editar Or NoRec)
        btnBuscar.Enabled = Not (Agregar Or Editar Or NoRec)
        btnBorrar.Enabled = Not (Agregar Or Editar Or NoRec)
        btnCerrar.Enabled = Not (Agregar Or Editar Or NoRec)
        pnlDatos.Enabled = Agregar Or Editar

        btnEditar.Enabled = Not (Not (Editar Or Agregar) And NoRec)

        If Agregar Or Editar Then
            ' Si está activa la edición o nuevo registro
            btnNuevo.Image = My.Resources.Ok16
            btnEditar.Image = My.Resources.CancelX
            btnNuevo.Text = "Aceptar"
            btnEditar.Text = "Cancelar"
            tabBuscar.SelectedTabIndex = 0
        Else

            btnNuevo.Image = My.Resources.NewRecord
            btnEditar.Image = My.Resources.Edit

            btnNuevo.Text = "Agregar"
            btnEditar.Text = "Editar"
        End If

        txtCodigo.Enabled = Agregar

        If Agregar Then
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtCodigo.Focus()
        ElseIf Editar Then
            txtNombre.Focus()
        End If
    End Sub
    Private Sub MostrarInformacion()
        Dim i As Integer

        Try

            If dtRegistro.Rows.Count > 0 And Not Agregar Then

                txtCodigo.Text = dtRegistro.Rows(0).Item("cod_cuestionario")
                txtNombre.Text = IIf(IsDBNull(dtRegistro.Rows(0).Item("nombre")), "", dtRegistro.Rows(0).Item("nombre").ToString.Trim)
                btnRecertificacion.Value = IIf(IsDBNull(dtRegistro.Rows(0).Item("recertificacion")), False, dtRegistro.Rows(0).Item("recertificacion"))
                intDias.Value = IIf(IsDBNull(dtRegistro.Rows(0).Item("tiempo_recertificacion")), 0, dtRegistro.Rows(0).Item("tiempo_recertificacion"))
                btnPromediar.Value = IIf(IsDBNull(dtRegistro.Rows(0).Item("promediar")), 0, dtRegistro.Rows(0).Item("promediar"))
            Else
                txtCodigo.Text = ""
                txtNombre.Text = ""
                btnRecertificacion.Value = False
                btnPromediar.Value = True
                intDias.Value = 0
            End If

            dtPreguntas = sqlExecute("SELECT cod_pregunta,RTRIM(pregunta) AS pregunta,titulo,preguntas.cod_respuesta," & _
                                     "RTRIM(tipos_respuestas.nombre) AS respuesta,ubicacion,calificacion_minima,participa_promedio FROM " & _
                                     "preguntas LEFT JOIN tipos_respuestas ON preguntas.cod_respuesta = tipos_respuestas.cod_respuesta " & _
                                     "WHERE cod_cuestionario = '" & txtCodigo.Text & "' ORDER BY ubicacion", "CAPACITACION")
            dgCuestionario.DataSource = dtPreguntas

            dgCuestionario.Columns.Remove("respuesta")
            dgCuestionario.Columns("colPromedio").Visible = btnPromediar.Value

            'sbpPreguntas.SubItems.Clear()
            'Dim itPreg As DevComponents.DotNetBar.ButtonItem

            'dtPreguntas = sqlExecute("SELECT cod_pregunta,pregunta,titulo FROM preguntas WHERE cod_cuestionario = '" & txtCodigo.Text & "'", "CAPACITACION")
            'For Each dPreg As DataRow In dtPreguntas.Rows
            '    itPreg = New DevComponents.DotNetBar.ButtonItem
            '    itPreg.FontBold = (dPreg("titulo") = 1)
            '    itPreg.Text = IIf(dPreg("titulo") = 1, "", vbTab) & dPreg("cod_pregunta") & " - " & dPreg("pregunta").ToString.Trim
            '    itPreg.Tag = dPreg("cod_pregunta")
            '    sbpPreguntas.SubItems.Add(itPreg)
            'Next
            If Not DesdeGrid Then
                i = dtLista.DefaultView.Find(txtCodigo.Text)
                If i >= 0 Then
                    dgTabla.FirstDisplayedScrollingRowIndex = i
                    dgTabla.Rows(i).Selected = True
                End If
            End If
            DesdeGrid = False
            CrearDTCambios()
            HabilitarBotones()

        Catch ex As Exception
            Stop
        End Try

    End Sub

    Private Sub btnCiasCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim Cod As String
        Cod = Buscar("capacitacion.dbo.cuestionarios", "cod_cuestionario", "estado cuestionarios", False)
        If Cod <> "CANCELAR" Then
            dtRegistro = sqlExecute("SELECT * FROM cuestionarios WHERE cod_cuestionario = '" & Cod & "' ", "CAPACITACION")
            MostrarInformacion()
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Primero("cuestionarios", "cod_cuestionario", dtregistro, "CAPACITACION")
        MostrarInformacion()
    End Sub

    Private Sub btnCiasPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        Anterior("cuestionarios", "cod_cuestionario", txtCodigo.Text, dtregistro, "CAPACITACION")
        MostrarInformacion()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Siguiente("cuestionarios", "cod_cuestionario", txtCodigo.Text, dtregistro, "CAPACITACION")
        MostrarInformacion()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Codigo = txtCodigo.Text
        dtTemporal = sqlExecute("SELECT * FROM tipo_ausentismo WHERE cod_cuestionario = '" & Codigo & "'", "CAPACITACION")
        If dtTemporal.Rows.Count > 0 Then
            MessageBox.Show("No puede borrarse un registro que se encuentre asignado a algún ausentismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("¿Está seguro de borrar el registro " & Codigo & "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sqlExecute("DELETE FROM cuestionarios WHERE cod_cuestionario = '" & Codigo & "'", "CAPACITACION")
                btnSiguiente.PerformClick()
            End If
        End If
    End Sub

    Private Sub dgTabla_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTabla.RowEnter
        On Error Resume Next

        Dim cod As String, nom As String

        DesdeGrid = True

        cod = dgTabla.Item("Código", e.RowIndex).Value
        nom = dgTabla.Item("Nombre", e.RowIndex).Value
        dtRegistro = sqlExecute("SELECT * FROM cuestionarios WHERE cod_cuestionario = '" & cod & "'", "CAPACITACION")
        MostrarInformacion()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        If Not Editar And Not Agregar Then
            Editar = True
            HabilitarBotones()
            txtNombre.Focus()
        Else
            Editar = False
        End If
        Agregar = False
        MostrarInformacion()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Ultimo("cuestionarios", "cod_cuestionario", dtregistro, "CAPACITACION")
        MostrarInformacion()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim CambioEfectuado As Boolean
        CambioEfectuado = True
        If Agregar Then
            ' Si Agregar, revisar si existe cod_cuestionario
            dtTemporal = sqlExecute("SELECT cod_cuestionario FROM cuestionarios where cod_cuestionario = '" & txtCodigo.Text & "'", "CAPACITACION")
            If dtTemporal.Rows.Count > 0 Then
                MessageBox.Show("El registro no se puede agregar, ya existe el nivel '" & txtCodigo.Text & "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigo.Focus()
                Exit Sub
            Else
                sqlExecute("INSERT INTO cuestionarios (cod_cuestionario) VALUES ('" & txtCodigo.Text & "')", "CAPACITACION")
            End If
        End If

        If Editar Or Agregar Then
            ' Si Editar, entonces guardar cambios a registro
            sqlExecute("UPDATE cuestionarios SET nombre = '" & txtNombre.Text & "'," & _
                       "recertificacion = " & IIf(btnRecertificacion.Value, 1, 0) & "," & _
                       "tiempo_recertificacion= " & intDias.Value & "," & _
                       "promediar = " & IIf(btnPromediar.Value, 1, 0) & _
                       " WHERE cod_cuestionario = '" & txtCodigo.Text & "'", "CAPACITACION")
            If ActualizarCambiosPreguntas() = False Then
                Exit Sub
            End If
            Agregar = False
        Else
            Agregar = True
        End If
        Editar = False

        dtRegistro = sqlExecute("SELECT * FROM cuestionarios WHERE cod_cuestionario = '" & txtCodigo.Text & "' ", "CAPACITACION")
        MostrarInformacion()

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        frmVistaPrevia.LlamarReporte("NaturalezaAusentismo", Nothing)
        frmVistaPrevia.ShowDialog()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_Validated(sender As Object, e As EventArgs) Handles txtCodigo.Validated
        If Editar Or Agregar Then
            txtCodigo.Text = txtCodigo.Text.Trim.PadLeft(txtCodigo.MaxLength, "0")
        End If
    End Sub

    'Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
    '    Dim itPreg As DevComponents.DotNetBar.ButtonItem
    '    Dim dtPreg As New DataTable
    '    strSeleccionado = "AGREGAR@C" & txtCodigo.Text
    '    If frmPreguntas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        dtPreg = sqlExecute("SELECT pregunta,titulo FROM preguntas WHERE cod_pregunta = '" & strSeleccionado & "'", "CAPACITACION")
    '        itPreg = New DevComponents.DotNetBar.ButtonItem
    '        itPreg.Text = strSeleccionado & " - " & dtPreg.Rows(0).Item("pregunta").ToString.Trim
    '        itPreg.Tag = strSeleccionado
    '        itPreg.FontBold = dtPreg.Rows(0).Item("titulo") = 1
    '        'sbPreguntas.SubItems.Add(itPreg)
    '        'sbPreguntas.Refresh()
    '    End If

    'End Sub

    Private Sub pnlDatos_Click(sender As Object, e As EventArgs) Handles pnlDatos.Click

    End Sub

    Private Sub expPanel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgCuestionario_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgCuestionario.CellBeginEdit
        If IsDBNull(dgCuestionario.Item("unico", e.RowIndex).Value) Then
            IDPreguntas = ""
        Else
            IDPreguntas = dgCuestionario.Item("unico", e.RowIndex).Value
        End If
        IDAnt = IIf(IsDBNull(dgCuestionario.Item(e.ColumnIndex, e.RowIndex).Value), "", dgCuestionario.Item(e.ColumnIndex, e.RowIndex).Value)

    End Sub

    'Private Sub MostrarPregunta(ByVal NumPregunta As String)
    '    Try
    '        Dim dtPregunta As New DataTable
    '        Dim drPregunta As DataRow
    '        dtPregunta = sqlExecute("SELECT * FROM preguntas WHERE cod_pregunta = '" & NumPregunta & "'", "CAPACITACION")
    '        drPregunta = dtPregunta.Rows(0)
    '        txtCodPregunta.Text = drPregunta("cod_pregunta")
    '        txtPregunta.Text = IIf(IsDBNull(drPregunta("pregunta")), "", drPregunta("pregunta")).ToString.Trim
    '        btntitulo.Value = IIf(IsDBNull(drPregunta("titulo")), 0, drPregunta("titulo")) = 1
    '        'If IsDBNull(drPregunta("cod_respuesta")) Then
    '        '    cmbRespuesta.SelectedIndex = -1
    '        'Else
    '        '    cmbRespuesta.SelectedValue = IIf(IsDBNull(drPregunta("cod_respuesta")), "", drPregunta("cod_respuesta")).ToString.Trim
    '        'End If

    '        ' HabilitarBotones()
    '    Catch ex As Exception
    '        Debug.Print(ex.Message)
    '        txtCodigo.Text = ""
    '        txtNombre.Text = ""
    '    End Try
    'End Sub

    Private Sub dgCuestionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuestionario.CellContentClick

    End Sub

    Private Sub dgCuestionario_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuestionario.CellEndEdit
        Dim NewVal As String
        Dim ID As String
        Dim dR As DataRow
        Static NvoID As Integer = 999000
        Try
            NvoID = NvoID + 1

            ID = IIf(IsDBNull(dgCuestionario.Item("unico", e.RowIndex).Value), NvoID, dgCuestionario.Item("unico", e.RowIndex).Value)

            NewVal = IIf(IsDBNull(dgCuestionario.Item(e.ColumnIndex, e.RowIndex).Value), "", dgCuestionario.Item(e.ColumnIndex, e.RowIndex).Value)

            If IDAnt <> NewVal Then
                dR = dtCambios.Rows.Find(ID)
                If IsNothing(dR) Then
                    dR = dtCambios.NewRow
                    dR("unico") = IIf(IDPreguntas = "", NvoID, IDPreguntas)
                    dR("movimiento") = IIf(AgregarPregunta, "A", "C")
                    dtCambios.Rows.Add(dR)
                End If
                dR.Item("cod_pregunta") = dgCuestionario.Item("ColCodigo", e.RowIndex).Value
                dR.Item("pregunta") = dgCuestionario.Item("ColPregunta", e.RowIndex).Value
                dR.Item("cod_respuesta") = dgCuestionario.Item("colTipoRespuesta", e.RowIndex).Value
                dR.Item("titulo") = dgCuestionario.Item("coltitulo", e.RowIndex).Value
                dR.Item("ubicacion") = dgCuestionario.Item("colUbicacion", e.RowIndex).Value
                dR.Item("calificacion_minima") = dgCuestionario.Item("colCalificacion", e.RowIndex).Value
                dR.Item("participa_promedio") = dgCuestionario.Item("colPromedio", e.RowIndex).Value

                AgregarPregunta = False
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, Err.Number, ex.Message)
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub dgCuestionario_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuestionario.CellEnter

    End Sub

    Private Sub dgCuestionario_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgCuestionario.CellFormatting
        'Dim drv As DataRowView
        Try
            Dim Fnt As Font
            Fnt = dgCuestionario.RowTemplate.DefaultCellStyle.Font
            If e.RowIndex >= 0 Then
                If IIf(IsDBNull(dgCuestionario.Item("Coltitulo", e.RowIndex).Value), False, dgCuestionario.Item("Coltitulo", e.RowIndex).Value) Then
                    e.CellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                End If
            End If

        Catch ex As Exception
            Stop
            Debug.Print(ex.Message)
        End Try
    End Sub
    Private Sub dgCuestionario_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgCuestionario.UserAddedRow
        AgregarPregunta = True
    End Sub

    Private Sub dgCuestionario_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgCuestionario.UserDeletingRow
        Dim Indice As String
        Dim dR As DataRow
        Try
            Indice = dgCuestionario.Item("colCodigo", e.Row.Index).Value
            If MessageBox.Show("¿Está seguro de borrar el registro " & Indice & "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                dR = dtCambios.Rows.Find(Indice)
                If IsNothing(dR) Then
                    If IsNothing(dR) Then
                        dR = dtCambios.NewRow
                        dR("unico") = IIf(IDPreguntas = "", Indice, IDPreguntas)
                        dR("movimiento") = "B"
                        dtCambios.Rows.Add(dR)
                    End If
                Else
                    dR.Item("MOVIMIENTO") = "B"
                End If
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, Err.Number, ex.Message)
            Debug.Print(ex.Message)
            e.Cancel = True
        End Try
    End Sub

    Private Function ActualizarCambiosPreguntas() As Boolean
        Dim M As String
        Dim ID As String

        Try
            For Each dCambio As DataRow In dtCambios.Rows
                M = dCambio("movimiento")
                ID = dCambio("unico")
                If IIf(IsDBNull(dCambio("cod_pregunta")), "", dCambio("cod_pregunta")).ToString.Length = 0 And M <> "B" Then
                    MessageBox.Show("El código de pregunta no puede quedar en blanco, favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Select Case M
                    Case "A"
                        If sqlExecute("SELECT cod_pregunta FROM preguntas WHERE cod_pregunta = '" & dCambio("cod_pregunta") & "'", "CAPACITACION").Rows.Count > 0 Then
                            MessageBox.Show("La pregunta " & dCambio("cod_pregunta") & " se encuentra duplicada. Favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                        sqlExecute("INSERT INTO preguntas (cod_cuestionario,cod_pregunta,cod_respuesta,pregunta,titulo,ubicacion) " & _
                                   "VALUES ('" & txtCodigo.Text & "','" & _
                                   IIf(IsDBNull(dCambio("cod_pregunta")), "", dCambio("cod_pregunta").ToString.ToUpper) & "','" & _
                                   IIf(IsDBNull(dCambio("cod_respuesta")), "", dCambio("cod_respuesta")) & "','" & _
                                   IIf(IsDBNull(dCambio("pregunta")), "", dCambio("pregunta")) & "'," & _
                                   IIf(IsDBNull(dCambio("titulo")), 0, dCambio("titulo")) & "," & _
                                   IIf(IsDBNull(dCambio("ubicacion")), 0, dCambio("ubicacion")) & ")", "CAPACITACION")
                    Case "B"
                        sqlExecute("DELETE FROM preguntas WHERE cod_pregunta = '" & ID & "'", "CAPACITACION")
                    Case "C"
                        Dim dtActualiza As New DataTable
                        Dim Pregunta As String
                        Pregunta = IIf(IsDBNull(dCambio("pregunta")), "", dCambio("pregunta")).ToString.Trim
                        Pregunta = Pregunta.Replace("'", "''")
                        dtActualiza = sqlExecute("UPDATE preguntas SET " & _
                                   "cod_cuestionario = '" & txtCodigo.Text & "'," & _
                                   "cod_pregunta = '" & IIf(IsDBNull(dCambio("cod_pregunta")), "", dCambio("cod_pregunta").ToString.ToUpper) & "'," & _
                                   "cod_respuesta = '" & IIf(IsDBNull(dCambio("cod_respuesta")), "", dCambio("cod_respuesta")) & "'," & _
                                   "pregunta = '" & Pregunta & "'," & _
                                   "titulo = " & IIf(IsDBNull(dCambio("titulo")), 0, dCambio("titulo")) & "," & _
                                   "calificacion_minima = " & IIf(IsDBNull(dCambio("calificacion_minima")), 0, dCambio("calificacion_minima")) & "," & _
                                   "participa_promedio = " & IIf(IsDBNull(dCambio("participa_promedio")), 0, dCambio("participa_promedio")) & "," & _
                                   "ubicacion = " & IIf(IsDBNull(dCambio("ubicacion")), 0, dCambio("ubicacion")) & _
                                   " WHERE cod_pregunta  = '" & ID & "'", "CAPACITACION")
                        If dtActualiza.Columns.Count = 1 Then
                            MessageBox.Show("La pregunta " & dCambio("cod_pregunta") & " no pudo ser guardada, se detectó un error. Favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dtCambios.Rows.Remove(dCambio)
                            Return False
                        End If

                End Select
            Next
            Return True
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, Err.Number, ex.Message)
            Debug.Print(ex.Message)
            Return False
        End Try
    End Function

    Private Function CrearDTCambios() As Boolean
        Try
            dtCambios = New DataTable("CambiosAuxiliares")
            dtCambios = dtPreguntas.Clone
            dtCambios.Columns.Add("unico")
            dtCambios.Columns.Add("movimiento")
            dtCambios.PrimaryKey = New DataColumn() {dtCambios.Columns("unico")}
            Return True
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, Err.Number, ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnRecertificacion_ValueChanged(sender As Object, e As EventArgs) Handles btnRecertificacion.ValueChanged
        intDias.Enabled = btnRecertificacion.Value
    End Sub

    Private Sub btnPromediar_ValueChanged(sender As Object, e As EventArgs) Handles btnPromediar.ValueChanged
        dgCuestionario.Columns("colPromedio").Visible = btnPromediar.Value

    End Sub
End Class