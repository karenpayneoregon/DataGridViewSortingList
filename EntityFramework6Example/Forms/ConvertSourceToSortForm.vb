Imports EntityFramework6Example.Classes
Imports EntityFramework6Example.EntityClasses
Imports EntityFramework6Example.LanguageExtensions

Namespace Forms

    ''' <summary>
    ''' Provides sorting by creating a DataTable from a list of CustomerEntity class
    ''' </summary>
    Public Class ConvertSourceToSortForm
        Private Operations As Operations = New Operations
        Private context As NorthWindAzureContext = New NorthWindAzureContext()
        Private BindingSource As BindingSource = New BindingSource()

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            gridView.AutoGenerateColumns = False

            BindingSource.DataSource = Operations.Customers(context).ToDataTable()
            gridView.DataSource = BindingSource

            gridView.ExpandColumns()

            Label1.Text = $"Supports sorting: {BindingSource.SupportsSorting}"

        End Sub

        Private Sub CurrentRowButton_Click(sender As Object, e As EventArgs) Handles CurrentRowButton.Click

            Dim currentRow = CType(BindingSource.Current, DataRowView).Row
            MessageBox.Show($"Current key: {currentRow.Field(Of Integer)("ContactIdentifier")} for customer " &
                            $"{currentRow.Field(Of String)("CompanyName")}")
        End Sub
    End Class
End Namespace