Module ModBiblioteca
    Public contador As Integer
    Public contadorSocios As Integer
    Public contadorPrestamos As Integer
    Public regLibros As struLibros
    Public regSocios As struSocios
    Public regPrestamos As struPrestamos
    Public id As String
    Public nombreEditorial As String
    Public ficheroEditorial As Integer
    Public ficheroLibros As Integer
    Public ficheroSocios As Integer
    Public ficheroPrestamos As Integer
    Public ficheroDevoluciones As Integer
    Public rutaLibros As String = "..\..\..\Datos\libros.dat"
    Public rutaEditorial As String = "..\..\..\Datos\editoriais.dat"
    Public rutaSocios As String = "..\..\..\Datos\socios.dat"
    Public rutaPrestamos As String = "..\..\..\Datos\prestamos.dat"
    Public rutaDevoluciones As String = "..\..\..\Datos\devoluciones.dat"
    Public rutaImagenes As String = "..\..\..\Imagenes"

    'variables fich libros
    Public codigo As Integer
    Public isbn As String
    Public titulo As String
    Public autor As String
    Public editorial As Integer
    Public fechalta As Date
    Public baja As Boolean = False
    Public fechbaja As Date

    'variables fich socios
    Public codigoSocios As String
    Public nif As String
    Public apellido1 As String
    Public apellido2 As String
    Public nombre As String
    Public direccion As String
    Public poblacion As String
    Public codPostal As Integer
    Public fechNac As Date
    Public bajaSocios As Boolean
    Public fechbajaSocios As Date

    'variables fichPréstamos 
    Public codigoPrestamos As Integer
    Public codigoLibroPrestamos As Integer
    Public codigoSociosPrestamos As Integer
    Public fechaPrestamos As Date

    'Creamos estructura del fichero libros
    Structure struLibros
        Dim codigo As Integer
        <VBFixedString(13)> Dim isbn As String
        <VBFixedString(50)> Dim titulo As String
        <VBFixedString(50)> Dim autor As String
        Dim editorial As Integer
        Dim fechalta As Date
        Dim baja As Boolean
        Dim fechbaja As Date
    End Structure

    'Creamos estructura del fichero socios
    Structure struSocios
        Dim codigoSocios As Integer
        <VBFixedString(10)> Dim nif As String
        <VBFixedString(20)> Dim apellido1 As String
        <VBFixedString(20)> Dim apellido2 As String
        <VBFixedString(20)> Dim nombre As String
        <VBFixedString(50)> Dim direccion As String
        <VBFixedString(50)> Dim poblacion As String
        Dim codPostal As Integer
        Dim fechNac As Date
        Dim bajasocios As Boolean
        Dim fechbajaSocios As Date
    End Structure

    Structure struPrestamos
        Dim codigoPrestamos As Integer
        Dim codigoLibroPrestamos As Integer
        Dim codigoSociosPrestamos As Integer
        Dim fechaPrestamos As Date
    End Structure


    'Subrutina con la que cargamos todas las editoriales en el cmbEdit
    Public Sub inicioCmb()
        ficheroEditorial = FreeFile()
        FileOpen(ficheroEditorial, rutaEditorial, OpenMode.Input)
        Do Until EOF(ficheroEditorial) = True
            Input(ficheroEditorial, id)
            Input(ficheroEditorial, nombreEditorial)
            frmLibros.cmbEditorial.Items.Add(nombreEditorial)
        Loop
        FileClose(ficheroEditorial)
        frmLibros.cmbEditorial.SelectedItem = -1
    End Sub

    Function cont() As Integer
        ' Try
        ficheroLibros = FreeFile()
        FileOpen(ficheroLibros, rutaLibros, OpenMode.Random, , , Len(regLibros))
        cont = LOF(ficheroLibros) / Len(regLibros)
        FileClose(ficheroLibros)
        'Catch ex As Exception
        'MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
        ' End Try
    End Function
    Function contS() As Integer
        ' Try
        ficheroSocios = FreeFile()
        FileOpen(ficheroSocios, rutaSocios, OpenMode.Random, , , Len(regSocios))
        contS = LOF(ficheroSocios) / Len(regSocios)
        FileClose(ficheroSocios)
        'Catch ex As Exception
        'MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
        ' End Try
    End Function
    Function contP() As Integer
        ' Try
        ficheroPrestamos = FreeFile()
        FileOpen(ficheroPrestamos, rutaPrestamos, OpenMode.Random, , , Len(regPrestamos))
        contP = LOF(ficheroPrestamos) / Len(regPrestamos)
        FileClose(ficheroPrestamos)
        'Catch ex As Exception
        'MsgBox(ex.Message & vbCrLf & "Póngase en contacto con Pablo Sotelo", vbCritical, "Error")
        ' End Try
    End Function

    'Subrutina de reinicio de aplicación cuando sucede un error fatal de fichero
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim form As frmLibros
        Do
            form = New frmLibros
            Application.Run(form)
        Loop While form.hasError
    End Sub

End Module
