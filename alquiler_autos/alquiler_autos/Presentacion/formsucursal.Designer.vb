<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formsucursal
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente2 = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar2 = New System.Windows.Forms.TextBox()
        Me.cbocampo2 = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtflag2)
        Me.GroupBox2.Controls.Add(Me.inexistente2)
        Me.GroupBox2.Controls.Add(Me.txtbuscar2)
        Me.GroupBox2.Controls.Add(Me.cbocampo2)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 407)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Sucursales"
        '
        'inexistente2
        '
        Me.inexistente2.AutoSize = True
        Me.inexistente2.Location = New System.Drawing.Point(222, 207)
        Me.inexistente2.Name = "inexistente2"
        Me.inexistente2.Size = New System.Drawing.Size(112, 13)
        Me.inexistente2.TabIndex = 3
        Me.inexistente2.TabStop = True
        Me.inexistente2.Text = "Datos Inexistentes"
        '
        'txtbuscar2
        '
        Me.txtbuscar2.Location = New System.Drawing.Point(184, 20)
        Me.txtbuscar2.Name = "txtbuscar2"
        Me.txtbuscar2.Size = New System.Drawing.Size(250, 20)
        Me.txtbuscar2.TabIndex = 2
        '
        'cbocampo2
        '
        Me.cbocampo2.FormattingEnabled = True
        Me.cbocampo2.Items.AddRange(New Object() {"nombre", "ciudad", "direccion", "telefono"})
        Me.cbocampo2.Location = New System.Drawing.Point(6, 19)
        Me.cbocampo2.Name = "cbocampo2"
        Me.cbocampo2.Size = New System.Drawing.Size(163, 21)
        Me.cbocampo2.TabIndex = 1
        Me.cbocampo2.Text = "nombre"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(6, 56)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(558, 322)
        Me.datalistado.TabIndex = 0
        '
        'txtflag2
        '
        Me.txtflag2.Location = New System.Drawing.Point(489, 20)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(75, 20)
        Me.txtflag2.TabIndex = 4
        Me.txtflag2.Text = "0"
        '
        'formsucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formsucursal"
        Me.Text = "formsucursal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente2 As LinkLabel
    Friend WithEvents txtbuscar2 As TextBox
    Friend WithEvents cbocampo2 As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents txtflag2 As TextBox
End Class
