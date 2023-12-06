Imports MySql.Data.MySqlClient

Public Class Form1
    Private cadenaConexion As String = "Server=localhost;Database=epe2_tapn;User Id=root;Password=1234;"
    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click

        Dim rut As String = txtRutAlumno.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim curso As String = CboxCurso.Text

        Dim idCurso As Integer = 0
        Select Case curso
            Case "Curso A"
                idCurso = 1
            Case "Curso B"
                idCurso = 2
            Case "Curso C"
                idCurso = 3
            Case Else
                MessageBox.Show("Curso erroneo")
        End Select

        Try
            Dim query As String = "INSERT INTO alumnos (rut, nombres, apellidos, idCursoFK) VALUES
                                    (@rut, @nombres, @apellidos, @idcursoFK);"
            '           'query para agregarlos automaticamente a todas las asignaturas, por lo menos las 3 que hay
            Dim query2 As String = "INSERT INTO asignaturas_alumnos (rutFK, idAsignaturaFK) VALUES
                                    (@rutFK, @idAsignaturaFK);"

            Using conectar As New MySqlConnection(cadenaConexion)
                conectar.Open()
                Using cmd As New MySqlCommand(query, conectar)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombres", nombre)
                    cmd.Parameters.AddWithValue("@apellidos", apellido)
                    cmd.Parameters.AddWithValue("@idCursoFK", idCurso)


                    cmd.ExecuteNonQuery()

                    txtRutAlumno.Text = ""
                    txtNombre.Text = ""
                    txtApellido.Text = ""


                    MessageBox.Show("Agregado Alumno con exito.")
                End Using

                For i As Integer = 1 To 3
                    Dim asignatura As Integer = i
                    Using cmd As New MySqlCommand(query2, conectar)
                        cmd.Parameters.AddWithValue("@rutFK", rut)
                        cmd.Parameters.AddWithValue("@idAsignaturaFK", asignatura)

                        cmd.ExecuteNonQuery()


                        MessageBox.Show("Agregado con exito." & i)
                    End Using
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try



    End Sub
End Class
