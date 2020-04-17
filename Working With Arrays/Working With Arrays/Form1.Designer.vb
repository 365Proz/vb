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
        Me.inputButton = New System.Windows.Forms.Button()
        Me.increatePriceButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'inputButton
        '
        Me.inputButton.Location = New System.Drawing.Point(13, 29)
        Me.inputButton.Name = "inputButton"
        Me.inputButton.Size = New System.Drawing.Size(75, 23)
        Me.inputButton.TabIndex = 1
        Me.inputButton.Text = "Input Data"
        Me.inputButton.UseVisualStyleBackColor = True
        '
        'increatePriceButton
        '
        Me.increatePriceButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.increatePriceButton.Location = New System.Drawing.Point(108, 305)
        Me.increatePriceButton.Name = "increatePriceButton"
        Me.increatePriceButton.Size = New System.Drawing.Size(232, 23)
        Me.increatePriceButton.TabIndex = 2
        Me.increatePriceButton.Text = "Increae Prices by 10%"
        Me.increatePriceButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(108, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(232, 264)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 357)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.increatePriceButton)
        Me.Controls.Add(Me.inputButton)
        Me.Name = "Form1"
        Me.Text = "Grocery Store Prices"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputButton As Button
    Friend WithEvents increatePriceButton As Button
    Friend WithEvents ListBox1 As ListBox
End Class
