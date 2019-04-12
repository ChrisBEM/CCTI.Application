<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentCourses
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.uxSave = New System.Windows.Forms.Button()
        Me.uxDelete = New System.Windows.Forms.Button()
        Me.uxClose = New System.Windows.Forms.Button()
        Me.uxStudents = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.ListOfCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxCourses = New System.Windows.Forms.DataGridView()
        Me.uxTotalCost = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(209, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "View A Student Courses"
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.Controls.Add(Me.uxSave)
        Me.ButtonsPanel.Controls.Add(Me.uxDelete)
        Me.ButtonsPanel.Controls.Add(Me.uxClose)
        Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonsPanel.Location = New System.Drawing.Point(0, 563)
        Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(794, 56)
        Me.ButtonsPanel.TabIndex = 20
        '
        'uxSave
        '
        Me.uxSave.Location = New System.Drawing.Point(31, 17)
        Me.uxSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxSave.Name = "uxSave"
        Me.uxSave.Size = New System.Drawing.Size(87, 28)
        Me.uxSave.TabIndex = 11
        Me.uxSave.Text = "&SAVE"
        Me.uxSave.UseVisualStyleBackColor = True
        '
        'uxDelete
        '
        Me.uxDelete.Location = New System.Drawing.Point(329, 17)
        Me.uxDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxDelete.Name = "uxDelete"
        Me.uxDelete.Size = New System.Drawing.Size(87, 28)
        Me.uxDelete.TabIndex = 13
        Me.uxDelete.Text = "&DELETE"
        Me.uxDelete.UseVisualStyleBackColor = True
        '
        'uxClose
        '
        Me.uxClose.Location = New System.Drawing.Point(634, 17)
        Me.uxClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxClose.Name = "uxClose"
        Me.uxClose.Size = New System.Drawing.Size(87, 28)
        Me.uxClose.TabIndex = 14
        Me.uxClose.Text = "&CLOSE"
        Me.uxClose.UseVisualStyleBackColor = True
        '
        'uxStudents
        '
        Me.uxStudents.FormattingEnabled = True
        Me.uxStudents.Location = New System.Drawing.Point(280, 144)
        Me.uxStudents.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.uxStudents.Name = "uxStudents"
        Me.uxStudents.Size = New System.Drawing.Size(282, 24)
        Me.uxStudents.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pick A Student :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 24
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
        Me.ClassListToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClassListToolStripMenuItem.Text = "Class List"
        '
        'ClassRosterRecordToolStripMenuItem
        '
        Me.ClassRosterRecordToolStripMenuItem.Name = "ClassRosterRecordToolStripMenuItem"
        Me.ClassRosterRecordToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClassRosterRecordToolStripMenuItem.Text = "Class Roster record"
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
        'uxCourses
        '
        Me.uxCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourses.Location = New System.Drawing.Point(31, 204)
        Me.uxCourses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.uxCourses.Name = "uxCourses"
        Me.uxCourses.Size = New System.Drawing.Size(674, 225)
        Me.uxCourses.TabIndex = 25
        '
        'uxTotalCost
        '
        Me.uxTotalCost.Location = New System.Drawing.Point(214, 498)
        Me.uxTotalCost.Name = "uxTotalCost"
        Me.uxTotalCost.Size = New System.Drawing.Size(288, 22)
        Me.uxTotalCost.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Total Cost :"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(794, 619)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.uxTotalCost)
        Me.Controls.Add(Me.uxCourses)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.uxStudents)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StudentCourses"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        Me.ButtonsPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents uxSave As Button
    Friend WithEvents uxDelete As Button
    Friend WithEvents uxClose As Button
    Friend WithEvents uxStudents As ComboBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents ListOfCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents uxCourses As DataGridView
    Friend WithEvents uxTotalCost As TextBox
    Friend WithEvents ClassRosterRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
