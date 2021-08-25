Public Class Form1
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'revisão da aula anterior, vamos exibir uma janela de mensagem
        MessageBox.Show("Olá " & txtName.Text & " , bem vindo a nossa aula!", "Mensagem ao usuário")

    End Sub
End Class
