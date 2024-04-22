Imports System.Configuration
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