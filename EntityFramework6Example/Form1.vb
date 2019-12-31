Imports EntityFramework6Example.Classes
Imports EntityFramework6Example.EntityClasses

Public Class Form1
    Private Operations As Operations = New Operations
    Private context As NorthWindAzureContext = New NorthWindAzureContext()
    Private BindingSource As BindingSource = New BindingSource()

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        gridView.AutoGenerateColumns = False
        BindingSource.DataSource = Operations.Customers(context)
        gridView.DataSource = BindingSource
        gridView.ExpandColumns()
    End Sub
End Class
