<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        FirstNumber = New TextBox()
        Label1 = New Label()
        SecondNumber = New TextBox()
        Label2 = New Label()
        AddTogether = New Button()
        SuspendLayout()
        ' 
        ' FirstNumber
        ' 
        FirstNumber.Location = New Point(284, 47)
        FirstNumber.Name = "FirstNumber"
        FirstNumber.Size = New Size(125, 27)
        FirstNumber.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 20)
        Label1.TabIndex = 1
        Label1.Text = "What is you first number?"
        ' 
        ' SecondNumber
        ' 
        SecondNumber.Location = New Point(284, 98)
        SecondNumber.Name = "SecondNumber"
        SecondNumber.Size = New Size(125, 27)
        SecondNumber.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 20)
        Label2.TabIndex = 3
        Label2.Text = "What is your second number?"
        ' 
        ' AddTogether
        ' 
        AddTogether.Location = New Point(196, 163)
        AddTogether.Name = "AddTogether"
        AddTogether.Size = New Size(114, 29)
        AddTogether.TabIndex = 4
        AddTogether.Text = "Calculate total"
        AddTogether.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(557, 263)
        Controls.Add(AddTogether)
        Controls.Add(Label2)
        Controls.Add(SecondNumber)
        Controls.Add(Label1)
        Controls.Add(FirstNumber)
        Name = "Form1"
        Text = "Add 2 numbers together"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FirstNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SecondNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddTogether As Button

End Class
