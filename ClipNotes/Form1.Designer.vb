<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RecordTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartRecordingOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordingMethodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckUpdateBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.MonitorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayIconMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Notify_RecordControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.RecordControl = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.ClearField = New MetroFramework.Controls.MetroButton()
        Me.Exportbtn = New MetroFramework.Controls.MetroButton()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Notifier = New MetroFramework.Controls.MetroLabel()
        Me.NotificationPanel = New System.Windows.Forms.Panel()
        Me.NotificationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextField = New ClipNotes.RichTextBoxPrintCtrl.RichTextBoxPrintCtrl()
        Me.Panel1.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TrayIconMenu.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.NotificationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecordTimer
        '
        Me.RecordTimer.Interval = 300
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextField)
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(430, 419)
        Me.Panel1.TabIndex = 1
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(103, 48)
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(430, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PageSetupToolStripMenuItem})
        Me.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CopyAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CopyAllToolStripMenuItem
        '
        Me.CopyAllToolStripMenuItem.Name = "CopyAllToolStripMenuItem"
        Me.CopyAllToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CopyAllToolStripMenuItem.Text = "Copy All"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.StartRecordingOnStartupToolStripMenuItem, Me.RecordingMethodToolStripMenuItem, Me.KeepOnTopToolStripMenuItem, Me.MinimizeToTrayToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FormatToolStripMenuItem.Text = "Options"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.FontToolStripMenuItem.Text = "Font..."
        '
        'StartRecordingOnStartupToolStripMenuItem
        '
        Me.StartRecordingOnStartupToolStripMenuItem.CheckOnClick = True
        Me.StartRecordingOnStartupToolStripMenuItem.Name = "StartRecordingOnStartupToolStripMenuItem"
        Me.StartRecordingOnStartupToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.StartRecordingOnStartupToolStripMenuItem.Text = "Start Recording on Startup"
        '
        'RecordingMethodToolStripMenuItem
        '
        Me.RecordingMethodToolStripMenuItem.CheckOnClick = True
        Me.RecordingMethodToolStripMenuItem.Name = "RecordingMethodToolStripMenuItem"
        Me.RecordingMethodToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RecordingMethodToolStripMenuItem.Text = "Use Classic Recording"
        '
        'KeepOnTopToolStripMenuItem
        '
        Me.KeepOnTopToolStripMenuItem.CheckOnClick = True
        Me.KeepOnTopToolStripMenuItem.Name = "KeepOnTopToolStripMenuItem"
        Me.KeepOnTopToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.KeepOnTopToolStripMenuItem.Text = "Keep On Top"
        '
        'MinimizeToTrayToolStripMenuItem
        '
        Me.MinimizeToTrayToolStripMenuItem.Name = "MinimizeToTrayToolStripMenuItem"
        Me.MinimizeToTrayToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MinimizeToTrayToolStripMenuItem.Text = "Minimize to Tray"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LicenseToolStripMenuItem, Me.CheckUpdateBtn})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'CheckUpdateBtn
        '
        Me.CheckUpdateBtn.Name = "CheckUpdateBtn"
        Me.CheckUpdateBtn.Size = New System.Drawing.Size(171, 22)
        Me.CheckUpdateBtn.Text = "Check for Updates"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'MonitorTimer
        '
        Me.MonitorTimer.Enabled = True
        Me.MonitorTimer.Interval = 300
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.NotifyIcon.BalloonTipText = "Click to Restore"
        Me.NotifyIcon.BalloonTipTitle = "ClipNotes"
        Me.NotifyIcon.ContextMenuStrip = Me.TrayIconMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Double Click to Restore"
        '
        'TrayIconMenu
        '
        Me.TrayIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.Notify_RecordControl})
        Me.TrayIconMenu.Name = "MetroContextMenu1"
        Me.TrayIconMenu.Size = New System.Drawing.Size(156, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem1.Text = "Restore"
        '
        'Notify_RecordControl
        '
        Me.Notify_RecordControl.Name = "Notify_RecordControl"
        Me.Notify_RecordControl.Size = New System.Drawing.Size(155, 22)
        Me.Notify_RecordControl.Text = "Start Recording"
        '
        'wb
        '
        Me.wb.Location = New System.Drawing.Point(0, 0)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(250, 250)
        Me.wb.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.RecordControl)
        Me.MainPanel.Controls.Add(Me.MenuStrip1)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.ClearField)
        Me.MainPanel.Controls.Add(Me.Exportbtn)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(20, 60)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(430, 480)
        Me.MainPanel.TabIndex = 6
        '
        'RecordControl
        '
        Me.RecordControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordControl.Image = Nothing
        Me.RecordControl.Location = New System.Drawing.Point(323, 448)
        Me.RecordControl.Name = "RecordControl"
        Me.RecordControl.Size = New System.Drawing.Size(104, 29)
        Me.RecordControl.Style = MetroFramework.MetroColorStyle.Green
        Me.RecordControl.TabIndex = 1
        Me.RecordControl.Text = "Start Recording"
        Me.RecordControl.UseSelectable = True
        Me.RecordControl.UseStyleColors = True
        Me.RecordControl.UseVisualStyleBackColor = True
        '
        'ClearField
        '
        Me.ClearField.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClearField.Location = New System.Drawing.Point(113, 448)
        Me.ClearField.Name = "ClearField"
        Me.ClearField.Size = New System.Drawing.Size(104, 29)
        Me.ClearField.TabIndex = 5
        Me.ClearField.Text = "Clear"
        Me.ClearField.UseSelectable = True
        '
        'Exportbtn
        '
        Me.Exportbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Exportbtn.Location = New System.Drawing.Point(3, 448)
        Me.Exportbtn.Name = "Exportbtn"
        Me.Exportbtn.Size = New System.Drawing.Size(104, 29)
        Me.Exportbtn.TabIndex = 2
        Me.Exportbtn.Text = "Export"
        Me.Exportbtn.UseSelectable = True
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(0, 0)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(15, 15)
        Me.Spinner.Speed = 3.0!
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Teal
        Me.Spinner.TabIndex = 3
        Me.Spinner.UseCustomBackColor = True
        Me.Spinner.UseSelectable = True
        Me.Spinner.UseStyleColors = True
        Me.Spinner.Value = 30
        '
        'Notifier
        '
        Me.Notifier.AutoSize = True
        Me.Notifier.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Notifier.ForeColor = System.Drawing.Color.White
        Me.Notifier.Location = New System.Drawing.Point(21, 0)
        Me.Notifier.Name = "Notifier"
        Me.Notifier.Size = New System.Drawing.Size(123, 15)
        Me.Notifier.TabIndex = 0
        Me.Notifier.Text = "Checking for Updates..."
        Me.Notifier.UseCustomBackColor = True
        '
        'NotificationPanel
        '
        Me.NotificationPanel.Controls.Add(Me.Notifier)
        Me.NotificationPanel.Controls.Add(Me.Spinner)
        Me.NotificationPanel.Location = New System.Drawing.Point(20, 42)
        Me.NotificationPanel.Name = "NotificationPanel"
        Me.NotificationPanel.Size = New System.Drawing.Size(155, 15)
        Me.NotificationPanel.TabIndex = 7
        Me.NotificationPanel.Visible = False
        '
        'NotificationTimer
        '
        '
        'TextField
        '
        Me.TextField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextField.ContextMenuStrip = Me.MetroContextMenu1
        Me.TextField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextField.Location = New System.Drawing.Point(5, 5)
        Me.TextField.Name = "TextField"
        Me.TextField.Size = New System.Drawing.Size(418, 407)
        Me.TextField.TabIndex = 0
        Me.TextField.Text = ""
        '
        'Form1
        '
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(470, 560)
        Me.Controls.Add(Me.NotificationPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(364, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "ClipNotes"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel1.ResumeLayout(False)
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TrayIconMenu.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.NotificationPanel.ResumeLayout(False)
        Me.NotificationPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecordTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartRecordingOnStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents RecordingMethodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeepOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents CopyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MonitorTimer As Timer
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents TrayIconMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Notify_RecordControl As ToolStripMenuItem
    Friend WithEvents TextField As RichTextBoxPrintCtrl.RichTextBoxPrintCtrl
    Friend WithEvents MinimizeToTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wb As WebBrowser
    Friend WithEvents CheckUpdateBtn As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ClearField As MetroFramework.Controls.MetroButton
    Friend WithEvents Exportbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Notifier As MetroFramework.Controls.MetroLabel
    Friend WithEvents RecordControl As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Spinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents NotificationPanel As Panel
    Friend WithEvents NotificationTimer As Timer
End Class
