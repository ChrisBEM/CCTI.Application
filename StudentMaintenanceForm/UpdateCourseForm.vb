Imports CCTI.DataAccessTier

Public Class UpdateCourseForm
    Private courseMainFrm As CourseMaintenanceForm
    Private addCourseFrm As AddCourseForm
    Private studentMainFrm As StudentMaintenenceForm
    Private _row As DataRow

    Private _course As BusinessEntities.Course
    Private _courseSection As BusinessEntities.CourseSection

    'close the form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    'call the forms attached
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Me.Hide()
        If addCourseFrm Is Nothing OrElse addCourseFrm.IsDisposed Then
            addCourseFrm = New AddCourseForm()
        End If
        addCourseFrm.Show()
        addCourseFrm.BringToFront()
    End Sub

    Private Sub MaintenanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        If addCourseFrm Is Nothing OrElse addCourseFrm.IsDisposed Then
            addCourseFrm = New AddCourseForm()
        End If
        addCourseFrm.Show()
        addCourseFrm.BringToFront()
    End Sub

    Private Sub UpdateCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill the grids and conbobox
        uxCourses.DataSource = RegistrationManager.Instance.GetCourses()
        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()

        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        uxDepartment.ValueMember = "ID"
    End Sub

    Private Sub uxCourses_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourses.SelectionChanged
        'get the data
        _course = CType(uxCourses.CurrentRow.DataBoundItem, BusinessEntities.Course)
        uxCode.Text = _course.Code
        uxName.Text = _course.Name
        uxDescription.Text = _course.Description
        uxCost.Text = _course.Cost
        uxDepartment.SelectedValue = _course.DepartmentID
    End Sub

    Private Sub uxCourseSection_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourseSection.SelectionChanged
        _courseSection = CType(uxCourseSection.CurrentRow.DataBoundItem, BusinessEntities.CourseSection)
        uxCode.Text = _courseSection.CourseCode
        uxSectionCode.Text = _courseSection.SectionCode
        uxStartDate.Text = _courseSection.StartDate
        uxEndDate.Text = _courseSection.EndDate
        uxRoomNumber.Text = _courseSection.RoomNumber
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        _course.Code = uxCode.Text
        _course.Name = uxName.Text
        _course.Description = uxDescription.Text
        _course.Cost = uxCost.Text
        _course.DepartmentID = Convert.ToInt32(uxDepartment.SelectedValue)

        _courseSection.SectionCode = uxSectionCode.Text
        _courseSection.StartDate = uxStartDate.Text
        _courseSection.EndDate = uxEndDate.Text
        _courseSection.RoomNumber = uxRoomNumber.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegistrationManager.Instance.SaveAll()
    End Sub
End Class