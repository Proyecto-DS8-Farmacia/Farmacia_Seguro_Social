<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.components = New System.ComponentModel.Container()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelMenuSmall = New System.Windows.Forms.Panel()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnFarmaceuta = New System.Windows.Forms.Button()
        Me.btnEncargado = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsultaPe = New System.Windows.Forms.Button()
        Me.btnConsultarIn = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSmall.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.PanelMenuSmall)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 561)
        Me.PanelMenu.TabIndex = 23
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.CapaPresentacion.My.Resources.Resources.logout1
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(6, 491)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(215, 58)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "    Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelMenuSmall
        '
        Me.PanelMenuSmall.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuSmall.Controls.Add(Me.btnAdministrador)
        Me.PanelMenuSmall.Controls.Add(Me.btnPaciente)
        Me.PanelMenuSmall.Controls.Add(Me.btnFarmaceuta)
        Me.PanelMenuSmall.Controls.Add(Me.btnEncargado)
        Me.PanelMenuSmall.Controls.Add(Me.btnPerfil)
        Me.PanelMenuSmall.Controls.Add(Me.btnInicioSesion)
        Me.PanelMenuSmall.Location = New System.Drawing.Point(3, 53)
        Me.PanelMenuSmall.Name = "PanelMenuSmall"
        Me.PanelMenuSmall.Size = New System.Drawing.Size(214, 432)
        Me.PanelMenuSmall.TabIndex = 1
        '
        'btnAdministrador
        '
        Me.btnAdministrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdministrador.FlatAppearance.BorderSize = 0
        Me.btnAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdministrador.ForeColor = System.Drawing.Color.White
        Me.btnAdministrador.Image = Global.CapaPresentacion.My.Resources.Resources.empleados
        Me.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdministrador.Location = New System.Drawing.Point(2, 318)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(215, 58)
        Me.btnAdministrador.TabIndex = 14
        Me.btnAdministrador.Text = "    Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'btnPaciente
        '
        Me.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPaciente.ForeColor = System.Drawing.Color.White
        Me.btnPaciente.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.Location = New System.Drawing.Point(0, 267)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(215, 58)
        Me.btnPaciente.TabIndex = 12
        Me.btnPaciente.Text = "    Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnFarmaceuta
        '
        Me.btnFarmaceuta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFarmaceuta.FlatAppearance.BorderSize = 0
        Me.btnFarmaceuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFarmaceuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFarmaceuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFarmaceuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFarmaceuta.ForeColor = System.Drawing.Color.White
        Me.btnFarmaceuta.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.btnFarmaceuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFarmaceuta.Location = New System.Drawing.Point(3, 203)
        Me.btnFarmaceuta.Name = "btnFarmaceuta"
        Me.btnFarmaceuta.Size = New System.Drawing.Size(215, 58)
        Me.btnFarmaceuta.TabIndex = 11
        Me.btnFarmaceuta.Text = "    Farmaceuta"
        Me.btnFarmaceuta.UseVisualStyleBackColor = True
        '
        'btnEncargado
        '
        Me.btnEncargado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEncargado.FlatAppearance.BorderSize = 0
        Me.btnEncargado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEncargado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEncargado.ForeColor = System.Drawing.Color.White
        Me.btnEncargado.Image = Global.CapaPresentacion.My.Resources.Resources.logofile1
        Me.btnEncargado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncargado.Location = New System.Drawing.Point(3, 139)
        Me.btnEncargado.Name = "btnEncargado"
        Me.btnEncargado.Size = New System.Drawing.Size(215, 58)
        Me.btnEncargado.TabIndex = 10
        Me.btnEncargado.Text = "    Encargado"
        Me.btnEncargado.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Image = Global.CapaPresentacion.My.Resources.Resources.logouser
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(0, 75)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(215, 58)
        Me.btnPerfil.TabIndex = 9
        Me.btnPerfil.Text = "    Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.BorderSize = 0
        Me.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Image = Global.CapaPresentacion.My.Resources.Resources.logologin1
        Me.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicioSesion.Location = New System.Drawing.Point(0, 3)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(215, 58)
        Me.btnInicioSesion.TabIndex = 8
        Me.btnInicioSesion.Text = "    Inicio Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.CapaPresentacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(168, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 33)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConsultaPe)
        Me.GroupBox1.Controls.Add(Me.btnConsultarIn)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(384, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 196)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú Administrador:"
        '
        'btnConsultaPe
        '
        Me.btnConsultaPe.BackColor = System.Drawing.Color.Black
        Me.btnConsultaPe.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConsultaPe.FlatAppearance.BorderSize = 2
        Me.btnConsultaPe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnConsultaPe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnConsultaPe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaPe.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultaPe.ForeColor = System.Drawing.Color.White
        Me.btnConsultaPe.Location = New System.Drawing.Point(294, 66)
        Me.btnConsultaPe.Name = "btnConsultaPe"
        Me.btnConsultaPe.Size = New System.Drawing.Size(135, 72)
        Me.btnConsultaPe.TabIndex = 26
        Me.btnConsultaPe.Text = "Consultar Perfil"
        Me.btnConsultaPe.UseVisualStyleBackColor = False
        '
        'btnConsultarIn
        '
        Me.btnConsultarIn.BackColor = System.Drawing.Color.Black
        Me.btnConsultarIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConsultarIn.FlatAppearance.BorderSize = 2
        Me.btnConsultarIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnConsultarIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnConsultarIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultarIn.ForeColor = System.Drawing.Color.White
        Me.btnConsultarIn.Location = New System.Drawing.Point(64, 66)
        Me.btnConsultarIn.Name = "btnConsultarIn"
        Me.btnConsultarIn.Size = New System.Drawing.Size(167, 72)
        Me.btnConsultarIn.TabIndex = 25
        Me.btnConsultarIn.Text = "Consultar Inventario"
        Me.btnConsultarIn.UseVisualStyleBackColor = False
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSmall.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelMenuSmall As Panel
    Friend WithEvents btnAdministrador As Button
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnFarmaceuta As Button
    Friend WithEvents btnEncargado As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConsultaPe As Button
    Friend WithEvents btnConsultarIn As Button
End Class
