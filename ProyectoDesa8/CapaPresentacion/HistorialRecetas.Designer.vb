<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialRecetas
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
        Me.dgvHistorialRe = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHistorialRe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistorialRe
        '
        Me.dgvHistorialRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorialRe.Location = New System.Drawing.Point(63, 85)
        Me.dgvHistorialRe.Name = "dgvHistorialRe"
        Me.dgvHistorialRe.RowTemplate.Height = 25
        Me.dgvHistorialRe.Size = New System.Drawing.Size(450, 216)
        Me.dgvHistorialRe.TabIndex = 0
        '
        'HistorialRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvHistorialRe)
        Me.Name = "HistorialRecetas"
        Me.Text = "HistorialRecetas"
        CType(Me.dgvHistorialRe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistorialRe As DataGridView
End Class
