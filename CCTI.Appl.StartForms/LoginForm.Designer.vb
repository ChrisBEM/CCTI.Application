<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.uxPassword = New System.Windows.Forms.TextBox()
        Me.uxUserName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.uxLogin = New System.Windows.Forms.Button()
        Me.uxCancel = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.uxClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'uxPassword
        '
        Me.uxPassword.Location = New System.Drawing.Point(245, 219)
        Me.uxPassword.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxPassword.Name = "uxPassword"
        Me.uxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.uxPassword.Size = New System.Drawing.Size(192, 22)
        Me.uxPassword.TabIndex = 24
        '
        'uxUserName
        '
        Me.uxUserName.Location = New System.Drawing.Point(245, 158)
        Me.uxUserName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxUserName.Name = "uxUserName"
        Me.uxUserName.Size = New System.Drawing.Size(192, 22)
        Me.uxUserName.TabIndex = 23
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label4.Font = New System.Drawing.Font("High Tower Text", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(245, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(143, 24)
        Me.label4.TabIndex = 22
        Me.label4.Text = "LOGIN FORM"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(89, 225)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(62, 16)
        Me.label3.TabIndex = 21
        Me.label3.Text = "Password :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(81, 167)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 16)
        Me.label2.TabIndex = 20
        Me.label2.Text = "User Name :"
        '
        'uxLogin
        '
        Me.uxLogin.Location = New System.Drawing.Point(280, 307)
        Me.uxLogin.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxLogin.Name = "uxLogin"
        Me.uxLogin.Size = New System.Drawing.Size(118, 42)
        Me.uxLogin.TabIndex = 19
        Me.uxLogin.Text = "&Login"
        Me.uxLogin.UseVisualStyleBackColor = True
        '
        'uxCancel
        '
        Me.uxCancel.Location = New System.Drawing.Point(35, 307)
        Me.uxCancel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxCancel.Name = "uxCancel"
        Me.uxCancel.Size = New System.Drawing.Size(118, 42)
        Me.uxCancel.TabIndex = 18
        Me.uxCancel.Text = "&Cancel"
        Me.uxCancel.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.label1.Location = New System.Drawing.Point(59, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(485, 21)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Welcome To The Calgary Technical Training Institute"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uxClose
        '
        Me.uxClose.Location = New System.Drawing.Point(492, 307)
        Me.uxClose.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.uxClose.Name = "uxClose"
        Me.uxClose.Size = New System.Drawing.Size(118, 42)
        Me.uxClose.TabIndex = 25
        Me.uxClose.Text = "C&LOSE"
        Me.uxClose.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(622, 364)
        Me.Controls.Add(Me.uxClose)
        Me.Controls.Add(Me.uxPassword)
        Me.Controls.Add(Me.uxUserName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.uxLogin)
        Me.Controls.Add(Me.uxCancel)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LoginForm"
        Me.Text = "Calgary Technical Training Institue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents uxPassword As TextBox
    Private WithEvents uxUserName As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents uxLogin As Button
    Private WithEvents uxCancel As Button
    Private WithEvents label1 As Label
    Private WithEvents uxClose As Button
End Class
