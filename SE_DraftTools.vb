Imports System.Runtime.InteropServices
Imports SolidEdgeConstants
Public Class SE_DraftTools

    Dim objApp As SolidEdgeFramework.Application
    Dim objDft As SolidEdgeDraft.DraftDocument
    Dim objSty As SolidEdgeFrameworkSupport.DimStyle

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

    Private Function Connect() As Boolean

        Try
            OleMessageFilter.Register()
            objApp = Marshal.GetActiveObject("SolidEdge.Application")

        Catch ex As Exception
            MsgBox("Solid Edge must be running", MsgBoxStyle.Critical)
            Return False
        End Try

        Try
            objDft = objApp.ActiveDocument
        Catch ex As Exception
            MsgBox("Solid Edge Draft document must be open", MsgBoxStyle.Critical)
            Return False
        End Try

        Return True

    End Function

    Private Sub CloseIt()

        Try
            If Not (objApp Is Nothing) Then
                Marshal.FinalReleaseComObject(objApp)
            End If
        Catch ex As Exception
            objApp = Nothing
        End Try

        OleMessageFilter.Revoke()

    End Sub

    Private Sub BT_FlipTerminators_Click(sender As Object, e As EventArgs) Handles BT_FlipTerminators.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    If Item.TerminatorPosition Then

                        Item.TerminatorPosition = False

                    Else

                        Item.TerminatorPosition = True

                    End If

                Catch ex As Exception

                End Try

            Next Item

        End If

    End Sub

    Private Sub BT_ToggleTerminators_Click(sender As Object, e As EventArgs) Handles BT_ToggleTerminators.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    objSty = Item.Style

                    Select Case objSty.OriginTerminatorType

                        Case Is = DimTermTypeConstants.igDimStyleTermFilled

                            If objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermFilled Then
                                objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermDot
                                objSty.OriginTerminatorType = DimTermTypeConstants.igDimStyleTermFilled
                            Else
                                objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermFilled
                                objSty.OriginTerminatorType = DimTermTypeConstants.igDimStyleTermDot
                            End If

                        Case Is = DimTermTypeConstants.igDimStyleTermDot

                            If objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermFilled Then
                                objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermDot
                                objSty.OriginTerminatorType = DimTermTypeConstants.igDimStyleTermDot
                            Else
                                objSty.TerminatorType = DimTermTypeConstants.igDimStyleTermFilled
                                objSty.OriginTerminatorType = DimTermTypeConstants.igDimStyleTermFilled
                            End If

                    End Select

                Catch ex As Exception

                End Try

            Next Item

        End If

    End Sub

    Private Sub BT_AddBreak_Click(sender As Object, e As EventArgs) Handles BT_AddBreak.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try
                    Item.AddProjectionLineBreaks
                Catch ex As Exception

                End Try

            Next Item

        End If

    End Sub

    Private Sub BT_RemoveBreaks_Click(sender As Object, e As EventArgs) Handles BT_RemoveBreaks.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try
                    Item.ClearProjectionLineBreaks
                Catch ex As Exception

                End Try

            Next Item

        End If

    End Sub

    Private Sub BT_SelectHorizontalDims_Click(sender As Object, e As EventArgs) Handles BT_SelectHorizontalDims.Click

        If Connect() Then

            For Each Item In objDft.ActiveSheet.Dimensions

                Try
                    If Not Item.MeasurementAxisDirection Then objApp.ActiveSelectSet.Add(Item)
                Catch ex As Exception

                End Try

            Next

        End If

    End Sub

    Private Sub BT_SelectVerticalDims_Click(sender As Object, e As EventArgs) Handles BT_SelectVerticalDims.Click

        If Connect() Then

            For Each Item In objDft.ActiveSheet.Dimensions

                Try
                    If Item.MeasurementAxisDirection Then objApp.ActiveSelectSet.Add(Item)
                Catch ex As Exception

                End Try

            Next

        End If

    End Sub

    Private Sub BT_HCenterDV_Click(sender As Object, e As EventArgs) Handles BT_HCenterDV.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    SetCenter(Item, objDft.ActiveSheet.SheetSetup.SheetWidth / 2, 0)

                Catch ex As Exception

                End Try

            Next

        End If

    End Sub

    Private Sub BT_VCenterDV_Click(sender As Object, e As EventArgs) Handles BT_VCenterDV.Click

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    SetCenter(Item, 0, objDft.ActiveSheet.SheetSetup.SheetHeight / 2)

                Catch ex As Exception

                End Try

            Next

        End If

    End Sub

    Private Sub SetCenter(objView As SolidEdgeDraft.DrawingView, X As Double, Y As Double)

        Dim min_x As Double
        Dim min_y As Double
        Dim max_x As Double
        Dim max_y As Double
        Dim Origin_X As Double
        Dim Origin_Y As Double

        objView.Range(min_x, min_y, max_x, max_y)
        objView.GetOrigin(Origin_X, Origin_Y)

        If X = 0 Then
            objView.SetOrigin(Origin_X, Y + Origin_Y - (min_y + max_y) / 2)
        End If

        If Y = 0 Then
            objView.SetOrigin(X + Origin_X - (min_x + max_x) / 2, Origin_Y)
        End If

    End Sub

End Class
