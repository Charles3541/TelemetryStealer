Imports System.IO

Public Class Form1
    Private thingy As Timer
    Private rocket As Bitmap
    Private theangle As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.Start("recsilent.exe") ' Create program instance
        rocket = New Bitmap("arrow.png") ' Set the bitmap for the arrow
        rocket.SetResolution(96.0F, 96.0F) ' Get the resolution just right
        thingy.Interval = 55 ' Add a interval to the timer
        AddHandler thingy.Tick, AddressOf Missisipi ' Add the handler
        thingy.Start() ' Start the timer
    End Sub

    Private Sub Missisipi(sender As Object, e As EventArgs)
        Panel1.Refresh()
        theangle = Convert.ToInt32(New StreamReader(New FileStream("rec\8.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)).ReadToEnd())
        Using g As Graphics = Panel1.CreateGraphics()
            g.TranslateTransform(100, 100)
            g.RotateTransform(CSng((0 - theangle + 90)))
            g.DrawImage(rocket, -49, -50)
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' I HAVE NOT SEEN MORE COPY PASTE THAN THIS!!!!!!!!!!!
        ' All this does is set the labels to the values in the text files
        AltLa.Text = New IO.StreamReader(New IO.FileStream("rec\2.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        VelLa.Text = New IO.StreamReader(New IO.FileStream("rec\1.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        ApLa.Text = New IO.StreamReader(New IO.FileStream("rec\3.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd + " - " + New IO.StreamReader(New IO.FileStream("rec\5.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        PeLa.Text = New IO.StreamReader(New IO.FileStream("rec\4.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        PiLa.Text = New IO.StreamReader(New IO.FileStream("rec\8.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd + "°"
        MaLa.Text = New IO.StreamReader(New IO.FileStream("rec\7.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        FuLa.Text = New IO.StreamReader(New IO.FileStream("rec\6.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
    End Sub
End Class
