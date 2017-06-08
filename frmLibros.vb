Public Class frmLibros
    Dim opcion As Integer
    Dim primerRegistro As Integer
    Dim ultimoRegistro As Integer
    Dim primerregistro1 As Integer
    Dim posicionNuevo As Integer
    Dim posicionEditar As Integer
    'variable de reiniciado de formulario
    Public hasError As Boolean

    'controlamos en el load que el archivo exista, que no esté vacío y el comportamiento de los botones
    Private Sub frmLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicioCmb()
        contador = cont()
        picbCancelado.Visible = False

        'lblRegistro.Text = "Tamaño del archivo: " & contador

        hasError = False

        ultimo()
        primerobis()
        '"preguntamos" si existe
        If My.Computer.FileSystem.FileExists(rutaLibros) = False Then
            ficheroLibros = FreeFile()
            FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
            FileClose(ficheroLibros)
        End If

        'comprobamos que el fichero contiene datos
        If FileLen(rutaLibros) = 0 Then
            MsgBox("El archivo está vacío. Pulse NUEVO para introducir nuevos registros", vbInformation, "Aviso")
            datosEnabled(False)
            confirmarEnabled(False)
            menuEnabled(False)
            btnNuevo.Enabled = True
            recorridoEnabled(False)
        Else
            'Si contiene registros pero están eliminados
            If (primerregistro1 = ultimoRegistro And ultimoRegistro = 0) Then
                MsgBox("El Archivo sólo contiene registros borrados", vbInformation, "Aviso")
                datosEnabled(False)
                btnNuevo.Enabled = True
                btnBuscar.Enabled = True
                btnBorrar.Enabled = False
                btnEditar.Enabled = False
                recorridoEnabled(False)
                confirmarEnabled(False)
                'Si contiene un solo registro activo
            ElseIf (primerregistro1 = ultimoRegistro And ultimoRegistro <> 0) Then
                datosEnabled(False)
                menuEnabled(True)
                confirmarEnabled(False)
                primero()
                btnSig.Enabled = False
                btnFinal.Enabled = False
                'Si contiene más de un registro activo
            Else
                datosEnabled(False)
                menuEnabled(True)
                confirmarEnabled(False)
                primero()
            End If
        End If

    End Sub

    Private Sub txtISBN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISBN.KeyPress
        If InStr("0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ-," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    'botón de cerrar
    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub



    'Programamos el botón aceptar con una select con 3 casos: Nuevo, buscar y editar
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'controlamos que el archivo no haya sido corrompido y la posición
        errorArchivo()
        ultimo()
        primerobis()


        Select Case opcion

            Case 1 'NUEVO
                contador = cont()
                'Comprobamos que campo código contenga algún valor.
                If Trim(txtCod.Text) = "" Then
                    MsgBox("No se ha introducido ningún código", vbInformation, "Aviso")
                    txtCod.Focus()
                    'comprobamos que sea mayor que "0"
                ElseIf Trim(txtCod.Text = 0) Then
                    MsgBox("Introduzca un código entre 1 y 99.999", vbInformation, "Aviso")
                    txtCod.Focus()
                    txtCod.SelectAll()
                    'Comprobamos que, si existe un código igual pero borrado con anterioridad, nos deje darlo de alta de nuevo
                    '(la comprobación de si está eliminado la hago después.)
                ElseIf txtCod.Text = posicionNuevo Then
                    txtISBN.Focus()
                    If txtISBN.Text = "" Then
                        MsgBox("No se ha introducido ningún ISBN", vbInformation, "Información")
                        txtISBN.Focus()
                    ElseIf txtTitulo.Text = "" Then
                        MsgBox("No se ha introducido ningún título", vbInformation, "Información")
                        txtTitulo.Focus()
                    ElseIf txtAutor.Text = "" Then
                        MsgBox("No se ha introducido ningún Autor", vbInformation, "Información")
                        txtAutor.Focus()
                    ElseIf cmbEditorial.SelectedIndex = -1 Then
                        MsgBox("Porfavor seleccione una editorial", vbInformation, "Aviso")
                        cmbEditorial.Focus()
                    ElseIf dtpFecha.Value.Day > Now.Day Then
                        MsgBox("la fecha es incorrecta", vbInformation, "Aviso")
                        dtpFecha.Focus()

                    Else
                        baja = False
                        'Abrimos fichero e ingresamos los datos de pantalla
                        ficheroLibros = FreeFile()
                        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                        grabarDatos()
                        FilePut(ficheroLibros, regLibros, CInt(txtCod.Text))
                        FileClose(ficheroLibros)
                        MsgBox("El libro ha sido añadido", vbInformation, "Aviso")
                        primerobis()
                        ultimo()
                        If primerregistro1 <> ultimoRegistro And ultimoRegistro <> 0 Then
                            menuEnabled(True)
                            btnSig.Enabled = True
                            btnFinal.Enabled = True
                            btnAtras.Enabled = False
                            btnIni.Enabled = False
                            datosEnabled(False)
                            confirmarEnabled(False)
                            primero()
                        Else
                            datosEnabled(False)
                            confirmarEnabled(False)
                            menuEnabled(True)
                            recorridoEnabled(False)
                        End If
                    End If

                ElseIf Trim(txtCod.Text) <> "" Then
                    'Comprobamos que el código sea menor o igual que la longitud total del texto 
                    If CInt(txtCod.Text) <= contador And CInt(txtCod.Text) <> 0 Then
                        Try
                            ficheroLibros = FreeFile()
                            FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                            FileGet(ficheroLibros, regLibros, CInt(txtCod.Text))
                            'Si dentro del tamaño del archivo existe algún código (>0) es que tiene datos y está activo
                            If regLibros.codigo <> 0 Then
                                MsgBox("Ya existe un libro con ese código", vbInformation, "Aviso")
                                txtCod.SelectAll()
                                txtCod.Focus()
                                'ElseIf regLibros.codigo = 0 And regLibros.alquiler > 0.01 Then
                            ElseIf regLibros.codigo = 0 And regLibros.baja = True Then

                                'En esta parte del IF volveremos a dar de alta los registros borrados con anterioridad
                                'Serán registros con el códgo con valor "0" pero dentro de la longitud total del archivo
                                'cerramos primero el fichero (luego abrimos para ecribir) y realizamos comprobaciones.
                                'posicionEditar = txtCod.Text
                                FileClose(ficheroLibros)
                                posicionNuevo = txtCod.Text
                                posicionEditar = txtCod.Text
                                If MsgBox("El Libro fue borrado con anterioridad. Presione SI para trabajar sobre el anterior contenido o NO para dar de alta de forma normal", vbYesNo + vbQuestion, "Aviso") = vbYes Then
                                    picbCancelado.Visible = True
                                    mostrarDatos()
                                    txtCod.Text = posicionEditar
                                    btnEditar.Enabled = True
                                    btnEditar.PerformClick()
                                    posicionNuevo = -1
                                Else
                                    'cmbEditorial.Focus()
                                    txtISBN.Focus()
                                End If
                            Else
                                FileClose(ficheroLibros)
                                txtISBN.Focus()
                                If txtISBN.Text = "" Then
                                    MsgBox("No se ha introducido ninguna ISBN", vbInformation, "Información")
                                    txtISBN.Focus()
                                ElseIf txtTitulo.Text = "" Then
                                    MsgBox("No se ha introducido ningún título", vbInformation, "Información")
                                    txtTitulo.Focus()
                                ElseIf txtAutor.Text = "" Then
                                    MsgBox("No se ha introducido ningún Autor", vbInformation, "Información")
                                    txtAutor.Focus()
                                ElseIf cmbEditorial.SelectedIndex = -1 Then
                                    MsgBox("Porfavor seleccione una editorial", vbInformation, "Aviso")
                                    cmbEditorial.Focus()
                                ElseIf dtpFecha.Value.Day > Now.Day Then
                                    MsgBox("la fecha es incorrecta", vbInformation, "Aviso")
                                    dtpFecha.Focus()
                                Else
                                    baja = False
                                    ficheroLibros = FreeFile()
                                    FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                                    grabarDatos()
                                    FilePut(ficheroLibros, regLibros, CInt(txtCod.Text))
                                    FileClose(ficheroLibros)
                                    MsgBox("El libro ha sido añadido", vbInformation, "Aviso")
                                    primero()
                                    ultimo()
                                    If primerRegistro <> ultimoRegistro And ultimoRegistro <> 0 Then
                                        menuEnabled(True)
                                        btnSig.Enabled = True
                                        btnFinal.Enabled = True
                                        btnAtras.Enabled = False
                                        btnIni.Enabled = False
                                        datosEnabled(False)
                                        confirmarEnabled(False)
                                        primero()
                                    Else
                                        datosEnabled(False)
                                        confirmarEnabled(False)
                                        menuEnabled(True)
                                        recorridoEnabled(False)
                                    End If
                                End If
                            End If
                            'End If
                            'Cierra el fichero de vehículos
                            FileClose(ficheroLibros)
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
                        End Try
                        'Desde aquí serán nuevos registros fuera del tamaño total del archivo
                    Else
                        If txtCod.Text = 0 Then
                            MsgBox("Introduzca un código entre 1 y 999", vbInformation, "Aviso")
                            txtCod.SelectAll()
                            txtCod.Focus()
                        ElseIf txtISBN.Text = "" Then
                            MsgBox("No se ha introducido ningún ISBN", vbInformation, "Información")
                            txtISBN.Focus()
                        ElseIf txtTitulo.Text = "" Then
                            MsgBox("No se ha introducido ningún título", vbInformation, "Información")
                            txtTitulo.Focus()
                        ElseIf txtAutor.Text = "" Then
                            MsgBox("No se ha introducido ningún Autor", vbInformation, "Información")
                            txtAutor.Focus()
                        ElseIf cmbEditorial.SelectedIndex = -1 Then
                            MsgBox("Porfavor seleccione una editorial", vbInformation, "Aviso")
                            cmbEditorial.Focus()
                        ElseIf dtpFecha.Value.Day > Now.Day Then
                            MsgBox("la fecha es incorrecta", vbInformation, "Aviso")
                            dtpFecha.Focus()
                        Else
                            baja = False
                            dtpFechBaja.Value = Now
                            ficheroLibros = FreeFile()
                            FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                            grabarDatos()
                            FilePut(ficheroLibros, regLibros, CInt(txtCod.Text))
                            FileClose(ficheroLibros)
                            MsgBox("El libro ha sido añadido", vbInformation, "Aviso")
                            primero()
                            ultimo()
                            If primerRegistro <> ultimoRegistro And ultimoRegistro <> 0 Then
                                menuEnabled(True)
                                btnSig.Enabled = True
                                btnFinal.Enabled = True
                                btnAtras.Enabled = False
                                btnIni.Enabled = False
                                datosEnabled(False)
                                confirmarEnabled(False)
                                primero()
                            Else
                                datosEnabled(False)
                                confirmarEnabled(False)
                                menuEnabled(True)
                                recorridoEnabled(False)
                            End If
                        End If
                    End If
                Else
                    MsgBox("No se ha introducido ningún código", vbInformation, "Aviso")
                    txtCod.Focus()
                End If
                'lblRegistro.Text = "Tamaño del archivo: " & contador

                '===============================================================================================

            Case 2 'BUSCAR
                contador = cont()
                If Trim(txtCod.Text) <> "" Then
                    If CInt(txtCod.Text) <= contador And CInt(txtCod.Text) <> 0 Then
                        Try
                            ficheroLibros = FreeFile()
                            FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                            FileGet(ficheroLibros, regLibros, CInt(txtCod.Text))
                            'Comprobamos el código y si existe el registro nos lo muestra
                            If regLibros.codigo <> 0 Then
                                txtISBN.Text = regLibros.isbn
                                txtTitulo.Text = regLibros.titulo
                                txtAutor.Text = regLibros.autor
                                cmbEditorial.SelectedIndex = regLibros.editorial
                                dtpFecha.Text = regLibros.fechalta
                                dtpFechBaja.Text = regLibros.fechbaja
                                If My.Computer.FileSystem.FileExists("C:\Users\pc\Desktop\23_prjBACT\Imagenes\" & txtCod.Text & ".jpg") = True Then
                                    picLibro.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Imagenes\" & txtCod.Text & ".jpg")
                                Else
                                    picLibro.Image = Nothing
                                End If
                                FileClose(ficheroLibros)
                                primerobis()
                                ultimo()
                                'controlamos la situación del RECORRIDO
                                If primerregistro1 = ultimoRegistro Then
                                    datosEnabled(False)
                                    confirmarEnabled(False)
                                    menuEnabled(True)
                                    recorridoEnabled(False)
                                Else
                                    If txtCod.Text = ultimoRegistro Then
                                        menuEnabled(True)
                                        btnSig.Enabled = True
                                        btnFinal.Enabled = True
                                        btnAtras.Enabled = False
                                        btnIni.Enabled = False
                                        datosEnabled(False)
                                        confirmarEnabled(False)
                                    ElseIf txtCod.Text = primerregistro1 Then
                                        menuEnabled(True)
                                        btnSig.Enabled = True
                                        btnFinal.Enabled = True
                                        btnAtras.Enabled = False
                                        btnIni.Enabled = False
                                        datosEnabled(False)
                                        confirmarEnabled(False)
                                    Else
                                        menuEnabled(True)
                                        recorridoEnabled(True)
                                        datosEnabled(False)
                                        confirmarEnabled(False)
                                    End If
                                End If
                                'comprobamos si el registro fue dado de baja con anterioridad a través del campo código y precio (puesto que por defecto se graba a "0.00" y debe ser mayor de 1 céntimo)
                            ElseIf regLibros.codigo = 0 And regLibros.baja = True Then
                                posicionEditar = txtCod.Text
                                If MsgBox("El libro fue borrado con anterioridad ¿Desea ver los datos?", vbYesNo + vbQuestion, "Aviso") = vbYes Then
                                    picbCancelado.Visible = True
                                    dtpFechBaja.Visible = True
                                    lblBaja.Visible = True
                                    mostrarDatos()
                                    txtCod.Text = posicionEditar
                                    datosEnabled(False)
                                    menuEnabled(True)
                                    confirmarEnabled(False)

                                    MsgBox("Puede volver a dar el libro de alta y editar su contenido pulsando EDITAR o salir pulsando CANCELAR", vbInformation, "Aviso")
                                    btnAceptar.Enabled = False
                                    btnNuevo.Enabled = False
                                    btnBuscar.Enabled = False
                                    btnBorrar.Enabled = False
                                    btnCancelar.Enabled = True
                                    recorridoEnabled(False)
                                Else
                                    txtCod.SelectAll()
                                    txtCod.Focus()
                                End If
                                'End If
                            Else
                                MsgBox("El libro no existe", vbInformation, "Aviso")
                                txtCod.SelectAll()
                                txtCod.Focus()
                            End If
                            'Cierra el fichero de vehiculos
                            FileClose(ficheroLibros)
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
                        End Try
                    Else
                        MsgBox("El libro no existe", vbInformation, "Aviso")
                        txtCod.SelectAll()
                        txtCod.Focus()
                    End If
                Else
                    MsgBox("El campo codigo no puede estar vacío", vbInformation, "Aviso")
                    txtCod.Focus()
                End If

                '===============================================================================================

            Case 3 'EDITAR
                'comprobamos campos


                regLibros.codigo = posicionEditar
                If regLibros.codigo = 0 Then
                    MsgBox("El registro buscado se borró con anterioridad, no puede darlo de alta de nuevo", vbInformation, "Aviso")
                ElseIf txtCod.Text = "" Then
                    MsgBox("No se ha introducido ningún código", vbInformation, "Información")
                    txtCod.Focus()
                ElseIf txtISBN.Text = "" Then
                    MsgBox("No se ha introducido ninguna ISBN", vbInformation, "Información")
                    txtISBN.Focus()
                ElseIf txtTitulo.Text = "" Then
                    MsgBox("No se ha introducido ningún título", vbInformation, "Información")
                    txtTitulo.Focus()
                ElseIf txtAutor.Text = "" Then
                    MsgBox("No se ha introducido ningún Autor", vbInformation, "Información")
                    txtAutor.Focus()
                ElseIf cmbEditorial.SelectedIndex = -1 Then
                    MsgBox("Porfavor seleccione una editorial", vbInformation, "Aviso")
                    cmbEditorial.Focus()
                ElseIf dtpFecha.Value.Day > Now.Day Then
                    MsgBox("la fecha es incorrecta", vbInformation, "Aviso")
                    dtpFecha.Focus()
                Else
                    If MsgBox("Está seguro de que desea modificar los datos del libro?", vbQuestion + vbYesNo, "Modificar") = vbYes Then
                        baja = False
                        dtpFechBaja.Value = Now
                        ficheroLibros = FreeFile()
                        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                        grabarDatos()
                        FilePut(ficheroLibros, regLibros, CInt(txtCod.Text))
                        FileClose()
                        MsgBox("El libro ha sido editado / dado de alta de nuevo", vbInformation, "Aviso")
                        primerobis()
                        ultimo()
                        picbCancelado.Visible = False
                        lblBaja.Visible = False
                        dtpFechBaja.Visible = False
                        If primerregistro1 <> ultimoRegistro Then
                            menuEnabled(True)
                            btnSig.Enabled = True
                            btnFinal.Enabled = True
                            btnAtras.Enabled = False
                            btnIni.Enabled = False
                            datosEnabled(False)
                            confirmarEnabled(False)
                            primero()

                        Else
                            datosEnabled(False)
                            confirmarEnabled(False)
                            menuEnabled(True)
                            recorridoEnabled(False)
                            reinicio()
                            primero()
                            btnSig.Enabled = False
                            btnFinal.Enabled = False
                        End If
                    Else
                        'si no queremos editar tras la pregunta, nos devuelve en pantalla
                        'el fichero anterior (por si queremos editarlo de nuevo (quizás
                        'el usuario se equivocó al editar y quiere comenzar de 0))
                        'para salir ya está el btnCancelar
                        'le devolvemos la posición que habíamos guardado con anterioridad
                        'txtCod.Text = posicionEditar
                        'mostrarDatos()
                        txtISBN.Focus()

                    End If
                End If




                '===============================================================================================

            Case 4 'BORRAR
                If txtCod.Text = "" Then
                    MsgBox("Busque primero un registro para su borrado", vbInformation, "Aviso")
                Else
                    Try

                        If MsgBox("Quieres dar de baja este libro?", vbYesNo + vbQuestion, "Borrar") = vbYes Then

                            'Abrimos fichero y editamos el registro colocando un "cero" en el campo clave código
                            ficheroLibros = FreeFile()
                            FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                            FileGet(ficheroLibros, regLibros, CInt(txtCod.Text))
                            'Al ponerlo a "0" me dió ciertos problemas, sobre todo si  estamos en el último registro activo
                            regLibros.baja = True
                            regLibros.codigo = 0
                            regLibros.fechbaja = dtpFechBaja.Text
                            FilePut(ficheroLibros, regLibros, CInt(txtCod.Text))
                            MsgBox("Baja realizada", vbInformation, "Info")
                            FileClose(ficheroLibros)
                            'Aquí, cuando el último y el primer registro activos son el mismo (por lo tanto sólo queda uno) cambiamos el textCod a cero tan sólo para hacer la comprobación siguiente
                            'Si hacía la comprobación antes me da cierto error cuando ultimo() o primero() se igualan a cero.
                            If ultimoRegistro = primerregistro1 Then
                                txtCod.Text = 0
                            Else
                                txtCod.Text = txtCod.Text
                                primerobis()
                                ultimo()
                            End If

                            'No quedan registros activos, por lo tanto cajas vacías y sólo "nuevo" y "buscar" activos
                            If primerregistro1 = ultimoRegistro And (txtCod.Text = 0) Then
                                datosEnabled(False)
                                confirmarEnabled(False)
                                btnNuevo.Enabled = True
                                btnBuscar.Enabled = True
                                btnBorrar.Enabled = False
                                btnEditar.Enabled = False
                                recorridoEnabled(False)
                                reinicio()
                                MsgBox("El Archivo ya no contiene registros activos", vbInformation, "Aviso")
                                'Queda sólo un registro activo, desactivamos "recorrido"
                            ElseIf primerregistro1 = ultimoRegistro And primerregistro1 <> 0 Then
                                menuEnabled(True)
                                recorridoEnabled(False)
                                datosEnabled(False)
                                confirmarEnabled(False)
                                primero()
                                btnSig.Enabled = False
                                'Existen 2 registros activos o más, activamos todo
                            ElseIf primerregistro1 <> ultimoRegistro And primerregistro1 <> 0 Then
                                datosEnabled(False)
                                confirmarEnabled(False)
                                menuEnabled(True)
                                recorridoEnabled(False)
                                primero()
                            End If
                            'Si presionamos "no" a la pregunta de borrado tan sólo nos devuelve a la vista anterior y cierra archivo
                            lblBaja.Visible = False
                            dtpFechBaja.Visible = False
                            dtpFechBaja.Enabled = False
                        Else
                            FileClose(ficheroLibros)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
                    End Try
                End If
        End Select
    End Sub
    'Programamos el botón "NUEVO" y el comportamiento de los objetos
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        errorArchivo()
        'elegimos la opción 1 del select del botón aceptar
        opcion = 1
        reinicio()
        recorridoEnabled(False)
        menuEnabled(False)
        datosEnabled(True)
        txtCod.Focus()
        confirmarEnabled(True)
    End Sub

    'Programamos el botón "BUSCAR" y el comportamiento de los objetos
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        errorArchivo()
        'elegimos la opción 2 del select del botón Aceptar
        opcion = 2
        recorridoEnabled(False)
        menuEnabled(False)
        reinicio()
        datosEnabled(False)
        txtCod.Enabled = True
        confirmarEnabled(True)
        txtCod.Focus()
    End Sub

    'Programamos el botón "BORRAR" y el comportamiento de los objetos
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        'comprobamos que el archivo no esté corrupto y primer y último registro
        errorArchivo()
        contador = cont()
        ultimo()
        primerobis()
        lblBaja.Visible = True
        dtpFechBaja.Visible = True
        dtpFechBaja.Enabled = True
        dtpFechBaja.Focus()
        MsgBox("introduce una fecha de baja", vbInformation, "Aviso")
        menuEnabled(False)
        confirmarEnabled(True)
        opcion = 4

    End Sub

    'Programamos el botón "EDITAR" y el comportamiento de los objetos
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        errorArchivo()
        posicionEditar = txtCod.Text
        recorridoEnabled(False)
        menuEnabled(False)
        confirmarEnabled(True)
        datosEnabled(True)
        txtCod.Enabled = False
        txtISBN.Focus()
        dtpFechBaja.Enabled = False
        'elegimos la opción 3 del select del botón Aceptar
        opcion = 3
    End Sub

    'Programamos el botón "CANCELAR " y el comportamiento de los objetos
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        errorArchivo()
        'Reiniciamoss la variable "posición nuevo" a -1 para que no nos de problema con registros borrados
        posicionNuevo = -1
        primero()
        If baja = False Then
            picbCancelado.Visible = False
        Else
            picbCancelado.Visible = True
        End If
        If FileLen(rutaLibros) = 0 Then
            datosEnabled(False)
            confirmarEnabled(False)
            menuEnabled(False)
            btnNuevo.Enabled = True
            recorridoEnabled(False)
            'Si contiene registros pero están eliminados
        ElseIf primerregistro1 = ultimoRegistro And ultimoRegistro = 0 Then
            reinicio()
            datosEnabled(False)
            btnNuevo.Enabled = True
            btnBuscar.Enabled = True
            btnBorrar.Enabled = False
            btnEditar.Enabled = False
            recorridoEnabled(False)
            confirmarEnabled(False)
            picbCancelado.Enabled = False
            dtpFechBaja.Visible = False
            lblBaja.Visible = False
            'Si contiene un solo registro activo
        ElseIf primerregistro1 = ultimoRegistro And ultimoRegistro <> 0 Then
            datosEnabled(False)

            If txtCod.Text = "" Then
                reinicio()
                menuEnabled(False)
                btnNuevo.Enabled = True
                btnBuscar.Enabled = True
                confirmarEnabled(False)
                recorridoEnabled(False)
            Else
                primero()
                menuEnabled(True)
                confirmarEnabled(False)
                primero()
                btnSig.Enabled = False
                picbCancelado.Enabled = False
                dtpFechBaja.Visible = False
                lblBaja.Visible = False
            End If
            'Si contiene más de un registro activo
        Else
            datosEnabled(False)
            menuEnabled(True)
            confirmarEnabled(False)
            primero()
            picbCancelado.Enabled = False
            dtpFechBaja.Visible = False
            lblBaja.Visible = False
        End If
    End Sub

    '"Reinicio" de cajas 
    Private Sub reinicio()
        txtCod.Clear()
        txtISBN.Clear()
        txtTitulo.Clear()
        txtAutor.Clear()
        cmbEditorial.SelectedIndex = -1
        dtpFecha.Value = Now
        dtpFechBaja.Value = Now
        dtpFechBaja.Visible = False
        lblBaja.Visible = False
        picbCancelado.Visible = False
        picLibro.Image = Nothing
    End Sub
    'RUTINAS DE CAMPOS
    'Rutina para activar o desactivar los campos de "DATOS"
    Private Sub datosEnabled(ByVal i As Boolean)
        txtCod.Enabled = i
        txtISBN.Enabled = i
        txtTitulo.Enabled = i
        txtAutor.Enabled = i
        cmbEditorial.Enabled = i
        dtpFecha.Enabled = i
        dtpFechBaja.Enabled = i
        picLibro.Enabled = i
    End Sub
    'Rutina para activar o desactivar los campos de "OPCIONES"
    Private Sub menuEnabled(ByVal i As Boolean)
        btnNuevo.Enabled = i
        btnEditar.Enabled = i
        btnBorrar.Enabled = i
        btnBuscar.Enabled = i
    End Sub
    'Rutina para activar o desactivar los campos de "CONFIRMAR"
    Private Sub confirmarEnabled(ByVal i As Boolean)
        btnAceptar.Enabled = i
        btnCancelar.Enabled = i
    End Sub
    'Rutina para activar o desactivar los campos de "RECORRIDO"
    Private Sub recorridoEnabled(ByVal i As Boolean)
        btnSig.Enabled = i
        btnAtras.Enabled = i
        btnFinal.Enabled = i
        btnIni.Enabled = i
    End Sub

    'RUTINAS "GRABAR-LEER"
    'Rutina para mostrar datos
    Public Sub mostrarDatos()
        txtCod.Text = regLibros.codigo
        txtISBN.Text = regLibros.isbn
        txtTitulo.Text = regLibros.titulo
        txtAutor.Text = regLibros.autor
        cmbEditorial.SelectedIndex = regLibros.editorial
        dtpFecha.Text = regLibros.fechalta
        dtpFechBaja.Text = regLibros.fechbaja
        If My.Computer.FileSystem.FileExists("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCod.Text & ".jpg") = True Then
            picLibro.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCod.Text & ".jpg")
        Else
            picLibro.Image = Nothing
        End If
    End Sub
    'Rutina para grabar datos
    Private Sub grabarDatos()
        regLibros.codigo = txtCod.Text
        regLibros.isbn = txtISBN.Text
        regLibros.titulo = txtTitulo.Text
        regLibros.autor = txtAutor.Text
        regLibros.editorial = cmbEditorial.SelectedIndex
        regLibros.fechalta = dtpFecha.Text
        regLibros.baja = baja
        regLibros.fechbaja = fechbaja
    End Sub


    'Programamos el txtCod para que sólo admita números
    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    'Si se elimina el archivo de la rutaLibros o sucede algún error fatal durante la manipulación del mismo, La aplicación se reinicia
    Private Sub errorArchivo()
        If My.Computer.FileSystem.FileExists(rutaLibros) = False Then
            Me.hasError = True
            MsgBox("Problema con el archivo de origen. El programa se reiniciará", vbCritical, "Error!")
            Me.Close()
        End If
    End Sub
    'Programamos los botones de RECORRIDO
    'a través de un bucle while recorremos hacia delante o hacia atrás buscando el primer registro que no contenga un "0" (borrados y default)
    'Programamos el botón "siguiente registro"
    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        errorArchivo()
        Dim pos As Integer
        ultimo()
        'Declaramos una variable donde guardar la posición
        pos = CInt(txtCod.Text) + 1
        contador = cont()

        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        While pos <= contador
            FileGet(ficheroLibros, regLibros, pos) 'Aumentamos posicion

            If regLibros.codigo <> 0 Then
                mostrarDatos()
                btnIni.Enabled = True
                btnAtras.Enabled = True
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroLibros)
        'comparamos si es igual al último registro activo y si es así deshabilitamos botones
        If pos = ultimoRegistro Then
            btnSig.Enabled = False
            btnFinal.Enabled = False
        End If
    End Sub

    'Programamos el botón "anterior registro"
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        errorArchivo()

        'Declaramos una variable donde guardar la posición
        Dim pos As Integer
        'comparamos la posición final con la posición inicial
        primerobis()

        pos = CInt(txtCod.Text) - 1
        btnSig.Enabled = True
        contador = cont()

        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        While pos <= contador
            FileGet(ficheroLibros, regLibros, pos) 'disminuimos posicion
            If regLibros.codigo <> 0 Then
                'txtCod.Text = pos
                mostrarDatos()
                Exit While
            End If
            pos = pos - 1
            btnSig.Enabled = True
            btnFinal.Enabled = True

        End While
        FileClose(ficheroLibros)
        'comparamos si es igual al primer registro activo y si es así deshabilitamos botones
        If pos = primerregistro1 Then
            btnAtras.Enabled = False
            btnIni.Enabled = False
        End If
    End Sub

    'Programamos una rutina que nos lleve al primer registro activo que se encuentre en el archivo y mostrarlo
    'La usaremos para posicionar el puntero en varios botones
    Private Sub primero()

        Dim pos As Integer
        txtCod.Text = 0
        pos = txtCod.Text + 1
        contador = cont()

        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        While pos <= contador
            FileGet(ficheroLibros, regLibros, pos) 'Aumentamos posicion

            If regLibros.codigo <> 0 Then
                mostrarDatos()
                primerRegistro = txtCod.Text
                btnAtras.Enabled = False
                btnSig.Enabled = True
                btnIni.Enabled = False
                btnFinal.Enabled = True
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroLibros)
        If txtCod.Text = 0 Then
            txtCod.Text = ""
        End If
    End Sub
    'Subrutinas que usaremos para localizar el primer y último registro activos
    'Subrutina que usaremos para localizar el ultimo registro activo
    Private Sub ultimo()

        Dim posFinal As Integer
        posFinal = contador
        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        While posFinal <= contador
            If posFinal = 0 Then
                Exit While
            End If
            FileGet(ficheroLibros, regLibros, posFinal) 'Aumentamos posicion
            If regLibros.codigo <> 0 Then
                ultimoRegistro = regLibros.codigo
                Exit While
            End If
            posFinal = posFinal - 1
        End While
        FileClose(ficheroLibros)
    End Sub

    'Subrutina que usaremos para localizar el primer registro activo
    Private Sub primerobis()
        Dim pos As Integer
        regLibros.codigo = 0
        pos = regLibros.codigo + 1
        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        While pos <= contador
            FileGet(ficheroLibros, regLibros, pos) 'Aumentamos posicion

            If regLibros.codigo <> 0 Then
                primerregistro1 = regLibros.codigo
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroLibros)
    End Sub

    'Programamos boton final
    Private Sub btnIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIni.Click
        errorArchivo()
        primero()
    End Sub

    'programamos botón inicio
    Private Sub btnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinal.Click
        errorArchivo()
        ultimo()
        mostrarDatos()
        btnFinal.Enabled = False
        btnSig.Enabled = False
        btnAtras.Enabled = True
        btnIni.Enabled = True
    End Sub

    Private Sub picLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLibro.Click
        Dim exists As Boolean
        exists = System.IO.File.Exists("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCod.Text & ".jpg")
        Dim nombre As String
        nombre = opfCargaPic.FileName()
        If opfCargaPic.ShowDialog() = DialogResult.Cancel Then
            
        Else


            If exists = True Then
                MsgBox("ya existe una imagen con ese nombre, vaya al archivo de imagenes", vbInformation, "Aviso")
            Else
                My.Computer.FileSystem.RenameFile(nombre, txtCod.Text & ".jpg")
                picLibro.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCod.Text & ".jpg")
                MsgBox("Diego puto")
                'picLibro.Enabled = False

            End If
        End If
    End Sub
End Class
