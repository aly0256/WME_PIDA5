﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPolizas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPolizas))
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader5 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader6 = New DevComponents.AdvTree.ColumnHeader()
        Me.gpControles = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.btnProcesar = New DevComponents.DotNetBar.ButtonX()
        Me.txtPeriodos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgPolizas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion_archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trPeriodos = New DevComponents.AdvTree.AdvTree()
        Me.ColPeriodo = New DevComponents.AdvTree.ColumnHeader()
        Me.column_periodo = New DevComponents.AdvTree.ColumnHeader()
        Me.ColFechaIni = New DevComponents.AdvTree.ColumnHeader()
        Me.ColFechaFin = New DevComponents.AdvTree.ColumnHeader()
        Me.ColMes = New DevComponents.AdvTree.ColumnHeader()
        Me.ColNombre = New DevComponents.AdvTree.ColumnHeader()
        Me.ColAnoP = New DevComponents.AdvTree.ColumnHeader()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.Node6 = New DevComponents.AdvTree.Node()
        Me.Cell2 = New DevComponents.AdvTree.Cell()
        Me.Cell3 = New DevComponents.AdvTree.Cell()
        Me.Cell4 = New DevComponents.AdvTree.Cell()
        Me.Cell5 = New DevComponents.AdvTree.Cell()
        Me.Cell1 = New DevComponents.AdvTree.Cell()
        Me.Node8 = New DevComponents.AdvTree.Node()
        Me.Cell6 = New DevComponents.AdvTree.Cell()
        Me.Cell7 = New DevComponents.AdvTree.Cell()
        Me.Cell8 = New DevComponents.AdvTree.Cell()
        Me.Cell9 = New DevComponents.AdvTree.Cell()
        Me.Node10 = New DevComponents.AdvTree.Node()
        Me.Node11 = New DevComponents.AdvTree.Node()
        Me.Node12 = New DevComponents.AdvTree.Node()
        Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
        Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle5 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle6 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle7 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle8 = New DevComponents.DotNetBar.ElementStyle()
        Me.cmbCompania = New DevComponents.DotNetBar.Controls.ComboTree()
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader4 = New DevComponents.AdvTree.ColumnHeader()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColumnHeader7 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader8 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader9 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader10 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader11 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader12 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader13 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader14 = New DevComponents.AdvTree.ColumnHeader()
        Me.dlgArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.gpParametros = New System.Windows.Forms.Panel()
        Me.sbGeneral = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.gpControles.SuspendLayout()
        CType(Me.dgPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(183, 23)
        Me.ReflectionLabel1.TabIndex = 80
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>PÓLIZAS</b></font>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Periodo"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Tipo de póliza"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DataFieldName = "tipo_pol"
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Tipo"
        Me.ColumnHeader1.Width.Absolute = 50
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
        'ColumnHeader5
        '
        Me.ColumnHeader5.DataFieldName = "cod_tipo"
        Me.ColumnHeader5.Name = "ColumnHeader5"
        Me.ColumnHeader5.Text = "Código"
        Me.ColumnHeader5.Width.Absolute = 50
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DataFieldName = "nombre"
        Me.ColumnHeader6.Name = "ColumnHeader6"
        Me.ColumnHeader6.StretchToFill = True
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width.Absolute = 150
        Me.ColumnHeader6.Width.AutoSize = True
        '
        'gpControles
        '
        Me.gpControles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpControles.Controls.Add(Me.btnSalir)
        Me.gpControles.Controls.Add(Me.btnProcesar)
        Me.gpControles.Location = New System.Drawing.Point(485, 373)
        Me.gpControles.Name = "gpControles"
        Me.gpControles.Size = New System.Drawing.Size(193, 52)
        Me.gpControles.TabIndex = 5
        Me.gpControles.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.CausesValidation = False
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.PIDA.My.Resources.Resources.Cancel16
        Me.btnSalir.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnSalir.Location = New System.Drawing.Point(99, 20)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 25)
        Me.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'btnProcesar
        '
        Me.btnProcesar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProcesar.CausesValidation = False
        Me.btnProcesar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Image = Global.PIDA.My.Resources.Resources.Set22
        Me.btnProcesar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnProcesar.Location = New System.Drawing.Point(6, 20)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(88, 25)
        Me.btnProcesar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Procesar"
        '
        'txtPeriodos
        '
        '
        '
        '
        Me.txtPeriodos.Border.Class = "TextBoxBorder"
        Me.txtPeriodos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPeriodos.Enabled = False
        Me.txtPeriodos.Location = New System.Drawing.Point(100, 36)
        Me.txtPeriodos.Name = "txtPeriodos"
        Me.txtPeriodos.Size = New System.Drawing.Size(578, 21)
        Me.txtPeriodos.TabIndex = 144
        '
        'dgPolizas
        '
        Me.dgPolizas.AllowUserToAddRows = False
        Me.dgPolizas.AllowUserToDeleteRows = False
        Me.dgPolizas.AllowUserToResizeColumns = False
        Me.dgPolizas.AllowUserToResizeRows = False
        Me.dgPolizas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPolizas.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgPolizas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.porcentaje, Me.provision, Me.Column2, Me.Column3, Me.nombre_archivo, Me.ubicacion_archivo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPolizas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgPolizas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgPolizas.HighlightSelectedColumnHeaders = False
        Me.dgPolizas.Location = New System.Drawing.Point(100, 358)
        Me.dgPolizas.Name = "dgPolizas"
        Me.dgPolizas.RowHeadersVisible = False
        Me.dgPolizas.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.[Default]
        Me.dgPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPolizas.Size = New System.Drawing.Size(379, 67)
        Me.dgPolizas.TabIndex = 143
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "selec"
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 80
        '
        'porcentaje
        '
        Me.porcentaje.DataPropertyName = "porcentaje"
        Me.porcentaje.HeaderText = "porcentaje"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.Visible = False
        '
        'provision
        '
        Me.provision.DataPropertyName = "provision"
        Me.provision.HeaderText = "provision"
        Me.provision.Name = "provision"
        Me.provision.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "tipo_pol"
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "nombre"
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.Name = "Column3"
        '
        'nombre_archivo
        '
        Me.nombre_archivo.DataPropertyName = "nombre_archivo"
        Me.nombre_archivo.HeaderText = "nombre_archivo"
        Me.nombre_archivo.Name = "nombre_archivo"
        Me.nombre_archivo.Visible = False
        '
        'ubicacion_archivo
        '
        Me.ubicacion_archivo.DataPropertyName = "ubicacion_archivo"
        Me.ubicacion_archivo.HeaderText = "ubicacion_archivo"
        Me.ubicacion_archivo.Name = "ubicacion_archivo"
        Me.ubicacion_archivo.Visible = False
        '
        'trPeriodos
        '
        Me.trPeriodos.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.trPeriodos.AllowDrop = True
        Me.trPeriodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trPeriodos.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.trPeriodos.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.trPeriodos.BackgroundStyle.Class = "TreeBorderKey"
        Me.trPeriodos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.trPeriodos.Columns.Add(Me.ColPeriodo)
        Me.trPeriodos.Columns.Add(Me.column_periodo)
        Me.trPeriodos.Columns.Add(Me.ColFechaIni)
        Me.trPeriodos.Columns.Add(Me.ColFechaFin)
        Me.trPeriodos.Columns.Add(Me.ColMes)
        Me.trPeriodos.Columns.Add(Me.ColNombre)
        Me.trPeriodos.Columns.Add(Me.ColAnoP)
        Me.trPeriodos.DragDropEnabled = False
        Me.trPeriodos.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
        Me.trPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trPeriodos.GroupNodeStyle = Me.ElementStyle1
        Me.trPeriodos.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.trPeriodos.Location = New System.Drawing.Point(100, 63)
        Me.trPeriodos.MultiNodeDragDropAllowed = False
        Me.trPeriodos.Name = "trPeriodos"
        Me.trPeriodos.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.trPeriodos.NodesColumnsBackgroundStyle = Me.ElementStyle3
        Me.trPeriodos.NodesConnector = Me.NodeConnector2
        Me.trPeriodos.NodeSpacing = 5
        Me.trPeriodos.NodeStyle = Me.ElementStyle1
        Me.trPeriodos.PathSeparator = ";"
        Me.trPeriodos.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
        Me.trPeriodos.Size = New System.Drawing.Size(578, 289)
        Me.trPeriodos.Styles.Add(Me.ElementStyle1)
        Me.trPeriodos.Styles.Add(Me.ElementStyle2)
        Me.trPeriodos.Styles.Add(Me.ElementStyle3)
        Me.trPeriodos.Styles.Add(Me.ElementStyle4)
        Me.trPeriodos.Styles.Add(Me.ElementStyle5)
        Me.trPeriodos.Styles.Add(Me.ElementStyle6)
        Me.trPeriodos.Styles.Add(Me.ElementStyle7)
        Me.trPeriodos.Styles.Add(Me.ElementStyle8)
        Me.trPeriodos.TabIndex = 142
        '
        'ColPeriodo
        '
        Me.ColPeriodo.Name = "ColPeriodo"
        Me.ColPeriodo.Text = "Periodo"
        Me.ColPeriodo.Width.Absolute = 80
        '
        'column_periodo
        '
        Me.column_periodo.Name = "column_periodo"
        Me.column_periodo.Text = "Periodo"
        Me.column_periodo.Width.Absolute = 70
        '
        'ColFechaIni
        '
        Me.ColFechaIni.Name = "ColFechaIni"
        Me.ColFechaIni.Text = "Fecha final"
        Me.ColFechaIni.Width.Absolute = 70
        '
        'ColFechaFin
        '
        Me.ColFechaFin.Name = "ColFechaFin"
        Me.ColFechaFin.Text = "Fecha final"
        Me.ColFechaFin.Width.Absolute = 70
        '
        'ColMes
        '
        Me.ColMes.Name = "ColMes"
        Me.ColMes.Text = "Mes"
        Me.ColMes.Width.Absolute = 85
        '
        'ColNombre
        '
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Text = "Nombre"
        Me.ColNombre.Width.Absolute = 230
        '
        'ColAnoP
        '
        Me.ColAnoP.Name = "ColAnoP"
        Me.ColAnoP.Text = "Ano"
        Me.ColAnoP.Visible = False
        Me.ColAnoP.Width.Absolute = 150
        '
        'ElementStyle1
        '
        Me.ElementStyle1.BackColor2 = System.Drawing.SystemColors.Highlight
        Me.ElementStyle1.BackColorGradientAngle = 90
        Me.ElementStyle1.BorderBottomWidth = 1
        Me.ElementStyle1.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle1.BorderLeftWidth = 1
        Me.ElementStyle1.BorderRightWidth = 1
        Me.ElementStyle1.BorderTopWidth = 1
        Me.ElementStyle1.CornerDiameter = 4
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Description = "Regular"
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.PaddingBottom = 1
        Me.ElementStyle1.PaddingLeft = 1
        Me.ElementStyle1.PaddingRight = 1
        Me.ElementStyle1.PaddingTop = 1
        Me.ElementStyle1.TextColor = System.Drawing.Color.Black
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node6, Me.Node8, Me.Node10, Me.Node11, Me.Node12})
        Me.Node1.Text = "AÑO"
        '
        'Node6
        '
        Me.Node6.Cells.Add(Me.Cell2)
        Me.Node6.Cells.Add(Me.Cell3)
        Me.Node6.Cells.Add(Me.Cell4)
        Me.Node6.Cells.Add(Me.Cell5)
        Me.Node6.Cells.Add(Me.Cell1)
        Me.Node6.CheckBoxVisible = True
        Me.Node6.Expanded = True
        Me.Node6.Name = "Node6"
        Me.Node6.Text = "01"
        '
        'Cell2
        '
        Me.Cell2.Name = "Cell2"
        Me.Cell2.StyleMouseOver = Nothing
        Me.Cell2.Text = "01/10/2013"
        '
        'Cell3
        '
        Me.Cell3.Name = "Cell3"
        Me.Cell3.StyleMouseOver = Nothing
        Me.Cell3.Text = "02/10/2013"
        '
        'Cell4
        '
        Me.Cell4.Name = "Cell4"
        Me.Cell4.StyleMouseOver = Nothing
        Me.Cell4.Text = "SEPTIEMBRE"
        '
        'Cell5
        '
        Me.Cell5.Name = "Cell5"
        Me.Cell5.StyleMouseOver = Nothing
        Me.Cell5.Text = "Aguinaldo 2014"
        '
        'Cell1
        '
        Me.Cell1.Name = "Cell1"
        Me.Cell1.StyleMouseOver = Nothing
        Me.Cell1.Text = "2222"
        '
        'Node8
        '
        Me.Node8.Cells.Add(Me.Cell6)
        Me.Node8.Cells.Add(Me.Cell7)
        Me.Node8.Cells.Add(Me.Cell8)
        Me.Node8.Cells.Add(Me.Cell9)
        Me.Node8.CheckBoxVisible = True
        Me.Node8.Expanded = True
        Me.Node8.Name = "Node8"
        Me.Node8.Text = "02"
        '
        'Cell6
        '
        Me.Cell6.Name = "Cell6"
        Me.Cell6.StyleMouseOver = Nothing
        '
        'Cell7
        '
        Me.Cell7.Name = "Cell7"
        Me.Cell7.StyleMouseOver = Nothing
        '
        'Cell8
        '
        Me.Cell8.Name = "Cell8"
        Me.Cell8.StyleMouseOver = Nothing
        '
        'Cell9
        '
        Me.Cell9.Name = "Cell9"
        Me.Cell9.StyleMouseOver = Nothing
        '
        'Node10
        '
        Me.Node10.CheckBoxVisible = True
        Me.Node10.Expanded = True
        Me.Node10.Name = "Node10"
        Me.Node10.Text = "03"
        '
        'Node11
        '
        Me.Node11.CheckBoxVisible = True
        Me.Node11.Expanded = True
        Me.Node11.Name = "Node11"
        Me.Node11.Text = "04"
        '
        'Node12
        '
        Me.Node12.CheckBoxVisible = True
        Me.Node12.Expanded = True
        Me.Node12.Name = "Node12"
        Me.Node12.Text = "05"
        '
        'ElementStyle3
        '
        Me.ElementStyle3.BackColor = System.Drawing.SystemColors.Window
        Me.ElementStyle3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ElementStyle3.BackColorGradientAngle = 90
        Me.ElementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderBottomWidth = 1
        Me.ElementStyle3.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderLeftWidth = 1
        Me.ElementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderRightWidth = 1
        Me.ElementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderTopWidth = 1
        Me.ElementStyle3.CornerDiameter = 4
        Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle3.Description = "Gray"
        Me.ElementStyle3.Name = "ElementStyle3"
        Me.ElementStyle3.PaddingBottom = 1
        Me.ElementStyle3.PaddingLeft = 1
        Me.ElementStyle3.PaddingRight = 1
        Me.ElementStyle3.PaddingTop = 1
        Me.ElementStyle3.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle2
        '
        Me.ElementStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ElementStyle2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ElementStyle2.BackColorGradientAngle = 90
        Me.ElementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderBottomWidth = 1
        Me.ElementStyle2.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderLeftWidth = 1
        Me.ElementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderRightWidth = 1
        Me.ElementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderTopWidth = 1
        Me.ElementStyle2.CornerDiameter = 4
        Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle2.Description = "Blue"
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.PaddingBottom = 1
        Me.ElementStyle2.PaddingLeft = 1
        Me.ElementStyle2.PaddingRight = 1
        Me.ElementStyle2.PaddingTop = 1
        Me.ElementStyle2.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle4
        '
        Me.ElementStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ElementStyle4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ElementStyle4.BackColorGradientAngle = 90
        Me.ElementStyle4.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle4.BorderBottomWidth = 1
        Me.ElementStyle4.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle4.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle4.BorderLeftWidth = 1
        Me.ElementStyle4.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle4.BorderRightWidth = 1
        Me.ElementStyle4.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle4.BorderTopWidth = 1
        Me.ElementStyle4.CornerDiameter = 4
        Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle4.Description = "Blue"
        Me.ElementStyle4.Name = "ElementStyle4"
        Me.ElementStyle4.PaddingBottom = 1
        Me.ElementStyle4.PaddingLeft = 1
        Me.ElementStyle4.PaddingRight = 1
        Me.ElementStyle4.PaddingTop = 1
        Me.ElementStyle4.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle5
        '
        Me.ElementStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ElementStyle5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ElementStyle5.BackColorGradientAngle = 90
        Me.ElementStyle5.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle5.BorderBottomWidth = 1
        Me.ElementStyle5.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle5.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle5.BorderLeftWidth = 1
        Me.ElementStyle5.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle5.BorderRightWidth = 1
        Me.ElementStyle5.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle5.BorderTopWidth = 1
        Me.ElementStyle5.CornerDiameter = 4
        Me.ElementStyle5.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle5.Description = "Blue"
        Me.ElementStyle5.Name = "ElementStyle5"
        Me.ElementStyle5.PaddingBottom = 1
        Me.ElementStyle5.PaddingLeft = 1
        Me.ElementStyle5.PaddingRight = 1
        Me.ElementStyle5.PaddingTop = 1
        Me.ElementStyle5.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle6
        '
        Me.ElementStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ElementStyle6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ElementStyle6.BackColorGradientAngle = 90
        Me.ElementStyle6.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderBottomWidth = 1
        Me.ElementStyle6.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle6.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderLeftWidth = 1
        Me.ElementStyle6.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderRightWidth = 1
        Me.ElementStyle6.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderTopWidth = 1
        Me.ElementStyle6.CornerDiameter = 4
        Me.ElementStyle6.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle6.Description = "BlueLight"
        Me.ElementStyle6.Name = "ElementStyle6"
        Me.ElementStyle6.PaddingBottom = 1
        Me.ElementStyle6.PaddingLeft = 1
        Me.ElementStyle6.PaddingRight = 1
        Me.ElementStyle6.PaddingTop = 1
        Me.ElementStyle6.TextColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'ElementStyle7
        '
        Me.ElementStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElementStyle7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ElementStyle7.BackColorGradientAngle = 90
        Me.ElementStyle7.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderBottomWidth = 1
        Me.ElementStyle7.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle7.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderLeftWidth = 1
        Me.ElementStyle7.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderRightWidth = 1
        Me.ElementStyle7.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderTopWidth = 1
        Me.ElementStyle7.CornerDiameter = 4
        Me.ElementStyle7.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle7.Description = "Orange"
        Me.ElementStyle7.Name = "ElementStyle7"
        Me.ElementStyle7.PaddingBottom = 1
        Me.ElementStyle7.PaddingLeft = 1
        Me.ElementStyle7.PaddingRight = 1
        Me.ElementStyle7.PaddingTop = 1
        Me.ElementStyle7.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle8
        '
        Me.ElementStyle8.BackColor = System.Drawing.SystemColors.Window
        Me.ElementStyle8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ElementStyle8.BackColorGradientAngle = 90
        Me.ElementStyle8.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderBottomWidth = 1
        Me.ElementStyle8.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle8.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderLeftWidth = 1
        Me.ElementStyle8.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderRightWidth = 1
        Me.ElementStyle8.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderTopWidth = 1
        Me.ElementStyle8.CornerDiameter = 4
        Me.ElementStyle8.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle8.Description = "Gray"
        Me.ElementStyle8.Name = "ElementStyle8"
        Me.ElementStyle8.PaddingBottom = 1
        Me.ElementStyle8.PaddingLeft = 1
        Me.ElementStyle8.PaddingRight = 1
        Me.ElementStyle8.PaddingTop = 1
        Me.ElementStyle8.TextColor = System.Drawing.Color.Black
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.cmbCompania.BackgroundStyle.Class = "TextBoxBorder"
        Me.cmbCompania.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmbCompania.ButtonDropDown.Visible = True
        Me.cmbCompania.Columns.Add(Me.ColumnHeader3)
        Me.cmbCompania.Columns.Add(Me.ColumnHeader4)
        Me.cmbCompania.DisplayMembers = "cod_super"
        Me.cmbCompania.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.cmbCompania.Location = New System.Drawing.Point(100, 5)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(435, 25)
        Me.cmbCompania.TabIndex = 94
        Me.cmbCompania.ValueMember = "cod_comp"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DataFieldName = "cod_comp"
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "Código"
        Me.ColumnHeader3.Width.Absolute = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DataFieldName = "nombre"
        Me.ColumnHeader4.Name = "ColumnHeader4"
        Me.ColumnHeader4.StretchToFill = True
        Me.ColumnHeader4.Text = "Nombre"
        Me.ColumnHeader4.Width.Absolute = 150
        Me.ColumnHeader4.Width.AutoSize = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Compañía"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Name = "ColumnHeader7"
        Me.ColumnHeader7.Text = "Per."
        Me.ColumnHeader7.Width.Absolute = 25
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Name = "ColumnHeader8"
        Me.ColumnHeader8.Text = "Ded."
        Me.ColumnHeader8.Width.Absolute = 25
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Name = "ColumnHeader9"
        Me.ColumnHeader9.Text = "Neto"
        Me.ColumnHeader9.Width.Absolute = 25
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Name = "ColumnHeader10"
        Me.ColumnHeader10.Text = "# Rec."
        Me.ColumnHeader10.Width.Absolute = 20
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Name = "ColumnHeader11"
        Me.ColumnHeader11.Text = "Per."
        Me.ColumnHeader11.Width.Absolute = 25
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Name = "ColumnHeader12"
        Me.ColumnHeader12.Text = "Ded."
        Me.ColumnHeader12.Width.Absolute = 25
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Name = "ColumnHeader13"
        Me.ColumnHeader13.Text = "Neto"
        Me.ColumnHeader13.Width.Absolute = 25
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Name = "ColumnHeader14"
        Me.ColumnHeader14.Text = "# Rec."
        Me.ColumnHeader14.Width.Absolute = 20
        '
        'gpParametros
        '
        Me.gpParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpParametros.BackColor = System.Drawing.SystemColors.Window
        Me.gpParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gpParametros.Controls.Add(Me.sbGeneral)
        Me.gpParametros.Controls.Add(Me.txtPeriodos)
        Me.gpParametros.Controls.Add(Me.gpControles)
        Me.gpParametros.Controls.Add(Me.Label5)
        Me.gpParametros.Controls.Add(Me.dgPolizas)
        Me.gpParametros.Controls.Add(Me.Label1)
        Me.gpParametros.Controls.Add(Me.trPeriodos)
        Me.gpParametros.Controls.Add(Me.Label2)
        Me.gpParametros.Controls.Add(Me.cmbCompania)
        Me.gpParametros.Location = New System.Drawing.Point(11, 41)
        Me.gpParametros.Name = "gpParametros"
        Me.gpParametros.Size = New System.Drawing.Size(693, 430)
        Me.gpParametros.TabIndex = 140
        '
        'sbGeneral
        '
        '
        '
        '
        Me.sbGeneral.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sbGeneral.Location = New System.Drawing.Point(541, 5)
        Me.sbGeneral.Name = "sbGeneral"
        Me.sbGeneral.OffText = "Individual"
        Me.sbGeneral.OnText = "General"
        Me.sbGeneral.Size = New System.Drawing.Size(137, 25)
        Me.sbGeneral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sbGeneral.TabIndex = 145
        Me.sbGeneral.Value = True
        Me.sbGeneral.ValueObject = "Y"
        '
        'frmPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 483)
        Me.Controls.Add(Me.gpParametros)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPolizas"
        Me.Text = "Póliza"
        Me.gpControles.ResumeLayout(False)
        CType(Me.dgPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpParametros.ResumeLayout(False)
        Me.gpParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnProcesar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents cmbCompania As DevComponents.DotNetBar.Controls.ComboTree
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader4 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader5 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader6 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents trPeriodos As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ColumnHeader11 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader12 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader13 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader14 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ColumnHeader7 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader8 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader9 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader10 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColPeriodo As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColFechaIni As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColFechaFin As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColMes As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColNombre As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents Node6 As DevComponents.AdvTree.Node
    Friend WithEvents Cell2 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell3 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell4 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell5 As DevComponents.AdvTree.Cell
    Friend WithEvents Node8 As DevComponents.AdvTree.Node
    Friend WithEvents Cell6 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell7 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell8 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell9 As DevComponents.AdvTree.Cell
    Friend WithEvents Node10 As DevComponents.AdvTree.Node
    Friend WithEvents Node11 As DevComponents.AdvTree.Node
    Friend WithEvents Node12 As DevComponents.AdvTree.Node
    Friend WithEvents dgPolizas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ElementStyle5 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle6 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle7 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle8 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ColAnoP As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Cell1 As DevComponents.AdvTree.Cell
    Friend WithEvents dlgArchivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtPeriodos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_archivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion_archivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpParametros As System.Windows.Forms.Panel
    Friend WithEvents column_periodo As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents sbGeneral As DevComponents.DotNetBar.Controls.SwitchButton
End Class
