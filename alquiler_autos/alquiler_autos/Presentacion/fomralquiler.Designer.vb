<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fomralquiler
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
        Me.ErrorIcono1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnguardar1 = New System.Windows.Forms.Button()
        Me.btncancelar1 = New System.Windows.Forms.Button()
        Me.btnnuevo1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inexistente3 = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar3 = New System.Windows.Forms.TextBox()
        Me.cbocampo3 = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtidsucursal = New System.Windows.Forms.TextBox()
        Me.txtidflota = New System.Windows.Forms.TextBox()
        Me.txtidcliente1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarsucursal = New System.Windows.Forms.Button()
        Me.btnbuscarauto = New System.Windows.Forms.Button()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.txtnsucursal = New System.Windows.Forms.TextBox()
        Me.txtcnombre = New System.Windows.Forms.TextBox()
        Me.txtauto = New System.Windows.Forms.TextBox()
        Me.txtentrada = New System.Windows.Forms.DateTimePicker()
        Me.txtsalida = New System.Windows.Forms.DateTimePicker()
        Me.txtidalquiler = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ErrorIcono1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcono1
        '
        Me.ErrorIcono1.ContainerControl = Me
        '
        'btnguardar1
        '
        Me.btnguardar1.BackColor = System.Drawing.Color.DarkCyan
        Me.btnguardar1.ForeColor = System.Drawing.Color.White
        Me.btnguardar1.Location = New System.Drawing.Point(158, 266)
        Me.btnguardar1.Name = "btnguardar1"
        Me.btnguardar1.Size = New System.Drawing.Size(113, 30)
        Me.btnguardar1.TabIndex = 13
        Me.btnguardar1.Text = "Guardar"
        Me.btnguardar1.UseVisualStyleBackColor = False
        '
        'btncancelar1
        '
        Me.btncancelar1.BackColor = System.Drawing.Color.DarkCyan
        Me.btncancelar1.ForeColor = System.Drawing.Color.White
        Me.btncancelar1.Location = New System.Drawing.Point(312, 266)
        Me.btncancelar1.Name = "btncancelar1"
        Me.btncancelar1.Size = New System.Drawing.Size(128, 33)
        Me.btncancelar1.TabIndex = 12
        Me.btncancelar1.Text = "Cancelar"
        Me.btncancelar1.UseVisualStyleBackColor = False
        '
        'btnnuevo1
        '
        Me.btnnuevo1.BackColor = System.Drawing.Color.DarkCyan
        Me.btnnuevo1.ForeColor = System.Drawing.Color.White
        Me.btnnuevo1.Location = New System.Drawing.Point(20, 266)
        Me.btnnuevo1.Name = "btnnuevo1"
        Me.btnnuevo1.Size = New System.Drawing.Size(95, 32)
        Me.btnnuevo1.TabIndex = 10
        Me.btnnuevo1.Text = "Nuevo"
        Me.btnnuevo1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de Entrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Flota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Cliente"
        '
        'inexistente3
        '
        Me.inexistente3.AutoSize = True
        Me.inexistente3.Location = New System.Drawing.Point(171, 208)
        Me.inexistente3.Name = "inexistente3"
        Me.inexistente3.Size = New System.Drawing.Size(112, 13)
        Me.inexistente3.TabIndex = 3
        Me.inexistente3.TabStop = True
        Me.inexistente3.Text = "Datos Inexistentes"
        '
        'txtbuscar3
        '
        Me.txtbuscar3.Location = New System.Drawing.Point(184, 20)
        Me.txtbuscar3.Name = "txtbuscar3"
        Me.txtbuscar3.Size = New System.Drawing.Size(250, 20)
        Me.txtbuscar3.TabIndex = 2
        '
        'cbocampo3
        '
        Me.cbocampo3.FormattingEnabled = True
        Me.cbocampo3.Items.AddRange(New Object() {"idalquiler"})
        Me.cbocampo3.Location = New System.Drawing.Point(6, 19)
        Me.cbocampo3.Name = "cbocampo3"
        Me.cbocampo3.Size = New System.Drawing.Size(163, 21)
        Me.cbocampo3.TabIndex = 1
        Me.cbocampo3.Text = "idalquiler"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(6, 75)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(428, 250)
        Me.datalistado.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente3)
        Me.GroupBox2.Controls.Add(Me.txtbuscar3)
        Me.GroupBox2.Controls.Add(Me.cbocampo3)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(487, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 406)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txtidsucursal
        '
        Me.txtidsucursal.Location = New System.Drawing.Point(124, 132)
        Me.txtidsucursal.Name = "txtidsucursal"
        Me.txtidsucursal.Size = New System.Drawing.Size(68, 20)
        Me.txtidsucursal.TabIndex = 2
        '
        'txtidflota
        '
        Me.txtidflota.Location = New System.Drawing.Point(124, 99)
        Me.txtidflota.Name = "txtidflota"
        Me.txtidflota.Size = New System.Drawing.Size(68, 20)
        Me.txtidflota.TabIndex = 1
        '
        'txtidcliente1
        '
        Me.txtidcliente1.Location = New System.Drawing.Point(124, 65)
        Me.txtidcliente1.Name = "txtidcliente1"
        Me.txtidcliente1.Size = New System.Drawing.Size(68, 20)
        Me.txtidcliente1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarsucursal)
        Me.GroupBox1.Controls.Add(Me.btnbuscarauto)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcliente)
        Me.GroupBox1.Controls.Add(Me.txtnsucursal)
        Me.GroupBox1.Controls.Add(Me.txtcnombre)
        Me.GroupBox1.Controls.Add(Me.txtauto)
        Me.GroupBox1.Controls.Add(Me.txtentrada)
        Me.GroupBox1.Controls.Add(Me.txtsalida)
        Me.GroupBox1.Controls.Add(Me.txtidalquiler)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnguardar1)
        Me.GroupBox1.Controls.Add(Me.btncancelar1)
        Me.GroupBox1.Controls.Add(Me.btnnuevo1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidsucursal)
        Me.GroupBox1.Controls.Add(Me.txtidflota)
        Me.GroupBox1.Controls.Add(Me.txtidcliente1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 332)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnbuscarsucursal
        '
        Me.btnbuscarsucursal.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscarsucursal.ForeColor = System.Drawing.Color.White
        Me.btnbuscarsucursal.Location = New System.Drawing.Point(376, 128)
        Me.btnbuscarsucursal.Name = "btnbuscarsucursal"
        Me.btnbuscarsucursal.Size = New System.Drawing.Size(64, 24)
        Me.btnbuscarsucursal.TabIndex = 23
        Me.btnbuscarsucursal.Text = "..."
        Me.btnbuscarsucursal.UseVisualStyleBackColor = False
        '
        'btnbuscarauto
        '
        Me.btnbuscarauto.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscarauto.ForeColor = System.Drawing.Color.White
        Me.btnbuscarauto.Location = New System.Drawing.Point(376, 96)
        Me.btnbuscarauto.Name = "btnbuscarauto"
        Me.btnbuscarauto.Size = New System.Drawing.Size(64, 24)
        Me.btnbuscarauto.TabIndex = 22
        Me.btnbuscarauto.Text = "..."
        Me.btnbuscarauto.UseVisualStyleBackColor = False
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscarcliente.ForeColor = System.Drawing.Color.White
        Me.btnbuscarcliente.Location = New System.Drawing.Point(376, 61)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(64, 24)
        Me.btnbuscarcliente.TabIndex = 21
        Me.btnbuscarcliente.Text = "..."
        Me.btnbuscarcliente.UseVisualStyleBackColor = False
        '
        'txtnsucursal
        '
        Me.txtnsucursal.Location = New System.Drawing.Point(203, 132)
        Me.txtnsucursal.Name = "txtnsucursal"
        Me.txtnsucursal.Size = New System.Drawing.Size(167, 20)
        Me.txtnsucursal.TabIndex = 20
        '
        'txtcnombre
        '
        Me.txtcnombre.Location = New System.Drawing.Point(203, 65)
        Me.txtcnombre.Name = "txtcnombre"
        Me.txtcnombre.Size = New System.Drawing.Size(167, 20)
        Me.txtcnombre.TabIndex = 19
        '
        'txtauto
        '
        Me.txtauto.Location = New System.Drawing.Point(203, 99)
        Me.txtauto.Name = "txtauto"
        Me.txtauto.Size = New System.Drawing.Size(167, 20)
        Me.txtauto.TabIndex = 18
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(124, 211)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.Size = New System.Drawing.Size(316, 20)
        Me.txtentrada.TabIndex = 17
        '
        'txtsalida
        '
        Me.txtsalida.Location = New System.Drawing.Point(124, 170)
        Me.txtsalida.Name = "txtsalida"
        Me.txtsalida.Size = New System.Drawing.Size(316, 20)
        Me.txtsalida.TabIndex = 16
        '
        'txtidalquiler
        '
        Me.txtidalquiler.Location = New System.Drawing.Point(124, 36)
        Me.txtidalquiler.Name = "txtidalquiler"
        Me.txtidalquiler.Size = New System.Drawing.Size(316, 20)
        Me.txtidalquiler.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID Alquiler"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "REGISTRO DE ALQUILER"
        '
        'fomralquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 496)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fomralquiler"
        Me.Text = "fomralquiler"
        CType(Me.ErrorIcono1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorIcono1 As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente3 As LinkLabel
    Friend WithEvents txtbuscar3 As TextBox
    Friend WithEvents cbocampo3 As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnguardar1 As Button
    Friend WithEvents btncancelar1 As Button
    Friend WithEvents btnnuevo1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidsucursal As TextBox
    Friend WithEvents txtidflota As TextBox
    Friend WithEvents txtidcliente1 As TextBox
    Friend WithEvents txtidalquiler As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtentrada As DateTimePicker
    Friend WithEvents txtsalida As DateTimePicker
    Friend WithEvents btnbuscarsucursal As Button
    Friend WithEvents btnbuscarauto As Button
    Friend WithEvents btnbuscarcliente As Button
    Friend WithEvents txtnsucursal As TextBox
    Friend WithEvents txtcnombre As TextBox
    Friend WithEvents txtauto As TextBox
    Friend WithEvents Label7 As Label
End Class
