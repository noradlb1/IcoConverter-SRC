Namespace IcoConverter
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.pictureBox3 = New System.Windows.Forms.PictureBox()
            Me.pictureBox4 = New System.Windows.Forms.PictureBox()
            Me.button2 = New System.Windows.Forms.Button()
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(12, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(68, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Open"
            Me.button1.UseVisualStyleBackColor = True
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            Me.openFileDialog1.Filter = """PNG""|*.png"
            '
            'pictureBox1
            '
            Me.pictureBox1.BackColor = System.Drawing.Color.White
            Me.pictureBox1.Location = New System.Drawing.Point(86, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(64, 64)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.BackColor = System.Drawing.Color.White
            Me.pictureBox2.Location = New System.Drawing.Point(156, 12)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(64, 64)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox2.TabIndex = 2
            Me.pictureBox2.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.BackColor = System.Drawing.Color.White
            Me.pictureBox3.Location = New System.Drawing.Point(226, 12)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(64, 64)
            Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox3.TabIndex = 3
            Me.pictureBox3.TabStop = False
            '
            'pictureBox4
            '
            Me.pictureBox4.BackColor = System.Drawing.Color.White
            Me.pictureBox4.Location = New System.Drawing.Point(296, 12)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(64, 64)
            Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox4.TabIndex = 4
            Me.pictureBox4.TabStop = False
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(12, 51)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(68, 24)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Save"
            Me.button2.UseVisualStyleBackColor = True
            '
            'saveFileDialog1
            '
            Me.saveFileDialog1.Filter = """ICON""|*.ico"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(367, 87)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.pictureBox4)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "by monstermc"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	End Class
End Namespace

