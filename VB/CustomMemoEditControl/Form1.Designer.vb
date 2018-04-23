Imports Microsoft.VisualBasic
Imports System
Namespace CustomControl
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.myMemoEdit1 = New CustomControl.MyMemoEdit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myMemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(0, 167)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(400, 150)
			Me.memoEdit1.TabIndex = 1
			' 
			' myMemoEdit1
			' 
			Me.myMemoEdit1.Location = New System.Drawing.Point(0, 0)
			Me.myMemoEdit1.Name = "myMemoEdit1"
			Me.myMemoEdit1.Size = New System.Drawing.Size(400, 150)
			Me.myMemoEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(401, 319)
			Me.Controls.Add(Me.memoEdit1)
			Me.Controls.Add(Me.myMemoEdit1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myMemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myMemoEdit1 As MyMemoEdit
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

