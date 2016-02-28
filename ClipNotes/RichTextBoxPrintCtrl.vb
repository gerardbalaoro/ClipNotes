Option Explicit On

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing

Namespace RichTextBoxPrintCtrl
    Public Class RichTextBoxPrintCtrl
        Inherits RichTextBox
        Private Const AnInch As Double = 14.4

        <StructLayout(LayoutKind.Sequential)>
        Private Structure RECT
            Public Left As Integer
            Public Top As Integer
            Public Right As Integer
            Public Bottom As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Private Structure CHARRANGE
            Public cpMin As Integer
            Public cpMax As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Private Structure FORMATRANGE
            Public hdc As IntPtr
            Public hdcTarget As IntPtr
            Public rc As RECT
            Public rcPage As RECT
            Public chrg As CHARRANGE
        End Structure

        Private Const WM_USER As Integer = &H400
        Private Const EM_FORMATRANGE As Integer = WM_USER + 57

        Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

        Public Function Print(ByVal charFrom As Integer, ByVal charTo As Integer, ByVal e As PrintPageEventArgs) As Integer
            Dim cRange As CHARRANGE
            cRange.cpMin = charFrom
            cRange.cpMax = charTo

            Dim rectToPrint As RECT
            rectToPrint.Top = e.MarginBounds.Top * AnInch
            rectToPrint.Bottom = e.MarginBounds.Bottom * AnInch
            rectToPrint.Left = e.MarginBounds.Left * AnInch
            rectToPrint.Right = e.MarginBounds.Right * AnInch

            Dim rectPage As RECT
            rectPage.Top = e.PageBounds.Top * AnInch
            rectPage.Bottom = e.PageBounds.Bottom * AnInch
            rectPage.Left = e.PageBounds.Left * AnInch
            rectPage.Right = e.PageBounds.Right * AnInch

            Dim hdc As IntPtr = e.Graphics.GetHdc()

            Dim fmtRange As FORMATRANGE
            fmtRange.chrg = cRange
            fmtRange.hdc = hdc
            fmtRange.hdcTarget = hdc
            fmtRange.rc = rectToPrint
            fmtRange.rcPage = rectPage

            Dim res As IntPtr = IntPtr.Zero
            Dim wparam As IntPtr = IntPtr.Zero
            wparam = New IntPtr(1)
            Dim lparam As IntPtr = IntPtr.Zero
            lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange))
            Marshal.StructureToPtr(fmtRange, lparam, False)
            res = SendMessage(Handle, EM_FORMATRANGE, wparam, lparam)
            Marshal.FreeCoTaskMem(lparam)
            e.Graphics.ReleaseHdc(hdc)
            Return res.ToInt32()
        End Function
    End Class
End Namespace