Public Class BETriangulo

    Private mLado1 As Integer
    Public Property Lado1() As Integer
        Get
            Return mLado1
        End Get
        Set(ByVal value As Integer)
            mLado1 = value
        End Set
    End Property

    Private mLado2 As Integer
    Public Property Lado2() As Integer
        Get
            Return mLado2
        End Get
        Set(ByVal value As Integer)
            mLado2 = value
        End Set
    End Property

    Private mLado3 As Integer
    Public Property Lado3() As Integer
        Get
            Return mLado3
        End Get
        Set(ByVal value As Integer)
            mLado3 = value
        End Set
    End Property

    Private mSP As Integer
    Public Property SP() As Integer
        Get
            Return mSP
        End Get
        Set(ByVal value As Integer)
            mSP = value
        End Set
    End Property

    Private mArea As Integer
    Public Property Area() As Integer
        Get
            Return mArea
        End Get
        Set(ByVal value As Integer)
            mArea = value
        End Set
    End Property


End Class
