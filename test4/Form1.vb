Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jumlahInput.Text = ""
        jumlahInput.ReadOnly = True
        btnProses.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beliInput.SelectedIndexChanged
        jumlahInput.ReadOnly = False
        btnProses.Enabled = True
        If beliInput.Text.Trim = "" Then
            jumlahInput.Text = ""
            jumlahInput.ReadOnly = True
            btnProses.Enabled = False
        End If
        jumlahInput.Focus()
    End Sub


    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim brg As String
        Dim jml As Integer

        If IsNumeric(jumlahInput.Text) Then
            brg = beliInput.Text
            jml = CInt(jumlahInput.Text)
            If brg = "Paracetamol" And jml > 3 Then
                MessageBox.Show("Anda akan mendapat bonus 1 hand sanitizer")
            ElseIf brg = "Paramex" Then
                MessageBox.Show("Anda akan mendapat diskon 10%")
            Else
                MessageBox.Show("Terima kasih atas kunjungannya")
            End If
        End If
    End Sub

    Private Sub btnUlangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlangi.Click
        beliInput.Text = ""
        jumlahInput.Text = ""
        jumlahInput.ReadOnly = True
        btnProses.Enabled = False
    End Sub
End Class
