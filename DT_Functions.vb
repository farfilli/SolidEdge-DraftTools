Imports System.Runtime.InteropServices
Imports SolidEdgeFrameworkSupport

Public Class DT_Functions

    Shared objApp As SolidEdgeFramework.Application
    Shared objDft As SolidEdgeDraft.DraftDocument

    Shared Function Connect() As Boolean

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

    Shared Sub CloseIt()

        Try
            If Not (objApp Is Nothing) Then
                Marshal.FinalReleaseComObject(objApp)
            End If
        Catch ex As Exception
            objApp = Nothing
        End Try

        OleMessageFilter.Revoke()

    End Sub

    Shared Sub SelectHDims()

        If Connect() Then

            Dim tmpSelectSet As SolidEdgeFramework.SelectSet = objApp.ActiveSelectSet
            Dim tmpHighlightset As SolidEdgeFramework.HighlightSet = objDft.HighlightSets.Add()

            For Each Item In objDft.ActiveSheet.Dimensions

                Try
                    If Not Item.MeasurementAxisDirection Then tmpHighlightset.AddItem(Item)
                Catch ex As Exception

                End Try

            Next

            tmpSelectSet.Add(tmpHighlightset)

        End If

        CloseIt()

    End Sub

    Shared Sub SelectVDims()

        If Connect() Then

            Dim tmpSelectSet As SolidEdgeFramework.SelectSet = objApp.ActiveSelectSet
            Dim tmpHighlightset As SolidEdgeFramework.HighlightSet = objDft.HighlightSets.Add()

            For Each Item In objDft.ActiveSheet.Dimensions

                Try
                    If Item.MeasurementAxisDirection Then tmpHighlightset.AddItem(Item)
                Catch ex As Exception

                End Try

            Next

            tmpSelectSet.Add(tmpHighlightset)

        End If

        CloseIt()

    End Sub

    Shared Sub SolidBackground()

        If Connect() Then

            Dim objSty As SolidEdgeFrameworkSupport.DimStyle

            For Each Item In objDft.SelectSet

                Try

                    objSty = Item.Style
                    objSty.TextAutoFillBackground = Not objSty.TextAutoFillBackground

                Catch ex As Exception
                End Try

            Next Item

        End If

        CloseIt()

    End Sub

    Shared Sub FlipTerminals()

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

        CloseIt()

    End Sub

    Shared Sub ToggleTerminals()

        If Connect() Then

            Dim objSty As SolidEdgeFrameworkSupport.DimStyle

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

        CloseIt()

    End Sub

    Shared Sub AddBreaks()

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try
                    Item.AddProjectionLineBreaks
                Catch ex As Exception

                End Try

            Next Item

        End If

        CloseIt()

    End Sub

    Shared Sub RemoveBreaks()

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try
                    Item.ClearProjectionLineBreaks
                Catch ex As Exception

                End Try

            Next Item

        End If

        CloseIt()

    End Sub

    Shared Sub HCenterDV()

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    SetCenter(Item, objDft.ActiveSheet.SheetSetup.SheetWidth / 2, 0)

                Catch ex As Exception

                End Try

            Next

        End If

        CloseIt()

    End Sub

    Shared Sub VCenterDV()

        If Connect() Then

            For Each Item In objDft.SelectSet

                Try

                    SetCenter(Item, 0, objDft.ActiveSheet.SheetSetup.SheetHeight / 2)

                Catch ex As Exception

                End Try

            Next

        End If

        CloseIt()

    End Sub

    Shared Sub SetCenter(objView As SolidEdgeDraft.DrawingView, X As Double, Y As Double)

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
