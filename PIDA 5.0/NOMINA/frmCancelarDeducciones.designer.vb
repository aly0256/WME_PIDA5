<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelarDeducciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelarDeducciones))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtClave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.gpDatos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pnlTransferencia = New System.Windows.Forms.Panel()
        Me.txtNvaClave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlDefinitiva = New System.Windows.Forms.Panel()
        Me.txtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNumCancelacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTransferencia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkDefinitivo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatos.SuspendLayout()
        Me.pnlTransferencia.SuspendLayout()
        Me.pnlDefinitiva.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PIDA.My.Resources.Resources.Cancel
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 256
        Me.PictureBox1.TabStop = False
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtClave.Border.Class = "TextBoxBorder"
        Me.txtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Black
        Me.txtClave.Location = New System.Drawing.Point(66, 62)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(119, 26)
        Me.txtClave.TabIndex = 0
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 62)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(56, 23)
        Me.LabelX4.TabIndex = 36
        Me.LabelX4.Text = "Inciso"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(50, 16)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(311, 40)
        Me.ReflectionLabel1.TabIndex = 255
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>CANCELAR DEDUCCIONES</b></font>"
        '
        'gpDatos
        '
        Me.gpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.gpDatos.Controls.Add(Me.pnlTransferencia)
        Me.gpDatos.Controls.Add(Me.pnlDefinitiva)
        Me.gpDatos.Controls.Add(Me.chkTransferencia)
        Me.gpDatos.Controls.Add(Me.chkDefinitivo)
        Me.gpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatos.Location = New System.Drawing.Point(13, 94)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(325, 304)
        '
        '
        '
        Me.gpDatos.Style.BackColor = SystemColors.Window
        Me.gpDatos.Style.BackColor2 = SystemColors.Window
        Me.gpDatos.Style.BackColorGradientAngle = 90
        Me.gpDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderBottomWidth = 1
        Me.gpDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderLeftWidth = 1
        Me.gpDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderRightWidth = 1
        Me.gpDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderTopWidth = 1
        Me.gpDatos.Style.CornerDiameter = 4
        Me.gpDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatos.TabIndex = 0
        '
        'pnlTransferencia
        '
        Me.pnlTransferencia.BackColor = SystemColors.Window
        Me.pnlTransferencia.Controls.Add(Me.txtNvaClave)
        Me.pnlTransferencia.Controls.Add(Me.Label3)
        Me.pnlTransferencia.Enabled = False
        Me.pnlTransferencia.Location = New System.Drawing.Point(32, 250)
        Me.pnlTransferencia.Name = "pnlTransferencia"
        Me.pnlTransferencia.Size = New System.Drawing.Size(275, 41)
        Me.pnlTransferencia.TabIndex = 3
        '
        'txtNvaClave
        '
        '
        '
        '
        Me.txtNvaClave.Border.Class = "TextBoxBorder"
        Me.txtNvaClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNvaClave.Location = New System.Drawing.Point(162, 8)
        Me.txtNvaClave.Name = "txtNvaClave"
        Me.txtNvaClave.Size = New System.Drawing.Size(106, 21)
        Me.txtNvaClave.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(2, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nueva clave"
        '
        'pnlDefinitiva
        '
        Me.pnlDefinitiva.BackColor = SystemColors.Window
        Me.pnlDefinitiva.Controls.Add(Me.txtMotivo)
        Me.pnlDefinitiva.Controls.Add(Me.txtNumCancelacion)
        Me.pnlDefinitiva.Controls.Add(Me.Label2)
        Me.pnlDefinitiva.Controls.Add(Me.Label1)
        Me.pnlDefinitiva.Location = New System.Drawing.Point(32, 41)
        Me.pnlDefinitiva.Name = "pnlDefinitiva"
        Me.pnlDefinitiva.Size = New System.Drawing.Size(275, 177)
        Me.pnlDefinitiva.TabIndex = 0
        '
        'txtMotivo
        '
        '
        '
        '
        Me.txtMotivo.Border.Class = "TextBoxBorder"
        Me.txtMotivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMotivo.Location = New System.Drawing.Point(5, 68)
        Me.txtMotivo.MaxLength = 100
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(263, 102)
        Me.txtMotivo.TabIndex = 1
        '
        'txtNumCancelacion
        '
        '
        '
        '
        Me.txtNumCancelacion.Border.Class = "TextBoxBorder"
        Me.txtNumCancelacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumCancelacion.Location = New System.Drawing.Point(162, 6)
        Me.txtNumCancelacion.Name = "txtNumCancelacion"
        Me.txtNumCancelacion.Size = New System.Drawing.Size(106, 21)
        Me.txtNumCancelacion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(2, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Motivo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número de cancelación"
        '
        'chkTransferencia
        '
        Me.chkTransferencia.AutoSize = True
        Me.chkTransferencia.BackColor = SystemColors.Window
        '
        '
        '
        Me.chkTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkTransferencia.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTransferencia.Location = New System.Drawing.Point(11, 224)
        Me.chkTransferencia.Name = "chkTransferencia"
        Me.chkTransferencia.Size = New System.Drawing.Size(173, 16)
        Me.chkTransferencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkTransferencia.TabIndex = 2
        Me.chkTransferencia.Text = "Transferencia a nueva clave"
        Me.chkTransferencia.TextColor = System.Drawing.Color.Black
        '
        'chkDefinitivo
        '
        Me.chkDefinitivo.AutoSize = True
        Me.chkDefinitivo.BackColor = SystemColors.Window
        '
        '
        '
        Me.chkDefinitivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDefinitivo.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkDefinitivo.Checked = True
        Me.chkDefinitivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefinitivo.CheckValue = "Y"
        Me.chkDefinitivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefinitivo.Location = New System.Drawing.Point(11, 13)
        Me.chkDefinitivo.Name = "chkDefinitivo"
        Me.chkDefinitivo.Size = New System.Drawing.Size(139, 16)
        Me.chkDefinitivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkDefinitivo.TabIndex = 1
        Me.chkDefinitivo.Text = "Cancelación definitiva"
        Me.chkDefinitivo.TextColor = System.Drawing.Color.Black
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.CausesValidation = False
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.PIDA.My.Resources.Resources.Cancel16
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(259, 404)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(78, 25)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 259
        Me.btnCerrar.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.CausesValidation = False
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.PIDA.My.Resources.Resources.Ok16
        Me.btnAceptar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnAceptar.Location = New System.Drawing.Point(175, 404)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 25)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 258
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmCancelarDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 442)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gpDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelarDeducciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar deducciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatos.ResumeLayout(False)
        Me.gpDatos.PerformLayout()
        Me.pnlTransferencia.ResumeLayout(False)
        Me.pnlTransferencia.PerformLayout()
        Me.pnlDefinitiva.ResumeLayout(False)
        Me.pnlDefinitiva.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents gpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents chkDefinitivo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtNvaClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNumCancelacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTransferencia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents pnlTransferencia As System.Windows.Forms.Panel
    Friend WithEvents pnlDefinitiva As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
