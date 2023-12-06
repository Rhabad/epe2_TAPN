<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnMostrarAlumnos = New Button()
        btnAgregarCalificacion = New Button()
        btnAgregarAlumno = New Button()
        btnMostrarCalificacion = New Button()
        txtRutAlumno = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        CboxCurso = New ComboBox()
        txtRutCalificaciones = New TextBox()
        txtNota = New TextBox()
        CBoxAsignatura = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 3
        Label4.Text = "Curso"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(17, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 22)
        Label5.TabIndex = 4
        Label5.Text = "Regristro De Alumnos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Stencil", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(17, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 22)
        Label6.TabIndex = 5
        Label6.Text = "Registro De Notas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 398)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 8
        Label7.Text = "Nota"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 361)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 15)
        Label8.TabIndex = 7
        Label8.Text = "Asignatura"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 324)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 15)
        Label9.TabIndex = 6
        Label9.Text = "Rut"
        ' 
        ' btnMostrarAlumnos
        ' 
        btnMostrarAlumnos.Location = New Point(179, 214)
        btnMostrarAlumnos.Name = "btnMostrarAlumnos"
        btnMostrarAlumnos.Size = New Size(138, 23)
        btnMostrarAlumnos.TabIndex = 9
        btnMostrarAlumnos.Text = "Mostrar Alumnos"
        btnMostrarAlumnos.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarCalificacion
        ' 
        btnAgregarCalificacion.Location = New Point(17, 429)
        btnAgregarCalificacion.Name = "btnAgregarCalificacion"
        btnAgregarCalificacion.Size = New Size(136, 23)
        btnAgregarCalificacion.TabIndex = 10
        btnAgregarCalificacion.Text = "Agregar Calificacion"
        btnAgregarCalificacion.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarAlumno
        ' 
        btnAgregarAlumno.Location = New Point(17, 214)
        btnAgregarAlumno.Name = "btnAgregarAlumno"
        btnAgregarAlumno.Size = New Size(136, 23)
        btnAgregarAlumno.TabIndex = 11
        btnAgregarAlumno.Text = "Agregar Alumno"
        btnAgregarAlumno.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarCalificacion
        ' 
        btnMostrarCalificacion.Location = New Point(179, 429)
        btnMostrarCalificacion.Name = "btnMostrarCalificacion"
        btnMostrarCalificacion.Size = New Size(138, 23)
        btnMostrarCalificacion.TabIndex = 12
        btnMostrarCalificacion.Text = "Mostrar Calificaciones"
        btnMostrarCalificacion.UseVisualStyleBackColor = True
        ' 
        ' txtRutAlumno
        ' 
        txtRutAlumno.Location = New Point(134, 60)
        txtRutAlumno.Name = "txtRutAlumno"
        txtRutAlumno.Size = New Size(144, 23)
        txtRutAlumno.TabIndex = 15
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(134, 98)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(144, 23)
        txtNombre.TabIndex = 16
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(134, 136)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(144, 23)
        txtApellido.TabIndex = 17
        ' 
        ' CboxCurso
        ' 
        CboxCurso.FlatStyle = FlatStyle.System
        CboxCurso.FormattingEnabled = True
        CboxCurso.ImeMode = ImeMode.NoControl
        CboxCurso.Items.AddRange(New Object() {"Curso A", "Curso B", "Curso C"})
        CboxCurso.Location = New Point(134, 174)
        CboxCurso.Name = "CboxCurso"
        CboxCurso.Size = New Size(144, 23)
        CboxCurso.TabIndex = 19
        ' 
        ' txtRutCalificaciones
        ' 
        txtRutCalificaciones.Location = New Point(144, 316)
        txtRutCalificaciones.Name = "txtRutCalificaciones"
        txtRutCalificaciones.Size = New Size(144, 23)
        txtRutCalificaciones.TabIndex = 20
        ' 
        ' txtNota
        ' 
        txtNota.Location = New Point(144, 390)
        txtNota.Name = "txtNota"
        txtNota.Size = New Size(54, 23)
        txtNota.TabIndex = 21
        ' 
        ' CBoxAsignatura
        ' 
        CBoxAsignatura.FlatStyle = FlatStyle.System
        CBoxAsignatura.FormattingEnabled = True
        CBoxAsignatura.ImeMode = ImeMode.NoControl
        CBoxAsignatura.Items.AddRange(New Object() {"Matemáticas.", "Historia.", "Ciencias."})
        CBoxAsignatura.Location = New Point(144, 353)
        CBoxAsignatura.Name = "CBoxAsignatura"
        CBoxAsignatura.Size = New Size(144, 23)
        CBoxAsignatura.TabIndex = 22
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(329, 462)
        Controls.Add(CBoxAsignatura)
        Controls.Add(txtNota)
        Controls.Add(txtRutCalificaciones)
        Controls.Add(CboxCurso)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRutAlumno)
        Controls.Add(btnMostrarCalificacion)
        Controls.Add(btnAgregarAlumno)
        Controls.Add(btnAgregarCalificacion)
        Controls.Add(btnMostrarAlumnos)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Registro de notas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnMostrarAlumnos As Button
    Friend WithEvents btnAgregarCalificacion As Button
    Friend WithEvents btnAgregarAlumno As Button
    Friend WithEvents btnMostrarCalificacion As Button
    Friend WithEvents txtRutAlumno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents CboxCurso As ComboBox
    Friend WithEvents txtRutCalificaciones As TextBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents CBoxAsignatura As ComboBox
End Class
