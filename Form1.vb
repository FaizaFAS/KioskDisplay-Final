Imports System.IO
Imports AxWMPLib
Imports WMPLib
Imports System.Diagnostics

Public Class MenuSelect
    'set button text and form (touchscreen) size
    Private Sub MenuSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' form will be maximized on touch screen
        Me.Size = New Size(1920, 1080)
        MachineTendingBtns() 'text titles for Machine Tending buttons
        MaterialRemovalBtns() ' text titles for Material Removal buttons
        MaterialHandlingBtns() ' text titles for Material Handling buttons
        AssemblyBtns() ' text titles for Assembly buttons
        OtherBtns() ' text titles for Other/Factory Automation Systems video button
        Threading.Thread.Sleep(2000) 'wait 2 seconds
        VideoDisplay.Show() 'displays Windows Media Player with looped video immediately
    End Sub
    'click functions for Machine Tending folder
    Public Sub PLCAutomation_Clks(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click
        Try
            Dim OldPLCAutomation As String() = Directory.GetFiles(GlobalVariable.MTPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldPLCAutomation(15) 'makes sure Machine tending is only 16 indeces
            Dim PLCAutomation As String() 'creates new array to copy original without database files
            ReDim PLCAutomation(15) 'ensures new array is only 16 indeces
            FileArr(OldPLCAutomation, PLCAutomation) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button1.Name
                    filename = PLCAutomation(0)
                    PlayVideo(filename)
                Case Me.Button2.Name
                    filename = PLCAutomation(1)
                    PlayVideo(filename)
                Case Me.Button3.Name
                    filename = PLCAutomation(2)
                    PlayVideo(filename)
                Case Me.Button4.Name
                    filename = PLCAutomation(3)
                    PlayVideo(filename)
                Case Me.Button5.Name
                    filename = PLCAutomation(4)
                    PlayVideo(filename)
                Case Me.Button6.Name
                    filename = PLCAutomation(5)
                    PlayVideo(filename)
                Case Me.Button7.Name
                    filename = PLCAutomation(6)
                    PlayVideo(filename)
                Case Me.Button8.Name
                    filename = PLCAutomation(7)
                    PlayVideo(filename)
                Case Me.Button9.Name
                    filename = PLCAutomation(8)
                    PlayVideo(filename)
                Case Me.Button10.Name
                    filename = PLCAutomation(9)
                    PlayVideo(filename)
                Case Me.Button11.Name
                    filename = PLCAutomation(10)
                    PlayVideo(filename)
                Case Me.Button12.Name
                    filename = PLCAutomation(11)
                    PlayVideo(filename)
                Case Me.Button13.Name
                    filename = PLCAutomation(12)
                    PlayVideo(filename)
                Case Me.Button14.Name
                    filename = PLCAutomation(13)
                    PlayVideo(filename)
                Case Me.Button15.Name
                    filename = PLCAutomation(14)
                    PlayVideo(filename)
                Case Me.Button16.Name
                    filename = PLCAutomation(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'click functions for Machine Tending folder
    Public Sub MachineTending_Clks(sender As Object, e As EventArgs) Handles Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click
        Try
            Dim OldMachineTending As String() = Directory.GetFiles(GlobalVariable.MTPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldMachineTending(15) 'makes sure Machine tending is only 16 indeces
            Dim MachineTending As String() 'creates new array to copy original without database files
            ReDim MachineTending(15) 'ensures new array is only 16 indeces
            FileArr(OldMachineTending, MachineTending) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button17.Name
                    filename = MachineTending(0)
                    PlayVideo(filename)
                Case Me.Button18.Name
                    filename = MachineTending(1)
                    PlayVideo(filename)
                Case Me.Button19.Name
                    filename = MachineTending(2)
                    PlayVideo(filename)
                Case Me.Button20.Name
                    filename = MachineTending(3)
                    PlayVideo(filename)
                Case Me.Button21.Name
                    filename = MachineTending(4)
                    PlayVideo(filename)
                Case Me.Button22.Name
                    filename = MachineTending(5)
                    PlayVideo(filename)
                Case Me.Button23.Name
                    filename = MachineTending(6)
                    PlayVideo(filename)
                Case Me.Button24.Name
                    filename = MachineTending(7)
                    PlayVideo(filename)
                Case Me.Button25.Name
                    filename = MachineTending(8)
                    PlayVideo(filename)
                Case Me.Button26.Name
                    filename = MachineTending(9)
                    PlayVideo(filename)
                Case Me.Button27.Name
                    filename = MachineTending(10)
                    PlayVideo(filename)
                Case Me.Button28.Name
                    filename = MachineTending(11)
                    PlayVideo(filename)
                Case Me.Button29.Name
                    filename = MachineTending(12)
                    PlayVideo(filename)
                Case Me.Button30.Name
                    filename = MachineTending(13)
                    PlayVideo(filename)
                Case Me.Button31.Name
                    filename = MachineTending(14)
                    PlayVideo(filename)
                Case Me.Button32.Name
                    filename = MachineTending(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'click functions for Material Removal folder
    Private Sub MaterialRemoval_Clks(sender As Object, e As EventArgs) Handles Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click
        Try
            Dim OldMaterialRemoval As String() = Directory.GetFiles(GlobalVariable.MRPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldMaterialRemoval(15) 'makes sure Machine tending is only 16 indeces
            Dim MaterialRemoval As String() 'creates new array to copy original without database files
            ReDim MaterialRemoval(15) 'ensures new array is only 16 indeces
            FileArr(OldMaterialRemoval, MaterialRemoval) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button33.Name
                    filename = MaterialRemoval(0)
                    PlayVideo(filename)
                Case Me.Button34.Name
                    filename = MaterialRemoval(1)
                    PlayVideo(filename)
                Case Me.Button35.Name
                    filename = MaterialRemoval(2)
                    PlayVideo(filename)
                Case Me.Button36.Name
                    filename = MaterialRemoval(3)
                    PlayVideo(filename)
                Case Me.Button37.Name
                    filename = MaterialRemoval(4)
                    PlayVideo(filename)
                Case Me.Button38.Name
                    filename = MaterialRemoval(5)
                    PlayVideo(filename)
                Case Me.Button39.Name
                    filename = MaterialRemoval(6)
                    PlayVideo(filename)
                Case Me.Button40.Name
                    filename = MaterialRemoval(7)
                    PlayVideo(filename)
                Case Me.Button41.Name
                    filename = MaterialRemoval(8)
                    PlayVideo(filename)
                Case Me.Button42.Name
                    filename = MaterialRemoval(9)
                    PlayVideo(filename)
                Case Me.Button43.Name
                    filename = MaterialRemoval(10)
                    PlayVideo(filename)
                Case Me.Button44.Name
                    filename = MaterialRemoval(11)
                    PlayVideo(filename)
                Case Me.Button45.Name
                    filename = MaterialRemoval(12)
                    PlayVideo(filename)
                Case Me.Button46.Name
                    filename = MaterialRemoval(13)
                    PlayVideo(filename)
                Case Me.Button47.Name
                    filename = MaterialRemoval(14)
                    PlayVideo(filename)
                Case Me.Button48.Name
                    filename = MaterialRemoval(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'click functions for Material Handling folder
    Private Sub MaterialHandling_Clks(sender As Object, e As EventArgs) Handles Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button61.Click, Button62.Click, Button63.Click, Button64.Click
        Try
            Dim OldMaterialHandling As String() = Directory.GetFiles(GlobalVariable.MHPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldMaterialHandling(15) 'makes sure Machine tending is only 16 indeces
            Dim MaterialHandling As String() 'creates new array to copy original without database files
            ReDim MaterialHandling(15) 'ensures new array is only 16 indeces
            FileArr(OldMaterialHandling, MaterialHandling) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button49.Name
                    filename = MaterialHandling(0)
                    PlayVideo(filename)
                Case Me.Button50.Name
                    filename = MaterialHandling(1)
                    PlayVideo(filename)
                Case Me.Button51.Name
                    filename = MaterialHandling(2)
                    PlayVideo(filename)
                Case Me.Button52.Name
                    filename = MaterialHandling(3)
                    PlayVideo(filename)
                Case Me.Button53.Name
                    filename = MaterialHandling(4)
                    PlayVideo(filename)
                Case Me.Button54.Name
                    filename = MaterialHandling(5)
                    PlayVideo(filename)
                Case Me.Button55.Name
                    filename = MaterialHandling(6)
                    PlayVideo(filename)
                Case Me.Button56.Name
                    filename = MaterialHandling(7)
                    PlayVideo(filename)
                Case Me.Button57.Name
                    filename = MaterialHandling(8)
                    PlayVideo(filename)
                Case Me.Button58.Name
                    filename = MaterialHandling(9)
                    PlayVideo(filename)
                Case Me.Button59.Name
                    filename = MaterialHandling(10)
                    PlayVideo(filename)
                Case Me.Button60.Name
                    filename = MaterialHandling(11)
                    PlayVideo(filename)
                Case Me.Button61.Name
                    filename = MaterialHandling(12)
                    PlayVideo(filename)
                Case Me.Button62.Name
                    filename = MaterialHandling(13)
                    PlayVideo(filename)
                Case Me.Button63.Name
                    filename = MaterialHandling(14)
                    PlayVideo(filename)
                Case Me.Button64.Name
                    filename = MaterialHandling(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'click functions for Assembly folder
    Private Sub Assembly_Clks(sender As Object, e As EventArgs) Handles Button65.Click, Button66.Click, Button67.Click, Button68.Click, Button69.Click, Button70.Click, Button71.Click, Button72.Click, Button73.Click, Button74.Click, Button75.Click, Button76.Click, Button77.Click, Button78.Click, Button79.Click, Button80.Click
        Try
            Dim OldAssembly As String() = Directory.GetFiles(GlobalVariable.APath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldAssembly(15) 'makes sure Machine tending is only 16 indeces
            Dim Assembly As String() 'creates new array to copy original without database files
            ReDim Assembly(15) 'ensures new array is only 16 indeces
            FileArr(OldAssembly, Assembly) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button65.Name
                    filename = Assembly(0)
                    PlayVideo(filename)
                Case Me.Button66.Name
                    filename = Assembly(1)
                    PlayVideo(filename)
                Case Me.Button67.Name
                    filename = Assembly(2)
                    PlayVideo(filename)
                Case Me.Button68.Name
                    filename = Assembly(3)
                    PlayVideo(filename)
                Case Me.Button69.Name
                    filename = Assembly(4)
                    PlayVideo(filename)
                Case Me.Button70.Name
                    filename = Assembly(5)
                    PlayVideo(filename)
                Case Me.Button71.Name
                    filename = Assembly(6)
                    PlayVideo(filename)
                Case Me.Button72.Name
                    filename = Assembly(7)
                    PlayVideo(filename)
                Case Me.Button73.Name
                    filename = Assembly(8)
                    PlayVideo(filename)
                Case Me.Button74.Name
                    filename = Assembly(9)
                    PlayVideo(filename)
                Case Me.Button75.Name
                    filename = Assembly(10)
                    PlayVideo(filename)
                Case Me.Button76.Name
                    filename = Assembly(11)
                    PlayVideo(filename)
                Case Me.Button77.Name
                    filename = Assembly(12)
                    PlayVideo(filename)
                Case Me.Button78.Name
                    filename = Assembly(13)
                    PlayVideo(filename)
                Case Me.Button79.Name
                    filename = Assembly(14)
                    PlayVideo(filename)
                Case Me.Button80.Name
                    filename = Assembly(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'click functions for Other folder (only Factory Automation System file)
    Private Sub Other_Clks(sender As Object, e As EventArgs) Handles Button81.Click, Button82.Click, Button83.Click, Button84.Click, Button85.Click, Button86.Click, Button87.Click, Button88.Click, Button89.Click, Button90.Click, Button91.Click, Button92.Click, Button93.Click, Button94.Click, Button95.Click, Button96.Click
        Try
            Dim OldOther As String() = Directory.GetFiles(GlobalVariable.OTPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldOther(15)
            Dim Other As String() 'creates new array to copy original without database files
            ReDim Other(15)
            FileArr(OldOther, Other) 'creates new arrray of file paths without extra database/thumb files
            Dim filename As String = "" 'Define filename to attach to buttons
            '
            'assigns appropriate file to its button
            Select Case CType(sender, Button).Name
                Case Me.Button81.Name
                    filename = Other(0)
                    PlayVideo(filename)
                Case Me.Button82.Name
                    filename = Other(1)
                    PlayVideo(filename)
                Case Me.Button83.Name
                    filename = Other(2)
                    PlayVideo(filename)
                Case Me.Button84.Name
                    filename = Other(3)
                    PlayVideo(filename)
                Case Me.Button85.Name
                    filename = Other(4)
                    PlayVideo(filename)
                Case Me.Button86.Name
                    filename = Other(5)
                    PlayVideo(filename)
                Case Me.Button87.Name
                    filename = Other(6)
                    PlayVideo(filename)
                Case Me.Button88.Name
                    filename = Other(7)
                    PlayVideo(filename)
                Case Me.Button89.Name
                    filename = Other(8)
                    PlayVideo(filename)
                Case Me.Button90.Name
                    filename = Other(9)
                    PlayVideo(filename)
                Case Me.Button91.Name
                    filename = Other(10)
                    PlayVideo(filename)
                Case Me.Button92.Name
                    filename = Other(11)
                    PlayVideo(filename)
                Case Me.Button93.Name
                    filename = Other(12)
                    PlayVideo(filename)
                Case Me.Button94.Name
                    filename = Other(13)
                    PlayVideo(filename)
                Case Me.Button95.Name
                    filename = Other(14)
                    PlayVideo(filename)
                Case Me.Button96.Name
                    filename = Other(15)
                    PlayVideo(filename)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'applies appropriate filenames to button titles from Machine Tending Folder
    Public Sub PLCAutomationBtns()
        Try
            Dim OldPLCAutomation As String() = Directory.GetFiles(GlobalVariable.PLCPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldPLCAutomation(15)
            Dim PLCAutomation As String() 'creates new array to copy original without database files
            ReDim PLCAutomation(15)
            Dim pnl As Panel = Panel1
            Dim p As Integer = 1
            FileArr(OldPLCAutomation, PLCAutomation) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, PLCAutomation, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'applies appropriate filenames to button titles from Machine Tending Folder
    Public Sub MachineTendingBtns()
        Try
            Dim OldMachineTending As String() = Directory.GetFiles(GlobalVariable.MTPath) 'places all paths of each file into array (including "Thumb.db"/extra files
            ReDim Preserve OldMachineTending(15)
            Dim MachineTending As String() 'creates new array to copy original without database files
            ReDim MachineTending(15)
            Dim pnl As Panel = Panel2
            Dim p As Integer = 2
            FileArr(OldMachineTending, MachineTending) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, MachineTending, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'applies appropriate filenames to button titles from Material Removal folder
    Public Sub MaterialRemovalBtns()
        Try
            Dim OldMaterialRemoval As String() = Directory.GetFiles(GlobalVariable.MRPath) 'places all paths of each file into array
            ReDim Preserve OldMaterialRemoval(15)
            Dim MaterialRemoval As String() 'creates new array to copy original without database files
            ReDim MaterialRemoval(15)
            Dim pnl As Panel = Panel3
            Dim p As Integer = 3
            FileArr(OldMaterialRemoval, MaterialRemoval) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, MaterialRemoval, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''applies appropriate filenames to button titles from Material Handling folder
    Public Sub MaterialHandlingBtns()
        Try
            Dim OldMaterialHandling As String() = Directory.GetFiles(GlobalVariable.MHPath) 'places all paths of each file into array
            ReDim Preserve OldMaterialHandling(15)
            Dim MaterialHandling As String() 'creates new array to copy original without database files
            ReDim MaterialHandling(15)
            Dim pnl As Panel = Panel4
            Dim p As Integer = 4
            FileArr(OldMaterialHandling, MaterialHandling) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, MaterialHandling, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''applies appropriate filenames to button titles from Assembly folder
    Public Sub AssemblyBtns()
        Try
            Dim OldAssembly As String() = Directory.GetFiles(GlobalVariable.APath) 'places all paths of each file into array
            ReDim Preserve OldAssembly(15)
            Dim Assembly As String() 'creates new array to copy original without database files
            ReDim Assembly(15)
            Dim pnl As Panel = Panel5
            Dim p As Integer = 5
            FileArr(OldAssembly, Assembly) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, Assembly, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''applies appropriate filenames to button titles from Other folder
    Public Sub OtherBtns()
        Try
            Dim OldOther As String() = Directory.GetFiles(GlobalVariable.OTPath) 'places all paths of each file into array
            ReDim Preserve OldOther(15)
            Dim Other As String() 'creates new array to copy original without databaes files
            ReDim Other(15)
            Dim pnl As Panel = Panel6
            Dim p As Integer = 6
            FileArr(OldOther, Other) 'creates new arrray of file paths without extra database/thumb files
            Eachbtn(pnl, Other, p) 'writes correct text/filename to corresponding button
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'assigns video address, plays in fullscreen, and plays when button is clicked
    Public Sub PlayVideo(filename)
        VideoDisplay.AxWindowsMediaPlayer1.settings.setMode("loop", False)
        If filename IsNot "" Then ' if there is a file assigned to this button
            VideoDisplay.AxWindowsMediaPlayer1.URL = filename ' the windows media player url is of that file
        End If
        VideoDisplay.AxWindowsMediaPlayer1.Ctlcontrols.play() 'play the video when button is clicked
    End Sub
    'creates new arrray of file paths without extra database/thumb files
    Public Sub FileArr(Oldarr, Newarr)
        Dim Newindex As Integer = 0 'count to iterate through new array
        Dim Oldindex As Integer = 0 'count to iterate through array with extra files
        'must rewrite array of filenames because original contains extra database files
        While Newindex < 16 And Oldindex < 16
            If Oldarr(Oldindex) Is Nothing Then ' if the current index of file array is empty
                Oldarr(Oldindex) = "" 'make the current index an empty string
                Newarr(Newindex) = Oldarr(Oldindex) 'copy current file array index into new array (an empty string)
                Newindex = Newindex + 1
                Oldindex = Oldindex + 1
            ElseIf Oldarr(Newindex).Contains(".db") Then 'if the current index of the old file array is a database file
                Oldindex = Oldindex + 1 'move to the next index of old array to skip datbase file
                Newarr(Newindex) = Oldarr(Oldindex)
                Newindex = Newindex + 1
                Oldindex = Oldindex + 1
            Else
                Newarr(Newindex) = Oldarr(Oldindex) 'assumes no file needs to be skipped
                Newindex = Newindex + 1
                Oldindex = Oldindex + 1
            End If
        End While

    End Sub
    'writes correct text/filename to corresponding button
    Public Sub Eachbtn(pnl, Newarr, p)
        Dim filename As String = "" ' defines filename as empty string
        Dim fileext As String = "" ' defines filename with its extension as empty string
        Dim filetime As String = ""
        Dim i As Integer = 0 ' iterates through new array of video arrays
        For Each btn As Button In pnl.Controls 'loops through each 16 buttons in Panel
            If (Newarr(i) = "") Then ' if there isn't a file for this button
                btn.Visible = False 'this button will be invisible
            Else
                Dim fullPath As String = Newarr(i) 'stores current index ofnew array in fullPath
                fileext = fullPath.Split("\").Last ' stores filename with ext in fileext
                filename = fileext.Substring(0, fileext.Length - 4) ' stores only name of file in filename
                'filetime = FileDurationText(fullPath) 'adds duration of video to title text
                btn.Text = filename '& filetime 'replaces current button with appropriate text
                btn.Visible = True ' ensures button assigned with files are visible (important for refresh button
            End If
            i = i + 1
        Next
    End Sub
    'Return Loop Button
    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        ReturnLoop()
    End Sub
    'finds duration of files in minutes and seconds (mm:ss)
    Public Function FileDurationText(filename)
        Dim Vidhhmmss As String = TimeSpan.FromSeconds(Math.Round(GetMediaDuration(filename))).ToString ' hh:mm:ss duration
        Dim space As String = " "
        Dim paral As String = "("
        Dim parar As String = ")"
        Dim Vidmmss As String = space + paral + Vidhhmmss.Substring(3, Vidhhmmss.Length - 3) + parar
        Return Vidmmss 'returned as (mm:ss)
    End Function
    'finds duration of a media file (applied in FileDurationText())
    Public Function GetMediaDuration(ByVal MediaFile As String)
        Try
            Dim w As New WMPLib.WindowsMediaPlayer
            Dim m As WMPLib.IWMPMedia = w.newMedia(MediaFile)
            Return m.duration 'used in FileDurationText
        Catch ex As Exception
            Return 0
        End Try
    End Function
    'creates a loop of 2015-0320 robot video
    Public Sub ReturnLoop()
        Try
            VideoDisplay.AxWindowsMediaPlayer1.URL = GlobalVariable.LoopPath
            VideoDisplay.AxWindowsMediaPlayer1.Ctlcontrols.play()
            VideoDisplay.AxWindowsMediaPlayer1.settings.setMode("loop", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Refresh button
    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click

        'rewrites all button text
        MachineTendingBtns()
        MaterialHandlingBtns()
        MaterialRemovalBtns()
        AssemblyBtns()
        OtherBtns()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox7.Click
        If PictureBox7.Left = 0 Then
            Timer1.Start()

        ElseIf PictureBox7.Right = 100 Then
            Timer2.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox7.Left += 5
        If PictureBox7.Right = 100 Then
            Panel7.BackColor = Color.FromArgb(255, 235, 128)
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox7.Left -= 5
        If PictureBox7.Left = 0 Then
            Panel7.BackColor = Color.FromArgb(41, 44, 51)
            Timer2.Stop()
        End If
    End Sub
End Class