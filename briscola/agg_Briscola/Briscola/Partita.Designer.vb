<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partita
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
        Me.Briscola = New System.Windows.Forms.PictureBox()
        Me.PBmazzo = New System.Windows.Forms.PictureBox()
        Me.C_vinte = New System.Windows.Forms.PictureBox()
        Me.C_vintecpu = New System.Windows.Forms.PictureBox()
        Me.Lb = New System.Windows.Forms.Label()
        Me.Maz = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbd = New System.Windows.Forms.Label()
        Me.Ex1 = New System.Windows.Forms.PictureBox()
        Me.Ex2 = New System.Windows.Forms.PictureBox()
        Me.Ex3 = New System.Windows.Forms.PictureBox()
        Me.Lb_time = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OpzioniToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.InformazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EsciToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RematchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opz1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opz2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.Briscola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBmazzo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_vinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_vintecpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ex1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ex2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ex3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Briscola
        '
        Me.Briscola.Location = New System.Drawing.Point(762, 178)
        Me.Briscola.Name = "Briscola"
        Me.Briscola.Size = New System.Drawing.Size(117, 181)
        Me.Briscola.TabIndex = 7
        Me.Briscola.TabStop = False
        '
        'PBmazzo
        '
        Me.PBmazzo.BackgroundImage = Global.Briscola.My.Resources.Resources.mazzo
        Me.PBmazzo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBmazzo.Location = New System.Drawing.Point(737, 264)
        Me.PBmazzo.Name = "PBmazzo"
        Me.PBmazzo.Size = New System.Drawing.Size(159, 118)
        Me.PBmazzo.TabIndex = 8
        Me.PBmazzo.TabStop = False
        '
        'C_vinte
        '
        Me.C_vinte.BackgroundImage = Global.Briscola.My.Resources.Resources.cvinte
        Me.C_vinte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C_vinte.Location = New System.Drawing.Point(-14, 437)
        Me.C_vinte.Name = "C_vinte"
        Me.C_vinte.Size = New System.Drawing.Size(143, 136)
        Me.C_vinte.TabIndex = 9
        Me.C_vinte.TabStop = False
        '
        'C_vintecpu
        '
        Me.C_vintecpu.BackgroundImage = Global.Briscola.My.Resources.Resources.cvinte
        Me.C_vintecpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C_vintecpu.Location = New System.Drawing.Point(-14, 14)
        Me.C_vintecpu.Name = "C_vintecpu"
        Me.C_vintecpu.Size = New System.Drawing.Size(143, 136)
        Me.C_vintecpu.TabIndex = 10
        Me.C_vintecpu.TabStop = False
        '
        'Lb
        '
        Me.Lb.AutoSize = True
        Me.Lb.BackColor = System.Drawing.Color.Yellow
        Me.Lb.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb.Location = New System.Drawing.Point(40, 302)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(307, 57)
        Me.Lb.TabIndex = 11
        Me.Lb.Text = "Tocca il mazzo, per mischiare le carte ed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "avviare partita veloce o scegli un'al" & _
            "tra opzione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nel menù" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Maz
        '
        Me.Maz.BackColor = System.Drawing.Color.Transparent
        Me.Maz.BackgroundImage = Global.Briscola.My.Resources.Resources.mazzo2
        Me.Maz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Maz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maz.Location = New System.Drawing.Point(496, 178)
        Me.Maz.Name = "Maz"
        Me.Maz.Size = New System.Drawing.Size(149, 239)
        Me.Maz.TabIndex = 12
        Me.Maz.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(31, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cpu: 0 p."
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(31, 594)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "G1: 0 p."
        Me.Label2.Visible = False
        '
        'Lbd
        '
        Me.Lbd.AutoSize = True
        Me.Lbd.BackColor = System.Drawing.Color.Black
        Me.Lbd.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbd.ForeColor = System.Drawing.Color.Chartreuse
        Me.Lbd.Location = New System.Drawing.Point(61, 344)
        Me.Lbd.Name = "Lbd"
        Me.Lbd.Size = New System.Drawing.Size(0, 17)
        Me.Lbd.TabIndex = 20
        '
        'Ex1
        '
        Me.Ex1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ex1.Location = New System.Drawing.Point(737, 14)
        Me.Ex1.Name = "Ex1"
        Me.Ex1.Size = New System.Drawing.Size(95, 180)
        Me.Ex1.TabIndex = 23
        Me.Ex1.TabStop = False
        Me.Ex1.Visible = False
        '
        'Ex2
        '
        Me.Ex2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ex2.Location = New System.Drawing.Point(860, 14)
        Me.Ex2.Name = "Ex2"
        Me.Ex2.Size = New System.Drawing.Size(95, 180)
        Me.Ex2.TabIndex = 24
        Me.Ex2.TabStop = False
        Me.Ex2.Visible = False
        '
        'Ex3
        '
        Me.Ex3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ex3.Location = New System.Drawing.Point(982, 14)
        Me.Ex3.Name = "Ex3"
        Me.Ex3.Size = New System.Drawing.Size(95, 180)
        Me.Ex3.TabIndex = 25
        Me.Ex3.TabStop = False
        Me.Ex3.Visible = False
        '
        'Lb_time
        '
        Me.Lb_time.AutoSize = True
        Me.Lb_time.Location = New System.Drawing.Point(971, 233)
        Me.Lb_time.Name = "Lb_time"
        Me.Lb_time.Size = New System.Drawing.Size(0, 15)
        Me.Lb_time.TabIndex = 26
        Me.Lb_time.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(960, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tempo di gioco"
        Me.Label4.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1056, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpzioniToolStripMenuItem1, Me.InformazioniToolStripMenuItem, Me.ToolStripSeparator2, Me.EsciToolStripMenuItem1})
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "File"
        '
        'OpzioniToolStripMenuItem1
        '
        Me.OpzioniToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.OpzioniToolStripMenuItem1.Name = "OpzioniToolStripMenuItem1"
        Me.OpzioniToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.OpzioniToolStripMenuItem1.Text = "Opzioni"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'InformazioniToolStripMenuItem
        '
        Me.InformazioniToolStripMenuItem.Name = "InformazioniToolStripMenuItem"
        Me.InformazioniToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.InformazioniToolStripMenuItem.Text = "Informazioni "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(154, 6)
        '
        'EsciToolStripMenuItem1
        '
        Me.EsciToolStripMenuItem1.Name = "EsciToolStripMenuItem1"
        Me.EsciToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.EsciToolStripMenuItem1.Text = "Esci"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RematchToolStripMenuItem, Me.OpzioniToolStripMenuItem, Me.ToolStripSeparator1, Me.EsciToolStripMenuItem})
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel1.Text = "Partita"
        '
        'RematchToolStripMenuItem
        '
        Me.RematchToolStripMenuItem.Name = "RematchToolStripMenuItem"
        Me.RematchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RematchToolStripMenuItem.Text = "Partita veloce"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OpzioniToolStripMenuItem.Text = "Match"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Opz1, Me.Opz2})
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EsciToolStripMenuItem.Text = "Assisti a match"
        '
        'Opz1
        '
        Me.Opz1.Name = "Opz1"
        Me.Opz1.Size = New System.Drawing.Size(74, 22)
        '
        'Opz2
        '
        Me.Opz2.Name = "Opz2"
        Me.Opz2.Size = New System.Drawing.Size(74, 22)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel2.Text = " help?"
        '
        'Partita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Briscola.My.Resources.Resources.DEFINITIVO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 750)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lb_time)
        Me.Controls.Add(Me.Ex3)
        Me.Controls.Add(Me.Ex2)
        Me.Controls.Add(Me.Ex1)
        Me.Controls.Add(Me.Lbd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Maz)
        Me.Controls.Add(Me.Lb)
        Me.Controls.Add(Me.C_vintecpu)
        Me.Controls.Add(Me.C_vinte)
        Me.Controls.Add(Me.PBmazzo)
        Me.Controls.Add(Me.Briscola)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Partita"
        Me.Text = " Briscola"
        CType(Me.Briscola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBmazzo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_vinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_vintecpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ex1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ex2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ex3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Briscola As System.Windows.Forms.PictureBox
    Friend WithEvents PBmazzo As System.Windows.Forms.PictureBox
    Friend WithEvents C_vinte As System.Windows.Forms.PictureBox
    Friend WithEvents C_vintecpu As System.Windows.Forms.PictureBox
    Friend WithEvents Lb As System.Windows.Forms.Label
    Friend WithEvents Maz As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbd As System.Windows.Forms.Label
    Friend WithEvents Ex1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ex2 As System.Windows.Forms.PictureBox
    Friend WithEvents Ex3 As System.Windows.Forms.PictureBox
    Friend WithEvents Lb_time As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents RematchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpzioniToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EsciToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Opz1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Opz2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
