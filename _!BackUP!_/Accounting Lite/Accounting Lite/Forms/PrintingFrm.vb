Public Class PrintingFrm
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Try
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            BtnPrint.Visible = False
            Application.DoEvents()
            GetFormImage(Me)
            pd = New Printing.PrintDocument
            'PrintPreviewDialog1.Document = pd
            'PrintPreviewDialog1.Show()
            pd.Print()
            BtnPrint.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class