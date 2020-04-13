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
        Me.rollDice = New System.Windows.Forms.Button()
        Me.randomList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.diceRollLabel = New System.Windows.Forms.Label()
        Me.totalScoreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rollDice
        '
        Me.rollDice.Location = New System.Drawing.Point(13, 33)
        Me.rollDice.Name = "rollDice"
        Me.rollDice.Size = New System.Drawing.Size(75, 23)
        Me.rollDice.TabIndex = 0
        Me.rollDice.Text = "Roll Dice"
        Me.rollDice.UseVisualStyleBackColor = True
        '
        'randomList
        '
        Me.randomList.FormattingEnabled = True
        Me.randomList.Location = New System.Drawing.Point(115, 33)
        Me.randomList.Name = "randomList"
        Me.randomList.Size = New System.Drawing.Size(159, 225)
        Me.randomList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No. Of Dice Rolled:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Score:"
        '
        'diceRollLabel
        '
        Me.diceRollLabel.AutoSize = True
        Me.diceRollLabel.Location = New System.Drawing.Point(135, 288)
        Me.diceRollLabel.Name = "diceRollLabel"
        Me.diceRollLabel.Size = New System.Drawing.Size(39, 13)
        Me.diceRollLabel.TabIndex = 4
        Me.diceRollLabel.Text = "Label3"
        '
        'totalScoreLabel
        '
        Me.totalScoreLabel.AutoSize = True
        Me.totalScoreLabel.Location = New System.Drawing.Point(138, 325)
        Me.totalScoreLabel.Name = "totalScoreLabel"
        Me.totalScoreLabel.Size = New System.Drawing.Size(39, 13)
        Me.totalScoreLabel.TabIndex = 5
        Me.totalScoreLabel.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 379)
        Me.Controls.Add(Me.totalScoreLabel)
        Me.Controls.Add(Me.diceRollLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.randomList)
        Me.Controls.Add(Me.rollDice)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rollDice As Button
    Friend WithEvents randomList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents diceRollLabel As Label
    Friend WithEvents totalScoreLabel As Label
End Class
