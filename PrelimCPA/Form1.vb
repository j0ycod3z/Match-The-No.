Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports ICSharpCode.SharpZipLib
Imports NPOI.OpenXmlFormats.Vml
Imports NPOI.SS.Formula.Functions

Public Class Form1
    Dim indexx As Integer = 0
    Dim btn(99) As Button
    Dim RanARR(99) As Integer
    Dim st() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
    Dim nd() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
    Dim control As Integer = 0


    Dim countcal As Integer = 0
    Dim primaryscore As Integer = 0
    Dim multiplier As Integer = 1
    Dim all As Integer = 0
    Dim berylast As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        score.Text = primaryscore
        Mult.Text = multiplier
        Dim x As Integer = 10
        Dim y As Integer = 10
        For i = 0 To 99
            btn(i) = New Button
            btn(i).Location = New System.Drawing.Point(x, y)
            btn(i).Size = New System.Drawing.Point(50, 50)
            btn(i).Text = "-"
            btn(i).Name = i
            control = i + 1


            Me.Controls.Add(btn(i))
            Dim test As Integer
            test = control Mod 10
            If test = 0 Then
                y = y + 55
                x = 10
            Else
                x += 55
            End If

        Next



    End Sub

    Dim counter As Integer = 0
    Dim one As Integer = 0
    Dim two As Integer = 0
    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click

        score.Text = 0
        countcal = 0
        multiplier = 1
        Mult.Text = 1

        Shuffle(st)
        Shuffle(nd)
        For i = 0 To 99
            If i <= 49 Then
                RanARR(i) = st(i)

            ElseIf i >= 50 Then
                RanARR(i) = nd(i - 50)
            End If

            btn(i).Text = RanARR(i)
            btn(i).BackColor = Color.Black
            AddHandler btn(i).Click, AddressOf pogi
            btn(i).Enabled = True
        Next

        MainButton.Visible = False
        Button1.Visible = True

    End Sub
    Private random As New Random()

    Public Sub Shuffle(items As Integer())
        Dim j As Int32
        Dim temp As Integer

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = random.Next(0, n + 1)

            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub

    Sub pogi(sender As Object, e As EventArgs)

        Dim butones As Button = sender
        Dim btnIndex As Integer = Convert.ToInt32(butones.Name)
        butones.BackColor = Color.Green

        If counter = 0 Then
            one = btnIndex
            counter += 1
        ElseIf counter = 1 Then
            two = btnIndex
            counter = 0

            If btn(one).Name = btn(two).Name Then
                MessageBox.Show("oh no same button clicked")



            Else
                If btn(one).Text = btn(two).Text Then
                    MessageBox.Show("Yehey")

                    Calculatew()
                    multiplier += 1
                    all += 1
                    btn(one).Enabled = False
                    btn(two).Enabled = False

                ElseIf btn(one).Text <> btn(two).Text Then
                    MessageBox.Show("oh no")
                    btn(one).BackColor = Color.Black
                    btn(two).BackColor = Color.Black
                    multiplier = 1
                    primaryscore = countcal
                    Calculatel()

                End If

            End If
        End If



    End Sub


    Sub Calculatew()


        If all = 0 Then
            countcal = primaryscore + 5

        ElseIf all < 5 Then
            countcal = countcal + (5 * multiplier)

        ElseIf all >= 5 Then


            countcal = countcal + (5 * multiplier)
            multiplier = 4
        End If


        score.Text = countcal


        If multiplier = 5 Then
            Mult.Text = multiplier
        Else
            Mult.Text = multiplier + 1
        End If


    End Sub

    Sub Calculatel()

        multiplier = 1
        Mult.Text = multiplier
        all = 0

    End Sub



    Dim off As Boolean = True
    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click

        If off = True Then

            off = False
            For i = 0 To 99
                btn(i).BackColor = Color.White
            Next
        ElseIf off = False Then
            For i = 0 To 99
                btn(i).BackColor = Color.Black
                off = True
            Next
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub
End Class
