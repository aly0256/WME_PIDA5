Public Class frmCancelarDeducciones
    Dim dtInfo As New DataTable

    Private Sub frmCancelarDeducciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  SELECT * FROM mtro_ded where reloj='00008 ' and CONCEPTO='FNAALC' and NUMCREDITO='2222222222'
        Dim Q1 As String = "SELECT * FROM mtro_ded WHERE (RTRIM(reloj) + RTRIM(concepto) + RTRIM(numcredito)) = '" & MtroDedConcepto & "'"
        dtInfo = sqlExecute(Q1, "nomina")

        txtClave.Text = dtInfo.Rows(0).Item("numcredito")
        txtNvaClave.Text = ""
        txtNumCancelacion.Focus()
    End Sub

    Private Sub chkDefinitivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefinitivo.CheckedChanged
        pnlDefinitiva.Enabled = chkDefinitivo.Checked
        pnlTransferencia.Enabled = chkTransferencia.Checked
    End Sub

    Private Sub chkTransferencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransferencia.CheckedChanged
        pnlDefinitiva.Enabled = chkDefinitivo.Checked
        pnlTransferencia.Enabled = chkTransferencia.Checked
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim Comentario As String

            If MessageBox.Show("¿Está seguro de cancelar el crédito o préstamo " & txtClave.Text.Trim & "?", "Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If chkDefinitivo.Checked Then
                    Comentario = IIf(IsDBNull(dtInfo.Rows(0).Item("comentario")), "", dtInfo.Rows(0).Item("comentario").ToString.Trim)
                    Comentario = IIf(Comentario.Length > 0, ", ", "") & _
                        "Cancelación #" & txtNumCancelacion.Text.Trim & " por el usuario " & Usuario & " el día " & Date.Now & _
                        IIf(txtMotivo.TextLength > 0, ", por ", "") & txtMotivo.Text.Trim
                    If Comentario.Length > 250 Then
                        Comentario = Comentario.Substring(0, 250)
                    End If
                    'BERE
                    'sqlExecute("UPDATE mtro_ded SET status = 0,comentario = '" & Comentario & "' WHERE CONCAT(RTRIM(reloj),RTRIM(concepto),RTRIM(numcredito)) = '" & MtroDedConcepto & "'", "nomina")
                    sqlExecute("UPDATE mtro_ded SET status = 0,comentario = '" & Comentario & "' WHERE (RTRIM(reloj) + RTRIM(concepto) + RTRIM(numcredito)) = '" & MtroDedConcepto & "'", "nomina")

                    sqlExecute("INSERT INTO saldos_ca (reloj,periodo,ano,concepto,numcredito,abono_alc,saldo_act,comentario) VALUES ('" & _
                               dtInfo.Rows(0).Item("reloj") & "','99','" & dtInfo.Rows(0).Item("ano") & "','" & dtInfo.Rows(0).Item("concepto").ToString.Trim & _
                               "','" & dtInfo.Rows(0).Item("numcredito") & "'," & MtroDedSaldo & ",0," & _
                               "'Monto acreditado por cancelación " & Date.Now & ". Usuario: " & Usuario & "')", "nomina")
                    sqlExecute("INSERT INTO mtro_ded_log (reloj,concepto,numcredito,campo,valor_anterior,valor_nuevo,usuario,fecha_movimiento,tipo_movimiento) " & _
                               " VALUES ('" & Reloj & "','" & dtInfo.Rows(0).Item("concepto") & "','" & dtInfo.Rows(0).Item("numcredito") & "','Status',0,1,'" & Usuario & "','" & _
                               FechaHoraSQL(Date.Now) & "', 'CANCELACIÓN')", "nomina")

                Else
                    'BERE
                    'sqlExecute("UPDATE mtro_ded SET numcredito = '" & txtNvaClave.Text & "', comentario = comentario + iif(comentario ='' or comentario is null,'',', ') + '" & _
                    '        "Transferencia de la clave original " & MtroDedConcepto & " por el usuario " & Usuario & " el día" & Date.Now & _
                    '        " WHERE numcredito = '" & MtroDedConcepto & "'", "nomina")
                    sqlExecute("UPDATE mtro_ded SET numcredito = '" & txtNvaClave.Text & "', comentario = comentario + (CASE WHEN (comentario ='' or comentario is null) THEN '' ELSE ', ' END) + '" & _
                            "Transferencia de la clave original " & MtroDedConcepto & " por el usuario " & Usuario & " el día" & Date.Now & _
                            " WHERE numcredito = '" & MtroDedConcepto & "'", "nomina")

                    sqlExecute("UPDATE saldos_ca SET numcredito = '" & txtNvaClave.Text & "' WHERE numcredito = '" & MtroDedConcepto & "'", "nomina")

                    sqlExecute("INSERT INTO mtro_ded_log (reloj,concepto,numcredito,campo,valor_anterior,valor_nuevo,usuario,fecha_movimiento,tipo_movimiento) " & _
                               " VALUES ('" & Reloj & "','" & dtInfo.Rows(0).Item("concepto") & "','" & dtInfo.Rows(0).Item("numcredito") & "','Status',0,1,'" & Usuario & "','" & _
                               FechaHoraSQL(Date.Now) & "', 'TRANSFERENCIA')", "nomina")
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            ErrorLog(Usuario, System.Reflection.MethodBase.GetCurrentMethod.Name(), Me.Name, ex.hResult, ex.Message)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        Finally
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class