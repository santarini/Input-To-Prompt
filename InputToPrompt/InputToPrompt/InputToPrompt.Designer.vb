<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputToPrompt
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(149, 492)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(252, 105)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(601, 492)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(252, 105)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(344, 174)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(287, 25)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "Enter some text to prompted out"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(259, 276)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(442, 79)
        Me.txtInput.TabIndex = 3
        '
        'InputToPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 671)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "InputToPrompt"
        Me.Text = "Input to Prompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents txtInput As TextBox
End Class
