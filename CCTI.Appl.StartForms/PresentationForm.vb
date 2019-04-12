Imports StudentMaintenanceForm
Imports CCTI.DataAccessTier


Public Class PresentationForm
    Private studentMainFrm As StudentMaintenenceForm
    Private courseMainFrm As CourseMaintenanceForm
    Private loginForm As LoginForm
    Private classRoster As ClassRosterRecord
    Private studentCoursesFrm As StudentCourses
    Private listOfCourseFrm As ListOfCourse
    Private classListFrm As ClassList

    Private Sub PresentationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        'Me.Hide()
        If studentMainFrm Is Nothing OrElse studentMainFrm.IsDisposed Then
            studentMainFrm = New StudentMaintenenceForm()
        End If
        studentMainFrm.Show()
        studentMainFrm.BringToFront()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'Me.Hide()
        If courseMainFrm Is Nothing OrElse courseMainFrm.IsDisposed Then
            courseMainFrm = New CourseMaintenanceForm()
        End If
        courseMainFrm.Show()
        courseMainFrm.BringToFront()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        'Me.Hide()
        If loginForm Is Nothing OrElse loginForm.IsDisposed Then
            loginForm = New LoginForm()
        End If
        loginForm.Show()
        loginForm.BringToFront()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        'Me.Hide()
        If classRoster Is Nothing OrElse classRoster.IsDisposed Then
            classRoster = New ClassRosterRecord()
        End If
        classRoster.Show()
        classRoster.BringToFront()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        'Me.Hide()
        If studentCoursesFrm Is Nothing OrElse studentCoursesFrm.IsDisposed Then
            studentCoursesFrm = New StudentCourses()
        End If
        studentCoursesFrm.Show()
        studentCoursesFrm.BringToFront()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        'Me.Hide()
        If listOfCourseFrm Is Nothing OrElse listOfCourseFrm.IsDisposed Then
            listOfCourseFrm = New ListOfCourse()
        End If
        listOfCourseFrm.Show()
        listOfCourseFrm.BringToFront()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        'Me.Hide()
        If classListFrm Is Nothing OrElse classListFrm.IsDisposed Then
            classListFrm = New ClassList()
        End If
        classListFrm.Show()
        classListFrm.BringToFront()
    End Sub
End Class