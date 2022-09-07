<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtPlay1 = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnStart.Font = New System.Drawing.Font("Ink Free", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(131, 207)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(500, 100)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnInstructions.Font = New System.Drawing.Font("Ink Free", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.White
        Me.btnInstructions.Location = New System.Drawing.Point(983, 207)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(500, 100)
        Me.btnInstructions.TabIndex = 1
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Sports"})
        Me.ComboBox1.Location = New System.Drawing.Point(131, 547)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(600, 73)
        Me.ComboBox1.TabIndex = 2
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BackColor = System.Drawing.Color.Transparent
        Me.lblChoose.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.ForeColor = System.Drawing.Color.White
        Me.lblChoose.Location = New System.Drawing.Point(202, 450)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(429, 65)
        Me.lblChoose.TabIndex = 3
        Me.lblChoose.Text = "Choose Category:"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnQuit.Font = New System.Drawing.Font("Ink Free", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(1418, 758)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(200, 50)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit Game"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'txtPlay1
        '
        Me.txtPlay1.BackColor = System.Drawing.Color.White
        Me.txtPlay1.Font = New System.Drawing.Font("Ink Free", 16.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay1.Location = New System.Drawing.Point(883, 543)
        Me.txtPlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlay1.Name = "txtPlay1"
        Me.txtPlay1.Size = New System.Drawing.Size(600, 61)
        Me.txtPlay1.TabIndex = 6
        Me.txtPlay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(940, 450)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(483, 65)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Enter Player Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.gZv7nv9
        Me.ClientSize = New System.Drawing.Size(1630, 820)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPlay1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblChoose As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtPlay1 As TextBox
    Friend WithEvents lblName As Label
End Class
