Public Class Form3
    Private Sub BtnBackHome_Click(sender As Object, e As EventArgs) Handles btnBackHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Mus, AudioPlayMode.BackgroundLoop)
    End Sub

End Class