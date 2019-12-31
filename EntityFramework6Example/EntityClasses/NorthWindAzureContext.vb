Imports System.Data.Entity

Namespace EntityClasses

    Partial Public Class NorthWindAzureContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=NorthWindAzureContext")
        End Sub

        Public Overridable Property Contacts As DbSet(Of Contact)
        Public Overridable Property ContactTypes As DbSet(Of ContactType)
        Public Overridable Property Countries As DbSet(Of Country)
        Public Overridable Property Customers As DbSet(Of Customer)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Contact)() _
                .HasMany(Function(e) e.Customers) _
                .WithOptional(Function(e) e.Contact) _
                .WillCascadeOnDelete()

            modelBuilder.Entity(Of ContactType)() _
                .HasMany(Function(e) e.Customers) _
                .WithOptional(Function(e) e.ContactType) _
                .WillCascadeOnDelete()
        End Sub
    End Class

End Namespace