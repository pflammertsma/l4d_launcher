Imports System.Windows.Forms

Public Class NotFound

    Private Sub NotFound_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInfo.Text = "Left 4 Dead could not be located via the Windows Uninstall list. This means that not only can you not use this Launcher, but you are also unlikely to be able to uninstall the game. This can automatically be fixed by entering the path to the game below."
        If Not VistaSecurity.IsAdmin Then
            VistaSecurity.AddShieldToButton(btnFix)
        End If
        txtPath.Focus()
        txtPath.SelectAll()
        ' Default answer:
    End Sub

    Public Sub SetPath(ByVal path As String)
        txtPath.Text = path
    End Sub

    Public Function GetPath() As String
        Return txtPath.Text
    End Function

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.Retry
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class
