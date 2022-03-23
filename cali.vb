Public Class cali

    Private Sub cali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(1600, 900)
        Me.Location = New Point(-1600, 95)
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity = 1 Then
            Timer2.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.08
        End If
    End Sub

    Private Sub cali_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub
End Class