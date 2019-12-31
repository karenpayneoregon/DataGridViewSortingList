Imports DataComponentLibrary
Imports EntityFramework6Example.Classes
Imports EntityFramework6Example.EntityClasses

Namespace Forms

    ''' <summary>
    ''' Example using a custom BindingList to implement sorting
    ''' </summary>
    Public Class GenericSortForm
        Private Operations As Operations = New Operations
        Private context As NorthWindAzureContext = New NorthWindAzureContext()
        Private BindingSource As BindingSource = New BindingSource()
        Private BindingCustomers As SortableBindingList(Of CustomerEntity)

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            gridView.AutoGenerateColumns = False
            '
            ' This is all that is needed to display data
            '
            BindingSource.DataSource = New SortableBindingList(Of CustomerEntity)(Operations.Customers(context))
            '
            ' This allow access to individual rows and properties
            '
            BindingCustomers = CType(BindingSource.DataSource, SortableBindingList(Of CustomerEntity))
            gridView.DataSource = BindingSource

            gridView.ExpandColumns()

            Label1.Text = $"Supports sorting: {BindingSource.SupportsSorting}"

        End Sub

        Private Sub CurrentRowButton_Click(sender As Object, e As EventArgs) Handles CurrentRowButton.Click
            Dim current As CustomerEntity = BindingCustomers.Item(BindingSource.Position)
            MessageBox.Show($"Current key: {current.ContactIdentifier} for customer: {current.CompanyName}")
        End Sub
    End Class
End Namespace