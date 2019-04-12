<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfCourse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uxDepartment = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uxCourseSection = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.uxCourses = New System.Windows.Forms.DataGridView()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.uxSave = New System.Windows.Forms.Button()
        Me.uxClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassRosterRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'uxDepartment
        '
        Me.uxDepartment.FormattingEnabled = True
        Me.uxDepartment.Location = New System.Drawing.Point(192, 108)
        Me.uxDepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxDepartment.Name = "uxDepartment"
        Me.uxDepartment.Size = New System.Drawing.Size(269, 24)
        Me.uxDepartment.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.uxCourseSection)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.uxCourses)
        Me.Panel1.Location = New System.Drawing.Point(29, 181)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 330)
        Me.Panel1.TabIndex = 34
        '
        'uxCourseSection
        '
        Me.uxCourseSection.BackgroundColor = System.Drawing.Color.Azure
        Me.uxCourseSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourseSection.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxCourseSection.Location = New System.Drawing.Point(0, 168)
        Me.uxCourseSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxCourseSection.Name = "uxCourseSection"
        Me.uxCourseSection.Size = New System.Drawing.Size(629, 162)
        Me.uxCourseSection.TabIndex = 31
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 160)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(629, 12)
        Me.Splitter1.TabIndex = 30
        Me.Splitter1.TabStop = False
        '
        'uxCourses
        '
        Me.uxCourses.BackgroundColor = System.Drawing.Color.Lavender
        Me.uxCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uxCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourses.Dock = System.Windows.Forms.DockStyle.Top
        Me.uxCourses.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.uxCourses.Location = New System.Drawing.Point(0, 0)
        Me.uxCourses.Margin = New System.Windows.Forms.Padding(7, 4, 7, 4)
        Me.uxCourses.Name = "uxCourses"
        Me.uxCourses.Size = New System.Drawing.Size(629, 160)
        Me.uxCourses.TabIndex = 29
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.Controls.Add(Me.uxSave)
        Me.ButtonsPanel.Controls.Add(Me.uxClose)
        Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonsPanel.Location = New System.Drawing.Point(0, 578)
        Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(674, 53)
        Me.ButtonsPanel.TabIndex = 35
        '
        'uxSave
        '
        Me.uxSave.Location = New System.Drawing.Point(104, 14)
        Me.uxSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.uxSave.Name = "uxSave"
        Me.uxSave.Size = New System.Drawing.Size(101, 34)
        Me.uxSave.TabIndex = 11
        Me.uxSave.Text = "&SAVE"
        Me.uxSave.UseVisualStyleBackColor = True
        '
        'uxClose
        '
        Me.uxClose.Location = New System.Drawing.Point(474, 14)
        Me.uxClose.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.uxClose.Name = "uxClose"
        Me.uxClose.Size = New System.Drawing.Size(101, 34)
        Me.uxClose.TabIndex = 14
        Me.uxClose.Text = "&CLOSE"
        Me.uxClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassListToolStripMenuItem, Me.ClassRosterRecordToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'ClassListToolStripMenuItem
        '
        Me.ClassListToolStripMenuItem.Name = "ClassListToolStripMenuItem"
        Me.ClassListToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ClassListToolStripMenuItem.Text = "Class List"
        '
        'ClassRosterRecordToolStripMenuItem
        '
        Me.ClassRosterRecordToolStripMenuItem.Name = "ClassRosterRecordToolStripMenuItem"
        Me.ClassRosterRecordToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ClassRosterRecordToolStripMenuItem.Text = "Class Roster Record"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceFormToolStripMenuItem, Me.StudentCoursesToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "&Student"
        '
        'MaintenanceFormToolStripMenuItem
        '
        Me.MaintenanceFormToolStripMenuItem.Name = "MaintenanceFormToolStripMenuItem"
        Me.MaintenanceFormToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MaintenanceFormToolStripMenuItem.Text = "Maintenance Form"
        '
        'StudentCoursesToolStripMenuItem
        '
        Me.StudentCoursesToolStripMenuItem.Name = "StudentCoursesToolStripMenuItem"
        Me.StudentCoursesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.StudentCoursesToolStripMenuItem.Text = "Student Courses"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceFormToolStripMenuItem1})
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CourseToolStripMenuItem.Text = "C&ourse"
        '
        'MaintenanceFormToolStripMenuItem1
        '
        Me.MaintenanceFormToolStripMenuItem1.Name = "MaintenanceFormToolStripMenuItem1"
        Me.MaintenanceFormToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.MaintenanceFormToolStripMenuItem1.Text = "Maintenance Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(187, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(352, 29)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "View Courses By Department"
        '
        'ListOfCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(674, 631)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.uxDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ListOfCourse"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        Me.Panel1.ResumeLayout(False)
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents uxDepartment As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents uxCourseSection As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents uxCourses As DataGridView
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents uxSave As Button
    Friend WithEvents uxClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents ClassRosterRecordToolStripMenuItem As ToolStripMenuItem
End Class
