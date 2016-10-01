Public Class Form1

    Dim imgGreenCircle As Image = My.Resources.circGreen
    Dim imgRedCircle As Image = My.Resources.circRed

    Dim gameTime As New Stopwatch

    Dim btn1Clicked, btn2Clicked, btn3Clicked, btn4Clicked As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'closes out program
        Me.Close()
    End Sub

    Public Sub btnShow()
        'Resets values if conditions aren't met
        btnTopLeft.Show()
        btnTopRight.Show()
        btnBotLeft.Show()
        btnBotRight.Show()

        btn1Clicked = False
        btn2Clicked = False
        btn3Clicked = False
        btn4Clicked = False
    End Sub

    Public Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        'help information

    End Sub

    Public Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'start the timer
        gameTime.Start()
        btnShow()

        'resets picturebox images
        topLeft.Image = Nothing
        topRight.Image = Nothing
        botLeft.Image = Nothing
        botRight.Image = Nothing

        'Resets Boolean
        btn1Clicked = False
        btn2Clicked = False
        btn3Clicked = False
        btn4Clicked = False

        'generates match possibilities
        Randomize()
        Dim randCase As Integer = CInt(Int((6 * Rnd()) + 1))
        Select Case randCase
            Case 1
                topLeft.Image = imgGreenCircle
                topRight.Image = imgGreenCircle
                botLeft.BackgroundImage = imgRedCircle
                botRight.BackgroundImage = imgRedCircle
            Case 2
                topLeft.Image = imgGreenCircle
                topRight.Image = imgRedCircle
                botLeft.Image = imgGreenCircle
                botRight.Image = imgRedCircle
            Case 3
                topLeft.Image = imgGreenCircle
                topRight.Image = imgRedCircle
                botLeft.Image = imgRedCircle
                botRight.Image = imgGreenCircle
            Case 4
                topLeft.Image = imgRedCircle
                topRight.Image = imgRedCircle
                botLeft.Image = imgGreenCircle
                botRight.Image = imgGreenCircle
            Case 5
                topLeft.Image = imgRedCircle
                topRight.Image = imgGreenCircle
                botLeft.Image = imgRedCircle
                botRight.Image = imgGreenCircle
            Case 6
                topLeft.Image = imgRedCircle
                topRight.Image = imgGreenCircle
                botLeft.Image = imgGreenCircle
                botRight.Image = imgRedCircle
        End Select
    End Sub

    Public Sub btnTopLeft_Click(sender As Object, e As EventArgs) Handles btnTopLeft.Click
        btnTopLeft.Hide()
        btn1Clicked = True
        ProcessClick(1)
    End Sub

    Public Sub btnTopRight_Click(sender As Object, e As EventArgs) Handles btnTopRight.Click
        btnTopRight.Hide()
        btn2Clicked = True
        ProcessClick(2)
    End Sub

    Public Sub btnBotLeft_Click(sender As Object, e As EventArgs) Handles btnBotLeft.Click
        btnBotLeft.Hide()
        btn3Clicked = True
        ProcessClick(3)
    End Sub

    Public Sub btnBotRight_Click(sender As Object, e As EventArgs) Handles btnBotRight.Click
        btnBotRight.Hide()
        btn4Clicked = True
        ProcessClick(4)
    End Sub

    Public Sub ProcessClick(buttonNo As Integer)
        'Button 1 + 2,3,4 clicked
        If btn1Clicked And btn2Clicked And btn3Clicked = False And btn4Clicked = False Then
            If topLeft.Image Is topRight.Image Then
            ElseIf topLeft.Image IsNot topRight.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        If btn1Clicked And btn3Clicked And btn2Clicked = False And btn4Clicked = False Then
            If topLeft.Image Is botLeft.Image Then
                btnTopLeft.Hide()
                btnBotLeft.Hide()
            ElseIf topLeft.Image IsNot botLeft.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        If btn1Clicked And btn4Clicked And btn2Clicked = False And btn3Clicked = False Then
            If topLeft.Image Is botRight.Image Then
                btnTopLeft.Hide()
                btnBotRight.Hide()
            ElseIf topLeft.Image IsNot botRight.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        'Button 2 + 3,4
        If btn2Clicked And btn3Clicked And btn1Clicked = False And btn4Clicked = False Then
            If topRight.Image Is botLeft.Image Then
            ElseIf topRight.Image IsNot botLeft.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        If btn2Clicked And btn4Clicked And btn1Clicked = False And btn4Clicked = False Then
            If topRight.Image Is botRight.Image Then
            ElseIf topRight.Image IsNot botRight.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        'Button 3 + 4
        If btn3Clicked And btn4Clicked And btn1Clicked = False And btn2Clicked = False Then
            If botLeft.Image Is botRight.Image Then
            ElseIf botLeft.Image IsNot botRight.Image Then
                MessageBox.Show("NO MATCH")
                btnShow()
            End If
        End If
        'If all matches have been found
        If btn1Clicked And btn2Clicked And btn3Clicked And btn4Clicked Then
            MessageBox.Show("You've gotten all the matches!!")
            gameTime.Stop()
            MessageBox.Show("      It took you " + gameTime.Elapsed.TotalSeconds.ToString +
                            " seconds to find all matches" + Environment.NewLine +
                            "               Keep trying to lower your time.")
        End If
    End Sub

End Class
