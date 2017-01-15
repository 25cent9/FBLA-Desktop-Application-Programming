
'Programmer: Innocent Niyibizi
'Date: 1-15-16
'Purpose: Class that will hold the basic information of the student 

Public Class studentClass

#Region "Variables"
    Private memberNumber As Integer
    Private fName As String
    Private lName As String
    Private skool As String
    Private state As String
    Private email As String
    Private yrJoined As Integer
    Private amtOwed As Double
    Private active As String
    Private gradeLevel As Byte

#End Region

#Region "Constructors"
    'Default constructor
    Public Sub New()
        memberNumber = 0
        fName = ""
        lName = ""
        skool = ""
        state = ""
        email = ""
        yrJoined = 0
        amtOwed = 0D
        active = ""
        gradeLevel = 0
    End Sub

    'Overloaded constuctor 
    Public Sub New(num, Fn, Ln, Sc, St, Em, Yr, amnt, Act, grade)

        memberNumber = num
        fName = Fn
        lName = Ln
        skool = Sc
        state = St
        email = Em
        yrJoined = Yr
        amtOwed = amnt
        active = Act
        gradeLevel = grade
    End Sub
#End Region

    'Getters
    'All are read only for now 
#Region "Properties"
    Public ReadOnly Property number As Integer

        Get
            Return memberNumber
        End Get
    End Property
    Public ReadOnly Property firstName As String

        Get
            Return fName
        End Get
    End Property
    Public ReadOnly Property lastName As String

        Get
            Return lName
        End Get

    End Property
    Public ReadOnly Property school As String

        Get
            Return skool
        End Get
    End Property
    Public ReadOnly Property st As String

        Get
            Return state
        End Get
    End Property
    Public ReadOnly Property mail As String

        Get
            Return email
        End Get
    End Property
    Public ReadOnly Property yrJ As Integer

        Get
            Return yrJoined
        End Get
    End Property
    Public ReadOnly Property amount As Double

        Get
            Return amtOwed
        End Get
    End Property
    Public ReadOnly Property activ As String

        Get
            Return active
        End Get
    End Property
    Public ReadOnly Property gradeLvl As Byte
        Get
            Return gradeLevel
        End Get
    End Property
#End Region

End Class
