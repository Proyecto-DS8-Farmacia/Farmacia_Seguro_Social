<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVerNewPass = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVerPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(104, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "confirmar contraseña "
        '
        'txtVerNewPass
        '
        Me.txtVerNewPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtVerNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVerNewPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerNewPass.ForeColor = System.Drawing.Color.White
        Me.txtVerNewPass.Location = New System.Drawing.Point(108, 185)
        Me.txtVerNewPass.Name = "txtVerNewPass"
        Me.txtVerNewPass.Size = New System.Drawing.Size(350, 20)
        Me.txtVerNewPass.TabIndex = 20
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(210, 256)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(162, 31)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Recuperar"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(104, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "nueva contraseña "
        '
        'txtVerPass
        '
        Me.txtVerPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtVerPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVerPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerPass.ForeColor = System.Drawing.Color.White
        Me.txtVerPass.Location = New System.Drawing.Point(108, 88)
        Me.txtVerPass.Name = "txtVerPass"
        Me.txtVerPass.Size = New System.Drawing.Size(350, 20)
        Me.txtVerPass.TabIndex = 17
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVerNewPass)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVerPass)
        Me.Name = "Reset"
        Me.Text = "Reset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtVerNewPass As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVerPass As TextBox
End Class
