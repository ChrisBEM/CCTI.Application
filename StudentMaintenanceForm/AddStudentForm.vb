Imports CCTI.DataAccessTier
Imports StudentMaintenanceForm
Imports TypedDataAccess
Imports TypedDataAccess.RegistrationTableAdapters

Public Class AddStudentForm
    Private studentMainFrm As StudentMaintenenceForm
    Private updateStudentFrm As UpdateStudentForm
    Private _row As DataRow
    Private db As Registration
    Private adapter As RegistrationTableAdapters.StudentTableAdapter


    ''calling forms
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Loading data in the comboboxes and grid

        uxProvince.DataSource = RegistrationManager.Instance.GetProvinces()
        uxProvince.DisplayMember = "Name"
        uxProvince.ValueMember = "Code"

        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        uxDepartment.ValueMember = "ID"
        db = New Registration()
        adapter = New RegistrationTableAdapters.StudentTableAdapter()
        adapter.Fill(db.Student)
        uxStudents.DataSource = db.Student
    End Sub

    ''attached forms
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Hide()
        If updateStudentFrm Is Nothing OrElse updateStudentFrm.IsDisposed Then
            updateStudentFrm = New UpdateStudentForm()
        End If
        updateStudentFrm.Show()
        updateStudentFrm.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        If updateStudentFrm Is Nothing OrElse updateStudentFrm.IsDisposed Then
            updateStudentFrm = New UpdateStudentForm()
        End If
        updateStudentFrm.Show()
        updateStudentFrm.BringToFront()
    End Sub

    Private Sub uxStudents_SelectionChanged(sender As Object, e As EventArgs) Handles uxStudents.SelectionChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Registration.StudentRow = db.Student.NewStudentRow
        row.FirstName = uxFirstName.Text
        row.LastName = uxLastName.Text
        row.Address = uxAddress.Text
        row.City = uxCity.Text
        row.Province = Convert.ToString(uxProvince.SelectedValue)
        row.PostalCode = uxPostalCode.Text
        row.Phone = uxPhone.Text
        row.Email = uxEmail.Text
        row.DepartmentID = Convert.ToInt32(uxDepartment.SelectedValue)
        db.Student.AddStudentRow(row)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adapter.Update(db.Student)
        RegistrationManager.Instance.SaveAll()

    End Sub
End Class