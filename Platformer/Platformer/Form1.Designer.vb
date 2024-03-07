<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2dPlatformer
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
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Game_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.Spiky_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Mover1 = New Platformer.Mover()
        Me.Mover2 = New Platformer.Mover()
        Me.Mover3 = New Platformer.Mover()
        Me.Mover4 = New Platformer.Mover()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 30
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 30
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 30
        '
        'tmrGameLogic
        '
        '
        'tmrGravity
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(368, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(286, 22)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Visible = False
        '
        'Game_Timer
        '
        Me.Game_Timer.Interval = 10000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(66, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Points:"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox19.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox19.Location = New System.Drawing.Point(382, 450)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox19.TabIndex = 31
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "L"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox18.Image = Global.Platformer.My.Resources.Resources.download__2_
        Me.PictureBox18.Location = New System.Drawing.Point(837, 123)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(39, 48)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 24
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "enemy"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox17.Image = Global.Platformer.My.Resources.Resources.download__2_
        Me.PictureBox17.Location = New System.Drawing.Point(328, 298)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(39, 48)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 23
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "enemy"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox16.Image = Global.Platformer.My.Resources.Resources.download__2_
        Me.PictureBox16.Location = New System.Drawing.Point(756, 174)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(39, 48)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 22
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "enemy"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox15.Image = Global.Platformer.My.Resources.Resources.download__2_
        Me.PictureBox15.Location = New System.Drawing.Point(320, 430)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(39, 48)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 21
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "enemy"
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox14.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox14.Location = New System.Drawing.Point(316, 319)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 20
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "win"
        Me.PictureBox14.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox13.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox13.Location = New System.Drawing.Point(780, 291)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 19
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "win"
        Me.PictureBox13.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox12.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox12.Location = New System.Drawing.Point(717, 445)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "win"
        Me.PictureBox12.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox11.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox11.Location = New System.Drawing.Point(598, 445)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 17
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "win"
        Me.PictureBox11.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox10.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox10.Location = New System.Drawing.Point(243, 445)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "win"
        Me.PictureBox10.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox9.Image = Global.Platformer.My.Resources.Resources.Red_Apple
        Me.PictureBox9.Location = New System.Drawing.Point(126, 445)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "win"
        Me.PictureBox9.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox8.Image = Global.Platformer.My.Resources.Resources._2005nickel_obverse
        Me.PictureBox8.Location = New System.Drawing.Point(230, 114)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "win_coin"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Image = Global.Platformer.My.Resources.Resources._2005nickel_obverse
        Me.PictureBox5.Location = New System.Drawing.Point(506, 242)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "win_coin"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox7.Image = Global.Platformer.My.Resources.Resources._2005nickel_obverse
        Me.PictureBox7.Location = New System.Drawing.Point(833, 149)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "win_coin"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Location = New System.Drawing.Point(739, 184)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(232, 18)
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(448, 277)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(141, 17)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(739, 172)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 18)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(448, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 17)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        Me.PictureBox1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(184, 149)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(141, 17)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer.Image = Global.Platformer.My.Resources.Resources.istockphoto_1332100919_612x612
        Me.picPlayer.Location = New System.Drawing.Point(12, 454)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(32, 29)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picGround.Location = New System.Drawing.Point(-3, 480)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1059, 63)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.Color.Cyan
        Me.picAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picAir.Location = New System.Drawing.Point(-3, -204)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(1078, 652)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox20.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox20.Location = New System.Drawing.Point(547, 247)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox20.TabIndex = 32
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Tag = "L"
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox21.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox21.Location = New System.Drawing.Point(448, 247)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox21.TabIndex = 33
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Tag = "L"
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox22.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox22.Location = New System.Drawing.Point(279, 123)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox22.TabIndex = 34
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Tag = "L"
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox23.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox23.Location = New System.Drawing.Point(902, 157)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox23.TabIndex = 35
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Tag = "L"
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox24.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox24.Location = New System.Drawing.Point(777, 154)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox24.TabIndex = 36
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Tag = "L"
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox25.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox25.Location = New System.Drawing.Point(657, 450)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox25.TabIndex = 37
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Tag = "L"
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox26.Image = Global.Platformer.My.Resources.Resources.spiky
        Me.PictureBox26.Location = New System.Drawing.Point(879, 450)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox26.TabIndex = 38
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Tag = "L"
        '
        'Spiky_Timer
        '
        Me.Spiky_Timer.Enabled = True
        Me.Spiky_Timer.Interval = 500
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.Interval = 100
        Me.Mover1.Location = New System.Drawing.Point(230, 400)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(513, 23)
        Me.Mover1.Speed = 10
        Me.Mover1.Sprite = Me.PictureBox15
        Me.Mover1.TabIndex = 25
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.Interval = 100
        Me.Mover2.Location = New System.Drawing.Point(156, 114)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(778, 52)
        Me.Mover2.Speed = 10
        Me.Mover2.Sprite = Me.PictureBox16
        Me.Mover2.TabIndex = 26
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.Interval = 100
        Me.Mover3.Location = New System.Drawing.Point(368, 38)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(46, 386)
        Me.Mover3.Speed = 10
        Me.Mover3.Sprite = Me.PictureBox17
        Me.Mover3.TabIndex = 27
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.Interval = 100
        Me.Mover4.Location = New System.Drawing.Point(817, 123)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(10, 301)
        Me.Mover4.Speed = 10
        Me.Mover4.Sprite = Me.PictureBox18
        Me.Mover4.TabIndex = 28
        '
        'frm2dPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1037, 542)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Name = "frm2dPlatformer"
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents TmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Game_Timer As Timer
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents Spiky_Timer As Timer
End Class
