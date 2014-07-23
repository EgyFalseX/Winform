Public Class MSGBOXFrm
#Region "Form Auto Move Subroutain"
    Public x As Int16
    Public y As Int16
    Public fla As Boolean
    Private Sub MSGBOXFrm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, Panel.MouseDown
        x = e.X
        y = e.Y
        fla = True
    End Sub
    Private Sub MSGBOXFrm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, Panel.MouseUp
        fla = False
    End Sub
    Private Sub MSGBOXFrm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, Panel.MouseMove
        If fla = True Then
            Me.Location = New Point(Me.Location.X + (e.X - x), Me.Location.Y + (e.Y - y))
        Else
            Me.Visible = True
        End If

    End Sub
#End Region
    Private FadTMR As New Timer
    Private MSG As String
    Private LBLTMR As New Timer
    Public Sub New(ByVal ShowedMessage As String)
        MSG = ShowedMessage
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MSGBOXFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLMSG.Text = MSG
        FadTMR.Interval = 30
        AddHandler FadTMR.Tick, AddressOf FadTmr_tick
        AddHandler LBLTMR.Tick, AddressOf LBLTMR_Tick
        FadTMR.Enabled = True
        LBLTMR.Interval = 1500
        'LBLTMR.Enabled = True
    End Sub
    Private Sub FadTmr_tick(ByVal sender As Object, ByVal e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.029
        Else
            Me.Opacity = 1
            FadTMR.Enabled = False
        End If
    End Sub
    Private Sub LBLTMR_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If LBLMSG.Visible = True Then
            LBLMSG.Visible = False
        Else
            LBLMSG.Visible = True
        End If
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LBLTMR.Enabled = False
        Me.Close()
    End Sub
End Class