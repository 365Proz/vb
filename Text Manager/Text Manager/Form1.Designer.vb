<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class textManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(textManagementForm))
        Me.browse1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.read2 = New System.Windows.Forms.TextBox()
        Me.save1 = New System.Windows.Forms.Button()
        Me.clear1 = New System.Windows.Forms.Button()
        Me.clear2 = New System.Windows.Forms.Button()
        Me.save2 = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.browse2 = New System.Windows.Forms.TextBox()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.copy1 = New System.Windows.Forms.Button()
        Me.copy2 = New System.Windows.Forms.Button()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.read1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'browse1
        '
        Me.browse1.Enabled = False
        Me.browse1.Location = New System.Drawing.Point(74, 12)
        Me.browse1.Name = "browse1"
        Me.browse1.Size = New System.Drawing.Size(298, 20)
        Me.browse1.TabIndex = 0
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(378, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(28, 20)
        Me.button1.TabIndex = 1
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'read2
        '
        Me.read2.Location = New System.Drawing.Point(15, 48)
        Me.read2.Multiline = True
        Me.read2.Name = "read2"
        Me.read2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.read2.Size = New System.Drawing.Size(1004, 411)
        Me.read2.TabIndex = 6
        '
        'save1
        '
        Me.save1.BackColor = System.Drawing.Color.Lime
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save1.Location = New System.Drawing.Point(525, 12)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(75, 23)
        Me.save1.TabIndex = 8
        Me.save1.Text = "Save"
        Me.save1.UseVisualStyleBackColor = False
        '
        'clear1
        '
        Me.clear1.BackColor = System.Drawing.Color.RoyalBlue
        Me.clear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear1.ForeColor = System.Drawing.Color.White
        Me.clear1.Location = New System.Drawing.Point(632, 15)
        Me.clear1.Name = "clear1"
        Me.clear1.Size = New System.Drawing.Size(75, 23)
        Me.clear1.TabIndex = 9
        Me.clear1.Text = "Clear"
        Me.clear1.UseVisualStyleBackColor = False
        '
        'clear2
        '
        Me.clear2.BackColor = System.Drawing.Color.RoyalBlue
        Me.clear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear2.ForeColor = System.Drawing.Color.White
        Me.clear2.Location = New System.Drawing.Point(632, 482)
        Me.clear2.Name = "clear2"
        Me.clear2.Size = New System.Drawing.Size(75, 23)
        Me.clear2.TabIndex = 16
        Me.clear2.Text = "Clear"
        Me.clear2.UseVisualStyleBackColor = False
        '
        'save2
        '
        Me.save2.BackColor = System.Drawing.Color.Lime
        Me.save2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save2.Location = New System.Drawing.Point(525, 482)
        Me.save2.Name = "save2"
        Me.save2.Size = New System.Drawing.Size(75, 23)
        Me.save2.TabIndex = 15
        Me.save2.Text = "Save"
        Me.save2.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(15, 518)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox2.Size = New System.Drawing.Size(1004, 138)
        Me.textBox2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tags #"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(378, 482)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(28, 20)
        Me.button2.TabIndex = 11
        Me.button2.Text = "..."
        Me.button2.UseVisualStyleBackColor = True
        '
        'browse2
        '
        Me.browse2.Enabled = False
        Me.browse2.Location = New System.Drawing.Point(74, 482)
        Me.browse2.Name = "browse2"
        Me.browse2.Size = New System.Drawing.Size(298, 20)
        Me.browse2.TabIndex = 10
        '
        'ofd1
        '
        Me.ofd1.ReadOnlyChecked = True
        '
        'copy1
        '
        Me.copy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.copy1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copy1.ForeColor = System.Drawing.Color.White
        Me.copy1.Location = New System.Drawing.Point(944, 19)
        Me.copy1.Name = "copy1"
        Me.copy1.Size = New System.Drawing.Size(75, 23)
        Me.copy1.TabIndex = 17
        Me.copy1.Text = "Copy"
        Me.copy1.UseVisualStyleBackColor = False
        '
        'copy2
        '
        Me.copy2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.copy2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copy2.ForeColor = System.Drawing.Color.White
        Me.copy2.Location = New System.Drawing.Point(944, 489)
        Me.copy2.Name = "copy2"
        Me.copy2.Size = New System.Drawing.Size(75, 23)
        Me.copy2.TabIndex = 18
        Me.copy2.Text = "Copy"
        Me.copy2.UseVisualStyleBackColor = False
        '
        'ofd2
        '
        Me.ofd2.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(421, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Read"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'read1
        '
        Me.read1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.read1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.read1.Location = New System.Drawing.Point(421, 12)
        Me.read1.Name = "read1"
        Me.read1.Size = New System.Drawing.Size(75, 23)
        Me.read1.TabIndex = 20
        Me.read1.Text = "Read"
        Me.read1.UseVisualStyleBackColor = False
        '
        'textManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1036, 668)
        Me.Controls.Add(Me.read1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.copy2)
        Me.Controls.Add(Me.copy1)
        Me.Controls.Add(Me.clear2)
        Me.Controls.Add(Me.save2)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.browse2)
        Me.Controls.Add(Me.clear1)
        Me.Controls.Add(Me.save1)
        Me.Controls.Add(Me.read2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.browse1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "textManagementForm"
        Me.ShowIcon = False
        Me.Text = "Text Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents browse1 As TextBox
    Friend WithEvents button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents read2 As TextBox
    Friend WithEvents save1 As Button
    Friend WithEvents clear1 As Button
    Friend WithEvents clear2 As Button
    Friend WithEvents save2 As Button
    Friend WithEvents textBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents button2 As Button
    Friend WithEvents browse2 As TextBox
    Friend WithEvents ofd1 As OpenFileDialog
    Friend WithEvents copy1 As Button
    Friend WithEvents copy2 As Button
    Friend WithEvents ofd2 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents read1 As Button
End Class
