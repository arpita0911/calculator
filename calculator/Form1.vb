
Imports System.Math
Public Class Form1

    Dim count As Integer

    Dim a, b As Integer


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 1

        RichTextBox1.Text = y


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 9
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = "+"

        count = 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 2

        RichTextBox1.Text = y
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 3

        RichTextBox1.Text = y
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 4

        RichTextBox1.Text = y
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 5

        RichTextBox1.Text = y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 6

        RichTextBox1.Text = y
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 7

        RichTextBox1.Text = y
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 8

        RichTextBox1.Text = y
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 9

        RichTextBox1.Text = y
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        On Error Resume Next

        b = RichTextBox1.Text

        If count = 1 Then

            RichTextBox1.Text = a + b

        ElseIf count = 2 Then

            RichTextBox1.Text = a - b

        ElseIf count = 3 Then

            RichTextBox1.Text = a * b

        ElseIf count = 4 Then

            RichTextBox1.Text = a / b

        ElseIf count = 5 Then

            RichTextBox1.Text = Log(a)

        ElseIf count = 6 Then

            RichTextBox1.Text = Sin(a)

        ElseIf count = 7 Then

            RichTextBox1.Text = Cos(a)

        ElseIf count = 8 Then

            RichTextBox1.Text = Sin(a) / Cos(a)

        ElseIf count = 9 Then

            RichTextBox1.Text = Sqrt(a)

        ElseIf count = 10 Then

            RichTextBox1.Text = Exp(a)


        ElseIf count = 11 Then

            RichTextBox1.Text = 1 / Sin(a)


        ElseIf count = 12 Then

            RichTextBox1.Text = 1 / Cos(a)


        ElseIf count = 13 Then

            RichTextBox1.Text = Cos(a) / Sin(a)


        ElseIf count = 14 Then

            RichTextBox1.Text = Abs(a / b)


        ElseIf count = 15 Then

            RichTextBox1.Text = a * a

        ElseIf count = 16 Then

            RichTextBox1.Text = ""


        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = "-"

        count = 2
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = "*"

        count = 3
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = "/"

        count = 4
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 5
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 6
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 7
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 8
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 10
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 11
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 12
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 13
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 14
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        On Error Resume Next

        a = RichTextBox1.Text

        RichTextBox1.Text = ""

        count = 15
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        On Error Resume Next

        RichTextBox1.Text = ""


        a = 0
        b = 0
        count = 16

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        On Error Resume Next

        Dim x, y As Integer

        x = RichTextBox1.Text

        y = x * 10 + 0

        RichTextBox1.Text = y
    End Sub
End Class
