Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class PortConnect

    Private Shared connectionMessage As String = Chr(255) & Chr(255) & Chr(255) & Chr(255) & "TSource Engine Query"

    'Dim client As TcpClient = Nothing
    Dim client As Socket = Nothing
    Dim stream As NetworkStream = Nothing

    WithEvents Timeout As System.Timers.Timer

    Public Shared Sub Test()
        Dim sIP As String = "192.168.0.154"
        Dim nPort As Integer = 27015

        Dim endPoint As New IPEndPoint(IPAddress.Parse(sIP), nPort)

        Dim client As New UdpClient()
        client.Client.ReceiveTimeout = 6000
        client.Send(Encoding.ASCII.GetBytes(connectionMessage), connectionMessage.Length, endPoint)
        Console.WriteLine("Message sent to " & sIP & ":" & nPort & vbCrLf & connectionMessage)
        Dim sBuffer(1400) As Byte
        Try
            sBuffer = client.Receive(endPoint)
            MsgBox(System.Text.Encoding.Unicode.GetString(sBuffer))
        Catch ex As SocketException
            Console.WriteLine("Failed to receive response on " & sIP & ":" & nPort & ":" & vbCrLf & ex.Message)
            MsgBox("Failed to receive response on " & sIP & ":" & nPort & ":" & vbCrLf & ex.Message)
        End Try
        Console.WriteLine(System.Text.Encoding.Unicode.GetString(sBuffer))
        System.Threading.Thread.Sleep(2000)

    End Sub

    Public Shared Sub Test2()
        Dim bBroadcast As Boolean = False
        Dim sIP As String = "192.168.0.154"
        Dim nPort As Integer = 27015

        Dim endPoint As New IPEndPoint(IPAddress.Parse(sIP), nPort)

        Dim client As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
        client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 6000)
        If bBroadcast Then
            sIP = "255.255.255.255"
            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1)
        End If
        client.SendTo(Encoding.ASCII.GetBytes(connectionMessage), endPoint)
        Console.WriteLine("Message sent to " & sIP & ":" & nPort & vbCrLf & connectionMessage)
        Dim sBuffer(1400) As Byte
        Try
            client.ReceiveFrom(sBuffer, endPoint)
            MsgBox(System.Text.Encoding.Unicode.GetString(sBuffer))
        Catch ex As SocketException
            Console.WriteLine("Failed to receive response on " & sIP & ":" & nPort & ":" & vbCrLf & ex.Message)
            MsgBox("Failed to receive response on " & sIP & ":" & nPort & ":" & vbCrLf & ex.Message)
        End Try
        Console.WriteLine(System.Text.Encoding.Unicode.GetString(sBuffer))
        System.Threading.Thread.Sleep(2000)
    End Sub

    Public Function Connect(ByRef oPingObject As PingObject, ByVal IP As IPAddress, ByVal nPort As Integer, ByVal nTimeout As Integer) As Boolean
        Dim bSuccess As Boolean
        Try
            client = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
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
                Dim size As Integer = client.Send(Encoding.ASCII.GetBytes(connectionMessage), connectionMessage.Length, SocketFlags.DontRoute)
                Console.WriteLine("Message sent to " & IPs(0).ToString & ":" & nPort & " (size " & size & ")")
                Dim sBuffer(1400) As Byte
                client.Receive(sBuffer)
                Console.WriteLine(System.Text.Encoding.Unicode.GetString(sBuffer))
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
        stream = Nothing
        client = Nothing
        Return bSuccess
    End Function

    Private Sub TimeoutHandler(ByVal source As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timeout.Elapsed
        Timeout.Stop()
        Timeout.Close()
        Try
            If Not stream Is Nothing Then stream.Close()
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
