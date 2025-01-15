<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpbSize = New System.Windows.Forms.GroupBox()
        Me.cboPizzaSize = New System.Windows.Forms.ComboBox()
        Me.grpbType = New System.Windows.Forms.GroupBox()
        Me.radSpecial = New System.Windows.Forms.RadioButton()
        Me.radVegetarian = New System.Windows.Forms.RadioButton()
        Me.radHamAndMushroom = New System.Windows.Forms.RadioButton()
        Me.radPepperoni = New System.Windows.Forms.RadioButton()
        Me.grpbExtraToppings = New System.Windows.Forms.GroupBox()
        Me.chkExtraHam = New System.Windows.Forms.CheckBox()
        Me.chkExtraCheese = New System.Windows.Forms.CheckBox()
        Me.grpbQuantity = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpbSize.SuspendLayout()
        Me.grpbType.SuspendLayout()
        Me.grpbExtraToppings.SuspendLayout()
        Me.grpbQuantity.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbSize
        '
        Me.grpbSize.Controls.Add(Me.cboPizzaSize)
        Me.grpbSize.Location = New System.Drawing.Point(160, 202)
        Me.grpbSize.Name = "grpbSize"
        Me.grpbSize.Size = New System.Drawing.Size(136, 57)
        Me.grpbSize.TabIndex = 0
        Me.grpbSize.TabStop = False
        Me.grpbSize.Text = "Size"
        '
        'cboPizzaSize
        '
        Me.cboPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPizzaSize.FormattingEnabled = True
        Me.cboPizzaSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboPizzaSize.Location = New System.Drawing.Point(6, 19)
        Me.cboPizzaSize.Name = "cboPizzaSize"
        Me.cboPizzaSize.Size = New System.Drawing.Size(121, 21)
        Me.cboPizzaSize.TabIndex = 8
        '
        'grpbType
        '
        Me.grpbType.Controls.Add(Me.radSpecial)
        Me.grpbType.Controls.Add(Me.radVegetarian)
        Me.grpbType.Controls.Add(Me.radHamAndMushroom)
        Me.grpbType.Controls.Add(Me.radPepperoni)
        Me.grpbType.Location = New System.Drawing.Point(320, 202)
        Me.grpbType.Name = "grpbType"
        Me.grpbType.Size = New System.Drawing.Size(128, 117)
        Me.grpbType.TabIndex = 1
        Me.grpbType.TabStop = False
        Me.grpbType.Text = "Pizza Type"
        '
        'radSpecial
        '
        Me.radSpecial.AutoSize = True
        Me.radSpecial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radSpecial.Location = New System.Drawing.Point(6, 88)
        Me.radSpecial.Name = "radSpecial"
        Me.radSpecial.Size = New System.Drawing.Size(60, 17)
        Me.radSpecial.TabIndex = 7
        Me.radSpecial.TabStop = True
        Me.radSpecial.Text = "Special"
        Me.radSpecial.UseVisualStyleBackColor = True
        '
        'radVegetarian
        '
        Me.radVegetarian.AutoSize = True
        Me.radVegetarian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radVegetarian.Location = New System.Drawing.Point(6, 65)
        Me.radVegetarian.Name = "radVegetarian"
        Me.radVegetarian.Size = New System.Drawing.Size(76, 17)
        Me.radVegetarian.TabIndex = 6
        Me.radVegetarian.TabStop = True
        Me.radVegetarian.Text = "Vegetarian"
        Me.radVegetarian.UseVisualStyleBackColor = True
        '
        'radHamAndMushroom
        '
        Me.radHamAndMushroom.AutoSize = True
        Me.radHamAndMushroom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radHamAndMushroom.Location = New System.Drawing.Point(6, 42)
        Me.radHamAndMushroom.Name = "radHamAndMushroom"
        Me.radHamAndMushroom.Size = New System.Drawing.Size(120, 17)
        Me.radHamAndMushroom.TabIndex = 5
        Me.radHamAndMushroom.TabStop = True
        Me.radHamAndMushroom.Text = "Ham and Mushroom"
        Me.radHamAndMushroom.UseVisualStyleBackColor = True
        '
        'radPepperoni
        '
        Me.radPepperoni.AutoSize = True
        Me.radPepperoni.Checked = True
        Me.radPepperoni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radPepperoni.Location = New System.Drawing.Point(6, 19)
        Me.radPepperoni.Name = "radPepperoni"
        Me.radPepperoni.Size = New System.Drawing.Size(73, 17)
        Me.radPepperoni.TabIndex = 5
        Me.radPepperoni.TabStop = True
        Me.radPepperoni.Text = "Pepperoni"
        Me.radPepperoni.UseVisualStyleBackColor = True
        '
        'grpbExtraToppings
        '
        Me.grpbExtraToppings.Controls.Add(Me.chkExtraHam)
        Me.grpbExtraToppings.Controls.Add(Me.chkExtraCheese)
        Me.grpbExtraToppings.Location = New System.Drawing.Point(479, 202)
        Me.grpbExtraToppings.Name = "grpbExtraToppings"
        Me.grpbExtraToppings.Size = New System.Drawing.Size(102, 73)
        Me.grpbExtraToppings.TabIndex = 2
        Me.grpbExtraToppings.TabStop = False
        Me.grpbExtraToppings.Text = "Extra Toppings"
        '
        'chkExtraHam
        '
        Me.chkExtraHam.AutoSize = True
        Me.chkExtraHam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkExtraHam.Location = New System.Drawing.Point(7, 46)
        Me.chkExtraHam.Name = "chkExtraHam"
        Me.chkExtraHam.Size = New System.Drawing.Size(73, 17)
        Me.chkExtraHam.TabIndex = 1
        Me.chkExtraHam.Text = "Extra ham"
        Me.chkExtraHam.UseVisualStyleBackColor = True
        '
        'chkExtraCheese
        '
        Me.chkExtraCheese.AutoSize = True
        Me.chkExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkExtraCheese.Location = New System.Drawing.Point(7, 22)
        Me.chkExtraCheese.Name = "chkExtraCheese"
        Me.chkExtraCheese.Size = New System.Drawing.Size(88, 17)
        Me.chkExtraCheese.TabIndex = 0
        Me.chkExtraCheese.Text = "Extra cheese"
        Me.chkExtraCheese.UseVisualStyleBackColor = True
        '
        'grpbQuantity
        '
        Me.grpbQuantity.Controls.Add(Me.txtQuantity)
        Me.grpbQuantity.Location = New System.Drawing.Point(621, 202)
        Me.grpbQuantity.Name = "grpbQuantity"
        Me.grpbQuantity.Size = New System.Drawing.Size(128, 58)
        Me.grpbQuantity.TabIndex = 4
        Me.grpbQuantity.TabStop = False
        Me.grpbQuantity.Text = "Quantity (1-10)"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(12, 21)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(425, 354)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 45)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Firebrick
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(135, 402)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(658, 48)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.appPizzaCost.My.Resources.Resources.checker_pattern_banner
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(930, 138)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.appPizzaCost.My.Resources.Resources.italy_flag_banner
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 526)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(930, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(321, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 57)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pizza time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(446, 38)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Authentic Italian Pizza"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-1, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(930, 2)
        Me.Label3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-2, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(930, 2)
        Me.Label4.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(134, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(659, 2)
        Me.Label5.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(134, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(659, 2)
        Me.Label6.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(134, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(2, 46)
        Me.Label7.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(791, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(2, 46)
        Me.Label8.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(927, 575)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpbQuantity)
        Me.Controls.Add(Me.grpbExtraToppings)
        Me.Controls.Add(Me.grpbType)
        Me.Controls.Add(Me.grpbSize)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(943, 614)
        Me.MinimumSize = New System.Drawing.Size(943, 614)
        Me.Name = "Form1"
        Me.Text = "Pizza Time"
        Me.grpbSize.ResumeLayout(False)
        Me.grpbType.ResumeLayout(False)
        Me.grpbType.PerformLayout()
        Me.grpbExtraToppings.ResumeLayout(False)
        Me.grpbExtraToppings.PerformLayout()
        Me.grpbQuantity.ResumeLayout(False)
        Me.grpbQuantity.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpbSize As GroupBox
    Friend WithEvents grpbType As GroupBox
    Friend WithEvents radSpecial As RadioButton
    Friend WithEvents radVegetarian As RadioButton
    Friend WithEvents radHamAndMushroom As RadioButton
    Friend WithEvents radPepperoni As RadioButton
    Friend WithEvents grpbExtraToppings As GroupBox
    Friend WithEvents chkExtraHam As CheckBox
    Friend WithEvents chkExtraCheese As CheckBox
    Friend WithEvents grpbQuantity As GroupBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cboPizzaSize As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
