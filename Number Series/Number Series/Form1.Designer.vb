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
        Me.generateButton = New System.Windows.Forms.Button()
        Me.numberList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(3, 12)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(108, 39)
        Me.generateButton.TabIndex = 0
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'numberList
        '
        Me.numberList.FormattingEnabled = True
        Me.numberList.Location = New System.Drawing.Point(133, 12)
        Me.numberList.Name = "numberList"
        Me.numberList.Size = New System.Drawing.Size(313, 615)
        Me.numberList.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 633)
        Me.Controls.Add(Me.numberList)
        Me.Controls.Add(Me.generateButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generateButton As Button
    Friend WithEvents numberList As ListBox
End Class
