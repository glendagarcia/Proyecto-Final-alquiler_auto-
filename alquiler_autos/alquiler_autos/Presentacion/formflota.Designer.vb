<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formflota
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente1 = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar1 = New System.Windows.Forms.TextBox()
        Me.cbocampo1 = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.txtflag1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtflag1)
        Me.GroupBox2.Controls.Add(Me.inexistente1)
        Me.GroupBox2.Controls.Add(Me.txtbuscar1)
        Me.GroupBox2.Controls.Add(Me.cbocampo1)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(30, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 407)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lsitado de Flota"
        '
        'inexistente1
        '
        Me.inexistente1.AutoSize = True
        Me.inexistente1.Location = New System.Drawing.Point(222, 207)
        Me.inexistente1.Name = "inexistente1"
        Me.inexistente1.Size = New System.Drawing.Size(112, 13)
        Me.inexistente1.TabIndex = 3
        Me.inexistente1.TabStop = True
        Me.inexistente1.Text = "Datos Inexistentes"
        '
        'txtbuscar1
        '
        Me.txtbuscar1.Location = New System.Drawing.Point(184, 20)
        Me.txtbuscar1.Name = "txtbuscar1"
        Me.txtbuscar1.Size = New System.Drawing.Size(250, 20)
        Me.txtbuscar1.TabIndex = 2
        '
        'cbocampo1
        '
        Me.cbocampo1.FormattingEnabled = True
        Me.cbocampo1.Items.AddRange(New Object() {"matricula", "marca", "modelo", "estado"})
        Me.cbocampo1.Location = New System.Drawing.Point(6, 19)
        Me.cbocampo1.Name = "cbocampo1"
        Me.cbocampo1.Size = New System.Drawing.Size(163, 21)
        Me.cbocampo1.TabIndex = 1
        Me.cbocampo1.Text = "matricula"
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
        'txtflag1
        '
        Me.txtflag1.Location = New System.Drawing.Point(505, 19)
        Me.txtflag1.Name = "txtflag1"
        Me.txtflag1.Size = New System.Drawing.Size(59, 20)
        Me.txtflag1.TabIndex = 4
        Me.txtflag1.Text = "0"
        '
        'formflota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formflota"
        Me.Text = "formflota"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente1 As LinkLabel
    Friend WithEvents txtbuscar1 As TextBox
    Friend WithEvents cbocampo1 As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents txtflag1 As TextBox
End Class
