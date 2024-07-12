Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create program instance
        Dim pyprog As New Process()
        pyprog.StartInfo.UseShellExecute = False ' Start parameter
        pyprog.StartInfo.WindowStyle = ProcessWindowStyle.Minimized 'Doesnt work, still here
        pyprog.Start("py\python.exe", "rec\Receiver.py") ' Start the python program
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
