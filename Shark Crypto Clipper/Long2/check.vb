Imports System.Security.Cryptography
Public Class check
    Public Shared Function AES_Encrypt(ByVal cc As String, ByVal idd As String) As Boolean
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(SBxx(idd.Split("_")(1) + idd.Split("_")(1) + "♞"))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = SBxx(idd)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            If encrypted = cc Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function SBxx(ByVal s As String) As Byte()
        Return System.Text.Encoding.UTF8.GetBytes(s)
    End Function
End Class
