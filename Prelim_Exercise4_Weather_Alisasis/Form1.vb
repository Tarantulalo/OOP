Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PctSunny.Visible = False
        Pctrain.Visible = False
        PctSnowy.Visible = False
        PctCloudy.Visible = False
        LblCLoudy.Visible = False
        Lblrainy.Visible = False
        LblSnowy.Visible = False
        LblSunny.Visible = False

    End Sub

    Private Sub RdbSunny_CheckedChanged(sender As Object, e As EventArgs) Handles RdbSunny.CheckedChanged
        PctSunny.Visible = True
        Pctrain.Visible = False
        PctSnowy.Visible = False
        PctCloudy.Visible = False
        LblSunny.Visible = True
    End Sub

    Private Sub Rdbrainy_CheckedChanged(sender As Object, e As EventArgs) Handles Rdbrainy.CheckedChanged
        Pctrain.Visible = True
        PctSunny.Visible = False
        PctSnowy.Visible = False
        PctCloudy.Visible = False
        Lblrainy.Visible = True
    End Sub

    Private Sub Rdbsnowy_CheckedChanged(sender As Object, e As EventArgs) Handles Rdbsnowy.CheckedChanged
        PctSnowy.Visible = True
        PctSunny.Visible = False
        Pctrain.Visible = False
        PctCloudy.Visible = False
        LblSnowy.Visible = True
    End Sub

    Private Sub RdbCloudy_CheckedChanged(sender As Object, e As EventArgs) Handles RdbCloudy.CheckedChanged
        PctCloudy.Visible = True
        PctSunny.Visible = False
        Pctrain.Visible = False
        PctSnowy.Visible = False
        LblCLoudy.Visible = True
    End Sub

    Private Sub LblCLoudy_Click(sender As Object, e As EventArgs) Handles LblCLoudy.Click

    End Sub
End Class
