Public Class Form1
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Joel's Hangman! Remember to press the instructions button to read the rules and other information before you play!", MsgBoxStyle.Information, "Welcome!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtPlay1.Text = "" Then
            MsgBox("Please enter a player name before continuing")
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class
