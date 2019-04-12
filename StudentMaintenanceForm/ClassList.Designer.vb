<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassList
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
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.uxSave = New System.Windows.Forms.Button()
        Me.uxClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uxCourseSection = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.uxCourses = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uxStudent = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassRosterRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonsPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.Controls.Add(Me.uxSave)
        Me.ButtonsPanel.Controls.Add(Me.uxClose)
        Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonsPanel.Location = New System.Drawing.Point(0, 694)
        Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(783, 51)
        Me.ButtonsPanel.TabIndex = 37
        '
        'uxSave
        '
        Me.uxSave.Location = New System.Drawing.Point(120, 9)
        Me.uxSave.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxSave.Name = "uxSave"
        Me.uxSave.Size = New System.Drawing.Size(118, 36)
        Me.uxSave.TabIndex = 11
        Me.uxSave.Text = "&SAVE"
        Me.uxSave.UseVisualStyleBackColor = True
        '
        'uxClose
        '
        Me.uxClose.Location = New System.Drawing.Point(553, 9)
        Me.uxClose.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxClose.Name = "uxClose"
        Me.uxClose.Size = New System.Drawing.Size(118, 36)
        Me.uxClose.TabIndex = 14
        Me.uxClose.Text = "&CLOSE"
        Me.uxClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.uxCourseSection)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.uxCourses)
        Me.Panel1.Location = New System.Drawing.Point(14, 106)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 311)
        Me.Panel1.TabIndex = 36
        '
        'uxCourseSection
        '
        Me.uxCourseSection.BackgroundColor = System.Drawing.Color.Azure
        Me.uxCourseSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourseSection.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxCourseSection.Location = New System.Drawing.Point(0, 156)
        Me.uxCourseSection.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.uxCourseSection.Name = "uxCourseSection"
        Me.uxCourseSection.Size = New System.Drawing.Size(734, 155)
        Me.uxCourseSection.TabIndex = 31
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 145)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(734, 15)
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
        Me.uxCourses.Margin = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.uxCourses.Name = "uxCourses"
        Me.uxCourses.Size = New System.Drawing.Size(734, 145)
        Me.uxCourses.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(254, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 29)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "View Class List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Select A Course :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Student List :"
        '
        'uxStudent
        '
        Me.uxStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxStudent.Location = New System.Drawing.Point(17, 473)
        Me.uxStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxStudent.Name = "uxStudent"
        Me.uxStudent.Size = New System.Drawing.Size(730, 185)
        Me.uxStudent.TabIndex = 41
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 24)
        Me.MenuStrip1.TabIndex = 42
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
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassRosterRecordToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
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
        Me.CourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceFormToolStripMenuItem1, Me.ListOfCourseToolStripMenuItem})
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
        'ListOfCourseToolStripMenuItem
        '
        Me.ListOfCourseToolStripMenuItem.Name = "ListOfCourseToolStripMenuItem"
        Me.ListOfCourseToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ListOfCourseToolStripMenuItem.Text = "List Of Course"
        '
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(783, 745)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.uxStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClassList"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        Me.ButtonsPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents uxSave As Button
    Friend WithEvents uxClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents uxCourseSection As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents uxCourses As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents uxStudent As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassRosterRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListOfCourseToolStripMenuItem As ToolStripMenuItem
End Class
