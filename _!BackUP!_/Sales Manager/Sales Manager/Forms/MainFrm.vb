Imports System.Windows.Forms

Public Class MainFrm
#Region "       -=[ Menus Handles ]=-      "
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexToolStripMenuItem.Click

    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
    Private Sub ItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemToolStripMenuItem.Click
        If FrmItemsInsertion.Visible = True Then
            FrmItemsInsertion.Focus()
            Exit Sub
        End If
        FrmItemsInsertion = New ItemsInsertionFrm
        FrmItemsInsertion.MdiParent = Me
        FrmItemsInsertion.Show()
    End Sub
    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        If FrmSupplyerInsertion.Visible = True Then
            FrmSupplyerInsertion.Focus()
            Exit Sub
        End If
        FrmSupplyerInsertion = New SupplyerInsertionFrm
        FrmSupplyerInsertion.MdiParent = Me
        FrmSupplyerInsertion.Show()
    End Sub
    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        If FrmEmployeeInsertion.Visible = True Then
            FrmEmployeeInsertion.Focus()
            Exit Sub
        End If
        FrmEmployeeInsertion = New EmployeeInsertionFrm
        FrmEmployeeInsertion.MdiParent = Me
        FrmEmployeeInsertion.Show()
    End Sub
    Private Sub BillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillsToolStripMenuItem.Click
        If FrmBills.Visible = True Then
            FrmBills.Focus()
            Exit Sub
        End If
        FrmBills = New BillsFrm
        FrmBills.MdiParent = Me
        FrmBills.Show()
    End Sub
    Private Sub AddsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddsToolStripMenuItem.Click
        If FrmAddsContains.Visible = True Then
            FrmAddsContains.Focus()
            Exit Sub
        End If
        FrmAddsContains = New AddsContainsFrm
        FrmAddsContains.MdiParent = Me
        FrmAddsContains.Show()
    End Sub
    Private Sub MaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceToolStripMenuItem.Click
        If FrmMaintenanceIncome.Visible = True Then
            FrmMaintenanceIncome.Focus()
            Exit Sub
        End If
        FrmMaintenanceIncome = New MaintenanceIncomeFrm
        FrmMaintenanceIncome.MdiParent = Me
        FrmMaintenanceIncome.Show()
    End Sub
    Private Sub ReturnedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnedToolStripMenuItem.Click
        If FrmReturned.Visible = True Then
            FrmReturned.Focus()
            Exit Sub
        End If
        FrmReturned = New ReturnedFrm
        FrmReturned.MdiParent = Me
        FrmReturned.Show()
    End Sub
    Private Sub SpendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpendingToolStripMenuItem.Click
        If FrmSpending.Visible = True Then
            FrmSpending.Focus()
            Exit Sub
        End If
        FrmSpending = New SpendingFrm
        FrmSpending.MdiParent = Me
        FrmSpending.Show()
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If FrmOptions.Visible = True Then
            FrmOptions.Focus()
            Exit Sub
        End If
        FrmOptions = New OptionsFrm
        FrmOptions.MdiParent = Me
        FrmOptions.Show()
    End Sub
    Private Sub EditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditorToolStripMenuItem.Click
        If FrmEditor.Visible = True Then
            FrmEditor.Focus()
            Exit Sub
        End If
        FrmEditor = New EditorFrm
        FrmEditor.MdiParent = Me
        FrmEditor.Show()
    End Sub
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        ToolStrip.Visible = Not ToolStrip.Visible
    End Sub
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusStrip.Visible = Not StatusStrip.Visible
    End Sub
    Private Sub QueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryToolStripMenuItem.Click

    End Sub
#End Region

End Class
