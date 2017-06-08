<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibros))
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblIsbn = New System.Windows.Forms.Label()
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.lblFech = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.cmbEditorial = New System.Windows.Forms.ComboBox()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.dtpFechBaja = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Panel()
        Me.picbCancelado = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Panel()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnIni = New System.Windows.Forms.Button()
        Me.opfCargaPic = New System.Windows.Forms.OpenFileDialog()
        Me.picLibro = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picbCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Location = New System.Drawing.Point(49, 62)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Código"
        '
        'lblIsbn
        '
        Me.lblIsbn.AutoSize = True
        Me.lblIsbn.BackColor = System.Drawing.Color.Transparent
        Me.lblIsbn.Location = New System.Drawing.Point(49, 96)
        Me.lblIsbn.Name = "lblIsbn"
        Me.lblIsbn.Size = New System.Drawing.Size(32, 13)
        Me.lblIsbn.TabIndex = 1
        Me.lblIsbn.Text = "ISBN"
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.BackColor = System.Drawing.Color.Transparent
        Me.lblTit.Location = New System.Drawing.Point(49, 130)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(35, 13)
        Me.lblTit.TabIndex = 2
        Me.lblTit.Text = "Título"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.BackColor = System.Drawing.Color.Transparent
        Me.lblAutor.Location = New System.Drawing.Point(49, 164)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(32, 13)
        Me.lblAutor.TabIndex = 3
        Me.lblAutor.Text = "Autor"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(128, 93)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(128, 20)
        Me.txtISBN.TabIndex = 8
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(128, 127)
        Me.txtTitulo.MaxLength = 50
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(128, 20)
        Me.txtTitulo.TabIndex = 9
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Transparent
        Me.lblEdit.Location = New System.Drawing.Point(49, 198)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(44, 13)
        Me.lblEdit.TabIndex = 8
        Me.lblEdit.Text = "Editorial"
        '
        'lblFech
        '
        Me.lblFech.AutoSize = True
        Me.lblFech.BackColor = System.Drawing.Color.Transparent
        Me.lblFech.Location = New System.Drawing.Point(49, 232)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(66, 26)
        Me.lblFech.TabIndex = 9
        Me.lblFech.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adquisicicón"
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(128, 161)
        Me.txtAutor.MaxLength = 50
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(128, 20)
        Me.txtAutor.TabIndex = 10
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(128, 236)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(85, 20)
        Me.dtpFecha.TabIndex = 12
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(128, 59)
        Me.txtCod.MaxLength = 5
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(42, 20)
        Me.txtCod.TabIndex = 7
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbEditorial
        '
        Me.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditorial.FormattingEnabled = True
        Me.cmbEditorial.Location = New System.Drawing.Point(128, 195)
        Me.cmbEditorial.Name = "cmbEditorial"
        Me.cmbEditorial.Size = New System.Drawing.Size(128, 21)
        Me.cmbEditorial.TabIndex = 11
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.BackColor = System.Drawing.Color.Transparent
        Me.lblBaja.Location = New System.Drawing.Point(49, 279)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(55, 26)
        Me.lblBaja.TabIndex = 68
        Me.lblBaja.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "baja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblBaja.Visible = False
        '
        'dtpFechBaja
        '
        Me.dtpFechBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechBaja.Location = New System.Drawing.Point(128, 282)
        Me.dtpFechBaja.Name = "dtpFechBaja"
        Me.dtpFechBaja.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechBaja.TabIndex = 13
        Me.dtpFechBaja.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(387, 274)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(48, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(441, 274)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(48, 23)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.lblExit)
        Me.Panel1.Location = New System.Drawing.Point(572, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(23, 23)
        Me.Panel1.TabIndex = 74
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblExit.Location = New System.Drawing.Point(3, 1)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(20, 17)
        Me.lblExit.TabIndex = 0
        Me.lblExit.Text = "r"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(333, 274)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(48, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(360, 312)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(441, 312)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(495, 274)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.Transparent
        Me.btnSig.Location = New System.Drawing.Point(557, 176)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(34, 32)
        Me.btnSig.TabIndex = 81
        '
        'picbCancelado
        '
        Me.picbCancelado.BackColor = System.Drawing.Color.Transparent
        Me.picbCancelado.BackgroundImage = CType(resources.GetObject("picbCancelado.BackgroundImage"), System.Drawing.Image)
        Me.picbCancelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbCancelado.Location = New System.Drawing.Point(194, 16)
        Me.picbCancelado.Name = "picbCancelado"
        Me.picbCancelado.Size = New System.Drawing.Size(173, 65)
        Me.picbCancelado.TabIndex = 82
        Me.picbCancelado.TabStop = False
        Me.picbCancelado.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.Location = New System.Drawing.Point(5, 176)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 32)
        Me.btnAtras.TabIndex = 84
        '
        'btnFinal
        '
        Me.btnFinal.BackColor = System.Drawing.Color.Transparent
        Me.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinal.Font = New System.Drawing.Font("Webdings", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnFinal.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnFinal.Location = New System.Drawing.Point(556, 212)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(34, 29)
        Me.btnFinal.TabIndex = 85
        Me.btnFinal.Text = ":"
        Me.btnFinal.UseVisualStyleBackColor = False
        '
        'btnIni
        '
        Me.btnIni.BackColor = System.Drawing.Color.Transparent
        Me.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIni.Font = New System.Drawing.Font("Webdings", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnIni.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnIni.Location = New System.Drawing.Point(6, 212)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(34, 29)
        Me.btnIni.TabIndex = 86
        Me.btnIni.Text = "9"
        Me.btnIni.UseVisualStyleBackColor = False
        '
        'opfCargaPic
        '
        Me.opfCargaPic.Filter = "archivos JPG|*.jpg| archivos PNG|*.png"
        Me.opfCargaPic.InitialDirectory = "C:\Users\pc\Desktop\23_prjBACT\Imagenes"
        '
        'picLibro
        '
        Me.picLibro.BackColor = System.Drawing.Color.Transparent
        Me.picLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLibro.Location = New System.Drawing.Point(386, 63)
        Me.picLibro.Name = "picLibro"
        Me.picLibro.Size = New System.Drawing.Size(104, 147)
        Me.picLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibro.TabIndex = 88
        Me.picLibro.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picLibro)
        Me.Controls.Add(Me.btnIni)
        Me.Controls.Add(Me.btnFinal)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpFechBaja)
        Me.Controls.Add(Me.lblBaja)
        Me.Controls.Add(Me.cmbEditorial)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.lblFech)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTit)
        Me.Controls.Add(Me.lblIsbn)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.picbCancelado)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibros"
        Me.Text = "Libros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picbCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblIsbn As System.Windows.Forms.Label
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblEdit As System.Windows.Forms.Label
    Friend WithEvents lblFech As System.Windows.Forms.Label
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents cmbEditorial As System.Windows.Forms.ComboBox
    Friend WithEvents lblBaja As System.Windows.Forms.Label
    Friend WithEvents dtpFechBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Panel
    Friend WithEvents picbCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents btnAtras As System.Windows.Forms.Panel
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnIni As System.Windows.Forms.Button
    Friend WithEvents opfCargaPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picLibro As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
