<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.choiceA = New System.Windows.Forms.Button()
        Me.questionBox = New System.Windows.Forms.Label()
        Me.questPanel = New System.Windows.Forms.Panel()
        Me.diffBox = New System.Windows.Forms.Label()
        Me.choiceD = New System.Windows.Forms.Button()
        Me.choiceC = New System.Windows.Forms.Button()
        Me.choiceB = New System.Windows.Forms.Button()
        Me.startPanel = New System.Windows.Forms.Panel()
        Me.diffPanel = New System.Windows.Forms.Panel()
        Me.hardButton = New System.Windows.Forms.Button()
        Me.mediumButton = New System.Windows.Forms.Button()
        Me.easyButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.turnPanel = New System.Windows.Forms.Panel()
        Me.player2dice = New System.Windows.Forms.Button()
        Me.player1dice = New System.Windows.Forms.Button()
        Me.p2dl = New System.Windows.Forms.Label()
        Me.p1dl = New System.Windows.Forms.Label()
        Me.playerPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.player1box = New System.Windows.Forms.TextBox()
        Me.player2box = New System.Windows.Forms.TextBox()
        Me.OKbox = New System.Windows.Forms.Button()
        Me.instructText = New System.Windows.Forms.Label()
        Me.rollPanel = New System.Windows.Forms.Panel()
        Me.dice3pic = New System.Windows.Forms.PictureBox()
        Me.dice2pic = New System.Windows.Forms.PictureBox()
        Me.dice1pic = New System.Windows.Forms.PictureBox()
        Me.rollDicebox = New System.Windows.Forms.Button()
        Me.rollAnim = New System.Windows.Forms.Timer(Me.components)
        Me.loadSetPanel = New System.Windows.Forms.Panel()
        Me.optionsBox = New System.Windows.Forms.GroupBox()
        Me.defaultRadio = New System.Windows.Forms.RadioButton()
        Me.customSetRadio = New System.Windows.Forms.RadioButton()
        Me.playButton = New System.Windows.Forms.Button()
        Me.currentSetLabel = New System.Windows.Forms.Label()
        Me.splashLabel = New System.Windows.Forms.Label()
        Me.customSetOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.questPanel.SuspendLayout()
        Me.startPanel.SuspendLayout()
        Me.diffPanel.SuspendLayout()
        Me.turnPanel.SuspendLayout()
        Me.playerPanel.SuspendLayout()
        Me.rollPanel.SuspendLayout()
        CType(Me.dice3pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dice2pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dice1pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loadSetPanel.SuspendLayout()
        Me.optionsBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'choiceA
        '
        Me.choiceA.BackColor = System.Drawing.Color.Gainsboro
        Me.choiceA.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choiceA.Location = New System.Drawing.Point(442, 67)
        Me.choiceA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.choiceA.Name = "choiceA"
        Me.choiceA.Size = New System.Drawing.Size(300, 90)
        Me.choiceA.TabIndex = 0
        Me.choiceA.Text = "A"
        Me.choiceA.UseVisualStyleBackColor = False
        '
        'questionBox
        '
        Me.questionBox.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionBox.Location = New System.Drawing.Point(6, 67)
        Me.questionBox.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.questionBox.Name = "questionBox"
        Me.questionBox.Size = New System.Drawing.Size(425, 389)
        Me.questionBox.TabIndex = 1
        Me.questionBox.Text = "Question"
        '
        'questPanel
        '
        Me.questPanel.Controls.Add(Me.diffBox)
        Me.questPanel.Controls.Add(Me.choiceD)
        Me.questPanel.Controls.Add(Me.choiceC)
        Me.questPanel.Controls.Add(Me.choiceB)
        Me.questPanel.Controls.Add(Me.choiceA)
        Me.questPanel.Controls.Add(Me.questionBox)
        Me.questPanel.Location = New System.Drawing.Point(12, 12)
        Me.questPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.questPanel.Name = "questPanel"
        Me.questPanel.Size = New System.Drawing.Size(748, 527)
        Me.questPanel.TabIndex = 2
        Me.questPanel.Visible = False
        '
        'diffBox
        '
        Me.diffBox.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diffBox.Location = New System.Drawing.Point(6, 7)
        Me.diffBox.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.diffBox.Name = "diffBox"
        Me.diffBox.Size = New System.Drawing.Size(734, 55)
        Me.diffBox.TabIndex = 5
        Me.diffBox.Text = "Difficulty"
        Me.diffBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'choiceD
        '
        Me.choiceD.BackColor = System.Drawing.Color.Gainsboro
        Me.choiceD.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choiceD.Location = New System.Drawing.Point(443, 366)
        Me.choiceD.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.choiceD.Name = "choiceD"
        Me.choiceD.Size = New System.Drawing.Size(300, 90)
        Me.choiceD.TabIndex = 4
        Me.choiceD.Text = "D"
        Me.choiceD.UseVisualStyleBackColor = False
        '
        'choiceC
        '
        Me.choiceC.BackColor = System.Drawing.Color.Gainsboro
        Me.choiceC.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choiceC.Location = New System.Drawing.Point(443, 266)
        Me.choiceC.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.choiceC.Name = "choiceC"
        Me.choiceC.Size = New System.Drawing.Size(300, 90)
        Me.choiceC.TabIndex = 3
        Me.choiceC.Text = "C"
        Me.choiceC.UseVisualStyleBackColor = False
        '
        'choiceB
        '
        Me.choiceB.BackColor = System.Drawing.Color.Gainsboro
        Me.choiceB.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choiceB.Location = New System.Drawing.Point(442, 166)
        Me.choiceB.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.choiceB.Name = "choiceB"
        Me.choiceB.Size = New System.Drawing.Size(300, 90)
        Me.choiceB.TabIndex = 2
        Me.choiceB.Text = "B"
        Me.choiceB.UseVisualStyleBackColor = False
        '
        'startPanel
        '
        Me.startPanel.Controls.Add(Me.diffPanel)
        Me.startPanel.Controls.Add(Me.turnPanel)
        Me.startPanel.Controls.Add(Me.playerPanel)
        Me.startPanel.Controls.Add(Me.OKbox)
        Me.startPanel.Controls.Add(Me.instructText)
        Me.startPanel.Location = New System.Drawing.Point(6, 7)
        Me.startPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.startPanel.Name = "startPanel"
        Me.startPanel.Size = New System.Drawing.Size(748, 532)
        Me.startPanel.TabIndex = 6
        '
        'diffPanel
        '
        Me.diffPanel.Controls.Add(Me.hardButton)
        Me.diffPanel.Controls.Add(Me.mediumButton)
        Me.diffPanel.Controls.Add(Me.easyButton)
        Me.diffPanel.Controls.Add(Me.Label6)
        Me.diffPanel.Controls.Add(Me.Label7)
        Me.diffPanel.Controls.Add(Me.Label8)
        Me.diffPanel.Location = New System.Drawing.Point(85, 123)
        Me.diffPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.diffPanel.Name = "diffPanel"
        Me.diffPanel.Size = New System.Drawing.Size(676, 126)
        Me.diffPanel.TabIndex = 12
        Me.diffPanel.Visible = False
        '
        'hardButton
        '
        Me.hardButton.BackgroundImage = Global.GameDesignFinal.My.Resources.Resources.d3
        Me.hardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.hardButton.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardButton.Location = New System.Drawing.Point(530, 38)
        Me.hardButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.hardButton.Name = "hardButton"
        Me.hardButton.Size = New System.Drawing.Size(75, 75)
        Me.hardButton.TabIndex = 11
        Me.hardButton.UseVisualStyleBackColor = True
        '
        'mediumButton
        '
        Me.mediumButton.BackgroundImage = Global.GameDesignFinal.My.Resources.Resources.d2
        Me.mediumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mediumButton.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumButton.Location = New System.Drawing.Point(301, 38)
        Me.mediumButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.mediumButton.Name = "mediumButton"
        Me.mediumButton.Size = New System.Drawing.Size(75, 75)
        Me.mediumButton.TabIndex = 10
        Me.mediumButton.UseVisualStyleBackColor = True
        '
        'easyButton
        '
        Me.easyButton.BackgroundImage = Global.GameDesignFinal.My.Resources.Resources.d1
        Me.easyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.easyButton.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.easyButton.Location = New System.Drawing.Point(76, 38)
        Me.easyButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.easyButton.Name = "easyButton"
        Me.easyButton.Size = New System.Drawing.Size(75, 75)
        Me.easyButton.TabIndex = 9
        Me.easyButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(535, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Medium"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 4)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Easy"
        '
        'turnPanel
        '
        Me.turnPanel.Controls.Add(Me.player2dice)
        Me.turnPanel.Controls.Add(Me.player1dice)
        Me.turnPanel.Controls.Add(Me.p2dl)
        Me.turnPanel.Controls.Add(Me.p1dl)
        Me.turnPanel.Location = New System.Drawing.Point(122, 72)
        Me.turnPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.turnPanel.Name = "turnPanel"
        Me.turnPanel.Size = New System.Drawing.Size(676, 126)
        Me.turnPanel.TabIndex = 12
        Me.turnPanel.Visible = False
        '
        'player2dice
        '
        Me.player2dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.player2dice.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2dice.Location = New System.Drawing.Point(530, 38)
        Me.player2dice.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.player2dice.Name = "player2dice"
        Me.player2dice.Size = New System.Drawing.Size(75, 75)
        Me.player2dice.TabIndex = 11
        Me.player2dice.UseVisualStyleBackColor = True
        '
        'player1dice
        '
        Me.player1dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.player1dice.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1dice.Location = New System.Drawing.Point(76, 38)
        Me.player1dice.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.player1dice.Name = "player1dice"
        Me.player1dice.Size = New System.Drawing.Size(75, 75)
        Me.player1dice.TabIndex = 9
        Me.player1dice.UseVisualStyleBackColor = True
        '
        'p2dl
        '
        Me.p2dl.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2dl.Location = New System.Drawing.Point(461, 4)
        Me.p2dl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.p2dl.Name = "p2dl"
        Me.p2dl.Size = New System.Drawing.Size(219, 29)
        Me.p2dl.TabIndex = 7
        Me.p2dl.Text = "[2]"
        Me.p2dl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'p1dl
        '
        Me.p1dl.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1dl.Location = New System.Drawing.Point(6, 4)
        Me.p1dl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.p1dl.Name = "p1dl"
        Me.p1dl.Size = New System.Drawing.Size(219, 29)
        Me.p1dl.TabIndex = 5
        Me.p1dl.Text = "[1]"
        Me.p1dl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'playerPanel
        '
        Me.playerPanel.Controls.Add(Me.Label1)
        Me.playerPanel.Controls.Add(Me.Label2)
        Me.playerPanel.Controls.Add(Me.player1box)
        Me.playerPanel.Controls.Add(Me.player2box)
        Me.playerPanel.Location = New System.Drawing.Point(27, 228)
        Me.playerPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.playerPanel.Name = "playerPanel"
        Me.playerPanel.Size = New System.Drawing.Size(676, 126)
        Me.playerPanel.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Player 2"
        '
        'player1box
        '
        Me.player1box.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1box.Location = New System.Drawing.Point(42, 60)
        Me.player1box.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.player1box.MaxLength = 14
        Me.player1box.Name = "player1box"
        Me.player1box.Size = New System.Drawing.Size(206, 35)
        Me.player1box.TabIndex = 3
        '
        'player2box
        '
        Me.player2box.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2box.Location = New System.Drawing.Point(447, 60)
        Me.player2box.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.player2box.MaxLength = 14
        Me.player2box.Name = "player2box"
        Me.player2box.Size = New System.Drawing.Size(206, 35)
        Me.player2box.TabIndex = 5
        '
        'OKbox
        '
        Me.OKbox.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKbox.Location = New System.Drawing.Point(218, 441)
        Me.OKbox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.OKbox.Name = "OKbox"
        Me.OKbox.Size = New System.Drawing.Size(341, 71)
        Me.OKbox.TabIndex = 2
        Me.OKbox.Text = "OK!"
        Me.OKbox.UseVisualStyleBackColor = True
        '
        'instructText
        '
        Me.instructText.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructText.Location = New System.Drawing.Point(12, 12)
        Me.instructText.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.instructText.Name = "instructText"
        Me.instructText.Size = New System.Drawing.Size(719, 424)
        Me.instructText.TabIndex = 1
        '
        'rollPanel
        '
        Me.rollPanel.Controls.Add(Me.dice3pic)
        Me.rollPanel.Controls.Add(Me.dice2pic)
        Me.rollPanel.Controls.Add(Me.dice1pic)
        Me.rollPanel.Controls.Add(Me.rollDicebox)
        Me.rollPanel.Location = New System.Drawing.Point(6, 3)
        Me.rollPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.rollPanel.Name = "rollPanel"
        Me.rollPanel.Size = New System.Drawing.Size(676, 126)
        Me.rollPanel.TabIndex = 8
        Me.rollPanel.Visible = False
        '
        'dice3pic
        '
        Me.dice3pic.Location = New System.Drawing.Point(370, 22)
        Me.dice3pic.Name = "dice3pic"
        Me.dice3pic.Size = New System.Drawing.Size(87, 87)
        Me.dice3pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dice3pic.TabIndex = 3
        Me.dice3pic.TabStop = False
        '
        'dice2pic
        '
        Me.dice2pic.Location = New System.Drawing.Point(223, 22)
        Me.dice2pic.Name = "dice2pic"
        Me.dice2pic.Size = New System.Drawing.Size(87, 87)
        Me.dice2pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dice2pic.TabIndex = 2
        Me.dice2pic.TabStop = False
        '
        'dice1pic
        '
        Me.dice1pic.Location = New System.Drawing.Point(67, 22)
        Me.dice1pic.Name = "dice1pic"
        Me.dice1pic.Size = New System.Drawing.Size(87, 87)
        Me.dice1pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dice1pic.TabIndex = 1
        Me.dice1pic.TabStop = False
        '
        'rollDicebox
        '
        Me.rollDicebox.Location = New System.Drawing.Point(521, 40)
        Me.rollDicebox.Name = "rollDicebox"
        Me.rollDicebox.Size = New System.Drawing.Size(131, 53)
        Me.rollDicebox.TabIndex = 0
        Me.rollDicebox.Text = "Roll"
        Me.rollDicebox.UseVisualStyleBackColor = True
        '
        'rollAnim
        '
        Me.rollAnim.Interval = 50
        '
        'loadSetPanel
        '
        Me.loadSetPanel.Controls.Add(Me.optionsBox)
        Me.loadSetPanel.Controls.Add(Me.playButton)
        Me.loadSetPanel.Controls.Add(Me.currentSetLabel)
        Me.loadSetPanel.Controls.Add(Me.splashLabel)
        Me.loadSetPanel.Location = New System.Drawing.Point(5, 3)
        Me.loadSetPanel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.loadSetPanel.Name = "loadSetPanel"
        Me.loadSetPanel.Size = New System.Drawing.Size(755, 536)
        Me.loadSetPanel.TabIndex = 13
        Me.loadSetPanel.Visible = False
        '
        'optionsBox
        '
        Me.optionsBox.Controls.Add(Me.defaultRadio)
        Me.optionsBox.Controls.Add(Me.customSetRadio)
        Me.optionsBox.Location = New System.Drawing.Point(26, 335)
        Me.optionsBox.Name = "optionsBox"
        Me.optionsBox.Size = New System.Drawing.Size(200, 100)
        Me.optionsBox.TabIndex = 11
        Me.optionsBox.TabStop = False
        Me.optionsBox.Text = "Select questions"
        '
        'defaultRadio
        '
        Me.defaultRadio.AutoSize = True
        Me.defaultRadio.Checked = True
        Me.defaultRadio.Location = New System.Drawing.Point(16, 27)
        Me.defaultRadio.Name = "defaultRadio"
        Me.defaultRadio.Size = New System.Drawing.Size(110, 33)
        Me.defaultRadio.TabIndex = 9
        Me.defaultRadio.TabStop = True
        Me.defaultRadio.Text = "Default"
        Me.defaultRadio.UseVisualStyleBackColor = True
        '
        'customSetRadio
        '
        Me.customSetRadio.AutoSize = True
        Me.customSetRadio.Location = New System.Drawing.Point(16, 60)
        Me.customSetRadio.Name = "customSetRadio"
        Me.customSetRadio.Size = New System.Drawing.Size(192, 33)
        Me.customSetRadio.TabIndex = 10
        Me.customSetRadio.Text = "Load your own"
        Me.customSetRadio.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(531, 362)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(136, 57)
        Me.playButton.TabIndex = 8
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'currentSetLabel
        '
        Me.currentSetLabel.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentSetLabel.Location = New System.Drawing.Point(10, 171)
        Me.currentSetLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentSetLabel.Name = "currentSetLabel"
        Me.currentSetLabel.Size = New System.Drawing.Size(734, 137)
        Me.currentSetLabel.TabIndex = 7
        Me.currentSetLabel.Text = "Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description:"
        '
        'splashLabel
        '
        Me.splashLabel.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splashLabel.Location = New System.Drawing.Point(9, 9)
        Me.splashLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.splashLabel.Name = "splashLabel"
        Me.splashLabel.Size = New System.Drawing.Size(734, 137)
        Me.splashLabel.TabIndex = 6
        Me.splashLabel.Text = "Welcome to Elements of Trivia!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before we begin, would you like to use the defa" & _
    "ult set of questions? Or would you like to load your own?"
        '
        'customSetOpenDialog
        '
        Me.customSetOpenDialog.DefaultExt = "etqs"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.loadSetPanel)
        Me.Controls.Add(Me.rollPanel)
        Me.Controls.Add(Me.questPanel)
        Me.Controls.Add(Me.startPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "mainForm"
        Me.Text = "Elements of Trivia"
        Me.questPanel.ResumeLayout(False)
        Me.startPanel.ResumeLayout(False)
        Me.diffPanel.ResumeLayout(False)
        Me.diffPanel.PerformLayout()
        Me.turnPanel.ResumeLayout(False)
        Me.playerPanel.ResumeLayout(False)
        Me.playerPanel.PerformLayout()
        Me.rollPanel.ResumeLayout(False)
        CType(Me.dice3pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dice2pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dice1pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loadSetPanel.ResumeLayout(False)
        Me.optionsBox.ResumeLayout(False)
        Me.optionsBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents choiceA As System.Windows.Forms.Button
    Friend WithEvents questionBox As System.Windows.Forms.Label
    Friend WithEvents questPanel As System.Windows.Forms.Panel
    Friend WithEvents diffBox As System.Windows.Forms.Label
    Friend WithEvents choiceD As System.Windows.Forms.Button
    Friend WithEvents choiceC As System.Windows.Forms.Button
    Friend WithEvents choiceB As System.Windows.Forms.Button
    Friend WithEvents startPanel As System.Windows.Forms.Panel
    Friend WithEvents playerPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents player1box As System.Windows.Forms.TextBox
    Friend WithEvents player2box As System.Windows.Forms.TextBox
    Friend WithEvents OKbox As System.Windows.Forms.Button
    Friend WithEvents instructText As System.Windows.Forms.Label
    Friend WithEvents rollPanel As System.Windows.Forms.Panel
    Friend WithEvents turnPanel As System.Windows.Forms.Panel
    Friend WithEvents player2dice As System.Windows.Forms.Button
    Friend WithEvents player1dice As System.Windows.Forms.Button
    Friend WithEvents p2dl As System.Windows.Forms.Label
    Friend WithEvents p1dl As System.Windows.Forms.Label
    Friend WithEvents diffPanel As System.Windows.Forms.Panel
    Friend WithEvents hardButton As System.Windows.Forms.Button
    Friend WithEvents mediumButton As System.Windows.Forms.Button
    Friend WithEvents easyButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dice3pic As System.Windows.Forms.PictureBox
    Friend WithEvents dice2pic As System.Windows.Forms.PictureBox
    Friend WithEvents dice1pic As System.Windows.Forms.PictureBox
    Friend WithEvents rollAnim As System.Windows.Forms.Timer
    Friend WithEvents rollDicebox As System.Windows.Forms.Button
    Friend WithEvents loadSetPanel As System.Windows.Forms.Panel
    Friend WithEvents splashLabel As System.Windows.Forms.Label
    Friend WithEvents customSetOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents optionsBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultRadio As System.Windows.Forms.RadioButton
    Friend WithEvents customSetRadio As System.Windows.Forms.RadioButton
    Friend WithEvents playButton As System.Windows.Forms.Button
    Friend WithEvents currentSetLabel As System.Windows.Forms.Label

End Class
