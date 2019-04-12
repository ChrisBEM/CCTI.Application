<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMaintenenceForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.uxProvince = New System.Windows.Forms.ComboBox()
        Me.uxDepartment = New System.Windows.Forms.ComboBox()
        Me.uxId = New System.Windows.Forms.TextBox()
        Me.uxFirstName = New System.Windows.Forms.TextBox()
        Me.uxLastName = New System.Windows.Forms.TextBox()
        Me.uxAddress = New System.Windows.Forms.TextBox()
        Me.uxCity = New System.Windows.Forms.TextBox()
        Me.uxPostalCode = New System.Windows.Forms.TextBox()
        Me.uxPhone = New System.Windows.Forms.TextBox()
        Me.uxEmail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.uxStudents = New System.Windows.Forms.DataGridView()
        Me.uxButtonsPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.uxStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uxButtonsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(284, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Maintenance Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "City :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Province :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 355)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Postal Code :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 397)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Phone :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 440)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 482)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Department :"
        '
        'uxProvince
        '
        Me.uxProvince.BackColor = System.Drawing.Color.GhostWhite
        Me.uxProvince.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxProvince.FormattingEnabled = True
        Me.uxProvince.Location = New System.Drawing.Point(141, 311)
        Me.uxProvince.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxProvince.Name = "uxProvince"
        Me.uxProvince.Size = New System.Drawing.Size(234, 21)
        Me.uxProvince.TabIndex = 11
        '
        'uxDepartment
        '
        Me.uxDepartment.BackColor = System.Drawing.Color.GhostWhite
        Me.uxDepartment.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxDepartment.FormattingEnabled = True
        Me.uxDepartment.Location = New System.Drawing.Point(141, 474)
        Me.uxDepartment.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxDepartment.Name = "uxDepartment"
        Me.uxDepartment.Size = New System.Drawing.Size(234, 21)
        Me.uxDepartment.TabIndex = 12
        '
        'uxId
        '
        Me.uxId.BackColor = System.Drawing.Color.GhostWhite
        Me.uxId.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxId.Location = New System.Drawing.Point(141, 116)
        Me.uxId.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxId.Name = "uxId"
        Me.uxId.ReadOnly = True
        Me.uxId.Size = New System.Drawing.Size(234, 20)
        Me.uxId.TabIndex = 13
        '
        'uxFirstName
        '
        Me.uxFirstName.BackColor = System.Drawing.Color.GhostWhite
        Me.uxFirstName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxFirstName.Location = New System.Drawing.Point(141, 154)
        Me.uxFirstName.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxFirstName.Name = "uxFirstName"
        Me.uxFirstName.ReadOnly = True
        Me.uxFirstName.Size = New System.Drawing.Size(234, 20)
        Me.uxFirstName.TabIndex = 14
        '
        'uxLastName
        '
        Me.uxLastName.BackColor = System.Drawing.Color.GhostWhite
        Me.uxLastName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxLastName.Location = New System.Drawing.Point(141, 195)
        Me.uxLastName.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxLastName.Name = "uxLastName"
        Me.uxLastName.ReadOnly = True
        Me.uxLastName.Size = New System.Drawing.Size(234, 20)
        Me.uxLastName.TabIndex = 15
        '
        'uxAddress
        '
        Me.uxAddress.BackColor = System.Drawing.Color.GhostWhite
        Me.uxAddress.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxAddress.Location = New System.Drawing.Point(141, 234)
        Me.uxAddress.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxAddress.Name = "uxAddress"
        Me.uxAddress.ReadOnly = True
        Me.uxAddress.Size = New System.Drawing.Size(234, 20)
        Me.uxAddress.TabIndex = 16
        '
        'uxCity
        '
        Me.uxCity.BackColor = System.Drawing.Color.GhostWhite
        Me.uxCity.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxCity.Location = New System.Drawing.Point(141, 271)
        Me.uxCity.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxCity.Name = "uxCity"
        Me.uxCity.ReadOnly = True
        Me.uxCity.Size = New System.Drawing.Size(234, 20)
        Me.uxCity.TabIndex = 17
        '
        'uxPostalCode
        '
        Me.uxPostalCode.BackColor = System.Drawing.Color.GhostWhite
        Me.uxPostalCode.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxPostalCode.Location = New System.Drawing.Point(141, 348)
        Me.uxPostalCode.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxPostalCode.Name = "uxPostalCode"
        Me.uxPostalCode.ReadOnly = True
        Me.uxPostalCode.Size = New System.Drawing.Size(234, 20)
        Me.uxPostalCode.TabIndex = 18
        '
        'uxPhone
        '
        Me.uxPhone.BackColor = System.Drawing.Color.GhostWhite
        Me.uxPhone.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxPhone.Location = New System.Drawing.Point(141, 390)
        Me.uxPhone.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxPhone.Name = "uxPhone"
        Me.uxPhone.ReadOnly = True
        Me.uxPhone.Size = New System.Drawing.Size(234, 20)
        Me.uxPhone.TabIndex = 19
        '
        'uxEmail
        '
        Me.uxEmail.BackColor = System.Drawing.Color.GhostWhite
        Me.uxEmail.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxEmail.Location = New System.Drawing.Point(141, 433)
        Me.uxEmail.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxEmail.Name = "uxEmail"
        Me.uxEmail.ReadOnly = True
        Me.uxEmail.Size = New System.Drawing.Size(234, 20)
        Me.uxEmail.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(649, 20)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "&DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(931, 20)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "C&LOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'uxStudents
        '
        Me.uxStudents.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.uxStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uxStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxStudents.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.uxStudents.Location = New System.Drawing.Point(404, 116)
        Me.uxStudents.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxStudents.Name = "uxStudents"
        Me.uxStudents.Size = New System.Drawing.Size(629, 381)
        Me.uxStudents.TabIndex = 25
        '
        'uxButtonsPanel
        '
        Me.uxButtonsPanel.BackColor = System.Drawing.Color.GhostWhite
        Me.uxButtonsPanel.Controls.Add(Me.Button4)
        Me.uxButtonsPanel.Controls.Add(Me.Button3)
        Me.uxButtonsPanel.Controls.Add(Me.Button1)
        Me.uxButtonsPanel.Controls.Add(Me.Button2)
        Me.uxButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxButtonsPanel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.uxButtonsPanel.Location = New System.Drawing.Point(0, 529)
        Me.uxButtonsPanel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.uxButtonsPanel.Name = "uxButtonsPanel"
        Me.uxButtonsPanel.Size = New System.Drawing.Size(1045, 55)
        Me.uxButtonsPanel.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Indigo
        Me.Label12.Location = New System.Drawing.Point(695, 70)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 28)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Students List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Indigo
        Me.Label13.Location = New System.Drawing.Point(19, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(216, 28)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Student Information"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 24)
        Me.MenuStrip1.TabIndex = 29
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
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "&Student"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1})
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CourseToolStripMenuItem.Text = "&Course"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.AddToolStripMenuItem1.Text = "Maintenance Form"
        '
        'StudentMaintenenceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1045, 584)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.uxButtonsPanel)
        Me.Controls.Add(Me.uxStudents)
        Me.Controls.Add(Me.uxEmail)
        Me.Controls.Add(Me.uxPhone)
        Me.Controls.Add(Me.uxPostalCode)
        Me.Controls.Add(Me.uxCity)
        Me.Controls.Add(Me.uxAddress)
        Me.Controls.Add(Me.uxLastName)
        Me.Controls.Add(Me.uxFirstName)
        Me.Controls.Add(Me.uxId)
        Me.Controls.Add(Me.uxDepartment)
        Me.Controls.Add(Me.uxProvince)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "StudentMaintenenceForm"
        Me.Text = "Welcome To The Calgary Technical Training Institute"
        CType(Me.uxStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uxButtonsPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents uxDepartment As ComboBox
    Friend WithEvents uxId As TextBox
    Friend WithEvents uxFirstName As TextBox
    Friend WithEvents uxLastName As TextBox
    Friend WithEvents uxAddress As TextBox
    Friend WithEvents uxCity As TextBox
    Friend WithEvents uxPostalCode As TextBox
    Friend WithEvents uxPhone As TextBox
    Friend WithEvents uxEmail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents uxStudents As DataGridView
    Friend WithEvents uxButtonsPanel As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents uxProvince As ComboBox
End Class
