Public Class SupplierFrm
    Private Tmr As New Timer
    Private ScnHeight As Int32 = Val(Screen.PrimaryScreen.WorkingArea.Height)
    Private _To As Int32 = 0
    Public Reset_Falg As Boolean
    Private Sub Frm_Supplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ArrArg() As String = Environment.GetCommandLineArgs
        If ArrArg.Length > 1 Then
            If ArrArg(1).ToLower.Trim = "uninstall" Then
                Process.Start(Environment.SystemDirectory & "\MsiExec.exe", "/I{F089E700-6F24-460C-AD47-22A36479B26D}")
                Process.GetCurrentProcess.Kill()
            End If
        End If
        LbRight.Text = Today.Day & "/  " & Today.Month & "/  " & Today.Year
        Me.TopMost = False
        Me.Location = New Point(Val(Screen.PrimaryScreen.WorkingArea.Width) - Val(Me.Width), Val(Screen.PrimaryScreen.WorkingArea.Height))
        Tmr.Interval = 10
        AddHandler Tmr.Tick, AddressOf Tmr_Tick
        Tmr.Start()
        Exit Sub
        If SecSTR <> CharToBinary(GetProcessorId) Then
            MsgBox_("Unrecognized PC Config", False, Me)
            Process.GetCurrentProcess.Kill()
        End If
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
        _To += Tmr.Interval
        If _To < Val(Me.Height) Then
            Me.Location = New Point(Me.Location.X, ScnHeight - _To)
        Else
            Me.Location = New Point(Val(Screen.PrimaryScreen.WorkingArea.Width) - Val(Me.Width), Val(Screen.PrimaryScreen.WorkingArea.Height) - Val(Me.Height))
            Me.TopMost = True
            Tmr.Stop()
        End If
    End Sub
    Private Sub SupplierFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Reset_Falg = False Then
            e.Cancel = True
        End If
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Process.GetProcessById(Process.GetCurrentProcess.Id).Kill()
    End Sub
    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnModels_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModels.CheckedChanged, BtnModels.Click
        If BtnModels.Checked = True And FrmTypesInsertion.Visible = False Then
            CloseWindows()
            FrmTypesInsertion = New TypesInsertionFrm
            FrmTypesInsertion.Show()
        End If
    End Sub
    Private Sub BtnCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomers.CheckedChanged, BtnCustomers.Click
        If BtnCustomers.Checked = True And FrmCustomerInsertion.Visible = False Then
            CloseWindows()
            FrmCustomerInsertion = New CustomerInsertionFrm
            FrmCustomerInsertion.Show()
        End If
    End Sub
    Private Sub BtnStorage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStorage.CheckedChanged, BtnStorage.Click
        If BtnStorage.Checked = True And FrmStorage.Visible = False Then
            CloseWindows()
            FrmStorage = New StorageFrm
            FrmStorage.Show()
        End If
    End Sub
    Private Sub BtnPayments_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayments.CheckedChanged, BtnPayments.Click
        If BtnPayments.Checked = True And FrmCustomerPayment.Visible = False Then
            CloseWindows()
            FrmCustomerPayment = New CustomerPaymentFrm
            FrmCustomerPayment.Show()
        End If
    End Sub
    Private Sub BtnBills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBills.CheckedChanged, BtnBills.Click
        If BtnBills.Checked = True And FrmBills.Visible = False Then
            CloseWindows()
            FrmBills = New BillsFrm
            FrmBills.Show()
        End If
    End Sub
    Private Sub BtnSpendType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpendType.CheckedChanged, BtnSpendType.Click
        If BtnSpendType.Checked = True And FrmSpendType.Visible = False Then
            CloseWindows()
            FrmSpendType = New SpendTypeFrm
            FrmSpendType.Show()
        End If
    End Sub
    Private Sub BtnSpend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpend.CheckedChanged, BtnSpend.Click
        If BtnSpend.Checked = True And FrmSpending.Visible = False Then
            CloseWindows()
            FrmSpending = New SpendingFrm
            FrmSpending.Show()
        End If
    End Sub
    Private Sub BtnEditor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditor.CheckedChanged, BtnEditor.Click
        If BtnEditor.Checked = True And FrmEditor.Visible = False Then
            CloseWindows()
            FrmEditor = New EditorFrm
            FrmEditor.Show()
        End If
    End Sub
    Private Sub BtnQueries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQueries.Click, BtnQueries.CheckedChanged
        If BtnQueries.Checked = True And FrmQueries.Visible = False Then
            CloseWindows()
            FrmQueries = New QueriesFrm
            FrmQueries.Show()
        End If
    End Sub
    Private Sub BtnReturner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturner.Click, BtnReturner.CheckedChanged
        If BtnReturner.Checked = True And FrmReturners.Visible = False Then
            CloseWindows()
            FrmReturners = New ReturnersFrm
            FrmReturners.Show()
        End If
    End Sub
    Private Sub BtnDiscount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDiscount.Click, BtnDiscount.CheckedChanged
        If BtnDiscount.Checked = True And FrmDiscounts.Visible = False Then
            CloseWindows()
            FrmDiscounts = New DiscountsFrm
            FrmDiscounts.Show()
        End If
    End Sub
    Private Sub BtnOptions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOptions.CheckedChanged, BtnOptions.Click
        If BtnOptions.Checked = True And FrmOptions.Visible = False Then
            CloseWindows()
            FrmOptions = New OptionsFrm
            FrmOptions.Show()
        End If
    End Sub
#Region "/  Form Moves    /"
    Public x As Int16
    Public y As Int16
    Public fla As Boolean
    Private Sub Frm_Main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseDown
        x = e.X
        y = e.Y
        fla = True
    End Sub
    Private Sub Frm_Main_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseUp
        fla = False
    End Sub
    Private Sub Frm_Main_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseMove
        If fla = True Then
            Me.Location = New Point(Me.Location.X + (e.X - x), Me.Location.Y + (e.Y - y))
        Else
            Me.Visible = True
        End If

    End Sub
#End Region
End Class