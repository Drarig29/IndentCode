<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Indent = New System.Windows.Forms.Button()
        Me.TextToIndent = New System.Windows.Forms.RichTextBox()
        Me.Buttons = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeIndent = New System.Windows.Forms.Button()
        Me.Copy = New System.Windows.Forms.Button()
        Me.ClearTextBox = New System.Windows.Forms.Button()
        Me.CloseForm = New System.Windows.Forms.Button()
        Me.Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Indent
        '
        Me.Indent.Location = New System.Drawing.Point(3, 3)
        Me.Indent.Name = "Indent"
        Me.Indent.Size = New System.Drawing.Size(128, 23)
        Me.Indent.TabIndex = 1
        Me.Indent.Text = "Increase indentation"
        Me.Indent.UseVisualStyleBackColor = True
        '
        'TextToIndent
        '
        Me.TextToIndent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextToIndent.Location = New System.Drawing.Point(12, 43)
        Me.TextToIndent.Name = "TextToIndent"
        Me.TextToIndent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TextToIndent.Size = New System.Drawing.Size(447, 230)
        Me.TextToIndent.TabIndex = 2
        Me.TextToIndent.Text = resources.GetString("TextToIndent.Text")
        '
        'Buttons
        '
        Me.Buttons.Controls.Add(Me.Indent)
        Me.Buttons.Controls.Add(Me.DeIndent)
        Me.Buttons.Controls.Add(Me.Copy)
        Me.Buttons.Controls.Add(Me.ClearTextBox)
        Me.Buttons.Controls.Add(Me.CloseForm)
        Me.Buttons.Location = New System.Drawing.Point(12, 7)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(447, 29)
        Me.Buttons.TabIndex = 4
        '
        'DeIndent
        '
        Me.DeIndent.Location = New System.Drawing.Point(137, 3)
        Me.DeIndent.Name = "DeIndent"
        Me.DeIndent.Size = New System.Drawing.Size(133, 23)
        Me.DeIndent.TabIndex = 5
        Me.DeIndent.Text = "Decrease indentation"
        Me.DeIndent.UseVisualStyleBackColor = True
        '
        'Copy
        '
        Me.Copy.Location = New System.Drawing.Point(276, 3)
        Me.Copy.Name = "Copy"
        Me.Copy.Size = New System.Drawing.Size(50, 23)
        Me.Copy.TabIndex = 5
        Me.Copy.Text = "Copy"
        Me.Copy.UseVisualStyleBackColor = True
        '
        'ClearTextBox
        '
        Me.ClearTextBox.Location = New System.Drawing.Point(332, 3)
        Me.ClearTextBox.Name = "ClearTextBox"
        Me.ClearTextBox.Size = New System.Drawing.Size(52, 23)
        Me.ClearTextBox.TabIndex = 3
        Me.ClearTextBox.Text = "Clear"
        Me.ClearTextBox.UseVisualStyleBackColor = True
        '
        'CloseForm
        '
        Me.CloseForm.Location = New System.Drawing.Point(390, 3)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.Size = New System.Drawing.Size(52, 23)
        Me.CloseForm.TabIndex = 2
        Me.CloseForm.Text = "Close"
        Me.CloseForm.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.Indent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 285)
        Me.Controls.Add(Me.Buttons)
        Me.Controls.Add(Me.TextToIndent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(487, 275)
        Me.Name = "MainForm"
        Me.Text = "IndentCode"
        Me.Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Indent As System.Windows.Forms.Button
    Friend WithEvents TextToIndent As System.Windows.Forms.RichTextBox
    Friend WithEvents Buttons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ClearTextBox As System.Windows.Forms.Button
    Friend WithEvents CloseForm As System.Windows.Forms.Button
    Friend WithEvents DeIndent As System.Windows.Forms.Button
    Friend WithEvents Copy As System.Windows.Forms.Button

End Class
