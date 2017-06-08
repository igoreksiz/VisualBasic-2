Public Class frmPrestamos
    Public hasError As Boolean
    Dim primerRegistro As Integer
    Dim ultimoRegistro As Integer
    Dim primerregistro1 As Integer
    Dim posicionNuevo As Integer
    Dim opcion As Integer
    Dim posicionEditar As Integer

    Private Sub frmPrestamos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        contadorPrestamos = contP()
        lblRegistro.Text = "Tamaño del archivo: " & contadorPrestamos

        hasError = False
        'controlamos en el load que el archivo exista, que no esté vacío y el comportamiento de los botones
        ultimo()
        primerobis()

        If My.Computer.FileSystem.FileExists(rutaPrestamos) = False Then
            ficheroPrestamos = FreeFile()
            FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
            FileClose(ficheroPrestamos)
        End If

        'comprobamos que el fichero contiene datos
        If FileLen(rutaPrestamos) = 0 Then
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
                'btnBorrar.Enabled = False
                'btnEditar.Enabled = False
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
                contadorPrestamos = contP()
                contador = cont()
                contadorSocios = contS()

                If Trim(txtCod.Text) = "" Then
                    MsgBox("No se ha introducido ningún código", vbInformation, "Aviso")
                    txtCod.Focus()

                ElseIf Trim(txtCod.Text = 0) Then
                    MsgBox("Introduzca un código entre 1 y 999", vbInformation, "Aviso")
                    txtCod.Focus()
                    txtCod.SelectAll()
                    
                ElseIf txtCodLibro.Text = "" Then
                    MsgBox("No se ha introducido ningún codigo libro", vbInformation, "Información")
                    txtCodLibro.Focus()
                ElseIf Trim(txtCodLibro.Text) <> "" Then
                    If CInt(txtCodLibro.Text) <= contador And CInt(txtCodLibro.Text) <> 0 Then
                        ficheroLibros = FreeFile()
                        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                        FileGet(ficheroLibros, regLibros, CInt(txtCodLibro.Text))
                        'Comprobamos el código y si existe el registro nos lo muestra
                        If regLibros.codigo <> 0 Then
                            MsgBox("existe")
                            If txtCodSocio.Text = "" Then
                                MsgBox("No se ha introducido ningún codigo socio", vbInformation, "Información")

                            ElseIf Trim(txtCodSocio.Text) <> "" Then
                                If CInt(txtCodSocio.Text) <= contadorSocios And CInt(txtCodSocio.Text) <> 0 Then

                                    ficheroSocios = FreeFile()
                                    FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                                    FileGet(ficheroSocios, regSocios, CInt(txtCodSocio.Text))
                                    'Comprobamos el código y si existe el registro nos lo muestra
                                    If regSocios.codigoSocios <> 0 Then
                                        MsgBox("existe")
                                        ficheroPrestamos = FreeFile()
                                        FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
                                        grabarDatos()
                                        FilePut(ficheroPrestamos, regPrestamos, CInt(txtCod.Text))
                                        FileClose(ficheroPrestamos)
                                        MsgBox("El registro ha sido añadido", vbInformation, "Aviso")
                                        If My.Computer.FileSystem.FileExists("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCodLibro.Text & ".jpg") = True Then
                                            picLibro.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Libros\" & txtCodLibro.Text & ".jpg")
                                        Else
                                            picLibro.Image = Nothing
                                        End If
                                        If My.Computer.FileSystem.FileExists("C:\Users\pc\Desktop\23_prjBACT\Socios\" & txtCodSocio.Text & ".jpg") = True Then
                                            picSocio.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Socios\" & txtCodSocio.Text & ".jpg")
                                        Else
                                            picSocio.Image = Nothing
                                        End If
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
                                    Else
                                        MsgBox("El fichero socios no existe")
                                        txtCodSocio.Focus()
                                        txtCodSocio.SelectAll()
                                    End If
                                    Else
                                        MsgBox("El fichero socios no existe")
                                    End If
                                FileClose(ficheroLibros)
                            Else
                                MsgBox("El fichero libros no existe")
                                txtCodLibro.Focus()
                                txtCodLibro.SelectAll()
                            End If
                        Else
                            MsgBox("El fichero libros no existe")
                            txtCodLibro.Focus()
                            txtCodLibro.SelectAll()
                        End If
                        FileClose(ficheroLibros)
                    End If
                End If


                'If txtCodSocio.Text = "" Then
                '    MsgBox("No se ha introducido ningún codigo socio", vbInformation, "Información")

                'ElseIf Trim(txtCodSocio.Text) <> "" Then
                '    If CInt(txtCodSocio.Text) <= contadorSocios And CInt(txtCodSocio.Text) <> 0 Then

                '        ficheroSocios = FreeFile()
                '        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                '        FileGet(ficheroSocios, regSocios, CInt(txtCodSocio.Text))
                '        'Comprobamos el código y si existe el registro nos lo muestra
                '        If regSocios.codigoSocios <> 0 Then
                '            MsgBox("existe")
                '        Else
                '            MsgBox("El fichero no existe")
                '            txtCodSocio.Focus()
                '            txtCodSocio.SelectAll()
                '        End If
                '    Else
                '        MsgBox("El fichero no existe")
                '    End If
                '    FileClose(ficheroLibros)

                'Else
                '    'Abrimos fichero e ingresamos los datos de pantalla
                '    ficheroPrestamos = FreeFile()
                '    FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
                '    grabarDatos()
                '    FilePut(ficheroPrestamos, regPrestamos, CInt(txtCod.Text))
                '    FileClose(ficheroPrestamos)
                '    MsgBox("El registro ha sido añadido", vbInformation, "Aviso")
                '    primerobis()
                '    ultimo()
                '    If primerregistro1 <> ultimoRegistro And ultimoRegistro <> 0 Then
                '        menuEnabled(True)
                '        btnSig.Enabled = True
                '        btnFinal.Enabled = True
                '        btnAtras.Enabled = False
                '        btnIni.Enabled = False
                '        datosEnabled(False)
                '        confirmarEnabled(False)
                '        primero()
                '    Else
                '        datosEnabled(False)
                '        confirmarEnabled(False)
                '        menuEnabled(True)
                '        recorridoEnabled(False)
                '    End If
                'End If
                'End If

                '    lblRegistro.Text = "Tamaño del archivo: " & contador


                '===============================================================================================

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
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        errorArchivo()
        'elegimos la opción 2 del select del botón Aceptar
        opcion = 2
        recorridoEnabled(False)
        menuEnabled(False)
        reinicio()
        datosEnabled(False)
        txtCodSocio.Enabled = True
        confirmarEnabled(True)
        txtCodSocio.Focus()
    End Sub

    'Programamos el botón "BORRAR" y el comportamiento de los objetos
    'Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

    'End Sub

    ''Programamos el botón "EDITAR" y el comportamiento de los objetos
    'Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

    'End Sub

    'Programamos el botón "CANCELAR " y el comportamiento de los objetos
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

    End Sub

    '"Reinicio" de cajas 
    Private Sub reinicio()
        txtCod.Clear()
        txtCodLibro.Clear()
        txtCodSocio.Clear()

        dtpFecha.Value = Now
    End Sub
    'RUTINAS DE CAMPOS
    'Rutina para activar o desactivar los campos de "DATOS"
    Private Sub datosEnabled(ByVal i As Boolean)
        txtCod.Enabled = i
        txtCodLibro.Enabled = i
        txtCodSocio.Enabled = i
        dtpFecha.Enabled = i
    End Sub
    'Rutina para activar o desactivar los campos de "OPCIONES"
    Private Sub menuEnabled(ByVal i As Boolean)
        btnNuevo.Enabled = i
        ' btnEditar.Enabled = i
        ' btnBorrar.Enabled = i
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
        txtCod.Text = regPrestamos.codigoPrestamos
        txtCodLibro.Text = regPrestamos.codigoLibroPrestamos
        txtCodSocio.Text = regPrestamos.codigoSociosPrestamos
        dtpFecha.Text = regSocios.fechbajaSocios
        If My.Computer.FileSystem.FileExists("C:\Users\pc\Desktop\23_prjBACT\Socios\" & txtCod.Text & ".jpg") = True Then
            picLibro.Image = Image.FromFile("C:\Users\pc\Desktop\23_prjBACT\Socios\" & txtCod.Text & ".jpg")
        Else
            picLibro.Image = Nothing
        End If
    End Sub
    'Rutina para grabar datos
    Private Sub grabarDatos()
        regPrestamos.codigoPrestamos = txtCod.Text
        regPrestamos.codigoLibroPrestamos = txtCodLibro.Text
        regPrestamos.codigoSociosPrestamos = txtCodSocio.Text
        regSocios.fechbajaSocios = dtpFecha.Text
    End Sub

    'PROGRAMAMOS LAS MÁSCARAS QUE NECESITEMOS
    'Programamos el txtCod para que sólo admita números
    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodSocio.KeyPress
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

    End Sub

    'Programamos el botón "anterior registro"
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

    End Sub
    'rpogramamos en botón "registro final"
    Private Sub btnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinal.Click

    End Sub

    'Programamos una rutina que nos lleve al primer registro activo que se encuentre en el archivo
    'La usaremos para posicionar el puntero en varios botones
    Private Sub primero()

        Dim pos As Integer
        txtCod.Text = 0
        pos = txtCod.Text + 1
        contadorPrestamos = contP()

        ficheroPrestamos = FreeFile()
        FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
        While pos <= contadorPrestamos
            FileGet(ficheroPrestamos, regPrestamos, pos) 'Aumentamos posicion

            If regPrestamos.codigoPrestamos <> 0 Then
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
        FileClose(ficheroPrestamos)
        If txtCod.Text = 0 Then
            txtCod.Text = ""
        End If
    End Sub
    'Subrutinas que usaremos para localizar el primer y último registro activos
    'Subrutina que usaremos para localizar el ultimo registro activo
    Private Sub ultimo()

        Dim posFinal As Integer
        posFinal = contadorPrestamos
        ficheroPrestamos = FreeFile()
        FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
        While posFinal <= contadorPrestamos
            If posFinal = 0 Then
                Exit While
            End If
            FileGet(ficheroPrestamos, regPrestamos, posFinal) 'Aumentamos posicion
            If regPrestamos.codigoPrestamos <> 0 Then
                ultimoRegistro = regPrestamos.codigoPrestamos
                Exit While
            End If
            posFinal = posFinal - 1
        End While
        FileClose(ficheroPrestamos)
    End Sub
    'Subrutina que usaremos para localizar el primer registro activo
    Private Sub primerobis()
        Dim pos As Integer
        regSocios.codigoSocios = 0
        pos = regSocios.codigoSocios + 1
        ficheroPrestamos = FreeFile()
        FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
        While pos <= contadorPrestamos
            FileGet(ficheroPrestamos, regPrestamos, pos) 'Aumentamos posicion

            If regPrestamos.codigoPrestamos <> 0 Then
                primerregistro1 = regPrestamos.codigoPrestamos
                Exit While
            End If
            pos = pos + 1
        End While
        FileClose(ficheroPrestamos)
    End Sub


    Private Sub pruebas()

        If Trim(txtCodLibro.Text) <> "" Then
            If CInt(txtCodLibro.Text) <= contador And CInt(txtCodLibro.Text) <> 0 Then

                ficheroLibros = FreeFile()
                FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
                FileGet(ficheroLibros, regLibros, CInt(txtCodSocio.Text))
                'Comprobamos el código y si existe el registro nos lo muestra
                If regLibros.codigo <> 0 Then
                    MsgBox("existe")

                End If
                MsgBox("no existe")

            End If
        ElseIf Trim(txtCodSocio.Text) <> "" Then
            If CInt(txtCodSocio.Text) <= contador And CInt(txtCodSocio.Text) <> 0 Then

                ficheroSocios = FreeFile()
                FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
                FileGet(ficheroSocios, regSocios, CInt(txtCod.Text))
                'Comprobamos el código y si existe el registro nos lo muestra
                If regSocios.codigoSocios <> 0 Then
                    MsgBox("existe")

                End If
                MsgBox("no existe")
            End If
        End If

    End Sub
End Class