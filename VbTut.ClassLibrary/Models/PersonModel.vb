Public Class PersonModel
    ' private members
    Private _firstName As String
    Private _lastName As String


    ' Properties
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property 'FirstName

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property 'LastName



End Class
