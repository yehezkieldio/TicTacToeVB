Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pages.ShowPage(Pages.StartPage)

        Alignments.StartMenu()
        Alignments.LoadingMenu()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Pages.ShowPage(Pages.LoadingPage)

        For i As Integer = 0 To 100
            ProgressBar1.Value = i
            Threading.Thread.Sleep(10)

            If i = 100 Then
                Pages.ShowPage(GamePage)
            End If
        Next

        Game.VerifyPanelLoad()
    End Sub

    Public Sub GamePanel_Paint(sender As Object, e As PaintEventArgs) Handles GamePanel.Paint
        Game.InitializeGame()
    End Sub

    Private Sub QuitSessionButton_Click(sender As Object, e As EventArgs) Handles QuitSessionButton.Click
        Game.DisposeGame()
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        Game.Seconds += 1
        Game.UpdateTimerElapsed()
    End Sub

    Private Sub RestartGame_Click(sender As Object, e As EventArgs) Handles RestartGame.Click
        Game.RestartGame()
    End Sub
End Class
