Public Class StartUpFrm
    Private Sub StartUpFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.Hide()
        main()
    End Sub
End Class
