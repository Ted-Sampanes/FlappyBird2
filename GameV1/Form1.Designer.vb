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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tube3Wall = New System.Windows.Forms.PictureBox()
        Me.Tube2Wall = New System.Windows.Forms.PictureBox()
        Me.mario = New System.Windows.Forms.PictureBox()
        Me.PictureBox2wall = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox5wall = New System.Windows.Forms.PictureBox()
        Me.Tube6Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox3Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Tube3Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tube2Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tube6Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Tube3Wall
        '
        Me.Tube3Wall.BackColor = System.Drawing.Color.Transparent
        Me.Tube3Wall.Image = CType(resources.GetObject("Tube3Wall.Image"), System.Drawing.Image)
        Me.Tube3Wall.Location = New System.Drawing.Point(782, 523)
        Me.Tube3Wall.Name = "Tube3Wall"
        Me.Tube3Wall.Size = New System.Drawing.Size(108, 126)
        Me.Tube3Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tube3Wall.TabIndex = 2
        Me.Tube3Wall.TabStop = False
        '
        'Tube2Wall
        '
        Me.Tube2Wall.BackColor = System.Drawing.Color.Transparent
        Me.Tube2Wall.Image = CType(resources.GetObject("Tube2Wall.Image"), System.Drawing.Image)
        Me.Tube2Wall.Location = New System.Drawing.Point(1039, 479)
        Me.Tube2Wall.Name = "Tube2Wall"
        Me.Tube2Wall.Size = New System.Drawing.Size(120, 170)
        Me.Tube2Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tube2Wall.TabIndex = 2
        Me.Tube2Wall.TabStop = False
        '
        'mario
        '
        Me.mario.BackColor = System.Drawing.Color.Transparent
        Me.mario.Enabled = False
        Me.mario.Image = Global.GameV1.My.Resources.Resources.unnamed
        Me.mario.Location = New System.Drawing.Point(1071, 253)
        Me.mario.Name = "mario"
        Me.mario.Size = New System.Drawing.Size(125, 132)
        Me.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mario.TabIndex = 3
        Me.mario.TabStop = False
        Me.mario.Visible = False
        '
        'PictureBox2wall
        '
        Me.PictureBox2wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2wall.Image = CType(resources.GetObject("PictureBox2wall.Image"), System.Drawing.Image)
        Me.PictureBox2wall.Location = New System.Drawing.Point(782, -14)
        Me.PictureBox2wall.Name = "PictureBox2wall"
        Me.PictureBox2wall.Size = New System.Drawing.Size(108, 216)
        Me.PictureBox2wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2wall.TabIndex = 2
        Me.PictureBox2wall.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Enabled = False
        Me.Bullet.Image = Global.GameV1.My.Resources.Resources.download1
        Me.Bullet.Location = New System.Drawing.Point(15, 43)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(48, 47)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 4
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.Transparent
        Me.Wall.Image = CType(resources.GetObject("Wall.Image"), System.Drawing.Image)
        Me.Wall.Location = New System.Drawing.Point(169, 503)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(108, 146)
        Me.Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall.TabIndex = 2
        Me.Wall.TabStop = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'PictureBox4wall
        '
        Me.PictureBox4wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4wall.Image = CType(resources.GetObject("PictureBox4wall.Image"), System.Drawing.Image)
        Me.PictureBox4wall.Location = New System.Drawing.Point(1039, -1)
        Me.PictureBox4wall.Name = "PictureBox4wall"
        Me.PictureBox4wall.Size = New System.Drawing.Size(120, 166)
        Me.PictureBox4wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4wall.TabIndex = 2
        Me.PictureBox4wall.TabStop = False
        '
        'PictureBox5wall
        '
        Me.PictureBox5wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5wall.Image = CType(resources.GetObject("PictureBox5wall.Image"), System.Drawing.Image)
        Me.PictureBox5wall.Location = New System.Drawing.Point(169, -1)
        Me.PictureBox5wall.Name = "PictureBox5wall"
        Me.PictureBox5wall.Size = New System.Drawing.Size(108, 166)
        Me.PictureBox5wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5wall.TabIndex = 2
        Me.PictureBox5wall.TabStop = False
        '
        'Tube6Wall
        '
        Me.Tube6Wall.BackColor = System.Drawing.Color.Transparent
        Me.Tube6Wall.Image = CType(resources.GetObject("Tube6Wall.Image"), System.Drawing.Image)
        Me.Tube6Wall.Location = New System.Drawing.Point(470, 457)
        Me.Tube6Wall.Name = "Tube6Wall"
        Me.Tube6Wall.Size = New System.Drawing.Size(120, 192)
        Me.Tube6Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tube6Wall.TabIndex = 2
        Me.Tube6Wall.TabStop = False
        '
        'PictureBox3Wall
        '
        Me.PictureBox3Wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3Wall.Image = CType(resources.GetObject("PictureBox3Wall.Image"), System.Drawing.Image)
        Me.PictureBox3Wall.Location = New System.Drawing.Point(470, -1)
        Me.PictureBox3Wall.Name = "PictureBox3Wall"
        Me.PictureBox3Wall.Size = New System.Drawing.Size(120, 128)
        Me.PictureBox3Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3Wall.TabIndex = 2
        Me.PictureBox3Wall.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(12, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(10, 13)
        Me.ScoreLabel.TabIndex = 6
        Me.ScoreLabel.Text = " "
        '
        'Timer4
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources.FlappyBackdrop1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1193, 751)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.mario)
        Me.Controls.Add(Me.Tube6Wall)
        Me.Controls.Add(Me.Tube2Wall)
        Me.Controls.Add(Me.PictureBox5wall)
        Me.Controls.Add(Me.PictureBox3Wall)
        Me.Controls.Add(Me.PictureBox4wall)
        Me.Controls.Add(Me.PictureBox2wall)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.Tube3Wall)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Flappy Bird 2"
        CType(Me.Tube3Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tube2Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tube6Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Tube3Wall As PictureBox
    Friend WithEvents Tube2Wall As PictureBox
    Friend WithEvents mario As PictureBox
    Friend WithEvents PictureBox2wall As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Wall As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox4wall As PictureBox
    Friend WithEvents PictureBox5wall As PictureBox
    Friend WithEvents Tube6Wall As PictureBox
    Friend WithEvents PictureBox3Wall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer4 As Timer
End Class
