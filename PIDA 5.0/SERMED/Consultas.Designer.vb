﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas))
        Me.tabControlGeneral = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.btnFirst = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrev = New DevComponents.DotNetBar.ButtonX()
        Me.btnNext = New DevComponents.DotNetBar.ButtonX()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnLast = New DevComponents.DotNetBar.ButtonX()
        Me.btnReporte = New DevComponents.DotNetBar.ButtonX()
        Me.dgvConsultasDiarias = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.tabConsultasDiarias = New DevComponents.DotNetBar.SuperTabItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.comboFiltroEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItemTodas = New DevComponents.Editors.ComboItem()
        Me.ComboItemProxima = New DevComponents.Editors.ComboItem()
        Me.ComboItemSinProxima = New DevComponents.Editors.ComboItem()
        Me.comboFiltroExternos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItemTodos = New DevComponents.Editors.ComboItem()
        Me.ComboItemExternos = New DevComponents.Editors.ComboItem()
        Me.ComboItemEmpleados = New DevComponents.Editors.ComboItem()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.tabControlGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlGeneral.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvConsultasDiarias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControlGeneral
        '
        Me.tabControlGeneral.CloseButtonOnTabsVisible = True
        '
        '
        '
        '
        '
        '
        Me.tabControlGeneral.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.tabControlGeneral.ControlBox.MenuBox.Name = ""
        Me.tabControlGeneral.ControlBox.Name = ""
        Me.tabControlGeneral.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabControlGeneral.ControlBox.MenuBox, Me.tabControlGeneral.ControlBox.CloseBox})
        Me.tabControlGeneral.Controls.Add(Me.SuperTabControlPanel1)
        Me.tabControlGeneral.ImageList = Me.ImageList1
        Me.tabControlGeneral.Location = New System.Drawing.Point(12, 68)
        Me.tabControlGeneral.Name = "tabControlGeneral"
        Me.tabControlGeneral.ReorderTabsEnabled = True
        Me.tabControlGeneral.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabControlGeneral.SelectedTabIndex = 0
        Me.tabControlGeneral.Size = New System.Drawing.Size(860, 657)
        Me.tabControlGeneral.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlGeneral.TabIndex = 24
        Me.tabControlGeneral.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabConsultasDiarias})
        Me.tabControlGeneral.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Zoom
        Me.SuperTabControlPanel1.Controls.Add(Me.comboFiltroEstado)
        Me.SuperTabControlPanel1.Controls.Add(Me.comboFiltroExternos)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Panel1)
        Me.SuperTabControlPanel1.Controls.Add(Me.dgvConsultasDiarias)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label1)
        Me.SuperTabControlPanel1.Controls.Add(Me.dtpFechaBusqueda)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(860, 627)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.tabConsultasDiarias
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnFirst)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Location = New System.Drawing.Point(3, 586)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 33)
        Me.Panel1.TabIndex = 21
        '
        'btnBorrar
        '
        Me.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.CausesValidation = False
        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = Global.PIDA.NET.My.Resources.Resources.DeleteRec
        Me.btnBorrar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnBorrar.Location = New System.Drawing.Point(702, 3)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 25)
        Me.btnBorrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBorrar.TabIndex = 5011
        Me.btnBorrar.Text = "Borrar"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.CausesValidation = False
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.PIDA.NET.My.Resources.Resources.NewRecord
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnNuevo.Location = New System.Drawing.Point(624, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 25)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 5010
        Me.btnNuevo.Text = "Agregar"
        '
        'btnFirst
        '
        Me.btnFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFirst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Image = Global.PIDA.NET.My.Resources.Resources.First16
        Me.btnFirst.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnFirst.Location = New System.Drawing.Point(3, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(68, 25)
        Me.btnFirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFirst.TabIndex = 5000
        Me.btnFirst.Text = "Inicio"
        '
        'btnPrev
        '
        Me.btnPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Image = Global.PIDA.NET.My.Resources.Resources.Prev16
        Me.btnPrev.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnPrev.Location = New System.Drawing.Point(77, 3)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(68, 25)
        Me.btnPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrev.TabIndex = 5001
        Me.btnPrev.Text = "Anterior"
        '
        'btnNext
        '
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Image = Global.PIDA.NET.My.Resources.Resources.Next16
        Me.btnNext.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnNext.Location = New System.Drawing.Point(151, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(68, 25)
        Me.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNext.TabIndex = 5002
        Me.btnNext.Text = "Siguiente"
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.CausesValidation = False
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.PIDA.NET.My.Resources.Resources.CancelX
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(780, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(68, 25)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 5009
        Me.btnCerrar.Text = "Salir"
        '
        'btnLast
        '
        Me.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Image = Global.PIDA.NET.My.Resources.Resources.Last16
        Me.btnLast.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnLast.Location = New System.Drawing.Point(225, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(68, 25)
        Me.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLast.TabIndex = 5003
        Me.btnLast.Text = "Final"
        '
        'btnReporte
        '
        Me.btnReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.CausesValidation = False
        Me.btnReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Image = Global.PIDA.NET.My.Resources.Resources.Reporte16
        Me.btnReporte.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnReporte.Location = New System.Drawing.Point(550, 3)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(68, 25)
        Me.btnReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReporte.TabIndex = 5005
        Me.btnReporte.Text = "Reporte"
        '
        'dgvConsultasDiarias
        '
        Me.dgvConsultasDiarias.AllowUserToAddRows = False
        Me.dgvConsultasDiarias.AllowUserToDeleteRows = False
        Me.dgvConsultasDiarias.AllowUserToOrderColumns = True
        Me.dgvConsultasDiarias.AllowUserToResizeColumns = False
        Me.dgvConsultasDiarias.AllowUserToResizeRows = False
        Me.dgvConsultasDiarias.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultasDiarias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultasDiarias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultasDiarias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvConsultasDiarias.Location = New System.Drawing.Point(6, 53)
        Me.dgvConsultasDiarias.Name = "dgvConsultasDiarias"
        Me.dgvConsultasDiarias.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultasDiarias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsultasDiarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultasDiarias.Size = New System.Drawing.Size(851, 527)
        Me.dgvConsultasDiarias.TabIndex = 277
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(820, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 278
        Me.Label1.Text = "Fecha"
        '
        'dtpFechaBusqueda
        '
        Me.dtpFechaBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBusqueda.Location = New System.Drawing.Point(750, 27)
        Me.dtpFechaBusqueda.MaxDate = New Date(2021, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaBusqueda.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaBusqueda.Name = "dtpFechaBusqueda"
        Me.dtpFechaBusqueda.Size = New System.Drawing.Size(107, 20)
        Me.dtpFechaBusqueda.TabIndex = 279
        '
        'tabConsultasDiarias
        '
        Me.tabConsultasDiarias.AttachedControl = Me.SuperTabControlPanel1
        Me.tabConsultasDiarias.CloseButtonVisible = False
        Me.tabConsultasDiarias.GlobalItem = False
        Me.tabConsultasDiarias.ImageIndex = 0
        Me.tabConsultasDiarias.Name = "tabConsultasDiarias"
        Me.tabConsultasDiarias.Text = "Consultas Diarias"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "group2-16.png")
        Me.ImageList1.Images.SetKeyName(1, "user-16.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PIDA.NET.My.Resources.Resources.sermed_doctor
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 276
        Me.PictureBox1.TabStop = False
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(59, 22)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(530, 40)
        Me.ReflectionLabel1.TabIndex = 275
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>CONSULTAS MÉDICAS DIARIAS</b></font>"
        '
        'comboFiltroEstado
        '
        Me.comboFiltroEstado.DisplayMember = "Text"
        Me.comboFiltroEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboFiltroEstado.FormattingEnabled = True
        Me.comboFiltroEstado.ItemHeight = 14
        Me.comboFiltroEstado.Items.AddRange(New Object() {Me.ComboItemTodas, Me.ComboItemProxima, Me.ComboItemSinProxima})
        Me.comboFiltroEstado.Location = New System.Drawing.Point(181, 27)
        Me.comboFiltroEstado.Name = "comboFiltroEstado"
        Me.comboFiltroEstado.Size = New System.Drawing.Size(121, 20)
        Me.comboFiltroEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.comboFiltroEstado.TabIndex = 5015
        '
        'ComboItemTodas
        '
        Me.ComboItemTodas.Text = "Todas"
        '
        'ComboItemProxima
        '
        Me.ComboItemProxima.Text = "Con Próxima Cita"
        '
        'ComboItemSinProxima
        '
        Me.ComboItemSinProxima.Text = "Sin Próxima Cita"
        '
        'comboFiltroExternos
        '
        Me.comboFiltroExternos.DisplayMember = "Text"
        Me.comboFiltroExternos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboFiltroExternos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFiltroExternos.FormattingEnabled = True
        Me.comboFiltroExternos.ItemHeight = 14
        Me.comboFiltroExternos.Items.AddRange(New Object() {Me.ComboItemTodos, Me.ComboItemExternos, Me.ComboItemEmpleados})
        Me.comboFiltroExternos.Location = New System.Drawing.Point(54, 27)
        Me.comboFiltroExternos.Name = "comboFiltroExternos"
        Me.comboFiltroExternos.Size = New System.Drawing.Size(121, 20)
        Me.comboFiltroExternos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.comboFiltroExternos.TabIndex = 5014
        '
        'ComboItemTodos
        '
        Me.ComboItemTodos.Text = "Todos"
        Me.ComboItemTodos.Value = "t"
        '
        'ComboItemExternos
        '
        Me.ComboItemExternos.Text = "Externos"
        Me.ComboItemExternos.Value = "e"
        '
        'ComboItemEmpleados
        '
        Me.ComboItemEmpleados.Text = "Empleados"
        Me.ComboItemEmpleados.Value = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5013
        Me.Label2.Text = "Mostrar:"
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 729)
        Me.Controls.Add(Me.tabControlGeneral)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Name = "Consultas"
        Me.Text = "Consultas Diarias"
        CType(Me.tabControlGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlGeneral.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvConsultasDiarias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControlGeneral As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBorrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFirst As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrev As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLast As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReporte As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvConsultasDiarias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBusqueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabConsultasDiarias As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents comboFiltroEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItemTodas As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItemProxima As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItemSinProxima As DevComponents.Editors.ComboItem
    Friend WithEvents comboFiltroExternos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItemTodos As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItemExternos As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItemEmpleados As DevComponents.Editors.ComboItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class