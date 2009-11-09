Imports System.IO

Public Class VPKParser

    Private FileName As String
    Private Maps As Collection

    Private Const nVPKSignature As Long = 1437209140
    Private Progress As ProgressBar
    Private DirectoryStart As Long

    Public Sub Parse(ByVal Directory As String, ByVal FileName As String, ByRef Maps As Collection, ByRef Progress As ProgressBar)
        Dim stream As FileStream = File.OpenRead(Directory & FileName)
        Dim reader As New BinaryReader(stream)
        Dim signature As Long = reader.ReadUInt32
        Me.FileName = FileName
        Me.Maps = Maps
        Me.Progress = Progress
        If signature = nVPKSignature Then
            Dim version As Long = reader.ReadUInt32
            Console.WriteLine("VPK file version " & version)
            Dim directoryLength As Long = reader.ReadUInt32
            Console.WriteLine("Directory length: " & directoryLength)
            Progress.Style = ProgressBarStyle.Blocks
            Progress.Maximum = directoryLength
        Else
            Progress.Style = ProgressBarStyle.Continuous
            ' the signature byte is likely part of the directory string
            ' Close and reopen file
            reader.Close()
            stream.Close()
            stream = File.OpenRead(FileName)
            reader = New BinaryReader(stream)
        End If
        ParseVPKDirectory(stream, reader)
        reader.Close()
        stream.Close()
    End Sub

    Public Sub ParseVPKDirectory(ByRef stream As FileStream, ByRef reader As BinaryReader)
        DirectoryStart = stream.Position
        While True
            Dim extension As String = ParseVPKString(reader)
            If extension = "" Then Exit While
            While True
                Dim path As String = ParseVPKString(reader)
                If path = "" Then Exit While
                While True
                    Dim file As String = ParseVPKString(reader)
                    If file = "" Then Exit While
                    ParseVPKFile(stream, reader, path, file, extension)
                End While
            End While
        End While
    End Sub

    Public Function ParseVPKString(ByRef reader As BinaryReader) As String
        Dim result As String = ""
        While True
            Dim thisChar As Char = reader.ReadChar
            If thisChar = Chr(0) Then Exit While
            result &= thisChar
        End While
        Return result
    End Function

    Public Sub ParseVPKFile(ByRef stream As FileStream, ByRef reader As BinaryReader, ByVal path As String, ByVal file As String, ByVal extension As String)
        Dim CRC As Long = reader.ReadUInt32
        Dim PreloadBytes As Integer = reader.ReadUInt16
        Dim ArchiveIndex As Integer = reader.ReadUInt16
        Dim EntryOffset As Long = reader.ReadUInt32
        Dim EntryLength As Long = reader.ReadUInt32
        Dim Terminator As Integer = reader.ReadUInt16
        'MsgBox(path & "/" & file & "." & extension & vbCrLf & PreloadBytes & " preload bytes" & vbCrLf & EntryLength & " bytes")
        'Console.WriteLine(path & "/" & file & "." & extension)
        If extension = "bsp" Then
            Dim oMap As New Map(file & "." & extension, FileName)
            Maps.Add(oMap)
        End If
        For i = 1 To PreloadBytes
            ' Read and dispose of the preload bytes
            reader.ReadByte()
        Next
        System.Threading.Thread.Sleep(10)
        If Progress.Style = ProgressBarStyle.Blocks Then
            Progress.Value = stream.Position - DirectoryStart
        End If
    End Sub

End Class
