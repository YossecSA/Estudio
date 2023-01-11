Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim i As String
        Dim rutaImagen As String = "C:\Users\Josefer\OneDrive\Escritorio\Desarrollo-Web\Proyecto\src\img\coffee.png"
        i = ListBox1.SelectedItem

        If ListBox1.SelectedItem = "Imagen1" Then
            'PictureBox1.Image = My.Resources.eventoMoverPantalla
            PictureBox1.Load(rutaImagen)

        ElseIf ListBox1.SelectedItem = "Imagen2" Then
            PictureBox1.Image = My.Resources.Captura_de_pantalla_2022_10_16_161109

        ElseIf ListBox1.SelectedItem = "Fondo Pantalla" Then
            PictureBox1.Image = My.Resources.guitarra

        ElseIf ListBox1.SelectedItem = "Cafe" Then
            PictureBox1.Image = My.Resources.coffee

        ElseIf ListBox1.SelectedItem = "Monstruo" Then
            PictureBox1.Image = My.Resources.monster


        End If

    End Sub

    Sub albumFotos()


    End Sub



End Class
