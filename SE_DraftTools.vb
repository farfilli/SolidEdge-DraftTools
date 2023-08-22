Imports System.Runtime.InteropServices
Imports SolidEdgeConstants
Public Class SE_DraftTools

    Dim objApp As SolidEdgeFramework.Application
    Dim objDft As SolidEdgeDraft.DraftDocument
    Dim objSty As SolidEdgeFrameworkSupport.DimStyle

    Private Sub Attiva(sender As Object, e As EventArgs) Handles BT_FlipTerminators.MouseEnter, BT_ToggleTerminators.MouseEnter, BT_Close.MouseEnter, BT_AddBreak.MouseEnter, BT_RemoveBreaks.MouseEnter

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
            objApp = GetObject(, "SolidEdge.Application")
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

    Private Sub BT_Close_Click(sender As Object, e As EventArgs) Handles BT_Close.Click
        Me.Close()
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

End Class
