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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnLetters = New System.Windows.Forms.Button()
        Me.btnVandC = New System.Windows.Forms.Button()
        Me.lblFirstLetter = New System.Windows.Forms.Label()
        Me.lblMiddleLetter = New System.Windows.Forms.Label()
        Me.lblLastLetter = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(30, 55)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(262, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnLetters
        '
        Me.btnLetters.Location = New System.Drawing.Point(30, 96)
        Me.btnLetters.Name = "btnLetters"
        Me.btnLetters.Size = New System.Drawing.Size(97, 62)
        Me.btnLetters.TabIndex = 1
        Me.btnLetters.Text = "Display Letters"
        Me.btnLetters.UseVisualStyleBackColor = True
        '
        'btnVandC
        '
        Me.btnVandC.Location = New System.Drawing.Point(185, 96)
        Me.btnVandC.Name = "btnVandC"
        Me.btnVandC.Size = New System.Drawing.Size(107, 62)
        Me.btnVandC.TabIndex = 2
        Me.btnVandC.Text = "Count Vowels and Consonants"
        Me.btnVandC.UseVisualStyleBackColor = True
        '
        'lblFirstLetter
        '
        Me.lblFirstLetter.AutoSize = True
        Me.lblFirstLetter.Location = New System.Drawing.Point(27, 179)
        Me.lblFirstLetter.Name = "lblFirstLetter"
        Me.lblFirstLetter.Size = New System.Drawing.Size(59, 13)
        Me.lblFirstLetter.TabIndex = 3
        Me.lblFirstLetter.Text = "First Letter:"
        '
        'lblMiddleLetter
        '
        Me.lblMiddleLetter.AutoSize = True
        Me.lblMiddleLetter.Location = New System.Drawing.Point(27, 210)
        Me.lblMiddleLetter.Name = "lblMiddleLetter"
        Me.lblMiddleLetter.Size = New System.Drawing.Size(71, 13)
        Me.lblMiddleLetter.TabIndex = 4
        Me.lblMiddleLetter.Text = "Middle Letter:"
        '
        'lblLastLetter
        '
        Me.lblLastLetter.AutoSize = True
        Me.lblLastLetter.Location = New System.Drawing.Point(27, 241)
        Me.lblLastLetter.Name = "lblLastLetter"
        Me.lblLastLetter.Size = New System.Drawing.Size(60, 13)
        Me.lblLastLetter.TabIndex = 5
        Me.lblLastLetter.Text = "Last Letter:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(166, 179)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Insert Your String"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblLastLetter)
        Me.Controls.Add(Me.lblMiddleLetter)
        Me.Controls.Add(Me.lblFirstLetter)
        Me.Controls.Add(Me.btnVandC)
        Me.Controls.Add(Me.btnLetters)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "String Manipulations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnLetters As System.Windows.Forms.Button
    Friend WithEvents btnVandC As System.Windows.Forms.Button
    Friend WithEvents lblFirstLetter As System.Windows.Forms.Label
    Friend WithEvents lblMiddleLetter As System.Windows.Forms.Label
    Friend WithEvents lblLastLetter As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
