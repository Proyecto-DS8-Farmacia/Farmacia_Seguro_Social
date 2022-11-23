<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Correo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Destinatario = New System.Windows.Forms.TextBox()
        Me.txt_Asunto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ProveedorC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Enviar = New System.Windows.Forms.Button()
        Me.txt_FarmaciaC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.PContraseña = New System.Windows.Forms.Label()
        Me.txt_Emisor = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.dgv_ReStockC = New System.Windows.Forms.DataGridView()
        Me.Sustancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_ReStockC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(442, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 46)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Detalles del Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(103, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Destinatario "
        '
        'txt_Destinatario
        '
        Me.txt_Destinatario.Location = New System.Drawing.Point(243, 210)
        Me.txt_Destinatario.Name = "txt_Destinatario"
        Me.txt_Destinatario.Size = New System.Drawing.Size(246, 27)
        Me.txt_Destinatario.TabIndex = 35
        '
        'txt_Asunto
        '
        Me.txt_Asunto.Location = New System.Drawing.Point(243, 267)
        Me.txt_Asunto.Name = "txt_Asunto"
        Me.txt_Asunto.Size = New System.Drawing.Size(246, 27)
        Me.txt_Asunto.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(103, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Asunto"
        '
        'txt_ProveedorC
        '
        Me.txt_ProveedorC.Location = New System.Drawing.Point(896, 210)
        Me.txt_ProveedorC.Name = "txt_ProveedorC"
        Me.txt_ProveedorC.Size = New System.Drawing.Size(246, 27)
        Me.txt_ProveedorC.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(756, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Proveedor"
        '
        'btn_Enviar
        '
        Me.btn_Enviar.BackColor = System.Drawing.Color.Black
        Me.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Enviar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Enviar.ForeColor = System.Drawing.Color.White
        Me.btn_Enviar.Location = New System.Drawing.Point(567, 672)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(177, 51)
        Me.btn_Enviar.TabIndex = 42
        Me.btn_Enviar.Text = "ENVIAR"
        Me.btn_Enviar.UseVisualStyleBackColor = False
        '
        'txt_FarmaciaC
        '
        Me.txt_FarmaciaC.Location = New System.Drawing.Point(896, 271)
        Me.txt_FarmaciaC.Name = "txt_FarmaciaC"
        Me.txt_FarmaciaC.Size = New System.Drawing.Size(246, 27)
        Me.txt_FarmaciaC.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(756, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Farmacia"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(896, 155)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.ReadOnly = True
        Me.txt_pass.Size = New System.Drawing.Size(246, 27)
        Me.txt_pass.TabIndex = 49
        '
        'PContraseña
        '
        Me.PContraseña.AutoSize = True
        Me.PContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PContraseña.ForeColor = System.Drawing.Color.White
        Me.PContraseña.Location = New System.Drawing.Point(756, 155)
        Me.PContraseña.Name = "PContraseña"
        Me.PContraseña.Size = New System.Drawing.Size(124, 23)
        Me.PContraseña.TabIndex = 48
        Me.PContraseña.Text = "Contraseña"
        '
        'txt_Emisor
        '
        Me.txt_Emisor.Location = New System.Drawing.Point(243, 155)
        Me.txt_Emisor.Name = "txt_Emisor"
        Me.txt_Emisor.ReadOnly = True
        Me.txt_Emisor.Size = New System.Drawing.Size(246, 27)
        Me.txt_Emisor.TabIndex = 47
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(103, 155)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(78, 23)
        Me.label.TabIndex = 46
        Me.label.Text = "Emisor"
        '
        'dgv_ReStockC
        '
        Me.dgv_ReStockC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ReStockC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sustancia, Me.Cantidad})
        Me.dgv_ReStockC.Location = New System.Drawing.Point(479, 409)
        Me.dgv_ReStockC.Name = "dgv_ReStockC"
        Me.dgv_ReStockC.RowHeadersWidth = 51
        Me.dgv_ReStockC.RowTemplate.Height = 29
        Me.dgv_ReStockC.Size = New System.Drawing.Size(300, 188)
        Me.dgv_ReStockC.TabIndex = 50
        '
        'Sustancia
        '
        Me.Sustancia.HeaderText = "Sustancia"
        Me.Sustancia.MinimumWidth = 6
        Me.Sustancia.Name = "Sustancia"
        Me.Sustancia.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 125
        '
        'Correo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1239, 748)
        Me.Controls.Add(Me.dgv_ReStockC)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.PContraseña)
        Me.Controls.Add(Me.txt_Emisor)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txt_FarmaciaC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Enviar)
        Me.Controls.Add(Me.txt_ProveedorC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Asunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Destinatario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Correo"
        Me.Text = "Correo"
        CType(Me.dgv_ReStockC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Destinatario As TextBox
    Friend WithEvents txt_Asunto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ProveedorC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Enviar As Button
    Friend WithEvents txt_FarmaciaC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_ReStockCorreo As DataGridView
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents PContraseña As Label
    Friend WithEvents txt_Emisor As TextBox
    Friend WithEvents label As Label
    Friend WithEvents dgv_ReStockC As DataGridView
    Friend WithEvents Sustancia As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
End Class
