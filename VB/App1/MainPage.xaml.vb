Imports DevExpress.Core
Imports App1.ServiceReference1

Public NotInheritable Class MainPage
    Inherits Page
    Private Service1 As New Service1Client()

    Public Property Items() As AsyncCollection(Of Item)
        Get
            Return m_Items
        End Get
        Set(value As AsyncCollection(Of Item))
            m_Items = value
        End Set
    End Property
    Private m_Items As AsyncCollection(Of Item)

    Public Sub New()
        Me.InitializeComponent()

        Items = New AsyncCollection(Of Item)(
            Async Function()
                Return Await Service1.CountAsync()
            End Function,
            Async Function(skipCount As Integer, takeCount As Integer)
                Return Await Service1.GetDataAsync(skipCount, takeCount)
            End Function)

        grid.ItemsSource = Items
    End Sub

End Class
