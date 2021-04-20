<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Result1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Result2 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Result3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Result4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(34, 36)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Click"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Result1
        '
        Me.Result1.AutoSize = True
        Me.Result1.Location = New System.Drawing.Point(44, 92)
        Me.Result1.Name = "Result1"
        Me.Result1.Size = New System.Drawing.Size(48, 17)
        Me.Result1.TabIndex = 1
        Me.Result1.Text = "Result"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(189, 90)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "Click"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Result2
        '
        Me.Result2.AutoSize = True
        Me.Result2.Location = New System.Drawing.Point(196, 137)
        Me.Result2.Name = "Result2"
        Me.Result2.Size = New System.Drawing.Size(48, 17)
        Me.Result2.TabIndex = 4
        Me.Result2.Text = "Result"
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(337, 36)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 5
        Me.Btn3.Text = "Click"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Result3
        '
        Me.Result3.AutoSize = True
        Me.Result3.Location = New System.Drawing.Point(343, 90)
        Me.Result3.Name = "Result3"
        Me.Result3.Size = New System.Drawing.Size(48, 17)
        Me.Result3.TabIndex = 6
        Me.Result3.Text = "Result"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(474, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(488, 86)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 23)
        Me.Btn4.TabIndex = 8
        Me.Btn4.Text = "Click"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Result4
        '
        Me.Result4.AutoSize = True
        Me.Result4.Location = New System.Drawing.Point(498, 137)
        Me.Result4.Name = "Result4"
        Me.Result4.Size = New System.Drawing.Size(48, 17)
        Me.Result4.TabIndex = 9
        Me.Result4.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 226)
        Me.Controls.Add(Me.Result4)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Result3)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Result2)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Result1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Result1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents Result2 As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents Result3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn4 As Button
    Friend WithEvents Result4 As Label
End Class
