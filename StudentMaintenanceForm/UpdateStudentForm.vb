Imports CCTI.DataAccessTier

Public Class UpdateStudentForm
    Private studentMainFrm As StudentMaintenenceForm
    Private AddStudentFrm As AddStudentForm
    Private courseMainFrm As CourseMaintenanceForm
    Private _student As BusinessEntities.Student

    'Close the form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    'Call the forms attached
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Hide()
        If AddStudentFrm Is Nothing OrElse AddStudentFrm.IsDisposed Then
            AddStudentFrm = New AddStudentForm()
        End If
        AddStudentFrm.Show()
        AddStudentFrm.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        If AddStudentFrm Is Nothing OrElse AddStudentFrm.IsDisposed Then
            AddStudentFrm = New AddStudentForm()
        End If
        AddStudentFrm.Show()
        AddStudentFrm.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub UpdateStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill the grid and comboboxes
        uxStudents.DataSource = RegistrationManager.Instance.GetStudents()

        uxProvince.DataSource = RegistrationManager.Instance.GetProvinces()
        uxProvince.DisplayMember = "Name"
        uxProvince.ValueMember = "Code"

        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        uxDepartment.ValueMember = "ID"
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub uxStudents_SelectionChanged(sender As Object, e As EventArgs) Handles uxStudents.SelectionChanged
        _student = CType(uxStudents.CurrentRow.DataBoundItem, BusinessEntities.Student)
        uxId.Text = _student.ID

        uxFirstName.Text = _student.FirstName
        uxLastName.Text = _student.LastName
        uxAddress.Text = _student.Address
        uxCity.Text = _student.City
        uxProvince.SelectedValue = _student.Province
        uxPostalCode.Text = _student.PostalCode
        uxPhone.Text = _student.Phone
        uxEmail.Text = _student.Email
        uxDepartment.SelectedValue = _student.DepartmentID

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _student.FirstName = uxFirstName.Text
        _student.LastName = uxLastName.Text
        _student.Address = uxAddress.Text
        _student.City = uxCity.Text
        _student.Province = Convert.ToString(uxProvince.SelectedValue)
        _student.PostalCode = uxPostalCode.Text
        _student.Phone = uxPhone.Text
        _student.Email = uxEmail.Text
        _student.DepartmentID = Convert.ToInt32(uxDepartment.SelectedValue)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegistrationManager.Instance.SaveAll()

    End Sub
End Class