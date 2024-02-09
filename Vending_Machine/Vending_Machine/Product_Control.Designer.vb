<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ID_Label = New System.Windows.Forms.Label()
        Me.Price_Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_Label
        '
        Me.ID_Label.AutoSize = True
        Me.ID_Label.Location = New System.Drawing.Point(73, 194)
        Me.ID_Label.Name = "ID_Label"
        Me.ID_Label.Size = New System.Drawing.Size(48, 16)
        Me.ID_Label.TabIndex = 0
        Me.ID_Label.Text = "Label1"
        '
        'Price_Label
        '
        Me.Price_Label.AutoSize = True
        Me.Price_Label.Location = New System.Drawing.Point(164, 194)
        Me.Price_Label.Name = "Price_Label"
        Me.Price_Label.Size = New System.Drawing.Size(48, 16)
        Me.Price_Label.TabIndex = 1
        Me.Price_Label.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Product_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Price_Label)
        Me.Controls.Add(Me.ID_Label)
        Me.Name = "Product_Control"
        Me.Size = New System.Drawing.Size(286, 216)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID_Label As Label
    Friend WithEvents Price_Label As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
