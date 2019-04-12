Imports CCTI.DataAccessTier

Public Class ClassList
    Private studentMainFrm As StudentMaintenenceForm
    Private courseMainFrm As CourseMaintenanceForm
    Private studentCoursesFrm As StudentCourses
    Private classRosterFrm As ClassRosterRecord
    Private listOfCourseFrm As ListOfCourse

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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

    Private Sub MaintenanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem.Click
        Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub StudentCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentCoursesToolStripMenuItem.Click
        Me.Hide()
        If studentCoursesFrm Is Nothing OrElse studentCoursesFrm.IsDisposed Then
            studentCoursesFrm = New StudentCourses()
        End If
        studentCoursesFrm.Show()
        studentCoursesFrm.BringToFront()
    End Sub

    Private Sub MaintenanceFormToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaintenanceFormToolStripMenuItem1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub ListOfCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfCourseToolStripMenuItem.Click
        Me.Hide()
        If listOfCourseFrm Is Nothing OrElse listOfCourseFrm.IsDisposed Then
            listOfCourseFrm = New ListOfCourse()
        End If
        listOfCourseFrm.Show()
        listOfCourseFrm.BringToFront()
    End Sub

    Private Sub ClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uxCourses.DataSource = RegistrationManager.Instance.GetCourses()

        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()
    End Sub

    Private Sub uxClose_Click(sender As Object, e As EventArgs) Handles uxClose.Click
        Close()
    End Sub

    Private Sub uxCourses_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourses.SelectionChanged
        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection(CType(uxCourses.CurrentRow.DataBoundItem, BusinessEntities.Course).Code)
        uxStudent.DataSource = RegistrationManager.Instance.GetStudentByCourses(CType(uxCourses.CurrentRow.DataBoundItem, BusinessEntities.Course))
    End Sub
End Class