<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentana))
        Me.btnProv = New System.Windows.Forms.Button()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnDev = New System.Windows.Forms.Button()
        Me.btnPres = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProv
        '
        Me.btnProv.BackColor = System.Drawing.Color.Transparent
        Me.btnProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProv.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnProv.Location = New System.Drawing.Point(515, 356)
        Me.btnProv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(87, 24)
        Me.btnProv.TabIndex = 4
        Me.btnProv.Text = "PROVINCIAS"
        Me.btnProv.UseVisualStyleBackColor = False
        '
        'btnSocios
        '
        Me.btnSocios.BackColor = System.Drawing.Color.Transparent
        Me.btnSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSocios.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnSocios.Location = New System.Drawing.Point(515, 296)
        Me.btnSocios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(87, 24)
        Me.btnSocios.TabIndex = 4
        Me.btnSocios.Text = "SOCIOS"
        Me.btnSocios.UseVisualStyleBackColor = False
        '
        'btnLibros
        '
        Me.btnLibros.BackColor = System.Drawing.Color.Transparent
        Me.btnLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibros.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnLibros.Location = New System.Drawing.Point(515, 266)
        Me.btnLibros.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(87, 24)
        Me.btnLibros.TabIndex = 3
        Me.btnLibros.Text = "LIBROS"
        Me.btnLibros.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnEdit.Location = New System.Drawing.Point(515, 326)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 24)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "EDITORIALES"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblExit)
        Me.Panel1.Location = New System.Drawing.Point(628, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(23, 23)
        Me.Panel1.TabIndex = 7
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblExit.Location = New System.Drawing.Point(3, 1)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(20, 17)
        Me.lblExit.TabIndex = 0
        Me.lblExit.Text = "r"
        '
        'btnDev
        '
        Me.btnDev.BackColor = System.Drawing.Color.Transparent
        Me.btnDev.BackgroundImage = CType(resources.GetObject("btnDev.BackgroundImage"), System.Drawing.Image)
        Me.btnDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDev.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnDev.Location = New System.Drawing.Point(533, 119)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(47, 38)
        Me.btnDev.TabIndex = 12
        Me.btnDev.UseVisualStyleBackColor = False
        '
        'btnPres
        '
        Me.btnPres.BackColor = System.Drawing.Color.Transparent
        Me.btnPres.BackgroundImage = CType(resources.GetObject("btnPres.BackgroundImage"), System.Drawing.Image)
        Me.btnPres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnPres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPres.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnPres.Location = New System.Drawing.Point(533, 66)
        Me.btnPres.Name = "btnPres"
        Me.btnPres.Size = New System.Drawing.Size(47, 38)
        Me.btnPres.TabIndex = 13
        Me.btnPres.UseVisualStyleBackColor = False
        '
        'frmVentana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 445)
        Me.Controls.Add(Me.btnPres)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnProv)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.btnLibros)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmVentana"
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProv As System.Windows.Forms.Button
    Friend WithEvents btnSocios As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnLibros As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents btnDev As System.Windows.Forms.Button
    Friend WithEvents btnPres As System.Windows.Forms.Button

End Class
