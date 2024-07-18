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
        Me.BT_SelectHorizontalDims = New System.Windows.Forms.ToolStripButton()
        Me.BT_SelectVerticalDims = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_PulloutText = New System.Windows.Forms.ToolStripButton()
        Me.BT_SolidBackground = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_FlipTerminators = New System.Windows.Forms.ToolStripButton()
        Me.BT_ToggleTerminators = New System.Windows.Forms.ToolStripButton()
        Me.BT_TogglePLines = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_AddBreak = New System.Windows.Forms.ToolStripButton()
        Me.BT_RemoveBreaks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_HCenterDV = New System.Windows.Forms.ToolStripButton()
        Me.BT_VCenterDV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TS_DraftTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'TS_DraftTools
        '
        Me.TS_DraftTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TS_DraftTools.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TS_DraftTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BT_SelectHorizontalDims, Me.BT_SelectVerticalDims, Me.ToolStripSeparator3, Me.BT_PulloutText, Me.BT_SolidBackground, Me.ToolStripSeparator4, Me.BT_FlipTerminators, Me.BT_ToggleTerminators, Me.BT_TogglePLines, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BT_AddBreak, Me.BT_RemoveBreaks, Me.ToolStripSeparator1, Me.BT_HCenterDV, Me.BT_VCenterDV})
        Me.TS_DraftTools.Location = New System.Drawing.Point(0, 0)
        Me.TS_DraftTools.Name = "TS_DraftTools"
        Me.TS_DraftTools.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.TS_DraftTools.Size = New System.Drawing.Size(362, 31)
        Me.TS_DraftTools.TabIndex = 0
        Me.TS_DraftTools.Text = "TS_DraftTools"
        '
        'BT_SelectHorizontalDims
        '
        Me.BT_SelectHorizontalDims.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_SelectHorizontalDims.Image = CType(resources.GetObject("BT_SelectHorizontalDims.Image"), System.Drawing.Image)
        Me.BT_SelectHorizontalDims.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SelectHorizontalDims.Name = "BT_SelectHorizontalDims"
        Me.BT_SelectHorizontalDims.Size = New System.Drawing.Size(28, 28)
        Me.BT_SelectHorizontalDims.Text = "Select horizontal dimensions"
        '
        'BT_SelectVerticalDims
        '
        Me.BT_SelectVerticalDims.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_SelectVerticalDims.Image = CType(resources.GetObject("BT_SelectVerticalDims.Image"), System.Drawing.Image)
        Me.BT_SelectVerticalDims.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SelectVerticalDims.Name = "BT_SelectVerticalDims"
        Me.BT_SelectVerticalDims.Size = New System.Drawing.Size(28, 28)
        Me.BT_SelectVerticalDims.Text = "Select vertical dimensions"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'BT_PulloutText
        '
        Me.BT_PulloutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_PulloutText.Image = CType(resources.GetObject("BT_PulloutText.Image"), System.Drawing.Image)
        Me.BT_PulloutText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_PulloutText.Name = "BT_PulloutText"
        Me.BT_PulloutText.Size = New System.Drawing.Size(28, 28)
        Me.BT_PulloutText.Text = "Pullout text"
        '
        'BT_SolidBackground
        '
        Me.BT_SolidBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_SolidBackground.Image = CType(resources.GetObject("BT_SolidBackground.Image"), System.Drawing.Image)
        Me.BT_SolidBackground.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SolidBackground.Name = "BT_SolidBackground"
        Me.BT_SolidBackground.Size = New System.Drawing.Size(28, 28)
        Me.BT_SolidBackground.Text = "Text fill background"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'BT_FlipTerminators
        '
        Me.BT_FlipTerminators.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_FlipTerminators.Image = CType(resources.GetObject("BT_FlipTerminators.Image"), System.Drawing.Image)
        Me.BT_FlipTerminators.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_FlipTerminators.Name = "BT_FlipTerminators"
        Me.BT_FlipTerminators.Size = New System.Drawing.Size(28, 28)
        Me.BT_FlipTerminators.Text = "Flip Terminators"
        '
        'BT_ToggleTerminators
        '
        Me.BT_ToggleTerminators.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_ToggleTerminators.Image = CType(resources.GetObject("BT_ToggleTerminators.Image"), System.Drawing.Image)
        Me.BT_ToggleTerminators.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_ToggleTerminators.Name = "BT_ToggleTerminators"
        Me.BT_ToggleTerminators.Size = New System.Drawing.Size(28, 28)
        Me.BT_ToggleTerminators.Text = "Toggle Terminators"
        '
        'BT_TogglePLines
        '
        Me.BT_TogglePLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_TogglePLines.Image = CType(resources.GetObject("BT_TogglePLines.Image"), System.Drawing.Image)
        Me.BT_TogglePLines.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_TogglePLines.Name = "BT_TogglePLines"
        Me.BT_TogglePLines.Size = New System.Drawing.Size(28, 28)
        Me.BT_TogglePLines.Text = "Toggle projection lines"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BT_AddBreak
        '
        Me.BT_AddBreak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_AddBreak.Image = CType(resources.GetObject("BT_AddBreak.Image"), System.Drawing.Image)
        Me.BT_AddBreak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_AddBreak.Name = "BT_AddBreak"
        Me.BT_AddBreak.Size = New System.Drawing.Size(28, 28)
        Me.BT_AddBreak.Text = "Add projection line breaks"
        '
        'BT_RemoveBreaks
        '
        Me.BT_RemoveBreaks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_RemoveBreaks.Image = CType(resources.GetObject("BT_RemoveBreaks.Image"), System.Drawing.Image)
        Me.BT_RemoveBreaks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_RemoveBreaks.Name = "BT_RemoveBreaks"
        Me.BT_RemoveBreaks.Size = New System.Drawing.Size(28, 28)
        Me.BT_RemoveBreaks.Text = "Remove projection line breaks"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BT_HCenterDV
        '
        Me.BT_HCenterDV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_HCenterDV.Image = CType(resources.GetObject("BT_HCenterDV.Image"), System.Drawing.Image)
        Me.BT_HCenterDV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_HCenterDV.Name = "BT_HCenterDV"
        Me.BT_HCenterDV.Size = New System.Drawing.Size(28, 28)
        Me.BT_HCenterDV.Text = "Horizontally center DV"
        '
        'BT_VCenterDV
        '
        Me.BT_VCenterDV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_VCenterDV.Image = CType(resources.GetObject("BT_VCenterDV.Image"), System.Drawing.Image)
        Me.BT_VCenterDV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_VCenterDV.Name = "BT_VCenterDV"
        Me.BT_VCenterDV.Size = New System.Drawing.Size(28, 28)
        Me.BT_VCenterDV.Text = "Vertically center DV"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Toggle connection lines"
        '
        'SE_DraftTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 30)
        Me.Controls.Add(Me.TS_DraftTools)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SE_DraftTools"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Draft Tools v0.6"
        Me.TopMost = True
        Me.TS_DraftTools.ResumeLayout(False)
        Me.TS_DraftTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TS_DraftTools As ToolStrip
    Friend WithEvents BT_FlipTerminators As ToolStripButton
    Friend WithEvents BT_ToggleTerminators As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BT_AddBreak As ToolStripButton
    Friend WithEvents BT_RemoveBreaks As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BT_SelectHorizontalDims As ToolStripButton
    Friend WithEvents BT_SelectVerticalDims As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BT_HCenterDV As ToolStripButton
    Friend WithEvents BT_VCenterDV As ToolStripButton
    Friend WithEvents BT_SolidBackground As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BT_TogglePLines As ToolStripButton
    Friend WithEvents BT_PulloutText As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
