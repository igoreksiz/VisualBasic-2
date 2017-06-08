<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
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
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblCodLibro = New System.Windows.Forms.Label()
        Me.lblCodSocio = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCodSocio = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtCodLibro = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnIni = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.picLibro = New System.Windows.Forms.PictureBox()
        Me.picSocio = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(39, 29)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(105, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Número de préstamo"
        '
        'lblCodLibro
        '
        Me.lblCodLibro.AutoSize = True
        Me.lblCodLibro.Location = New System.Drawing.Point(39, 57)
        Me.lblCodLibro.Name = "lblCodLibro"
        Me.lblCodLibro.Size = New System.Drawing.Size(79, 13)
        Me.lblCodLibro.TabIndex = 1
        Me.lblCodLibro.Text = "Código del libro"
        '
        'lblCodSocio
        '
        Me.lblCodSocio.AutoSize = True
        Me.lblCodSocio.Location = New System.Drawing.Point(39, 85)
        Me.lblCodSocio.Name = "lblCodSocio"
        Me.lblCodSocio.Size = New System.Drawing.Size(83, 13)
        Me.lblCodSocio.TabIndex = 2
        Me.lblCodSocio.Text = "Código de socio"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(39, 113)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha préstamo"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(155, 113)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(85, 20)
        Me.dtpFecha.TabIndex = 63
        '
        'txtCodSocio
        '
        Me.txtCodSocio.Location = New System.Drawing.Point(155, 82)
        Me.txtCodSocio.MaxLength = 5
        Me.txtCodSocio.Name = "txtCodSocio"
        Me.txtCodSocio.Size = New System.Drawing.Size(42, 20)
        Me.txtCodSocio.TabIndex = 64
        Me.txtCodSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(155, 26)
        Me.txtCod.MaxLength = 5
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(42, 20)
        Me.txtCod.TabIndex = 68
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodLibro
        '
        Me.txtCodLibro.Location = New System.Drawing.Point(155, 54)
        Me.txtCodLibro.MaxLength = 5
        Me.txtCodLibro.Name = "txtCodLibro"
        Me.txtCodLibro.Size = New System.Drawing.Size(42, 20)
        Me.txtCodLibro.TabIndex = 70
        Me.txtCodLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(44, 149)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(48, 23)
        Me.btnNuevo.TabIndex = 96
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(44, 178)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(48, 23)
        Me.btnBuscar.TabIndex = 95
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(125, 207)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 98
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(44, 207)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 97
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblRegistro
        '
        Me.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.Location = New System.Drawing.Point(42, 338)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(172, 18)
        Me.lblRegistro.TabIndex = 99
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
        Me.Panel1.Location = New System.Drawing.Point(42, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 50)
        Me.Panel1.TabIndex = 100
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
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(189, 86)
        Me.TextBox6.MaxLength = 5
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(42, 20)
        Me.TextBox6.TabIndex = 70
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'picLibro
        '
        Me.picLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLibro.Location = New System.Drawing.Point(392, 12)
        Me.picLibro.Name = "picLibro"
        Me.picLibro.Size = New System.Drawing.Size(109, 134)
        Me.picLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibro.TabIndex = 101
        Me.picLibro.TabStop = False
        '
        'picSocio
        '
        Me.picSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSocio.Location = New System.Drawing.Point(392, 178)
        Me.picSocio.Name = "picSocio"
        Me.picSocio.Size = New System.Drawing.Size(109, 134)
        Me.picSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSocio.TabIndex = 102
        Me.picSocio.TabStop = False
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 373)
        Me.Controls.Add(Me.picSocio)
        Me.Controls.Add(Me.picLibro)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodLibro)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.txtCodSocio)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCodSocio)
        Me.Controls.Add(Me.lblCodLibro)
        Me.Controls.Add(Me.lblCod)
        Me.Name = "frmPrestamos"
        Me.Text = "Péstamos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblCodLibro As System.Windows.Forms.Label
    Friend WithEvents lblCodSocio As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtCodLibro As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIni As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents picLibro As System.Windows.Forms.PictureBox
    Friend WithEvents picSocio As System.Windows.Forms.PictureBox
End Class
