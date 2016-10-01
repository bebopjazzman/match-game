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
        Me.topLeft = New System.Windows.Forms.PictureBox()
        Me.topRight = New System.Windows.Forms.PictureBox()
        Me.botLeft = New System.Windows.Forms.PictureBox()
        Me.botRight = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnTopLeft = New System.Windows.Forms.Button()
        Me.btnTopRight = New System.Windows.Forms.Button()
        Me.btnBotLeft = New System.Windows.Forms.Button()
        Me.btnBotRight = New System.Windows.Forms.Button()
        CType(Me.topLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topLeft
        '
        Me.topLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.topLeft.Location = New System.Drawing.Point(55, 15)
        Me.topLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.topLeft.Name = "topLeft"
        Me.topLeft.Size = New System.Drawing.Size(117, 123)
        Me.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.topLeft.TabIndex = 1
        Me.topLeft.TabStop = False
        '
        'topRight
        '
        Me.topRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.topRight.Location = New System.Drawing.Point(195, 15)
        Me.topRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.topRight.Name = "topRight"
        Me.topRight.Size = New System.Drawing.Size(117, 123)
        Me.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.topRight.TabIndex = 2
        Me.topRight.TabStop = False
        '
        'botLeft
        '
        Me.botLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.botLeft.Location = New System.Drawing.Point(55, 160)
        Me.botLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botLeft.Name = "botLeft"
        Me.botLeft.Size = New System.Drawing.Size(117, 123)
        Me.botLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.botLeft.TabIndex = 3
        Me.botLeft.TabStop = False
        '
        'botRight
        '
        Me.botRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.botRight.Location = New System.Drawing.Point(195, 160)
        Me.botRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botRight.Name = "botRight"
        Me.botRight.Size = New System.Drawing.Size(117, 123)
        Me.botRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.botRight.TabIndex = 4
        Me.botRight.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(269, 315)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 37)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerate.Location = New System.Drawing.Point(15, 315)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 37)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStats.Location = New System.Drawing.Point(135, 315)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(93, 37)
        Me.btnStats.TabIndex = 7
        Me.btnStats.Text = "help"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnTopLeft
        '
        Me.btnTopLeft.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTopLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTopLeft.FlatAppearance.BorderSize = 3
        Me.btnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopLeft.Location = New System.Drawing.Point(55, 13)
        Me.btnTopLeft.Name = "btnTopLeft"
        Me.btnTopLeft.Size = New System.Drawing.Size(117, 125)
        Me.btnTopLeft.TabIndex = 9
        Me.btnTopLeft.UseVisualStyleBackColor = False
        '
        'btnTopRight
        '
        Me.btnTopRight.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTopRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopRight.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTopRight.FlatAppearance.BorderSize = 3
        Me.btnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopRight.Location = New System.Drawing.Point(195, 13)
        Me.btnTopRight.Name = "btnTopRight"
        Me.btnTopRight.Size = New System.Drawing.Size(117, 125)
        Me.btnTopRight.TabIndex = 10
        Me.btnTopRight.UseVisualStyleBackColor = False
        '
        'btnBotLeft
        '
        Me.btnBotLeft.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBotLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBotLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBotLeft.FlatAppearance.BorderSize = 3
        Me.btnBotLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotLeft.Location = New System.Drawing.Point(55, 158)
        Me.btnBotLeft.Name = "btnBotLeft"
        Me.btnBotLeft.Size = New System.Drawing.Size(117, 125)
        Me.btnBotLeft.TabIndex = 11
        Me.btnBotLeft.UseVisualStyleBackColor = False
        '
        'btnBotRight
        '
        Me.btnBotRight.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBotRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBotRight.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBotRight.FlatAppearance.BorderSize = 3
        Me.btnBotRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotRight.Location = New System.Drawing.Point(195, 158)
        Me.btnBotRight.Name = "btnBotRight"
        Me.btnBotRight.Size = New System.Drawing.Size(117, 125)
        Me.btnBotRight.TabIndex = 12
        Me.btnBotRight.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(371, 358)
        Me.Controls.Add(Me.btnBotRight)
        Me.Controls.Add(Me.btnBotLeft)
        Me.Controls.Add(Me.btnTopRight)
        Me.Controls.Add(Me.btnTopLeft)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.botRight)
        Me.Controls.Add(Me.botLeft)
        Me.Controls.Add(Me.topRight)
        Me.Controls.Add(Me.topLeft)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "match quiz"
        CType(Me.topLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents topLeft As PictureBox
    Friend WithEvents topRight As PictureBox
    Friend WithEvents botLeft As PictureBox
    Friend WithEvents botRight As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnTopLeft As Button
    Friend WithEvents btnTopRight As Button
    Friend WithEvents btnBotLeft As Button
    Friend WithEvents btnBotRight As Button
End Class
