'http://www.g2gsoft.com/webboard/forum.php?Mod=viewthread&tid=311
'http://www.g2gsoft.com/webboard/forum.php?Mod=viewthread&tid=317
'https://github.com/chakphanu/ThaiNationalIDCard
'https://github.com/dotnetthailand/ThaiNationalIDCard
'Original repository by Mr. Chakphanu Komasathit https://github.com/chakphanu/ThaiNationalIDCard
'APDU Command from Mr. Manoi http://hosxp.net/index.php?option=com_smf&topic=22496
'3B 78 Type of Thai smartcard. More details https://github.com/kolry/ThaiNationalIDCard/wiki/_pages

Imports ThaiNationalIDCard
Imports System.ComponentModel
Imports System.ServiceModel.Web
Imports System.ServiceModel

<ServiceContract>
Public Interface IService
    <OperationContract()>
    <WebGet(UriTemplate:="getjson", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)>
    Function getjson() As Dictionary(Of String, String)
End Interface

Public Class frmReader
    Implements IService
    Public Function getjson() As Dictionary(Of String, String) Implements IService.getjson
        'Add Options Header 
        WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*")
        Dim pData = New Dictionary(Of String, String)
        pData.Add("Citizenid", My.Settings.txtData.Item(0))
        pData.Add("sex", My.Settings.txtData.Item(1))
        pData.Add("En_Prefix", My.Settings.txtData.Item(2))
        pData.Add("En_Firstname", My.Settings.txtData.Item(3))
        pData.Add("En_Lastname", My.Settings.txtData.Item(4))
        pData.Add("Th_Prefix", My.Settings.txtData.Item(5))
        pData.Add("Th_Firstname", My.Settings.txtData.Item(6))
        pData.Add("Th_Lastname", My.Settings.txtData.Item(7))
        pData.Add("Birthday", My.Settings.txtData.Item(8))
        pData.Add("Issue", My.Settings.txtData.Item(9))
        pData.Add("Expire", My.Settings.txtData.Item(10))
        pData.Add("addrHouseNo", My.Settings.txtData.Item(11))
        pData.Add("addrVillageNo", My.Settings.txtData.Item(12))
        pData.Add("addrLane", My.Settings.txtData.Item(13))
        pData.Add("addrRoad", My.Settings.txtData.Item(14))
        pData.Add("addrTambol", My.Settings.txtData.Item(15))
        pData.Add("addrAmphur", My.Settings.txtData.Item(16))
        pData.Add("addrProvince", My.Settings.txtData.Item(17))
        pData.Add("PhotoRaw", My.Settings.txtImgBase64)

        Return pData
    End Function

    Private WithEvents objThaiIDCard As New ThaiIDCard
    Dim bgWorker As New BackgroundWorker
    Dim SetupWCF As WebServiceHost
    Public Sub openApi()
        Try
            If (SetupWCF.State = CommunicationState.Opened) Then
                SetupWCF.Close()
                tErr.Text = genLog(SetupWCF.State.ToString)

                SetupWCF = New WebServiceHost(GetType(frmReader), New Uri("http://localhost:" & t_Port.Text))
                tErr.Text = genLog(SetupWCF.State.ToString)

                SetupWCF.Open()
                tErr.Text = genLog(SetupWCF.State.ToString)
            Else
                tErr.Text = genLog(SetupWCF.State.ToString)
                SetupWCF.Open()
                tErr.Text = genLog(SetupWCF.State.ToString)
            End If

            t_api.Text = "http://localhost:" & t_Port.Text & "/getjson"
            tErr.Text = genLog("HTTP GET : " & vbCrLf & t_api.Text)
        Catch ex As Exception
            tErr.Text = genLog(vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub frmReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t_Port.Text = My.Settings.apiPort
        t_api.Text = "http://localhost:" & t_Port.Text & "/getjson"

        'อัปเดทค่าใน my.setting เอาไว้ให้ selfhost อ่านค่า
        My.Settings.txtData.Item(0) = ""
        My.Settings.txtData.Item(1) = ""
        My.Settings.txtData.Item(2) = ""
        My.Settings.txtData.Item(3) = ""
        My.Settings.txtData.Item(4) = ""
        My.Settings.txtData.Item(5) = ""
        My.Settings.txtData.Item(6) = ""
        My.Settings.txtData.Item(7) = ""
        My.Settings.txtData.Item(8) = ""
        My.Settings.txtData.Item(9) = ""
        My.Settings.txtData.Item(10) = ""
        My.Settings.txtData.Item(11) = ""
        My.Settings.txtData.Item(12) = ""
        My.Settings.txtData.Item(13) = ""
        My.Settings.txtData.Item(14) = ""
        My.Settings.txtData.Item(15) = ""
        My.Settings.txtData.Item(16) = ""
        My.Settings.txtData.Item(17) = ""
        My.Settings.txtImgBase64 = ""

        SetupWCF = New WebServiceHost(GetType(frmReader), New Uri("http://localhost:" & t_Port.Text))
        Call openApi()

        readProgressBar.Visible = False
        '// Initialized BackGroundWorker
        With bgWorker
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '// *********** IMPORTANT ***********
        Control.CheckForIllegalCrossThreadCalls = False
        '// Add Event Handler.
        AddHandler bgWorker.DoWork, AddressOf bgWorker_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted
        searchCbReader(cbReader)

    End Sub
    Sub searchCbReader(ByVal cbReaderVal As ComboBox)
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
            cbReaderVal.DroppedDown = True
            tStatus.Text = "พบเครื่องอ่านบัตร " & cbReaderVal.Items.Count & " เครื่อง .."
            tErr.Text = genLog(tStatus.Text)
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

                'อัปเดทค่าใน my.setting เอาไว้ให้ WebServiceHost อ่านค่า
                My.Settings.txtData.Item(0) = .Citizenid
                My.Settings.txtData.Item(1) = If(.Sex = 1, "ชาย", "หญิง")
                My.Settings.txtData.Item(2) = .En_Prefix
                My.Settings.txtData.Item(3) = .En_Firstname
                My.Settings.txtData.Item(4) = .En_Lastname
                My.Settings.txtData.Item(5) = .Th_Prefix
                My.Settings.txtData.Item(6) = .Th_Firstname
                My.Settings.txtData.Item(7) = .Th_Lastname
                My.Settings.txtData.Item(8) = .Birthday.ToString("dd/MM/yyyy")
                My.Settings.txtData.Item(9) = .Issue.ToString("dd/MM/yyyy")
                My.Settings.txtData.Item(10) = .Expire.ToString("dd/MM/yyyy")
                My.Settings.txtData.Item(11) = .addrHouseNo
                My.Settings.txtData.Item(12) = .addrVillageNo
                My.Settings.txtData.Item(13) = .addrLane
                My.Settings.txtData.Item(14) = .addrRoad
                My.Settings.txtData.Item(15) = .addrTambol
                My.Settings.txtData.Item(16) = .addrAmphur
                My.Settings.txtData.Item(17) = .addrProvince
                My.Settings.txtImgBase64 = Convert.ToBase64String(.PhotoRaw)

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
    Sub clearText()
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
    Function genLog(s As String)
        Return DateTime.Now.AddYears(-543).ToString("yyyy-MM-dd HH:mm:ss") & " | " & s & vbCrLf & tErr.Text
    End Function
    Private Sub frmReader_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.apiPort = t_Port.Text
    End Sub
End Class