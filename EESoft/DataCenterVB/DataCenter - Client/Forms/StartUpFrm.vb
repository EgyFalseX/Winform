Imports System.IO
Public Class StartUpFrm
    Private Sub StartUpFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Visible = False
            Me.Hide()
            'Make sure that the temp directory is exist and have no files
            If Directory.Exists(IconPath) = False Then
                Directory.CreateDirectory(IconPath)
            Else
                Directory.Delete(IconPath, True)
                Directory.CreateDirectory(IconPath)
            End If
            main()
        Catch ex As Exception
            MsgBox_(ex.Message, 0, 23, False, Me)
            Application.Exit()
        End Try
    End Sub
End Class