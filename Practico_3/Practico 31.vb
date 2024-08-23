Public Class PequenoFormulario

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
        If TDni.Text.Length > 0 Then
            If Not IsNumeric(TDni.Text) Then
                MessageBox.Show("El campo DNI solo debe contener números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TDni.Clear()
            End If
        End If
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
        If TApellido.Text.Length > 0 Then
            For Each c As Char In TApellido.Text
                If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                    MessageBox.Show("Solo se permiten letras y espacios.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TApellido.Clear()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        If TNombre.Text.Length > 0 Then
            For Each c As Char In TNombre.Text
                If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                    MessageBox.Show("El campo Nombre solo debe contener letras y espacios.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TNombre.Clear()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub BGuardar_Click1(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim ask As MsgBoxResult

        If String.IsNullOrWhiteSpace(TApellido.Text) Or String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TDni.Text) Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ask = MsgBox("¿Seguro que desea insertar un nuevo Cliente?",
                         MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton1,
                         "Confirmar Inserción")

            If ask = MsgBoxResult.Yes Then
                LModificar.Text = TNombre.Text & " " & TApellido.Text
                MsgBox("El Cliente: " & TNombre.Text & " " & TApellido.Text & " se insertó correctamente",
                       MsgBoxStyle.Information, "Guardar")
            End If
        End If
    End Sub

    Private Sub BEliminar_Click2(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está a punto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text,
                 MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation Or MsgBoxStyle.DefaultButton2,
                 "Confirmar Eliminación")

        If ask = MsgBoxResult.Yes Then
            TNombre.Clear()
            TApellido.Clear()
            TDni.Clear()
            TTelefono.Clear()
            LModificar.Text = String.Empty

            CheckBox1.Checked = True


            RBVaron.Checked = True
            RBMujer.Checked = False

            MsgBox("El Cliente se eliminó correctamente",
               MsgBoxStyle.Information, "Eliminar")
        End If
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Pi\Downloads\Nueva carpeta (7)\H.png")
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Pi\Downloads\Nueva carpeta (7)\M.png")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged
        If TTelefono.Text.Length > 0 Then
            If Not IsNumeric(TTelefono.Text) Then
                MessageBox.Show("El campo Teléfono solo debe contener números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TTelefono.Clear()
            End If
        End If
    End Sub

End Class
