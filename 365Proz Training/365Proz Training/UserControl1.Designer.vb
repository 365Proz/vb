<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.titleLablel = New System.Windows.Forms.Label()
        Me.changeColour = New System.Windows.Forms.Button()
        Me.changeText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLablel
        '
        Me.titleLablel.AutoSize = True
        Me.titleLablel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLablel.Location = New System.Drawing.Point(166, 16)
        Me.titleLablel.Name = "titleLablel"
        Me.titleLablel.Size = New System.Drawing.Size(294, 31)
        Me.titleLablel.TabIndex = 0
        Me.titleLablel.Text = "365 Training Program"
        '
        'changeColour
        '
        Me.changeColour.Location = New System.Drawing.Point(253, 75)
        Me.changeColour.Name = "changeColour"
        Me.changeColour.Size = New System.Drawing.Size(118, 23)
        Me.changeColour.TabIndex = 1
        Me.changeColour.Text = "Change Colour"
        Me.changeColour.UseVisualStyleBackColor = True
        '
        'changeText
        '
        Me.changeText.Location = New System.Drawing.Point(253, 115)
        Me.changeText.Name = "changeText"
        Me.changeText.Size = New System.Drawing.Size(118, 23)
        Me.changeText.TabIndex = 2
        Me.changeText.Text = "Change Text"
        Me.changeText.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.changeText)
        Me.Controls.Add(Me.changeColour)
        Me.Controls.Add(Me.titleLablel)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(662, 192)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLablel As Label
    Friend WithEvents changeColour As Button
    Friend WithEvents changeText As Button
End Class
