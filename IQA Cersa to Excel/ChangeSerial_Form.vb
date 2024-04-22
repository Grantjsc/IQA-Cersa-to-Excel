Public Class ChangeSerial_Form

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonSaveSerial()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ChangeSerial_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComPort()
    End Sub
End Class