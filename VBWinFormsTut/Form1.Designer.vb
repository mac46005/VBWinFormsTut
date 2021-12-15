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
        Me.tbxValueOne = New System.Windows.Forms.TextBox()
        Me.tbxValueTwo = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbxInequalityOperators = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxValueOne
        '
        Me.tbxValueOne.Location = New System.Drawing.Point(50, 88)
        Me.tbxValueOne.Name = "tbxValueOne"
        Me.tbxValueOne.Size = New System.Drawing.Size(150, 31)
        Me.tbxValueOne.TabIndex = 0
        '
        'tbxValueTwo
        '
        Me.tbxValueTwo.Location = New System.Drawing.Point(50, 197)
        Me.tbxValueTwo.Name = "tbxValueTwo"
        Me.tbxValueTwo.Size = New System.Drawing.Size(150, 31)
        Me.tbxValueTwo.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(50, 245)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 62)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cbxInequalityOperators
        '
        Me.cbxInequalityOperators.FormattingEnabled = True
        Me.cbxInequalityOperators.Location = New System.Drawing.Point(50, 144)
        Me.cbxInequalityOperators.Name = "cbxInequalityOperators"
        Me.cbxInequalityOperators.Size = New System.Drawing.Size(182, 33)
        Me.cbxInequalityOperators.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(88, 337)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(92, 25)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "resultlabel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cbxInequalityOperators)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.tbxValueTwo)
        Me.Controls.Add(Me.tbxValueOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxValueOne As TextBox
    Friend WithEvents tbxValueTwo As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbxInequalityOperators As ComboBox
    Friend WithEvents lblResult As Label
End Class
