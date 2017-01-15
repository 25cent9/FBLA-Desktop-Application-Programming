<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustripSenior = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuniorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SophmoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreshmenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllMembersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersOwingABalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StudentInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountOwedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationDataSet = New fbla1.Student_InformationDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmboState = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmboActive = New System.Windows.Forms.ComboBox()
        Me.cmboGrade = New System.Windows.Forms.ComboBox()
        Me.txtBoxAmnt = New System.Windows.Forms.TextBox()
        Me.txtBoxYr = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxSchool = New System.Windows.Forms.TextBox()
        Me.txtBoxLName = New System.Windows.Forms.TextBox()
        Me.txtBoxFName = New System.Windows.Forms.TextBox()
        Me.txtBoxNum = New System.Windows.Forms.TextBox()
        Me.labelGrade = New System.Windows.Forms.Label()
        Me.labelAmnt = New System.Windows.Forms.Label()
        Me.labelActive = New System.Windows.Forms.Label()
        Me.labelYear = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelState = New System.Windows.Forms.Label()
        Me.labelSchool = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.labelFName = New System.Windows.Forms.Label()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoTableAdapter = New fbla1.Student_InformationDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New fbla1.Student_InformationDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.StudentInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_InformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menustripSenior, Me.JuniorsToolStripMenuItem, Me.SophmoresToolStripMenuItem, Me.FreshmenToolStripMenuItem, Me.AllMembersToolStripMenuItem1})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ViewToolStripMenuItem.Text = "Reports"
        '
        'menustripSenior
        '
        Me.menustripSenior.Name = "menustripSenior"
        Me.menustripSenior.Size = New System.Drawing.Size(141, 22)
        Me.menustripSenior.Text = "Seniors"
        '
        'JuniorsToolStripMenuItem
        '
        Me.JuniorsToolStripMenuItem.Name = "JuniorsToolStripMenuItem"
        Me.JuniorsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.JuniorsToolStripMenuItem.Text = "Juniors"
        '
        'SophmoresToolStripMenuItem
        '
        Me.SophmoresToolStripMenuItem.Name = "SophmoresToolStripMenuItem"
        Me.SophmoresToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SophmoresToolStripMenuItem.Text = "Sophomores"
        '
        'FreshmenToolStripMenuItem
        '
        Me.FreshmenToolStripMenuItem.Name = "FreshmenToolStripMenuItem"
        Me.FreshmenToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FreshmenToolStripMenuItem.Text = "Freshmen"
        '
        'AllMembersToolStripMenuItem1
        '
        Me.AllMembersToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersOwingABalanceToolStripMenuItem})
        Me.AllMembersToolStripMenuItem1.Name = "AllMembersToolStripMenuItem1"
        Me.AllMembersToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.AllMembersToolStripMenuItem1.Text = "All Members"
        '
        'MembersOwingABalanceToolStripMenuItem
        '
        Me.MembersOwingABalanceToolStripMenuItem.Name = "MembersOwingABalanceToolStripMenuItem"
        Me.MembersOwingABalanceToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.MembersOwingABalanceToolStripMenuItem.Text = "Members owing a balance "
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 24)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(921, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(80, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(105, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(82, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(78, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Enabled = False
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Enabled = False
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Enabled = False
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Enabled = False
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Enabled = False
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Enabled = False
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'StudentInfoDataGridView
        '
        Me.StudentInfoDataGridView.AllowUserToAddRows = False
        Me.StudentInfoDataGridView.AutoGenerateColumns = False
        Me.StudentInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentInfoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StudentInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.StudentInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StudentInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.StudentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.YearJoinedDataGridViewTextBoxColumn, Me.AmountOwedDataGridViewTextBoxColumn, Me.ActiveDataGridViewTextBoxColumn, Me.GradeLevelDataGridViewTextBoxColumn})
        Me.StudentInfoDataGridView.DataSource = Me.StudentInfoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentInfoDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.StudentInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StudentInfoDataGridView.Location = New System.Drawing.Point(0, 202)
        Me.StudentInfoDataGridView.Name = "StudentInfoDataGridView"
        Me.StudentInfoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.StudentInfoDataGridView.Size = New System.Drawing.Size(921, 438)
        Me.StudentInfoDataGridView.TabIndex = 20
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "Number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "School"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "School"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 5
        '
        'YearJoinedDataGridViewTextBoxColumn
        '
        Me.YearJoinedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.YearJoinedDataGridViewTextBoxColumn.DataPropertyName = "Year Joined"
        Me.YearJoinedDataGridViewTextBoxColumn.HeaderText = "Year Joined"
        Me.YearJoinedDataGridViewTextBoxColumn.Name = "YearJoinedDataGridViewTextBoxColumn"
        '
        'AmountOwedDataGridViewTextBoxColumn
        '
        Me.AmountOwedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountOwedDataGridViewTextBoxColumn.DataPropertyName = "Amount Owed"
        Me.AmountOwedDataGridViewTextBoxColumn.HeaderText = "Amount Owed"
        Me.AmountOwedDataGridViewTextBoxColumn.Name = "AmountOwedDataGridViewTextBoxColumn"
        '
        'ActiveDataGridViewTextBoxColumn
        '
        Me.ActiveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ActiveDataGridViewTextBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewTextBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewTextBoxColumn.Name = "ActiveDataGridViewTextBoxColumn"
        '
        'GradeLevelDataGridViewTextBoxColumn
        '
        Me.GradeLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GradeLevelDataGridViewTextBoxColumn.DataPropertyName = "Grade Level"
        Me.GradeLevelDataGridViewTextBoxColumn.HeaderText = "Grade Level"
        Me.GradeLevelDataGridViewTextBoxColumn.Name = "GradeLevelDataGridViewTextBoxColumn"
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.Student_InformationDataSet
        '
        'Student_InformationDataSet
        '
        Me.Student_InformationDataSet.DataSetName = "Student_InformationDataSet"
        Me.Student_InformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 102
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 103
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "School"
        Me.DataGridViewTextBoxColumn4.HeaderText = "School"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 103
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 102
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 103
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Year Joined"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Year Joined"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 102
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Amount Owed"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Amount Owed"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 103
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Active"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Active"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 102
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "Number"
        Me.Number.Name = "Number"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(921, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLbl
        '
        Me.statusLbl.BackColor = System.Drawing.SystemColors.Control
        Me.statusLbl.Name = "statusLbl"
        Me.statusLbl.Size = New System.Drawing.Size(120, 17)
        Me.statusLbl.Text = "ToolStripStatusLabel1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.cmboState)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.cmboActive)
        Me.Panel1.Controls.Add(Me.cmboGrade)
        Me.Panel1.Controls.Add(Me.txtBoxAmnt)
        Me.Panel1.Controls.Add(Me.txtBoxYr)
        Me.Panel1.Controls.Add(Me.txtBoxEmail)
        Me.Panel1.Controls.Add(Me.txtBoxSchool)
        Me.Panel1.Controls.Add(Me.txtBoxLName)
        Me.Panel1.Controls.Add(Me.txtBoxFName)
        Me.Panel1.Controls.Add(Me.txtBoxNum)
        Me.Panel1.Controls.Add(Me.labelGrade)
        Me.Panel1.Controls.Add(Me.labelAmnt)
        Me.Panel1.Controls.Add(Me.labelActive)
        Me.Panel1.Controls.Add(Me.labelYear)
        Me.Panel1.Controls.Add(Me.labelEmail)
        Me.Panel1.Controls.Add(Me.labelState)
        Me.Panel1.Controls.Add(Me.labelSchool)
        Me.Panel1.Controls.Add(Me.lblLName)
        Me.Panel1.Controls.Add(Me.labelFName)
        Me.Panel1.Controls.Add(Me.labelNumber)
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 152)
        Me.Panel1.TabIndex = 3
        '
        'cmboState
        '
        Me.cmboState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboState.Enabled = False
        Me.cmboState.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmboState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cmboState.Location = New System.Drawing.Point(409, 72)
        Me.cmboState.Name = "cmboState"
        Me.cmboState.Size = New System.Drawing.Size(119, 21)
        Me.cmboState.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Location = New System.Drawing.Point(420, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 22)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Location = New System.Drawing.Point(420, 122)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 22)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmboActive
        '
        Me.cmboActive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboActive.Enabled = False
        Me.cmboActive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmboActive.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmboActive.Location = New System.Drawing.Point(790, 73)
        Me.cmboActive.Name = "cmboActive"
        Me.cmboActive.Size = New System.Drawing.Size(119, 21)
        Me.cmboActive.TabIndex = 13
        '
        'cmboGrade
        '
        Me.cmboGrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboGrade.Enabled = False
        Me.cmboGrade.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmboGrade.Items.AddRange(New Object() {"9", "10", "11", "12"})
        Me.cmboGrade.Location = New System.Drawing.Point(790, 101)
        Me.cmboGrade.Name = "cmboGrade"
        Me.cmboGrade.Size = New System.Drawing.Size(119, 21)
        Me.cmboGrade.TabIndex = 14
        '
        'txtBoxAmnt
        '
        Me.txtBoxAmnt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxAmnt.Location = New System.Drawing.Point(790, 47)
        Me.txtBoxAmnt.Name = "txtBoxAmnt"
        Me.txtBoxAmnt.ReadOnly = True
        Me.txtBoxAmnt.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxAmnt.TabIndex = 12
        '
        'txtBoxYr
        '
        Me.txtBoxYr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxYr.Location = New System.Drawing.Point(409, 99)
        Me.txtBoxYr.Name = "txtBoxYr"
        Me.txtBoxYr.ReadOnly = True
        Me.txtBoxYr.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxYr.TabIndex = 11
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxEmail.Location = New System.Drawing.Point(80, 100)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxEmail.TabIndex = 8
        '
        'txtBoxSchool
        '
        Me.txtBoxSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxSchool.Location = New System.Drawing.Point(409, 47)
        Me.txtBoxSchool.Name = "txtBoxSchool"
        Me.txtBoxSchool.ReadOnly = True
        Me.txtBoxSchool.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxSchool.TabIndex = 9
        '
        'txtBoxLName
        '
        Me.txtBoxLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxLName.Location = New System.Drawing.Point(80, 74)
        Me.txtBoxLName.Name = "txtBoxLName"
        Me.txtBoxLName.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxLName.TabIndex = 7
        '
        'txtBoxFName
        '
        Me.txtBoxFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxFName.Location = New System.Drawing.Point(80, 47)
        Me.txtBoxFName.Name = "txtBoxFName"
        Me.txtBoxFName.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxFName.TabIndex = 6
        '
        'txtBoxNum
        '
        Me.txtBoxNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxNum.Location = New System.Drawing.Point(409, 6)
        Me.txtBoxNum.Name = "txtBoxNum"
        Me.txtBoxNum.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxNum.TabIndex = 1
        '
        'labelGrade
        '
        Me.labelGrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelGrade.AutoSize = True
        Me.labelGrade.Location = New System.Drawing.Point(710, 108)
        Me.labelGrade.Name = "labelGrade"
        Me.labelGrade.Size = New System.Drawing.Size(65, 13)
        Me.labelGrade.TabIndex = 9
        Me.labelGrade.Text = "Grade Level"
        '
        'labelAmnt
        '
        Me.labelAmnt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelAmnt.AutoSize = True
        Me.labelAmnt.Location = New System.Drawing.Point(710, 54)
        Me.labelAmnt.Name = "labelAmnt"
        Me.labelAmnt.Size = New System.Drawing.Size(74, 13)
        Me.labelAmnt.TabIndex = 8
        Me.labelAmnt.Text = "Amount Owed"
        '
        'labelActive
        '
        Me.labelActive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelActive.AutoSize = True
        Me.labelActive.Location = New System.Drawing.Point(710, 82)
        Me.labelActive.Name = "labelActive"
        Me.labelActive.Size = New System.Drawing.Size(37, 13)
        Me.labelActive.TabIndex = 7
        Me.labelActive.Text = "Active"
        '
        'labelYear
        '
        Me.labelYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelYear.AutoSize = True
        Me.labelYear.Location = New System.Drawing.Point(340, 106)
        Me.labelYear.Name = "labelYear"
        Me.labelYear.Size = New System.Drawing.Size(63, 13)
        Me.labelYear.TabIndex = 6
        Me.labelYear.Text = "Year Joined"
        '
        'labelEmail
        '
        Me.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(17, 107)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(32, 13)
        Me.labelEmail.TabIndex = 5
        Me.labelEmail.Text = "Email"
        '
        'labelState
        '
        Me.labelState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelState.AutoSize = True
        Me.labelState.Location = New System.Drawing.Point(340, 80)
        Me.labelState.Name = "labelState"
        Me.labelState.Size = New System.Drawing.Size(32, 13)
        Me.labelState.TabIndex = 4
        Me.labelState.Text = "State"
        '
        'labelSchool
        '
        Me.labelSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelSchool.AutoSize = True
        Me.labelSchool.Location = New System.Drawing.Point(340, 54)
        Me.labelSchool.Name = "labelSchool"
        Me.labelSchool.Size = New System.Drawing.Size(40, 13)
        Me.labelSchool.TabIndex = 3
        Me.labelSchool.Text = "School"
        '
        'lblLName
        '
        Me.lblLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(16, 80)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 17
        Me.lblLName.Text = "Last Name"
        '
        'labelFName
        '
        Me.labelFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFName.AutoSize = True
        Me.labelFName.Location = New System.Drawing.Point(16, 54)
        Me.labelFName.Name = "labelFName"
        Me.labelFName.Size = New System.Drawing.Size(57, 13)
        Me.labelFName.TabIndex = 17
        Me.labelFName.Text = "First Name"
        '
        'labelNumber
        '
        Me.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Location = New System.Drawing.Point(340, 13)
        Me.labelNumber.Name = "labelNumber"
        Me.labelNumber.Size = New System.Drawing.Size(44, 13)
        Me.labelNumber.TabIndex = 15
        Me.labelNumber.Text = "Number"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.ToolTip1.ToolTipTitle = "Error"
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.StudentInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = fbla1.Student_InformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(921, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.StudentInfoDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Future Business Leaders of America - All Members"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.StudentInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_InformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Student_InformationDataSet As fbla1.Student_InformationDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As fbla1.Student_InformationDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As fbla1.Student_InformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menustripSenior As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuniorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SophmoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreshmenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllMembersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersOwingABalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents labelFName As System.Windows.Forms.Label
    Friend WithEvents labelNumber As System.Windows.Forms.Label
    Friend WithEvents labelYear As System.Windows.Forms.Label
    Friend WithEvents labelEmail As System.Windows.Forms.Label
    Friend WithEvents labelState As System.Windows.Forms.Label
    Friend WithEvents labelSchool As System.Windows.Forms.Label
    Friend WithEvents labelGrade As System.Windows.Forms.Label
    Friend WithEvents labelAmnt As System.Windows.Forms.Label
    Friend WithEvents labelActive As System.Windows.Forms.Label
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearJoinedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountOwedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBoxAmnt As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxYr As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSchool As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxLName As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFName As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNum As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmboGrade As System.Windows.Forms.ComboBox
	Friend WithEvents cmboActive As System.Windows.Forms.ComboBox
	Friend WithEvents cmboState As System.Windows.Forms.ComboBox
End Class
