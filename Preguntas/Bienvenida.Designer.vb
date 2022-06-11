<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TxtbNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.Lime
        Me.textBox1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textBox1.Location = New System.Drawing.Point(67, 24)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(785, 260)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Lime
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(67, 308)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(316, 32)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Por favor ingrese su nombre"
        '
        'TxtbNombre
        '
        Me.TxtbNombre.BackColor = System.Drawing.Color.Lime
        Me.TxtbNombre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtbNombre.Location = New System.Drawing.Point(388, 308)
        Me.TxtbNombre.Margin = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtbNombre.Multiline = True
        Me.TxtbNombre.Name = "TxtbNombre"
        Me.TxtbNombre.Size = New System.Drawing.Size(465, 32)
        Me.TxtbNombre.TabIndex = 4
        Me.TxtbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(377, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 71)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(906, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TxtbNombre)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Bienvenida"
        Me.Text = "Bienvenida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents TxtbNombre As TextBox
    Friend WithEvents Button1 As Button
End Class
