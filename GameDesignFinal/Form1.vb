Public Class mainForm

    Dim player1 As String                   ' Name of player 1
    Dim player2 As String                   ' Name of player 2
    Dim p1turn As Integer                   ' Value of the "who goes first" dice roll of player 1
    Dim p2turn As Integer                   ' Value of the "who goes first" dice roll of player 2
    Dim score As Integer                    ' Current score differental (+ means P1 is winning)
    Dim roll As Integer                     ' Determines the type of roll happening
    ' 1 = P1 WGF roll, 2 = P2 WGF roll, 3 = easy roll, 4 = medium roll, 5 = hard roll
    Dim dice1 As Integer                    ' Value of the first die in a roll
    Dim dice2 As Integer                    ' Value of the second die in a roll
    Dim dice3 As Integer                    ' Value of the third die in a roll
    Dim dice As Integer                     ' Total value of the dice rolled
    ' A dice roll in this game is simply calling rollMax number of random numbers
    Dim rollIt As Integer                   ' The current number of random numbers called
    Dim rollMax As Integer                  ' The maximum number of random numbers called
    Dim turn As Integer                     ' Determines whose turn it is (odd = P1, even = P2).
    Dim first As Integer                    ' Determines who goes/went first (1 or 2)
    Dim questionCount As Integer            ' The number of questions that have been asked in the game
    Dim correct As Integer                  ' Determines which answer should be the correct answer
    Dim wrong As Integer                    ' The number of wrong answers on the current question
    Dim nameOfSet As String                 ' Name of the currently loaded set.
    Dim descOfSet As String                 ' Description of the currently loaded set.
    Dim easyQuestions As New List(Of Question)  ' The list of easy questions
    Dim medQuestions As New List(Of Question)   ' The list of medium questions
    Dim hardQuestions As New List(Of Question)  ' The list of hard questions

    Public Class Question
        Public Property Question As String
        Public Property Answer As String
        Public Property Wrong1 As String
        Public Property Wrong2 As String
        Public Property Wrong3 As String
    End Class

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub reset()
        ' Resets the game, returning it to its default state
        p1turn = 0
        p2turn = 0
        score = 0
        turn = 0
        questionCount = 1
        correct = 0
        player1box.Text = ""
        player2box.Text = ""
        playerPanel.Visible = True
        instructText.Text = "This is a two player game that will test your trivia skills." & vbNewLine & vbNewLine &
        "Now, what are the names of the two players?"
        loadSetPanel.Visible = True
        clearQuestions()

        ' Loads the default question set.
        Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser("../../ElementsOfGameDesign.etqs")
            questionLoad(MyReader)
        End Using

        ' Loads the name and description of the set into the program.
        currentSetLabel.Text = "Name: " & nameOfSet & vbNewLine & "Description: " & descOfSet
    End Sub

    Private Sub clearQuestions()
        ' Empties the list of questions
        easyQuestions.Clear()
        medQuestions.Clear()
        hardQuestions.Clear()
    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        ' Checks to see if there's a file loaded into the game if a custom file was set.
        ' If not, the game does not proceed, and alerts the user.
        If defaultRadio.Checked = False And customSetOpenDialog.FileName = Nothing Then
            MsgBox("Please select a file if you wish to use your own question set.")
            customSetRadio.Checked = False
            defaultRadio.Checked = True
        Else
            loadSetPanel.Visible = False
        End If
    End Sub

    Private Sub customSetRadio_Click(sender As Object, e As EventArgs) Handles customSetRadio.Click
        customSetOpenDialog.ShowDialog()
    End Sub

    Private Sub defaultRadio_CheckedChanged(sender As Object, e As EventArgs) Handles defaultRadio.CheckedChanged
        reset()
    End Sub

    Private Sub customSetOpenDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles customSetOpenDialog.FileOk
        ' Upon a file being loaded into the game, the default set is cleared, and the new one is loaded.
        clearQuestions()
        Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser(customSetOpenDialog.FileName)
            questionLoad(MyReader)
        End Using

        currentSetLabel.Text = "Name: " & nameOfSet & vbNewLine & "Description: " & descOfSet
    End Sub

    Private Sub questionLoad(MyReader As Microsoft.VisualBasic.FileIO.TextFieldParser)
        ' Loads a question set into the game.
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters("~")
        Dim currentRow As String()
        While Not MyReader.EndOfData
            Try
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                For Each currentField In currentRow
                    ' The first line in the file is the name of the set, and the second is the description
                    ' LineNumbers 2 and 3 are used, because when a new row is loaded into currentRow,
                    ' the cursor goes to the next row. So when currentRow has the contents of line 1,
                    ' the cursor is actually on line 2, and so on.
                    If MyReader.LineNumber = 2 Then
                        nameOfSet = currentRow(0)
                    ElseIf MyReader.LineNumber = 3 Then
                        descOfSet = currentRow(0)
                    Else
                        ' Each line with a valid question starts with "@#" followed by the question difficulty
                        ' This loads each question into the proper list. If the line is invalid, the line is skipped.
                        If currentField.StartsWith("@#E") Then
                            easyQuestions.Add(New Question With {
                                              .Question = currentRow(1),
                                              .Answer = currentRow(2),
                                              .Wrong1 = currentRow(3),
                                              .Wrong2 = currentRow(4),
                                              .Wrong3 = currentRow(5)})
                        ElseIf currentField.StartsWith("@#M") Then
                            medQuestions.Add(New Question With {
                                              .Question = currentRow(1),
                                              .Answer = currentRow(2),
                                              .Wrong1 = currentRow(3),
                                              .Wrong2 = currentRow(4),
                                              .Wrong3 = currentRow(5)})
                        ElseIf currentField.StartsWith("@#H") Then
                            hardQuestions.Add(New Question With {
                                              .Question = currentRow(1),
                                              .Answer = currentRow(2),
                                              .Wrong1 = currentRow(3),
                                              .Wrong2 = currentRow(4),
                                              .Wrong3 = currentRow(5)})
                        End If
                    End If
                Next
            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While
    End Sub

    Private Sub OKbox_Click(sender As Object, e As EventArgs) Handles OKbox.Click
        If playerPanel.Visible = True Then
            ' Stops game from proceeding if Player 1 name is blank
            If player1box.Text.Replace(" ", "") = "" Then
                player1box.BackColor = Color.Salmon
                player1 = ""
            Else
                player1box.BackColor = Color.White
                player1 = player1box.Text
                p1dl.Text = player1
            End If

            ' Stops game from proceeding if Player 2 name is blank
            If player2box.Text.Replace(" ", "") = "" Then
                player2box.BackColor = Color.Salmon
                player2 = ""
            Else
                player2box.BackColor = Color.White
                player2 = player2box.Text
                p2dl.Text = player2
            End If

            ' Starts the "Who goes first" phase of the game
            If player1 <> "" And player2 <> "" Then
                playerPanel.Visible = False
                turnPanel.Visible = True
                turnPanel.Left = 27
                turnPanel.Top = 228
                OKbox.Visible = False
                player1dice.Enabled = True
                player2dice.Enabled = True
                player1dice.BackgroundImage = Nothing
                player2dice.BackgroundImage = Nothing
                instructText.Text = "Welcome " & player1 & " and " & player2 & "!" & vbNewLine & vbNewLine &
                "Before we begin playing, let's see who will go first." & vbNewLine & vbNewLine &
                "Each person will roll one die. The highest number will go first."
            End If
            ' Starts going over game instructions
            ' The game advances through the instructions and game based on the text in instructText
        ElseIf turnPanel.Visible = True Then
            turnPanel.Visible = False
            instructText.Text = "It's now time to play the game!" & vbNewLine & vbNewLine &
                "Choose a difficulty rating, and I'll ask you a multiple choice question related to this class." & vbNewLine & vbNewLine &
                "If you get it right, you'll earn some points." & vbNewLine & vbNewLine &
                "If you get it wrong, your opponent will get a chance to steal."
        ElseIf instructText.Text.StartsWith("It's") Then
            instructText.Text = "Anyone who answers a question correctly will get to roll some dice to determine how many points they'll gain." & vbNewLine & vbNewLine &
                "You'll roll one die for an easy question, two dice for a medium question, and three dice for a hard question. One point is awarded for each dot that shows on the dice." & vbNewLine & vbNewLine &
                "In addition, anyone who answers correctly on the first guess, or steals on the first guess, will receive six bonus points." & vbNewLine & vbNewLine &
                "The game ends either when I've asked ten questions, or if someone is leading by so many points, that they can't be caught. Whoever is leading when the game ends is the winner!"
        ElseIf instructText.Text.StartsWith("Anyone") Then
            instructText.Text = "Question " & questionCount & ". " & current(turn) & ", choose a difficulty."
            diffUp()
        ElseIf instructText.Text.StartsWith("Correct!") Then
            questionCount += 1
            Dim max As Integer
            max = (11 - questionCount) * 24
            rollPanel.Visible = False
            ' Runs if 10 questions are asked, or if the leader is head by too many points to be caught.
            If questionCount > 10 Or score > max Or score < (max * -1) Then
                instructText.Text = "The game is over!" & vbNewLine & vbNewLine &
                    ""
                If score > 0 Then
                    instructText.Text = instructText.Text & "With a " & score & " point lead, " & current(1) & " wins!" & vbNewLine & vbNewLine
                ElseIf score < 0 Then
                    instructText.Text = instructText.Text & "With a " & (score * -1) & " point lead, " & current(2) & " wins!" & vbNewLine & vbNewLine
                Else
                    instructText.Text = instructText.Text & "It's a tie!" & vbNewLine & vbNewLine
                End If
                instructText.Text = instructText.Text & "Click OK to reset the game."
                OKbox.Visible = True
            Else
                ' Creates the prompt that awards the points.
                If turn Mod 2 = 1 Then
                    instructText.Text = current(1) & " gets " & pt(dice) & "! "
                Else
                    instructText.Text = current(2) & " gets " & pt(dice) & "! "
                End If
                ' Reminds the players that the trailing player chooses the final four questions.
                If questionCount = 7 Then
                    instructText.Text = instructText.Text & vbNewLine & vbNewLine & "From here on out, whoever is losing will get to pick the difficulty of the question." & vbNewLine & vbNewLine
                End If
                check()
                instructText.Text = instructText.Text & "Question " & questionCount & ". " & current(turn) & ", choose a difficulty."
                diffUp()
            End If
        ElseIf instructText.Text.StartsWith("The game") Then
            reset()
        End If
    End Sub

    Public Function pt(x As Integer)
        ' Makes the word "points" appear as singular if the number of points referenced = 1
        If x = 1 Then
            Return "1 point"
        Else
            Return x & " points"
        End If
    End Function

    Private Sub check()
        ' Checks the score, and reminds the player of the score after question 2.
        If score > 0 Then
            If questionCount > 2 Then
                If turn Mod 2 = 1 Then
                    instructText.Text = instructText.Text & current(1) & " now leads by " & pt(score) & "." & vbNewLine & vbNewLine
                Else
                    instructText.Text = instructText.Text & current(2) & " now trails by " & pt(score) & "." & vbNewLine & vbNewLine
                End If
            End If
        ElseIf score < 0 Then
            If questionCount > 2 Then
                If turn Mod 2 = 1 Then
                    instructText.Text = instructText.Text & current(1) & " now trails by " & pt(score * -1) & "." & vbNewLine & vbNewLine
                Else
                    instructText.Text = instructText.Text & current(2) & " now leads by " & pt(score * -1) & "." & vbNewLine & vbNewLine
                End If
            End If
        Else
            instructText.Text = instructText.Text & "The game is tied!" & vbNewLine & vbNewLine
            If questionCount > 6 Then
                instructText.Text = instructText.Text & "Since we're tied, the player who last answered correctly will get to choose." & vbNewLine & vbNewLine
            End If
        End If

        ' The players take turns choosing during the first six questions
        ' The player who is trailing chooses from question 7 onwards.
        If questionCount > 6 Then
            If score > 0 Then
                turn = 2
            ElseIf score < 0 Then
                turn = 1
            End If
        Else
            turn = ((first + questionCount) Mod 2) + 1
        End If
    End Sub
    Private Sub diffUp()
        ' Places the box that allows users to select the difficulty.
        diffPanel.Visible = True
        diffPanel.Left = 27
        diffPanel.Top = 328
        OKbox.Visible = False
    End Sub

    Private Sub rollAnim_Tick(sender As Object, e As EventArgs) Handles rollAnim.Tick
        If roll = 1 Then 'Player 1 opening roll
            p1turn = GetRandom(1, 6)
            buttonDice(player1dice, p1turn)
        ElseIf roll = 2 Then 'Player 2 opening roll
            p2turn = GetRandom(1, 6)
            buttonDice(player2dice, p2turn)
            ' Roll number from 3 to 5 is the difficulty, with 3 = easy, 4 = medium, and 5 = hard
        ElseIf roll >= 3 Then
            dice1 = GetRandom(1, 6)
            boxDice(dice1pic, dice1)
            If roll >= 4 Then
                dice2 = GetRandom(1, 6)
                boxDice(dice2pic, dice2)
                If roll >= 5 Then
                    dice3 = GetRandom(1, 6)
                    boxDice(dice3pic, dice3)
                End If
            End If
        End If

        rollIt += 1 ' Increments the roll counter by 1

        ' When the maximum number of rolls have been done, then the rolling stops.
        If rollIt > rollMax Then
            rollAnim.Stop()
            ' Determines who goes first.
            If roll = 1 Or roll = 2 Then
                If p1turn <> 0 And p2turn <> 0 Then
                    If p1turn > p2turn Then
                        turn = 1
                        first = 1
                        instructText.Text = current(1) & " will go first!" & vbNewLine & vbNewLine &
                            ""
                        OKbox.Visible = True
                    ElseIf p1turn < p2turn Then
                        turn = 2
                        first = 2
                        instructText.Text = current(2) & " will go first!" & vbNewLine & vbNewLine &
                            ""
                        OKbox.Visible = True
                    Else
                        instructText.Text = "You both rolled a " & p1turn & "!" & vbNewLine & vbNewLine &
                            "Roll again!"
                        player1dice.Enabled = True
                        player2dice.Enabled = True
                        p1turn = 0
                        p2turn = 0
                        player1dice.BackgroundImage = Nothing
                        player2dice.BackgroundImage = Nothing
                    End If
                End If
            Else
                ' Determines how many points will be awarded.
                If roll = 3 Then
                    dice = dice1 + bonus()
                ElseIf roll = 4 Then
                    dice = (dice1 + dice2) + bonus()
                ElseIf roll = 5 Then
                    dice = (dice1 + dice2 + dice3) + bonus()
                End If

                'Apply the result of the dice roll to the score
                If turn Mod 2 = 1 Then
                    score += dice
                Else
                    score -= dice
                End If

                OKbox.Visible = True
            End If
        End If
    End Sub

    Private Function bonus()
        ' If either player answers correctly on their first guess, they get six bonus points.
        If wrong < 2 Then
            Return 6
        Else
            Return 0
        End If
    End Function
    Private Sub rollDice(x As Integer)
        ' Sets the parameters for dice rolling.
        rollIt = 0
        roll = x
        rollMax = GetRandom(13, 19)
        rollAnim.Start()
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' Function that returns a random number in the requested range
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub buttonDice(a As Button, x As Integer)
        ' Determines the dice face that appears as part of the "Who Goes First" roll.
        If x = 1 Then
            a.BackgroundImage = My.Resources.d1
        ElseIf x = 2 Then
            a.BackgroundImage = My.Resources.d2
        ElseIf x = 3 Then
            a.BackgroundImage = My.Resources.d3
        ElseIf x = 4 Then
            a.BackgroundImage = My.Resources.d4
        ElseIf x = 5 Then
            a.BackgroundImage = My.Resources.d5
        ElseIf x = 6 Then
            a.BackgroundImage = My.Resources.d6
        End If
    End Sub

    Private Sub boxDice(a As PictureBox, x As Integer)
        ' Determines the dice face that appears as part of each point scoring roll.
        If x = 1 Then
            a.Image = My.Resources.d1
        ElseIf x = 2 Then
            a.Image = My.Resources.d2
        ElseIf x = 3 Then
            a.Image = My.Resources.d3
        ElseIf x = 4 Then
            a.Image = My.Resources.d4
        ElseIf x = 5 Then
            a.Image = My.Resources.d5
        ElseIf x = 6 Then
            a.Image = My.Resources.d6
        End If
    End Sub

    Private Sub player1dice_Click(sender As Object, e As EventArgs) Handles player1dice.Click
        ' Begins rolling the die for Player 1's "Who Goes First" roll
        rollDice(1)
        player1dice.Enabled = False
    End Sub

    Private Sub player2dice_Click(sender As Object, e As EventArgs) Handles player2dice.Click
        ' Begins rolling the die for Player 2's "Who Goes First" roll
        rollDice(2)
        player2dice.Enabled = False
    End Sub

    Public Function current(x As Integer)
        ' Returns the name of the player requested
        If x Mod 2 = 1 Then
            Return player1
        Else
            Return player2
        End If
    End Function

    Private Sub easyButton_Click(sender As Object, e As EventArgs) Handles easyButton.Click
        ' Loads an easy question
        roll = 3
        diffBox.Text = "Easy Question: " & current(turn) & ", choose your answer!"
        fetch()
    End Sub

    Private Sub mediumButton_Click(sender As Object, e As EventArgs) Handles mediumButton.Click
        ' Loads a medium question
        roll = 4
        diffBox.Text = "Medium Question: " & current(turn) & ", choose your answer!"
        fetch()
    End Sub

    Private Sub hardButton_Click(sender As Object, e As EventArgs) Handles hardButton.Click
        ' Loads a hard question
        roll = 5
        diffBox.Text = "Hard Question: " & current(turn) & ", choose your answer!"
        fetch()
    End Sub

    Public Function diffQ(x As Integer)
        ' Determines the questionList that will be pulled from
        If x = 3 Then
            Return easyQuestions
        ElseIf x = 4 Then
            Return medQuestions
        Else
            Return hardQuestions
        End If
    End Function
    Private Sub fetch()
        Dim qn As Integer
        qn = GetRandom(0, diffQ(roll).Count - 1)
        questionBox.Text = diffQ(roll)(qn).Question
        ' Determines where the correct answer, and the three incorrect answers should appear
        correct = GetRandom(1, 24)
        Select Case correct
            Case 1 To 6
                ' Makes A the correct answer
                choiceA.Text = diffQ(roll)(qn).Answer
                Select Case correct
                    Case 1, 2
                        choiceB.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceC.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 3, 4
                        choiceC.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceB.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 5, 6
                        choiceD.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        End If
                End Select
                correct = 1
            Case 7 To 12
                ' Makes B the correct answer
                choiceB.Text = diffQ(roll)(qn).Answer
                Select Case correct
                    Case 7, 8
                        choiceA.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceC.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 9, 10
                        choiceC.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 11, 12
                        choiceD.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceC.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                End Select
                correct = 2
            Case 13 To 18
                ' Makes C the correct answer
                choiceC.Text = diffQ(roll)(qn).Answer
                Select Case correct
                    Case 13, 14
                        choiceA.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceB.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 15, 16
                        choiceB.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceD.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceD.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 17, 18
                        choiceD.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceB.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                End Select
                correct = 3
            Case 19 To 24
                ' Makes D the correct answer
                choiceD.Text = diffQ(roll)(qn).Answer
                Select Case correct
                    Case 19, 20
                        choiceA.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceC.Text = diffQ(roll)(qn).Wrong2
                            choiceB.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 21, 22
                        choiceB.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceC.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceC.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                    Case 23, 24
                        choiceC.Text = diffQ(roll)(qn).Wrong1
                        If correct Mod 2 = 1 Then
                            choiceA.Text = diffQ(roll)(qn).Wrong2
                            choiceB.Text = diffQ(roll)(qn).Wrong3
                        Else
                            choiceB.Text = diffQ(roll)(qn).Wrong2
                            choiceA.Text = diffQ(roll)(qn).Wrong3
                        End If
                End Select
                correct = 4
        End Select

        ' Removes the question from the list, so it won't come up again in the current game.
        diffQ(roll).RemoveAt(qn)

        ' Prepares the buttons for selection
        wrong = 0
        questPanel.Visible = True
        diffPanel.Visible = False
        choiceA.Enabled = True
        choiceB.Enabled = True
        choiceC.Enabled = True
        choiceD.Enabled = True
        choiceA.BackColor = Color.Gainsboro
        choiceB.BackColor = Color.Gainsboro
        choiceC.BackColor = Color.Gainsboro
        choiceD.BackColor = Color.Gainsboro
    End Sub

    Private Sub wrongAnswer()
        ' If a wrong answer is selected
        turn += 1
        wrong += 1
        diffBox.Text = "Incorrect! " & current(turn) & " can steal!"
    End Sub
    Private Sub choiceA_Click(sender As Object, e As EventArgs) Handles choiceA.Click
        ' If A is selected
        If correct = 1 Then
            grab()
        Else
            choiceA.Enabled = False
            choiceA.BackColor = Color.Salmon
            wrongAnswer()
        End If
    End Sub

    Private Sub choiceB_Click(sender As Object, e As EventArgs) Handles choiceB.Click
        ' If B is selected
        If correct = 2 Then
            grab()
        Else
            choiceB.Enabled = False
            choiceB.BackColor = Color.Salmon
            wrongAnswer()
        End If
    End Sub

    Private Sub choiceC_Click(sender As Object, e As EventArgs) Handles choiceC.Click
        ' If C is selected
        If correct = 3 Then
            grab()
        Else
            choiceC.Enabled = False
            choiceC.BackColor = Color.Salmon
            wrongAnswer()
        End If
    End Sub

    Private Sub choiceD_Click(sender As Object, e As EventArgs) Handles choiceD.Click
        ' If D is selected
        If correct = 4 Then
            grab()
        Else
            choiceD.Enabled = False
            choiceD.BackColor = Color.Salmon
            wrongAnswer()
        End If
    End Sub

    Private Sub grab()
        ' Ends the question/answer phase, and sets up the game to award points.
        questPanel.Visible = False
        instructText.Text = "Correct!" & vbNewLine & vbNewLine
        If wrong = 0 Then
            instructText.Text = instructText.Text & current(turn) & " earns 6 bonus points for getting it on the first try!" & vbNewLine & vbNewLine & "Now roll to see how many more points you will earn!"
        ElseIf wrong = 1 Then
            instructText.Text = instructText.Text & current(turn) & " earns 6 bonus points for stealing it on the first try!" & vbNewLine & vbNewLine & "Now roll to see how many more points you will earn!"
        Else
            instructText.Text = instructText.Text & current(turn) & ", roll to see how many points you will earn."
        End If
        rollPanel.Visible = True
        rollPanel.Left = 27
        rollPanel.Top = 228
        dice1pic.Image = Nothing
        dice2pic.Image = Nothing
        dice3pic.Image = Nothing
        rollDicebox.Visible = True
    End Sub

    Private Sub rollDicebox_Click(sender As Object, e As EventArgs) Handles rollDicebox.Click
        ' Engages the dice rolling for awarding points.
        rollDice(roll)
        rollDicebox.Visible = False
    End Sub
End Class
