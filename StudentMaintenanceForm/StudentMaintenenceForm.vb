Imports CCTI.DataAccessTier


Public Class StudentMaintenenceForm
    Private AddStudentFrm As AddStudentForm
    Private updateStudentFrm As UpdateStudentForm
    Private courseMainFrm As CourseMaintenanceForm
    Private _student As BusinessEntities.Student


    ''Calling Attached Forms
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If AddStudentFrm Is Nothing OrElse AddStudentFrm.IsDisposed Then
            AddStudentFrm = New AddStudentForm()
        End If
        AddStudentFrm.Show()
        AddStudentFrm.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub StudentMaintenenceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uxStudents.DataSource = RegistrationManager.Instance.GetStudents()
        uxProvince.DataSource = RegistrationManager.Instance.GetProvinces()
        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()

        uxProvince.DataSource = RegistrationManager.Instance.GetProvinces()
        uxProvince.DisplayMember = "Name"
        uxProvince.ValueMember = "Code"

        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        uxDepartment.ValueMember = "ID"
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.Hide()
        If AddStudentFrm Is Nothing OrElse AddStudentFrm.IsDisposed Then
            AddStudentFrm = New AddStudentForm()
        End If
        AddStudentFrm.Show()
        AddStudentFrm.BringToFront()
    End Sub

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    ''Get the Data from the grid , display in the combobox
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete a student
        If MessageBox.Show("Are you sure you want to delete this student?",
                           "Delete Confirmation",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim row =
            (CType(uxStudents.CurrentRow.DataBoundItem, DataRowView)).Row
            row.Delete()
        End If
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click

    End Sub
End Class
