Imports System
Imports System.Windows.Forms

Namespace WinPivot_GettingStarted

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            'UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI);
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
