Imports butika.Models

Public Class StockRequestForm

    Public Sub New(medicine As Medicine)
        InitializeComponent()
        Me.MedicineInfo = medicine
    End Sub

    Public Property MedicineInfo As Medicine
    Dim medRep As New MedicineRepository

    Private Sub StockRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submit_request.Enabled = False
        submit_request.Visible = False

        cancel_edit.Visible = False
        cancel_edit.Enabled = False

        stock_txtbox.ReadOnly = True


        If MedicineInfo IsNot Nothing Then
            stock_txtbox.Text = MedicineInfo.MedicineStock
        End If
    End Sub

    Private Async Sub edit_stock_Click(sender As Object, e As EventArgs) Handles edit_stock.Click
        Dim isDuplicate = Await medRep.IsDuplicateStockRequest(MedicineInfo.MedicineID)
        If isDuplicate = False Then
            submit_request.Enabled = True
            submit_request.Visible = True

            edit_stock.Visible = False
            edit_stock.Enabled = False

            cancel_edit.Visible = True
            cancel_edit.Enabled = True

            stock_txtbox.ReadOnly = False
        Else
            MessageBox.Show("Duplicate stock request found. Please wait for admin to approve your request before submitting.", "Duplicate Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cancel_edit_Click(sender As Object, e As EventArgs) Handles cancel_edit.Click
        submit_request.Enabled = False
        submit_request.Visible = False

        edit_stock.Visible = True
        edit_stock.Enabled = True

        cancel_edit.Visible = False
        cancel_edit.Enabled = False

        stock_txtbox.ReadOnly = True
        stock_txtbox.Text = MedicineInfo.MedicineStock
    End Sub

    Private Sub stock_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stock_txtbox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Async Sub submit_request_Click(sender As Object, e As EventArgs) Handles submit_request.Click
        If String.IsNullOrWhiteSpace(stock_txtbox.Text) Then
            MessageBox.Show("Input quantity first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Submit stock request?", "Stock Request Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MedicineInfo.StockQuantityRequest = Integer.Parse(stock_txtbox.Text)
                Await medRep.SubmitStockRequest(MedicineInfo)
                MessageBox.Show("Stock request submitted to admin.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
End Class