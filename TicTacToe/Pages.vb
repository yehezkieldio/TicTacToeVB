Module Pages
    Public Const StartPage As Integer = 0
    Public Const LoadingPage As Integer = 1
    Public Const GamePage As Integer = 2

    Public Sub ShowPage(pageIndex As Integer)
        For Each panel As Panel In Form1.Controls.OfType(Of Panel)()
            panel.Visible = False
        Next
        Select Case pageIndex
            Case StartPage
                Form1.StartPanel.Visible = True
            Case LoadingPage
                Form1.LoadingPanel.Visible = True
            Case GamePage
                Form1.GamePanel.Visible = True
        End Select
    End Sub

End Module
