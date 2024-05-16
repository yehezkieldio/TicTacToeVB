Module Game
    Public CurrentPlayer As Char = "X"
    Public Seconds As Integer = 0

    Public Sub UpdateCurrentPlayer(Player As Char)
        CurrentPlayer = Player
    End Sub

    Public Sub UpdateCurrentPlayerLabel(Player As Char)
        Form1.CurrentPlayerText.Text = "Current Player: " & Player
    End Sub

    Public Sub BindPictureBoxes()
        For Each PictureBox As PictureBox In Form1.GamePanel.Controls.OfType(Of PictureBox)
            If PictureBox.Name.StartsWith("PictureBox") Then
                PictureBox.TabIndex = CInt(PictureBox.Name.Substring(10))

                ' Add event handler to each PictureBox
                AddHandler PictureBox.Click, AddressOf PictureBox_Click
            End If
        Next
    End Sub

    ' Handle PictureBox click event to place X or O and determine winner
    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim PictureBox As PictureBox = DirectCast(sender, PictureBox)

        If PictureBox.Image Is Nothing Then
            If CurrentPlayer = "X"c Then
                PictureBox.Image = My.Resources.X
                UpdateCurrentPlayer("O")
            Else
                PictureBox.Image = My.Resources.O
                UpdateCurrentPlayer("X")
            End If
        End If

        UpdateCurrentPlayerLabel(CurrentPlayer)
    End Sub

    Public Sub InitializeGame()
        UpdateCurrentPlayer("X")
        UpdateCurrentPlayerLabel("X")

        Form1.GameTimer.Interval = 1000
        Form1.GameTimer.Start()

        BindPictureBoxes()
    End Sub

    Public Sub RestartGame()
        UpdateCurrentPlayer("X")

        For Each PictureBox As PictureBox In Form1.GamePanel.Controls.OfType(Of PictureBox)
            If PictureBox.Name.StartsWith("PictureBox") Then
                PictureBox.Image = Nothing
            End If
        Next

        Form1.GameTimer.Stop()
        ResetTimer()

        Pages.ShowPage(LoadingPage)
        For i As Integer = 0 To 100
            Form1.ProgressBar1.Value = i
            Threading.Thread.Sleep(10)

            If i = 100 Then
                Pages.ShowPage(GamePage)
            End If
        Next

        Game.VerifyPanelLoad()
    End Sub

    Public Sub DisposeGame()
        UpdateCurrentPlayer("X")

        For Each PictureBox As PictureBox In Form1.GamePanel.Controls.OfType(Of PictureBox)
            If PictureBox.Name.StartsWith("PictureBox") Then
                PictureBox.Image = Nothing

                ' Remove event handler from each PictureBox
                RemoveHandler PictureBox.Click, AddressOf PictureBox_Click
            End If
        Next

        Form1.GameTimer.Stop()
        ResetTimer()

        Pages.ShowPage(Pages.StartPage)
    End Sub

    Public Sub UpdateTimerElapsed()
        Dim hours As Integer = Seconds / 3600
        Dim minutes As Integer = (Seconds Mod 3600) / 60
        Dim secs As Integer = Seconds Mod 60

        Form1.TimerText.Text = "Time Elapsed: " & String.Format("{0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), secs.ToString("00"))
    End Sub

    Public Sub ResetTimer()
        Seconds = 0
        UpdateTimerElapsed()
    End Sub

    Public Sub VerifyPanelLoad()
        If Form1.GamePanel.Visible = True Then
            InitializeGame()
        End If
    End Sub

End Module
