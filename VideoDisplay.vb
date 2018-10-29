Imports AxWMPLib
Imports WMPLib
Public Class VideoDisplay

    Private Sub VideoDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary) ' assigns secondary monitor location
        If secondaryMonitor IsNot Nothing Then ' if there is a second monitor
            Dim newLocation = secondaryMonitor.Bounds.Location 'sets boundaries for monitor
            newLocation.Offset(100, 100)
            Me.Location = newLocation 'assigns monitor to this form
        End If
        Threading.Thread.Sleep(1000) 'wait 1 second
        MenuSelect.ReturnLoop() 'immediatley load looping video to windows media player
    End Sub
    'loads windows media player in fullscreen and resets player to looping video after a buttton is selected
    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        Select Case e.newState
            Case 3 'when Windows Media Player is Playing
                AxWindowsMediaPlayer1.fullScreen = True 'start in fullscreen
            Case 8 'when a video has ended
                AxWindowsMediaPlayer1.Ctlcontrols.stop() 'stop the player
                Timer1.Start() 'start timer to prevent looping video from overriding chosen button
        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() 'when chosen video ends
        Threading.Thread.Sleep(1000) 'wait 1 second
        MenuSelect.ReturnLoop() 'return to looping video
    End Sub

End Class