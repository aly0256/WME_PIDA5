<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarDeducciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarDeducciones))
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtReloj = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblEstado = New DevComponents.DotNetBar.LabelX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpDatos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtAbono = New DevComponents.Editors.DoubleInput()
        Me.txtSaldoActual = New DevComponents.Editors.DoubleInput()
        Me.txtNumCredito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAbonoActual = New DevComponents.Editors.DoubleInput()
        Me.txtSaldoMes = New DevComponents.Editors.DoubleInput()
        Me.txtAbonoMes = New DevComponents.Editors.DoubleInput()
        Me.btnProrratearMes = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.txtSemRestan = New DevComponents.Editors.IntegerInput()
        Me.txtTasa = New DevComponents.Editors.DoubleInput()
        Me.txtSemanas = New DevComponents.Editors.IntegerInput()
        Me.txtSaldoInicial = New DevComponents.Editors.DoubleInput()
        Me.cmbPeriodo = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader4 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader5 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDeduccion = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.btnProrratear = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.gpDatos.SuspendLayout()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSemRestan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSemanas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(37, 16)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(199, 40)
        Me.ReflectionLabel1.TabIndex = 253
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>DEDUCCIONES</b></font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.txtReloj)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 49)
        Me.GroupBox1.TabIndex = 251
        Me.GroupBox1.TabStop = False
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(11, 17)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(56, 23)
        Me.LabelX4.TabIndex = 36
        Me.LabelX4.Text = "Reloj"
        '
        'txtReloj
        '
        Me.txtReloj.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtReloj.Border.Class = "TextBoxBorder"
        Me.txtReloj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReloj.Enabled = False
        Me.txtReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReloj.ForeColor = System.Drawing.Color.Black
        Me.txtReloj.Location = New System.Drawing.Point(79, 15)
        Me.txtReloj.Name = "txtReloj"
        Me.txtReloj.ReadOnly = True
        Me.txtReloj.Size = New System.Drawing.Size(84, 26)
        Me.txtReloj.TabIndex = 0
        Me.txtReloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.Green
        '
        '
        '
        Me.lblEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEstado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEstado.Location = New System.Drawing.Point(6, 8)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(29, 91)
        Me.lblEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblEstado.TabIndex = 252
        Me.lblEstado.Text = "ACTIVO"
        Me.lblEstado.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblEstado.TextOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.lblEstado.VerticalTextTopUp = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 250
        Me.Label5.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(39, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(396, 21)
        Me.txtNombre.TabIndex = 249
        '
        'gpDatos
        '
        Me.gpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.gpDatos.Controls.Add(Me.txtAbono)
        Me.gpDatos.Controls.Add(Me.txtSaldoActual)
        Me.gpDatos.Controls.Add(Me.txtNumCredito)
        Me.gpDatos.Controls.Add(Me.txtAbonoActual)
        Me.gpDatos.Controls.Add(Me.txtSaldoMes)
        Me.gpDatos.Controls.Add(Me.txtAbonoMes)
        Me.gpDatos.Controls.Add(Me.btnProrratearMes)
        Me.gpDatos.Controls.Add(Me.txtSemRestan)
        Me.gpDatos.Controls.Add(Me.txtTasa)
        Me.gpDatos.Controls.Add(Me.txtSemanas)
        Me.gpDatos.Controls.Add(Me.txtSaldoInicial)
        Me.gpDatos.Controls.Add(Me.cmbPeriodo)
        Me.gpDatos.Controls.Add(Me.Label17)
        Me.gpDatos.Controls.Add(Me.Label16)
        Me.gpDatos.Controls.Add(Me.Label15)
        Me.gpDatos.Controls.Add(Me.Label14)
        Me.gpDatos.Controls.Add(Me.Label13)
        Me.gpDatos.Controls.Add(Me.Label9)
        Me.gpDatos.Controls.Add(Me.Label10)
        Me.gpDatos.Controls.Add(Me.Label4)
        Me.gpDatos.Controls.Add(Me.Label6)
        Me.gpDatos.Controls.Add(Me.Label7)
        Me.gpDatos.Controls.Add(Me.Label3)
        Me.gpDatos.Controls.Add(Me.Label2)
        Me.gpDatos.Controls.Add(Me.Label1)
        Me.gpDatos.Controls.Add(Me.cmbDeduccion)
        Me.gpDatos.Controls.Add(Me.btnProrratear)
        Me.gpDatos.Controls.Add(Me.Label18)
        Me.gpDatos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatos.Location = New System.Drawing.Point(9, 105)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(426, 396)
        '
        '
        '
        Me.gpDatos.Style.BackColor = System.Drawing.SystemColors.Window
        Me.gpDatos.Style.BackColor2 = System.Drawing.SystemColors.Window
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
        'txtAbono
        '
        '
        '
        '
        Me.txtAbono.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAbono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAbono.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAbono.DisplayFormat = "C"
        Me.txtAbono.Enabled = False
        Me.txtAbono.Increment = 1.0R
        Me.txtAbono.Location = New System.Drawing.Point(114, 149)
        Me.txtAbono.MinValue = 0.0R
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(91, 20)
        Me.txtAbono.TabIndex = 5
        '
        'txtSaldoActual
        '
        '
        '
        '
        Me.txtSaldoActual.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSaldoActual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSaldoActual.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSaldoActual.DisplayFormat = "C"
        Me.txtSaldoActual.Enabled = False
        Me.txtSaldoActual.Increment = 1.0R
        Me.txtSaldoActual.Location = New System.Drawing.Point(114, 175)
        Me.txtSaldoActual.MinValue = 0.0R
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Size = New System.Drawing.Size(91, 20)
        Me.txtSaldoActual.TabIndex = 6
        '
        'txtNumCredito
        '
        '
        '
        '
        Me.txtNumCredito.Border.Class = "TextBoxBorder"
        Me.txtNumCredito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumCredito.Location = New System.Drawing.Point(114, 42)
        Me.txtNumCredito.MaxLength = 10
        Me.txtNumCredito.Name = "txtNumCredito"
        Me.txtNumCredito.Size = New System.Drawing.Size(91, 20)
        Me.txtNumCredito.TabIndex = 1
        '
        'txtAbonoActual
        '
        '
        '
        '
        Me.txtAbonoActual.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAbonoActual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAbonoActual.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAbonoActual.DisplayFormat = "C"
        Me.txtAbonoActual.Increment = 1.0R
        Me.txtAbonoActual.Location = New System.Drawing.Point(114, 361)
        Me.txtAbonoActual.MaxValue = 99999.0R
        Me.txtAbonoActual.MinValue = 0.0R
        Me.txtAbonoActual.Name = "txtAbonoActual"
        Me.txtAbonoActual.ShowUpDown = True
        Me.txtAbonoActual.Size = New System.Drawing.Size(89, 20)
        Me.txtAbonoActual.TabIndex = 13
        '
        'txtSaldoMes
        '
        '
        '
        '
        Me.txtSaldoMes.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSaldoMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSaldoMes.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSaldoMes.DisplayFormat = "C"
        Me.txtSaldoMes.Increment = 1.0R
        Me.txtSaldoMes.Location = New System.Drawing.Point(114, 335)
        Me.txtSaldoMes.MaxValue = 99999.0R
        Me.txtSaldoMes.MinValue = 0.0R
        Me.txtSaldoMes.Name = "txtSaldoMes"
        Me.txtSaldoMes.ShowUpDown = True
        Me.txtSaldoMes.Size = New System.Drawing.Size(89, 20)
        Me.txtSaldoMes.TabIndex = 12
        '
        'txtAbonoMes
        '
        '
        '
        '
        Me.txtAbonoMes.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAbonoMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAbonoMes.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAbonoMes.DisplayFormat = "C"
        Me.txtAbonoMes.Increment = 1.0R
        Me.txtAbonoMes.Location = New System.Drawing.Point(114, 309)
        Me.txtAbonoMes.MaxValue = 99999.0R
        Me.txtAbonoMes.MinValue = 0.0R
        Me.txtAbonoMes.Name = "txtAbonoMes"
        Me.txtAbonoMes.ShowUpDown = True
        Me.txtAbonoMes.Size = New System.Drawing.Size(89, 20)
        Me.txtAbonoMes.TabIndex = 11
        '
        'btnProrratearMes
        '
        '
        '
        '
        Me.btnProrratearMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnProrratearMes.Location = New System.Drawing.Point(114, 281)
        Me.btnProrratearMes.Name = "btnProrratearMes"
        Me.btnProrratearMes.OffText = "NO"
        Me.btnProrratearMes.OffTextColor = System.Drawing.SystemColors.WindowText
        Me.btnProrratearMes.OnText = "SI"
        Me.btnProrratearMes.OnTextColor = System.Drawing.SystemColors.WindowText
        Me.btnProrratearMes.Size = New System.Drawing.Size(91, 22)
        Me.btnProrratearMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProrratearMes.TabIndex = 10
        '
        'txtSemRestan
        '
        '
        '
        '
        Me.txtSemRestan.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSemRestan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSemRestan.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSemRestan.Location = New System.Drawing.Point(114, 227)
        Me.txtSemRestan.MaxValue = 104
        Me.txtSemRestan.MinValue = 0
        Me.txtSemRestan.Name = "txtSemRestan"
        Me.txtSemRestan.ShowUpDown = True
        Me.txtSemRestan.Size = New System.Drawing.Size(91, 20)
        Me.txtSemRestan.TabIndex = 8
        '
        'txtTasa
        '
        '
        '
        '
        Me.txtTasa.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTasa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTasa.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTasa.Increment = 1.0R
        Me.txtTasa.Location = New System.Drawing.Point(114, 201)
        Me.txtTasa.MaxValue = 100.0R
        Me.txtTasa.MinValue = 0.0R
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.ShowUpDown = True
        Me.txtTasa.Size = New System.Drawing.Size(91, 20)
        Me.txtTasa.TabIndex = 7
        '
        'txtSemanas
        '
        '
        '
        '
        Me.txtSemanas.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSemanas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSemanas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSemanas.Location = New System.Drawing.Point(114, 97)
        Me.txtSemanas.MaxValue = 150
        Me.txtSemanas.MinValue = 0
        Me.txtSemanas.Name = "txtSemanas"
        Me.txtSemanas.ShowUpDown = True
        Me.txtSemanas.Size = New System.Drawing.Size(91, 20)
        Me.txtSemanas.TabIndex = 3
        '
        'txtSaldoInicial
        '
        '
        '
        '
        Me.txtSaldoInicial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSaldoInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSaldoInicial.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSaldoInicial.DisplayFormat = "C"
        Me.txtSaldoInicial.Increment = 1.0R
        Me.txtSaldoInicial.Location = New System.Drawing.Point(114, 123)
        Me.txtSaldoInicial.MinValue = 0.0R
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.ShowUpDown = True
        Me.txtSaldoInicial.Size = New System.Drawing.Size(91, 20)
        Me.txtSaldoInicial.TabIndex = 4
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbPeriodo.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbPeriodo.ButtonDropDown.Visible = True
        Me.cmbPeriodo.Columns.Add(Me.ColumnHeader4)
        Me.cmbPeriodo.Columns.Add(Me.ColumnHeader5)
        Me.cmbPeriodo.Columns.Add(Me.ColumnHeader1)
        Me.cmbPeriodo.Columns.Add(Me.ColumnHeader2)
        Me.cmbPeriodo.Columns.Add(Me.ColumnHeader3)
        Me.cmbPeriodo.FormatString = "d"
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbPeriodo.Location = New System.Drawing.Point(114, 68)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(303, 23)
        Me.cmbPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbPeriodo.TabIndex = 2
        Me.cmbPeriodo.ValueMember = "unico"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DataFieldName = "unico"
        Me.ColumnHeader4.Name = "ColumnHeader4"
        Me.ColumnHeader4.Text = "Column"
        Me.ColumnHeader4.Visible = False
        Me.ColumnHeader4.Width.Absolute = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DataFieldName = "ano"
        Me.ColumnHeader5.Name = "ColumnHeader5"
        Me.ColumnHeader5.Text = "Año"
        Me.ColumnHeader5.Width.Relative = 30
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DataFieldName = "periodo"
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Periodo"
        Me.ColumnHeader1.Width.Relative = 20
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DataFieldName = "fecha_ini"
        Me.ColumnHeader2.EditorType = DevComponents.AdvTree.eCellEditorType.[Date]
        Me.ColumnHeader2.MaxInputLength = 10
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "Fecha inicial"
        Me.ColumnHeader2.Width.Relative = 30
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DataFieldName = "fecha_fin"
        Me.ColumnHeader3.EditorType = DevComponents.AdvTree.eCellEditorType.[Date]
        Me.ColumnHeader3.MaxInputLength = 10
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "Fecha final"
        Me.ColumnHeader3.Width.Relative = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(10, 365)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Abono sem. actual"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(10, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Saldo mensual"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(10, 313)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Abono mensual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(10, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Prorrateo mensual"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(10, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Semanas restan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(10, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tasa de int. sem."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(10, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Saldo actual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(10, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Abono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(10, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Saldo inicial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(10, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "# Semanas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(10, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Año / Periodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "# Crédito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concepto"
        '
        'cmbDeduccion
        '
        Me.cmbDeduccion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbDeduccion.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbDeduccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbDeduccion.ButtonDropDown.Visible = True
        Me.cmbDeduccion.DisplayMembers = "concepto"
        Me.cmbDeduccion.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbDeduccion.Location = New System.Drawing.Point(114, 13)
        Me.cmbDeduccion.Name = "cmbDeduccion"
        Me.cmbDeduccion.Size = New System.Drawing.Size(303, 23)
        Me.cmbDeduccion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDeduccion.TabIndex = 0
        Me.cmbDeduccion.ValueMember = "concepto"
        '
        'btnProrratear
        '
        '
        '
        '
        Me.btnProrratear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnProrratear.Location = New System.Drawing.Point(114, 253)
        Me.btnProrratear.Name = "btnProrratear"
        Me.btnProrratear.OffText = "NO"
        Me.btnProrratear.OffTextColor = System.Drawing.SystemColors.WindowText
        Me.btnProrratear.OnText = "SI"
        Me.btnProrratear.OnTextColor = System.Drawing.SystemColors.WindowText
        Me.btnProrratear.Size = New System.Drawing.Size(91, 22)
        Me.btnProrratear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProrratear.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(10, 258)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Prorrateo saldo total"
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.CausesValidation = False
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.PIDA.My.Resources.Resources.Ok16
        Me.btnAceptar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnAceptar.Location = New System.Drawing.Point(275, 507)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 25)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
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
        Me.btnCerrar.Location = New System.Drawing.Point(360, 507)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(78, 25)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cancelar"
        '
        'frmEditarDeducciones
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(444, 538)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gpDatos)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarDeducciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar/Agregar"
        Me.GroupBox1.ResumeLayout(False)
        Me.gpDatos.ResumeLayout(False)
        Me.gpDatos.PerformLayout()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSemRestan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSemanas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtReloj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDeduccion As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnProrratear As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents txtAbonoActual As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSaldoMes As DevComponents.Editors.DoubleInput
    Friend WithEvents txtAbonoMes As DevComponents.Editors.DoubleInput
    Friend WithEvents btnProrratearMes As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents txtSemRestan As DevComponents.Editors.IntegerInput
    Friend WithEvents txtTasa As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSemanas As DevComponents.Editors.IntegerInput
    Friend WithEvents txtSaldoInicial As DevComponents.Editors.DoubleInput
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents txtNumCredito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAbono As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSaldoActual As DevComponents.Editors.DoubleInput
    Friend WithEvents ColumnHeader4 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader5 As DevComponents.AdvTree.ColumnHeader
End Class
