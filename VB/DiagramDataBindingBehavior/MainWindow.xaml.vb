Imports DiagramDataBindingBehavior.Data
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DiagramDataBindingBehavior
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DiagramDataBindingBehavior_GenerateItem(ByVal sender As Object, ByVal e As DevExpress.Xpf.Diagram.DiagramGenerateItemEventArgs)
			If CType(e.DataObject, ClassData).Type = ClassType.Interface Then
				e.Item = e.CreateItemFromTemplate("InterfaceShape")
			Else
				e.Item = e.CreateItemFromTemplate("ClassShape")
			End If
		End Sub

		Private Sub DiagramDataBindingBehavior_GenerateConnector(ByVal sender As Object, ByVal e As DevExpress.Xpf.Diagram.DiagramGenerateConnectorEventArgs)
			If CType(e.From, ClassData).Type = ClassType.Interface OrElse CType(e.To, ClassData).Type = ClassType.Interface Then
				e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector")
			Else
				e.Connector = e.CreateConnectorFromTemplate("ClassConnector")
			End If
		End Sub
	End Class
End Namespace
