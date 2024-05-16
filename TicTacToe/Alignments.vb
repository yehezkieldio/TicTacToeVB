Module Alignments
    Public Sub StartMenu()
        Form1.StartTitle.Left = (Form1.StartPanel.Width - Form1.StartTitle.Width) \ 2
        Form1.StartTitle.Top = (Form1.StartPanel.Height - Form1.StartTitle.Height) \ 2

        Form1.StartSubtitle.Left = (Form1.StartPanel.Width - Form1.StartSubtitle.Width) \ 2
        Form1.StartSubtitle.Top = Form1.StartTitle.Bottom + 10

        Form1.StartButton.Left = (Form1.StartPanel.Width - Form1.StartButton.Width) \ 2
        Form1.StartButton.Top = Form1.StartSubtitle.Bottom + 30
    End Sub

    Public Sub LoadingMenu()
        Form1.LoadingText.Left = (Form1.LoadingPanel.Width - Form1.LoadingText.Width) \ 2
        Form1.LoadingText.Top = (Form1.LoadingPanel.Height - Form1.LoadingText.Height) \ 2

        Form1.ProgressBar1.Left = (Form1.LoadingPanel.Width - Form1.ProgressBar1.Width) \ 2
        Form1.ProgressBar1.Top = Form1.LoadingText.Bottom + 20
    End Sub
End Module
