Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports System.Threading

Namespace WebApplication1
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	<KnownType(GetType(Item))> _
	Public Class Service1
		Implements IService1
		Public Function GetData(ByVal skipCount As Integer, ByVal takeCount As Integer) As IEnumerable Implements IService1.GetData
			Dim endIndex As Integer = skipCount + takeCount
			Debug.WriteLine(String.Format("skipCount={0}, takeCount={1}", skipCount, takeCount))
			Dim items As New List(Of Item)()
			For i As Integer = skipCount To endIndex - 1
				items.Add(New Item With {.Id = i, .Name = "Name" & i})
			Next i
			Return items
        End Function
        Public Function Count() As Integer Implements IService1.Count
            Return 1000
        End Function
	End Class
	Public Class Item
		Implements IItem
		Private privateId As Integer
		<DataMember> _
		Public Property Id() As Integer Implements IItem.Id
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateName As String
        <DataMember> _
        Public Property Name() As String Implements IItem.Name
            Get
                Return privateName
            End Get
            Set(ByVal value As String)
                privateName = value
            End Set
        End Property
	End Class
End Namespace