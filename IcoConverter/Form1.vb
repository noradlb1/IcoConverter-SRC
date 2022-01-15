Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
'by monstermc
Namespace IcoConverter
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			openFileDialog1.ShowDialog()

		End Sub

		Private Sub openFileDialog1_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs) Handles openFileDialog1.FileOk
			If pictureBox1.ImageLocation Is Nothing Then
				pictureBox1.ImageLocation = openFileDialog1.FileName
			ElseIf pictureBox2.ImageLocation Is Nothing Then
				pictureBox2.ImageLocation = openFileDialog1.FileName
			ElseIf pictureBox3.ImageLocation Is Nothing Then
				pictureBox3.ImageLocation = openFileDialog1.FileName
			ElseIf pictureBox4.ImageLocation Is Nothing Then
				pictureBox4.ImageLocation = openFileDialog1.FileName
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			saveFileDialog1.ShowDialog()
		End Sub

		Private Sub saveFileDialog1_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs) Handles saveFileDialog1.FileOk
			Dim paths(3) As String
			paths(0) = pictureBox1.ImageLocation
			paths(1) = pictureBox2.ImageLocation
			paths(2) = pictureBox3.ImageLocation
			paths(3) = pictureBox4.ImageLocation
			IcoFileConverter.ConvertToIco(paths,saveFileDialog1.FileName)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
