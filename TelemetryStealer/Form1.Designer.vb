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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PiLa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaLa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FuLa = New System.Windows.Forms.Label()
        Me.Label333 = New System.Windows.Forms.Label()
        Me.PeLa = New System.Windows.Forms.Label()
        Me.ApLa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VelLa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AltLa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.YaLa = New System.Windows.Forms.Label()
        Me.RollLab = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 372)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RollLab)
        Me.TabPage1.Controls.Add(Me.YaLa)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.PiLa)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.MaLa)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.FuLa)
        Me.TabPage1.Controls.Add(Me.Label333)
        Me.TabPage1.Controls.Add(Me.PeLa)
        Me.TabPage1.Controls.Add(Me.ApLa)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.VelLa)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.AltLa)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(25, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(606, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Launch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(207, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 200)
        Me.Panel1.TabIndex = 13
        '
        'PiLa
        '
        Me.PiLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiLa.Location = New System.Drawing.Point(222, 336)
        Me.PiLa.Name = "PiLa"
        Me.PiLa.Size = New System.Drawing.Size(175, 25)
        Me.PiLa.TabIndex = 12
        Me.PiLa.Text = "15º"
        Me.PiLa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(277, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pitch"
        '
        'MaLa
        '
        Me.MaLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaLa.Location = New System.Drawing.Point(3, 283)
        Me.MaLa.Name = "MaLa"
        Me.MaLa.Size = New System.Drawing.Size(134, 25)
        Me.MaLa.TabIndex = 10
        Me.MaLa.Text = "0g"
        Me.MaLa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Mass"
        '
        'FuLa
        '
        Me.FuLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuLa.Location = New System.Drawing.Point(513, 277)
        Me.FuLa.Name = "FuLa"
        Me.FuLa.Size = New System.Drawing.Size(90, 25)
        Me.FuLa.TabIndex = 8
        Me.FuLa.Text = "0.00%"
        Me.FuLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label333
        '
        Me.Label333.AutoSize = True
        Me.Label333.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label333.Location = New System.Drawing.Point(554, 252)
        Me.Label333.Name = "Label333"
        Me.Label333.Size = New System.Drawing.Size(49, 25)
        Me.Label333.TabIndex = 7
        Me.Label333.Text = "Fuel"
        '
        'PeLa
        '
        Me.PeLa.AutoSize = True
        Me.PeLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeLa.Location = New System.Drawing.Point(3, 53)
        Me.PeLa.Name = "PeLa"
        Me.PeLa.Size = New System.Drawing.Size(38, 25)
        Me.PeLa.TabIndex = 6
        Me.PeLa.Text = "0m"
        Me.PeLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ApLa
        '
        Me.ApLa.AutoSize = True
        Me.ApLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApLa.Location = New System.Drawing.Point(3, 28)
        Me.ApLa.Name = "ApLa"
        Me.ApLa.Size = New System.Drawing.Size(74, 25)
        Me.ApLa.TabIndex = 5
        Me.ApLa.Text = "0m - 0s"
        Me.ApLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ap/Pe"
        '
        'VelLa
        '
        Me.VelLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VelLa.Location = New System.Drawing.Point(454, 336)
        Me.VelLa.Name = "VelLa"
        Me.VelLa.Size = New System.Drawing.Size(152, 25)
        Me.VelLa.TabIndex = 3
        Me.VelLa.Text = "0m/s"
        Me.VelLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Velocity"
        '
        'AltLa
        '
        Me.AltLa.AutoSize = True
        Me.AltLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltLa.Location = New System.Drawing.Point(3, 336)
        Me.AltLa.Name = "AltLa"
        Me.AltLa.Size = New System.Drawing.Size(38, 25)
        Me.AltLa.TabIndex = 1
        Me.AltLa.Text = "0m"
        Me.AltLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altitude"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(25, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(606, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Landing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Roll"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(551, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Yaw"
        '
        'YaLa
        '
        Me.YaLa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YaLa.Location = New System.Drawing.Point(510, 167)
        Me.YaLa.Name = "YaLa"
        Me.YaLa.Size = New System.Drawing.Size(90, 25)
        Me.YaLa.TabIndex = 16
        Me.YaLa.Text = "0º"
        Me.YaLa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RollLab
        '
        Me.RollLab.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollLab.Location = New System.Drawing.Point(510, 28)
        Me.RollLab.Name = "RollLab"
        Me.RollLab.Size = New System.Drawing.Size(90, 25)
        Me.RollLab.TabIndex = 17
        Me.RollLab.Text = "0º"
        Me.RollLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 396)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "TelemetryStealer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AltLa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents VelLa As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PeLa As Label
    Friend WithEvents ApLa As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PiLa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaLa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FuLa As Label
    Friend WithEvents Label333 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RollLab As Label
    Friend WithEvents YaLa As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
End Class
