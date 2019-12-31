Imports EntityFramework6Example.Forms

Public Class MainForm
    Private Sub LoadNormalWithoutSortingButton_Click(sender As Object, e As EventArgs) Handles LoadNormalWithoutSortingButton.Click
        Dim form As New NoSortingByDefaultForm
        form.ShowDialog()
    End Sub

    Private Sub LoadDataConvertToDataTableButton_Click(sender As Object, e As EventArgs) Handles LoadDataConvertToDataTableButton.Click
        Dim form As New ConvertSourceToSortForm
        form.ShowDialog()
    End Sub

    Private Sub LoadDataSortWithBindingListButton_Click(sender As Object, e As EventArgs) Handles LoadDataSortWithBindingListButton.Click
        Dim form As New GenericSortForm
        form.ShowDialog()
    End Sub
End Class