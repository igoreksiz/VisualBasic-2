<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSocios))
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dtpFechNac = New System.Windows.Forms.DateTimePicker()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.lblApe1 = New System.Windows.Forms.Label()
        Me.lblApe2 = New System.Windows.Forms.Label()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblPob = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblFechNac = New System.Windows.Forms.Label()
        Me.lblFechBaja = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtPob = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.dtpFechBaj = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnIni = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(157, 26)
        Me.txtCod.MaxLength = 5
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(42, 20)
        Me.txtCod.TabIndex = 58
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(42, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 64
        Me.lblCodigo.Text = "Código"
        '
        'dtpFechNac
        '
        Me.dtpFechNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechNac.Location = New System.Drawing.Point(157, 298)
        Me.dtpFechNac.Name = "dtpFechNac"
        Me.dtpFechNac.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechNac.TabIndex = 62
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Location = New System.Drawing.Point(42, 63)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(24, 13)
        Me.lblNif.TabIndex = 71
        Me.lblNif.Text = "NIF"
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(157, 60)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(100, 20)
        Me.txtNif.TabIndex = 72
        '
        'lblApe1
        '
        Me.lblApe1.AutoSize = True
        Me.lblApe1.Location = New System.Drawing.Point(42, 97)
        Me.lblApe1.Name = "lblApe1"
        Me.lblApe1.Size = New System.Drawing.Size(53, 13)
        Me.lblApe1.TabIndex = 73
        Me.lblApe1.Text = "Apellido 1"
        '
        'lblApe2
        '
        Me.lblApe2.AutoSize = True
        Me.lblApe2.Location = New System.Drawing.Point(42, 131)
        Me.lblApe2.Name = "lblApe2"
        Me.lblApe2.Size = New System.Drawing.Size(53, 13)
        Me.lblApe2.TabIndex = 74
        Me.lblApe2.Text = "Apellido 2"
        '
        'txtApe1
        '
        Me.txtApe1.Location = New System.Drawing.Point(157, 94)
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(100, 20)
        Me.txtApe1.TabIndex = 75
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(157, 128)
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(100, 20)
        Me.txtApe2.TabIndex = 76
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(157, 162)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 77
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(42, 165)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(44, 13)
        Me.lblNom.TabIndex = 78
        Me.lblNom.Text = "Nombre"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Location = New System.Drawing.Point(42, 199)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(52, 13)
        Me.lblDir.TabIndex = 79
        Me.lblDir.Text = "Dirección"
        '
        'lblPob
        '
        Me.lblPob.AutoSize = True
        Me.lblPob.Location = New System.Drawing.Point(42, 233)
        Me.lblPob.Name = "lblPob"
        Me.lblPob.Size = New System.Drawing.Size(54, 13)
        Me.lblPob.TabIndex = 80
        Me.lblPob.Text = "Población"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(42, 267)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 13)
        Me.lblCP.TabIndex = 81
        Me.lblCP.Text = "Código Postal"
        '
        'lblFechNac
        '
        Me.lblFechNac.AutoSize = True
        Me.lblFechNac.Location = New System.Drawing.Point(42, 301)
        Me.lblFechNac.Name = "lblFechNac"
        Me.lblFechNac.Size = New System.Drawing.Size(106, 13)
        Me.lblFechNac.TabIndex = 82
        Me.lblFechNac.Text = "Fecha de nacimiento"
        '
        'lblFechBaja
        '
        Me.lblFechBaja.AutoSize = True
        Me.lblFechBaja.Location = New System.Drawing.Point(42, 335)
        Me.lblFechBaja.Name = "lblFechBaja"
        Me.lblFechBaja.Size = New System.Drawing.Size(75, 13)
        Me.lblFechBaja.TabIndex = 84
        Me.lblFechBaja.Text = "Fecha de baja"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(157, 196)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(100, 20)
        Me.txtDir.TabIndex = 85
        '
        'txtPob
        '
        Me.txtPob.Location = New System.Drawing.Point(157, 230)
        Me.txtPob.Name = "txtPob"
        Me.txtPob.Size = New System.Drawing.Size(100, 20)
        Me.txtPob.TabIndex = 86
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(157, 264)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 20)
        Me.txtCP.TabIndex = 87
        '
        'dtpFechBaj
        '
        Me.dtpFechBaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechBaj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechBaj.Location = New System.Drawing.Point(157, 334)
        Me.dtpFechBaj.Name = "dtpFechBaj"
        Me.dtpFechBaj.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechBaj.TabIndex = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(346, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 152)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'lblRegistro
        '
        Me.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.Location = New System.Drawing.Point(325, 357)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(172, 18)
        Me.lblRegistro.TabIndex = 90
        Me.lblRegistro.Text = "Número de registros:  0"
        Me.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSig)
        Me.Panel1.Controls.Add(Me.btnFinal)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.btnIni)
        Me.Panel1.Location = New System.Drawing.Point(325, 306)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 50)
        Me.Panel1.TabIndex = 91
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSig.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSig.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnSig.Location = New System.Drawing.Point(84, 0)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(42, 46)
        Me.btnSig.TabIndex = 23
        Me.btnSig.Text = "4"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'btnFinal
        '
        Me.btnFinal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFinal.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFinal.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnFinal.Location = New System.Drawing.Point(126, 0)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(42, 46)
        Me.btnFinal.TabIndex = 24
        Me.btnFinal.Text = ":"
        Me.btnFinal.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAtras.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAtras.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(42, 0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(42, 46)
        Me.btnAtras.TabIndex = 22
        Me.btnAtras.Text = "3"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnIni
        '
        Me.btnIni.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnIni.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnIni.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnIni.Location = New System.Drawing.Point(0, 0)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(42, 46)
        Me.btnIni.TabIndex = 21
        Me.btnIni.Text = "9"
        Me.btnIni.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(469, 199)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 23)
        Me.btnEditar.TabIndex = 97
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(415, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 96
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(334, 237)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 95
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(307, 199)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(48, 23)
        Me.btnNuevo.TabIndex = 94
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(415, 199)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(48, 23)
        Me.btnBorrar.TabIndex = 93
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(361, 199)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(48, 23)
        Me.btnBuscar.TabIndex = 92
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 432)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpFechBaj)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtPob)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.lblFechBaja)
        Me.Controls.Add(Me.lblFechNac)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblPob)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtApe2)
        Me.Controls.Add(Me.txtApe1)
        Me.Controls.Add(Me.lblApe2)
        Me.Controls.Add(Me.lblApe1)
        Me.Controls.Add(Me.txtNif)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.dtpFechNac)
        Me.Name = "frmSocios"
        Me.Text = "Socios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents dtpFechNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents txtNif As System.Windows.Forms.TextBox
    Friend WithEvents lblApe1 As System.Windows.Forms.Label
    Friend WithEvents lblApe2 As System.Windows.Forms.Label
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents lblPob As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblFechNac As System.Windows.Forms.Label
    Friend WithEvents lblFechBaja As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtPob As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechBaj As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIni As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
