Imports System.Drawing
Imports System.Media
Public Class frmPong

End Class
Public Class clsSprite
    Public pVelocity As PointF
    Public pLocation As PointF
    Public sSize As SizeF
    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal Width As Single, ByVal Height As Single)
        pLocation.X = x
        pLocation.Y = y
        sSize.Width = Width
        sSize.Height = Height
    End Sub
    Protected Sub New()
        ' TODO: Complete member initialization'
    End Sub
    Public Overridable Sub UpdateTime(ByVal dblGame As Double, ByVal dblElapsed As Double)
        pLocation.X += pVelocity.X * CSng(dblElapsed)
        pLocation.Y += pVelocity.Y * CSng(dblElapsed)
    End Sub
    Public Overridable Sub Draw()

    End Sub
End Class
Public Class clsControlSprite
    Inherits clsSprite
    Public ctrControl As Control
    Public Sub New(ByVal ctrl As Control)
        MyBase.New()
        ctrControl = ctrl
        SetDimensions()
    End Sub
    Public Overrides Sub Draw()
        ctrControl.Location = New Point(CInt(Fix(pLocation.X + 0.5F)), CInt(Fix(pLocation.Y + 0.5F)))
        ctrControl.Refresh()
    End Sub
    Protected Sub SetDimensions()
        sSize.Height = ctrControl.Height
        sSize.Width = ctrControl.Width
    End Sub
    Public Sub New()

    End Sub
End Class
Public Class Ball
    Inherits clsControlSprite
    Private Const intRadius As Integer = 20
    Private Const dblSpeed As Double = 200
    Private Shared clrColor As Color = Color.Black
    Private rndRandom As Random = New Random()
    Private sngMaxY As Single
    Private sngMinY As Single
    Private sngMaxX As Single
    Private sngMinX As Single
    Private bBat1 As clsBat
    Private bBat2 As clsBat
    Private gsGameState As clsScores
    Public Sub New(ByVal control As Control, ByVal minX As Single, ByVal maxX As Single, ByVal minY As Single, ByVal maxY As Single, ByVal player1 As clsBat, ByVal player2 As clsbat, ByVal score As clsScore)
        MyBase.New(control)
        gsGameState = score
        sngMinX = minX
        sngMaxX = maxX
        sngMinY = minY
        sngMaxY = maxY
        Clear()
        bBat1 = player1
        bBat2 = player2
        control.BackColor = clrColor
        control.Width = intRadius
        control.Height = intRadius
        SetDimensions()
    End Sub
    Private Sub Clear()
        pLocation = New PointF((sngMaxX - sngMinX) / 2, (sngMaxY - sngMinY) / 2 + rndRandom.Next(300) - 150)
    End Sub
End Class


