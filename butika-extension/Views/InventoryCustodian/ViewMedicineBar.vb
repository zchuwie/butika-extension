Public Class ViewMedicineBar
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub edit_medicine_btn_Click(sender As Object, e As EventArgs) Handles edit_medicine_btn.Click
        edit_medicine_btn.Visible = False
        edit_medicine_btn.Enabled = False

        cancel_update_btn.Enabled = True
        cancel_update_btn.Visible = True

        save_update_btn.Enabled = True
        save_update_btn.Visible = True
    End Sub

    Private Sub cancel_update_btn_Click(sender As Object, e As EventArgs) Handles cancel_update_btn.Click
        edit_medicine_btn.Visible = True
        edit_medicine_btn.Enabled = True

        cancel_update_btn.Enabled = False
        cancel_update_btn.Visible = False

        save_update_btn.Enabled = False
        save_update_btn.Visible = False
    End Sub
End Class