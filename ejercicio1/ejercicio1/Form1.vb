Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates

Public Class Form1


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        ingresarPalabra(txtPalabra.Text)

    End Sub

    Private Sub ingresarPalabra(palabra As String)


        If "aeiou".Contains(palabra.ToLower().Chars(0)) Then

            'para agregar palabra a listBox
            listVocal.Items.Add(palabra)
        Else
            lisConso.Items.Add(palabra)
        End If


    End Sub
End Class
