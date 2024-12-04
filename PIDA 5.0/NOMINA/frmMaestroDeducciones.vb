
Imports System.IO
Public Class frmMaestroDeducciones
    Dim Editar As Boolean = False
    Dim Agregar As Boolean = False


    ' Tablas
    Dim dtperiodos As New DataTable
    Dim dtInfoPersonal As New DataTable
    Dim dtconceptos As New DataTable
    Dim dtDeducciones As New DataTable
    Dim dtDed2 As New DataTable
    Dim dtSaldos As New DataTable

    Dim seleccionado As String
    Dim dtTemp As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlExecute("DELETE FROM mtro_ded where isnull(reloj,'')=''", "NOMINA")
        MostrarInformacion()
        HabilitarBotones()
    End Sub
    Public Sub HabilitarBotones()
        btnNext.Enabled = Not (Editar Or Agregar)
        btnFirst.Enabled = Not (Editar Or Agregar)
        btnLast.Enabled = Not (Editar Or Agregar)
        btnPrev.Enabled = Not (Editar Or Agregar)
        btnBorrar.Enabled = Not (Editar Or Agregar)
        btnCerrar.Enabled = Not (Editar Or Agregar)
        btnReporte.Enabled = Not (Editar Or Agregar)
        btnBuscar.Enabled = Not (Editar Or Agregar)
        dgMaestro.ReadOnly = Not (Editar Or Agregar)

        If Editar Or Agregar Then
            ' Si está activa la edición o nuevo registro
            btnNuevo.Image = My.Resources.Ok16
            btnEditar.Image = My.Resources.CancelX
            btnNuevo.Text = "Aceptar"
            btnEditar.Text = "Cancelar"
        Else
            btnNuevo.Image = My.Resources.NewRecord
            btnEditar.Image = My.Resources.Edit

            btnNuevo.Text = "Agregar"
            btnEditar.Text = "Editar"
        End If

    End Sub


    ''' <summary>
    ''' Proceso para regresar la información al fin del periodo, revisando la bitácora
    ''' </summary>
    Private Function ConsultaBitacora(ByRef dtPersonal As DataTable, Ano As String, Periodo As String) As Boolean
        Dim dtPeriodos As New DataTable
        Dim dtBitacora As New DataTable
        Dim FechaTopeIni As Date
        Dim FechaTopeFin As Date
        Dim FechaMto As Date

        Try
            dtPeriodos = sqlExecute("SELECT fecha_ini,fecha_fin,ano,periodo FROM periodos WHERE ano+periodo = '" & Ano & Periodo & "'", "TA")
            'Fechas topes para buscar en el mantenimiento, lo que se haya generado en los mantenimientos de ese rango
            'La fecha tope inicial es un día después del fin del periodo
            FechaTopeIni = DateAdd(DateInterval.Day, 1, dtPeriodos.Rows(0).Item("fecha_fin"))
            'Fecha tope final, es 3 días después del fin del periodo
            FechaTopeFin = DateAdd(DateInterval.Day, 3, dtPeriodos.Rows(0).Item("fecha_fin"))

            'Revisar en la bitácora cuando se hizo el último mantenimiento en el rango
            dtBitacora = sqlExecute("SELECT MAX(fecha_mantenimiento) AS fecha FROM bitacora_personal WHERE fecha_mantenimiento " & _
                                    "BETWEEN '" & FechaSQL(FechaTopeIni) & "' AND '" & FechaSQL(FechaTopeFin) & "'")
            If dtBitacora.Rows.Count = 0 Then
                FechaMto = Now.Date
            Else
                FechaMto = IIf(IsDBNull(dtBitacora.Rows(0).Item("fecha")), Now.Date, dtBitacora.Rows(0).Item("fecha"))
            End If

            'Realizar para cada registro de la tabla
            For Each dRow As DataRow In dtPersonal.Rows
                '... con cada columna
                For Each dCol As DataColumn In dtPersonal.Columns
                    '.... excepto con el reloj
                    If dCol.ColumnName.ToLower <> "reloj" Then
                        'buscar si hay movimientos efectuados entre el mantenimiento y la fecha actual, y regresa el más antiguo
                        dtBitacora = sqlExecute("SELECT TOP 1 ValorAnterior FROM bitacora_personal WHERE " & _
                                                "fecha BETWEEN '" & FechaHoraSQL(DateAdd(DateInterval.Second, 1, FechaMto)) & _
                                                "' AND '" & FechaHoraSQL(Now) & "'" & _
                                                " AND reloj = '" & dRow("reloj") & "' and campo = '" & dCol.ColumnName & _
                                                "' ORDER BY fecha")
                        If dtBitacora.Rows.Count > 0 Then
                            'Si hubo registro, pasar el valor anterior a la tabla, para regresar al punto del mantenimiento
                            dRow(dCol.ColumnName) = dtBitacora.Rows(0).Item("ValorAnterior")
                        End If
                    End If
                Next
            Next

            Return True
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
            Return False
        End Try
    End Function

    Public Sub MostrarInformacion(Optional ByVal rl As String = "")
        Dim ArchivoFoto As String
        Dim dRow As DataRow
        Dim Credito As String
        Try
            Dim QInfoPer As String = ""

            If rl = "" Then
                QInfoPer = "SELECT TOP 1 reloj,nombres,cod_tipo,cod_depto,cod_super,cod_clase,cod_turno,cod_hora, " & _
                                            "nombre_depto,nombre_turno,nombre_horario,nombre_tipoemp,nombre_clase,nombre_super,alta,baja  " & _
                                            "FROM personalVW ORDER BY reloj"

                dtInfoPersonal = ConsultaPersonalVW(QInfoPer)
            Else
                QInfoPer = "SELECT TOP 1 reloj,nombres,cod_tipo,cod_depto,cod_super,cod_clase,cod_turno,cod_hora, " & _
                            "nombre_depto,nombre_turno,nombre_horario,nombre_tipoemp,nombre_clase,nombre_super,alta,baja  " & _
                            "FROM personalVW WHERE reloj = '" & rl & "' ORDER BY reloj"

                dtInfoPersonal = ConsultaPersonalVW(QInfoPer)
            End If
            'ConsultaBitacora(dtInfoPersonal, "2013", "45")

            rl = IIf(IsDBNull(dtInfoPersonal.Rows.Item(0).Item("reloj")), "", dtInfoPersonal.Rows.Item(0).Item("reloj"))
            dRow = dtInfoPersonal.Rows(0)

            'Mostrar información
            txtReloj.Text = IIf(IsDBNull(dRow("reloj")), "", dRow("reloj"))
            txtNombre.Text = IIf(IsDBNull(dRow("nombres")), "", dRow("nombres"))

            txtAlta.Text = IIf(IsDBNull(dRow("alta")), Nothing, dRow("alta"))
            EsBaja = Not IsDBNull(dRow("baja"))
            txtBaja.Text = IIf(EsBaja, dRow("baja"), Nothing)

            txtTipoEmp.Text = IIf(IsDBNull(dRow("cod_tipo")), "", dRow("cod_tipo").ToString.Trim) & IIf(IsDBNull(dRow("nombre_tipoemp")), "", " (" & dRow("nombre_tipoemp").ToString.Trim & ")")
            txtDepto.Text = IIf(IsDBNull(dRow("cod_depto")), "", dRow("cod_depto").ToString.Trim) & IIf(IsDBNull(dRow("nombre_depto")), "", " (" & dRow("nombre_depto").ToString.Trim & ")")
            txtSupervisor.Text = IIf(IsDBNull(dRow("cod_super")), "", dRow("cod_super").ToString.Trim) & IIf(IsDBNull(dRow("nombre_super")), "", " (" & dRow("nombre_super").ToString.Trim & ")")
            txtClase.Text = IIf(IsDBNull(dRow("cod_clase")), "", dRow("cod_clase").ToString.Trim) & IIf(IsDBNull(dRow("nombre_clase")), "", " (" & dRow("nombre_clase").ToString.Trim & ")")
            txtTurno.Text = IIf(IsDBNull(dRow("cod_turno")), "", dRow("cod_turno").ToString.Trim) & IIf(IsDBNull(dRow("nombre_turno")), "", " (" & dRow("nombre_turno").ToString.Trim & ")")
            txtHorario.Text = IIf(IsDBNull(dRow("cod_hora")), "", dRow("cod_hora").ToString.Trim) & IIf(IsDBNull(dRow("nombre_horario")), "", " (" & dRow("nombre_horario").ToString.Trim & ")")

            ' *** PROCESO PARA CARGAR FOTOGRAFIA ***
            Try
                ArchivoFoto = PathFoto & rl & ".jpg"
                If Dir(ArchivoFoto) = "" Then
                    ArchivoFoto = PathFoto & "nofoto.png"
                End If

                'Dim ft As New Bitmap(ArchivoFoto)
                picFoto.Width = picFoto.MinimumSize.Width
                picFoto.Height = picFoto.MinimumSize.Height
                picFoto.Left = 900
                'picFoto.Image = ft
                picFoto.ImageLocation = ArchivoFoto
            Catch
                picFoto.Image = picFoto.ErrorImage
            End Try

            '****************************************

            '*** Cambios en bajas ****
            txtBaja.Visible = EsBaja
            lblBaja.Visible = EsBaja
            lblEstado.Text = IIf(EsBaja, "INACTIVO", "ACTIVO")
            lblEstado.BackColor = IIf(EsBaja, Color.IndianRed, Color.LimeGreen)
            txtReloj.BackColor = lblEstado.BackColor
            '*************************
            Dim QDeduc As String = "SELECT CONCEPTOS.CONCEPTO,RTRIM(CONCEPTOS.NOMBRE) AS NOMBRE,NUMCREDITO,PERIODO,ANO,SEMANAS_DESC," & _
                                       "SALDO_ORIG,ABONO_ORIG,TASA_INT_SEM, " & _
                                       "STATUS,RTRIM(COMENTARIO) AS COMENTARIO,RTRIM(DETALLE) AS DETALLE,SEM_TRANS,SEM_RESTAN,SALDO_ACT," & _
                                       "PRORRATEAR,ABONO_MES,SALDO_MES,PRORRATEAR_MES, " & _
                                       "ABONO_ACT,SEM_REST_MES FROM  " & _
                                       "MTRO_DED LEFT JOIN CONCEPTOS ON mtro_ded.CONCEPTO = CONCEPTOS.CONCEPTO  " & _
                                       "WHERE reloj = '" & rl & "' ORDER BY status DESC"

            dtDeducciones = sqlExecute(QDeduc, "Nomina")

            If dtDeducciones.Rows.Count > 0 Then dgMaestro.DataSource = dtDeducciones Else dgMaestro.DataSource = Nothing

            Dim Qdeduc2 As String = "SELECT CONCEPTOS.CONCEPTO,CONCEPTOS.NOMBRE,NUMCREDITO FROM  " & _
                           "MTRO_DED LEFT JOIN CONCEPTOS ON mtro_ded.CONCEPTO = CONCEPTOS.CONCEPTO  " & _
                           "WHERE reloj = '" & rl & "' ORDER BY status DESC"

            dtDed2 = sqlExecute(Qdeduc2, "Nomina")
            cbConcepto.DataSource = dtDeducciones

            Credito = IIf(cbConcepto.SelectedValue Is Nothing, "X", cbConcepto.SelectedValue)

            Dim QSaldos As String = "SELECT cast(ano as int) as ano,cast(periodo as int) AS periodo,concepto,saldo_act+abono_alc AS saldo_ant,abono_alc AS abono,saldo_act AS saldo," & _
                      "intereses_alc AS intereses,comentario FROM saldos_ca " & _
                      "WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & _
                      "' ORDER BY ano,periodo"
            dtSaldos = sqlExecute(QSaldos, "nomina")

            dgSaldos.DataSource = dtSaldos

            Exit Sub
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        dtTemp = ConsultaPersonalVW("SELECT TOP 1 reloj FROM personalVW ORDER BY reloj ASC ")
        If dtTemp.Rows.Count <> 0 Then
            MostrarInformacion(dtTemp.Rows(0).Item("reloj"))
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        dtTemp = ConsultaPersonalVW("SELECT TOP 1 reloj FROM personalVW  ORDER BY reloj DESC ")
        If dtTemp.Rows.Count <> 0 Then
            MostrarInformacion(dtTemp.Rows(0).Item("reloj"))
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        dtTemp = ConsultaPersonalVW("SELECT TOP 1 reloj FROM personalVW where reloj < '" & txtReloj.Text & "'  ORDER BY reloj DESC ")
        If dtTemp.Rows.Count = 0 Then
            btnFirst.PerformClick()
        Else
            MostrarInformacion(dtTemp.Rows(0).Item("reloj"))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dtTemp = ConsultaPersonalVW("SELECT TOP 1 reloj FROM personalVW where reloj > '" & txtReloj.Text & "'  ORDER BY reloj ASC ")
        If dtTemp.Rows.Count = 0 Then
            btnLast.PerformClick()
        Else
            MostrarInformacion(dtTemp.Rows(0).Item("reloj"))
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dtTemp = dtInfoPersonal
        Try
            frmBuscar.ShowDialog(Me)
            If Reloj <> "CANCEL" Then
                MostrarInformacion(Reloj)
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
            dtInfoPersonal = dtTemp
        End Try
    End Sub

    Private Sub dgMaestro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMaestro.CellEnter
        Dim Activo As Boolean
        Try
            Activo = dgMaestro.Item("ColActivo", e.RowIndex).Value
        Catch ex As Exception
            Activo = False
        End Try

        btnEditar.Enabled = Activo
        btnBorrar.Enabled = Activo
    End Sub

    Private Sub dgMovimientos_Paint(sender As Object, e As PaintEventArgs) Handles dgMaestro.Paint
  
    End Sub

    Private Sub cbConcepto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbConcepto.SelectedValueChanged
        Try
            Dim dtTotales As New DataTable
            Dim dtTotales1, dtTotales2, dtTotales3 As New DataTable
            Dim i As Integer
            Dim Activo As Boolean
            Dim Comentario As String
            Dim Credito As String

            'Limpiar etiquetas e imágenes, por si no hay totales
            picStatus.Image = Nothing
            lblStatus.Text = ""
            lblSaldoInicial.Text = FormatCurrency(0)
            lblAbonos.Text = FormatCurrency(0)
            lblSaldoActual.Text = FormatCurrency(0)
            lblIntereses.Text = FormatCurrency(0)

            'Inicializar variable crédito. Si no hay valor seleccionado
            'Si credito = 'X', la tabla de saldos regresa vacía, pero es diferente de 'Nothing'
            'Si la tabla = Nothing, el Grid pierde la configuración de columnas

            Credito = IIf(cbConcepto.SelectedValue Is Nothing, "X", cbConcepto.SelectedValue)

            If Not cbConcepto.DataSource Is Nothing Then
                'Buscar, de acuerdo al datasource del combo, la posición actual
                i = cbConcepto.BindingContext(dtDeducciones).Position
                'Si i=-1, no hay registros
                If i > -1 Then
                    'Buscar si el crédito seleccionado está activo
                    Activo = IIf(IsDBNull(dtDeducciones.Rows(i).Item("status")), 0, dtDeducciones.Rows(i).Item("status")) = 1
                    'Tomar el comentario del crédito, para luego buscar si está cancelado
                    Comentario = IIf(IsDBNull(dtDeducciones.Rows(i).Item("Comentario")), "", dtDeducciones.Rows(i).Item("Comentario"))

                    If Activo Then
                        lblStatus.Text = "ACTIVO"
                        picStatus.Image = My.Resources.Accept32
                    ElseIf Not Activo And Comentario.ToUpper.Contains("CANCEL") Then
                        lblStatus.Text = "CANCELADO"
                        picStatus.Image = My.Resources.Cancel
                    Else
                        'Si no está activo, ni cancelado, quiere decir que ya se liquidó
                        lblStatus.Text = "LIQUIDADO"
                        picStatus.Image = My.Resources.MedalBlueGold32
                    End If
                End If
            End If
            'Buscar totales
            'El saldo inicial, es el que tenga el periodo menor del año mayor (último año)
            'El saldo final, es el que tenga el periodo mayor, del año mayor (último año)

            dtTotales = sqlExecute("SELECT " & _
                                   "(SELECT TOP 1 saldo_act from saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & _
                                   Credito & "' ORDER BY ano DESC,periodo ASC) AS saldo_inicial, " & _
                                   "(SELECT TOP 1 saldo_act FROM saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & _
                                   Credito & "' ORDER BY ano DESC,periodo DESC) AS saldo_final," & _
                                   "SUM(abono_alc) AS abonos," & _
                                   "SUM(intereses_alc) AS intereses " & _
                                   "FROM saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & "'", "NOMINA")

            dtTotales1 = sqlExecute("SELECT TOP 1 saldo_act+ABONO_ALC AS saldo_inicial,cast(ano as int) as ano,cast(periodo as int) AS periodo FROM saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & "' ORDER BY ano ASC,periodo ASC", "NOMINA")
            dtTotales2 = sqlExecute("SELECT TOP 1 saldo_act AS saldo_final,cast(ano as int) as ano,cast(periodo as int) AS periodo FROM saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & "' ORDER BY ano DESC,periodo DESC", "NOMINA")
            dtTotales3 = sqlExecute("SELECT SUM(abono_alc) AS abonos, SUM(intereses_alc) AS intereses FROM saldos_ca WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & "'", "NOMINA")

            If dtTotales.Rows.Count > 0 Then
                lblSaldoInicial.Text = FormatCurrency(IIf(IsDBNull(dtTotales1.Rows(0).Item("saldo_inicial")), 0, dtTotales1.Rows(0).Item("saldo_inicial")))
                lblSaldoActual.Text = FormatCurrency(IIf(IsDBNull(dtTotales2.Rows(0).Item("saldo_final")), 0, dtTotales2.Rows(0).Item("saldo_final")))
                lblAbonos.Text = FormatCurrency(IIf(IsDBNull(dtTotales3.Rows(0).Item("abonos")), 0, dtTotales3.Rows(0).Item("abonos")))
                lblIntereses.Text = FormatCurrency(IIf(IsDBNull(dtTotales3.Rows(0).Item("intereses")), 0, dtTotales3.Rows(0).Item("intereses")))
            End If

            'Tomar la información de los pagos
            dtSaldos = sqlExecute("SELECT cast(ano as int) as ano,cast(periodo as int) AS periodo,concepto,saldo_act+abono_alc AS saldo_ant,abono_alc AS abono,saldo_act AS saldo," & _
                                  "intereses_alc AS intereses,comentario FROM saldos_ca " & _
                                  "WHERE reloj = '" & txtReloj.Text & "' AND numcredito = '" & Credito & _
                                  "' ORDER BY ano,periodo", "nomina")

            dgSaldos.DataSource = dtSaldos

            If dtSaldos.Rows.Count > 0 Then
                'Resaltar el primer registro, que representa el inicio del crédito
                dgSaldos.Rows(0).DefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuHighlight
            End If
        Catch ex As Exception
            picStatus.Image = Nothing
            lblStatus.Text = ""
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        MtroDedConcepto = txtReloj.Text & dgMaestro.Item("ColCredito", dgMaestro.CurrentRow.Index).Value.ToString.Trim
        frmEditarDeducciones.ShowDialog(Me)
        MostrarInformacion(txtReloj.Text)
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim Respuesta As Windows.Forms.DialogResult

        'Insertar núm. de crédito para formar registro base
        MtroDedConcepto = "NVO"
        Respuesta = frmEditarDeducciones.ShowDialog(Me)
        If Respuesta = Windows.Forms.DialogResult.Abort Then
            MessageBox.Show("Hubo un error durante el proceso, y los cambios no pudieron ser guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf Respuesta = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        MostrarInformacion(txtReloj.Text)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Saldo As Double
        Dim Concepto As String
        Dim NumCredito As String
        Dim Reloj As String

        Try
            Saldo = IIf(IsDBNull(dgMaestro.Item("ColSaldoActual", dgMaestro.CurrentRow.Index).Value), 0, dgMaestro.Item("ColSaldoActual", dgMaestro.CurrentRow.Index).Value.ToString.Trim)
            Concepto = IIf(IsDBNull(dgMaestro.Item("ColCodigo", dgMaestro.CurrentRow.Index).Value), "", dgMaestro.Item("ColCodigo", dgMaestro.CurrentRow.Index).Value.ToString.Trim)
            NumCredito = IIf(IsDBNull(dgMaestro.Item("ColCredito", dgMaestro.CurrentRow.Index).Value), "", dgMaestro.Item("ColCredito", dgMaestro.CurrentRow.Index).Value.ToString.Trim)
            Reloj = txtReloj.Text

            MtroDedSaldo = Saldo
            MtroDedConcepto = Reloj.Trim & Concepto.Trim & NumCredito.Trim
            If frmCancelarDeducciones.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                MessageBox.Show("El crédito/préstamo no pudo ser cancelado. Favor de verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            MostrarInformacion(txtReloj.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgMaestro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMaestro.CellContentClick

    End Sub

    Private Function ExportarAjustes() As Windows.Forms.DialogResult
        Try
            Dim dtAjustesNom As New DataTable
            Dim dtMtroDed As New DataTable
            Dim dtConceptos As New DataTable
            Dim SinSaldo As Integer = 0
            Dim Inicializa As Windows.Forms.DialogResult
            Dim Archivo As String = ""
            Dim Clave As String

            'Solicitar periodo y año para exportación
            If frmSeleccionaPeriodo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Ubicar el archivo en C: y nombrarlo OTAMISC_PP por default
                dlgArchivo.InitialDirectory = "C:\"
                dlgArchivo.FileName = "OTAMISC_" & PeriodoSelec & ".TXT"
                dlgArchivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                dlgArchivo.OverwritePrompt = True

                'Solicitar nombre de archivo para exportación
                Dim lDialogResult As DialogResult = dlgArchivo.ShowDialog()

                If lDialogResult = Windows.Forms.DialogResult.Cancel Then
                    'Si seleccionan "CANCEL", salir del procedimiento
                    Return lDialogResult
                Else
                    Archivo = dlgArchivo.FileName
                End If

                'Obtener cuántos registros están activos, pero su saldo ya es <=0
                dtMtroDed = sqlExecute("SELECT SUM(1) FROM mtro_ded where status = 1 AND prorratear_mes = 1 AND saldo_mes<=0", "nomina")
                If dtMtroDed.Rows.Count > 0 Then
                    SinSaldo = IIf(IsDBNull(dtMtroDed.Rows(0).Item(0)), 0, dtMtroDed.Rows(0).Item(0))
                End If

                'Pregunta para inicializar saldos
                Inicializa = MessageBox.Show("¿Desea inicializar los saldo mensuales para los conceptos que aplique?" & _
                                             IIf(SinSaldo > 0, vbCrLf & vbCrLf & _
                                                "(Existen " & SinSaldo & " créditos que ya completaron su abono mensual)", "") & _
                                            "", "Inicializar saldos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If Inicializa = Windows.Forms.DialogResult.Cancel Then
                    'Si se elige cancelar, salir del proceso
                    'A este punto, no se ha hecho ningún movimiento en la base de datos
                    Return Inicializa
                ElseIf Inicializa = Windows.Forms.DialogResult.Yes Then
                    'Si se eligió inicializar, poner saldo mensual de acuerdo a lo que corresponda, 
                    'si se prorratea por mes y está activo
                    sqlExecute("UPDATE mtro_ded SET saldo_mes = ROUND(abono_mes +.005,2),sem_restan = 4,abono_act = ROUND(ROUND(abono_mes +.005,2)/4,2) " & _
                                "WHERE status = 1 AND prorratear_mes = 1", "nomina")
                End If
            Else
                'Si se eligió cancelar la selección del periodo, salir de la función
                Return Windows.Forms.DialogResult.Cancel
            End If

            'Obtener los registros activos del maestro de deducciones, que aún tengan saldo, 
            'y se registraron para cobro antes del periodo elegido
            dtMtroDed = sqlExecute("SELECT * FROM mtro_ded WHERE status = 1 AND saldo_act>0 AND CONCAT(ano,periodo)<= '" & AnoSelec & _
                                   PeriodoSelec & "'", "nomina")

            'Para cada registro activo del maestro de deducciones
            For Each dRow As DataRow In dtMtroDed.Rows
                '** PROGRESS BAR AQUI ***

                'Obtener ajuste para esta deducción
                dtAjustesNom = sqlExecute("SELECT reloj FROM ajustes_nom WHERE CONCAT(ano,periodo,reloj,RTRIM(concepto),RTRIM(numcredito)) = '" & _
                                          AnoSelec & PeriodoSelec & dRow("reloj") & dRow("concepto").ToString.Trim & _
                                          dRow("numcredito").ToString.Trim & "'", "nomina")
                If dtAjustesNom.Rows.Count = 0 Then
                    'Si no existe en ajustes_nom, insertarlo
                    dtDed2 = sqlExecute("SELECT misce_clave FROM conceptos WHERE concepto = '" & dRow("concepto") & "'", "nomina")
                    If dtDed2.Rows.Count = 0 Then
                        Clave = "XX"
                    Else
                        Clave = IIf(IsDBNull(dtDed2.Rows(0).Item("misce_clave")), "XX", dtDed2.Rows(0).Item("misce_clave")).ToString.Trim
                    End If
                    sqlExecute("INSERT INTO ajustes_nom (ano,periodo,reloj,concepto,clave,per_ded,numcredito,mtro_ded) " & _
                               "VALUES ('" & AnoSelec & "','" & PeriodoSelec & "','" & dRow("RELOJ") & "','" & dRow("concepto") & "','" & Clave & _
                               "',(SELECT cod_naturaleza FROM conceptos WHERE conceptos.concepto = '" & dRow("concepto").ToString.Trim & _
                               "'),'" & dRow("numcredito").ToString.Trim & "',1)", "nomina")
                End If

                'Actualizar montos en ajustes_nom
                sqlExecute("UPDATE ajustes_nom SET monto = ROUND(IIF(monto IS NULL,0,monto) + " & dRow("abono_act") & ",2), " & _
                           "usuario = '" & Usuario & "', " & _
                           "fecha = '" & FechaSQL(Now.Date) & "'," & _
                           "saldo_act = " & dRow("saldo_act") & " WHERE CONCAT(ano,periodo,reloj,RTRIM(concepto),RTRIM(numcredito)) = '" & _
                           AnoSelec & PeriodoSelec & dRow("reloj") & dRow("concepto").ToString.Trim & _
                           dRow("numcredito").ToString.Trim & "'", "nomina")
            Next

            Dim dtRecib As New DataTable
            Dim dRecib As DataRow
            Dim wrArchivo As New StreamWriter(Archivo)

            '** Layout de Ajustes para Eagle Ottawa, para cada vez enviar el descuento como si fuera todo el saldo IVO 12 Nov 2013
            dtRecib = sqlExecute("SELECT '*OTA*' AS reloj,'  ' AS clave,' Semana' as saldo,'*" & PeriodoSelec & "*' as abono,'' as saldo2,' ' as negativo,'' AS comentario")
            dtRecib.PrimaryKey = New DataColumn() {dtRecib.Columns("reloj"), dtRecib.Columns("clave")}

            dtAjustesNom = sqlExecute("SELECT reloj,clave,monto,saldo_act,numcredito FROM ajustes_nom WHERE CONCAT(ano,periodo) = '" & AnoSelec & PeriodoSelec & "'", "nomina")
            For Each dAjuste As DataRow In dtAjustesNom.Rows
                '*** PROGRESS BAR AQUI ***

                'Buscar en la tabla de recibos si ya exise el registro
                dRecib = dtRecib.Rows.Find({dAjuste("RELOJ"), IIf(IsDBNull(dAjuste("clave")), "", dAjuste("clave"))})
                If IsNothing(dRecib) Then
                    'Si no existe, crearlo
                    dtRecib.Rows.Add({dAjuste("reloj"), IIf(IsDBNull(dAjuste("clave")), "", dAjuste("clave"))})
                    dRecib = dtRecib.Rows.Find({dAjuste("RELOJ"), IIf(IsDBNull(dAjuste("clave")), "", dAjuste("clave"))})
                End If

                'Acumular montos en la tabla de recibos
                '(en la tabla, se guardan sin centavos y en tipo caracter. 
                'Para acumular, hay que volverlos double y con centavos antes de procesar)
                dRecib("saldo") = Math.Abs((Val(IIf(IsDBNull(dRecib("saldo")), 0, dRecib("saldo"))) / 100 + dAjuste("monto")) * 100).ToString.PadLeft(9, " ")
                dRecib("abono") = Math.Abs((Val(IIf(IsDBNull(dRecib("abono")), 0, dRecib("abono"))) / 100 + dAjuste("monto")) * 100).ToString.PadLeft(9, " ")
                dRecib("saldo2") = Math.Abs((Val(IIf(IsDBNull(dRecib("saldo2")), 0, dRecib("saldo2"))) / 100 + dAjuste("saldo_act")) * 100).ToString.PadLeft(9, " ")
                dRecib("negativo") = IIf((Val(dRecib("saldo")) / 100 + dAjuste("monto")) < 0, "*", " ")

                'En ajustes_nom, indicar quién y cuándo hizo la exportación
                sqlExecute("UPDATE ajustes_nom SET envio_nom = 1,envio_date = '" & FechaHoraSQL(Now) & "', " & _
                           "envio_usu = '" & Usuario & "' WHERE reloj= '" & dAjuste("reloj") & "' AND clave = '" & dAjuste("clave").ToString.Trim & _
                           "' AND numcredito = '" & dAjuste("numcredito").ToString.Trim & "'", "nomina")
            Next

            'Enviar los datos al archivo seleccionado
            For Each dRecib In dtRecib.Rows
                'Escribir todos los campos
                wrArchivo.Write(dRecib("reloj"))
                wrArchivo.Write(dRecib("clave").ToString.PadRight(2, " "))
                wrArchivo.Write(" ")
                wrArchivo.Write(dRecib("saldo").ToString.PadLeft(9).Substring(0, 9))
                wrArchivo.Write(dRecib("abono").ToString.PadLeft(9).Substring(0, 9))
                wrArchivo.Write(" ")
                wrArchivo.Write(dRecib("saldo2").ToString.PadLeft(9).Substring(0, 9))
                wrArchivo.Write(dRecib("negativo").ToString.PadRight(1))
                wrArchivo.Write(dRecib("comentario").ToString.PadRight(20).Substring(0, 20))
                'Indicar fin de línea
                wrArchivo.WriteLine()
            Next
            'Cerrar el archivo
            wrArchivo.Close()
            Return Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Return Windows.Forms.DialogResult.Abort
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Function

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim dtReporte As New DataTable
        Dim Concepto As String = ""
        Concepto = cbConcepto.Text.Substring(0, 10).Trim
        dtReporte = sqlExecute("SELECT saldos_ca.RELOJ,saldos_ca.ANO,saldos_ca.PERIODO,saldos_ca.NUMCREDITO,ABONO_ALC,saldos_ca.SALDO_ACT," & _
                               "saldos_ca.COMENTARIO,mtro_ded.comentario AS DETALLE,INTERESES_ALC, NOMBRES,COD_DEPTO,COD_SUPER," & _
                               "COD_CLASE,COD_TURNO,COD_HORA,COD_PUESTO,COD_TIPO,ALTA,BAJA,CONCEPTOS.NOMBRE AS CONCEPTO," & _
                               "(SELECT TOP 1 saldo_act from saldos_ca WHERE reloj = '" & txtReloj.Text & _
                               "' AND concepto = mtro_ded.concepto AND numcredito = mtro_ded.NUMCREDITO " & _
                               "ORDER BY ano DESC,periodo ASC) AS SALDO_INICIAL," & _
                               "(SELECT TOP 1 saldo_act from saldos_ca WHERE reloj = '" & txtReloj.Text & _
                               "' AND concepto = mtro_ded.concepto AND numcredito = mtro_ded.NUMCREDITO " & _
                               "ORDER BY ano DESC,periodo DESC) AS SALDO_FINAL " & _
                               "FROM nomina.dbo.saldos_ca LEFT JOIN personal.dbo.personalvw ON saldos_ca.reloj= personalvw.reloj " & _
                               "LEFT JOIN nomina.dbo.conceptos ON saldos_ca.concepto = conceptos.concepto " & _
                               "LEFT JOIN mtro_ded ON saldos_ca.reloj = mtro_ded.reloj AND saldos_ca.numcredito = mtro_ded.numcredito " & _
                               "WHERE saldos_ca.reloj = '" & txtReloj.Text & "' AND saldos_ca.concepto = '" & Concepto & _
                               "' AND mtro_ded.concepto = '" & Concepto & "' ORDER BY concepto,numcredito,ano,periodo", "nomina")
        frmVistaPrevia.LlamarReporte("Estado de cuenta maestro de deducciones", dtReporte)
        frmVistaPrevia.ShowDialog()

    End Sub
End Class