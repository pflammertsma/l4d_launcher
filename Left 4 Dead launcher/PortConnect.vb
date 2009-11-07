Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class PortConnect

    'Dim client As TcpClient = Nothing
    Dim client As Socket = Nothing
    Dim stream As NetworkStream = Nothing

    WithEvents Timeout As System.Timers.Timer

    Public Function Connect(ByRef oPingObject As PingObject, ByVal IP As IPAddress, ByVal nPort As Integer, ByVal nTimeout As Integer) As Boolean
        Dim bSuccess As Boolean
        Try
            'client = New System.Net.Sockets.TcpClient()
            'client = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            client = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim IPs() As IPAddress = {IP}
            Timeout = New System.Timers.Timer(nTimeout)
            Timeout.Start()
            client.SendTimeout = nTimeout
            If client.ProtocolType = ProtocolType.Tcp Then
                client.NoDelay = True
                client.LingerState.Enabled = False
            End If
            client.ReceiveTimeout = nTimeout
            client.Connect(IPs, nPort)
            If client.Connected Then
                Console.WriteLine(IP.ToString & ":" & nPort & " -> " & client.Send(Encoding.ASCII.GetBytes("connect")))
                Dim sBuffer(10) As Byte
                client.Receive(sBuffer)
                Console.WriteLine(sBuffer)
                'stream = client.GetStream()
                'stream.ReadTimeout = nTimeout
                'stream.WriteTimeout = nTimeout
                'If stream.CanRead Then
                bSuccess = True
                'End If
            End If
            Timeout.Stop()
            Timeout.Close()
        Catch ex As SocketException
            If ex.SocketErrorCode = SocketError.ConnectionRefused Then
                ' Something responded!
                bSuccess = True
            ElseIf ex.SocketErrorCode <> SocketError.NotSocket Then
                ' We're expecting a NotSocket exception; inform of other errors
                Console.WriteLine("Socket exception while connecting to " & IP.ToString & ":" & nPort & ". " & ex.Message & " (" & ex.SocketErrorCode & ")")
            End If
        Catch ex As Exception
            Console.WriteLine("Error connecting to " & IP.ToString & ":" & nPort & ". " & ex.Message)
        End Try
        Try
            If Not stream Is Nothing Then stream.Close()
            If Not client Is Nothing And client.Connected Then
                If client.ProtocolType = ProtocolType.Tcp Then
                    client.LingerState.Enabled = False
                End If
                client.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("Error disconnecting to " & IP.ToString & ": " & ex.Message)
        End Try
        Return bSuccess
    End Function

    Private Sub TimeoutHandler(ByVal source As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timeout.Elapsed
        Timeout.Stop()
        Timeout.Close()
        Try
            If Not client Is Nothing Then
                If client.ProtocolType = ProtocolType.Tcp Then
                    client.LingerState.Enabled = False
                End If
                'If client.Connected Then
                client.Close()
                'End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error forcably disconnecting: " & ex.Message)
        End Try
    End Sub

End Class
