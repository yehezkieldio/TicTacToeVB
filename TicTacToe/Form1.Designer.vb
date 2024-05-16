<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        StartPanel = New Panel()
        StartSubtitle = New Label()
        StartTitle = New Label()
        StartButton = New Button()
        LoadingPanel = New Panel()
        LoadingText = New Label()
        ProgressBar1 = New ProgressBar()
        GamePanel = New Panel()
        TimerText = New Label()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CurrentPlayerText = New Label()
        QuitSessionButton = New Button()
        GameTimer = New Timer(components)
        RestartGame = New Button()
        StartPanel.SuspendLayout()
        LoadingPanel.SuspendLayout()
        GamePanel.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartPanel
        ' 
        StartPanel.AutoSize = True
        StartPanel.Controls.Add(StartSubtitle)
        StartPanel.Controls.Add(StartTitle)
        StartPanel.Controls.Add(StartButton)
        StartPanel.Location = New Point(0, 0)
        StartPanel.Name = "StartPanel"
        StartPanel.Size = New Size(807, 300)
        StartPanel.TabIndex = 0
        ' 
        ' StartSubtitle
        ' 
        StartSubtitle.AutoSize = True
        StartSubtitle.Location = New Point(130, 90)
        StartSubtitle.Name = "StartSubtitle"
        StartSubtitle.Size = New Size(184, 15)
        StartSubtitle.TabIndex = 4
        StartSubtitle.Text = "2311032 Yehezkiel Dio Sinolungan"
        ' 
        ' StartTitle
        ' 
        StartTitle.AutoSize = True
        StartTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        StartTitle.Location = New Point(130, 48)
        StartTitle.Name = "StartTitle"
        StartTitle.Size = New Size(153, 32)
        StartTitle.TabIndex = 3
        StartTitle.Text = "TIC TAC TOE"
        ' 
        ' StartButton
        ' 
        StartButton.Anchor = AnchorStyles.Left
        StartButton.Location = New Point(130, 124)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(75, 23)
        StartButton.TabIndex = 2
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' LoadingPanel
        ' 
        LoadingPanel.Controls.Add(LoadingText)
        LoadingPanel.Controls.Add(ProgressBar1)
        LoadingPanel.Location = New Point(0, 0)
        LoadingPanel.Name = "LoadingPanel"
        LoadingPanel.Size = New Size(804, 297)
        LoadingPanel.TabIndex = 0
        LoadingPanel.Visible = False
        ' 
        ' LoadingText
        ' 
        LoadingText.AutoSize = True
        LoadingText.Location = New Point(87, 109)
        LoadingText.Name = "LoadingText"
        LoadingText.Size = New Size(59, 15)
        LoadingText.TabIndex = 1
        LoadingText.Text = "Loading..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(87, 152)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(175, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' GamePanel
        ' 
        GamePanel.Controls.Add(RestartGame)
        GamePanel.Controls.Add(TimerText)
        GamePanel.Controls.Add(PictureBox9)
        GamePanel.Controls.Add(PictureBox8)
        GamePanel.Controls.Add(PictureBox7)
        GamePanel.Controls.Add(PictureBox6)
        GamePanel.Controls.Add(PictureBox5)
        GamePanel.Controls.Add(PictureBox4)
        GamePanel.Controls.Add(PictureBox3)
        GamePanel.Controls.Add(PictureBox2)
        GamePanel.Controls.Add(PictureBox1)
        GamePanel.Controls.Add(CurrentPlayerText)
        GamePanel.Controls.Add(QuitSessionButton)
        GamePanel.Location = New Point(0, 0)
        GamePanel.Name = "GamePanel"
        GamePanel.Size = New Size(801, 406)
        GamePanel.TabIndex = 1
        ' 
        ' TimerText
        ' 
        TimerText.AutoSize = True
        TimerText.Location = New Point(12, 31)
        TimerText.Name = "TimerText"
        TimerText.Size = New Size(79, 15)
        TimerText.TabIndex = 11
        TimerText.Text = "Time Elapsed:"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(248, 250)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(112, 82)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 10
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.Location = New Point(130, 250)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(112, 82)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 9
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Location = New Point(12, 250)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(112, 82)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 8
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.BorderStyle = BorderStyle.FixedSingle
        PictureBox6.Location = New Point(248, 162)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(112, 82)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 7
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Location = New Point(130, 162)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(112, 82)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Location = New Point(12, 162)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(112, 82)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Location = New Point(248, 74)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(112, 82)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(130, 74)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(112, 82)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 82)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' CurrentPlayerText
        ' 
        CurrentPlayerText.AutoSize = True
        CurrentPlayerText.Location = New Point(12, 12)
        CurrentPlayerText.Name = "CurrentPlayerText"
        CurrentPlayerText.Size = New Size(88, 15)
        CurrentPlayerText.TabIndex = 1
        CurrentPlayerText.Text = "Current Player: "
        ' 
        ' QuitSessionButton
        ' 
        QuitSessionButton.Location = New Point(688, 12)
        QuitSessionButton.Name = "QuitSessionButton"
        QuitSessionButton.Size = New Size(100, 34)
        QuitSessionButton.TabIndex = 0
        QuitSessionButton.Text = "Quit Game"
        QuitSessionButton.UseVisualStyleBackColor = True
        ' 
        ' GameTimer
        ' 
        ' 
        ' RestartGame
        ' 
        RestartGame.Location = New Point(582, 12)
        RestartGame.Name = "RestartGame"
        RestartGame.Size = New Size(100, 34)
        RestartGame.TabIndex = 12
        RestartGame.Text = "Restart Game"
        RestartGame.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GamePanel)
        Controls.Add(StartPanel)
        Controls.Add(LoadingPanel)
        Name = "Form1"
        Text = "Form1"
        StartPanel.ResumeLayout(False)
        StartPanel.PerformLayout()
        LoadingPanel.ResumeLayout(False)
        LoadingPanel.PerformLayout()
        GamePanel.ResumeLayout(False)
        GamePanel.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents LoadingPanel As Panel
    Friend WithEvents GamePanel As Panel
    Friend WithEvents StartTitle As Label
    Friend WithEvents StartSubtitle As Label
    Friend WithEvents LoadingText As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents QuitSessionButton As Button
    Friend WithEvents CurrentPlayerText As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerText As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents RestartGame As Button

End Class
