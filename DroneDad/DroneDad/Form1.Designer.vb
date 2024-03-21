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
        components = New ComponentModel.Container()
        ShoppingCart = New Label()
        Timer1 = New Timer(components)
        DroneVendingMachine1 = New DroneVendingMachine()
        DroneVendingMachine2 = New DroneVendingMachine()
        DroneVendingMachine3 = New DroneVendingMachine()
        DroneVendingMachine4 = New DroneVendingMachine()
        DroneVendingMachine5 = New DroneVendingMachine()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        DroneVendingMachine6 = New DroneVendingMachine()
        DroneVendingMachine7 = New DroneVendingMachine()
        DroneVendingMachine8 = New DroneVendingMachine()
        DroneVendingMachine9 = New DroneVendingMachine()
        DroneVendingMachine10 = New DroneVendingMachine()
        Button4 = New Button()
        DroneVendingMachine11 = New DroneVendingMachine()
        DroneVendingMachine12 = New DroneVendingMachine()
        DroneVendingMachine13 = New DroneVendingMachine()
        DroneVendingMachine14 = New DroneVendingMachine()
        DroneVendingMachine15 = New DroneVendingMachine()
        SuspendLayout()
        ' 
        ' ShoppingCart
        ' 
        ShoppingCart.AutoSize = True
        ShoppingCart.Location = New Point(610, 268)
        ShoppingCart.Name = "ShoppingCart"
        ShoppingCart.Size = New Size(41, 15)
        ShoppingCart.TabIndex = 1
        ShoppingCart.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5
        ' 
        ' DroneVendingMachine1
        ' 
        DroneVendingMachine1.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine1.count = 0
        DroneVendingMachine1.label = "Carbon Fiber"
        DroneVendingMachine1.Location = New Point(10, 9)
        DroneVendingMachine1.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine1.Name = "DroneVendingMachine1"
        DroneVendingMachine1.price = New Decimal(New Integer() {5, 0, 0, 0})
        DroneVendingMachine1.Size = New Size(144, 91)
        DroneVendingMachine1.TabIndex = 2
        ' 
        ' DroneVendingMachine2
        ' 
        DroneVendingMachine2.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine2.count = 0
        DroneVendingMachine2.label = "Carbon Fiber"
        DroneVendingMachine2.Location = New Point(159, 9)
        DroneVendingMachine2.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine2.Name = "DroneVendingMachine2"
        DroneVendingMachine2.price = New Decimal(New Integer() {15, 0, 0, 0})
        DroneVendingMachine2.Size = New Size(144, 91)
        DroneVendingMachine2.TabIndex = 3
        ' 
        ' DroneVendingMachine3
        ' 
        DroneVendingMachine3.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine3.count = 0
        DroneVendingMachine3.label = "Carbon Fiber"
        DroneVendingMachine3.Location = New Point(308, 9)
        DroneVendingMachine3.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine3.Name = "DroneVendingMachine3"
        DroneVendingMachine3.price = New Decimal(New Integer() {7, 0, 0, 0})
        DroneVendingMachine3.Size = New Size(144, 91)
        DroneVendingMachine3.TabIndex = 4
        ' 
        ' DroneVendingMachine4
        ' 
        DroneVendingMachine4.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine4.count = 0
        DroneVendingMachine4.label = "Carbon Fiber"
        DroneVendingMachine4.Location = New Point(457, 9)
        DroneVendingMachine4.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine4.Name = "DroneVendingMachine4"
        DroneVendingMachine4.price = New Decimal(New Integer() {2, 0, 0, 0})
        DroneVendingMachine4.Size = New Size(144, 91)
        DroneVendingMachine4.TabIndex = 5
        ' 
        ' DroneVendingMachine5
        ' 
        DroneVendingMachine5.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine5.count = 0
        DroneVendingMachine5.label = "Carbon Fiber"
        DroneVendingMachine5.Location = New Point(10, 104)
        DroneVendingMachine5.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine5.Name = "DroneVendingMachine5"
        DroneVendingMachine5.price = New Decimal(New Integer() {10, 0, 0, 0})
        DroneVendingMachine5.Size = New Size(144, 91)
        DroneVendingMachine5.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(308, 262)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 7
        Button1.Text = "Check Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(196, 116)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 120)
        TextBox1.TabIndex = 8
        TextBox1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(10, 259)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 25)
        Button2.TabIndex = 9
        Button2.Text = "To Motors"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(101, 259)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 25)
        Button3.TabIndex = 10
        Button3.Text = "To Propellors"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DroneVendingMachine6
        ' 
        DroneVendingMachine6.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine6.count = 0
        DroneVendingMachine6.label = "Motor 5"
        DroneVendingMachine6.Location = New Point(10, 104)
        DroneVendingMachine6.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine6.Name = "DroneVendingMachine6"
        DroneVendingMachine6.price = New Decimal(New Integer() {10, 0, 0, 0})
        DroneVendingMachine6.Size = New Size(144, 91)
        DroneVendingMachine6.TabIndex = 15
        ' 
        ' DroneVendingMachine7
        ' 
        DroneVendingMachine7.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine7.count = 0
        DroneVendingMachine7.label = "Motor 4"
        DroneVendingMachine7.Location = New Point(457, 9)
        DroneVendingMachine7.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine7.Name = "DroneVendingMachine7"
        DroneVendingMachine7.price = New Decimal(New Integer() {2, 0, 0, 0})
        DroneVendingMachine7.Size = New Size(144, 91)
        DroneVendingMachine7.TabIndex = 14
        ' 
        ' DroneVendingMachine8
        ' 
        DroneVendingMachine8.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine8.count = 0
        DroneVendingMachine8.label = "Motor 3"
        DroneVendingMachine8.Location = New Point(308, 9)
        DroneVendingMachine8.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine8.Name = "DroneVendingMachine8"
        DroneVendingMachine8.price = New Decimal(New Integer() {7, 0, 0, 0})
        DroneVendingMachine8.Size = New Size(144, 91)
        DroneVendingMachine8.TabIndex = 13
        ' 
        ' DroneVendingMachine9
        ' 
        DroneVendingMachine9.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine9.count = 0
        DroneVendingMachine9.label = "Motor 2"
        DroneVendingMachine9.Location = New Point(159, 9)
        DroneVendingMachine9.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine9.Name = "DroneVendingMachine9"
        DroneVendingMachine9.price = New Decimal(New Integer() {15, 0, 0, 0})
        DroneVendingMachine9.Size = New Size(144, 91)
        DroneVendingMachine9.TabIndex = 12
        ' 
        ' DroneVendingMachine10
        ' 
        DroneVendingMachine10.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine10.count = 0
        DroneVendingMachine10.label = "Motor 1"
        DroneVendingMachine10.Location = New Point(10, 9)
        DroneVendingMachine10.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine10.Name = "DroneVendingMachine10"
        DroneVendingMachine10.price = New Decimal(New Integer() {5, 0, 0, 0})
        DroneVendingMachine10.Size = New Size(144, 91)
        DroneVendingMachine10.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(35, 288)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 22)
        Button4.TabIndex = 16
        Button4.Text = "To Drone Body's"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DroneVendingMachine11
        ' 
        DroneVendingMachine11.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine11.count = 0
        DroneVendingMachine11.label = "Propellor 1"
        DroneVendingMachine11.Location = New Point(9, 11)
        DroneVendingMachine11.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine11.Name = "DroneVendingMachine11"
        DroneVendingMachine11.price = New Decimal(New Integer() {10, 0, 0, 0})
        DroneVendingMachine11.Size = New Size(144, 91)
        DroneVendingMachine11.TabIndex = 26
        DroneVendingMachine11.Visible = False
        ' 
        ' DroneVendingMachine12
        ' 
        DroneVendingMachine12.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine12.count = 0
        DroneVendingMachine12.label = "Propellor 2"
        DroneVendingMachine12.Location = New Point(160, 9)
        DroneVendingMachine12.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine12.Name = "DroneVendingMachine12"
        DroneVendingMachine12.price = New Decimal(New Integer() {2, 0, 0, 0})
        DroneVendingMachine12.Size = New Size(144, 91)
        DroneVendingMachine12.TabIndex = 25
        DroneVendingMachine12.Visible = False
        ' 
        ' DroneVendingMachine13
        ' 
        DroneVendingMachine13.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine13.count = 0
        DroneVendingMachine13.label = "Propellor 3"
        DroneVendingMachine13.Location = New Point(307, 11)
        DroneVendingMachine13.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine13.Name = "DroneVendingMachine13"
        DroneVendingMachine13.price = New Decimal(New Integer() {7, 0, 0, 0})
        DroneVendingMachine13.Size = New Size(144, 91)
        DroneVendingMachine13.TabIndex = 24
        DroneVendingMachine13.Visible = False
        ' 
        ' DroneVendingMachine14
        ' 
        DroneVendingMachine14.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine14.count = 0
        DroneVendingMachine14.label = "Propellor 4"
        DroneVendingMachine14.Location = New Point(458, 11)
        DroneVendingMachine14.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine14.Name = "DroneVendingMachine14"
        DroneVendingMachine14.price = New Decimal(New Integer() {15, 0, 0, 0})
        DroneVendingMachine14.Size = New Size(144, 91)
        DroneVendingMachine14.TabIndex = 23
        DroneVendingMachine14.Visible = False
        ' 
        ' DroneVendingMachine15
        ' 
        DroneVendingMachine15.BorderStyle = BorderStyle.Fixed3D
        DroneVendingMachine15.count = 0
        DroneVendingMachine15.label = "Propellor 5"
        DroneVendingMachine15.Location = New Point(9, 106)
        DroneVendingMachine15.Margin = New Padding(3, 2, 3, 2)
        DroneVendingMachine15.Name = "DroneVendingMachine15"
        DroneVendingMachine15.price = New Decimal(New Integer() {5, 0, 0, 0})
        DroneVendingMachine15.Size = New Size(144, 91)
        DroneVendingMachine15.TabIndex = 22
        DroneVendingMachine15.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(DroneVendingMachine11)
        Controls.Add(DroneVendingMachine12)
        Controls.Add(DroneVendingMachine13)
        Controls.Add(DroneVendingMachine14)
        Controls.Add(DroneVendingMachine15)
        Controls.Add(Button4)
        Controls.Add(DroneVendingMachine6)
        Controls.Add(DroneVendingMachine7)
        Controls.Add(DroneVendingMachine8)
        Controls.Add(DroneVendingMachine9)
        Controls.Add(DroneVendingMachine10)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(DroneVendingMachine5)
        Controls.Add(DroneVendingMachine4)
        Controls.Add(DroneVendingMachine3)
        Controls.Add(DroneVendingMachine2)
        Controls.Add(DroneVendingMachine1)
        Controls.Add(ShoppingCart)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
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
End Class
