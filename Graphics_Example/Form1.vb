Public Class Graphics
    Dim playerPosX As Integer
    Dim playerPosY As Integer
    Dim grid = (30, 30)
    Dim randyPos
    Private Sub Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Label1.Text = "Press the SpaceBar to Start"
        If Keys.Space = True Then
            Start()
        End If
    End Sub
    Sub Start() Handles Button1.Click
        playerPosX = 0
        playerPosY = 0
        Button1.Hide()
        GroupBox1.Show()
        Label1.Text = "Randy's Quest"
        ' My.Computer.Audio.Play("laugh.wav", AudioPlayMode.WaitToComplete)

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        TextBox1.Text = playerPosX
        TextBox2.Text = playerPosY
        randyPos = (playerPosX, playerPosY)

        If keyData = Keys.W And Not Keys.A And Not Keys.D Then
            playerPosY += 1
            Return True
        End If
        'detect down arrow key
        If keyData = Keys.S And Not Keys.A And Not Keys.D Then
            playerPosY -= 1
            Return True
        End If
        'detect left arrow key
        If keyData = Keys.A Then
            playerPosX -= 1
            Return True
        End If
        'detect right arrow key
        If keyData = Keys.D Then
            playerPosX += 1
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



End Class