Imports CCTI.DataAccessTier

Public Class StudentCourses
    Private studentMainFrm As StudentMaintenenceForm
    Private courseMainFrm As CourseMaintenanceForm
    Private classRosterFrm As ClassRosterRecord
    Private listOfCourseFrm As ListOfCourse

    Private Sub uxDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MaintenanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub MaintenanceFormToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub uxDelete_Click_1(sender As Object, e As EventArgs) Handles uxDelete.Click
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

    Private Sub uxClose_Click(sender As Object, e As EventArgs) Handles uxClose.Click
        Close()
    End Sub

    Private Sub ClassRosterRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassRosterRecordToolStripMenuItem.Click
        Me.Hide()
        If classRosterFrm Is Nothing OrElse classRosterFrm.IsDisposed Then
            classRosterFrm = New ClassRosterRecord()
        End If
        classRosterFrm.Show()
        classRosterFrm.BringToFront()
    End Sub

    Private Sub StudentCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uxStudents.DataSource = RegistrationManager.Instance.GetStudents()
    End Sub

    Private Sub ListOfCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfCourseToolStripMenuItem.Click
        Me.Hide()
        If listOfCourseFrm Is Nothing OrElse listOfCourseFrm.IsDisposed Then
            listOfCourseFrm = New ListOfCourse()
        End If
        listOfCourseFrm.Show()
        listOfCourseFrm.BringToFront()
    End Sub

    Private Sub uxStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uxStudents.SelectedIndexChanged
        uxCourses.DataSource = RegistrationManager.Instance.GetStudentCourses(CType(uxStudents.SelectedValue, BusinessEntities.Student))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uxTotalCost.Text = "0"
        For Each row As DataGridViewRow In uxCourses.Rows
            uxTotalCost.Text = Convert.ToString(Decimal.Parse(uxTotalCost.Text) + Decimal.Parse(row.Cells("Cost").Value))
        Next

    End Sub
End Class