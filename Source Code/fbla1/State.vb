
'Programmer: Innocent Niyibizi
'Date: 2-1-15
'Purpose: Class that holds information for each state in the database

Public Class State

#Region "Data Members"
    Private studs As List(Of studentClass) = New List(Of studentClass)
    Private activeMembers As Integer
    Private nonActiveMembers As Integer
    Private totalAmount As Double
    Private totalOwing As Integer
    Private name As String
#End Region

    Public Sub New()

    End Sub
    Public Sub New(newName)
        name = newName
    End Sub

#Region "Properties"

    Public Property Students As List(Of studentClass)
        Get
            Return studs
        End Get
        Set(value As List(Of studentClass))

        End Set
    End Property

    Public Property Active As Integer
        Get
            Return activeMembers
        End Get
        Set(value As Integer)
            activeMembers = value
        End Set
    End Property

    Public Property NonActive As Integer
        Get
            Return nonActiveMembers
        End Get
        Set(value As Integer)
            nonActiveMembers = value
        End Set
    End Property

    Public Property TotalAmnt As Double
        Get
            Return totalAmount
        End Get
        Set(value As Double)
            totalAmount = value
        End Set
    End Property

    Public Property StudentsOwing As Integer
        Get
            Return totalOwing
        End Get
        Set(value As Integer)
            totalOwing = value
        End Set
    End Property

    Public Property StateName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
#End Region

End Class
