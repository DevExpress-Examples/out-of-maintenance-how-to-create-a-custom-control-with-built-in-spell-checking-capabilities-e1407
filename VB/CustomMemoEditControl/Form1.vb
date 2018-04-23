Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CustomControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			DevExpress.XtraSpellChecker.Native.SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomControl.MyMemoEdit), GetType(DevExpress.XtraSpellChecker.Native.SimpleTextEditTextController))
			DevExpress.XtraSpellChecker.Native.SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(CustomControl.MyMemoEdit), GetType(DevExpress.XtraSpellChecker.Native.MemoEditTextBoxFinder))

			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myMemoEdit1.Text = "The quik onyx gobleen jumps over the laizy dvarf"
			myMemoEdit1.DeselectAll()

			memoEdit1.Text = "The quik onyx gobleen jumps over the laizy dvarf"
		End Sub


	End Class
End Namespace