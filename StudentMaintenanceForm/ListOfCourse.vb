Imports CCTI.DataAccessTier
Imports TypedDataAccess

Public Class ListOfCourse
    Private studentMainFrm As StudentMaintenenceForm
    Private courseMainFrm As CourseMaintenanceForm
    Private studentCoursesFrm As StudentCourses
    Private classRosterFrm As ClassRosterRecord

    Private isLoaded As Boolean = False

    Private db As RegistrationDataSet
    Private CourseAdapter As RegistrationDataSetTableAdapters.CourseTableAdapter
    Private CourseSectionAdapter As RegistrationDataSetTableAdapters.CourseSectionTableAdapter

    Private Sub ListOfCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'uxCourses.DataSource = RegistrationManager.Instance.GetCourses()

        'uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()

        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        isLoaded = True

    End Sub

    Private Sub uxClose_Click(sender As Object, e As EventArgs) Handles uxClose.Click
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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

    Private Sub StudentCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentCoursesToolStripMenuItem.Click
        Me.Hide()
        If studentCoursesFrm Is Nothing OrElse studentCoursesFrm.IsDisposed Then
            studentCoursesFrm = New StudentCourses()
        End If
        studentCoursesFrm.Show()
        studentCoursesFrm.BringToFront()
    End Sub

    Private Sub ClassRosterRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassRosterRecordToolStripMenuItem.Click
        Me.Hide()
        If classRosterFrm Is Nothing OrElse classRosterFrm.IsDisposed Then
            classRosterFrm = New ClassRosterRecord()
        End If
        classRosterFrm.Show()
        classRosterFrm.BringToFront()
    End Sub

    Private Sub uxSave_Click(sender As Object, e As EventArgs) Handles uxSave.Click

    End Sub

    Private Sub uxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uxDepartment.SelectedIndexChanged
        uxCourses.DataSource = RegistrationManager.Instance.GetCourses(CType(uxDepartment.SelectedValue, BusinessEntities.Department).ID)

    End Sub

    Private Sub uxCourses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles uxCourses.CellContentClick

    End Sub

    Private Sub uxCourses_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourses.SelectionChanged
        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection(CType(uxCourses.CurrentRow.DataBoundItem, BusinessEntities.Course).Code)

    End Sub
End Class