<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibosCFDI2017
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibosCFDI2017))
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.gpParametros = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkPtuBajas = New System.Windows.Forms.CheckBox()
        Me.chkPtuAltas = New System.Windows.Forms.CheckBox()
        Me.chkPtu = New System.Windows.Forms.CheckBox()
        Me.lblCargaXml = New DevComponents.DotNetBar.LabelX()
        Me.txtEntidad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFecPago = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.chkFecPago = New System.Windows.Forms.CheckBox()
        Me.cmbTipoPeriodo = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader8 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader9 = New DevComponents.AdvTree.ColumnHeader()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.sbEmail = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnValidarLista = New DevComponents.DotNetBar.ButtonX()
        Me.txtListaRelojes = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.rbLista = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.gpAvance = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CircularProgress4 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblAvance = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.pbAvance = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.txtRiesgo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBanco = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCia = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDirectorioArchivos = New DevComponents.DotNetBar.ButtonX()
        Me.txtDirectorioArchivos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDirectorioCD = New DevComponents.DotNetBar.ButtonX()
        Me.txtDirectorioCD = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClaveWeb = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuarioWeb = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClaveKEY = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnArchivoCER = New DevComponents.DotNetBar.ButtonX()
        Me.txtArchivoCER = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnArchivoKEY = New DevComponents.DotNetBar.ButtonX()
        Me.txtArchivoKEY = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnPrueba = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAnoPeriodo = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader4 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader5 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader6 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader7 = New DevComponents.AdvTree.ColumnHeader()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gpControles = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.dlgArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.bgTimbrado = New System.ComponentModel.BackgroundWorker()
        Me.PreguntaArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.tmrTranscurre = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnVers4Cfdi = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.gpParametros.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtFecPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpAvance.SuspendLayout()
        Me.gpControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(451, 46)
        Me.ReflectionLabel1.TabIndex = 113
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>RECIBOS CFDI Versión 3.3</b></font>"
        '
        'gpParametros
        '
        Me.gpParametros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gpParametros.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpParametros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.gpParametros.Controls.Add(Me.btnVers4Cfdi)
        Me.gpParametros.Controls.Add(Me.Label15)
        Me.gpParametros.Controls.Add(Me.Panel2)
        Me.gpParametros.Controls.Add(Me.lblCargaXml)
        Me.gpParametros.Controls.Add(Me.txtEntidad)
        Me.gpParametros.Controls.Add(Me.Label14)
        Me.gpParametros.Controls.Add(Me.txtFecPago)
        Me.gpParametros.Controls.Add(Me.chkFecPago)
        Me.gpParametros.Controls.Add(Me.cmbTipoPeriodo)
        Me.gpParametros.Controls.Add(Me.Label13)
        Me.gpParametros.Controls.Add(Me.sbEmail)
        Me.gpParametros.Controls.Add(Me.Panel1)
        Me.gpParametros.Controls.Add(Me.gpAvance)
        Me.gpParametros.Controls.Add(Me.txtRiesgo)
        Me.gpParametros.Controls.Add(Me.txtBanco)
        Me.gpParametros.Controls.Add(Me.Label11)
        Me.gpParametros.Controls.Add(Me.Label9)
        Me.gpParametros.Controls.Add(Me.cmbCia)
        Me.gpParametros.Controls.Add(Me.Label10)
        Me.gpParametros.Controls.Add(Me.Label8)
        Me.gpParametros.Controls.Add(Me.btnDirectorioArchivos)
        Me.gpParametros.Controls.Add(Me.txtDirectorioArchivos)
        Me.gpParametros.Controls.Add(Me.Label7)
        Me.gpParametros.Controls.Add(Me.btnDirectorioCD)
        Me.gpParametros.Controls.Add(Me.txtDirectorioCD)
        Me.gpParametros.Controls.Add(Me.Label6)
        Me.gpParametros.Controls.Add(Me.txtClaveWeb)
        Me.gpParametros.Controls.Add(Me.Label5)
        Me.gpParametros.Controls.Add(Me.txtUsuarioWeb)
        Me.gpParametros.Controls.Add(Me.Label4)
        Me.gpParametros.Controls.Add(Me.txtClaveKEY)
        Me.gpParametros.Controls.Add(Me.Label3)
        Me.gpParametros.Controls.Add(Me.btnArchivoCER)
        Me.gpParametros.Controls.Add(Me.txtArchivoCER)
        Me.gpParametros.Controls.Add(Me.Label1)
        Me.gpParametros.Controls.Add(Me.btnArchivoKEY)
        Me.gpParametros.Controls.Add(Me.txtArchivoKEY)
        Me.gpParametros.Controls.Add(Me.btnPrueba)
        Me.gpParametros.Controls.Add(Me.Label2)
        Me.gpParametros.Controls.Add(Me.cmbAnoPeriodo)
        Me.gpParametros.Controls.Add(Me.Label12)
        Me.gpParametros.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpParametros.Location = New System.Drawing.Point(12, 64)
        Me.gpParametros.Name = "gpParametros"
        Me.gpParametros.Size = New System.Drawing.Size(942, 533)
        '
        '
        '
        Me.gpParametros.Style.BackColor = System.Drawing.SystemColors.Window
        Me.gpParametros.Style.BackColor2 = System.Drawing.SystemColors.Window
        Me.gpParametros.Style.BackColorGradientAngle = 90
        Me.gpParametros.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpParametros.Style.BorderBottomWidth = 1
        Me.gpParametros.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpParametros.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpParametros.Style.BorderLeftWidth = 1
        Me.gpParametros.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpParametros.Style.BorderRightWidth = 1
        Me.gpParametros.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpParametros.Style.BorderTopWidth = 1
        Me.gpParametros.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpParametros.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpParametros.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpParametros.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpParametros.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpParametros.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkPtuBajas)
        Me.Panel2.Controls.Add(Me.chkPtuAltas)
        Me.Panel2.Controls.Add(Me.chkPtu)
        Me.Panel2.Location = New System.Drawing.Point(14, 70)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 82)
        Me.Panel2.TabIndex = 287
        '
        'chkPtuBajas
        '
        Me.chkPtuBajas.AutoSize = True
        Me.chkPtuBajas.Location = New System.Drawing.Point(8, 49)
        Me.chkPtuBajas.Margin = New System.Windows.Forms.Padding(2)
        Me.chkPtuBajas.Name = "chkPtuBajas"
        Me.chkPtuBajas.Size = New System.Drawing.Size(52, 17)
        Me.chkPtuBajas.TabIndex = 2
        Me.chkPtuBajas.Text = "Bajas"
        Me.chkPtuBajas.UseVisualStyleBackColor = True
        '
        'chkPtuAltas
        '
        Me.chkPtuAltas.AutoSize = True
        Me.chkPtuAltas.Location = New System.Drawing.Point(8, 27)
        Me.chkPtuAltas.Margin = New System.Windows.Forms.Padding(2)
        Me.chkPtuAltas.Name = "chkPtuAltas"
        Me.chkPtuAltas.Size = New System.Drawing.Size(49, 17)
        Me.chkPtuAltas.TabIndex = 1
        Me.chkPtuAltas.Text = "Altas"
        Me.chkPtuAltas.UseVisualStyleBackColor = True
        '
        'chkPtu
        '
        Me.chkPtu.AutoSize = True
        Me.chkPtu.Location = New System.Drawing.Point(8, 4)
        Me.chkPtu.Margin = New System.Windows.Forms.Padding(2)
        Me.chkPtu.Name = "chkPtu"
        Me.chkPtu.Size = New System.Drawing.Size(48, 17)
        Me.chkPtu.TabIndex = 0
        Me.chkPtu.Text = "PTU"
        Me.chkPtu.UseVisualStyleBackColor = True
        '
        'lblCargaXml
        '
        '
        '
        '
        Me.lblCargaXml.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCargaXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaXml.Location = New System.Drawing.Point(403, 172)
        Me.lblCargaXml.Name = "lblCargaXml"
        Me.lblCargaXml.Size = New System.Drawing.Size(205, 54)
        Me.lblCargaXml.TabIndex = 286
        Me.lblCargaXml.Text = "carga xml"
        Me.lblCargaXml.Visible = False
        '
        'txtEntidad
        '
        Me.txtEntidad.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtEntidad.Border.Class = "TextBoxBorder"
        Me.txtEntidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEntidad.Location = New System.Drawing.Point(122, 495)
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(133, 21)
        Me.txtEntidad.TabIndex = 285
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 497)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 15)
        Me.Label14.TabIndex = 284
        Me.Label14.Text = "Entidad"
        '
        'txtFecPago
        '
        '
        '
        '
        Me.txtFecPago.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtFecPago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecPago.ButtonDropDown.Visible = True
        Me.txtFecPago.DisabledForeColor = System.Drawing.Color.Black
        Me.txtFecPago.Enabled = False
        Me.txtFecPago.FocusHighlightEnabled = True
        Me.txtFecPago.IsPopupCalendarOpen = False
        Me.txtFecPago.Location = New System.Drawing.Point(122, 185)
        '
        '
        '
        Me.txtFecPago.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtFecPago.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtFecPago.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecPago.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtFecPago.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtFecPago.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecPago.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.txtFecPago.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtFecPago.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtFecPago.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtFecPago.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtFecPago.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtFecPago.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecPago.MonthCalendar.TodayButtonVisible = True
        Me.txtFecPago.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtFecPago.Name = "txtFecPago"
        Me.txtFecPago.Size = New System.Drawing.Size(134, 20)
        Me.txtFecPago.TabIndex = 283
        Me.txtFecPago.Value = New Date(2007, 7, 7, 0, 0, 0, 0)
        '
        'chkFecPago
        '
        Me.chkFecPago.AutoSize = True
        Me.chkFecPago.Location = New System.Drawing.Point(15, 187)
        Me.chkFecPago.Name = "chkFecPago"
        Me.chkFecPago.Size = New System.Drawing.Size(98, 17)
        Me.chkFecPago.TabIndex = 282
        Me.chkFecPago.Text = "Fecha de pago"
        Me.chkFecPago.UseVisualStyleBackColor = True
        '
        'cmbTipoPeriodo
        '
        Me.cmbTipoPeriodo.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbTipoPeriodo.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbTipoPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbTipoPeriodo.ButtonDropDown.Visible = True
        Me.cmbTipoPeriodo.Columns.Add(Me.ColumnHeader8)
        Me.cmbTipoPeriodo.Columns.Add(Me.ColumnHeader9)
        Me.cmbTipoPeriodo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbTipoPeriodo.Location = New System.Drawing.Point(122, 12)
        Me.cmbTipoPeriodo.Name = "cmbTipoPeriodo"
        Me.cmbTipoPeriodo.Size = New System.Drawing.Size(200, 23)
        Me.cmbTipoPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipoPeriodo.TabIndex = 281
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.ColumnName = "colTipoPeriodo"
        Me.ColumnHeader8.DataFieldName = "tipo_periodo"
        Me.ColumnHeader8.Name = "ColumnHeader8"
        Me.ColumnHeader8.Text = "Tipo"
        Me.ColumnHeader8.Width.Relative = 25
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.ColumnName = "colNombreTipoPeriodo"
        Me.ColumnHeader9.DataFieldName = "nombre"
        Me.ColumnHeader9.Name = "ColumnHeader9"
        Me.ColumnHeader9.StretchToFill = True
        Me.ColumnHeader9.Text = "Nombre"
        Me.ColumnHeader9.Width.Absolute = 150
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(614, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 15)
        Me.Label13.TabIndex = 280
        Me.Label13.Text = "Incluir correos electrónicos"
        '
        'sbEmail
        '
        '
        '
        '
        Me.sbEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sbEmail.Location = New System.Drawing.Point(801, 214)
        Me.sbEmail.Name = "sbEmail"
        Me.sbEmail.OffText = "NO"
        Me.sbEmail.OnText = "SI"
        Me.sbEmail.Size = New System.Drawing.Size(133, 23)
        Me.sbEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sbEmail.TabIndex = 279
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnValidarLista)
        Me.Panel1.Controls.Add(Me.txtListaRelojes)
        Me.Panel1.Controls.Add(Me.rbLista)
        Me.Panel1.Controls.Add(Me.rbTodos)
        Me.Panel1.Location = New System.Drawing.Point(122, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 83)
        Me.Panel1.TabIndex = 278
        '
        'btnValidarLista
        '
        Me.btnValidarLista.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnValidarLista.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnValidarLista.Enabled = False
        Me.btnValidarLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarLista.Location = New System.Drawing.Point(713, 49)
        Me.btnValidarLista.Name = "btnValidarLista"
        Me.btnValidarLista.Size = New System.Drawing.Size(90, 21)
        Me.btnValidarLista.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnValidarLista.TabIndex = 5
        Me.btnValidarLista.Text = "Validar lista"
        '
        'txtListaRelojes
        '
        Me.txtListaRelojes.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtListaRelojes.Border.Class = "TextBoxBorder"
        Me.txtListaRelojes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtListaRelojes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListaRelojes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtListaRelojes.Location = New System.Drawing.Point(8, 49)
        Me.txtListaRelojes.Name = "txtListaRelojes"
        Me.txtListaRelojes.ReadOnly = True
        Me.txtListaRelojes.Size = New System.Drawing.Size(699, 21)
        Me.txtListaRelojes.TabIndex = 4
        '
        'rbLista
        '
        Me.rbLista.AutoSize = True
        Me.rbLista.Location = New System.Drawing.Point(8, 26)
        Me.rbLista.Name = "rbLista"
        Me.rbLista.Size = New System.Drawing.Size(303, 17)
        Me.rbLista.TabIndex = 1
        Me.rbLista.Text = "Lista de empleados (Números de reloj separados por coma)"
        Me.rbLista.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(8, 3)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(125, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.Text = "Todos los empleados"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'gpAvance
        '
        Me.gpAvance.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAvance.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.gpAvance.Controls.Add(Me.CircularProgress4)
        Me.gpAvance.Controls.Add(Me.lblAvance)
        Me.gpAvance.Controls.Add(Me.lblTiempo)
        Me.gpAvance.Controls.Add(Me.pbAvance)
        Me.gpAvance.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpAvance.Location = New System.Drawing.Point(362, 213)
        Me.gpAvance.Name = "gpAvance"
        Me.gpAvance.Size = New System.Drawing.Size(216, 229)
        '
        '
        '
        Me.gpAvance.Style.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gpAvance.Style.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gpAvance.Style.BackColorGradientAngle = 90
        Me.gpAvance.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAvance.Style.BorderBottomWidth = 2
        Me.gpAvance.Style.BorderColor = System.Drawing.SystemColors.Highlight
        Me.gpAvance.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAvance.Style.BorderLeftWidth = 1
        Me.gpAvance.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAvance.Style.BorderRightWidth = 1
        Me.gpAvance.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAvance.Style.BorderTopWidth = 1
        Me.gpAvance.Style.CornerDiameter = 4
        Me.gpAvance.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpAvance.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpAvance.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpAvance.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpAvance.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpAvance.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpAvance.TabIndex = 275
        Me.gpAvance.Visible = False
        '
        'CircularProgress4
        '
        '
        '
        '
        Me.CircularProgress4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgress4.Location = New System.Drawing.Point(-124, 27)
        Me.CircularProgress4.Name = "CircularProgress4"
        Me.CircularProgress4.ProgressColor = System.Drawing.Color.SteelBlue
        Me.CircularProgress4.ProgressTextVisible = True
        Me.CircularProgress4.Size = New System.Drawing.Size(539, 78)
        Me.CircularProgress4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress4.TabIndex = 286
        Me.CircularProgress4.Visible = False
        '
        'lblAvance
        '
        Me.lblAvance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblAvance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvance.Location = New System.Drawing.Point(0, 162)
        Me.lblAvance.Name = "lblAvance"
        Me.lblAvance.Size = New System.Drawing.Size(214, 44)
        Me.lblAvance.TabIndex = 273
        Me.lblAvance.Text = "Preparando datos..."
        Me.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempo
        '
        Me.lblTiempo.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTiempo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTiempo.Location = New System.Drawing.Point(0, 206)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(214, 20)
        Me.lblTiempo.TabIndex = 272
        Me.lblTiempo.Text = "Tiempo..."
        '
        'pbAvance
        '
        Me.pbAvance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.pbAvance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pbAvance.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbAvance.Location = New System.Drawing.Point(0, 0)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Padding = New System.Windows.Forms.Padding(5)
        Me.pbAvance.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.pbAvance.ProgressColor = System.Drawing.Color.MediumBlue
        Me.pbAvance.ProgressTextFormat = ""
        Me.pbAvance.Size = New System.Drawing.Size(214, 152)
        Me.pbAvance.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.pbAvance.TabIndex = 270
        '
        'txtRiesgo
        '
        Me.txtRiesgo.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtRiesgo.Border.Class = "TextBoxBorder"
        Me.txtRiesgo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRiesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRiesgo.Location = New System.Drawing.Point(122, 468)
        Me.txtRiesgo.Name = "txtRiesgo"
        Me.txtRiesgo.Size = New System.Drawing.Size(133, 21)
        Me.txtRiesgo.TabIndex = 118
        '
        'txtBanco
        '
        Me.txtBanco.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtBanco.Border.Class = "TextBoxBorder"
        Me.txtBanco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBanco.Location = New System.Drawing.Point(122, 441)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(133, 21)
        Me.txtBanco.TabIndex = 117
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 470)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Riesgo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Banco"
        '
        'cmbCia
        '
        Me.cmbCia.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbCia.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbCia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbCia.ButtonDropDown.Visible = True
        Me.cmbCia.Columns.Add(Me.ColumnHeader1)
        Me.cmbCia.Columns.Add(Me.ColumnHeader2)
        Me.cmbCia.DropDownHeight = 180
        Me.cmbCia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCia.FormatString = "d"
        Me.cmbCia.FormattingEnabled = True
        Me.cmbCia.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbCia.Location = New System.Drawing.Point(122, 41)
        Me.cmbCia.Name = "cmbCia"
        Me.cmbCia.Size = New System.Drawing.Size(808, 23)
        Me.cmbCia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCia.TabIndex = 1
        Me.cmbCia.ValueMember = "cod_comp"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DataFieldName = "cod_comp"
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width.Absolute = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DataFieldName = "nombre"
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "Compañía"
        Me.ColumnHeader2.Width.Absolute = 150
        Me.ColumnHeader2.Width.AutoSize = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Compañía"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Directorio destino archivos XML y PDF"
        '
        'btnDirectorioArchivos
        '
        Me.btnDirectorioArchivos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDirectorioArchivos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDirectorioArchivos.Location = New System.Drawing.Point(911, 414)
        Me.btnDirectorioArchivos.Name = "btnDirectorioArchivos"
        Me.btnDirectorioArchivos.Size = New System.Drawing.Size(23, 21)
        Me.btnDirectorioArchivos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDirectorioArchivos.TabIndex = 13
        Me.btnDirectorioArchivos.Text = "..."
        '
        'txtDirectorioArchivos
        '
        Me.txtDirectorioArchivos.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtDirectorioArchivos.Border.Class = "TextBoxBorder"
        Me.txtDirectorioArchivos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDirectorioArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectorioArchivos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDirectorioArchivos.Location = New System.Drawing.Point(253, 414)
        Me.txtDirectorioArchivos.Name = "txtDirectorioArchivos"
        Me.txtDirectorioArchivos.Size = New System.Drawing.Size(652, 21)
        Me.txtDirectorioArchivos.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 15)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Ubicación programa de comercio digital"
        '
        'btnDirectorioCD
        '
        Me.btnDirectorioCD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDirectorioCD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDirectorioCD.Location = New System.Drawing.Point(911, 385)
        Me.btnDirectorioCD.Name = "btnDirectorioCD"
        Me.btnDirectorioCD.Size = New System.Drawing.Size(23, 21)
        Me.btnDirectorioCD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDirectorioCD.TabIndex = 11
        Me.btnDirectorioCD.Text = "..."
        '
        'txtDirectorioCD
        '
        Me.txtDirectorioCD.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtDirectorioCD.Border.Class = "TextBoxBorder"
        Me.txtDirectorioCD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDirectorioCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectorioCD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDirectorioCD.Location = New System.Drawing.Point(253, 385)
        Me.txtDirectorioCD.Name = "txtDirectorioCD"
        Me.txtDirectorioCD.Size = New System.Drawing.Size(652, 21)
        Me.txtDirectorioCD.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Contraseña WEB"
        '
        'txtClaveWeb
        '
        Me.txtClaveWeb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtClaveWeb.Border.Class = "TextBoxBorder"
        Me.txtClaveWeb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClaveWeb.Enabled = False
        Me.txtClaveWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveWeb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtClaveWeb.Location = New System.Drawing.Point(122, 356)
        Me.txtClaveWeb.Name = "txtClaveWeb"
        Me.txtClaveWeb.Size = New System.Drawing.Size(133, 21)
        Me.txtClaveWeb.TabIndex = 9
        Me.txtClaveWeb.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Usuario WEB"
        '
        'txtUsuarioWeb
        '
        Me.txtUsuarioWeb.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtUsuarioWeb.Border.Class = "TextBoxBorder"
        Me.txtUsuarioWeb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuarioWeb.Enabled = False
        Me.txtUsuarioWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioWeb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsuarioWeb.Location = New System.Drawing.Point(122, 327)
        Me.txtUsuarioWeb.Name = "txtUsuarioWeb"
        Me.txtUsuarioWeb.Size = New System.Drawing.Size(133, 21)
        Me.txtUsuarioWeb.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Contraseña .KEY"
        '
        'txtClaveKEY
        '
        Me.txtClaveKEY.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtClaveKEY.Border.Class = "TextBoxBorder"
        Me.txtClaveKEY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClaveKEY.Enabled = False
        Me.txtClaveKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveKEY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtClaveKEY.Location = New System.Drawing.Point(122, 298)
        Me.txtClaveKEY.Name = "txtClaveKEY"
        Me.txtClaveKEY.Size = New System.Drawing.Size(133, 21)
        Me.txtClaveKEY.TabIndex = 7
        Me.txtClaveKEY.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Archivo .CER"
        '
        'btnArchivoCER
        '
        Me.btnArchivoCER.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnArchivoCER.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnArchivoCER.Location = New System.Drawing.Point(911, 269)
        Me.btnArchivoCER.Name = "btnArchivoCER"
        Me.btnArchivoCER.Size = New System.Drawing.Size(23, 21)
        Me.btnArchivoCER.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnArchivoCER.TabIndex = 6
        Me.btnArchivoCER.Text = "..."
        '
        'txtArchivoCER
        '
        Me.txtArchivoCER.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtArchivoCER.Border.Class = "TextBoxBorder"
        Me.txtArchivoCER.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtArchivoCER.Enabled = False
        Me.txtArchivoCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivoCER.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtArchivoCER.Location = New System.Drawing.Point(122, 269)
        Me.txtArchivoCER.Name = "txtArchivoCER"
        Me.txtArchivoCER.Size = New System.Drawing.Size(783, 21)
        Me.txtArchivoCER.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Archivo .KEY"
        '
        'btnArchivoKEY
        '
        Me.btnArchivoKEY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnArchivoKEY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnArchivoKEY.Location = New System.Drawing.Point(911, 240)
        Me.btnArchivoKEY.Name = "btnArchivoKEY"
        Me.btnArchivoKEY.Size = New System.Drawing.Size(23, 21)
        Me.btnArchivoKEY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnArchivoKEY.TabIndex = 4
        Me.btnArchivoKEY.Text = "..."
        '
        'txtArchivoKEY
        '
        Me.txtArchivoKEY.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtArchivoKEY.Border.Class = "TextBoxBorder"
        Me.txtArchivoKEY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtArchivoKEY.Enabled = False
        Me.txtArchivoKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivoKEY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtArchivoKEY.Location = New System.Drawing.Point(122, 240)
        Me.txtArchivoKEY.Name = "txtArchivoKEY"
        Me.txtArchivoKEY.Size = New System.Drawing.Size(783, 21)
        Me.txtArchivoKEY.TabIndex = 3
        '
        'btnPrueba
        '
        '
        '
        '
        Me.btnPrueba.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnPrueba.Location = New System.Drawing.Point(122, 211)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.OffText = "NO"
        Me.btnPrueba.OnText = "SI"
        Me.btnPrueba.Size = New System.Drawing.Size(133, 23)
        Me.btnPrueba.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrueba.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Info. de prueba"
        '
        'cmbAnoPeriodo
        '
        Me.cmbAnoPeriodo.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbAnoPeriodo.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbAnoPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbAnoPeriodo.ButtonDropDown.Visible = True
        Me.cmbAnoPeriodo.Columns.Add(Me.ColumnHeader3)
        Me.cmbAnoPeriodo.Columns.Add(Me.ColumnHeader4)
        Me.cmbAnoPeriodo.Columns.Add(Me.ColumnHeader5)
        Me.cmbAnoPeriodo.Columns.Add(Me.ColumnHeader6)
        Me.cmbAnoPeriodo.Columns.Add(Me.ColumnHeader7)
        Me.cmbAnoPeriodo.DropDownHeight = 180
        Me.cmbAnoPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnoPeriodo.FormatString = "d"
        Me.cmbAnoPeriodo.FormattingEnabled = True
        Me.cmbAnoPeriodo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbAnoPeriodo.Location = New System.Drawing.Point(328, 12)
        Me.cmbAnoPeriodo.Name = "cmbAnoPeriodo"
        Me.cmbAnoPeriodo.Size = New System.Drawing.Size(602, 23)
        Me.cmbAnoPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbAnoPeriodo.TabIndex = 0
        Me.cmbAnoPeriodo.ValueMember = "unico"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DataFieldName = "unico"
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "UNICO"
        Me.ColumnHeader3.Visible = False
        Me.ColumnHeader3.Width.Absolute = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DataFieldName = "ano"
        Me.ColumnHeader4.Name = "ColumnHeader4"
        Me.ColumnHeader4.Text = "AÑO"
        Me.ColumnHeader4.Width.Relative = 20
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DataFieldName = "periodo"
        Me.ColumnHeader5.Name = "ColumnHeader5"
        Me.ColumnHeader5.Text = "PERIODO"
        Me.ColumnHeader5.Width.Relative = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DataFieldName = "fecha_ini"
        Me.ColumnHeader6.Name = "ColumnHeader6"
        Me.ColumnHeader6.Text = "FECHA INICIO"
        Me.ColumnHeader6.Width.Relative = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DataFieldName = "fecha_fin"
        Me.ColumnHeader7.Name = "ColumnHeader7"
        Me.ColumnHeader7.Text = "FECHA FIN"
        Me.ColumnHeader7.Width.Relative = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 15)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Año/periodo"
        '
        'gpControles
        '
        Me.gpControles.Controls.Add(Me.btnExportar)
        Me.gpControles.Controls.Add(Me.btnCancelar)
        Me.gpControles.Location = New System.Drawing.Point(742, 584)
        Me.gpControles.Name = "gpControles"
        Me.gpControles.Size = New System.Drawing.Size(212, 50)
        Me.gpControles.TabIndex = 1
        Me.gpControles.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.CausesValidation = False
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = Global.PIDA.My.Resources.Resources.Export24
        Me.btnExportar.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.btnExportar.ImageTextSpacing = 5
        Me.btnExportar.Location = New System.Drawing.Point(10, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(94, 28)
        Me.btnExportar.TabIndex = 0
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.PIDA.My.Resources.Resources.CancelX
        Me.btnCancelar.ImageTextSpacing = 5
        Me.btnCancelar.Location = New System.Drawing.Point(110, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 28)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cerrar"
        Me.btnCancelar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'dlgArchivo
        '
        Me.dlgArchivo.FileName = "OpenFileDialog1"
        '
        'bgTimbrado
        '
        Me.bgTimbrado.WorkerReportsProgress = True
        Me.bgTimbrado.WorkerSupportsCancellation = True
        '
        'tmrTranscurre
        '
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.CausesValidation = False
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.PIDA.My.Resources.Resources.catalog24
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.ButtonX1.ImageTextSpacing = 5
        Me.ButtonX1.Location = New System.Drawing.Point(12, 603)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(94, 28)
        Me.ButtonX1.TabIndex = 114
        Me.ButtonX1.Text = "Bitácora"
        Me.ButtonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 15)
        Me.Label15.TabIndex = 288
        Me.Label15.Text = "Versión 4.0 CFDI"
        '
        'btnVers4Cfdi
        '
        '
        '
        '
        Me.btnVers4Cfdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnVers4Cfdi.Location = New System.Drawing.Point(121, 156)
        Me.btnVers4Cfdi.Name = "btnVers4Cfdi"
        Me.btnVers4Cfdi.OffText = "NO"
        Me.btnVers4Cfdi.OnText = "SI"
        Me.btnVers4Cfdi.Size = New System.Drawing.Size(133, 23)
        Me.btnVers4Cfdi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVers4Cfdi.TabIndex = 289
        '
        'frmRecibosCFDI2017
        '
        Me.AcceptButton = Me.btnExportar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(964, 634)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.gpControles)
        Me.Controls.Add(Me.gpParametros)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecibosCFDI2017"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "r"
        Me.gpParametros.ResumeLayout(False)
        Me.gpParametros.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtFecPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpAvance.ResumeLayout(False)
        Me.gpControles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents gpParametros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbAnoPeriodo As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnPrueba As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnArchivoKEY As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtArchivoKEY As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDirectorioArchivos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDirectorioArchivos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDirectorioCD As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDirectorioCD As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClaveWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClaveKEY As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnArchivoCER As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtArchivoCER As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dlgArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbCia As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents txtRiesgo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBanco As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader4 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader5 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader6 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader7 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents gpAvance As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pbAvance As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents bgTimbrado As System.ComponentModel.BackgroundWorker
    Friend WithEvents PreguntaArchivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tmrTranscurre As System.Windows.Forms.Timer
    Friend WithEvents lblAvance As System.Windows.Forms.Label
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnValidarLista As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtListaRelojes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbLista As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sbEmail As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbTipoPeriodo As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents ColumnHeader8 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader9 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents chkFecPago As System.Windows.Forms.CheckBox
    Private WithEvents txtFecPago As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtEntidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CircularProgress4 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lblCargaXml As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkPtuBajas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPtuAltas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPtu As System.Windows.Forms.CheckBox
    Friend WithEvents btnVers4Cfdi As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
