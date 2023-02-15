'https://github.com/chakphanu/ThaiNationalIDCard
'https://github.com/dotnetthailand/ThaiNationalIDCard
'http://hosxp.net/index.php?option=com_smf&topic=22496
'http://www.g2gsoft.com/webboard/forum.php?mod=viewthread&tid=311
'http://www.g2gsoft.com/webboard/forum.php?mod=viewthread&tid=317
'https://learn.microsoft.com/en-us/dotnet/api/system.servicemodel.web.webservicehost?redirectedfrom=MSDN&view=netframework-4.8.1
'https://learn.microsoft.com/en-us/dotnet/api/system.servicemodel.web.weboperationcontext.outgoingrequest?view=netframework-4.8
'https://www.codeproject.com/Questions/1067471/how-to-resolve-cross-domain-issues-using-wcf-servi
'https://www.codeproject.com/Articles/1184324/How-to-Create-a-WCF-WebService-in-VB-NET
'https://stackoverflow.com/questions/11403333/httplistener-with-https-support
'https://itecnote.com/tecnote/r-httplistener-with-https-support/

Imports ThaiNationalIDCard
Imports System.ComponentModel
Imports System.ServiceModel.Web
Imports System.ServiceModel
Imports System.Net

<ServiceContract>
Public Interface IService
    <OperationContract()>
    <WebInvoke(Method:="GET", UriTemplate:="", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)>
    Function runjson() As String

End Interface

Public Class frmReader
    Implements IService
    Public Function runjson() As String Implements IService.runjson
        Dim json As String
        json = "{"
        json &= " ""Citizenid"": """ & My.Settings.txtPerson.Item(0) & """, "
        json &= " ""sex"": """ & My.Settings.txtPerson.Item(1) & """, "
        json &= " ""En_Prefix"": """ & My.Settings.txtPerson.Item(2) & """, "
        json &= " ""En_Firstname"": """ & My.Settings.txtPerson.Item(3) & """, "
        json &= " ""En_Lastname"": """ & My.Settings.txtPerson.Item(4) & """, "
        json &= " ""Th_Prefix"": """ & My.Settings.txtPerson.Item(5) & """, "
        json &= " ""Th_Firstname"": """ & My.Settings.txtPerson.Item(6) & """, "
        json &= " ""Th_Lastname"": """ & My.Settings.txtPerson.Item(7) & """, "
        json &= " ""Birthday"": """ & My.Settings.txtPerson.Item(8) & """, "
        json &= " ""Issue"": """ & My.Settings.txtPerson.Item(9) & """, "
        json &= " ""Expire"": """ & My.Settings.txtPerson.Item(10) & """, "
        json &= " ""addrHouseNo"": """ & My.Settings.txtPerson.Item(11) & """, "
        json &= " ""addrVillageNo"": """ & My.Settings.txtPerson.Item(12) & """, "
        json &= " ""addrLane"": """ & My.Settings.txtPerson.Item(13) & """, "
        json &= " ""addrRoad"": """ & My.Settings.txtPerson.Item(14) & """, "
        json &= " ""addrTambol"": """ & My.Settings.txtPerson.Item(15) & """, "
        json &= " ""addrAmphur"": """ & My.Settings.txtPerson.Item(16) & """, "
        json &= " ""addrProvince"": """ & My.Settings.txtPerson.Item(17) & """, "
        json &= " ""Address"": """ & My.Settings.txtPerson.Item(18) & """, "
        json &= " ""Issuer"": """ & My.Settings.txtPerson.Item(19) & """, "
        json &= " ""PhotoRaw"": """ & My.Settings.txtImgBase64 & """ "
        json &= "}"
        Return json
    End Function

    Dim bgWorkerListener As New BackgroundWorker
    Dim apiUrl As String
    Dim listener As New HttpListener()
    Private Sub frmReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'อัปเดทค่าใน my.setting เอาไว้ให้ selfhost อ่านค่า
        My.Settings.txtImgBase64 = ""
        For i = 0 To 19
            My.Settings.txtPerson.Item(i) = ""
        Next

        '// Initialized bgWorker
        With bgWorker
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '// Initialized bgWorkerListener
        With bgWorkerListener
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        readProgressBar.Visible = False
        searchCbReader(cbReader)

        '// *********** IMPORTANT ***********
        Control.CheckForIllegalCrossThreadCalls = False
        '// Add Event Handler.
        AddHandler bgWorker.DoWork, AddressOf bgWorker_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted
        '// Add Event Handler.
        AddHandler bgWorkerListener.DoWork, AddressOf bgWorkerListener_DoWork

        'Run Selfhost HttpListener
        t_Port.Text = My.Settings.apiPort
        t_url.Text = My.Settings.apiUrl
        apiUrl = "http://" & t_url.Text & ":" & t_Port.Text & "/"
        Call chkWorker()
    End Sub
    Private Sub t_Port_Leave(sender As Object, e As EventArgs) Handles t_Port.Leave
        My.Settings.apiPort = t_Port.Text
        My.Settings.apiUrl = t_url.Text
        apiUrl = "http://" & t_url.Text & ":" & t_Port.Text & "/"
    End Sub
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call chkWorker()
    End Sub
    Private Sub chkWorker()
        If bgWorkerListener.IsBusy = True Then
            listener.Stop()
        Else
            bgWorkerListener.RunWorkerAsync()
        End If
    End Sub
    Private Sub openListener()
        Try
            Dim uri(2) As String
            uri(0) = "/json/"
            Dim reader As New frmReader()
            listener.Prefixes.Add(apiUrl)
            listener.Start()

            tErr.Text = genLog("HTTP Method GET Started as LINK below" &
                               vbCrLf & apiUrl & uri(0).Remove(0, 1) &
                               vbCrLf)
            btnRun.Text = "Stop"
            While True
                Dim context As HttpListenerContext = listener.GetContext()
                Dim request As HttpListenerRequest = context.Request
                Dim response As HttpListenerResponse = context.Response

                response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, X-Requested-With")
                response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS")
                response.AddHeader("Access-Control-Max-Age", "1728000")
                response.AppendHeader("Access-Control-Allow-Origin", "*")

                If request.Url.LocalPath = uri(0) AndAlso request.HttpMethod = "GET" Then
                    response.ContentType = "application/json"
                    response.StatusCode = 200

                    Dim responseData As String = reader.runjson()
                    Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(responseData)
                    response.ContentLength64 = buffer.Length
                    response.OutputStream.Write(buffer, 0, buffer.Length)
                    response.OutputStream.Close()
                Else
                    response.StatusCode = 404
                    response.OutputStream.Close()
                End If
            End While
        Catch ex As Exception
            tErr.Text = genLog("HTTP Listener has Stoped" & vbCrLf)
            listener.Stop()
            bgWorkerListener.CancelAsync()
            btnRun.Text = "Start"
        End Try
    End Sub
    Private Sub bgWorkerListener_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        Call openListener()
    End Sub

    ' ##################### Smart Card Event ####################
    Private WithEvents objThaiIDCard As New ThaiIDCard
    Dim bgWorker As New BackgroundWorker
    Private Sub searchCbReader(ByVal cbReaderVal As ComboBox)
        tStatus.Text = "กำลังค้นหาเครื่องอ่านบัตร .."
        tErr.Text = genLog(tStatus.Text)
        Try
            cbReaderVal.Items.Clear()
            cbReaderVal.SelectedIndex = -1
            cbReaderVal.SelectedText = String.Empty
            cbReaderVal.Text = String.Empty
            cbReaderVal.Refresh()
            Dim idcard As ThaiIDCard = New ThaiIDCard()
            Dim readers As String() = idcard.GetReaders()
            If readers Is Nothing Then Return
            For Each r As String In readers
                cbReaderVal.Items.Add(r)
            Next
            'cbReaderVal.DroppedDown = True
            tStatus.Text = "พบเครื่องอ่านบัตร " & cbReaderVal.Items.Count & " เครื่อง .."
            tErr.Text = genLog(tStatus.Text)

            If cbReader.Items.Count = 1 Then
                cbReaderVal.SelectedIndex = 0
            Else
                cbReaderVal.DroppedDown = True
            End If
            'tErr.Text &= vbCrLf & idcard.GetHashCode
        Catch ex As Exception
            tStatus.Text = "ไม่พบเครื่องอ่านบัตร .."
            tErr.Text = genLog(tStatus.Text)
        End Try
    End Sub
    Private Sub cbReader_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReader.SelectedIndexChanged
        ckAutoRead.CheckState = CheckState.Checked
        tStatus.Text = "เลือกเครื่องอ่านบัตรแล้ว .."
        tErr.Text = genLog(tStatus.Text)
    End Sub
    Private Sub autoRead()
        If ckAutoRead.Checked = True Then
            If cbReader.SelectedItem Is Nothing Then
                tStatus.Text = "ยังไม่ได้เลือกเครื่องอ่านบัตรสำหรับอ่านข้อมูล ..!"
                tErr.Text = genLog(tStatus.Text)
                ckAutoRead.Checked = False
                Return
            End If

            'Event Capture SmartCard
            objThaiIDCard.MonitorStart(cbReader.SelectedItem.ToString())
            'Event Card Inserted
            AddHandler objThaiIDCard.eventCardInserted, AddressOf readThaiIDCard
            'Event Card Remove
            AddHandler objThaiIDCard.eventCardRemoved, AddressOf clearText
            'Evednt Card Progress เอาไว้ทำ progress bar
            AddHandler objThaiIDCard.eventPhotoProgress, AddressOf readProgress

        Else
            If cbReader.SelectedItem IsNot Nothing Then objThaiIDCard.MonitorStop(cbReader.SelectedItem.ToString())
        End If
    End Sub
    Private Sub ckAutoRead_CheckedChanged(sender As Object, e As EventArgs) Handles ckAutoRead.CheckedChanged
        Call autoRead()
    End Sub
    Sub readThaiIDCard()
        tStatus.Text = "กำลังอ่านบัตร .."
        tErr.Text = genLog(tStatus.Text)
        bgWorker.RunWorkerAsync()
    End Sub
    Private Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim objThaiIDCardData As New Personal
        readProgressBar.Value = 0
        readProgressBar.Visible = True

        'Evednt Card Progress เอาไว้ทำ progress bar
        AddHandler objThaiIDCard.eventPhotoProgress, AddressOf readProgress

        'อ่านค่าจาก smart card
        objThaiIDCardData = objThaiIDCard.readAllPhoto

        If Not objThaiIDCardData Is Nothing Then
            With objThaiIDCardData

                t_Citizenid.Text = .Citizenid 'เลขบัตรประชาชน
                t_Sex.Text = If(.Sex = 1, "ชาย", "หญิง")

                'EN
                t_En_Prefix.Text = .En_Prefix
                t_En_Firstname.Text = .En_Firstname
                t_En_Lastname.Text = .En_Lastname

                'TH
                t_Th_Prefix.Text = .Th_Prefix
                t_Th_Firstname.Text = .Th_Firstname
                t_Th_Lastname.Text = .Th_Lastname

                'ว/ด/ป เกิด
                t_Birthday.Text = .Birthday.ToString("dd/MM/yyyy")

                'วันออกบัตร
                t_Issue.Text = .Issue.ToString("dd/MM/yyyy")

                'วันหมดอายุบัตร
                t_Expire.Text = .Expire.ToString("dd/MM/yyyy")

                t_addrHouseNo.Text = .addrHouseNo
                t_addrVillageNo.Text = .addrVillageNo
                t_addrLane.Text = .addrLane
                t_addrRoad.Text = .addrRoad
                t_addrTambol.Text = .addrTambol
                t_addrAmphur.Text = .addrAmphur
                t_addrProvince.Text = .addrProvince
                PictureBox1.Image = .PhotoBitmap
                t_PhotoRaw.Text = Convert.ToBase64String(.PhotoRaw)
                t_Issuer.Text = .Issuer
                If Not IsNothing(t_Birthday.Text) Then t_age.Text = CalcDate(t_Birthday.Text, Now())

                'อัปเดทค่าใน my.setting เอาไว้ให้ WebServiceHost อ่านค่า
                My.Settings.txtPerson.Item(0) = .Citizenid
                My.Settings.txtPerson.Item(1) = If(.Sex = 1, "ชาย", "หญิง")
                My.Settings.txtPerson.Item(2) = .En_Prefix
                My.Settings.txtPerson.Item(3) = .En_Firstname
                My.Settings.txtPerson.Item(4) = .En_Lastname
                My.Settings.txtPerson.Item(5) = .Th_Prefix
                My.Settings.txtPerson.Item(6) = .Th_Firstname
                My.Settings.txtPerson.Item(7) = .Th_Lastname
                'My.Settings.txtPerson.Item(8) = .Birthday.ToString("yyyyMMdd")
                My.Settings.txtPerson.Item(8) = .Birthday.ToString("dd/MM/yyyy")
                My.Settings.txtPerson.Item(9) = .Issue.ToString("dd/MM/yyyy")
                My.Settings.txtPerson.Item(10) = .Expire.ToString("dd/MM/yyyy")
                My.Settings.txtPerson.Item(11) = .addrHouseNo
                My.Settings.txtPerson.Item(12) = .addrVillageNo
                My.Settings.txtPerson.Item(13) = .addrLane
                My.Settings.txtPerson.Item(14) = .addrRoad
                My.Settings.txtPerson.Item(15) = .addrTambol
                My.Settings.txtPerson.Item(16) = .addrAmphur
                My.Settings.txtPerson.Item(17) = .addrProvince
                'My.Settings.txtPerson.Item(18) = .Address
                My.Settings.txtPerson.Item(18) = .Address.Replace(" ", "#")
                My.Settings.txtPerson.Item(19) = .Issuer.Replace(" ", "")
                My.Settings.txtImgBase64 = Convert.ToBase64String(.PhotoRaw)

                'MsgBox(.Issuer)
                'MsgBox(.Address)
                tStatus.Text = "อ่านบัตรสำเร็จ .."
                tErr.Text = genLog(tStatus.Text)
            End With

        ElseIf objThaiIDCard.ErrorCode > 0 Then
            Select Case objThaiIDCard.ErrorCode
                Case Is = 256
                    tStatus.Text = "ยังไม่ได้เชื่อมต่อเครื่องอ่านบัตรประชาชน"
                    tErr.Text = genLog(tStatus.Text)
                Case Else
                    tStatus.Text = objThaiIDCard.Error
                    tErr.Text = genLog(tStatus.Text)
            End Select
        End If

    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        readProgressBar.Visible = False
    End Sub
    Private Sub clearText()
        tStatus.Text = "ถอดบัตรจากเครื่องอ่าน .."
        tErr.Text = genLog(tStatus.Text)
        For Each tb As TextBox In Me.GroupBox1.Controls.OfType(Of TextBox)()
            tb.Clear()
        Next
        PictureBox1.Image = Nothing
    End Sub
    Private Sub readProgress(ByVal value As Integer, ByVal maximum As Integer)

        If tErr.InvokeRequired Then
            If readProgressBar.Maximum <> maximum Then
                readProgressBar.BeginInvoke(New MethodInvoker(Function()
                                                                  readProgressBar.Maximum = maximum
                                                              End Function))
            End If

            If readProgressBar.Maximum > value Then
                readProgressBar.BeginInvoke(New MethodInvoker(Function()
                                                                  readProgressBar.Value = value + 1
                                                              End Function))
                readProgressBar.BeginInvoke(New MethodInvoker(Function()
                                                                  readProgressBar.Value = value
                                                              End Function))
            End If

        Else
            If readProgressBar.Maximum <> maximum Then readProgressBar.Maximum = maximum
            If readProgressBar.Maximum > value Then readProgressBar.Value = value + 1
            readProgressBar.Value = value
        End If

    End Sub
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        searchCbReader(cbReader)
    End Sub
    Private Function CalcDate(sDate As Date, eDate As Date) As String
        Dim vDays As Integer
        Dim vMonths As Integer
        Dim vYears As Integer
        '/ Parameters:
        '/    sDate - ค่าวันเดือนปีเกิด (หรือวันเดือนปีที่ต้องการคำนวณหา)
        '/    eDate - คำนวณเทียบกับวันเดือนปีปัจจุบัน (Now())
        '/ Results:
        '/    vYears - เก็บค่าความแตกต่างของจำนวนปี
        '/    vMonths - เก็บค่าความแตกต่างของจำนวนเดือน
        '/    vDays - เก็บค่าความแตกต่างของจำนวนวัน

        '/ หาความแตกต่างของจำนวนเดือน
        vMonths = DateDiff("m", sDate, eDate)
        vDays = DateDiff("d", DateAdd("m", vMonths, sDate), eDate)
        If vDays < 0 Then
            vMonths = vMonths - 1
            vDays = DateDiff("d", DateAdd("m", vMonths, sDate), eDate)
        End If
        vYears = vMonths \ 12 ' หารตัดเศษก็จะได้จำนวนปี
        vMonths = vMonths Mod 12 ' การหารเอาเศษ โดยจะมีค่าระหว่าง 0, 1, 2, ... 11 ไม่มีทางเท่ากับ หรือ มากกว่า 12
        CalcDate = "อายุ " & vYears & " ปี " & vMonths & " เดือน " & vDays & " วัน"
    End Function
    Private Function genLog(s As String)
        Return DateTime.Now.AddYears(-543).ToString("yyyy-MM-dd HH:mm:ss") & " | " & s & vbCrLf & tErr.Text
    End Function
End Class