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
        Me.TextDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddThis = New System.Windows.Forms.Button()
        Me.addProgram = New System.Windows.Forms.Button()
        Me.addmy = New System.Windows.Forms.Button()
        Me.AddIs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextDisplay
        '
        Me.TextDisplay.Location = New System.Drawing.Point(168, 81)
        Me.TextDisplay.Name = "TextDisplay"
        Me.TextDisplay.Size = New System.Drawing.Size(100, 22)
        Me.TextDisplay.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My text is"
        '
        'AddThis
        '
        Me.AddThis.Location = New System.Drawing.Point(12, 126)
        Me.AddThis.Name = "AddThis"
        Me.AddThis.Size = New System.Drawing.Size(88, 23)
        Me.AddThis.TabIndex = 2
        Me.AddThis.Text = "Add ""This """
        Me.AddThis.UseVisualStyleBackColor = True
        '
        'addProgram
        '
        Me.addProgram.Location = New System.Drawing.Point(283, 126)
        Me.addProgram.Name = "addProgram"
        Me.addProgram.Size = New System.Drawing.Size(142, 23)
        Me.addProgram.TabIndex = 3
        Me.addProgram.Text = "Add ""program."""
        Me.addProgram.UseVisualStyleBackColor = True
        '
        'addmy
        '
        Me.addmy.Location = New System.Drawing.Point(193, 126)
        Me.addmy.Name = "addmy"
        Me.addmy.Size = New System.Drawing.Size(84, 23)
        Me.addmy.TabIndex = 4
        Me.addmy.Text = "add ""my """
        Me.addmy.UseVisualStyleBackColor = True
        '
        'AddIs
        '
        Me.AddIs.Location = New System.Drawing.Point(106, 126)
        Me.AddIs.Name = "AddIs"
        Me.AddIs.Size = New System.Drawing.Size(81, 23)
        Me.AddIs.TabIndex = 5
        Me.AddIs.Text = "Add ""is """
        Me.AddIs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddIs)
        Me.Controls.Add(Me.addmy)
        Me.Controls.Add(Me.addProgram)
        Me.Controls.Add(Me.AddThis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextDisplay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddThis As Button
    Friend WithEvents addProgram As Button
    Friend WithEvents addmy As Button
    Friend WithEvents AddIs As Button
End Class
