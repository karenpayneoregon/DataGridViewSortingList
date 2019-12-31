Imports EntityFramework6Example.EntityClasses

Namespace Classes
    Public Class Operations

        ''' <summary>
        ''' Read in data from the Customer table joining in Contact and ContactType tables.
        ''' </summary>
        ''' <param name="context">DbContext created in the main form</param>
        ''' <returns>List(Of CustomerEntity)</returns>
        Public Function Customers(context As NorthWindAzureContext) As List(Of CustomerEntity)


            Dim customerData = (
                    From customer In context.Customers
                    Join contactType In context.ContactTypes On customer.ContactTypeIdentifier Equals contactType.ContactTypeIdentifier
                    Join contact In context.Contacts On customer.ContactId Equals contact.ContactId
                    Select New CustomerEntity With {
                        .CustomerIdentifier = customer.CustomerIdentifier,
                        .CompanyName = customer.CompanyName,
                        .ContactIdentifier = customer.ContactId,
                        .FirstName = contact.FirstName,
                        .LastName = contact.LastName,
                        .ContactTypeIdentifier = contactType.ContactTypeIdentifier,
                        .ContactTitle = contactType.ContactTitle,
                        .Address = customer.Address,
                        .City = customer.City,
                        .PostalCode = customer.PostalCode,
                        .CountryIdentifier = customer.CountryIdentifier,
                        .CountyName = customer.Country.Name
                    }).ToList()


            Return customerData

        End Function

    End Class
End Namespace