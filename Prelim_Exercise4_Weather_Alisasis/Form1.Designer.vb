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
        TextBox1 = New TextBox()
        Label1 = New Label()
        RdbSunny = New RadioButton()
        Rdbrainy = New RadioButton()
        Rdbsnowy = New RadioButton()
        RdbCloudy = New RadioButton()
        PctSunny = New PictureBox()
        Pctrain = New PictureBox()
        PctSnowy = New PictureBox()
        PctCloudy = New PictureBox()
        Label2 = New Label()
        LblSunny = New Label()
        Lblrainy = New Label()
        LblSnowy = New Label()
        LblCLoudy = New Label()
        CType(PctSunny, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pctrain, ComponentModel.ISupportInitialize).BeginInit()
        CType(PctSnowy, ComponentModel.ISupportInitialize).BeginInit()
        CType(PctCloudy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(166, 35)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(241, 34)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(50, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter Name:"
        ' 
        ' RdbSunny
        ' 
        RdbSunny.AutoSize = True
        RdbSunny.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        RdbSunny.Location = New Point(50, 134)
        RdbSunny.Name = "RdbSunny"
        RdbSunny.Size = New Size(73, 24)
        RdbSunny.TabIndex = 2
        RdbSunny.TabStop = True
        RdbSunny.Text = "Sunny"
        RdbSunny.UseVisualStyleBackColor = True
        ' 
        ' Rdbrainy
        ' 
        Rdbrainy.AutoSize = True
        Rdbrainy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Rdbrainy.Location = New Point(50, 177)
        Rdbrainy.Name = "Rdbrainy"
        Rdbrainy.Size = New Size(68, 24)
        Rdbrainy.TabIndex = 3
        Rdbrainy.TabStop = True
        Rdbrainy.Text = "Rainy"
        Rdbrainy.UseVisualStyleBackColor = True
        ' 
        ' Rdbsnowy
        ' 
        Rdbsnowy.AutoSize = True
        Rdbsnowy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Rdbsnowy.Location = New Point(50, 219)
        Rdbsnowy.Name = "Rdbsnowy"
        Rdbsnowy.Size = New Size(75, 24)
        Rdbsnowy.TabIndex = 4
        Rdbsnowy.TabStop = True
        Rdbsnowy.Text = "Snowy"
        Rdbsnowy.UseVisualStyleBackColor = True
        ' 
        ' RdbCloudy
        ' 
        RdbCloudy.AutoSize = True
        RdbCloudy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        RdbCloudy.Location = New Point(50, 263)
        RdbCloudy.Name = "RdbCloudy"
        RdbCloudy.Size = New Size(78, 24)
        RdbCloudy.TabIndex = 5
        RdbCloudy.TabStop = True
        RdbCloudy.Text = "Cloudy"
        RdbCloudy.UseVisualStyleBackColor = True
        ' 
        ' PctSunny
        ' 
        PctSunny.Image = CType(resources.GetObject("PctSunny.Image"), Image)
        PctSunny.Location = New Point(191, 122)
        PctSunny.Name = "PctSunny"
        PctSunny.Size = New Size(206, 206)
        PctSunny.SizeMode = PictureBoxSizeMode.StretchImage
        PctSunny.TabIndex = 6
        PctSunny.TabStop = False
        ' 
        ' Pctrain
        ' 
        Pctrain.Image = CType(resources.GetObject("Pctrain.Image"), Image)
        Pctrain.Location = New Point(191, 122)
        Pctrain.Name = "Pctrain"
        Pctrain.Size = New Size(206, 206)
        Pctrain.SizeMode = PictureBoxSizeMode.StretchImage
        Pctrain.TabIndex = 7
        Pctrain.TabStop = False
        ' 
        ' PctSnowy
        ' 
        PctSnowy.Image = CType(resources.GetObject("PctSnowy.Image"), Image)
        PctSnowy.Location = New Point(181, 122)
        PctSnowy.Name = "PctSnowy"
        PctSnowy.Size = New Size(216, 206)
        PctSnowy.SizeMode = PictureBoxSizeMode.StretchImage
        PctSnowy.TabIndex = 8
        PctSnowy.TabStop = False
        ' 
        ' PctCloudy
        ' 
        PctCloudy.Image = CType(resources.GetObject("PctCloudy.Image"), Image)
        PctCloudy.Location = New Point(181, 122)
        PctCloudy.Name = "PctCloudy"
        PctCloudy.Size = New Size(216, 206)
        PctCloudy.SizeMode = PictureBoxSizeMode.StretchImage
        PctCloudy.TabIndex = 9
        PctCloudy.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(250, 379)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 10
        ' 
        ' LblSunny
        ' 
        LblSunny.AutoSize = True
        LblSunny.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSunny.Location = New Point(12, 375)
        LblSunny.Name = "LblSunny"
        LblSunny.Size = New Size(435, 28)
        LblSunny.TabIndex = 11
        LblSunny.Text = "It look s like a Sunny Weather today, Maribella"
        ' 
        ' Lblrainy
        ' 
        Lblrainy.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblrainy.Location = New Point(20, 378)
        Lblrainy.Name = "Lblrainy"
        Lblrainy.Size = New Size(422, 25)
        Lblrainy.TabIndex = 12
        Lblrainy.Text = "It will rain today, Maribella"
        ' 
        ' LblSnowy
        ' 
        LblSnowy.AutoSize = True
        LblSnowy.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSnowy.Location = New Point(12, 379)
        LblSnowy.Name = "LblSnowy"
        LblSnowy.Size = New Size(347, 25)
        LblSnowy.TabIndex = 13
        LblSnowy.Text = "It looks like it will Snow today, Maribella"
        ' 
        ' LblCLoudy
        ' 
        LblCLoudy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCLoudy.Location = New Point(5, 383)
        LblCLoudy.Name = "LblCLoudy"
        LblCLoudy.Size = New Size(437, 25)
        LblCLoudy.TabIndex = 14
        LblCLoudy.Text = "Looks like we have CLOUDY weather today, Maribella"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 446)
        Controls.Add(LblCLoudy)
        Controls.Add(LblSnowy)
        Controls.Add(Lblrainy)
        Controls.Add(LblSunny)
        Controls.Add(Label2)
        Controls.Add(PctCloudy)
        Controls.Add(PctSnowy)
        Controls.Add(Pctrain)
        Controls.Add(PctSunny)
        Controls.Add(RdbCloudy)
        Controls.Add(Rdbsnowy)
        Controls.Add(Rdbrainy)
        Controls.Add(RdbSunny)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = " Weather Report"
        CType(PctSunny, ComponentModel.ISupportInitialize).EndInit()
        CType(Pctrain, ComponentModel.ISupportInitialize).EndInit()
        CType(PctSnowy, ComponentModel.ISupportInitialize).EndInit()
        CType(PctCloudy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RdbSunny As RadioButton
    Friend WithEvents Rdbrainy As RadioButton
    Friend WithEvents Rdbsnowy As RadioButton
    Friend WithEvents RdbCloudy As RadioButton
    Friend WithEvents PctSunny As PictureBox
    Friend WithEvents Pctrain As PictureBox
    Friend WithEvents PctSnowy As PictureBox
    Friend WithEvents PctCloudy As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblSunny As Label
    Friend WithEvents Lblrainy As Label
    Friend WithEvents LblSnowy As Label
    Friend WithEvents LblCLoudy As Label

End Class
