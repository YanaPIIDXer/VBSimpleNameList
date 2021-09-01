Public Class Person
    ' ID
    Private _id As Integer
    Public ReadOnly Property Id() As Integer
        Get
            Return _id
        End Get
    End Property

    ' 苗字
    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    ' 名前
    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    ' コンストラクタ
    Sub New(id As Integer, lastName As String, firstName As String)
        _id = id
        _lastName = lastName
        _firstName = firstName
    End Sub

    ' ToString
    ' 「苗字 + " " + 名前」の形で返す
    Public Overrides Function ToString() As String
        Return _lastName + " " + _firstName
    End Function
End Class
