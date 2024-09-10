Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdby.CheckedChanged
        pct2.Visible = True
        pct1.Visible = False
        lbl2.ForeColor = Color.Yellow
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pct2.Visible = True
        pct1.Visible = False
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click

    End Sub

    Private Sub rdbb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbb.CheckedChanged
        pct2.Visible = True
        pct1.Visible = False
        lbl2.ForeColor = Color.Blue

    End Sub

    Private Sub rdbr_CheckedChanged(sender As Object, e As EventArgs) Handles rdbr.CheckedChanged
        pct2.Visible = True
        pct1.Visible = False
        lbl2.ForeColor = Color.Red
    End Sub

    Private Sub rdbg_CheckedChanged(sender As Object, e As EventArgs) Handles rdbg.CheckedChanged
        pct2.Visible = True
        pct1.Visible = False
        lbl2.ForeColor = Color.Green

    End Sub

    Private Sub pct1_Click(sender As Object, e As EventArgs) Handles pct1.Click
        pct2.Visible = True
        pct1.Visible = False
    End Sub

    Private Sub pct2_Click(sender As Object, e As EventArgs) Handles pct2.Click
        pct2.Visible = False
        pct1.Visible = True
    End Sub
End Class
