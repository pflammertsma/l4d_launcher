Imports System.Net.Sockets
Imports System.Net

Public Class PortConnect

    Dim client As TcpClient = Nothing
    Dim stream As NetworkStream = Nothing

    WithEvents Timeout As System.Timers.Timer

    Public Function Connect(ByRef oPingObject As PingObject, ByVal IP As IPAddress, ByVal nPort As Integer, ByVal nTimeout As Integer) As Boolean
        Dim bSuccess As Boolean
        Try
            client = New System.Net.Sockets.TcpClient()
            Dim IPs() As IPAddress = {IP}
            Timeout = New System.Timers.Timer(nTimeout)
            Timeout.Start()
            client.SendTimeout = nTimeout
            client.NoDelay = True
            client.ReceiveTimeout = nTimeout
            client.LingerState.Enabled = False
            client.Connect(IPs, nPort)
            If client.Connected Then
                stream = client.GetStream()
                stream.ReadTimeout = nTimeout
                stream.WriteTimeout = nTimeout
                If stream.CanRead Then
                    bSuccess = True
                End If
            End If
            Timeout.Start()
            Timeout.Close()
        Catch ex As SocketException
            'Console.WriteLine("Socket exception while connecting to " & IP.ToString & ": " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error connecting to " & IP.ToString & ": " & ex.Message)
        End Try
        Try
            If Not stream Is Nothing Then stream.Close()
            If Not client Is Nothing And Not client.Client Is Nothing Then
                'client.LingerState.Enabled = False
                client.Close()
            End If
            Return bSuccess
        Catch ex As Exception
            Console.WriteLine("Error disconnecting to " & IP.ToString & ": " & ex.Message)
        End Try
    End Function

    Private Sub TimeoutHandler(ByVal source As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timeout.Elapsed
        Try
            If Not client Is Nothing And Not client.Client Is Nothing Then
                client.LingerState.Enabled = False
                client.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("Error forcably disconnecting: " & ex.Message)
        End Try
    End Sub

End Class
