Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnMyBio_Click(sender As Object, e As EventArgs) Handles btnMyBio.Click

        'Declare var Name
        Dim Name As String
        Dim Surname As String

        Name = txtName.Text
        Surname = txtSurname.Text

        If Name = "Oratile" Then
            MsgBox("Oratile")
        ElseIf Surname = "Legae" Then
            MsgBox("Legae")
        Else
            MsgBox("Your Name and Surname is not listed")
        End If


        'Declare var Year you were born
        Dim Yearyouwereborn As Integer
        Dim Age As Integer

        Yearyouwereborn = txtYearyouwereborn.Text

        Age = 2023 - Yearyouwereborn

        If Age = "Yearyouwereborn" Then
            MsgBox("Born this year")

        End If

        'Declare var Tribe
        Dim Tribe As String

        Tribe = txtTribe.Text

        If Tribe = "Setswana" Then
            MsgBox("Tswana")
        ElseIf Tribe = "English" Then
            MsgBox("Hi")
        Else
            MsgBox("Your tribe is not listed")
        End If

        'Declare var gender
        Dim title As String
        Dim Gender As String

        Gender = txtGender.Text

        If Gender = "male" Then
            title = "gentleman"
        ElseIf title = "female" Then
            title = "lady"
        Else
            title = "other"
        End If

        MsgBox("Hi " & Name & " " & Surname & ", you are a " & " " & Age & " " & Gender & " " & "who speaks " & Tribe)


    End Sub
End Class
