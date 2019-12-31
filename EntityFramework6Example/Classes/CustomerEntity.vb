Namespace Classes
    ''' <summary>
    ''' Container for a Operations.Customers method to read Custom data
    ''' using LINQ with joins on contactType and contact
    ''' </summary>
    Public Class CustomerEntity
        Public Property CustomerIdentifier() As Integer
        Public Property CompanyName() As String
        Public Property ContactIdentifier() As Integer?
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property ContactTypeIdentifier() As Integer
        Public Property ContactTitle() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property PostalCode() As String
        Public Property CountryIdentifier() As Integer?
        Public Property CountyName() As String

        Public Overrides Function ToString() As String
            Return $"{CompanyName}"
        End Function
    End Class
End Namespace