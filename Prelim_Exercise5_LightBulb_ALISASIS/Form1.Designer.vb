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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        rdby = New RadioButton()
        rdbb = New RadioButton()
        rdbr = New RadioButton()
        rdbg = New RadioButton()
        pct1 = New PictureBox()
        pct2 = New PictureBox()
        lbl2 = New Label()
        CType(pct1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pct2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(83, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(195, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(269, 27)
        TextBox1.TabIndex = 1
        ' 
        ' rdby
        ' 
        rdby.AutoSize = True
        rdby.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold)
        rdby.Location = New Point(102, 137)
        rdby.Name = "rdby"
        rdby.Size = New Size(80, 24)
        rdby.TabIndex = 2
        rdby.TabStop = True
        rdby.Text = "Yellow"
        rdby.UseVisualStyleBackColor = True
        ' 
        ' rdbb
        ' 
        rdbb.AutoSize = True
        rdbb.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold)
        rdbb.Location = New Point(102, 189)
        rdbb.Name = "rdbb"
        rdbb.Size = New Size(65, 24)
        rdbb.TabIndex = 3
        rdbb.TabStop = True
        rdbb.Text = "Blue"
        rdbb.UseVisualStyleBackColor = True
        ' 
        ' rdbr
        ' 
        rdbr.AutoSize = True
        rdbr.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold)
        rdbr.Location = New Point(102, 243)
        rdbr.Name = "rdbr"
        rdbr.Size = New Size(61, 24)
        rdbr.TabIndex = 4
        rdbr.TabStop = True
        rdbr.Text = "Red"
        rdbr.UseVisualStyleBackColor = True
        ' 
        ' rdbg
        ' 
        rdbg.AutoSize = True
        rdbg.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold)
        rdbg.Location = New Point(102, 295)
        rdbg.Name = "rdbg"
        rdbg.Size = New Size(77, 24)
        rdbg.TabIndex = 5
        rdbg.TabStop = True
        rdbg.Text = "Green"
        rdbg.UseVisualStyleBackColor = True
        ' 
        ' pct1
        ' 
        pct1.Image = CType(resources.GetObject("pct1.Image"), Image)
        pct1.Location = New Point(211, 101)
        pct1.Name = "pct1"
        pct1.Size = New Size(286, 244)
        pct1.SizeMode = PictureBoxSizeMode.StretchImage
        pct1.TabIndex = 6
        pct1.TabStop = False
        ' 
        ' pct2
        ' 
        pct2.Image = CType(resources.GetObject("pct2.Image"), Image)
        pct2.Location = New Point(211, 101)
        pct2.Name = "pct2"
        pct2.Size = New Size(286, 244)
        pct2.SizeMode = PictureBoxSizeMode.StretchImage
        pct2.TabIndex = 7
        pct2.TabStop = False
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(258, 373)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(197, 20)
        lbl2.TabIndex = 8
        lbl2.Text = "Light is TURN OFF, Maribella"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 443)
        Controls.Add(lbl2)
        Controls.Add(pct2)
        Controls.Add(pct1)
        Controls.Add(rdbg)
        Controls.Add(rdbr)
        Controls.Add(rdbb)
        Controls.Add(rdby)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(pct1, ComponentModel.ISupportInitialize).EndInit()
        CType(pct2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents rdby As RadioButton
    Friend WithEvents rdbb As RadioButton
    Friend WithEvents rdbr As RadioButton
    Friend WithEvents rdbg As RadioButton
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents pct2 As PictureBox
    Friend WithEvents lbl2 As Label

End Class
