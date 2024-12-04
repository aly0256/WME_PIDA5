<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCondensadoNomina
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCondensadoNomina))
        Me.dgvCondensado = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ColumnFormato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGenerar = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCia = New System.Windows.Forms.Label()
        Me.lstPeriodos = New System.Windows.Forms.ListBox()
        Me.gpAvance = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblAvance = New System.Windows.Forms.Label()
        Me.pbAvance = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDirectorio = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bgwGenerar = New System.ComponentModel.BackgroundWorker()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.cbTodo = New System.Windows.Forms.CheckBox()
        CType(Me.dgvCondensado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpAvance.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCondensado
        '
        Me.dgvCondensado.AllowUserToAddRows = False
        Me.dgvCondensado.AllowUserToDeleteRows = False
        Me.dgvCondensado.AllowUserToOrderColumns = True
        Me.dgvCondensado.AllowUserToResizeColumns = False
        Me.dgvCondensado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCondensado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCondensado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCondensado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFormato, Me.ColumnNombre, Me.ColumnGenerar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCondensado.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCondensado.Enabled = False
        Me.dgvCondensado.EnableHeadersVisualStyles = False
        Me.dgvCondensado.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvCondensado.Location = New System.Drawing.Point(12, 175)
        Me.dgvCondensado.Name = "dgvCondensado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCondensado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCondensado.Size = New System.Drawing.Size(760, 343)
        Me.dgvCondensado.TabIndex = 0
        '
        'ColumnFormato
        '
        Me.ColumnFormato.DataPropertyName = "id_formato"
        Me.ColumnFormato.HeaderText = "formato"
        Me.ColumnFormato.Name = "ColumnFormato"
        Me.ColumnFormato.ReadOnly = True
        Me.ColumnFormato.Visible = False
        '
        'ColumnNombre
        '
        Me.ColumnNombre.DataPropertyName = "nombre_reporte"
        Me.ColumnNombre.HeaderText = "Reporte"
        Me.ColumnNombre.Name = "ColumnNombre"
        Me.ColumnNombre.ReadOnly = True
        Me.ColumnNombre.Width = 650
        '
        'ColumnGenerar
        '
        Me.ColumnGenerar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnGenerar.Checked = True
        Me.ColumnGenerar.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ColumnGenerar.CheckValue = Nothing
        Me.ColumnGenerar.DataPropertyName = "generar"
        Me.ColumnGenerar.HeaderText = "Incluir"
        Me.ColumnGenerar.Name = "ColumnGenerar"
        Me.ColumnGenerar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnGenerar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(57, 4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(451, 48)
        Me.ReflectionLabel1.TabIndex = 112
        Me.ReflectionLabel1.Text = "<font color=""#1F497D""><b>Condensado de reportes de nómina</b></font>"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PIDA.My.Resources.Resources.condensados
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'btnGenerar
        '
        Me.btnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerar.CausesValidation = False
        Me.btnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = Global.PIDA.My.Resources.Resources.Reporte16
        Me.btnGenerar.Location = New System.Drawing.Point(271, 524)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(237, 25)
        Me.btnGenerar.TabIndex = 114
        Me.btnGenerar.Text = "Generar reportes seleccionados"
        '
        'bgw
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCia)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ReflectionLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 83)
        Me.Panel1.TabIndex = 283
        '
        'lblCia
        '
        Me.lblCia.BackColor = System.Drawing.Color.Silver
        Me.lblCia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCia.Location = New System.Drawing.Point(0, 55)
        Me.lblCia.Name = "lblCia"
        Me.lblCia.Size = New System.Drawing.Size(784, 28)
        Me.lblCia.TabIndex = 283
        Me.lblCia.Text = "COMPAÑIA"
        Me.lblCia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstPeriodos
        '
        Me.lstPeriodos.BackColor = System.Drawing.SystemColors.Highlight
        Me.lstPeriodos.ColumnWidth = 70
        Me.lstPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPeriodos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lstPeriodos.FormattingEnabled = True
        Me.lstPeriodos.ItemHeight = 16
        Me.lstPeriodos.Location = New System.Drawing.Point(22, 102)
        Me.lstPeriodos.MultiColumn = True
        Me.lstPeriodos.Name = "lstPeriodos"
        Me.lstPeriodos.Size = New System.Drawing.Size(119, 20)
        Me.lstPeriodos.TabIndex = 123
        '
        'gpAvance
        '
        Me.gpAvance.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAvance.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.gpAvance.Controls.Add(Me.lblAvance)
        Me.gpAvance.Controls.Add(Me.pbAvance)
        Me.gpAvance.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpAvance.Location = New System.Drawing.Point(282, 171)
        Me.gpAvance.Name = "gpAvance"
        Me.gpAvance.Size = New System.Drawing.Size(220, 218)
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
        Me.gpAvance.TabIndex = 285
        Me.gpAvance.Visible = False
        '
        'lblAvance
        '
        Me.lblAvance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblAvance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvance.Location = New System.Drawing.Point(0, 155)
        Me.lblAvance.Name = "lblAvance"
        Me.lblAvance.Size = New System.Drawing.Size(218, 60)
        Me.lblAvance.TabIndex = 271
        Me.lblAvance.Text = "Preparando datos..."
        Me.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pbAvance.Size = New System.Drawing.Size(218, 152)
        Me.pbAvance.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.pbAvance.TabIndex = 270
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(22, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(718, 26)
        Me.TextBox1.TabIndex = 286
        '
        'btnDirectorio
        '
        Me.btnDirectorio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDirectorio.CausesValidation = False
        Me.btnDirectorio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDirectorio.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDirectorio.Enabled = False
        Me.btnDirectorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirectorio.Location = New System.Drawing.Point(746, 141)
        Me.btnDirectorio.Name = "btnDirectorio"
        Me.btnDirectorio.Size = New System.Drawing.Size(26, 26)
        Me.btnDirectorio.TabIndex = 287
        Me.btnDirectorio.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "Directorio archivos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 289
        Me.Label2.Text = "Periodo seleccionado"
        '
        'bgwGenerar
        '
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.CausesValidation = False
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Enabled = False
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.PIDA.My.Resources.Resources.Cancel16
        Me.btnSalir.Location = New System.Drawing.Point(12, 524)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 25)
        Me.btnSalir.TabIndex = 290
        Me.btnSalir.Text = "Salir"
        '
        'cbTodo
        '
        Me.cbTodo.AutoSize = True
        Me.cbTodo.Enabled = False
        Me.cbTodo.Location = New System.Drawing.Point(666, 524)
        Me.cbTodo.Name = "cbTodo"
        Me.cbTodo.Size = New System.Drawing.Size(106, 17)
        Me.cbTodo.TabIndex = 291
        Me.cbTodo.Text = "Seleccionar todo"
        Me.cbTodo.UseVisualStyleBackColor = True
        '
        'frmCondensadoNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cbTodo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstPeriodos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDirectorio)
        Me.Controls.Add(Me.gpAvance)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgvCondensado)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCondensadoNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condensado de nómina"
        CType(Me.dgvCondensado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpAvance.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCondensado As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCia As System.Windows.Forms.Label
    Public WithEvents lstPeriodos As System.Windows.Forms.ListBox
    Friend WithEvents gpAvance As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblAvance As System.Windows.Forms.Label
    Friend WithEvents pbAvance As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ColumnFormato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGenerar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDirectorio As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bgwGenerar As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTodo As System.Windows.Forms.CheckBox
End Class
