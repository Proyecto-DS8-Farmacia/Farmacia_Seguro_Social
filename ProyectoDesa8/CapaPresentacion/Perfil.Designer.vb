<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelMenuSmall = New System.Windows.Forms.Panel()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnFarmaceuta = New System.Windows.Forms.Button()
        Me.btnEncargado = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.cboFarmacia = New System.Windows.Forms.ComboBox()
        Me.cboTiposUsuario = New System.Windows.Forms.ComboBox()
        Me.cboCedula = New System.Windows.Forms.ComboBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblTU = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFarmacia = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTipodeUsuario = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSmall.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelMenu.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.CapaPresentacion.My.Resources.Resources.logout1
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(5, 476)
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
        Me.PanelMenuSmall.Controls.Add(Me.btnInicioSesion)
        Me.PanelMenuSmall.Controls.Add(Me.btnPaciente)
        Me.PanelMenuSmall.Controls.Add(Me.btnFarmaceuta)
        Me.PanelMenuSmall.Controls.Add(Me.btnEncargado)
        Me.PanelMenuSmall.Controls.Add(Me.btnPerfil)
        Me.PanelMenuSmall.Location = New System.Drawing.Point(3, 80)
        Me.PanelMenuSmall.Name = "PanelMenuSmall"
        Me.PanelMenuSmall.Size = New System.Drawing.Size(214, 390)
        Me.PanelMenuSmall.TabIndex = 1
        '
        'btnAdministrador
        '
        Me.btnAdministrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdministrador.FlatAppearance.BorderSize = 0
        Me.btnAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdministrador.ForeColor = System.Drawing.Color.White
        Me.btnAdministrador.Image = Global.CapaPresentacion.My.Resources.Resources.empleados
        Me.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdministrador.Location = New System.Drawing.Point(-1, 329)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(215, 58)
        Me.btnAdministrador.TabIndex = 16
        Me.btnAdministrador.Text = "    Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.BorderSize = 0
        Me.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Image = Global.CapaPresentacion.My.Resources.Resources.logologin1
        Me.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicioSesion.Location = New System.Drawing.Point(-1, 11)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(215, 58)
        Me.btnInicioSesion.TabIndex = 10
        Me.btnInicioSesion.Text = "    Inicio Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'btnPaciente
        '
        Me.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnFarmaceuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFarmaceuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnEncargado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEncargado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        'tmMostrarMenu
        '
        '
        'tmOcultarMenu
        '
        '
        'cboFarmacia
        '
        Me.cboFarmacia.FormattingEnabled = True
        Me.cboFarmacia.Items.AddRange(New Object() {"-"})
        Me.cboFarmacia.Location = New System.Drawing.Point(425, 112)
        Me.cboFarmacia.Name = "cboFarmacia"
        Me.cboFarmacia.Size = New System.Drawing.Size(166, 23)
        Me.cboFarmacia.TabIndex = 10
        '
        'cboTiposUsuario
        '
        Me.cboTiposUsuario.FormattingEnabled = True
        Me.cboTiposUsuario.Location = New System.Drawing.Point(425, 195)
        Me.cboTiposUsuario.Name = "cboTiposUsuario"
        Me.cboTiposUsuario.Size = New System.Drawing.Size(166, 23)
        Me.cboTiposUsuario.TabIndex = 11
        '
        'cboCedula
        '
        Me.cboCedula.FormattingEnabled = True
        Me.cboCedula.Location = New System.Drawing.Point(425, 293)
        Me.cboCedula.Name = "cboCedula"
        Me.cboCedula.Size = New System.Drawing.Size(166, 23)
        Me.cboCedula.TabIndex = 13
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblF.Location = New System.Drawing.Point(265, 115)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(137, 15)
        Me.lblF.TabIndex = 14
        Me.lblF.Text = "Seleccione la farmacia"
        '
        'lblTU
        '
        Me.lblTU.AutoSize = True
        Me.lblTU.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTU.Location = New System.Drawing.Point(249, 203)
        Me.lblTU.Name = "lblTU"
        Me.lblTU.Size = New System.Drawing.Size(170, 15)
        Me.lblTU.TabIndex = 15
        Me.lblTU.Text = "Seleccione el tipo de usuario"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblC.Location = New System.Drawing.Point(265, 296)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(124, 15)
        Me.lblC.TabIndex = 16
        Me.lblC.Text = "Seleccione la cedula"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTipodeUsuario)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(641, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 381)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtFarmacia)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.txtcedula)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(17, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 169)
        Me.Panel2.TabIndex = 8
        '
        'txtFarmacia
        '
        Me.txtFarmacia.Location = New System.Drawing.Point(158, 130)
        Me.txtFarmacia.Name = "txtFarmacia"
        Me.txtFarmacia.ReadOnly = True
        Me.txtFarmacia.Size = New System.Drawing.Size(141, 21)
        Me.txtFarmacia.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(158, 94)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(141, 21)
        Me.txtTelefono.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(158, 60)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(141, 21)
        Me.txtCorreo.TabIndex = 9
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(158, 23)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.ReadOnly = True
        Me.txtcedula.Size = New System.Drawing.Size(141, 21)
        Me.txtcedula.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(59, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cedula: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(59, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Farmacia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(59, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(59, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono: "
        '
        'lblTipodeUsuario
        '
        Me.lblTipodeUsuario.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTipodeUsuario.Location = New System.Drawing.Point(98, 14)
        Me.lblTipodeUsuario.Name = "lblTipodeUsuario"
        Me.lblTipodeUsuario.Size = New System.Drawing.Size(195, 18)
        Me.lblTipodeUsuario.TabIndex = 6
        Me.lblTipodeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(98, 134)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(195, 22)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(149, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Editar Perfil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.logouser
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(149, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 79)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(385, 403)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(973, 524)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Visible = False
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblTU)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.cboCedula)
        Me.Controls.Add(Me.cboTiposUsuario)
        Me.Controls.Add(Me.cboFarmacia)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Perfil"
        Me.Text = "Perfil"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSmall.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelMenuSmall As Panel
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnFarmaceuta As Button
    Friend WithEvents btnEncargado As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents btnAdministrador As Button
    Friend WithEvents cboFarmacia As ComboBox
    Friend WithEvents cboTiposUsuario As ComboBox
    Friend WithEvents cboCedula As ComboBox
    Friend WithEvents lblF As Label
    Friend WithEvents lblTU As Label
    Friend WithEvents lblC As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTipodeUsuario As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFarmacia As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
