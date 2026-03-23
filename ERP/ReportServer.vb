Public Module ReportServer

    Private _reportServerURI As String = "http://feap-chronos:83"
    Private _reportServerUser As String = "reportViewer"
    Private _reportServerPwd As String = "WebSlinger15"

    Public ReadOnly Property reportServerURI() As String
        Get
            Return _reportServerURI
        End Get
    End Property

    Public ReadOnly Property reportServerUser() As String
        Get
            Return _reportServerUser
        End Get
    End Property

    Public ReadOnly Property reportServerPwd() As String
        Get
            Return _reportServerPwd
        End Get
    End Property

End Module
