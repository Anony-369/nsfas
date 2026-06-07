Option Explicit On
Option Strict On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtCellNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnTablet = New System.Windows.Forms.RadioButton()
        Me.rbtnLaptop = New System.Windows.Forms.RadioButton()
        Me.rbtnSmartphone = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkCharger = New System.Windows.Forms.CheckBox()
        Me.chkEarphones = New System.Windows.Forms.CheckBox()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnShowPromo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(40, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 22)
        Me.txtName.TabIndex = 0
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(40, 90)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(220, 22)
        Me.txtSurname.TabIndex = 1
        '
        'txtCellNumber
        '
        Me.txtCellNumber.Location = New System.Drawing.Point(40, 140)
        Me.txtCellNumber.Name = "txtCellNumber"
        Me.txtCellNumber.Size = New System.Drawing.Size(220, 22)
        Me.txtCellNumber.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(40, 190)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 22)
        Me.txtEmail.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnTablet)
        Me.GroupBox1.Controls.Add(Me.rbtnLaptop)
        Me.GroupBox1.Controls.Add(Me.rbtnSmartphone)
        Me.GroupBox1.Location = New System.Drawing.Point(300, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 140)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Products (Group A)"
        '
        'rbtnTablet
        '
        Me.rbtnTablet.AutoSize = True
        Me.rbtnTablet.Location = New System.Drawing.Point(20, 100)
        Me.rbtnTablet.Name = "rbtnTablet"
        Me.rbtnTablet.Size = New System.Drawing.Size(71, 21)
        Me.rbtnTablet.TabIndex = 2
        Me.rbtnTablet.TabStop = True
        Me.rbtnTablet.Text = "Tablet"
        Me.rbtnTablet.UseVisualStyleBackColor = True
        '
        'rbtnLaptop
        '
        Me.rbtnLaptop.AutoSize = True
        Me.rbtnLaptop.Location = New System.Drawing.Point(20, 65)
        Me.rbtnLaptop.Name = "rbtnLaptop"
        Me.rbtnLaptop.Size = New System.Drawing.Size(72, 21)
        Me.rbtnLaptop.TabIndex = 1
        Me.rbtnLaptop.TabStop = True
        Me.rbtnLaptop.Text = "Laptop"
        Me.rbtnLaptop.UseVisualStyleBackColor = True
        '
        'rbtnSmartphone
        '
        Me.rbtnSmartphone.AutoSize = True
        Me.rbtnSmartphone.Location = New System.Drawing.Point(20, 30)
        Me.rbtnSmartphone.Name = "rbtnSmartphone"
        Me.rbtnSmartphone.Size = New System.Drawing.Size(104, 21)
        Me.rbtnSmartphone.TabIndex = 0
        Me.rbtnSmartphone.TabStop = True
        Me.rbtnSmartphone.Text = "Smartphone"
        Me.rbtnSmartphone.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkKeyboard)
        Me.GroupBox2.Controls.Add(Me.chkMouse)
        Me.GroupBox2.Controls.Add(Me.chkCharger)
        Me.GroupBox2.Controls.Add(Me.chkEarphones)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 160)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accessories (Group B)"
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(20, 120)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(87, 21)
        Me.chkKeyboard.TabIndex = 3
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Location = New System.Drawing.Point(20, 90)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(66, 21)
        Me.chkMouse.TabIndex = 2
        Me.chkMouse.Text = "Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkCharger
        '
        Me.chkCharger.AutoSize = True
        Me.chkCharger.Location = New System.Drawing.Point(20, 60)
        Me.chkCharger.Name = "chkCharger"
        Me.chkCharger.Size = New System.Drawing.Size(80, 21)
        Me.chkCharger.TabIndex = 1
        Me.chkCharger.Text = "Charger"
        Me.chkCharger.UseVisualStyleBackColor = True
        '
        'chkEarphones
        '
        Me.chkEarphones.AutoSize = True
        Me.chkEarphones.Location = New System.Drawing.Point(20, 30)
        Me.chkEarphones.Name = "chkEarphones"
        Me.chkEarphones.Size = New System.Drawing.Size(90, 21)
        Me.chkEarphones.TabIndex = 0
        Me.chkEarphones.Text = "Earphones"
        Me.chkEarphones.UseVisualStyleBackColor = True
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 16
        Me.lstReceipt.Location = New System.Drawing.Point(40, 250)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(220, 164)
        Me.lstReceipt.TabIndex = 6
        '
        'btnShowPromo
        '
        Me.btnShowPromo.Location = New System.Drawing.Point(300, 370)
        Me.btnShowPromo.Name = "btnShowPromo"
        Me.btnShowPromo.Size = New System.Drawing.Size(120, 30)
        Me.btnShowPromo.TabIndex = 7
        Me.btnShowPromo.Text = "Show Receipt"
        Me.btnShowPromo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(440, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(250, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cell Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 471)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowPromo)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCellNumber)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tech Store Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtCellNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnTablet As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnLaptop As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSmartphone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents chkMouse As System.Windows.Forms.CheckBox
    Friend WithEvents chkCharger As System.Windows.Forms.CheckBox
    Friend WithEvents chkEarphones As System.Windows.Forms.CheckBox
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox
    Friend WithEvents btnShowPromo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
