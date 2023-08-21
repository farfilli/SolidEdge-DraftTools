<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SE_DraftTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SE_DraftTools))
        Me.TS_DraftTools = New System.Windows.Forms.ToolStrip()
        Me.BT_FlipTerminators = New System.Windows.Forms.ToolStripButton()
        Me.BT_ToggleTerminators = New System.Windows.Forms.ToolStripButton()
        Me.BT_AddBreak = New System.Windows.Forms.ToolStripButton()
        Me.BT_RemoveBreaks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_Close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TS_DraftTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'TS_DraftTools
        '
        Me.TS_DraftTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TS_DraftTools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TS_DraftTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BT_FlipTerminators, Me.BT_ToggleTerminators, Me.ToolStripSeparator2, Me.BT_AddBreak, Me.BT_RemoveBreaks, Me.ToolStripSeparator1, Me.BT_Close})
        Me.TS_DraftTools.Location = New System.Drawing.Point(0, 0)
        Me.TS_DraftTools.Name = "TS_DraftTools"
        Me.TS_DraftTools.Size = New System.Drawing.Size(194, 39)
        Me.TS_DraftTools.TabIndex = 0
        Me.TS_DraftTools.Text = "TS_DraftTools"
        '
        'BT_FlipTerminators
        '
        Me.BT_FlipTerminators.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_FlipTerminators.Image = CType(resources.GetObject("BT_FlipTerminators.Image"), System.Drawing.Image)
        Me.BT_FlipTerminators.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_FlipTerminators.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_FlipTerminators.Name = "BT_FlipTerminators"
        Me.BT_FlipTerminators.Size = New System.Drawing.Size(36, 36)
        Me.BT_FlipTerminators.Text = "Flip Terminators"
        '
        'BT_ToggleTerminators
        '
        Me.BT_ToggleTerminators.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_ToggleTerminators.Image = CType(resources.GetObject("BT_ToggleTerminators.Image"), System.Drawing.Image)
        Me.BT_ToggleTerminators.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_ToggleTerminators.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_ToggleTerminators.Name = "BT_ToggleTerminators"
        Me.BT_ToggleTerminators.Size = New System.Drawing.Size(36, 36)
        Me.BT_ToggleTerminators.Text = "Toggle Terminators"
        '
        'BT_AddBreak
        '
        Me.BT_AddBreak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_AddBreak.Image = CType(resources.GetObject("BT_AddBreak.Image"), System.Drawing.Image)
        Me.BT_AddBreak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_AddBreak.Name = "BT_AddBreak"
        Me.BT_AddBreak.Size = New System.Drawing.Size(36, 36)
        Me.BT_AddBreak.Text = "Add projection line breaks"
        '
        'BT_RemoveBreaks
        '
        Me.BT_RemoveBreaks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_RemoveBreaks.Image = CType(resources.GetObject("BT_RemoveBreaks.Image"), System.Drawing.Image)
        Me.BT_RemoveBreaks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_RemoveBreaks.Name = "BT_RemoveBreaks"
        Me.BT_RemoveBreaks.Size = New System.Drawing.Size(36, 36)
        Me.BT_RemoveBreaks.Text = "Remove projection line breaks"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BT_Close
        '
        Me.BT_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Close.Image = CType(resources.GetObject("BT_Close.Image"), System.Drawing.Image)
        Me.BT_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_Close.Name = "BT_Close"
        Me.BT_Close.Size = New System.Drawing.Size(36, 36)
        Me.BT_Close.Text = "Close"
        Me.BT_Close.ToolTipText = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'SE_DraftTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 38)
        Me.ControlBox = False
        Me.Controls.Add(Me.TS_DraftTools)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SE_DraftTools"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Draft Tools v0.0"
        Me.TopMost = True
        Me.TS_DraftTools.ResumeLayout(False)
        Me.TS_DraftTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TS_DraftTools As ToolStrip
    Friend WithEvents BT_FlipTerminators As ToolStripButton
    Friend WithEvents BT_ToggleTerminators As ToolStripButton
    Friend WithEvents BT_Close As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BT_AddBreak As ToolStripButton
    Friend WithEvents BT_RemoveBreaks As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
