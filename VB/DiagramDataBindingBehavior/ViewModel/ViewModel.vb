Imports DiagramDataBindingBehavior.Data
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DiagramDataBindingBehavior.ViewModel

	Public Class ViewModel
		Public Property ClassSource() As List(Of ClassData)
		Public Property ConnectionSource() As List(Of ConnectionData)

		Public Sub New()
			ClassSource = ClassStructureGenerator.ClassList()
			ConnectionSource = ClassStructureGenerator.ConnectionList()
		End Sub
	End Class
End Namespace
