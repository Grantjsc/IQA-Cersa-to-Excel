Imports System.Runtime.InteropServices
Imports System.Threading
Imports Microsoft.Office.Interop

Public Class Form1

    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorksheet As Excel.Worksheet

    'Dim xlApp As Object
    'Dim xlWorkbook As Object
    'Dim xlWorksheet As Object

    'Public Sub InputToExcel()
    '    ' Get the existing instance of Excel
    '    Try
    '        xlApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application")
    '    Catch ex As Exception
    '        MessageBox.Show("Excel is not running.")
    '        Return
    '    End Try

    '    ' Activate the workbook
    '    xlWorkbook = xlApp.ActiveWorkbook
    '    If xlWorkbook Is Nothing Then
    '        MessageBox.Show("No workbook is active in Excel.")
    '        Return
    '    End If

    '    ' Activate the worksheet
    '    xlWorksheet = xlWorkbook.ActiveSheet

    '    '*********** Pasting in Selected Cell **************
    '    If txtReading.Text = 0 Then

    '    Else
    '        Dim ToExcel As String = txtCoversion.Text
    '        xlApp.ActiveCell.Value = ToExcel 'paste to excel
    '        xlApp.ActiveCell.Offset(1, 0).Select() 'Move to next cell
    '    End If

    '    'Dim ToExcel As String = txtReading.Text
    '    'xlApp.ActiveCell.Value = ToExcel 'paste to excel
    '    'xlApp.ActiveCell.Offset(1, 0).Select() 'Move to next cell
    'End Sub

    Private Sub InputToExcel()
        ' Check if Excel is running
        If Not IsExcelRunning() Then
            MessageBox.Show("Excel is not running.")
            Return
        End If

        ' Try to get the existing instance of Excel
        Try
            xlApp = Marshal.GetActiveObject("Excel.Application")
        Catch ex As Exception
            ' If Excel is not running, create a new instance
            Try
                xlApp = CreateObject("Excel.Application")
            Catch exc As Exception
                MessageBox.Show("Error creating Excel instance: " & exc.Message)
                Return
            End Try
        End Try

        ' Check if xlApp is Nothing
        If xlApp Is Nothing Then
            MessageBox.Show("Unable to get the Excel application instance.")
            Return
        End If

        ' Wait for Excel to fully initialize
        Thread.Sleep(500)

        ' Activate the workbook
        Try
            xlWorkbook = xlApp.ActiveWorkbook
            If xlWorkbook Is Nothing Then
                MessageBox.Show("No workbook is active in Excel.")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing workbook: " & ex.Message)
            Return
        End Try

        ' Activate the worksheet
        Try
            xlWorksheet = xlWorkbook.ActiveSheet
        Catch ex As Exception
            MessageBox.Show("Error accessing worksheet: " & ex.Message)
            Return
        End Try

        ' Pasting in selected cell
        Try
            Dim toExcel As String = txtCoversion.Text
            xlApp.ActiveCell.Value = toExcel ' Paste to Excel
            xlApp.ActiveCell.Offset(1, 0).Select() ' Move to next cell
        Catch ex As Exception
            MessageBox.Show("Error pasting into Excel: " & ex.Message)
        End Try
    End Sub

    Private Function IsExcelRunning() As Boolean
        ' Check if Excel is running by attempting to get the active object
        Try
            Dim obj As Object = Marshal.GetActiveObject("Excel.Application")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub CersaCommand()
        Try

            Dim dataToSend() As Byte = {&H26, &H1, &H52}
            SerialPort1.Write(dataToSend, 0, dataToSend.Length)

            Thread.Sleep(400)

            Dim dataToSend2() As Byte = {&H3E, &HE4, &H0, &H0, &H0, &H0, &H0, &H0}
            SerialPort1.Write(dataToSend2, 0, dataToSend2.Length)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialName()
        SerialPort1.PortName = Serial1
        btnGo.Enabled = False
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If Not SerialPort1.IsOpen Then
            SerialPort1.Open()
        End If
        CersaCommand()
        'InputToExcel()
    End Sub

    Private Sub ChangeSerialNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSerialNameToolStripMenuItem.Click
        MSChangeSerial()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim byteString As String = ""
            Dim reString As String
            Dim FinalValue As String

            Dim buffer(0 To 32) As Byte
            SerialPort1.Read(buffer, 0, 32)

            For Each b As Byte In buffer

                Console.Write(b.ToString("X2") & " ")
                byteString &= b.ToString("X2")

            Next
            Invoke(Sub()

                       reString = byteString.Substring(8, 8)
                       TextBox1.Text = reString
                       Dim convertedVal As Integer = Convert.ToInt32(reString, 16)
                       FinalValue = convertedVal.ToString("N0")
                       FinalValue = FinalValue.Replace(",", ".")
                       txtReading.Text = FinalValue

                   End Sub)
            Console.WriteLine()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Invoke(Sub()
                   ReaLValue()
                   InputToExcel()
               End Sub)
    End Sub

    Private Sub txtPartNumber_Enter(sender As Object, e As EventArgs) Handles txtPartNumber.Enter
        If txtPartNumber.Text = "Enter part number" Then
            txtPartNumber.Text = ""
            txtPartNumber.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPartNumber_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPartNumber.KeyUp
        If e.KeyCode = Keys.Enter Then
            GetPartNumber()
        End If
    End Sub

    Private Sub txtPartNumber_Leave(sender As Object, e As EventArgs) Handles txtPartNumber.Leave
        If txtPartNumber.Text = "" Then
            txtPartNumber.Text = "Enter part number"
            txtPartNumber.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If txtPartNumber.Text = "Enter part number" Or txtPartNumber.Text = "" Then
            MsgBox("There is no data to clear!", MsgBoxStyle.Information)
        Else
            txtPartNumber.Text = "Enter part number"
            txtPartNumber.ForeColor = Color.Silver

            txtReading.Text = ""
            txtCoversion.Text = ""
            txtPartNumber.Focus()
            txtPartNumber.ReadOnly = False
            btnGo.Enabled = False

            lblUoM.Text = "UoM"
        End If
    End Sub

    Private Sub btnGo_KeyUp(sender As Object, e As KeyEventArgs) Handles btnGo.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Not SerialPort1.IsOpen Then
                SerialPort1.Open()
            End If
            CersaCommand()
        End If
    End Sub
End Class
