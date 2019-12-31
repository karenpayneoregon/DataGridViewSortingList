Imports EntityFramework6Example.Classes
Imports EntityFramework6Example.EntityClasses

Namespace Forms
    Public Class NoSortingByDefaultForm
        Private Operations As Operations = New Operations
        Private context As NorthWindAzureContext = New NorthWindAzureContext()
        Private BindingSource As BindingSource = New BindingSource()

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            gridView.AutoGenerateColumns = False

            BindingSource.DataSource = Operations.Customers(context)
            gridView.DataSource = BindingSource

            gridView.ExpandColumns()

            Label1.Text = $"Supports sorting: {BindingSource.SupportsSorting}"


        End Sub

        Private Sub CurrentRowButton_Click(sender As Object, e As EventArgs) Handles CurrentRowButton.Click
            Dim current As CustomerEntity = CType(BindingSource.Current, CustomerEntity)
            Console.WriteLine(current.CompanyName)
        End Sub

#Region "Will not work as the underlying source does not support sorting"

        Private Sub gridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridView.ColumnHeaderMouseClick
            Exit Sub
            Dim col = gridView.Columns(e.ColumnIndex)
            Dim dir As System.ComponentModel.ListSortDirection

            Select Case col.HeaderCell.SortGlyphDirection
                Case SortOrder.None, SortOrder.Ascending
                    dir = ComponentModel.ListSortDirection.Ascending
                Case Else
                    dir = ComponentModel.ListSortDirection.Descending
            End Select

            gridView.Sort(col, dir)

        End Sub

        Private Sub gridView_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles gridView.SortCompare
            Exit Sub
            If e.Column.Name = "CompanyName" Then
                e.SortResult = Date.Compare(CType(e.CellValue1, Date), CType(e.CellValue2, Date))

                e.Handled = True
            End If
        End Sub

#End Region
    End Class
End Namespace