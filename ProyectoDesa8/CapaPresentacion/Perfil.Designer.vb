<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cboFarmacia_Select = New System.Windows.Forms.ComboBox()
        Me.txtPerfilapellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPerfilNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTipodeUsuario = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSmall.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.txtnombre.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(251, 748)
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
        Me.btnSalir.Location = New System.Drawing.Point(6, 635)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(246, 77)
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
        Me.PanelMenuSmall.Location = New System.Drawing.Point(3, 107)
        Me.PanelMenuSmall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenuSmall.Name = "PanelMenuSmall"
        Me.PanelMenuSmall.Size = New System.Drawing.Size(245, 520)
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
        Me.btnAdministrador.Location = New System.Drawing.Point(-1, 439)
        Me.btnAdministrador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(246, 77)
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
        Me.btnInicioSesion.Location = New System.Drawing.Point(-1, 15)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(246, 77)
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
        Me.btnPaciente.Location = New System.Drawing.Point(0, 356)
        Me.btnPaciente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(246, 77)
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
        Me.btnFarmaceuta.Location = New System.Drawing.Point(3, 271)
        Me.btnFarmaceuta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFarmaceuta.Name = "btnFarmaceuta"
        Me.btnFarmaceuta.Size = New System.Drawing.Size(246, 77)
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
        Me.btnEncargado.Location = New System.Drawing.Point(3, 185)
        Me.btnEncargado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEncargado.Name = "btnEncargado"
        Me.btnEncargado.Size = New System.Drawing.Size(246, 77)
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
        Me.btnPerfil.Location = New System.Drawing.Point(0, 100)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(246, 77)
        Me.btnPerfil.TabIndex = 9
        Me.btnPerfil.Text = "    Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.CapaPresentacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(192, 4)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(56, 44)
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
        Me.cboFarmacia.Location = New System.Drawing.Point(486, 149)
        Me.cboFarmacia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFarmacia.Name = "cboFarmacia"
        Me.cboFarmacia.Size = New System.Drawing.Size(189, 28)
        Me.cboFarmacia.TabIndex = 10
        '
        'cboTiposUsuario
        '
        Me.cboTiposUsuario.FormattingEnabled = True
        Me.cboTiposUsuario.Location = New System.Drawing.Point(486, 260)
        Me.cboTiposUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTiposUsuario.Name = "cboTiposUsuario"
        Me.cboTiposUsuario.Size = New System.Drawing.Size(189, 28)
        Me.cboTiposUsuario.TabIndex = 11
        '
        'cboCedula
        '
        Me.cboCedula.FormattingEnabled = True
        Me.cboCedula.Location = New System.Drawing.Point(486, 391)
        Me.cboCedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCedula.Name = "cboCedula"
        Me.cboCedula.Size = New System.Drawing.Size(189, 28)
        Me.cboCedula.TabIndex = 13
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblF.Location = New System.Drawing.Point(303, 153)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(166, 18)
        Me.lblF.TabIndex = 14
        Me.lblF.Text = "Seleccione la farmacia"
        '
        'lblTU
        '
        Me.lblTU.AutoSize = True
        Me.lblTU.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTU.Location = New System.Drawing.Point(266, 266)
        Me.lblTU.Name = "lblTU"
        Me.lblTU.Size = New System.Drawing.Size(214, 18)
        Me.lblTU.TabIndex = 15
        Me.lblTU.Text = "Seleccione el tipo de usuario"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblC.Location = New System.Drawing.Point(303, 395)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(154, 18)
        Me.lblC.TabIndex = 16
        Me.lblC.Text = "Seleccione la cedula"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.lblTipodeUsuario)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(733, 107)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 628)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 211)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Editar Perfil"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.Controls.Add(Me.CheckBox1)
        Me.txtnombre.Controls.Add(Me.cboFarmacia_Select)
        Me.txtnombre.Controls.Add(Me.txtPerfilapellido)
        Me.txtnombre.Controls.Add(Me.Label2)
        Me.txtnombre.Controls.Add(Me.txtPerfilNombre)
        Me.txtnombre.Controls.Add(Me.Label1)
        Me.txtnombre.Controls.Add(Me.txtTelefono)
        Me.txtnombre.Controls.Add(Me.txtCorreo)
        Me.txtnombre.Controls.Add(Me.Label8)
        Me.txtnombre.Controls.Add(Me.Label5)
        Me.txtnombre.Controls.Add(Me.Label6)
        Me.txtnombre.Location = New System.Drawing.Point(19, 257)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(406, 348)
        Me.txtnombre.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(43, 293)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cboFarmacia_Select
        '
        Me.cboFarmacia_Select.FormattingEnabled = True
        Me.cboFarmacia_Select.Items.AddRange(New Object() {"-"})
        Me.cboFarmacia_Select.Location = New System.Drawing.Point(181, 291)
        Me.cboFarmacia_Select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFarmacia_Select.Name = "cboFarmacia_Select"
        Me.cboFarmacia_Select.Size = New System.Drawing.Size(189, 28)
        Me.cboFarmacia_Select.TabIndex = 16
        '
        'txtPerfilapellido
        '
        Me.txtPerfilapellido.Location = New System.Drawing.Point(181, 127)
        Me.txtPerfilapellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPerfilapellido.Name = "txtPerfilapellido"
        Me.txtPerfilapellido.Size = New System.Drawing.Size(161, 27)
        Me.txtPerfilapellido.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(67, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Apellido: "
        '
        'txtPerfilNombre
        '
        Me.txtPerfilNombre.Location = New System.Drawing.Point(181, 79)
        Me.txtPerfilNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPerfilNombre.Name = "txtPerfilNombre"
        Me.txtPerfilNombre.Size = New System.Drawing.Size(161, 27)
        Me.txtPerfilNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre: "
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(181, 218)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(161, 27)
        Me.txtTelefono.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(181, 173)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(161, 27)
        Me.txtCorreo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(67, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Farmacia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(67, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(67, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono: "
        '
        'lblTipodeUsuario
        '
        Me.lblTipodeUsuario.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTipodeUsuario.Location = New System.Drawing.Point(112, 19)
        Me.lblTipodeUsuario.Name = "lblTipodeUsuario"
        Me.lblTipodeUsuario.Size = New System.Drawing.Size(223, 24)
        Me.lblTipodeUsuario.TabIndex = 6
        Me.lblTipodeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(112, 179)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(223, 29)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.logouser
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(170, 61)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 105)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(440, 537)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(86, 31)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(651, 722)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(11, 13)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(668, 722)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.Size = New System.Drawing.Size(11, 13)
        Me.DataGridView2.TabIndex = 21
        Me.DataGridView2.Visible = False
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1239, 748)
        Me.Controls.Add(Me.DataGridView2)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Perfil"
        Me.Text = "Perfil"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSmall.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.txtnombre.ResumeLayout(False)
        Me.txtnombre.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTipodeUsuario As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtnombre As Panel
    Friend WithEvents txtFarmacia As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtPerfilapellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPerfilNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFarmacia_Select As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
