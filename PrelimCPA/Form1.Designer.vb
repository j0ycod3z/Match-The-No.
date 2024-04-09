<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mult = New System.Windows.Forms.Label()
        Me.Button101 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainButton
        '
        Me.MainButton.Location = New System.Drawing.Point(32, 616)
        Me.MainButton.Name = "MainButton"
        Me.MainButton.Size = New System.Drawing.Size(150, 46)
        Me.MainButton.TabIndex = 0
        Me.MainButton.Text = "Start"
        Me.MainButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 843)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 32)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Score"
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Location = New System.Drawing.Point(125, 844)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(34, 32)
        Me.score.TabIndex = 102
        Me.score.Text = "__"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 844)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 32)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Multiplier"
        '
        'Mult
        '
        Me.Mult.AutoSize = True
        Me.Mult.Location = New System.Drawing.Point(525, 845)
        Me.Mult.Name = "Mult"
        Me.Mult.Size = New System.Drawing.Size(34, 32)
        Me.Mult.TabIndex = 104
        Me.Mult.Text = "__"
        '
        'Button101
        '
        Me.Button101.Location = New System.Drawing.Point(387, 616)
        Me.Button101.Name = "Button101"
        Me.Button101.Size = New System.Drawing.Size(150, 46)
        Me.Button101.TabIndex = 205
        Me.Button101.Text = "Cheat"
        Me.Button101.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 46)
        Me.Button1.TabIndex = 206
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 912)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button101)
        Me.Controls.Add(Me.Mult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents score As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Mult As Label
    Friend WithEvents Button101 As Button
    Friend WithEvents Button1 As Button
End Class
