Imports System.Windows

Namespace DXMapLesson2
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnWebRequest(ByVal sender As Object, ByVal e As DevExpress.Xpf.Map.MapWebRequestEventArgs)
			e.UserAgent = "DevExpress OpenStreetMapProvider example"
		End Sub
	End Class
End Namespace
