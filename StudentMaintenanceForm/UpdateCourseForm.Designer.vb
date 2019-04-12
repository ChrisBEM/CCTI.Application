<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCourseForm
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
        Me.uxEndDate = New System.Windows.Forms.DateTimePicker()
        Me.uxStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uxCourseSection = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.uxCourses = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uxButtonsPanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.uxDepartment = New System.Windows.Forms.ComboBox()
        Me.uxRoomNumber = New System.Windows.Forms.TextBox()
        Me.uxSectionCode = New System.Windows.Forms.TextBox()
        Me.uxCost = New System.Windows.Forms.TextBox()
        Me.uxDescription = New System.Windows.Forms.TextBox()
        Me.uxName = New System.Windows.Forms.TextBox()
        Me.uxCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uxButtonsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uxEndDate
        '
        Me.uxEndDate.Location = New System.Drawing.Point(216, 473)
        Me.uxEndDate.Name = "uxEndDate"
        Me.uxEndDate.Size = New System.Drawing.Size(271, 20)
        Me.uxEndDate.TabIndex = 60
        '
        'uxStartDate
        '
        Me.uxStartDate.Location = New System.Drawing.Point(216, 436)
        Me.uxStartDate.Name = "uxStartDate"
        Me.uxStartDate.Size = New System.Drawing.Size(271, 20)
        Me.uxStartDate.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 361)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 28)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Course Section"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.uxCourseSection)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.uxCourses)
        Me.Panel1.Location = New System.Drawing.Point(537, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 395)
        Me.Panel1.TabIndex = 57
        '
        'uxCourseSection
        '
        Me.uxCourseSection.BackgroundColor = System.Drawing.Color.SeaShell
        Me.uxCourseSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourseSection.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxCourseSection.Location = New System.Drawing.Point(0, 245)
        Me.uxCourseSection.Name = "uxCourseSection"
        Me.uxCourseSection.Size = New System.Drawing.Size(850, 150)
        Me.uxCourseSection.TabIndex = 31
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 239)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(850, 10)
        Me.Splitter1.TabIndex = 30
        Me.Splitter1.TabStop = False
        '
        'uxCourses
        '
        Me.uxCourses.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.uxCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uxCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxCourses.Dock = System.Windows.Forms.DockStyle.Top
        Me.uxCourses.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.uxCourses.Location = New System.Drawing.Point(0, 0)
        Me.uxCourses.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.uxCourses.Name = "uxCourses"
        Me.uxCourses.Size = New System.Drawing.Size(850, 239)
        Me.uxCourses.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(10, 71)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(206, 28)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Course Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(870, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 28)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Courses List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(371, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 37)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Update A Course "
        '
        'uxButtonsPanel
        '
        Me.uxButtonsPanel.BackColor = System.Drawing.Color.GhostWhite
        Me.uxButtonsPanel.Controls.Add(Me.Button5)
        Me.uxButtonsPanel.Controls.Add(Me.Button4)
        Me.uxButtonsPanel.Controls.Add(Me.Button3)
        Me.uxButtonsPanel.Controls.Add(Me.Button1)
        Me.uxButtonsPanel.Controls.Add(Me.Button2)
        Me.uxButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxButtonsPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxButtonsPanel.Location = New System.Drawing.Point(0, 550)
        Me.uxButtonsPanel.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.uxButtonsPanel.Name = "uxButtonsPanel"
        Me.uxButtonsPanel.Size = New System.Drawing.Size(1370, 55)
        Me.uxButtonsPanel.TabIndex = 53
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(312, 20)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "&ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1242, 20)
        Me.Button4.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "C&LOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(950, 20)
        Me.Button3.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "SA&VE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(660, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'uxDepartment
        '
        Me.uxDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxDepartment.FormattingEnabled = True
        Me.uxDepartment.Location = New System.Drawing.Point(216, 302)
        Me.uxDepartment.Name = "uxDepartment"
        Me.uxDepartment.Size = New System.Drawing.Size(271, 21)
        Me.uxDepartment.TabIndex = 52
        '
        'uxRoomNumber
        '
        Me.uxRoomNumber.BackColor = System.Drawing.Color.SeaShell
        Me.uxRoomNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxRoomNumber.Location = New System.Drawing.Point(216, 508)
        Me.uxRoomNumber.Name = "uxRoomNumber"
        Me.uxRoomNumber.Size = New System.Drawing.Size(271, 20)
        Me.uxRoomNumber.TabIndex = 51
        '
        'uxSectionCode
        '
        Me.uxSectionCode.BackColor = System.Drawing.Color.SeaShell
        Me.uxSectionCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxSectionCode.Location = New System.Drawing.Point(216, 398)
        Me.uxSectionCode.Name = "uxSectionCode"
        Me.uxSectionCode.Size = New System.Drawing.Size(271, 20)
        Me.uxSectionCode.TabIndex = 50
        '
        'uxCost
        '
        Me.uxCost.BackColor = System.Drawing.Color.PapayaWhip
        Me.uxCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxCost.Location = New System.Drawing.Point(216, 240)
        Me.uxCost.Name = "uxCost"
        Me.uxCost.Size = New System.Drawing.Size(271, 20)
        Me.uxCost.TabIndex = 49
        '
        'uxDescription
        '
        Me.uxDescription.BackColor = System.Drawing.Color.PapayaWhip
        Me.uxDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxDescription.Location = New System.Drawing.Point(216, 202)
        Me.uxDescription.Multiline = True
        Me.uxDescription.Name = "uxDescription"
        Me.uxDescription.Size = New System.Drawing.Size(271, 20)
        Me.uxDescription.TabIndex = 48
        '
        'uxName
        '
        Me.uxName.BackColor = System.Drawing.Color.PapayaWhip
        Me.uxName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxName.Location = New System.Drawing.Point(216, 164)
        Me.uxName.Name = "uxName"
        Me.uxName.Size = New System.Drawing.Size(271, 20)
        Me.uxName.TabIndex = 47
        '
        'uxCode
        '
        Me.uxCode.BackColor = System.Drawing.Color.PapayaWhip
        Me.uxCode.Enabled = False
        Me.uxCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uxCode.Location = New System.Drawing.Point(216, 124)
        Me.uxCode.Name = "uxCode"
        Me.uxCode.Size = New System.Drawing.Size(271, 20)
        Me.uxCode.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Sienna
        Me.Label12.Location = New System.Drawing.Point(19, 515)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Room Number :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Sienna
        Me.Label11.Location = New System.Drawing.Point(19, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "End Date :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Sienna
        Me.Label10.Location = New System.Drawing.Point(19, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Start Date :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(19, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Section Code :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(19, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Department :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(19, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Cost :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(19, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Description :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(19, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(19, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Code :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CourseToolStripMenuItem, Me.StudentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 61
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
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.UpdateToolStripMenuItem})
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CourseToolStripMenuItem.Text = "&Course"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UpdateToolStripMenuItem.Text = "Maintenance Form"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceFormToolStripMenuItem})
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
        'UpdateCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1370, 605)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.uxEndDate)
        Me.Controls.Add(Me.uxStartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.uxButtonsPanel)
        Me.Controls.Add(Me.uxDepartment)
        Me.Controls.Add(Me.uxRoomNumber)
        Me.Controls.Add(Me.uxSectionCode)
        Me.Controls.Add(Me.uxCost)
        Me.Controls.Add(Me.uxDescription)
        Me.Controls.Add(Me.uxName)
        Me.Controls.Add(Me.uxCode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UpdateCourseForm"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        Me.Panel1.ResumeLayout(False)
        CType(Me.uxCourseSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uxButtonsPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uxEndDate As DateTimePicker
    Friend WithEvents uxStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents uxCourseSection As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents uxCourses As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents uxButtonsPanel As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents uxDepartment As ComboBox
    Friend WithEvents uxRoomNumber As TextBox
    Friend WithEvents uxSectionCode As TextBox
    Friend WithEvents uxCost As TextBox
    Friend WithEvents uxDescription As TextBox
    Friend WithEvents uxName As TextBox
    Friend WithEvents uxCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
End Class
