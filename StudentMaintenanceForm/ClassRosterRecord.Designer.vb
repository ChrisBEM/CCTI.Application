<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassRosterRecord
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.uxCourses = New System.Windows.Forms.ComboBox()
        Me.uxStudents = New System.Windows.Forms.ComboBox()
        Me.uxClassRoster = New System.Windows.Forms.DataGridView()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.uxSave = New System.Windows.Forms.Button()
        Me.uxDelete = New System.Windows.Forms.Button()
        Me.uxClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uxRegisteredDate = New System.Windows.Forms.DateTimePicker()
        Me.uxCourseSection = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.uxClassRoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Courses :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Section Available :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "List Of Students :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Registered Date :"
        '
        'uxCourses
        '
        Me.uxCourses.FormattingEnabled = True
        Me.uxCourses.Location = New System.Drawing.Point(246, 101)
        Me.uxCourses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxCourses.Name = "uxCourses"
        Me.uxCourses.Size = New System.Drawing.Size(242, 24)
        Me.uxCourses.TabIndex = 4
        '
        'uxStudents
        '
        Me.uxStudents.FormattingEnabled = True
        Me.uxStudents.Location = New System.Drawing.Point(246, 188)
        Me.uxStudents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxStudents.Name = "uxStudents"
        Me.uxStudents.Size = New System.Drawing.Size(242, 24)
        Me.uxStudents.TabIndex = 6
        '
        'uxClassRoster
        '
        Me.uxClassRoster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxClassRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxClassRoster.Location = New System.Drawing.Point(17, 294)
        Me.uxClassRoster.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxClassRoster.Name = "uxClassRoster"
        Me.uxClassRoster.Size = New System.Drawing.Size(616, 222)
        Me.uxClassRoster.TabIndex = 8
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.Controls.Add(Me.uxSave)
        Me.ButtonsPanel.Controls.Add(Me.uxDelete)
        Me.ButtonsPanel.Controls.Add(Me.uxClose)
        Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonsPanel.Location = New System.Drawing.Point(0, 538)
        Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(709, 64)
        Me.ButtonsPanel.TabIndex = 9
        '
        'uxSave
        '
        Me.uxSave.Location = New System.Drawing.Point(27, 29)
        Me.uxSave.Name = "uxSave"
        Me.uxSave.Size = New System.Drawing.Size(75, 23)
        Me.uxSave.TabIndex = 11
        Me.uxSave.Text = "&SAVE"
        Me.uxSave.UseVisualStyleBackColor = True
        '
        'uxDelete
        '
        Me.uxDelete.Location = New System.Drawing.Point(283, 29)
        Me.uxDelete.Name = "uxDelete"
        Me.uxDelete.Size = New System.Drawing.Size(75, 23)
        Me.uxDelete.TabIndex = 13
        Me.uxDelete.Text = "&DELETE"
        Me.uxDelete.UseVisualStyleBackColor = True
        '
        'uxClose
        '
        Me.uxClose.Location = New System.Drawing.Point(544, 29)
        Me.uxClose.Name = "uxClose"
        Me.uxClose.Size = New System.Drawing.Size(75, 23)
        Me.uxClose.TabIndex = 14
        Me.uxClose.Text = "&CLOSE"
        Me.uxClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(195, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Set Up A Class Roster"
        '
        'uxRegisteredDate
        '
        Me.uxRegisteredDate.Location = New System.Drawing.Point(246, 235)
        Me.uxRegisteredDate.Name = "uxRegisteredDate"
        Me.uxRegisteredDate.Size = New System.Drawing.Size(242, 22)
        Me.uxRegisteredDate.TabIndex = 11
        '
        'uxCourseSection
        '
        Me.uxCourseSection.FormattingEnabled = True
        Me.uxCourseSection.Location = New System.Drawing.Point(246, 149)
        Me.uxCourseSection.Name = "uxCourseSection"
        Me.uxCourseSection.Size = New System.Drawing.Size(242, 24)
        Me.uxCourseSection.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 13
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
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassListToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'ClassListToolStripMenuItem
        '
        Me.ClassListToolStripMenuItem.Name = "ClassListToolStripMenuItem"
        Me.ClassListToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClassListToolStripMenuItem.Text = "Class List"
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
        Me.ListOfCourseToolStripMenuItem.Text = "List of Course"
        '
        'ClassRosterRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(709, 602)
        Me.Controls.Add(Me.uxCourseSection)
        Me.Controls.Add(Me.uxRegisteredDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.uxClassRoster)
        Me.Controls.Add(Me.uxStudents)
        Me.Controls.Add(Me.uxCourses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClassRosterRecord"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        CType(Me.uxClassRoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents uxCourses As ComboBox
    Friend WithEvents uxStudents As ComboBox
    Friend WithEvents uxClassRoster As DataGridView
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents uxSave As Button
    Friend WithEvents uxDelete As Button
    Friend WithEvents uxClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents uxRegisteredDate As DateTimePicker
    Friend WithEvents uxCourseSection As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListOfCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassListToolStripMenuItem As ToolStripMenuItem
End Class
