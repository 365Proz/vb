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
        Me.guessNoLablel = New System.Windows.Forms.Label()
        Me.guessNoText = New System.Windows.Forms.TextBox()
        Me.guessNoButton = New System.Windows.Forms.Button()
        Me.showNoButton = New System.Windows.Forms.Button()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'guessNoLablel
        '
        Me.guessNoLablel.AutoSize = True
        Me.guessNoLablel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guessNoLablel.Location = New System.Drawing.Point(172, 9)
        Me.guessNoLablel.Name = "guessNoLablel"
        Me.guessNoLablel.Size = New System.Drawing.Size(407, 31)
        Me.guessNoLablel.TabIndex = 0
        Me.guessNoLablel.Text = "Play Guess the Number Game"
        '
        'guessNoText
        '
        Me.guessNoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guessNoText.Location = New System.Drawing.Point(178, 78)
        Me.guessNoText.Name = "guessNoText"
        Me.guessNoText.Size = New System.Drawing.Size(160, 22)
        Me.guessNoText.TabIndex = 1
        '
        'guessNoButton
        '
        Me.guessNoButton.Location = New System.Drawing.Point(375, 78)
        Me.guessNoButton.Name = "guessNoButton"
        Me.guessNoButton.Size = New System.Drawing.Size(101, 23)
        Me.guessNoButton.TabIndex = 2
        Me.guessNoButton.Text = "Guess Number"
        Me.guessNoButton.UseVisualStyleBackColor = True
        '
        'showNoButton
        '
        Me.showNoButton.Location = New System.Drawing.Point(482, 77)
        Me.showNoButton.Name = "showNoButton"
        Me.showNoButton.Size = New System.Drawing.Size(101, 23)
        Me.showNoButton.TabIndex = 3
        Me.showNoButton.Text = "Show Number"
        Me.showNoButton.UseVisualStyleBackColor = True
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(178, 129)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(0, 13)
        Me.messageLabel.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.showNoButton)
        Me.Controls.Add(Me.guessNoButton)
        Me.Controls.Add(Me.guessNoText)
        Me.Controls.Add(Me.guessNoLablel)
        Me.Name = "Form1"
        Me.Text = "Guess The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents guessNoLablel As Label
    Friend WithEvents guessNoText As TextBox
    Friend WithEvents guessNoButton As Button
    Friend WithEvents showNoButton As Button
    Friend WithEvents messageLabel As Label
End Class
