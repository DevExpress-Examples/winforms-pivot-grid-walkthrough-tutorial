Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace WinPivot_GettingStarted
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			'UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI);
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
