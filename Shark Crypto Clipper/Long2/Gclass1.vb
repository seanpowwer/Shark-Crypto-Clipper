Public Class Gclass1
    Public Shared Port As Integer
    Public Shared ReadOnly SPL As String = "Agent"
    Public Shared KEY As String

    Public Shared NOTEF As Boolean

    Public Shared Online As New List(Of tlscclient)
    Public Shared Blocked As List(Of String)

    Public Shared Received As Long = 0
    Public Shared Sent As Long = 0

    Public Shared UP As Boolean
    Public Shared FMUP As Boolean
    Public Shared PHP As String


End Class
