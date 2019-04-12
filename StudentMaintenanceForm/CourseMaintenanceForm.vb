Imports CCTI.DataAccessTier

Public Class CourseMaintenanceForm
    Private addCourseFrm As AddCourseForm
    Private updateCourseFrm As UpdateCourseForm
    Private studentMainFrm As StudentMaintenenceForm

    Private _course As BusinessEntities.Course
    Private _courseSection As BusinessEntities.CourseSection

    Private Sub CourseMaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Loading data to the grids
        uxCourses.DataSource = RegistrationManager.Instance.GetCourses()
        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles uxCode.TextChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    ''calling attached forms
    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Me.Hide()
        If addCourseFrm Is Nothing OrElse addCourseFrm.IsDisposed Then
            addCourseFrm = New AddCourseForm()
        End If
        addCourseFrm.Show()
        addCourseFrm.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If addCourseFrm Is Nothing OrElse addCourseFrm.IsDisposed Then
            addCourseFrm = New AddCourseForm()
        End If
        addCourseFrm.Show()
        addCourseFrm.BringToFront()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Hide()
        If updateCourseFrm Is Nothing OrElse updateCourseFrm.IsDisposed Then
            updateCourseFrm = New UpdateCourseForm()
        End If
        updateCourseFrm.Show()
        updateCourseFrm.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        If updateCourseFrm Is Nothing OrElse updateCourseFrm.IsDisposed Then
            updateCourseFrm = New UpdateCourseForm()
        End If
        updateCourseFrm.Show()
        updateCourseFrm.BringToFront()
    End Sub

    Private Sub MaintenanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem.Click
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


    ''display the data from the grids to the combobox/Course
    Private Sub uxCourses_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourses.SelectionChanged
        _course = CType(uxCourses.CurrentRow.DataBoundItem, BusinessEntities.Course)
        uxCode.Text = _course.Code
        uxName.Text = _course.Name
        uxDescription.Text = _course.Description
        uxCost.Text = _course.Cost
        uxDepartment.SelectedValue = _course.DepartmentID
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete a course
        If MessageBox.Show("Are you sure you want to delete this course?",
                           "Delete Confirmation",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim row =
            (CType(uxCourses.CurrentRow.DataBoundItem, DataRowView)).Row
            row.Delete()
        End If
    End Sub


    ''display the data from the grid to the combobox/Course section
    Private Sub uxCourseSection_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourseSection.SelectionChanged
        _courseSection = CType(uxCourseSection.CurrentRow.DataBoundItem, BusinessEntities.CourseSection)
        uxCode.Text = _courseSection.CourseCode
        uxSectionCode.Text = _courseSection.SectionCode
        uxStartDate.Text = _courseSection.StartDate
        uxEndDate.Text = _courseSection.EndDate
        uxRoomNumber.Text = _courseSection.RoomNumber
    End Sub
End Class