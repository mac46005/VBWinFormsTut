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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tbxValue01 = New System.Windows.Forms.TextBox()
        Me.tbxValue02 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(81, 190)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 71)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tbxValue01
        '
        Me.tbxValue01.Location = New System.Drawing.Point(81, 117)
        Me.tbxValue01.Name = "tbxValue01"
        Me.tbxValue01.Size = New System.Drawing.Size(150, 31)
        Me.tbxValue01.TabIndex = 1
        '
        'tbxValue02
        '
        Me.tbxValue02.Location = New System.Drawing.Point(325, 114)
        Me.tbxValue02.Name = "tbxValue02"
        Me.tbxValue02.Size = New System.Drawing.Size(150, 31)
        Me.tbxValue02.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ">"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Is value one bigger than value two?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Answer:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(198, 311)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(74, 25)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.Text = "Answer:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxValue02)
        Me.Controls.Add(Me.tbxValue01)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents tbxValue01 As TextBox
    Friend WithEvents tbxValue02 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAnswer As Label
End Class
