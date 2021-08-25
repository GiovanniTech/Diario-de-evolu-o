Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblidade1.Click

    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        ' criando as variaveis que serão utilizadas no processo
        Dim idade1, idade2 As Integer
        ' inserindo valores nas variáveis, recuperando dos objetos TextBox
        ' convertendo o conteúdo do textBox que é uma string para números inteiros com a função Cint
        idade1 = CInt(tbtIdade1.Text)
        idade2 = CInt(tbtIdade2.Text)

        ' vamos comparar os valores das variáveis usando a estrutura de decisão
        If idade1 > idade2 Then
            MessageBox.Show("A idade " & idade1 & " anos, é maior que " & idade2 & "anos")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade " & idade2 & " anos, é maior que " & idade1 & "anos")
        Else
            MessageBox.Show("A idade " & idade1 & " anos, é maior que " & idade2 & "anos")
        End If

        tbtIdade1.Clear()
        tbtIdade2.Clear()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        tbtIdade1.Clear()
        tbtIdade2.Clear()

    End Sub
End Class
