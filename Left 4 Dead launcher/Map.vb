Public Class Map
    Public Name As String
    Public AddOn As String = Nothing
    Public IsCoop As Boolean
    Public IsVersus As Boolean
    Public IsSurival As Boolean

    Public Sub New(ByVal Name As String, Optional ByVal AddOn As String = Nothing)
        Me.Name = Name
        Me.AddOn = AddOn
        Me.IsCoop = (Name.IndexOf("_vs_") < 0)
        Me.IsVersus = (Name.IndexOf("_vs_") > 0)
        Me.IsSurival = (Name.IndexOf("_sv_") > 0)
    End Sub

End Class
