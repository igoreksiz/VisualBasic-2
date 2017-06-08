Public Class frmSocios
    'variable que hará que el formulario se reinicie
    Public hasError As Boolean
    Dim primerRegistro As Integer
    Dim ultimoRegistro As Integer
    Dim primerregistro1 As Integer
    Dim posicionNuevo As Integer
    Dim opcion As Integer
    Dim posicionEditar As Integer

    'controlamos valores del load
    Private Sub frmSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        contadorSocios = contS()
        lblRegistro.Text = "Tamaño del archivo: " & contadorSocios

        hasError = False
        'controlamos en el load que el archivo exista, que no esté vacío y el comportamiento de los botones
        ultimo()
        primerobis()

        If My.Computer.FileSystem.FileExists(rutaSocios) = False Then
            ficheroSocios = FreeFile()
            FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
            FileClose(ficheroSocios)
        End If

        'comprobamos que el fichero contiene datos
        If FileLen(rutaSocios) = 0 Then
            MsgBox("El archivo está vacío. Pulse NUEVO para introducir nuevos registros", vbInformation, "Aviso")
            datosEnabled(False)
            confirmarEnabled(False)
            menuEnabled(False)
            btnNuevo.Enabled = True
            recorridoEnabled(False)
        Else
            'Si contiene registros pero están eliminados
            If (primerregistro1 = ultimoRegistro And ultimoRegistro = 0) Then
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

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        errorArchivo()
        ultimo()
        primerobis()


        Select Case opcion

            Case 1 'NUEVO
                contadorSocios = contS()
                'Comprobamos que campo código contenga algún valor.
                If Trim(txtCod.Text) = "" Then
                    MsgBox("No se ha introducido ningún código", vbInformation, "Aviso")
                    txtCod.Focus()
                    'comprobamos que sea mayor que "0"
                ElseIf Trim(txtCod.Text = 0) Then
                    MsgBox("Introduzca un código entre 1 y 999", vbInformation, "Aviso")
                    txtCod.Focus()
                    txtCod.SelectAll()
                    'Comrpobamos que, si existe un código igual pero borrado con anterioridad, nos deje darlo de alta de nuevo
                    '(la comprobación de si está eliminado la hago después.)
                ElseIf txtCod.Text = posicionNuevo Then
                    txtNif.Focus()

                    If txtNif.Text = "" Then
                        MsgBox("No se ha introducido ningún NIF", vbInformation, "Información")
                        txtNif.Focus()
                    ElseIf txtApe1.Text = "" Then
                        MsgBox("No se ha introducido ningún primer apellido", vbInformation, "Información")
                        txtApe1.Focus()
                    ElseIf txtApe2.Text = "" Then
                        MsgBox("No se ha introducido ningún segundo apellido", vbInformation, "Información")
                        txtApe2.Focus()
                    ElseIf txtNom.Text = "" Then
                        MsgBox("No se ha introducido ningún nombre", vbInformation, "Información")
                        txtNom.Focus()

                    ElseIf txtDir.Text = "" Then
                        MsgBox("No se ha introducido ninguna dirección", vbInformation, "Información")
                        txtDir.Focus()
                    ElseIf txtPob.Text = "" Then
                        MsgBox("No se ha introducido ninguna población", vbInformation, "Información")
                        txtPob.Focus()
                    ElseIf txtCP.Text = "" Then
                        MsgBox("No se ha introducido ningún código postal", vbInformation, "Información")
                        txtCP.Focus()
                    Else
                        'Abrimos fichero e ingresamos los datos de pantalla
                        ficheroSocios = FreeFile()
                        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                        grabarDatos()
                        FilePut(ficheroSocios, regSocios, CInt(txtCod.Text))
                        FileClose(ficheroSocios)
                        MsgBox("El registro ha sido añadido", vbInformation, "Aviso")
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
                    If CInt(txtCod.Text) <= contadorSocios And CInt(txtCod.Text) <> 0 Then
                        Try
                            ficheroSocios = FreeFile()
                            FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                            FileGet(ficheroSocios, regSocios, CInt(txtCod.Text))
                            'Si dentro del tamaño del archivo existe algún código (>0) es que tiene datos y está activo
                            If regSocios.codigoSocios <> 0 Then
                                MsgBox("Ya existe un registro con ese código", vbInformation, "Aviso")
                                txtCod.SelectAll()
                                txtCod.Focus()
                            ElseIf regSocios.codigoSocios = 0 And bajaSocios = True Then

                                'En esta parte del IF volveremos a dar de alta los registros borrados con anterioridad
                                'Serán registros con el códgo con valor "0" pero dentro de la longitud total del archivo
                                'cerramos primero el fichero (luego abrimos para ecribir) y realizamos comprobaciones.
                                'posicionEditar = txtCod.Text
                                FileClose(ficheroSocios)
                                posicionNuevo = txtCod.Text
                                posicionEditar = txtCod.Text
                                If MsgBox("El registro fue borrado con anterioridad. Presione SI para trabajar sobre el anterior contenido o NO para dar de alta de forma normal", vbYesNo + vbQuestion, "Aviso") = vbYes Then
                                    mostrarDatos()
                                    txtCod.Text = posicionEditar
                                    btnEditar.Enabled = True
                                    btnEditar.PerformClick()
                                    posicionNuevo = -1
                                Else
                                    txtNif.Focus()
                                End If
                            Else
                                FileClose(ficheroSocios)
                                If txtNif.Text = "" Then
                                    MsgBox("No se ha introducido ningún NIF", vbInformation, "Información")
                                    txtNif.Focus()
                                ElseIf txtApe1.Text = "" Then
                                    MsgBox("No se ha introducido ningún primer apellido", vbInformation, "Información")
                                    txtApe1.Focus()
                                ElseIf txtApe2.Text = "" Then
                                    MsgBox("No se ha introducido ningún segundo apellido", vbInformation, "Información")
                                    txtApe2.Focus()
                                ElseIf txtNom.Text = "" Then
                                    MsgBox("No se ha introducido ningún nombre", vbInformation, "Información")
                                    txtNom.Focus()

                                ElseIf txtDir.Text = "" Then
                                    MsgBox("No se ha introducido ninguna dirección", vbInformation, "Información")
                                    txtDir.Focus()
                                ElseIf txtPob.Text = "" Then
                                    MsgBox("No se ha introducido ninguna población", vbInformation, "Información")
                                    txtPob.Focus()
                                ElseIf txtCP.Text = "" Then
                                    MsgBox("No se ha introducido ningún código postal", vbInformation, "Información")
                                    txtCP.Focus()
                                Else
                                    ficheroSocios = FreeFile()
                                    FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                                    grabarDatos()
                                    FilePut(ficheroSocios, regSocios, CInt(txtCod.Text))
                                    FileClose(ficheroSocios)
                                    MsgBox("El registro ha sido añadido", vbInformation, "Aviso")
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
                            FileClose(ficheroSocios)
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
                        End Try
                        'Desde aquí serán nuevos registros fuera del tamaño total del archivo
                    Else
                        If txtCod.Text = 0 Then
                            MsgBox("Introduzca un código entre 1 y 999", vbInformation, "Aviso")
                            txtCod.SelectAll()
                            txtCod.Focus()

                        ElseIf txtNif.Text = "" Then
                            MsgBox("No se ha introducido ningún NIF", vbInformation, "Información")
                            txtNif.Focus()
                        ElseIf txtApe1.Text = "" Then
                            MsgBox("No se ha introducido ningún primer apellido", vbInformation, "Información")
                            txtApe1.Focus()
                        ElseIf txtApe2.Text = "" Then
                            MsgBox("No se ha introducido ningún segundo apellido", vbInformation, "Información")
                            txtApe2.Focus()
                        ElseIf txtNom.Text = "" Then
                            MsgBox("No se ha introducido ningún nombre", vbInformation, "Información")
                            txtNom.Focus()

                        ElseIf txtDir.Text = "" Then
                            MsgBox("No se ha introducido ninguna dirección", vbInformation, "Información")
                            txtDir.Focus()
                        ElseIf txtPob.Text = "" Then
                            MsgBox("No se ha introducido ninguna población", vbInformation, "Información")
                            txtPob.Focus()
                        ElseIf txtCP.Text = "" Then
                            MsgBox("No se ha introducido ningún código postal", vbInformation, "Información")
                            txtCP.Focus()
                        Else
                            ficheroSocios = FreeFile()
                            FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                            grabarDatos()
                            FilePut(ficheroSocios, regSocios, CInt(txtCod.Text))
                            FileClose(ficheroSocios)
                            MsgBox("El registro ha sido añadido", vbInformation, "Aviso")
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
                lblRegistro.Text = "Tamaño del archivo: " & contadorSocios

                '===============================================================================================

            Case 2 'BUSCAR
                contadorSocios = contS()
                If Trim(txtCod.Text) <> "" Then
                    If CInt(txtCod.Text) <= contadorSocios And CInt(txtCod.Text) <> 0 Then
                        Try
                            ficheroSocios = FreeFile()
                            FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                            FileGet(ficheroSocios, regSocios, CInt(txtCod.Text))
                            'Comprobamos el código y si existe el registro nos lo muestra
                            If regSocios.codigoSocios <> 0 Then
                                txtNif.Text = regSocios.nif
                                txtApe1.Text = regSocios.apellido1
                                txtApe2.Text = regSocios.apellido2
                                txtNom.Text = regSocios.nombre
                                txtDir.Text = regSocios.direccion
                                txtPob.Text = regSocios.poblacion
                                txtCP.Text = regSocios.codPostal
                                dtpFechNac.Text = regSocios.fechNac
                                dtpFechBaj.Text = regSocios.fechbajaSocios
                                FileClose(ficheroSocios)
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
                                        btnSig.Enabled = False
                                        btnFinal.Enabled = False
                                        btnAtras.Enabled = True
                                        btnIni.Enabled = True
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
                                'comprobamos si el registro fue dado d ebaja con anterioridad a través del campo código y precio (puesto que por defecto se graba a "0" y debe ser mayor de 1 céntimo)
                            ElseIf regSocios.codigoSocios = 0 And bajaSocios = True Then
                                posicionEditar = txtCod.Text
                                If MsgBox("El registro fue borrado con anterioridad ¿Desea ver los datos?", vbYesNo + vbQuestion, "Aviso") = vbYes Then
                                    mostrarDatos()
                                    txtCod.Text = posicionEditar
                                    datosEnabled(False)
                                    menuEnabled(True)
                                    confirmarEnabled(False)

                                    MsgBox("Puede volver a dar el registro de alta y editar su contenido pulsando EDITAR o salir pulsando CANCELAR", vbInformation, "Aviso")
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
                                MsgBox("El registro no ha sido encontrado.", vbInformation, "Aviso")
                                txtCod.SelectAll()
                                txtCod.Focus()
                            End If
                            'Cierra el fichero de vehiculos
                            FileClose(ficheroSocios)
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
                        End Try
                    Else
                        MsgBox("El registro no ha sido encontrado.", vbInformation, "Aviso")
                        txtCod.SelectAll()
                        txtCod.Focus()
                    End If
                Else
                    MsgBox("El campo codigo no puede estar vacio", vbInformation, "Aviso")
                    txtCod.Focus()
                End If

                '===============================================================================================

            Case 3 'EDITAR
                'comprobamos campos
                regSocios.codigoSocios = posicionEditar
                If regSocios.codigoSocios = 0 Then
                    MsgBox("El registro buscado se borró con anterioridad, no puede darlo de alta de nuevo", vbInformation, "Aviso")
                ElseIf txtCod.Text = "" Then
                    MsgBox("No se ha introducido ningún código", vbInformation, "Información")
                    txtCod.Focus()

                ElseIf txtNif.Text = "" Then
                    MsgBox("No se ha introducido ningún NIF", vbInformation, "Información")
                    txtNif.Focus()
                ElseIf txtApe1.Text = "" Then
                    MsgBox("No se ha introducido ningún primer apellido", vbInformation, "Información")
                    txtApe1.Focus()
                ElseIf txtApe2.Text = "" Then
                    MsgBox("No se ha introducido ningún segundo apellido", vbInformation, "Información")
                    txtApe2.Focus()
                ElseIf txtNom.Text = "" Then
                    MsgBox("No se ha introducido ningún nombre", vbInformation, "Información")
                    txtNom.Focus()

                ElseIf txtDir.Text = "" Then
                    MsgBox("No se ha introducido ninguna dirección", vbInformation, "Información")
                    txtDir.Focus()
                ElseIf txtPob.Text = "" Then
                    MsgBox("No se ha introducido ninguna población", vbInformation, "Información")
                    txtPob.Focus()
                ElseIf txtCP.Text = "" Then
                    MsgBox("No se ha introducido ningún código postal", vbInformation, "Información")
                    txtCP.Focus()
                Else
                    If MsgBox("Está seguro de que desea modificar el registro?", vbQuestion + vbYesNo, "Modificar") = vbYes Then

                        ficheroSocios = FreeFile()
                        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                        grabarDatos()
                        FilePut(ficheroSocios, regSocios, CInt(txtCod.Text))
                        FileClose()
                        MsgBox("El registro ha sido editado", vbInformation, "Aviso")
                        primerobis()
                        ultimo()
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
                        datosEnabled(False)
                        menuEnabled(True)
                        confirmarEnabled(False)

                        'le devolvemos la posición que habíamos guardado con anterioridad
                        txtCod.Text = posicionEditar
                        mostrarDatos()
                    End If
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
        errorArchivo()
        contador = cont()
        ultimo()
        primerobis()
        menuEnabled(False)
        confirmarEnabled(True)
        opcion = 4
    End Sub

    'Programamos el botón "EDITAR" y el comportamiento de los objetos
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

    End Sub

    'Programamos el botón "CANCELAR " y el comportamiento de los objetos
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        errorArchivo()

        'Reiniciamoss la variable "posición nuevo" a -1 para que no nos de problema con registros borrados
        posicionNuevo = -1
        primero()
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
            End If
            'Si contiene más de un registro activo
        Else
            datosEnabled(False)
            menuEnabled(True)
            confirmarEnabled(False)
            primero()
        End If
    End Sub

    '"Reinicio" de cajas 
    Private Sub reinicio()
        txtCod.Clear()
        txtNif.Clear()
        txtApe1.Clear()
        txtApe2.Clear()
        txtNom.Clear()
        txtDir.Clear()
        txtCP.Clear()
        dtpFechNac.Value = Now
        dtpFechBaj.Value = Now
    End Sub
    'RUTINAS DE CAMPOS
    'Rutina para activar o desactivar los campos de "DATOS"
    Private Sub datosEnabled(ByVal i As Boolean)
        txtCod.Enabled = i
        txtNif.Enabled = i
        txtApe1.Enabled = i
        txtApe2.Enabled = i
        txtNom.Enabled = i
        txtDir.Enabled = i
        txtPob.Enabled = i
        txtCP.Enabled = i
        dtpFechNac.Enabled = i
        dtpFechBaj.Enabled = i
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
        btnIni.Enabled = i
        btnSig.Enabled = i
        btnFinal.Enabled = i
        btnAtras.Enabled = i
    End Sub

    'RUTINAS "GRABAR-LEER"
    'Rutina para mostrar datos
    Public Sub mostrarDatos()
        txtCod.Text = regSocios.codigoSocios
        txtNif.Text = regSocios.nif
        txtApe1.Text = regSocios.apellido1
        txtApe2.Text = regSocios.apellido2
        txtNom.Text = regSocios.nombre
        txtDir.Text = regSocios.direccion
        txtPob.Text = regSocios.poblacion
        txtCP.Text = regSocios.codPostal
        dtpFechNac.Text = regSocios.fechNac
        dtpFechBaj.Text = regSocios.fechbajaSocios
    End Sub
    'Rutina para grabar datos
    Private Sub grabarDatos()
        regSocios.codigoSocios = txtCod.Text
        regSocios.nif = txtNif.Text
        regSocios.apellido1 = txtApe1.Text
        regSocios.apellido2 = txtApe2.Text
        regSocios.nombre = txtNom.Text
        regSocios.direccion = txtDir.Text
        regSocios.poblacion = txtPob.Text
        regSocios.codPostal = txtCP.Text
        regSocios.fechNac = dtpFechNac.Text
        regSocios.fechbajaSocios = dtpFechBaj.Text
    End Sub

    'PROGRAMAMOS LAS MÁSCARAS QUE NECESITEMOS
    'Programamos el txtCod para que sólo admita números
    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    'Si se elimina el archivo de la rutaSocios o sucede algún error fatal durante la manipulación del mismo, La aplicación se reinicia
    Private Sub errorArchivo()
        If My.Computer.FileSystem.FileExists(rutaSocios) = False Then
            Me.hasError = True
            MsgBox("Problema con el archivo de origen. El programa se reiniciará", vbCritical, "Error!")
            Me.Close()
        End If
    End Sub
    'Programamos los botones de RECORRIDO
    'a través de un bucle while recorremos hacia delante o hacia atrás buscando el primer registro que no contenga un "0" (borrados y default)
    'Programamos el botón "primer registro"
    Private Sub btnIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIni.Click
        errorArchivo()
        primero()
    End Sub

    'Programamos el botón "siguiente registro"
    Private Sub btnSig_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        errorArchivo()
        Dim pos As Integer
        ultimo()
        'Declaramos una variable donde guardar la posición
        pos = CInt(txtCod.Text) + 1
        contadorSocios = contS()

        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        While pos <= contadorSocios
            FileGet(ficheroSocios, regSocios, pos) 'Aumentamos posicion

            If regSocios.codigoSocios <> 0 Then
                mostrarDatos()
                btnAtras.Enabled = True
                btnIni.Enabled = True
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroSocios)
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
        btnFinal.Enabled = True
        contadorSocios = contS()

        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        While pos <= contadorSocios
            FileGet(ficheroSocios, regSocios, pos) 'disminuimos posicion
            If regSocios.codigoSocios <> 0 Then
                'txtCod.Text = pos
                mostrarDatos()
                Exit While
            End If
            pos = pos - 1
            btnSig.Enabled = True
            btnFinal.Enabled = True
        End While
        FileClose(ficheroSocios)
        'comparamos si es igual al primer registro activo y si es así deshabilitamos botones
        If pos = primerregistro1 Then
            btnAtras.Enabled = False
            btnIni.Enabled = False
        End If
    End Sub
    'rpogramamos en botón "registro final"
    Private Sub btnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinal.Click
        errorArchivo()
        ultimo()
        mostrarDatos()
        btnFinal.Enabled = False
        btnSig.Enabled = False
        btnAtras.Enabled = True
        btnIni.Enabled = True
    End Sub

    'Programamos una rutina que nos lleve al primer registro activo que se encuentre en el archivo
    'La usaremos para posicionar el puntero en varios botones
    Private Sub primero()

        Dim pos As Integer
        txtCod.Text = 0
        pos = txtCod.Text + 1
        contadorSocios = contS()

        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        While pos <= contadorSocios
            FileGet(ficheroSocios, regSocios, pos) 'Aumentamos posicion

            If regSocios.codigoSocios <> 0 Then
                mostrarDatos()
                primerRegistro = txtCod.Text
                btnAtras.Enabled = False
                btnIni.Enabled = False
                btnFinal.Enabled = True
                btnSig.Enabled = True
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroSocios)
        If txtCod.Text = 0 Then
            txtCod.Text = ""
        End If
    End Sub
    'Subrutinas que usaremos para localizar el primer y último registro activos
    'Subrutina que usaremos para localizar el ultimo registro activo
    Private Sub ultimo()

        Dim posFinal As Integer
        posFinal = contadorSocios
        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        While posFinal <= contadorSocios
            If posFinal = 0 Then
                Exit While
            End If
            FileGet(ficheroSocios, regSocios, posFinal) 'Aumentamos posicion
            If regSocios.codigoSocios <> 0 Then
                ultimoRegistro = regSocios.codigoSocios
                Exit While
            End If
            posFinal = posFinal - 1
        End While
        FileClose(ficheroSocios)
    End Sub
    'Subrutina que usaremos para localizar el primer registro activo
    Private Sub primerobis()
        Dim pos As Integer
        regSocios.codigoSocios = 0
        pos = regSocios.codigoSocios + 1
        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        While pos <= contadorSocios
            FileGet(ficheroSocios, regSocios, pos) 'Aumentamos posicion

            If regSocios.codigoSocios <> 0 Then
                primerregistro1 = regSocios.codigoSocios
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroSocios)
    End Sub
End Class
