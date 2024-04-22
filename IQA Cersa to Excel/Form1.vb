Imports System.Threading
Imports Microsoft.Office.Interop

Public Class Form1

    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorksheet As Excel.Worksheet

    Public Sub InputToExcel()
        ' Get the existing instance of Excel
        Try
            xlApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application")
        Catch ex As Exception
            MessageBox.Show("Excel is not running.")
            Return
        End Try

        ' Activate the workbook
        xlWorkbook = xlApp.ActiveWorkbook
        If xlWorkbook Is Nothing Then
            MessageBox.Show("No workbook is active in Excel.")
            Return
        End If

        ' Activate the worksheet
        xlWorksheet = xlWorkbook.ActiveSheet

        '*********** Pasting in Selected Cell **************
        If txtReading.Text = 0 Then

        Else
            Dim ToExcel As String = txtReading.Text
            xlApp.ActiveCell.Value = ToExcel 'paste to excel
            xlApp.ActiveCell.Offset(1, 0).Select() 'Move to next cell
        End If

        'Dim ToExcel As String = txtReading.Text
        'xlApp.ActiveCell.Value = ToExcel 'paste to excel
        'xlApp.ActiveCell.Offset(1, 0).Select() 'Move to next cell
    End Sub

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

        InputToExcel()
    End Sub
End Class
