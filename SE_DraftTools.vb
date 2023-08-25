Imports System.Runtime.InteropServices
Imports SolidEdgeConstants
Public Class SE_DraftTools

    Dim objApp As SolidEdgeFramework.Application
    Dim objDft As SolidEdgeDraft.DraftDocument

    Private Sub SE_DraftTools_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each item As ToolStripItem In TS_DraftTools.Items

            AddHandler item.MouseEnter, New System.EventHandler(AddressOf Attiva)

        Next

    End Sub

    Private Sub Attiva(sender As Object, e As EventArgs)

        Me.Activate()

    End Sub

    Private Sub Disattiva(sender As Object, e As EventArgs) Handles Me.MouseLeave

        Try
            objApp = GetObject(, "SolidEdge.Application")
            objApp.Activate()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BT_SelectHorizontalDims_Click(sender As Object, e As EventArgs) Handles BT_SelectHorizontalDims.Click

        DT_Functions.SelectHDims()

    End Sub

    Private Sub BT_SelectVerticalDims_Click(sender As Object, e As EventArgs) Handles BT_SelectVerticalDims.Click

        DT_Functions.SelectVDims()

    End Sub

    Private Sub BT_SolidBackground_Click(sender As Object, e As EventArgs) Handles BT_SolidBackground.Click

        DT_Functions.SolidBackground()

    End Sub

    Private Sub BT_FlipTerminators_Click(sender As Object, e As EventArgs) Handles BT_FlipTerminators.Click

        DT_Functions.FlipTerminals()

    End Sub

    Private Sub BT_ToggleTerminators_Click(sender As Object, e As EventArgs) Handles BT_ToggleTerminators.Click

        DT_Functions.ToggleTerminals()

    End Sub

    Private Sub BT_AddBreak_Click(sender As Object, e As EventArgs) Handles BT_AddBreak.Click

        DT_Functions.AddBreaks()

    End Sub

    Private Sub BT_RemoveBreaks_Click(sender As Object, e As EventArgs) Handles BT_RemoveBreaks.Click

        DT_Functions.RemoveBreaks()

    End Sub

    Private Sub BT_HCenterDV_Click(sender As Object, e As EventArgs) Handles BT_HCenterDV.Click

        DT_Functions.HCenterDV

    End Sub

    Private Sub BT_VCenterDV_Click(sender As Object, e As EventArgs) Handles BT_VCenterDV.Click

        DT_Functions.VCenterDV

    End Sub

End Class
