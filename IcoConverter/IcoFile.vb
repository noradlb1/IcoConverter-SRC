Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Namespace IcoConverter
	Public NotInheritable Class IcoFileConverter

		Private Sub New()
		End Sub

		Public Shared Sub ConvertToIco(ByVal pngPaths() As String, ByVal savePath As String)
			Dim pngBytes As New List(Of Byte())()
			For i As Integer = 0 To 3
				If pngPaths(i) IsNot Nothing Then
					Dim readStream As Stream = New FileStream(pngPaths(i), FileMode.Open)
					Dim reader As New BinaryReader(readStream)
					pngBytes.Add(reader.ReadBytes(CInt(readStream.Length)))
					readStream.Close()
				End If
			Next i

			Dim saveStream As Stream = New FileStream(savePath, FileMode.Create)
			Dim writer As New BinaryWriter(saveStream)

			writer.Write(CUShort(0)) 'constant
			writer.Write(CUShort(1)) '1=ico 2=cur (cursor .CUR)
			writer.Write(CUShort(pngBytes.Count)) 'number of images
			'foreach image
			Dim offset As Integer = 6 + 16 * pngBytes.Count
			For i As Integer = 0 To pngBytes.Count - 1
				Dim bitmap As New Bitmap(pngPaths(i))
				writer.Write(CByte(bitmap.Width)) 'imageWidth
				writer.Write(CByte(bitmap.Height)) 'ImageHeight
				writer.Write(CByte(0)) 'number of palette colors
				writer.Write(CByte(0)) 'constant
				writer.Write(CUShort(0)) 'Color planes?
				writer.Write(CUShort(32)) 'bits per pixel
				writer.Write(CInt(pngBytes(i).Length)) 'data lenght
				writer.Write(CInt(offset)) 'data offset
				offset += pngBytes(i).Length
			Next i
			For i As Integer = 0 To pngBytes.Count - 1
				writer.Write(pngBytes(i)) 'data offset
			Next i
			saveStream.Close()
		End Sub
	End Class
End Namespace
