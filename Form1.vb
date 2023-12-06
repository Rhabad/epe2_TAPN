Imports System.Globalization
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx

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

    Private Sub btnMostrarAlumnos_Click(sender As Object, e As EventArgs) Handles btnMostrarAlumnos.Click
        Dim query As String = "SELECT a.rut, a.nombres, a.apellidos, c.curso
                                FROM alumnos a
                                JOIN cursos c ON a.idCursoFK = c.idCurso;"
        Try
            Using connection As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, connection)
                    connection.Open()

                    Dim lector As MySqlDataReader = cmd.ExecuteReader()

                    Dim resultado As New StringBuilder

                    While lector.Read()
                        resultado.AppendLine("Rut: " & lector("rut").ToString)
                        resultado.AppendLine("Nombre: " & lector("nombres").ToString)
                        resultado.AppendLine("Apellido: " & lector("apellidos").ToString)
                        resultado.AppendLine("Curso: " & lector("curso").ToString)

                        resultado.AppendLine()
                    End While

                    txtMostrarAlumnos.Text = resultado.ToString
                End Using
            End Using
        Catch ex As Exception
            MsgBox("no se pudo conectar" & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCalificacion_Click(sender As Object, e As EventArgs) Handles btnAgregarCalificacion.Click
        Dim rut As String = txtRutCalificaciones.Text
        Dim asignatura As String = CBoxAsignatura.Text
        Dim nota As Double

        If Double.TryParse(txtNota.Text, NumberStyles.Float, CultureInfo.CurrentCulture, nota) Then

            Dim idAsignatura As Integer = 0
            Select Case asignatura
                Case "Matemáticas."
                    idAsignatura = 1
                Case "Historia."
                    idAsignatura = 2
                Case "Ciencias."
                    idAsignatura = 3
                Case Else
                    MessageBox.Show("Curso erroneo")
            End Select


            Try
                Dim query As String = "INSERT INTO calificaciones (notaFinal, rutFK, idAsignaturaFK) VALUES
                                    (@notaFinal, @rutFK, @idAsignaturaFK);"

                Using conectar As New MySqlConnection(cadenaConexion)
                    Using cmd As New MySqlCommand(query, conectar)
                        cmd.Parameters.AddWithValue("@notaFinal", nota)
                        cmd.Parameters.AddWithValue("@rutFK", rut)
                        cmd.Parameters.AddWithValue("@idAsignaturaFK", idAsignatura)

                        conectar.Open()
                        cmd.ExecuteNonQuery()

                        txtRutCalificaciones.Text = ""
                        txtNota.Text = ""


                        MessageBox.Show("Agregado con exito.")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar: " & ex.Message)
            End Try


        Else
            MsgBox("Error al convertir el texto a Double.")
        End If

    End Sub

    Private Sub btnMostrarCalificacion_Click(sender As Object, e As EventArgs) Handles btnMostrarCalificacion.Click
        Dim query As String = "SELECT a.rut, a.nombres, a.apellidos, c.curso, asig.nombreAsignatura, cal.notaFinal
                            FROM
                                alumnos a
                            JOIN
                                cursos c ON a.idCursoFK = c.idCurso
                            JOIN
                                asignaturas_alumnos aa ON a.rut = aa.rutFK
                            JOIN
                                asignatura asig ON aa.idAsignaturaFK = asig.idAsignatura
                            JOIN
                                calificaciones cal ON a.rut = cal.rutFK AND asig.idAsignatura = cal.idAsignaturaFK;"
        Try
            Using connection As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, connection)
                    connection.Open()

                    Dim lector As MySqlDataReader = cmd.ExecuteReader()

                    Dim resultado As New StringBuilder

                    While lector.Read()
                        resultado.AppendLine("Rut: " & lector("rut").ToString)
                        resultado.AppendLine("Nombre: " & lector("nombres").ToString)
                        resultado.AppendLine("Apellido: " & lector("apellidos").ToString)
                        resultado.AppendLine("Curso: " & lector("curso").ToString)
                        resultado.AppendLine("Asignatura: " & lector("nombreAsignatura").ToString)
                        resultado.AppendLine("Nota: " & lector("notaFinal").ToString)

                        resultado.AppendLine()
                    End While

                    txtMostrarCalificaciones.Text = resultado.ToString
                End Using
            End Using
        Catch ex As Exception
            MsgBox("no se pudo conectar" & ex.Message)
        End Try
    End Sub
End Class
