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
        Me.components = New System.ComponentModel.Container()
        Me.ShoppingCart = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DroneVendingMachine1 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine2 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine3 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine4 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine5 = New DroneDad.DroneVendingMachine()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DroneVendingMachine6 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine7 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine8 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine9 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine10 = New DroneDad.DroneVendingMachine()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DroneVendingMachine11 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine12 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine13 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine14 = New DroneDad.DroneVendingMachine()
        Me.DroneVendingMachine15 = New DroneDad.DroneVendingMachine()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DroneVendingMachine16 = New DroneDad.DroneVendingMachine()
        Me.SuspendLayout()
        '
        'ShoppingCart
        '
        Me.ShoppingCart.AutoSize = True
        Me.ShoppingCart.Location = New System.Drawing.Point(697, 357)
        Me.ShoppingCart.Name = "ShoppingCart"
        Me.ShoppingCart.Size = New System.Drawing.Size(53, 20)
        Me.ShoppingCart.TabIndex = 1
        Me.ShoppingCart.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'DroneVendingMachine1
        '
        Me.DroneVendingMachine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine1.count = 0
        Me.DroneVendingMachine1.label = "Drone Body"
        Me.DroneVendingMachine1.Location = New System.Drawing.Point(11, 12)
        Me.DroneVendingMachine1.Name = "DroneVendingMachine1"
        Me.DroneVendingMachine1.Pictore = Global.DroneDad.My.Resources.Resources._619WbcMO36S__AC_UF350_350_QL80_
        Me.DroneVendingMachine1.price = New Decimal(New Integer() {3199, 0, 0, 131072})
        Me.DroneVendingMachine1.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine1.TabIndex = 2
        '
        'DroneVendingMachine2
        '
        Me.DroneVendingMachine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine2.count = 0
        Me.DroneVendingMachine2.label = "Carbon Fiber 6 Armed Drone With Landing Gears And Camera Mount"
        Me.DroneVendingMachine2.Location = New System.Drawing.Point(182, 12)
        Me.DroneVendingMachine2.Name = "DroneVendingMachine2"
        Me.DroneVendingMachine2.Pictore = Global.DroneDad.My.Resources.Resources.S896e1557edb04c878a67e7c0f7c8f350S_jpg_640x640Q90_jpg_
        Me.DroneVendingMachine2.price = New Decimal(New Integer() {8999, 0, 0, 131072})
        Me.DroneVendingMachine2.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine2.TabIndex = 3
        '
        'DroneVendingMachine3
        '
        Me.DroneVendingMachine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine3.count = 0
        Me.DroneVendingMachine3.label = "Racing Drone Frame"
        Me.DroneVendingMachine3.Location = New System.Drawing.Point(352, 12)
        Me.DroneVendingMachine3.Name = "DroneVendingMachine3"
        Me.DroneVendingMachine3.Pictore = Global.DroneDad.My.Resources.Resources.DroneBody3
        Me.DroneVendingMachine3.price = New Decimal(New Integer() {3899, 0, 0, 131072})
        Me.DroneVendingMachine3.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine3.TabIndex = 4
        '
        'DroneVendingMachine4
        '
        Me.DroneVendingMachine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine4.count = 0
        Me.DroneVendingMachine4.label = "Drone with cheese"
        Me.DroneVendingMachine4.Location = New System.Drawing.Point(522, 12)
        Me.DroneVendingMachine4.Name = "DroneVendingMachine4"
        Me.DroneVendingMachine4.Pictore = Global.DroneDad.My.Resources.Resources.DroneBody4
        Me.DroneVendingMachine4.price = New Decimal(New Integer() {5621, 0, 0, 131072})
        Me.DroneVendingMachine4.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine4.TabIndex = 5
        '
        'DroneVendingMachine5
        '
        Me.DroneVendingMachine5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine5.count = 0
        Me.DroneVendingMachine5.label = "Rubber Ducky Drone"
        Me.DroneVendingMachine5.Location = New System.Drawing.Point(11, 139)
        Me.DroneVendingMachine5.Name = "DroneVendingMachine5"
        Me.DroneVendingMachine5.Pictore = Global.DroneDad.My.Resources.Resources.Ducky
        Me.DroneVendingMachine5.price = New Decimal(New Integer() {40078, 0, 0, 131072})
        Me.DroneVendingMachine5.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine5.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 155)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 159)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "To Motors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(115, 345)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "To Propellors"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DroneVendingMachine6
        '
        Me.DroneVendingMachine6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine6.count = 0
        Me.DroneVendingMachine6.label = "Motor 5"
        Me.DroneVendingMachine6.Location = New System.Drawing.Point(10, 141)
        Me.DroneVendingMachine6.Name = "DroneVendingMachine6"
        Me.DroneVendingMachine6.Pictore = Global.DroneDad.My.Resources.Resources.Motor5
        Me.DroneVendingMachine6.price = New Decimal(New Integer() {2599, 0, 0, 131072})
        Me.DroneVendingMachine6.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine6.TabIndex = 15
        '
        'DroneVendingMachine7
        '
        Me.DroneVendingMachine7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine7.count = 0
        Me.DroneVendingMachine7.label = "Motor 4"
        Me.DroneVendingMachine7.Location = New System.Drawing.Point(522, 15)
        Me.DroneVendingMachine7.Name = "DroneVendingMachine7"
        Me.DroneVendingMachine7.Pictore = Global.DroneDad.My.Resources.Resources.Motor4
        Me.DroneVendingMachine7.price = New Decimal(New Integer() {3789, 0, 0, 131072})
        Me.DroneVendingMachine7.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine7.TabIndex = 14
        '
        'DroneVendingMachine8
        '
        Me.DroneVendingMachine8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine8.count = 0
        Me.DroneVendingMachine8.label = "Motor 3"
        Me.DroneVendingMachine8.Location = New System.Drawing.Point(352, 12)
        Me.DroneVendingMachine8.Name = "DroneVendingMachine8"
        Me.DroneVendingMachine8.Pictore = Global.DroneDad.My.Resources.Resources.Motor3
        Me.DroneVendingMachine8.price = New Decimal(New Integer() {5899, 0, 0, 131072})
        Me.DroneVendingMachine8.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine8.TabIndex = 13
        '
        'DroneVendingMachine9
        '
        Me.DroneVendingMachine9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine9.count = 0
        Me.DroneVendingMachine9.label = "Motor 2"
        Me.DroneVendingMachine9.Location = New System.Drawing.Point(182, 15)
        Me.DroneVendingMachine9.Name = "DroneVendingMachine9"
        Me.DroneVendingMachine9.Pictore = Global.DroneDad.My.Resources.Resources.Motor2
        Me.DroneVendingMachine9.price = New Decimal(New Integer() {7485, 0, 0, 131072})
        Me.DroneVendingMachine9.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine9.TabIndex = 12
        '
        'DroneVendingMachine10
        '
        Me.DroneVendingMachine10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine10.count = 0
        Me.DroneVendingMachine10.label = "Drone Motor"
        Me.DroneVendingMachine10.Location = New System.Drawing.Point(12, 15)
        Me.DroneVendingMachine10.Name = "DroneVendingMachine10"
        Me.DroneVendingMachine10.Pictore = Global.DroneDad.My.Resources.Resources.Motor1
        Me.DroneVendingMachine10.price = New Decimal(New Integer() {6299, 0, 0, 131072})
        Me.DroneVendingMachine10.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine10.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(40, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 29)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "To Drone Body's"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DroneVendingMachine11
        '
        Me.DroneVendingMachine11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine11.count = 0
        Me.DroneVendingMachine11.label = "Carbon Fiber "
        Me.DroneVendingMachine11.Location = New System.Drawing.Point(10, 15)
        Me.DroneVendingMachine11.Name = "DroneVendingMachine11"
        Me.DroneVendingMachine11.Pictore = Global.DroneDad.My.Resources.Resources.Blade1
        Me.DroneVendingMachine11.price = New Decimal(New Integer() {2775, 0, 0, 131072})
        Me.DroneVendingMachine11.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine11.TabIndex = 26
        Me.DroneVendingMachine11.Visible = False
        '
        'DroneVendingMachine12
        '
        Me.DroneVendingMachine12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine12.count = 0
        Me.DroneVendingMachine12.label = "2 Blade Propeller"
        Me.DroneVendingMachine12.Location = New System.Drawing.Point(180, 12)
        Me.DroneVendingMachine12.Name = "DroneVendingMachine12"
        Me.DroneVendingMachine12.Pictore = Global.DroneDad.My.Resources.Resources.Blade2
        Me.DroneVendingMachine12.price = New Decimal(New Integer() {1015, 0, 0, 131072})
        Me.DroneVendingMachine12.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine12.TabIndex = 25
        Me.DroneVendingMachine12.Visible = False
        '
        'DroneVendingMachine13
        '
        Me.DroneVendingMachine13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine13.count = 0
        Me.DroneVendingMachine13.label = "Toroidal Propellers"
        Me.DroneVendingMachine13.Location = New System.Drawing.Point(352, 12)
        Me.DroneVendingMachine13.Name = "DroneVendingMachine13"
        Me.DroneVendingMachine13.Pictore = Global.DroneDad.My.Resources.Resources.Blade3
        Me.DroneVendingMachine13.price = New Decimal(New Integer() {1843, 0, 0, 131072})
        Me.DroneVendingMachine13.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine13.TabIndex = 24
        Me.DroneVendingMachine13.Visible = False
        '
        'DroneVendingMachine14
        '
        Me.DroneVendingMachine14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine14.count = 0
        Me.DroneVendingMachine14.label = "3 Blade Led Propellers"
        Me.DroneVendingMachine14.Location = New System.Drawing.Point(522, 15)
        Me.DroneVendingMachine14.Name = "DroneVendingMachine14"
        Me.DroneVendingMachine14.Pictore = Global.DroneDad.My.Resources.Resources.Blade4
        Me.DroneVendingMachine14.price = New Decimal(New Integer() {3499, 0, 0, 131072})
        Me.DroneVendingMachine14.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine14.TabIndex = 23
        Me.DroneVendingMachine14.Visible = False
        '
        'DroneVendingMachine15
        '
        Me.DroneVendingMachine15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine15.count = 0
        Me.DroneVendingMachine15.label = "Tri blade Toroidal Propellers"
        Me.DroneVendingMachine15.Location = New System.Drawing.Point(10, 138)
        Me.DroneVendingMachine15.Name = "DroneVendingMachine15"
        Me.DroneVendingMachine15.Pictore = Global.DroneDad.My.Resources.Resources.Blade5
        Me.DroneVendingMachine15.price = New Decimal(New Integer() {2480, 0, 0, 131072})
        Me.DroneVendingMachine15.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine15.TabIndex = 22
        Me.DroneVendingMachine15.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(553, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Clear Cart"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(654, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cart:"
        '
        'DroneVendingMachine16
        '
        Me.DroneVendingMachine16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DroneVendingMachine16.count = 0
        Me.DroneVendingMachine16.label = "Cheese"
        Me.DroneVendingMachine16.Location = New System.Drawing.Point(586, 155)
        Me.DroneVendingMachine16.Name = "DroneVendingMachine16"
        Me.DroneVendingMachine16.Pictore = Global.DroneDad.My.Resources.Resources.Cheese
        Me.DroneVendingMachine16.price = New Decimal(New Integer() {2, 0, 0, 0})
        Me.DroneVendingMachine16.Size = New System.Drawing.Size(164, 120)
        Me.DroneVendingMachine16.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.DroneVendingMachine16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DroneVendingMachine11)
        Me.Controls.Add(Me.DroneVendingMachine12)
        Me.Controls.Add(Me.DroneVendingMachine13)
        Me.Controls.Add(Me.DroneVendingMachine14)
        Me.Controls.Add(Me.DroneVendingMachine15)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DroneVendingMachine6)
        Me.Controls.Add(Me.DroneVendingMachine7)
        Me.Controls.Add(Me.DroneVendingMachine8)
        Me.Controls.Add(Me.DroneVendingMachine9)
        Me.Controls.Add(Me.DroneVendingMachine10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DroneVendingMachine5)
        Me.Controls.Add(Me.DroneVendingMachine4)
        Me.Controls.Add(Me.DroneVendingMachine3)
        Me.Controls.Add(Me.DroneVendingMachine2)
        Me.Controls.Add(Me.DroneVendingMachine1)
        Me.Controls.Add(Me.ShoppingCart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShoppingCart As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DroneVendingMachine1 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine2 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine3 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine4 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine5 As DroneVendingMachine
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DroneVendingMachine6 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine7 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine8 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine9 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine10 As DroneVendingMachine
    Friend WithEvents Button4 As Button
    Friend WithEvents DroneVendingMachine11 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine12 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine13 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine14 As DroneVendingMachine
    Friend WithEvents DroneVendingMachine15 As DroneVendingMachine
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DroneVendingMachine16 As DroneVendingMachine
End Class
