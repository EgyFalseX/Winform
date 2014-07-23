Public Class BillsFrm
    Private CusDS, ModDS, BillItemsDS As DataSet
    Public BillID As String = ""
    Private ErrorProv As String
    Private Sub BillsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If BillID <> "" Then
            PNL.Enabled = False
            LoadAllItems()
            If CBModName.Items.Count > 0 Then
                If CBModName.Items.Count > 0 Then
                    GB.Enabled = True
                    CBModName.SelectedIndex = 0
                    UpdateBillItems()
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
        If Val(TxtCount.Text.Trim) <> 0 And Val(TxtCount.Text.Trim) <= Val(LblCount.Text.Trim) Then
            Insertion_Updateing_Deleting("INSERT INTO BillTypes (BillID, TypeID, [Count], Cost) VALUES ('" & BillID & "'," & CBModName.SelectedValue.ToString & ",'" & Val(TxtCount.Text.Trim) & "','" & Val(TxtCost.Text.Trim) & "')")
            UpdateBillItems()
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
        Insertion_Updateing_Deleting("Delete from BillTypes where BillTypeID=" & LBMob.SelectedValue.ToString)
        UpdateBillItems()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtBillNumber.TextLength = 0 Then
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ErrorProv = InsertBill("INSERT INTO Bills (BillsID,BillDate, CusID) VALUES ('" & TxtBillNumber.Text.Trim & "',#" & DTP.Value.ToShortDateString & "#," & CBCus.SelectedValue & ")")
        If ErrorProv = Nothing Then
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            If CBModName.Items.Count > 0 Then
                If CBModName.Items.Count > 0 Then
                    PNL.Enabled = False
                    GB.Enabled = True
                    BillID = TxtBillNumber.Text
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
            PnlSto.Visible = True
            TxtCost.Text = ModDS.Tables(0).Rows(CBModName.SelectedIndex).Item(2).ToString
            SelectTypeCount(CBModName.SelectedValue, LblCount.Text) 'Get Item Count from Storage
        Else
            PnlSto.Visible = False
            TxtCost.Text = "0"
        End If
    End Sub
    Private Sub LBMob_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBMob.MouseClick
        Dim Str As String = Nothing
        If LBMob.SelectedIndex <> -1 Then
            Str = " الكمـيه " & BillItemsDS.Tables(0).Rows(LBMob.SelectedIndex).Item(1).ToString
            Str &= vbNewLine & " سعر الوحده " & BillItemsDS.Tables(0).Rows(LBMob.SelectedIndex).Item(2).ToString
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
    Private Sub UpdateBillItems()
        BillItemsDS = CreateOLEDS("SELECT BillTypes.BillTypeID, BillTypes.[Count], BillTypes.Cost, Types.TypeCode FROM (BillTypes INNER JOIN Types ON BillTypes.TypeID = Types.TypeID) WHERE (BillTypes.BillID = '" & BillID & "')")
        LBMob.DataSource = BillItemsDS.Tables(0)
        LBMob.ValueMember = "BillTypeID"
        LBMob.DisplayMember = "TypeCode"
    End Sub
    Private Sub LoadAllItems()
        ModDS = CreateOLEDS("SELECT TypeID, TypeCode, Cost FROM Types")
        CBModName.DataSource = ModDS.Tables(0)
        CBModName.ValueMember = "TypeID"
        CBModName.DisplayMember = "TypeCode"
    End Sub
End Class