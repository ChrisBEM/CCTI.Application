Imports CCTI.DataAccessTier
Imports TypedDataAccess

Public Class ClassRosterRecord
    Private studentMainFrm As StudentMaintenenceForm
    Private courseMainFrm As CourseMaintenanceForm
    Private studentCoursesFrm As StudentCourses
    Private listOfCourseFrm As ListOfCourse
    Private classListFrm As ClassList
    Private db As RegistrationDataSet
    Private ClassRosterAdapter As RegistrationDataSetTableAdapters.ClassRosterTableAdapter

    Private Sub ClassRosterRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uxCourses.DataSource = RegistrationManager.Instance.GetCourses()
        uxCourses.DisplayMember = "Name"
        uxCourses.ValueMember = "Code"

        uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()
        uxCourseSection.DisplayMember = "SectionCode"
        uxCourseSection.ValueMember = "SectionCode"

        uxStudents.DataSource = RegistrationManager.Instance.GetStudents()
        uxStudents.DisplayMember = "FirstName"
        uxStudents.ValueMember = "ID"

        db = New RegistrationDataSet()
        ClassRosterAdapter = New RegistrationDataSetTableAdapters.ClassRosterTableAdapter()

        'populate class Roster
        ClassRosterAdapter.Fill(db.ClassRoster)
        uxClassRoster.DataSource = db.ClassRoster

    End Sub

    Private Sub uxCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub uxDelete_Click(sender As Object, e As EventArgs) Handles uxDelete.Click
        'delete a class roster
        If MessageBox.Show("Are you sure you want to delete this student?",
                           "Delete Confirmation",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim row =
            (CType(uxClassRoster.CurrentRow.DataBoundItem, DataRowView)).Row
            row.Delete()
        End If
    End Sub

    Private Sub uxClose_Click(sender As Object, e As EventArgs) Handles uxClose.Click
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PresentationFormToolStripMenuItem_Click(sender As Object, e As EventArgs)

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

    Private Sub ListOfCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfCourseToolStripMenuItem.Click
        Me.Hide()
        If listOfCourseFrm Is Nothing OrElse listOfCourseFrm.IsDisposed Then
            listOfCourseFrm = New ListOfCourse()
        End If
        listOfCourseFrm.Show()
        listOfCourseFrm.BringToFront()
    End Sub

    Private Sub ClassListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassListToolStripMenuItem.Click
        Me.Hide()
        If classListFrm Is Nothing OrElse classListFrm.IsDisposed Then
            classListFrm = New ClassList()
        End If
        classListFrm.Show()
        classListFrm.BringToFront()
    End Sub

    Private Sub uxSave_Click(sender As Object, e As EventArgs) Handles uxSave.Click
        Dim row As RegistrationDataSet.ClassRosterRow = db.ClassRoster.NewClassRosterRow
        row.CourseCode = Convert.ToString(uxCourses.SelectedValue)
        row.SectionCode = uxCourseSection.Text
        row.StudentID = Convert.ToInt32(uxStudents.SelectedValue)
        row.DateRegistered = uxRegisteredDate.Text


        db.ClassRoster.AddClassRosterRow(row)
        ClassRosterAdapter.Update(db.ClassRoster)

    End Sub
End Class