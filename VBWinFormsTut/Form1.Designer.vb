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
        Me.tbxRange = New System.Windows.Forms.TextBox()
        Me.tbxGuess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnMustSubmitRange = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxRange
        '
        Me.tbxRange.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbxRange.Location = New System.Drawing.Point(40, 94)
        Me.tbxRange.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxRange.Name = "tbxRange"
        Me.tbxRange.Size = New System.Drawing.Size(108, 27)
        Me.tbxRange.TabIndex = 0
        '
        'tbxGuess
        '
        Me.tbxGuess.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbxGuess.Location = New System.Drawing.Point(40, 239)
        Me.tbxGuess.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxGuess.Name = "tbxGuess"
        Me.tbxGuess.Size = New System.Drawing.Size(108, 27)
        Me.tbxGuess.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Take your chance pick a number!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(40, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick the range of numbers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(40, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Take your chance! Pick a number or else...:)"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Niagara Solid", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.ForeColor = System.Drawing.Color.Salmon
        Me.lblResult.Location = New System.Drawing.Point(40, 337)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(41, 21)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result"
        '
        'btnMustSubmitRange
        '
        Me.btnMustSubmitRange.ForeColor = System.Drawing.Color.Red
        Me.btnMustSubmitRange.Location = New System.Drawing.Point(40, 155)
        Me.btnMustSubmitRange.Name = "btnMustSubmitRange"
        Me.btnMustSubmitRange.Size = New System.Drawing.Size(112, 34)
        Me.btnMustSubmitRange.TabIndex = 6
        Me.btnMustSubmitRange.Text = "Button1"
        Me.btnMustSubmitRange.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.ForeColor = System.Drawing.Color.Red
        Me.btnSubmit.Location = New System.Drawing.Point(40, 289)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 34)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Button2"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(400, 378)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnMustSubmitRange)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxGuess)
        Me.Controls.Add(Me.tbxRange)
        Me.Font = New System.Drawing.Font("Niagara Engraved", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Turquoise
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxRange As TextBox
    Friend WithEvents tbxGuess As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnMustSubmitRange As Button
    Friend WithEvents btnSubmit As Button
End Class
