Public Class ReturnersFrm
    Private CusDS, ModDS, ReturnerItemsDS As DataSet
    Public ReturnerID As String = ""
    Private ErrorProv As String
    Private Sub ReturnersFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ReturnerID <> "" Then
            PNL.Enabled = False
            LoadAllItems()
            If CBModName.Items.Count > 0 Then
                If CBModName.Items.Count > 0 Then
                    GB.Enabled = True
                    CBModName.SelectedIndex = 0
                    UpdateReturnerItems()
                End If
            End If
            Exit Sub
        End If
        CusDS = CreateOLEDS("SELECT CusID, CusName FROM Customers")
        CBCus.DataSource = CusDS.Tables(0)
        CBCus.ValueMember = "CusID"
        CBCus.DisplayMember = "CusName"
        If CBCus.Items.Count > 0 Then
            CBCus.SelectedIndex = 0
        Else
            BtnSave.Enabled = False
            Exit Sub
        End If
        LoadAllItems()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'LBMob
        If Val(TxtCount.Text.Trim) <> 0 Then
            Insertion_Updateing_Deleting("INSERT INTO RetType (ReturnerID, TypeID, [Count], Cost) VALUES ('" & ReturnerID & "','" & CBModName.SelectedValue.ToString & "','" & Val(TxtCount.Text.Trim) & "','" & Val(TxtPrice.Text.Trim) & "')")
            UpdateReturnerItems()
            LblCount.Text = Val(LblCount.Text) - Val(TxtCount.Text.Trim)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtCount.Clear()
            CBModName.Focus()
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If MsgBox("هـل انـت متـأكد ؟", MsgBoxStyle.YesNo, "حـــذف") = MsgBoxResult.No Then
            Exit Sub
        End If
        Insertion_Updateing_Deleting("Delete from RetType where RetTypeID=" & LBMob.SelectedValue.ToString)
        UpdateReturnerItems()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtReturnerNumber.TextLength = 0 Then
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ErrorProv = InsertBill("INSERT INTO Returners (ReturnerID,ReturnerDate, CusID) VALUES ('" & TxtReturnerNumber.Text.Trim & "',#" & DTP.Value.ToShortDateString & "#," & CBCus.SelectedValue & ")")
        If ErrorProv = Nothing Then
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            If CBModName.Items.Count > 0 Then
                If CBModName.Items.Count > 0 Then
                    PNL.Enabled = False
                    GB.Enabled = True
                    ReturnerID = TxtReturnerNumber.Text
                    CBModName.SelectedIndex = 0
                    CBModName.Focus()
                End If
            End If
        Else
            MsgBox("خطــــاء" & vbNewLine & ErrorProv, MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub CBModName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBModName.SelectedIndexChanged
        If CBModName.SelectedIndex >= 0 And Val(CBModName.SelectedValue.ToString) > 0 Then
            TxtPrice.Text = Val(ModDS.Tables(0).Rows(CBModName.SelectedIndex).Item(2).ToString)
            '    PnlSto.Visible = True
            '    SelectTypeCount(CBModName.SelectedValue, LblCount.Text) 'Get Item Count from Storage
        Else
            '    PnlSto.Visible = False
            TxtPrice.Text = "0"
        End If
    End Sub
    Private Sub LBMob_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBMob.MouseClick
        Dim Str As String = Nothing
        If LBMob.SelectedIndex <> -1 Then
            Str = " الكمـيه " & ReturnerItemsDS.Tables(0).Rows(LBMob.SelectedIndex).Item(1).ToString
            Str &= vbNewLine & " سعر الوحده " & ReturnerItemsDS.Tables(0).Rows(LBMob.SelectedIndex).Item(3).ToString
            MsgBox(Str)
        End If
    End Sub
    Private Sub LBMob_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBMob.SelectedIndexChanged
        If LBMob.SelectedIndex >= 0 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub UpdateReturnerItems()
        ReturnerItemsDS = CreateOLEDS("SELECT RetType.RetTypeID, RetType.[Count], Types.TypeCode, RetType.Cost FROM (RetType INNER JOIN Types ON RetType.TypeID = Types.TypeID) WHERE (RetType.ReturnerID = '" & ReturnerID & "')")
        LBMob.DataSource = ReturnerItemsDS.Tables(0)
        LBMob.ValueMember = "RetTypeID"
        LBMob.DisplayMember = "TypeCode"
    End Sub
    Private Sub LoadAllItems()
        ModDS = CreateOLEDS("SELECT TypeID, TypeCode, Cost FROM Types")
        CBModName.DataSource = ModDS.Tables(0)
        CBModName.ValueMember = "TypeID"
        CBModName.DisplayMember = "TypeCode"
    End Sub
End Class