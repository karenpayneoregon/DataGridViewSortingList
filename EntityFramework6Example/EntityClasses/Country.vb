Imports System.ComponentModel.DataAnnotations

Namespace EntityClasses

    Partial Public Class Country
        Public Sub New()
            Customers = New HashSet(Of Customer)()
        End Sub

        <Key>
        Public Property CountryIdentifier As Integer
        Public Property Name As String
        Public Overridable Property Customers As ICollection(Of Customer)
    End Class
End Namespace