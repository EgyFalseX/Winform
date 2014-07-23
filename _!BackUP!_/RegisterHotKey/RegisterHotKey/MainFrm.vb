Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.ComponentModel

Public Class MainFrm
    Public Enum HotkeyModifierFlags
        MOD_ALT = &H1
        MOD_CONTROL = &H2
        MOD_SHIFT = &H4
        MOD_WIN = &H8
    End Enum
    Public Function RegisterHotkey(ByVal hwnd As IntPtr, ByVal Id As Int32, <MarshalAs(UnmanagedType.U4)> ByVal fsModifiers As Int32, _
               <MarshalAs(UnmanagedType.U4)> ByVal vkey As Int32) As Boolean
    End Function
    Public Function UnregisterHotkey(ByVal hwnd As Int32, ByVal Id As Int32) As Boolean
    End Function
    Public Function GlobalAddAtom(<MarshalAs(UnmanagedType.LPTStr)> _
                ByVal lpString As String) As Int32
    End Function
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Listen for messages that are sent to the 
        ' button window. Some messages are sent
        ' to the parent window instead of the button's window.
        Select Case (m.Msg)
            Case WM_HOTKEY
                ' Respond to the hotkey message (asynchronously??)
                If Not mwh Is Nothing Then
                    mwh.Set()
                End If
        End Select
        MyBase.WndProc(m)
    End Sub
End Class

Public Class GlobalHotkeyListener
    Inherits NativeWindow
#Region "Private member variables"
    Private windowHandle As Integer
    Private mwh As ManualResetEvent
#End Region
    Public Sub New(ByVal Id As Int32, _
              ByVal fsModifiers As Int32, _
              ByVal vkey As Int32, _
              ByRef wh As ManualResetEvent)

        '\\ Get a local copy of the wait handle


        mwh = wh
        Dim cp As CreateParams = New CreateParams()

        ' Fill in the CreateParams details.

        cp.Caption = ""
        cp.ClassName = "STATIC"

        ' Set the position on the form

        cp.X = 0
        cp.Y = 0
        cp.Height = 0
        cp.Width = 0

        '\\ Set the style and extended style flags

        cp.Style = WindowStyleBits.WS_MINIMIZE
        cp.ExStyle = WindowStyleExtendedBits.WS_EX_NOACTIVATE

        ' Create the actual window

        Me.CreateHandle(cp)

        Try
            If Not RegisterHotKey(MyBase.Handle, _
                        Id, fsModifiers, vkey) Then
                Throw New Win32Exception()
            End If
        Catch e As Exception
            System.Diagnostics.Debug.WriteLine(e.ToString)
        End Try
    End Sub
End Class