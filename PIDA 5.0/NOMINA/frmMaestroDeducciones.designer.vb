<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaestroDeducciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaestroDeducciones))
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtHorario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtTurno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtClase = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtSupervisor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtTipoEmp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtDepto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblEstado = New DevComponents.DotNetBar.LabelX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgMaestro = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSemanas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaldoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaldoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColComentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSemRestan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prorratear = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColProrratearMes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColAbonoMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaldoMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAbonoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSemTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSemRestMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabBuscar = New DevComponents.DotNetBar.SuperTabControl()
        Me.pnlDatos = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.tabEmpleado = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.dgSaldos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblIntereses = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.lblAbonos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbConcepto = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader()
        Me.tabTabla = New DevComponents.DotNetBar.SuperTabItem()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBaja = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gbReloj = New System.Windows.Forms.GroupBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtReloj = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.picStatus = New System.Windows.Forms.PictureBox()
        Me.btnFirst = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrev = New DevComponents.DotNetBar.ButtonX()
        Me.btnNext = New DevComponents.DotNetBar.ButtonX()
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnBorrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnLast = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.btnReporte = New DevComponents.DotNetBar.ButtonX()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        CType(Me.dgMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBuscar.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.dgSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbReloj.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.SystemColors.Control
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(441, 33)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(48, 15)
        Me.Label72.TabIndex = 149
        Me.Label72.Text = "Horario"
        '
        'txtHorario
        '
        Me.txtHorario.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtHorario.Border.Class = "TextBoxBorder"
        Me.txtHorario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.ForeColor = System.Drawing.Color.Black
        Me.txtHorario.Location = New System.Drawing.Point(526, 30)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.ReadOnly = True
        Me.txtHorario.Size = New System.Drawing.Size(181, 21)
        Me.txtHorario.TabIndex = 148
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.SystemColors.Control
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(441, 9)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(39, 15)
        Me.Label69.TabIndex = 147
        Me.Label69.Text = "Turno"
        '
        'txtTurno
        '
        Me.txtTurno.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtTurno.Border.Class = "TextBoxBorder"
        Me.txtTurno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurno.ForeColor = System.Drawing.Color.Black
        Me.txtTurno.Location = New System.Drawing.Point(526, 6)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.ReadOnly = True
        Me.txtTurno.Size = New System.Drawing.Size(181, 21)
        Me.txtTurno.TabIndex = 146
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.SystemColors.Control
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(441, 81)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(38, 15)
        Me.Label70.TabIndex = 145
        Me.Label70.Text = "Clase"
        '
        'txtClase
        '
        Me.txtClase.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtClase.Border.Class = "TextBoxBorder"
        Me.txtClase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClase.ForeColor = System.Drawing.Color.Black
        Me.txtClase.Location = New System.Drawing.Point(526, 78)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.ReadOnly = True
        Me.txtClase.Size = New System.Drawing.Size(181, 21)
        Me.txtClase.TabIndex = 144
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.SystemColors.Control
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(441, 105)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(65, 15)
        Me.Label71.TabIndex = 143
        Me.Label71.Text = "Supervisor"
        '
        'txtSupervisor
        '
        Me.txtSupervisor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSupervisor.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtSupervisor.Border.Class = "TextBoxBorder"
        Me.txtSupervisor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisor.ForeColor = System.Drawing.Color.Black
        Me.txtSupervisor.Location = New System.Drawing.Point(526, 102)
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.ReadOnly = True
        Me.txtSupervisor.Size = New System.Drawing.Size(181, 21)
        Me.txtSupervisor.TabIndex = 142
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.SystemColors.Control
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(441, 57)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(79, 15)
        Me.Label68.TabIndex = 141
        Me.Label68.Text = "Tipo de emp."
        '
        'txtTipoEmp
        '
        Me.txtTipoEmp.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtTipoEmp.Border.Class = "TextBoxBorder"
        Me.txtTipoEmp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTipoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEmp.ForeColor = System.Drawing.Color.Black
        Me.txtTipoEmp.Location = New System.Drawing.Point(526, 54)
        Me.txtTipoEmp.Name = "txtTipoEmp"
        Me.txtTipoEmp.ReadOnly = True
        Me.txtTipoEmp.Size = New System.Drawing.Size(181, 21)
        Me.txtTipoEmp.TabIndex = 140
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.SystemColors.Control
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(39, 105)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(86, 15)
        Me.Label67.TabIndex = 139
        Me.Label67.Text = "Departamento"
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtDepto.Border.Class = "TextBoxBorder"
        Me.txtDepto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepto.ForeColor = System.Drawing.Color.Black
        Me.txtDepto.Location = New System.Drawing.Point(138, 102)
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.Size = New System.Drawing.Size(297, 21)
        Me.txtDepto.TabIndex = 138
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
        Me.lblEstado.Size = New System.Drawing.Size(29, 115)
        Me.lblEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblEstado.TabIndex = 134
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
        Me.Label5.TabIndex = 130
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
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(39, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(396, 21)
        Me.txtNombre.TabIndex = 126
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btnFirst)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Location = New System.Drawing.Point(0, 487)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 35)
        Me.Panel1.TabIndex = 151
        '
        'dgMaestro
        '
        Me.dgMaestro.AllowUserToAddRows = False
        Me.dgMaestro.AllowUserToDeleteRows = False
        Me.dgMaestro.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgMaestro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMaestro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaestro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMaestro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColCredito, Me.ColPeriodo, Me.ColAno, Me.ColSemanas, Me.ColSaldoInicial, Me.ColAbono, Me.ColSaldoActual, Me.ColTasa, Me.ColActivo, Me.ColComentario, Me.ColDetalle, Me.ColSemRestan, Me.Prorratear, Me.ColProrratearMes, Me.ColAbonoMes, Me.ColSaldoMes, Me.ColAbonoActual, Me.ColSemTrans, Me.ColSemRestMes, Me.ColCodigo})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaestro.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgMaestro.EnableHeadersVisualStyles = False
        Me.dgMaestro.GridColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.dgMaestro.Location = New System.Drawing.Point(0, 3)
        Me.dgMaestro.Name = "dgMaestro"
        Me.dgMaestro.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaestro.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgMaestro.RowHeadersVisible = False
        Me.dgMaestro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMaestro.Size = New System.Drawing.Size(917, 349)
        Me.dgMaestro.TabIndex = 244
        '
        'ColConcepto
        '
        Me.ColConcepto.DataPropertyName = "nombre"
        Me.ColConcepto.Frozen = True
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.ReadOnly = True
        Me.ColConcepto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColConcepto.Width = 130
        '
        'ColCredito
        '
        Me.ColCredito.DataPropertyName = "numcredito"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColCredito.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCredito.Frozen = True
        Me.ColCredito.HeaderText = "# Crédito"
        Me.ColCredito.Name = "ColCredito"
        Me.ColCredito.ReadOnly = True
        Me.ColCredito.Width = 60
        '
        'ColPeriodo
        '
        Me.ColPeriodo.DataPropertyName = "periodo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColPeriodo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColPeriodo.HeaderText = "Periodo"
        Me.ColPeriodo.Name = "ColPeriodo"
        Me.ColPeriodo.ReadOnly = True
        Me.ColPeriodo.Width = 60
        '
        'ColAno
        '
        Me.ColAno.DataPropertyName = "ano"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColAno.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColAno.HeaderText = "Año"
        Me.ColAno.Name = "ColAno"
        Me.ColAno.ReadOnly = True
        Me.ColAno.Width = 40
        '
        'ColSemanas
        '
        Me.ColSemanas.DataPropertyName = "semanas_desc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSemanas.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColSemanas.HeaderText = "#Sem."
        Me.ColSemanas.Name = "ColSemanas"
        Me.ColSemanas.ReadOnly = True
        Me.ColSemanas.Width = 40
        '
        'ColSaldoInicial
        '
        Me.ColSaldoInicial.DataPropertyName = "saldo_orig"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        Me.ColSaldoInicial.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColSaldoInicial.HeaderText = "Saldo inicial"
        Me.ColSaldoInicial.Name = "ColSaldoInicial"
        Me.ColSaldoInicial.ReadOnly = True
        Me.ColSaldoInicial.Width = 70
        '
        'ColAbono
        '
        Me.ColAbono.DataPropertyName = "abono_orig"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.ColAbono.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColAbono.HeaderText = "Abono"
        Me.ColAbono.Name = "ColAbono"
        Me.ColAbono.ReadOnly = True
        Me.ColAbono.Width = 70
        '
        'ColSaldoActual
        '
        Me.ColSaldoActual.DataPropertyName = "saldo_act"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "C2"
        Me.ColSaldoActual.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColSaldoActual.HeaderText = "Saldo sem. actual"
        Me.ColSaldoActual.Name = "ColSaldoActual"
        Me.ColSaldoActual.ReadOnly = True
        Me.ColSaldoActual.Width = 70
        '
        'ColTasa
        '
        Me.ColTasa.DataPropertyName = "tasa_int_sem"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.ColTasa.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColTasa.HeaderText = "Tasa int. sem."
        Me.ColTasa.Name = "ColTasa"
        Me.ColTasa.ReadOnly = True
        Me.ColTasa.Width = 50
        '
        'ColActivo
        '
        Me.ColActivo.DataPropertyName = "status"
        Me.ColActivo.HeaderText = "Activo"
        Me.ColActivo.Name = "ColActivo"
        Me.ColActivo.ReadOnly = True
        Me.ColActivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColActivo.Width = 50
        '
        'ColComentario
        '
        Me.ColComentario.DataPropertyName = "comentario"
        Me.ColComentario.HeaderText = "Comentario"
        Me.ColComentario.Name = "ColComentario"
        Me.ColComentario.ReadOnly = True
        Me.ColComentario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColComentario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColComentario.Width = 300
        '
        'ColDetalle
        '
        Me.ColDetalle.DataPropertyName = "detalle"
        Me.ColDetalle.HeaderText = "Detalle"
        Me.ColDetalle.Name = "ColDetalle"
        Me.ColDetalle.ReadOnly = True
        '
        'ColSemRestan
        '
        Me.ColSemRestan.DataPropertyName = "sem_restan"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSemRestan.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColSemRestan.HeaderText = "Sem. rest."
        Me.ColSemRestan.Name = "ColSemRestan"
        Me.ColSemRestan.ReadOnly = True
        Me.ColSemRestan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSemRestan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSemRestan.Width = 40
        '
        'Prorratear
        '
        Me.Prorratear.DataPropertyName = "prorratear"
        Me.Prorratear.HeaderText = "Prorrateo total"
        Me.Prorratear.Name = "Prorratear"
        Me.Prorratear.ReadOnly = True
        Me.Prorratear.Width = 60
        '
        'ColProrratearMes
        '
        Me.ColProrratearMes.DataPropertyName = "prorratear_mes"
        Me.ColProrratearMes.HeaderText = "Prorrateo mensual"
        Me.ColProrratearMes.Name = "ColProrratearMes"
        Me.ColProrratearMes.ReadOnly = True
        Me.ColProrratearMes.Width = 60
        '
        'ColAbonoMes
        '
        Me.ColAbonoMes.DataPropertyName = "abono_mes"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "c2"
        Me.ColAbonoMes.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColAbonoMes.HeaderText = "Abono mensual"
        Me.ColAbonoMes.Name = "ColAbonoMes"
        Me.ColAbonoMes.ReadOnly = True
        Me.ColAbonoMes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColAbonoMes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColAbonoMes.Width = 70
        '
        'ColSaldoMes
        '
        Me.ColSaldoMes.DataPropertyName = "saldo_mes"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "c2"
        Me.ColSaldoMes.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColSaldoMes.HeaderText = "Saldo mensual"
        Me.ColSaldoMes.Name = "ColSaldoMes"
        Me.ColSaldoMes.ReadOnly = True
        Me.ColSaldoMes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSaldoMes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSaldoMes.Width = 70
        '
        'ColAbonoActual
        '
        Me.ColAbonoActual.DataPropertyName = "abono_act"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "c2"
        Me.ColAbonoActual.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColAbonoActual.HeaderText = "Abono actual"
        Me.ColAbonoActual.Name = "ColAbonoActual"
        Me.ColAbonoActual.ReadOnly = True
        Me.ColAbonoActual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColAbonoActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColAbonoActual.Width = 70
        '
        'ColSemTrans
        '
        Me.ColSemTrans.DataPropertyName = "sem_trans"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSemTrans.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColSemTrans.HeaderText = "Semanas trans."
        Me.ColSemTrans.Name = "ColSemTrans"
        Me.ColSemTrans.ReadOnly = True
        Me.ColSemTrans.Width = 60
        '
        'ColSemRestMes
        '
        Me.ColSemRestMes.DataPropertyName = "sem_rest_mes"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSemRestMes.DefaultCellStyle = DataGridViewCellStyle16
        Me.ColSemRestMes.HeaderText = "Sem. rest. mes"
        Me.ColSemRestMes.Name = "ColSemRestMes"
        Me.ColSemRestMes.ReadOnly = True
        Me.ColSemRestMes.Width = 60
        '
        'ColCodigo
        '
        Me.ColCodigo.DataPropertyName = "concepto"
        Me.ColCodigo.HeaderText = "Codigo"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Visible = False
        '
        'tabBuscar
        '
        Me.tabBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        '
        '
        '
        Me.tabBuscar.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.tabBuscar.ControlBox.MenuBox.Name = ""
        Me.tabBuscar.ControlBox.MenuBox.Visible = False
        Me.tabBuscar.ControlBox.Name = ""
        Me.tabBuscar.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabBuscar.ControlBox.MenuBox, Me.tabBuscar.ControlBox.CloseBox})
        Me.tabBuscar.Controls.Add(Me.pnlDatos)
        Me.tabBuscar.Controls.Add(Me.SuperTabControlPanel2)
        Me.tabBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBuscar.Location = New System.Drawing.Point(6, 129)
        Me.tabBuscar.Name = "tabBuscar"
        Me.tabBuscar.ReorderTabsEnabled = True
        Me.tabBuscar.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabBuscar.SelectedTabIndex = 0
        Me.tabBuscar.Size = New System.Drawing.Size(992, 352)
        Me.tabBuscar.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.tabBuscar.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBuscar.TabIndex = 247
        Me.tabBuscar.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit
        Me.tabBuscar.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabEmpleado, Me.tabTabla})
        Me.tabBuscar.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.dgMaestro)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatos.Location = New System.Drawing.Point(0, 0)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(917, 352)
        Me.pnlDatos.TabIndex = 0
        Me.pnlDatos.TabItem = Me.tabEmpleado
        '
        'tabEmpleado
        '
        Me.tabEmpleado.AttachedControl = Me.pnlDatos
        Me.tabEmpleado.GlobalItem = False
        Me.tabEmpleado.Name = "tabEmpleado"
        Me.tabEmpleado.Text = "Maestro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de deduc."
        Me.tabEmpleado.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.dgSaldos)
        Me.SuperTabControlPanel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SuperTabControlPanel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(917, 352)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.tabTabla
        '
        'dgSaldos
        '
        Me.dgSaldos.AllowUserToAddRows = False
        Me.dgSaldos.AllowUserToDeleteRows = False
        Me.dgSaldos.AllowUserToOrderColumns = True
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgSaldos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSaldos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSaldos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column3})
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSaldos.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgSaldos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSaldos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgSaldos.EnableHeadersVisualStyles = False
        Me.dgSaldos.GridColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.dgSaldos.Location = New System.Drawing.Point(0, 37)
        Me.dgSaldos.Name = "dgSaldos"
        Me.dgSaldos.ReadOnly = True
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSaldos.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgSaldos.RowHeadersVisible = False
        Me.dgSaldos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Lime
        Me.dgSaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgSaldos.Size = New System.Drawing.Size(917, 272)
        Me.dgSaldos.TabIndex = 301
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ano"
        Me.Column1.HeaderText = "Año"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "periodo"
        Me.Column2.HeaderText = "Periodo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "saldo_ant"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "c2"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column4.HeaderText = "Saldo anterior"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "abono"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "c2"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column5.HeaderText = "Abono"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 75
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "saldo"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "c2"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column6.HeaderText = "Saldo actual"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 75
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "intereses"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "c2"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle24
        Me.Column7.HeaderText = "Intereses"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.DataPropertyName = "comentario"
        Me.Column8.HeaderText = "Comentario"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "concepto"
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblIntereses, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSaldoActual, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAbonos, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSaldoInicial, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 309)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(917, 43)
        Me.TableLayoutPanel2.TabIndex = 247
        '
        'lblIntereses
        '
        Me.lblIntereses.AutoSize = True
        Me.lblIntereses.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblIntereses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIntereses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntereses.Location = New System.Drawing.Point(735, 23)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblIntereses.Size = New System.Drawing.Size(179, 20)
        Me.lblIntereses.TabIndex = 7
        Me.lblIntereses.Text = "$0.00"
        Me.lblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.AutoSize = True
        Me.lblSaldoActual.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblSaldoActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaldoActual.Location = New System.Drawing.Point(369, 23)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblSaldoActual.Size = New System.Drawing.Size(360, 20)
        Me.lblSaldoActual.TabIndex = 6
        Me.lblSaldoActual.Text = "$0.00"
        Me.lblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAbonos
        '
        Me.lblAbonos.AutoSize = True
        Me.lblAbonos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblAbonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbonos.Location = New System.Drawing.Point(186, 23)
        Me.lblAbonos.Name = "lblAbonos"
        Me.lblAbonos.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblAbonos.Size = New System.Drawing.Size(177, 20)
        Me.lblAbonos.TabIndex = 5
        Me.lblAbonos.Text = "$0.00"
        Me.lblAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(735, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Intereses"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(369, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(360, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Saldo actual"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Abonos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Saldo inicial"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblSaldoInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoInicial.Location = New System.Drawing.Point(3, 23)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblSaldoInicial.Size = New System.Drawing.Size(177, 20)
        Me.lblSaldoInicial.TabIndex = 4
        Me.lblSaldoInicial.Text = "$0.00"
        Me.lblSaldoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65863!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.34136!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.picStatus, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbConcepto, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.68116!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(917, 37)
        Me.TableLayoutPanel1.TabIndex = 246
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Location = New System.Drawing.Point(733, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(101, 37)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "LIQUIDADO"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbConcepto
        '
        Me.cbConcepto.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cbConcepto.BackgroundStyle.Class = "TextBoxBorder"
        Me.cbConcepto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbConcepto.ButtonDropDown.Visible = True
        Me.cbConcepto.Columns.Add(Me.ColumnHeader1)
        Me.cbConcepto.Columns.Add(Me.ColumnHeader2)
        Me.cbConcepto.Columns.Add(Me.ColumnHeader3)
        Me.cbConcepto.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbConcepto.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cbConcepto.Location = New System.Drawing.Point(110, 3)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.Size = New System.Drawing.Size(617, 23)
        Me.cbConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbConcepto.TabIndex = 7
        Me.cbConcepto.ValueMember = "numcredito"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DataFieldName = "concepto"
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width.Absolute = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DataFieldName = "nombre"
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.StretchToFill = True
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width.Absolute = 150
        Me.ColumnHeader2.Width.AutoSize = True
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DataFieldName = "numcredito"
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "Núm. crédito"
        Me.ColumnHeader3.Width.Absolute = 150
        '
        'tabTabla
        '
        Me.tabTabla.AttachedControl = Me.SuperTabControlPanel2
        Me.tabTabla.GlobalItem = False
        Me.tabTabla.Name = "tabTabla"
        Me.tabTabla.Text = "Estado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de cuenta"
        Me.tabTabla.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
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
        Me.ReflectionLabel1.Size = New System.Drawing.Size(398, 40)
        Me.ReflectionLabel1.TabIndex = 248
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>MAESTRO DE DEDUCCIONES</b></font>"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.picFoto)
        Me.Panel3.Controls.Add(Me.txtBaja)
        Me.Panel3.Controls.Add(Me.txtAlta)
        Me.Panel3.Controls.Add(Me.gbReloj)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblBaja)
        Me.Panel3.Location = New System.Drawing.Point(713, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 117)
        Me.Panel3.TabIndex = 249
        '
        'txtBaja
        '
        Me.txtBaja.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtBaja.Border.Class = "TextBoxBorder"
        Me.txtBaja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaja.ForeColor = System.Drawing.Color.Black
        Me.txtBaja.Location = New System.Drawing.Point(93, 76)
        Me.txtBaja.Name = "txtBaja"
        Me.txtBaja.ReadOnly = True
        Me.txtBaja.Size = New System.Drawing.Size(101, 21)
        Me.txtBaja.TabIndex = 251
        Me.txtBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlta
        '
        Me.txtAlta.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtAlta.Border.Class = "TextBoxBorder"
        Me.txtAlta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlta.ForeColor = System.Drawing.Color.Black
        Me.txtAlta.Location = New System.Drawing.Point(93, 46)
        Me.txtAlta.Name = "txtAlta"
        Me.txtAlta.ReadOnly = True
        Me.txtAlta.Size = New System.Drawing.Size(101, 21)
        Me.txtAlta.TabIndex = 250
        Me.txtAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbReloj
        '
        Me.gbReloj.Controls.Add(Me.LabelX4)
        Me.gbReloj.Controls.Add(Me.txtReloj)
        Me.gbReloj.Location = New System.Drawing.Point(10, 4)
        Me.gbReloj.Name = "gbReloj"
        Me.gbReloj.Size = New System.Drawing.Size(190, 41)
        Me.gbReloj.TabIndex = 0
        Me.gbReloj.TabStop = False
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(11, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(52, 23)
        Me.LabelX4.TabIndex = 36
        Me.LabelX4.Text = "Reloj"
        '
        'txtReloj
        '
        '
        '
        '
        Me.txtReloj.Border.Class = "TextBoxBorder"
        Me.txtReloj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReloj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtReloj.Location = New System.Drawing.Point(69, 10)
        Me.txtReloj.MaxLength = 6
        Me.txtReloj.Name = "txtReloj"
        Me.txtReloj.ReadOnly = True
        Me.txtReloj.Size = New System.Drawing.Size(115, 26)
        Me.txtReloj.TabIndex = 0
        Me.txtReloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Fecha de alta"
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaja.Location = New System.Drawing.Point(7, 78)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(85, 15)
        Me.lblBaja.TabIndex = 49
        Me.lblBaja.Text = "Fecha de baja"
        '
        'picFoto
        '
        Me.picFoto.Dock = System.Windows.Forms.DockStyle.Right
        Me.picFoto.ErrorImage = Global.PIDA.My.Resources.Resources.NoFoto
        Me.picFoto.Image = Global.PIDA.My.Resources.Resources.NoFoto
        Me.picFoto.InitialImage = Global.PIDA.My.Resources.Resources.NoFoto
        Me.picFoto.Location = New System.Drawing.Point(203, 0)
        Me.picFoto.MaximumSize = New System.Drawing.Size(164, 210)
        Me.picFoto.MinimumSize = New System.Drawing.Size(82, 105)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(82, 117)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 12
        Me.picFoto.TabStop = False
        '
        'picStatus
        '
        Me.picStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.picStatus.Image = Global.PIDA.My.Resources.Resources.Cancel
        Me.picStatus.Location = New System.Drawing.Point(840, 3)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(74, 31)
        Me.picStatus.TabIndex = 5
        Me.picStatus.TabStop = False
        '
        'btnFirst
        '
        Me.btnFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFirst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFirst.Image = Global.PIDA.My.Resources.Resources.First16
        Me.btnFirst.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnFirst.Location = New System.Drawing.Point(101, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(78, 25)
        Me.btnFirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFirst.TabIndex = 33
        Me.btnFirst.Text = "Inicio"
        '
        'btnPrev
        '
        Me.btnPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrev.Image = Global.PIDA.My.Resources.Resources.Prev16
        Me.btnPrev.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnPrev.Location = New System.Drawing.Point(182, 3)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(78, 25)
        Me.btnPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrev.TabIndex = 34
        Me.btnPrev.Text = "Anterior"
        '
        'btnNext
        '
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNext.Image = Global.PIDA.My.Resources.Resources.Next16
        Me.btnNext.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnNext.Location = New System.Drawing.Point(263, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(78, 25)
        Me.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = "Siguiente"
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.CausesValidation = False
        Me.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.PIDA.My.Resources.Resources.Edit
        Me.btnEditar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnEditar.Location = New System.Drawing.Point(667, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 25)
        Me.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEditar.TabIndex = 40
        Me.btnEditar.Text = "Editar"
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.CausesValidation = False
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.PIDA.My.Resources.Resources.CancelX
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(829, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(78, 25)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 42
        Me.btnCerrar.Text = "Salir"
        '
        'btnBorrar
        '
        Me.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.CausesValidation = False
        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = Global.PIDA.My.Resources.Resources.Cancel2_16
        Me.btnBorrar.Location = New System.Drawing.Point(748, 3)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(78, 25)
        Me.btnBorrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBorrar.TabIndex = 41
        Me.btnBorrar.Text = "Cancelar"
        '
        'btnLast
        '
        Me.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLast.Image = Global.PIDA.My.Resources.Resources.Last16
        Me.btnLast.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnLast.Location = New System.Drawing.Point(344, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(78, 25)
        Me.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLast.TabIndex = 36
        Me.btnLast.Text = "Final"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.CausesValidation = False
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.PIDA.My.Resources.Resources.NewRecord
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnNuevo.Location = New System.Drawing.Point(587, 2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 25)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 39
        Me.btnNuevo.Text = "Agregar"
        '
        'btnReporte
        '
        Me.btnReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.CausesValidation = False
        Me.btnReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Image = Global.PIDA.My.Resources.Resources.Reporte16
        Me.btnReporte.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnReporte.Location = New System.Drawing.Point(505, 3)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(78, 25)
        Me.btnReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReporte.TabIndex = 38
        Me.btnReporte.Text = "Reporte"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.CausesValidation = False
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.PIDA.My.Resources.Resources.Search16
        Me.btnBuscar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnBuscar.Location = New System.Drawing.Point(424, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 25)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Tooltip = "Buscar"
        '
        'frmMaestroDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1007, 522)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.tabBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.txtClase)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.txtSupervisor)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.txtTipoEmp)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaestroDeducciones"
        Me.Text = "Maestro de deducciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgMaestro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBuscar.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.dgSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbReloj.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtHorario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtTurno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtClase As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtSupervisor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtTipoEmp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtDepto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFirst As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrev As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLast As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReporte As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgMaestro As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabBuscar As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents pnlDatos As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents tabEmpleado As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents tabTabla As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents dgSaldos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblIntereses As System.Windows.Forms.Label
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents lblAbonos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoInicial As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cbConcepto As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents dlgArchivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPeriodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSemanas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSaldoInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSaldoActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColActivo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColComentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSemRestan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prorratear As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColProrratearMes As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColAbonoMes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSaldoMes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAbonoActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSemTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSemRestMes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtBaja As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gbReloj As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtReloj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblBaja As System.Windows.Forms.Label
End Class
