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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ShoppingCart = New System.Windows.Forms.Label()
        Me.UserControl1 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl2 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl3 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl4 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl5 = New Drone_Dad_Take_2.UserControl1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserControl6 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl7 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl8 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl9 = New Drone_Dad_Take_2.UserControl1()
        Me.UserControl10 = New Drone_Dad_Take_2.UserControl1()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "To Motors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(40, 401)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "To Drone Body's"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'ShoppingCart
        '
        Me.ShoppingCart.AutoSize = True
        Me.ShoppingCart.Location = New System.Drawing.Point(673, 404)
        Me.ShoppingCart.Name = "ShoppingCart"
        Me.ShoppingCart.Size = New System.Drawing.Size(48, 16)
        Me.ShoppingCart.TabIndex = 4
        Me.ShoppingCart.Text = "Label1"
        '
        'UserControl1
        '
        Me.UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl1.count = 0
        Me.UserControl1.label = "Carbon Fiber"
        Me.UserControl1.Location = New System.Drawing.Point(13, 13)
        Me.UserControl1.Name = "UserControl1"
        Me.UserControl1.price = New Decimal(New Integer() {5, 0, 0, 0})
        Me.UserControl1.Size = New System.Drawing.Size(132, 102)
        Me.UserControl1.TabIndex = 5
        '
        'UserControl2
        '
        Me.UserControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl2.count = 0
        Me.UserControl2.label = "Carbon Fiber"
        Me.UserControl2.Location = New System.Drawing.Point(151, 13)
        Me.UserControl2.Name = "UserControl2"
        Me.UserControl2.price = New Decimal(New Integer() {15, 0, 0, 0})
        Me.UserControl2.Size = New System.Drawing.Size(132, 102)
        Me.UserControl2.TabIndex = 6
        '
        'UserControl3
        '
        Me.UserControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl3.count = 0
        Me.UserControl3.label = "Carbon Fiber"
        Me.UserControl3.Location = New System.Drawing.Point(289, 12)
        Me.UserControl3.Name = "UserControl3"
        Me.UserControl3.price = New Decimal(New Integer() {10, 0, 0, 0})
        Me.UserControl3.Size = New System.Drawing.Size(132, 102)
        Me.UserControl3.TabIndex = 7
        '
        'UserControl4
        '
        Me.UserControl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl4.count = 0
        Me.UserControl4.label = "Carbon Fiber"
        Me.UserControl4.Location = New System.Drawing.Point(427, 13)
        Me.UserControl4.Name = "UserControl4"
        Me.UserControl4.price = New Decimal(New Integer() {7, 0, 0, 0})
        Me.UserControl4.Size = New System.Drawing.Size(132, 102)
        Me.UserControl4.TabIndex = 8
        '
        'UserControl5
        '
        Me.UserControl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl5.count = 0
        Me.UserControl5.label = "Carbon Fiber"
        Me.UserControl5.Location = New System.Drawing.Point(565, 13)
        Me.UserControl5.Name = "UserControl5"
        Me.UserControl5.price = New Decimal(New Integer() {3, 0, 0, 0})
        Me.UserControl5.Size = New System.Drawing.Size(132, 102)
        Me.UserControl5.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 120)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(483, 233)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Visible = False
        '
        'UserControl6
        '
        Me.UserControl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl6.count = 0
        Me.UserControl6.label = Nothing
        Me.UserControl6.Location = New System.Drawing.Point(12, 121)
        Me.UserControl6.Name = "UserControl6"
        Me.UserControl6.price = New Decimal(New Integer() {3, 0, 0, 0})
        Me.UserControl6.Size = New System.Drawing.Size(132, 102)
        Me.UserControl6.TabIndex = 15
        '
        'UserControl7
        '
        Me.UserControl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl7.count = 0
        Me.UserControl7.label = Nothing
        Me.UserControl7.Location = New System.Drawing.Point(151, 121)
        Me.UserControl7.Name = "UserControl7"
        Me.UserControl7.price = New Decimal(New Integer() {7, 0, 0, 0})
        Me.UserControl7.Size = New System.Drawing.Size(132, 102)
        Me.UserControl7.TabIndex = 14
        '
        'UserControl8
        '
        Me.UserControl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl8.count = 0
        Me.UserControl8.label = Nothing
        Me.UserControl8.Location = New System.Drawing.Point(289, 121)
        Me.UserControl8.Name = "UserControl8"
        Me.UserControl8.price = New Decimal(New Integer() {10, 0, 0, 0})
        Me.UserControl8.Size = New System.Drawing.Size(132, 102)
        Me.UserControl8.TabIndex = 13
        '
        'UserControl9
        '
        Me.UserControl9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl9.count = 0
        Me.UserControl9.label = Nothing
        Me.UserControl9.Location = New System.Drawing.Point(427, 121)
        Me.UserControl9.Name = "UserControl9"
        Me.UserControl9.price = New Decimal(New Integer() {15, 0, 0, 0})
        Me.UserControl9.Size = New System.Drawing.Size(132, 102)
        Me.UserControl9.TabIndex = 12
        '
        'UserControl10
        '
        Me.UserControl10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserControl10.count = 0
        Me.UserControl10.label = Nothing
        Me.UserControl10.Location = New System.Drawing.Point(565, 121)
        Me.UserControl10.Name = "UserControl10"
        Me.UserControl10.price = New Decimal(New Integer() {5, 0, 0, 0})
        Me.UserControl10.Size = New System.Drawing.Size(132, 102)
        Me.UserControl10.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserControl6)
        Me.Controls.Add(Me.UserControl7)
        Me.Controls.Add(Me.UserControl8)
        Me.Controls.Add(Me.UserControl9)
        Me.Controls.Add(Me.UserControl10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UserControl5)
        Me.Controls.Add(Me.UserControl4)
        Me.Controls.Add(Me.UserControl3)
        Me.Controls.Add(Me.UserControl2)
        Me.Controls.Add(Me.UserControl1)
        Me.Controls.Add(Me.ShoppingCart)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShoppingCart As Label
    Friend WithEvents UserControl1 As UserControl1
    Friend WithEvents UserControl2 As UserControl1
    Friend WithEvents UserControl3 As UserControl1
    Friend WithEvents UserControl4 As UserControl1
    Friend WithEvents UserControl5 As UserControl1
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserControl6 As UserControl1
    Friend WithEvents UserControl7 As UserControl1
    Friend WithEvents UserControl8 As UserControl1
    Friend WithEvents UserControl9 As UserControl1
    Friend WithEvents UserControl10 As UserControl1
End Class
