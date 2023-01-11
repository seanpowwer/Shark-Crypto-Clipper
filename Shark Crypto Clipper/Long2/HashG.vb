Imports System.IO
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text

Public Class HashG
    Public Shared Function Bot()
        Try
            Return HWID()
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    Public Shared Function UserName()
        Try
            Return Environment.UserName
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    Public Shared Function HWID() As String
        Try
            Return GetHashT(String.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, New DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize))
        Catch
            Return "Unknown HWID"
        End Try
    End Function

    Public Shared Function GetHashT(ByVal strToHash As String) As String
        Dim md5Obj As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim bytesToHash As Byte() = Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As StringBuilder = New StringBuilder()
        For Each b As Byte In bytesToHash
            strResult.Append(b.ToString("x2"))
        Next
        Return strResult.ToString().Substring(0, 20).ToUpper()
    End Function
    Function frombase64(ByVal bs64 As String) As Object
        Try
            Return Convert.FromBase64String(bs64)
        Catch ex As Exception
        End Try
    End Function

    Private Shared Function Identifier(ByVal wmiClass As String, ByVal wmiProperty As String) As String
        Try
            Dim result As String = ""
            Dim mc As Management.ManagementClass = New Management.ManagementClass(wmiClass)
            Dim moc As Management.ManagementObjectCollection = mc.GetInstances()
            For Each mo As Management.ManagementObject In moc
                If result = "" Then
                    Try
                        result = mo(wmiProperty).ToString()
                        Exit For
                    Catch
                    End Try
                End If
            Next
            Return result
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    Public Shared Function MD5HASH(ByVal input As String) As String
        Try
            Dim md5 As Security.Cryptography.MD5CryptoServiceProvider = New Security.Cryptography.MD5CryptoServiceProvider()
            Dim temp As Byte() = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
            For i As Integer = 10 To temp.Length - 1
                sb.Append(temp(i).ToString("x2"))
            Next
            Return sb.ToString().ToUpper()
        Catch ex As Exception
            Return "Error"
        End Try
    End Function


End Class
