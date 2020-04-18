<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class readLabel
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
        Me.readFromFileButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.writeToFileButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'readFromFileButton
        '
        Me.readFromFileButton.Location = New System.Drawing.Point(12, 12)
        Me.readFromFileButton.Name = "readFromFileButton"
        Me.readFromFileButton.Size = New System.Drawing.Size(96, 23)
        Me.readFromFileButton.TabIndex = 0
        Me.readFromFileButton.Text = "Read From File"
        Me.readFromFileButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 462)
        Me.TextBox1.TabIndex = 1
        '
        'writeToFileButton
        '
        Me.writeToFileButton.Location = New System.Drawing.Point(12, 42)
        Me.writeToFileButton.Name = "writeToFileButton"
        Me.writeToFileButton.Size = New System.Drawing.Size(95, 23)
        Me.writeToFileButton.TabIndex = 2
        Me.writeToFileButton.Text = "Write To File"
        Me.writeToFileButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(13, 71)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(95, 23)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'readLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 495)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.writeToFileButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.readFromFileButton)
        Me.Name = "readLabel"
        Me.Text = "Text File Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents readFromFileButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents writeToFileButton As Button
    Friend WithEvents clearButton As Button
End Class
