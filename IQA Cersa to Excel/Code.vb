Imports System.Configuration
Imports System.Data.OleDb
Imports System.Dynamic
Imports System.IO.Ports

Module ChangeSerial_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Public Serial1 As String
    Public NewSerialName As String

    Sub GetSerialName()
        Dim serial As String = System.Configuration.ConfigurationManager.AppSettings("Serialname")
        Console.WriteLine(serial)

        Serial1 = serial
    End Sub

    Sub GetNewSerial()
        NewSerialName = ChangeSerial_Form.cboSerialList.Text
    End Sub

    Sub SaveChangesInSerial()
        config.AppSettings.Settings("Serialname").Value = NewSerialName ' Rewrite Mettlet Toledo Weighing Scale COM name
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub LoadComPort()

        Dim Serials As String() = SerialPort.GetPortNames()
        For Each portname As String In Serials
            ChangeSerial_Form.cboSerialList.Items.Add(portname)
        Next
    End Sub
    Sub ButtonSaveSerial()
        If ChangeSerial_Form.cboSerialList.Text = "" Then
            MsgBox("Please input serial name", MsgBoxStyle.Critical)
        Else
            GetNewSerial()
            SaveChangesInSerial()
        End If

        GetSerialName()
        Form1.SerialPort1.PortName = Serial1
        ChangeSerial_Form.Close()
    End Sub

End Module

Module Menustrip_Module
    Sub MSChangeSerial()
        With ChangeSerial_Form
            .TopLevel = False
            Form1.Panel1.Controls.Add(ChangeSerial_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub
End Module

Module Query_Module
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\IQA Tegam Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfIQAtegam"
    Public connection As New OleDbConnection(connString)

    Public UOM_Value As String
    Sub GetPartNumber()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            connection.Open()

            MyData = "SELECT * From PartNo_tb WHERE Part_Number = '" + Form1.txtPartNumber.Text + "'"
            cmd.Connection = connection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                UOM_Value = Data.Rows(0).Item("UOM").ToString
                Console.WriteLine(UOM_Value)

                Form1.txtPartNumber.ReadOnly = True
                Form1.btnGo.Enabled = True
                Form1.btnGo.Focus()

                Select Case UOM_Value.ToString

                    Case "Ohms/ft"
                        Form1.lblUoM.Text = "inch"

                    Case "Ohms/M"
                        Form1.lblUoM.Text = "mm"

                End Select

                If Not Form1.SerialPort1.IsOpen Then
                    Form1.SerialPort1.Open()
                End If
            Else
                MsgBox("Part number does not exist in the database.", MessageBoxIcon.Error)
                Form1.txtPartNumber.Text = ""
                Form1.txtPartNumber.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            connection.Close()
        End Try
    End Sub
End Module

Module Computation_Module
    Sub Ohms_ft()
        Dim Eq1 As String
        Eq1 = Form1.txtReading.Text * 0.00003937

        Form1.txtCoversion.Text = Math.Round(CDec(Eq1), 8)
    End Sub

    Sub Ohms_M()
        Dim Eq1 As String
        Eq1 = Form1.txtReading.Text * 0.001

        Form1.txtCoversion.Text = Math.Round(CDec(Eq1), 6)
    End Sub

End Module

Module Function_Module
    Sub ReaLValue()
        Select Case UOM_Value.ToString

            Case "Ohms/ft"
                If Form1.txtReading.Text = 0 Then

                Else
                    Form1.lblUoM.Text = "inch"
                    Ohms_ft()
                End If

            Case "Ohms/M"
                If Form1.txtReading.Text = 0 Then

                Else
                    Form1.lblUoM.Text = "mm"
                    Ohms_M()
                End If
        End Select
    End Sub
End Module