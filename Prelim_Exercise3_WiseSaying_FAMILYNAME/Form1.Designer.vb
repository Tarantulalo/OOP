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
        components = New ComponentModel.Container()
        RichTextBox1 = New RichTextBox()
        ToolTip1 = New ToolTip(components)
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(193, 60)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(125, 120)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = "Its better to be a coward for a minute that be dead for the rest of your life."
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(193, 224)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        TextBox1.Text = "A Proverb"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 323)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox

End Class
