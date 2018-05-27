Public Class Form1

    Dim work As New Process()
    Dim work2 As New Process()

    'cpu start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CPUMine.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CPUMine.DoWork

        Dim pool_address As String = TextBox1.Text
        Dim wallet As String = TextBox2.Text

        Dim oStartInfo As New ProcessStartInfo("cpuminer\cpuminer.exe",
                                       "-a x17" + " -o " + pool_address + " -u " + wallet + " -p c=XVG")

        work.StartInfo = oStartInfo
        work.Start()
    End Sub

    'gpu start
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GPUMine.RunWorkerAsync()
    End Sub

    'gpu stop
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GPUMine.CancelAsync()
    End Sub

    'cpu stop
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CPUMine.CancelAsync()
    End Sub

    Private Sub GPUMine_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles GPUMine.DoWork
        Dim pool_address As String = TextBox4.Text
        Dim wallet As String = TextBox3.Text

        Dim oStartInfo As New ProcessStartInfo("gpuminer\ccminer.exe",
                                       "-a x17" + " -o " + pool_address + " -u " + wallet + " -p c=XVG")

        work2.StartInfo = oStartInfo
        work2.Start()
    End Sub
End Class
