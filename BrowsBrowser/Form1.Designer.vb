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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reload_button = New System.Windows.Forms.PictureBox()
        Me.newtab_button = New System.Windows.Forms.PictureBox()
        Me.back_button = New System.Windows.Forms.PictureBox()
        Me.forward_button = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.webProgress = New System.Windows.Forms.ProgressBar()
        Me.Sandboxed_process1 = New System.Windows.Forms.WebBrowser()
        Me.status_bar = New System.Windows.Forms.Panel()
        Me.Status = New System.Windows.Forms.Label()
        Me.adrenaline = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.reload_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newtab_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forward_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.status_bar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.reload_button)
        Me.Panel1.Controls.Add(Me.newtab_button)
        Me.Panel1.Controls.Add(Me.back_button)
        Me.Panel1.Controls.Add(Me.forward_button)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.webProgress)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 45)
        Me.Panel1.TabIndex = 1
        '
        'reload_button
        '
        Me.reload_button.BackColor = System.Drawing.Color.Transparent
        Me.reload_button.Image = Global.BrowsBrowser.My.Resources.Resources.reloadbuttonidle
        Me.reload_button.Location = New System.Drawing.Point(80, 14)
        Me.reload_button.Name = "reload_button"
        Me.reload_button.Size = New System.Drawing.Size(25, 25)
        Me.reload_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reload_button.TabIndex = 5
        Me.reload_button.TabStop = False
        '
        'newtab_button
        '
        Me.newtab_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newtab_button.BackColor = System.Drawing.Color.Transparent
        Me.newtab_button.Image = Global.BrowsBrowser.My.Resources.Resources.newtabidle
        Me.newtab_button.Location = New System.Drawing.Point(702, 14)
        Me.newtab_button.Name = "newtab_button"
        Me.newtab_button.Size = New System.Drawing.Size(25, 25)
        Me.newtab_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.newtab_button.TabIndex = 3
        Me.newtab_button.TabStop = False
        '
        'back_button
        '
        Me.back_button.BackColor = System.Drawing.Color.Transparent
        Me.back_button.Image = Global.BrowsBrowser.My.Resources.Resources.backbuttonidle
        Me.back_button.Location = New System.Drawing.Point(7, 14)
        Me.back_button.Name = "back_button"
        Me.back_button.Size = New System.Drawing.Size(25, 25)
        Me.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back_button.TabIndex = 0
        Me.back_button.TabStop = False
        '
        'forward_button
        '
        Me.forward_button.BackColor = System.Drawing.Color.Transparent
        Me.forward_button.Image = Global.BrowsBrowser.My.Resources.Resources.forwardbuttonidle
        Me.forward_button.Location = New System.Drawing.Point(42, 14)
        Me.forward_button.Name = "forward_button"
        Me.forward_button.Size = New System.Drawing.Size(25, 25)
        Me.forward_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.forward_button.TabIndex = 2
        Me.forward_button.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(111, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(585, 22)
        Me.TextBox1.TabIndex = 1
        '
        'webProgress
        '
        Me.webProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webProgress.Location = New System.Drawing.Point(111, 29)
        Me.webProgress.MarqueeAnimationSpeed = 200
        Me.webProgress.Name = "webProgress"
        Me.webProgress.Size = New System.Drawing.Size(585, 10)
        Me.webProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.webProgress.TabIndex = 4
        '
        'Sandboxed_process1
        '
        Me.Sandboxed_process1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sandboxed_process1.Location = New System.Drawing.Point(0, 45)
        Me.Sandboxed_process1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Sandboxed_process1.Name = "Sandboxed_process1"
        Me.Sandboxed_process1.ScriptErrorsSuppressed = True
        Me.Sandboxed_process1.Size = New System.Drawing.Size(800, 406)
        Me.Sandboxed_process1.TabIndex = 2
        Me.Sandboxed_process1.Url = New System.Uri("http://streamsearch.cf", System.UriKind.Absolute)
        '
        'status_bar
        '
        Me.status_bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.status_bar.Controls.Add(Me.Status)
        Me.status_bar.Location = New System.Drawing.Point(0, 431)
        Me.status_bar.Name = "status_bar"
        Me.status_bar.Size = New System.Drawing.Size(788, 20)
        Me.status_bar.TabIndex = 3
        '
        'Status
        '
        Me.Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(4, 4)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(39, 13)
        Me.Status.TabIndex = 0
        Me.Status.Text = "Label1"
        '
        'adrenaline
        '
        Me.adrenaline.Icon = CType(resources.GetObject("adrenaline.Icon"), System.Drawing.Icon)
        Me.adrenaline.Text = "Adrenaline is running!"
        Me.adrenaline.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.status_bar)
        Me.Controls.Add(Me.Sandboxed_process1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STREAM Brows Browser - Build 1906 - AdrenalineEngine is starting up..."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.reload_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newtab_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forward_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.status_bar.ResumeLayout(False)
        Me.status_bar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents back_button As PictureBox
    Friend WithEvents Sandboxed_process1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents forward_button As PictureBox
    Friend WithEvents newtab_button As PictureBox
    Friend WithEvents webProgress As ProgressBar
    Friend WithEvents status_bar As Panel
    Friend WithEvents Status As Label
    Friend WithEvents reload_button As PictureBox
    Friend WithEvents adrenaline As NotifyIcon
End Class
