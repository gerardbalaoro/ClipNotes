Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports MetroFramework

Public Class Form1
    Dim ClassicStyle As Boolean = False
    Dim RecorderRunning As Boolean = False
    Sub RecorderActivate()
        RecorderRunning = True
        If My.Settings.UseClassicRecording = True Then
            ClassicStyle = True
            RecordControl.Text = "Stop Recording"
            Notify_RecordControl.Text = "Stop Recording"
            RecordControl.Style = MetroColorStyle.Red
        ElseIf My.Settings.UseClassicRecording = False Then
            RecordTimer.Enabled = True
            RecordTimer.Start()
            RecordControl.Text = "Stop Recording"
            RecordControl.Style = MetroColorStyle.Red
            Notify_RecordControl.Text = "Stop Recording"
        End If
    End Sub

    Sub RecorderStop()
        RecorderRunning = False
        If My.Settings.UseClassicRecording = True Then
            ClassicStyle = False
            RecordControl.Text = "Start Recording"
            RecordControl.Style = MetroColorStyle.Green
            Notify_RecordControl.Text = "Start Recording"
        ElseIf My.Settings.UseClassicRecording = False Then
            RecordTimer.Start()
            RecordTimer.Enabled = False
            RecordControl.Text = "Start Recording"
            RecordControl.Style = MetroColorStyle.Green
            Notify_RecordControl.Text = "Start Recording"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RecordTimer.Tick
        If My.Settings.UseClassicRecording = False Then
            If Clipboard.ContainsText Then
                If Clipboard.GetText.ToString <> My.Settings.recenttext.ToString Then
                    My.Settings.recenttext = Clipboard.GetText.ToString
                    TextField.AppendText(Clipboard.GetText)
                    TextField.AppendText(vbNewLine)
                    TextField.AppendText(vbNewLine)
                    My.Settings.Save()
                End If
            End If
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles RecordControl.Click
        If RecorderRunning = True Then
            RecorderStop()
        ElseIf RecorderRunning = False
            RecorderActivate()
        End If
        TextField.Focus()
    End Sub

    Private Sub SaveAs(sender As Object, e As EventArgs) Handles Exportbtn.Click, SaveToolStripMenuItem.Click
        Dim sd As New SaveFileDialog
        sd.Filter = "Rich Text Format (.rtf)|*.rtf|Text File (.txt)|*.txt"
        If sd.ShowDialog = DialogResult.OK Then
            If sd.Filter = "RichTextFormat|*.rtf" Then
                TextField.SaveFile(sd.FileName)
            Else
                TextField.SaveFile(sd.FileName, RichTextBoxStreamType.UnicodePlainText)
            End If
        End If
        TextField.Focus()
    End Sub

    Private Sub CopyAll(sender As Object, e As EventArgs) Handles CopyAllToolStripMenuItem.Click
        RecordControl.PerformClick()
        If TextField.Text <> Nothing Then Clipboard.SetText(TextField.Text)
    End Sub

    Private Sub ClearFieldText(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, ClearField.Click
        TextField.Clear()
        TextField.Focus()
    End Sub

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312
    Public Const KEY_CONTROL As Integer = &H2

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RecordTimer.Enabled = False
        RecordTimer.Stop()
        MonitorTimer.Start()
        If My.Settings.AlwaysOnTop = True Then
            KeepOnTopToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If

        If My.Settings.UseClassicRecording = True Then
            RecordingMethodToolStripMenuItem.Checked = True

        End If
        If My.Settings.RecordOnStart = True Then
            RecorderActivate()
            StartRecordingOnStartupToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If Clipboard.ContainsText = True Then
            PasteToolStripMenuItem.Enabled = True
        Else PasteToolStripMenuItem.Enabled = False
        End If
        TextField.BulletIndent = 1
        RegisterHotKey(Me.Handle, 1, KEY_CONTROL Or KEY_ALT, Keys.Z)
        RegisterHotKey(Me.Handle, 2, KEY_CONTROL Or KEY_ALT, Keys.Y)
        RegisterHotKey(Me.Handle, 3, KEY_ALT, Keys.F2)
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = _HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "1"
                    TextField.Undo()
                Case "2"
                    TextField.Redo()
                Case "3"
                    RecordControl.PerformClick()
            End Select
        End If
        MyBase.WndProc(m)


        If m.Msg = WM_DRAWCLIPBOARD Then
            If ClassicStyle = True Then
                Dim rtb As New RichTextBox
                TextField.Paste()
                TextField.AppendText(vbNewLine & vbNewLine)
            End If
            SendMessage(fpChainedWindowHandle, m.Msg, m.LParam, m.WParam)
        ElseIf m.Msg = WM_CHANGECBCHAIN Then
            SendMessage(fpChainedWindowHandle, m.Msg, m.LParam, m.WParam)
            fpChainedWindowHandle = m.LParam
        End If

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextField.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        TextField.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, CopyToolStripMenuItem1.Click
        Clipboard.SetText(TextField.SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click, PasteToolStripMenuItem1.Click
        TextField.AppendText(Clipboard.GetText)
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fontdiag As New FontDialog
        fontdiag.ShowApply = True
        fontdiag.Font = TextField.Font
        If fontdiag.ShowDialog = DialogResult.OK Then
            TextField.Font = fontdiag.Font
            My.Settings.Font = fontdiag.Font
            My.Settings.Save()
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub TextField_TextChanged(sender As Object, e As EventArgs) Handles TextField.TextChanged
        TextField.BulletIndent = 1
    End Sub

    Private Sub StartRecordingOnStartupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartRecordingOnStartupToolStripMenuItem.Click
        If StartRecordingOnStartupToolStripMenuItem.Checked = True Then
            My.Settings.RecordOnStart = True
            My.Settings.Save()
        ElseIf StartRecordingOnStartupToolStripMenuItem.Checked = False Then
            My.Settings.RecordOnStart = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private checkPrint As Integer

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        checkPrint = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        checkPrint = TextField.Print(checkPrint, TextField.TextLength, e)
        If checkPrint < TextField.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If My.Settings.AlwaysOnTop = True Then
            Me.TopMost = vbFalse
            KeepOnTopToolStripMenuItem.Checked = False
        End If
        MetroMessageBox.Show(Me, My.Resources.About, "About", MessageBoxButtons.OK, MessageBoxIcon.Question, 250)

    End Sub

#Region "Status Strip Effects"
    Private Sub FileToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpened, FileToolStripMenuItem.MouseHover
        FileToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub FileToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownClosed
        FileToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub FileToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.MouseLeave
        If FileToolStripMenuItem.DropDown.Visible = False Then FileToolStripMenuItem.ForeColor = Color.White
    End Sub
    Private Sub EditToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.DropDownOpened, EditToolStripMenuItem.MouseHover
        EditToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub EditToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.DropDownClosed
        EditToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub EditToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.MouseLeave
        If EditToolStripMenuItem.DropDown.Visible = False Then EditToolStripMenuItem.ForeColor = Color.White
    End Sub
    Private Sub FormatToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.DropDownOpened, FormatToolStripMenuItem.MouseHover
        FormatToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub FormatToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.DropDownClosed
        FormatToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub FormatToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.MouseLeave
        If FormatToolStripMenuItem.DropDown.Visible = False Then FormatToolStripMenuItem.ForeColor = Color.White
    End Sub
    Private Sub HelpToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.DropDownOpened, HelpToolStripMenuItem.MouseHover
        HelpToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub HelpToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.DropDownClosed
        HelpToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub HelpToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.MouseLeave
        If HelpToolStripMenuItem.DropDown.Visible = False Then HelpToolStripMenuItem.ForeColor = Color.White
    End Sub
#End Region

    Private Sub InternalHotKeys(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            PrintToolStripMenuItem.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            SaveToolStripMenuItem.PerformClick()
        ElseIf e.Alt AndAlso e.Shift AndAlso e.KeyCode = Keys.D Then
            If My.Settings.AlwaysOnTop = True Then
                Me.TopMost = vbFalse
                KeepOnTopToolStripMenuItem.Checked = False
            End If
            MetroMessageBox.Show(Me, vbNewLine & "Settings Debug Check:" & vbNewLine _
                                 & vbNewLine & "Startup Run: " & My.Settings.RecordOnStart.ToString _
                                 & vbNewLine & "Classic Mode: " & My.Settings.UseClassicRecording.ToString _
                                 & vbNewLine & "Top Most: " & My.Settings.AlwaysOnTop.ToString _
                                 , "Hidden Command: Debug Activated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        e.Handled = False
    End Sub

    Private Const WM_DRAWCLIPBOARD As Integer = 776
    Private Const WM_CHANGECBCHAIN As Integer = 781
    Private fpChainedWindowHandle As IntPtr

    <DllImport("User32.dll")>
    Public Shared Function SetClipboardViewer(ByVal hWndNewViewer As IntPtr) As IntPtr
    End Function
    <DllImport("User32.dll")>
    Public Shared Function SendMessage(ByVal Handle As IntPtr,
                                 ByVal msg As Integer,
                                 ByVal wParam As IntPtr,
                                 ByVal lParam As IntPtr) As IntPtr
    End Function
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fpChainedWindowHandle = SetClipboardViewer(Me.Handle)
    End Sub

    Private Sub OnClose(sender As Object, e As EventArgs) Handles MyBase.Closing
        My.Settings.Save()
    End Sub

    Private Sub RecordingMethodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordingMethodToolStripMenuItem.Click
        RecorderStop()
        If RecordingMethodToolStripMenuItem.Checked = True Then
            My.Settings.UseClassicRecording = True
            My.Settings.Save()
        Else
            My.Settings.UseClassicRecording = False
            My.Settings.Save()
        End If
        RecorderActivate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(My.Settings.UseClassicRecording.ToString())
    End Sub

    Private Sub KeepOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeepOnTopToolStripMenuItem.Click
        If KeepOnTopToolStripMenuItem.Checked = True Then
            My.Settings.AlwaysOnTop = True
            My.Settings.Save()
            Me.TopMost = True
        ElseIf StartRecordingOnStartupToolStripMenuItem.Checked = False Then
            My.Settings.AlwaysOnTop = False
            My.Settings.Save()
            Me.TopMost = False
        End If
    End Sub

    Dim oldsize As Size
    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        oldsize = Me.Size
        If My.Settings.AlwaysOnTop = True Then
            Me.TopMost = vbFalse
            KeepOnTopToolStripMenuItem.Checked = False
        End If
        If Me.Size.Width < 444 Then
            Me.Size = New Size(444, Me.Height)
        ElseIf Me.Size.Height < 560 Then
            Me.Size = New Size(Me.Width, 560)
        End If
        If MetroMessageBox.Show(Me, My.Resources.Help, "Help", MessageBoxButtons.OK, MessageBoxIcon.Warning, 532) _
            = DialogResult.OK Then
            Me.Size = oldsize
        End If

    End Sub

    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click
        oldsize = Me.Size
        If My.Settings.AlwaysOnTop = True Then KeepOnTopToolStripMenuItem.PerformClick() If My.Settings.AlwaysOnTop = True Then
            Me.TopMost = vbFalse
            KeepOnTopToolStripMenuItem.Checked = False
        End If
        If Me.Size.Width < 747 Then
            Me.Size = New Size(747, Me.Height)
        ElseIf Me.Size.Height < 500 Then
            Me.Size = New Size(Me.Width, 500)
        End If
        If MetroMessageBox.Show(Me, My.Resources.License, "The MIT LICENSE", MessageBoxButtons.OK, MessageBoxIcon.Information, 490) _
            = DialogResult.OK Then
            Me.Size = oldsize
        End If
    End Sub

    Private Sub MonitorTimer_Tick(sender As Object, e As EventArgs) Handles MonitorTimer.Tick
        If Clipboard.ContainsText Then
            PasteToolStripMenuItem.Enabled = True
            PasteToolStripMenuItem1.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
            PasteToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        MinimizetoTray()
    End Sub

    Sub MinimizetoTray()
        Me.WindowState = FormWindowState.Minimized
        NotifyIcon.Visible = True
        Me.Hide()
        ShowInTaskbar = False

    End Sub

    Sub RestoreWindow()
        Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        RestoreWindow()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        RestoreWindow()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Notify_RecordControl.Click
        If RecorderRunning = True Then
            RecorderStop()
        ElseIf RecorderRunning = False
            RecorderActivate()
        End If
    End Sub

End Class