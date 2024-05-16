﻿Public Class Form1
    Private Const StartPage As Integer = 0
    Private Const LoadingPage As Integer = 1
    Private Const GamePage As Integer = 2

    Private CurrentPlayer As Char = "X"c

    Private Sub ShowPage(pageIndex As Integer)
        For Each panel As Panel In Me.Controls.OfType(Of Panel)()
            panel.Visible = False
        Next
        Select Case pageIndex
            Case StartPage
                StartPanel.Visible = True
            Case LoadingPage
                LoadingPanel.Visible = True
            Case GamePage
                GamePanel.Visible = True
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPage(StartPage)

        ' Start Menu element alignments

        StartTitle.Left = (StartPanel.Width - StartTitle.Width) \ 2
        StartTitle.Top = (StartPanel.Height - StartTitle.Height) \ 2

        StartSubtitle.Left = (StartPanel.Width - StartSubtitle.Width) \ 2
        StartSubtitle.Top = StartTitle.Bottom + 10

        StartButton.Left = (StartPanel.Width - StartButton.Width) \ 2
        StartButton.Top = StartSubtitle.Bottom + 30

        ' Loading Menu elements alignments

        LoadingText.Left = (LoadingPanel.Width - LoadingText.Width) \ 2
        LoadingText.Top = (LoadingPanel.Height - LoadingText.Height) \ 2

        ProgressBar1.Left = (LoadingPanel.Width - ProgressBar1.Width) \ 2
        ProgressBar1.Top = LoadingText.Bottom + 20
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        LoadingText.Left = (LoadingPanel.Width - LoadingText.Width) \ 2
        LoadingText.Top = (LoadingPanel.Height - LoadingText.Height) \ 2

        ProgressBar1.Left = (LoadingPanel.Width - ProgressBar1.Width) \ 2
        ProgressBar1.Top = LoadingText.Bottom + 20

        ShowPage(LoadingPage)

        For i As Integer = 0 To 100
            ProgressBar1.Value = i
            Threading.Thread.Sleep(10)

            If i = 100 Then
                ShowPage(GamePage)
            End If
        Next
    End Sub

    Private Sub QuitSessionButton_Click(sender As Object, e As EventArgs) Handles QuitSessionButton.Click
        ShowPage(StartPage)
        ProgressBar1.Value = 0
    End Sub

    Private Sub GamePanel_Paint(sender As Object, e As PaintEventArgs) Handles GamePanel.Paint
        CurrentPlayerText.Text = "Current Player: " & CurrentPlayer


    End Sub
End Class