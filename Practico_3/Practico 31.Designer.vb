<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PequenoFormulario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PequenoFormulario))
        LDni = New Label()
        TApellido = New TextBox()
        BGuardar = New Button()
        TNombre = New TextBox()
        TDni = New TextBox()
        LApellido = New Label()
        LNombre = New Label()
        LNya = New Label()
        LModificar = New Label()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        TTelefono = New TextBox()
        PictureBox1 = New PictureBox()
        BEliminar = New Button()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        Button2 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(21, 53)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 0
        LDni.Text = "DNI"
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(100, 91)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 1
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = SystemColors.ControlLight
        BGuardar.FlatStyle = FlatStyle.Popup
        BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), Image)
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.Location = New Point(168, 310)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(121, 64)
        BGuardar.TabIndex = 2
        BGuardar.Text = "Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleRight
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(100, 132)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 4
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(100, 50)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 5
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(3, 91)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 6
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(21, 140)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 7
        LNombre.Text = "Nombre"
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(3, 15)
        LNya.Name = "LNya"
        LNya.Size = New Size(107, 15)
        LNya.TabIndex = 8
        LNya.Text = "Nombre y Apellido"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.BackColor = SystemColors.ButtonHighlight
        LModificar.ForeColor = Color.IndianRed
        LModificar.Location = New Point(128, 15)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 9
        LModificar.Text = "Modificar"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TTelefono)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LDni)
        Panel1.Controls.Add(TApellido)
        Panel1.Location = New Point(18, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 292)
        Panel1.TabIndex = 10
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(136, 242)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(67, 19)
        CheckBox3.TabIndex = 15
        CheckBox3.Text = "Naranja"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(136, 267)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(85, 19)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Mastercard"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(136, 217)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(47, 19)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Visa"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 12
        Label2.Text = "Tarjeta de Credito"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 11
        Label1.Text = "Telefono"
        ' 
        ' TTelefono
        ' 
        TTelefono.Location = New Point(100, 173)
        TTelefono.Name = "TTelefono"
        TTelefono.Size = New Size(100, 23)
        TTelefono.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(330, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 143)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' BEliminar
        ' 
        BEliminar.BackColor = SystemColors.ControlLight
        BEliminar.FlatStyle = FlatStyle.Popup
        BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), Image)
        BEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BEliminar.Location = New Point(2, 310)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(126, 64)
        BEliminar.TabIndex = 17
        BEliminar.Text = "Eliminar"
        BEliminar.TextAlign = ContentAlignment.MiddleRight
        BEliminar.UseVisualStyleBackColor = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Checked = True
        RBVaron.Font = New Font("Microsoft Sans Serif", 8.25F)
        RBVaron.Location = New Point(330, 226)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(53, 17)
        RBVaron.TabIndex = 18
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(399, 226)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 19
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLight
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(323, 310)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 64)
        Button2.TabIndex = 20
        Button2.Text = "Salir"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PequenoFormulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(456, 382)
        Controls.Add(Button2)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(BEliminar)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(BGuardar)
        Name = "PequenoFormulario"
        Text = "Practico_31"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDni As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BEliminar As Button
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents Button2 As Button

End Class
