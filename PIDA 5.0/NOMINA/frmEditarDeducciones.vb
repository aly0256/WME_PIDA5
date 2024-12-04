Public Class frmEditarDeducciones
    Dim dtConceptos As New DataTable
    Dim dtPeriodos As New DataTable
    Dim dtDeducc As New DataTable
    Dim dtTemp As New DataTable
    Dim Nuevo As Boolean


    Private Sub frmEditarDeducciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PeriodoActivo As String = ""
        txtReloj.Text = frmMaestroDeducciones.txtReloj.Text
        txtNombre.Text = frmMaestroDeducciones.txtNombre.Text


        Try

            dtConceptos = sqlExecute("SELECT concepto,nombre FROM conceptos WHERE aplica_mtro_ded = 1", "nomina")
            cmbDeduccion.DataSource = dtConceptos
            'cmbDeduccion.SelectedValue = MtroDedConcepto

            dtTemp = sqlExecute("SELECT ano+periodo as 'unico'FROM periodos WHERE activo = 1 ORDER BY ano DESC,periodo DESC", "TA")
            If dtTemp.Rows.Count > 0 Then
                PeriodoActivo = dtTemp.Rows(0).Item(0)
            End If

            dtPeriodos = sqlExecute("SELECT ano+periodo as 'unico',ano,periodo,fecha_ini,fecha_fin FROM periodos WHERE " & _
                                    "periodo_especial IS NULL OR periodo_especial = 0 ORDER BY ano DESC,periodo ASC", "TA")
            ''dtPeriodos = sqlExecute("SELECT ano+periodo as 'unico',ano,periodo,(personal.dbo.FechaCorta(fecha_ini)) as 'fecha_ini',(personal.dbo.FechaCorta(fecha_fin)) as'fecha_fin' FROM periodos WHERE periodo_especial IS NULL OR periodo_especial = 0 ORDER BY ano DESC,periodo ASC", "TA")
            cmbPeriodo.DataSource = dtPeriodos
            cmbPeriodo.SelectedValue = PeriodoActivo

            dtDeducc = sqlExecute("SELECT * FROM mtro_ded WHERE reloj + numcredito = '" & MtroDedConcepto & "'", "nomina")
            If dtDeducc.Rows.Count = 0 Then
                'Si no se localiza el núm. de crédito, es que se va a agregar
                dtDeducc.Rows.Add("")
                drMtroDed = dtDeducc.Rows(0)
                Nuevo = True
                cmbDeduccion.SelectedIndex = 0
                cmbPeriodo.SelectedIndex = 0
                txtNumCredito.Text = ""
                txtSemanas.Text = 0
                txtSaldoInicial.Text = 0
                txtAbono.Text = 0
                txtSaldoActual.Text = 0
                txtTasa.Text = 0
                txtSemRestan.Text = 0
                btnProrratearMes.Value = False
                txtAbonoMes.Text = 0
                txtSaldoMes.Text = 0
                txtAbonoActual.Text = 0
                btnProrratear.Value = False

            Else
                Nuevo = False
                drMtroDed = dtDeducc.Rows(0)
                cmbDeduccion.SelectedValue = dtDeducc.Rows(0).Item("concepto")
                cmbPeriodo.SelectedValue = dtDeducc.Rows(0).Item("ano").ToString.Trim & dtDeducc.Rows(0).Item("periodo").ToString.Trim
                txtNumCredito.Text = dtDeducc.Rows(0).Item("numcredito")
                txtSemanas.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("semanas_desc")), 0, dtDeducc.Rows(0).Item("semanas_desc"))
                txtSaldoInicial.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("saldo_orig")), 0, dtDeducc.Rows(0).Item("saldo_orig"))
                txtAbono.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("abono_orig")), 0, dtDeducc.Rows(0).Item("abono_orig"))
                txtSaldoActual.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("saldo_act")), 0, dtDeducc.Rows(0).Item("saldo_act"))
                txtTasa.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("tasa_int_sem")), 0, dtDeducc.Rows(0).Item("tasa_int_sem"))
                txtSemRestan.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("sem_restan")), 0, dtDeducc.Rows(0).Item("sem_restan"))
                btnProrratearMes.Value = IIf(IsDBNull(dtDeducc.Rows(0).Item("prorratear_mes")), 0, dtDeducc.Rows(0).Item("prorratear_mes"))
                txtAbonoMes.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("abono_mes")), 0, dtDeducc.Rows(0).Item("abono_mes"))
                txtSaldoMes.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("saldo_mes")), 0, dtDeducc.Rows(0).Item("saldo_mes"))
                txtAbonoActual.Text = IIf(IsDBNull(dtDeducc.Rows(0).Item("abono_act")), 0, dtDeducc.Rows(0).Item("abono_act"))
                btnProrratear.Value = IIf(IsDBNull(dtDeducc.Rows(0).Item("prorratear")), 0, dtDeducc.Rows(0).Item("prorratear"))
            End If

            txtSemRestan.Enabled = Not Nuevo
            txtSaldoInicial.Enabled = Nuevo
            txtSaldoActual.Enabled = False
            txtSaldoMes.Enabled = Nuevo
            'dtTemp = sqlExecute("SELECT ano + periodo as anoPeriodo FROM periodos WHERE activo = 1", "TA")
            'If dtTemp.Rows.Count > 0 Then
            '    PeriodoActivo = dtTemp.Rows(0).Item("anoPeriodo")
            '    cmbPeriodo.SelectedValue = dtTemp.Rows(0).Item("anoPeriodo")
            'End If

        Catch ex As Exception
            MessageBox.Show("Se detectaron errores al intentar editar. Si el error persiste, contacte al administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)

        End Try
    End Sub

    Private Sub txtSemanas_Validated(sender As Object, e As EventArgs) Handles txtSemanas.Validated
        txtAbono.Value = Math.Round(IIf(txtSemanas.Value > 0, txtSaldoInicial.Value / txtSemanas.Value, 0), 2)
    End Sub

    Private Sub txtSaldoInicial_Validated(sender As Object, e As EventArgs) Handles txtSaldoInicial.Validated
        If txtSemanas.Value > 0 Then
            txtAbono.Value = Math.Round(txtSaldoInicial.Value / txtSemanas.Value, 2)
            txtSaldoActual.Value = Math.Round(txtSaldoInicial.Value, 2)
            txtSemRestan.Value = txtSemanas.Value
            txtAbonoActual.Value = Math.Round(txtSaldoInicial.Value / txtSemanas.Value, 2)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim Concepto As String
            Dim NumCredito As String
            Dim ano As String = ""
            Dim periodo As String = ""

            Concepto = cmbDeduccion.SelectedValue.ToString.Trim
            NumCredito = txtNumCredito.Text.Trim

            drMtroDed("concepto") = Concepto
            drMtroDed("numcredito") = NumCredito
            drMtroDed("ano") = cmbPeriodo.SelectedValue.ToString.Substring(0, 4)
            drMtroDed("periodo") = cmbPeriodo.SelectedValue.ToString.Substring(4, 2)
            drMtroDed("semanas_desc") = txtSemanas.Value
            drMtroDed("saldo_orig") = txtSaldoInicial.Value
            drMtroDed("abono_orig") = txtAbono.Value
            drMtroDed("saldo_act") = txtSaldoActual.Value
            drMtroDed("tasa_int_sem") = txtTasa.Value
            drMtroDed("sem_restan") = txtSemRestan.Value
            drMtroDed("prorratear_mes") = IIf(btnProrratearMes.Value, 1, 0)
            drMtroDed("abono_mes") = txtAbonoMes.Value
            drMtroDed("saldo_mes") = txtSaldoMes.Value
            drMtroDed("abono_act") = txtAbonoActual.Value
            drMtroDed("prorratear") = IIf(btnProrratear.Value, 1, 0)

            ano = drMtroDed("ano").ToString.Trim
            periodo = drMtroDed("periodo").ToString.Trim

            'Guardar cambios
            If Nuevo Then
                Dim QInsert As String = "INSERT INTO mtro_ded (reloj,concepto,numcredito) VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "')"
                sqlExecute(QInsert, "nomina")
                sqlExecute("INSERT INTO mtro_ded_log (reloj,concepto,numcredito) VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "')", "nomina")

                Dim QInsert2 As String = "INSERT INTO saldos_ca (reloj,periodo,ano,concepto,numcredito,abono_alc,saldo_act,comentario) VALUES ('" & _
                           txtReloj.Text & "','00','" & ano & "','" & Concepto & "','" & NumCredito & _
                           "',0," & drMtroDed("saldo_orig") & ",'Saldo inicial " & Date.Now & " Usuario: " & Usuario & "')"
                sqlExecute(QInsert2, "nomina")
            End If

            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "periodo", periodo, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "ano", ano, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "saldo_orig", Val(drMtroDed("saldo_orig")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "abono_orig", Val(drMtroDed("abono_orig")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "semanas_desc", Val(drMtroDed("semanas_desc")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "tasa_int_sem", Val(drMtroDed("tasa_int_sem")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "status", 1, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "comentario", drMtroDed("comentario").ToString.Trim, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "sem_trans", 0, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "sem_restan", Val(drMtroDed("sem_restan")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "saldo_act", Val(drMtroDed("saldo_act")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "prorratear", Val(drMtroDed("prorratear")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "abono_mes", Val(drMtroDed("abono_mes")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "saldo_mes", Val(drMtroDed("saldo_mes")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "prorratear_mes", Val(drMtroDed("prorratear_mes")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "abono_act", Val(drMtroDed("abono_act")), IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))
            ActualizaMtroDed(txtReloj.Text, Concepto, NumCredito, "sem_rest_mes", 4, IIf(Nuevo, "AGREGAR", "MODIFICACIÓN"))

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub
    Private Sub ActualizaMtroDed(ByVal Reloj As String, ByVal Concepto As String, ByVal NumCredito As String, ByVal Campo As String, ByVal Valor As String, ByVal TipoMovimiento As String)
        Dim dtRevisa As New DataTable
        Dim ValorAnt As String
        Try
            Dim Q1 As String = "SELECT " & Campo & " FROM mtro_ded WHERE reloj='" & Reloj.Trim & "' and NUMCREDITO='" & NumCredito.ToString.Trim & "'"
            dtRevisa = sqlExecute(Q1, "nomina")
            If dtRevisa.Rows.Count = 0 Then
                Dim Q2 As String = "INSERT INTO mtro_ded (reloj,concepto,numcredito) VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "')"
                Dim Q3 As String = "SELECT " & Campo & " FROM mtro_ded WHERE reloj='" & Reloj.Trim & "' and NUMCREDITO='" & NumCredito.ToString.Trim & "'"
                sqlExecute(Q2, "nomina")
                dtRevisa = sqlExecute(Q3, "nomina")

            End If

            ValorAnt = IIf(IsDBNull(dtRevisa.Rows(0).Item(0)), "", dtRevisa.Rows(0).Item(0)).ToString.Trim

            If Valor <> ValorAnt Then

                Dim Q4 = "UPDATE mtro_ded SET " & Campo & " = '" & Valor & "' WHERE RELOJ='" & Reloj & "' AND CONCEPTO='" & Concepto & "' AND NUMCREDITO='" & NumCredito & "'"
                ' Dim Q4 As String = "UPDATE mtro_ded SET " & Campo & " = '" & Valor & "' WHERE CONCAT(RTRIM(reloj),RTRIM(concepto),RTRIM(numcredito)) = '" & Reloj & Concepto & NumCredito & "'"
                sqlExecute(Q4, "nomina")
                sqlExecute("INSERT INTO mtro_ded_log (reloj,concepto,numcredito,campo,valor_anterior,valor_nuevo,usuario,fecha_movimiento,tipo_movimiento) " & _
                   " VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "','" & Campo & "','" & ValorAnt & "','" & _
                   Valor & "','" & Usuario & "','" & FechaHoraSQL(Date.Now) & "', '" & TipoMovimiento & "')", "nomina")
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.HResult, ex.Message)
        End Try
    End Sub

    'Private Sub ActualizaMtroDed(ByVal Reloj As String, ByVal Concepto As String, ByVal NumCredito As String, ByVal Campo As String, ByVal Valor As Double, ByVal TipoMovimiento As String)

    '    Dim dtRevisa As New DataTable
    '    Dim ValorAnt As Double

    '    dtRevisa = sqlExecute("SELECT " & Campo & " FROM mtro_ded WHERE reloj+numcredito = '" & Reloj & NumCredito & "'", "nomina")
    '    If dtRevisa.Rows.Count = 0 Then
    '        sqlExecute("INSERT INTO mtro_ded (reloj,concepto,numcredito) VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "')", "nomina")
    '        dtRevisa = sqlExecute("SELECT " & Campo & " FROM mtro_ded WHERE reloj+numcredito = '" & Reloj & NumCredito & "'", "nomina")
    '    End If

    '    ValorAnt = IIf(IsDBNull(dtRevisa.Rows(0).Item(0)), 0, dtRevisa.Rows(0).Item(0))

    '    If Valor <> ValorAnt Then
    '        sqlExecute("UPDATE mtro_ded SET " & Campo & " = " & Valor & " WHERE CONCAT(RTRIM(reloj),RTRIM(concepto),RTRIM(numcredito)) = '" & Reloj & Concepto & NumCredito & "'", "nomina")
    '        sqlExecute("INSERT INTO mtro_ded_log (reloj,concepto,numcredito,campo,valor_anterior,valor_nuevo,usuario,fecha_movimiento,tipo_movimiento) " & _
    '          " VALUES ('" & Reloj & "','" & Concepto & "','" & NumCredito & "','" & Campo & "','" & ValorAnt & "','" & _
    '          Valor & "','" & Usuario & "','" & FechaHoraSQL(Date.Now) & "', '" & TipoMovimiento & "')", "nomina")

    '    End If
    'End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProrratearMes_ValueChanged(sender As Object, e As EventArgs) Handles btnProrratearMes.ValueChanged
        If btnProrratearMes.Value Then
            'Para evitar pérdidas en el redondeo, se suma +.005
            txtAbonoMes.Value = Math.Round((txtSaldoInicial.Value / txtSemanas.Value * 4) + 0.005, 2)

            txtSaldoMes.Value = txtAbonoMes.Value
            txtAbonoActual.Value = txtAbonoMes.Value / 4
        Else
            txtAbonoMes.Value = 0
            txtSaldoMes.Value = 0
            txtAbonoActual.Value = 0
        End If
    End Sub

    Private Sub DoubleInput1_ValueChanged(sender As Object, e As EventArgs) Handles txtAbono.ValueChanged

    End Sub
End Class