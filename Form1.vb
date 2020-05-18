Public Class Form1

    Dim num1 As Double
    Dim num2 As Double
    Dim operation As String
    Dim first As Boolean = True
    Dim rDisplayed As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "1"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "2"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "3"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "4"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "5"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "6"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "9"
    End Sub
    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B9.Click
        If rDisplayed = True Then
            EntryBox.Text = ""
            rDisplayed = False
        End If
        EntryBox.Text = EntryBox.Text & "0"
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, EntryBox.KeyPress, Btimes.KeyPress, Bplus.KeyPress, Bminus.KeyPress, Benter.KeyPress, Bdot.KeyPress, Bdivide.KeyPress, B9.KeyPress, B8.KeyPress, B7.KeyPress, B6.KeyPress, B5.KeyPress, B4.KeyPress, B3.KeyPress, B2.KeyPress, B1.KeyPress, B0.KeyPress, BC.KeyPress
        '48 to 57 are the char codes for "0 to 9" of alphanumeric keypad. 
        'If e.KeyChar = Chr(49) Then EntryBox.Text = EntryBox.Text & "1"
        If IsNumeric(e.KeyChar) = True Then
            If rDisplayed = True Then
                EntryBox.Text = ""
                rDisplayed = False
            End If
            EntryBox.Text = EntryBox.Text & e.KeyChar.ToString
            Exit Sub
        End If

        If e.KeyChar = vbCr Then 'if enter pressed
            If first = False Then
                num2 = Val(EntryBox.Text)
                Calculate()
            End If
        End If

        If e.KeyChar = "." Then 'decimal pressed
            If InStr(EntryBox.Text, ".") = 0 Then EntryBox.Text = EntryBox.Text & "."
        End If

        If e.KeyChar = "/" Or e.KeyChar = "*" Or e.KeyChar = "-" Or e.KeyChar = "+" Then
            operation = e.KeyChar
            first = False
            num1 = Val(EntryBox.Text)
            EntryBox.Text = ""
        End If

    End Sub

    Private Sub Calculate()

        Dim result As Double

        If operation = "/" Then
            result = num1 / num2
        End If

        If operation = "*" Then
            result = num1 * num2
        End If

        If operation = "-" Then
            result = num1 - num2
        End If

        If operation = "+" Then
            result = num1 + num2
        End If


        If num1.ToString.Length > 2 And num2.ToString.Length > 2 Then

            Dim ch1 As String = num1.ToString.Substring(num1.ToString.Length - 1)
            Dim ch2 As String = num2.ToString.Substring(num2.ToString.Length - 1)

            If (ch1 = 7 Or ch1 = 3) And (ch2 = 7 Or ch2 = 3) Then

                If operation = "/" Or operation = "*" Then

                    Dim rando As Integer = CInt(Int((10 * Rnd()) + 1))

                    If rando = 5 Then
                        result = result + Val(ch1)
                    End If

                    If rando = 7 Then
                        result = result + Val(ch2)
                    End If

                End If
            End If

        End If

        EntryBox.Text = result
        rDisplayed = True

    End Sub

    Private Sub Bdot_Click(sender As Object, e As EventArgs) Handles Bdot.Click
        If InStr(EntryBox.Text, ".") = 0 Then EntryBox.Text = EntryBox.Text & "."
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        'clear
        num1 = 0
        num2 = 0
        operation = ""
        first = True
        EntryBox.Text = ""

    End Sub

    Private Sub Benter_Click(sender As Object, e As EventArgs) Handles Benter.Click
        If first = False Then
            num2 = Val(EntryBox.Text)
            Calculate()
        End If
    End Sub

    Private Sub Bplus_Click(sender As Object, e As EventArgs) Handles Bplus.Click
        operation = "+"
        first = False
        num1 = Val(EntryBox.Text)
        EntryBox.Text = ""
    End Sub

    Private Sub Bminus_Click(sender As Object, e As EventArgs) Handles Bminus.Click
        operation = "-"
        first = False
        num1 = Val(EntryBox.Text)
        EntryBox.Text = ""
    End Sub

    Private Sub Btimes_Click(sender As Object, e As EventArgs) Handles Btimes.Click
        operation = "*"
        first = False
        num1 = Val(EntryBox.Text)
        EntryBox.Text = ""
    End Sub

    Private Sub Bdivide_Click(sender As Object, e As EventArgs) Handles Bdivide.Click
        operation = "/"
        first = False
        num1 = Val(EntryBox.Text)
        EntryBox.Text = ""
    End Sub
End Class
