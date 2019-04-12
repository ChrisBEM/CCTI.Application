Imports CCTI.DataAccessTier
Imports TypedDataAccess
Imports TypedDataAccess.RegistrationDataSet

Public Class AddCourseForm

    Private courseMainFrm As CourseMaintenanceForm
    Private updateCourseFrm As UpdateCourseForm
    Private studentMainFrm As StudentMaintenenceForm
    Private _row As DataRow

    Private db As RegistrationDataSet
    Private CourseAdapter As RegistrationDataSetTableAdapters.CourseTableAdapter
    Private CourseSectionAdapter As RegistrationDataSetTableAdapters.CourseSectionTableAdapter

    Private _course As BusinessEntities.Course
    Private _courseSection As BusinessEntities.CourseSection

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        If updateCourseFrm Is Nothing OrElse updateCourseFrm.IsDisposed Then
            updateCourseFrm = New UpdateCourseForm()
        End If
        updateCourseFrm.Show()
        updateCourseFrm.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub uxCourseSection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles uxCourseSection.CellContentClick

    End Sub

    Private Sub AddCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Instantiate the data objects

        'uxCourses.DataSource = RegistrationManager.Instance.GetCourses()
        'uxCourseSection.DataSource = RegistrationManager.Instance.GetCourseSection()


        'populate department
        uxDepartment.DataSource = RegistrationManager.Instance.GetDepartments()
        uxDepartment.DisplayMember = "Name"
        uxDepartment.ValueMember = "ID"

        db = New RegistrationDataSet()
        CourseAdapter = New RegistrationDataSetTableAdapters.CourseTableAdapter()
        CourseSectionAdapter = New RegistrationDataSetTableAdapters.CourseSectionTableAdapter()
        CourseAdapter.Fill(db.Course)
        CourseSectionAdapter.Fill(db.CourseSection)
        uxCourses.DataSource = db.Course
        uxCourseSection.DataSource = db.CourseSection
    End Sub

    Private Sub uxCourses_SelectionChanged(sender As Object, e As EventArgs) Handles uxCourses.SelectionChanged
        'we display only the code 
        _row = (CType(uxCourses.CurrentRow.DataBoundItem, DataRowView)).Row
        uxCode.Text = _row("Code").ToString()

    End Sub

    'Add a new Course
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim _row As RegistrationDataSet.CourseRow = db.Course.NewCourseRow
        _row.Code = uxCode.Text
        _row.Name = uxName.Text
        _row.Description = uxDescription.Text
        _row.Cost = Convert.ToDecimal(uxCost.Text)
        _row.DepartmentID = Convert.ToInt32(uxDepartment.SelectedValue)

        db.Course.AddCourseRow(_row)

        CourseAdapter.Update(db.Course)
    End Sub


    'Add a new Course Section
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim row As RegistrationDataSet.CourseSectionRow = db.CourseSection.NewCourseSectionRow
        row.CourseCode = uxCode.Text
        row.SectionCode = uxSectionCode.Text
        row.StartDate = uxStartDate.Text
        row.EndDate = Convert.ToDateTime(uxEndDate.Value)
        row.RoomNumber = uxRoomNumber.Text

        db.CourseSection.AddCourseSectionRow(row)
        CourseSectionAdapter.Update(db.CourseSection)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        RegistrationManager.Instance.SaveAll()

    End Sub

End Class