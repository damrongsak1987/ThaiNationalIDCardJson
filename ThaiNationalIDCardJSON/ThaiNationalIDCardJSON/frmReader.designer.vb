<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReader))
        Me.t_Citizenid = New System.Windows.Forms.TextBox()
        Me.t_Th_Prefix = New System.Windows.Forms.TextBox()
        Me.t_Th_Firstname = New System.Windows.Forms.TextBox()
        Me.t_Th_Lastname = New System.Windows.Forms.TextBox()
        Me.t_En_Prefix = New System.Windows.Forms.TextBox()
        Me.t_En_Firstname = New System.Windows.Forms.TextBox()
        Me.t_En_Lastname = New System.Windows.Forms.TextBox()
        Me.t_Sex = New System.Windows.Forms.TextBox()
        Me.t_Birthday = New System.Windows.Forms.TextBox()
        Me.t_Issue = New System.Windows.Forms.TextBox()
        Me.t_Expire = New System.Windows.Forms.TextBox()
        Me.t_addrHouseNo = New System.Windows.Forms.TextBox()
        Me.t_addrVillageNo = New System.Windows.Forms.TextBox()
        Me.t_addrLane = New System.Windows.Forms.TextBox()
        Me.t_addrRoad = New System.Windows.Forms.TextBox()
        Me.t_addrTambol = New System.Windows.Forms.TextBox()
        Me.t_addrAmphur = New System.Windows.Forms.TextBox()
        Me.t_addrProvince = New System.Windows.Forms.TextBox()
        Me.t_PhotoRaw = New System.Windows.Forms.TextBox()
        Me.t_api = New System.Windows.Forms.TextBox()
        Me.cbReader = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.readProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.ckAutoRead = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tErr = New System.Windows.Forms.RichTextBox()
        Me.tStatus = New System.Windows.Forms.Label()
        Me.t_Port = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't_Citizenid
        '
        Me.t_Citizenid.BackColor = System.Drawing.Color.White
        Me.t_Citizenid.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Citizenid.Location = New System.Drawing.Point(6, 43)
        Me.t_Citizenid.Name = "t_Citizenid"
        Me.t_Citizenid.ReadOnly = True
        Me.t_Citizenid.Size = New System.Drawing.Size(275, 26)
        Me.t_Citizenid.TabIndex = 0
        Me.t_Citizenid.TabStop = False
        '
        't_Th_Prefix
        '
        Me.t_Th_Prefix.BackColor = System.Drawing.Color.White
        Me.t_Th_Prefix.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Th_Prefix.Location = New System.Drawing.Point(6, 75)
        Me.t_Th_Prefix.Name = "t_Th_Prefix"
        Me.t_Th_Prefix.ReadOnly = True
        Me.t_Th_Prefix.Size = New System.Drawing.Size(82, 26)
        Me.t_Th_Prefix.TabIndex = 0
        Me.t_Th_Prefix.TabStop = False
        '
        't_Th_Firstname
        '
        Me.t_Th_Firstname.BackColor = System.Drawing.Color.White
        Me.t_Th_Firstname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Th_Firstname.Location = New System.Drawing.Point(94, 75)
        Me.t_Th_Firstname.Name = "t_Th_Firstname"
        Me.t_Th_Firstname.ReadOnly = True
        Me.t_Th_Firstname.Size = New System.Drawing.Size(130, 26)
        Me.t_Th_Firstname.TabIndex = 0
        Me.t_Th_Firstname.TabStop = False
        '
        't_Th_Lastname
        '
        Me.t_Th_Lastname.BackColor = System.Drawing.Color.White
        Me.t_Th_Lastname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Th_Lastname.Location = New System.Drawing.Point(230, 75)
        Me.t_Th_Lastname.Name = "t_Th_Lastname"
        Me.t_Th_Lastname.ReadOnly = True
        Me.t_Th_Lastname.Size = New System.Drawing.Size(130, 26)
        Me.t_Th_Lastname.TabIndex = 0
        Me.t_Th_Lastname.TabStop = False
        '
        't_En_Prefix
        '
        Me.t_En_Prefix.BackColor = System.Drawing.Color.White
        Me.t_En_Prefix.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_En_Prefix.Location = New System.Drawing.Point(6, 107)
        Me.t_En_Prefix.Name = "t_En_Prefix"
        Me.t_En_Prefix.ReadOnly = True
        Me.t_En_Prefix.Size = New System.Drawing.Size(82, 26)
        Me.t_En_Prefix.TabIndex = 0
        Me.t_En_Prefix.TabStop = False
        '
        't_En_Firstname
        '
        Me.t_En_Firstname.BackColor = System.Drawing.Color.White
        Me.t_En_Firstname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_En_Firstname.Location = New System.Drawing.Point(94, 107)
        Me.t_En_Firstname.Name = "t_En_Firstname"
        Me.t_En_Firstname.ReadOnly = True
        Me.t_En_Firstname.Size = New System.Drawing.Size(130, 26)
        Me.t_En_Firstname.TabIndex = 0
        Me.t_En_Firstname.TabStop = False
        '
        't_En_Lastname
        '
        Me.t_En_Lastname.BackColor = System.Drawing.Color.White
        Me.t_En_Lastname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_En_Lastname.Location = New System.Drawing.Point(230, 107)
        Me.t_En_Lastname.Name = "t_En_Lastname"
        Me.t_En_Lastname.ReadOnly = True
        Me.t_En_Lastname.Size = New System.Drawing.Size(130, 26)
        Me.t_En_Lastname.TabIndex = 0
        Me.t_En_Lastname.TabStop = False
        '
        't_Sex
        '
        Me.t_Sex.BackColor = System.Drawing.Color.White
        Me.t_Sex.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Sex.Location = New System.Drawing.Point(287, 43)
        Me.t_Sex.Name = "t_Sex"
        Me.t_Sex.ReadOnly = True
        Me.t_Sex.Size = New System.Drawing.Size(73, 26)
        Me.t_Sex.TabIndex = 0
        Me.t_Sex.TabStop = False
        '
        't_Birthday
        '
        Me.t_Birthday.BackColor = System.Drawing.Color.White
        Me.t_Birthday.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Birthday.Location = New System.Drawing.Point(6, 139)
        Me.t_Birthday.Name = "t_Birthday"
        Me.t_Birthday.ReadOnly = True
        Me.t_Birthday.Size = New System.Drawing.Size(114, 26)
        Me.t_Birthday.TabIndex = 0
        Me.t_Birthday.TabStop = False
        '
        't_Issue
        '
        Me.t_Issue.BackColor = System.Drawing.Color.White
        Me.t_Issue.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Issue.Location = New System.Drawing.Point(126, 139)
        Me.t_Issue.Name = "t_Issue"
        Me.t_Issue.ReadOnly = True
        Me.t_Issue.Size = New System.Drawing.Size(114, 26)
        Me.t_Issue.TabIndex = 0
        Me.t_Issue.TabStop = False
        '
        't_Expire
        '
        Me.t_Expire.BackColor = System.Drawing.Color.White
        Me.t_Expire.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Expire.Location = New System.Drawing.Point(246, 139)
        Me.t_Expire.Name = "t_Expire"
        Me.t_Expire.ReadOnly = True
        Me.t_Expire.Size = New System.Drawing.Size(114, 26)
        Me.t_Expire.TabIndex = 0
        Me.t_Expire.TabStop = False
        '
        't_addrHouseNo
        '
        Me.t_addrHouseNo.BackColor = System.Drawing.Color.White
        Me.t_addrHouseNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrHouseNo.Location = New System.Drawing.Point(6, 171)
        Me.t_addrHouseNo.Name = "t_addrHouseNo"
        Me.t_addrHouseNo.ReadOnly = True
        Me.t_addrHouseNo.Size = New System.Drawing.Size(82, 26)
        Me.t_addrHouseNo.TabIndex = 0
        Me.t_addrHouseNo.TabStop = False
        '
        't_addrVillageNo
        '
        Me.t_addrVillageNo.BackColor = System.Drawing.Color.White
        Me.t_addrVillageNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrVillageNo.Location = New System.Drawing.Point(94, 171)
        Me.t_addrVillageNo.Name = "t_addrVillageNo"
        Me.t_addrVillageNo.ReadOnly = True
        Me.t_addrVillageNo.Size = New System.Drawing.Size(75, 26)
        Me.t_addrVillageNo.TabIndex = 0
        Me.t_addrVillageNo.TabStop = False
        '
        't_addrLane
        '
        Me.t_addrLane.BackColor = System.Drawing.Color.White
        Me.t_addrLane.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrLane.Location = New System.Drawing.Point(6, 203)
        Me.t_addrLane.Name = "t_addrLane"
        Me.t_addrLane.ReadOnly = True
        Me.t_addrLane.Size = New System.Drawing.Size(163, 26)
        Me.t_addrLane.TabIndex = 0
        Me.t_addrLane.TabStop = False
        '
        't_addrRoad
        '
        Me.t_addrRoad.BackColor = System.Drawing.Color.White
        Me.t_addrRoad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrRoad.Location = New System.Drawing.Point(6, 235)
        Me.t_addrRoad.Name = "t_addrRoad"
        Me.t_addrRoad.ReadOnly = True
        Me.t_addrRoad.Size = New System.Drawing.Size(163, 26)
        Me.t_addrRoad.TabIndex = 0
        Me.t_addrRoad.TabStop = False
        '
        't_addrTambol
        '
        Me.t_addrTambol.BackColor = System.Drawing.Color.White
        Me.t_addrTambol.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrTambol.Location = New System.Drawing.Point(175, 171)
        Me.t_addrTambol.Name = "t_addrTambol"
        Me.t_addrTambol.ReadOnly = True
        Me.t_addrTambol.Size = New System.Drawing.Size(185, 26)
        Me.t_addrTambol.TabIndex = 0
        Me.t_addrTambol.TabStop = False
        '
        't_addrAmphur
        '
        Me.t_addrAmphur.BackColor = System.Drawing.Color.White
        Me.t_addrAmphur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrAmphur.Location = New System.Drawing.Point(175, 203)
        Me.t_addrAmphur.Name = "t_addrAmphur"
        Me.t_addrAmphur.ReadOnly = True
        Me.t_addrAmphur.Size = New System.Drawing.Size(185, 26)
        Me.t_addrAmphur.TabIndex = 0
        Me.t_addrAmphur.TabStop = False
        '
        't_addrProvince
        '
        Me.t_addrProvince.BackColor = System.Drawing.Color.White
        Me.t_addrProvince.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_addrProvince.Location = New System.Drawing.Point(175, 235)
        Me.t_addrProvince.Name = "t_addrProvince"
        Me.t_addrProvince.ReadOnly = True
        Me.t_addrProvince.Size = New System.Drawing.Size(185, 26)
        Me.t_addrProvince.TabIndex = 0
        Me.t_addrProvince.TabStop = False
        '
        't_PhotoRaw
        '
        Me.t_PhotoRaw.BackColor = System.Drawing.Color.White
        Me.t_PhotoRaw.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_PhotoRaw.Location = New System.Drawing.Point(366, 235)
        Me.t_PhotoRaw.Multiline = True
        Me.t_PhotoRaw.Name = "t_PhotoRaw"
        Me.t_PhotoRaw.ReadOnly = True
        Me.t_PhotoRaw.Size = New System.Drawing.Size(145, 26)
        Me.t_PhotoRaw.TabIndex = 0
        Me.t_PhotoRaw.TabStop = False
        '
        't_api
        '
        Me.t_api.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.t_api.BackColor = System.Drawing.Color.White
        Me.t_api.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_api.Location = New System.Drawing.Point(366, 305)
        Me.t_api.Name = "t_api"
        Me.t_api.ReadOnly = True
        Me.t_api.Size = New System.Drawing.Size(145, 26)
        Me.t_api.TabIndex = 0
        Me.t_api.TabStop = False
        '
        'cbReader
        '
        Me.cbReader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbReader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbReader.FormattingEnabled = True
        Me.cbReader.Location = New System.Drawing.Point(366, 335)
        Me.cbReader.Name = "cbReader"
        Me.cbReader.Size = New System.Drawing.Size(145, 26)
        Me.cbReader.TabIndex = 1
        Me.cbReader.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(366, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 186)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'readProgressBar
        '
        Me.readProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.readProgressBar.Location = New System.Drawing.Point(-1, 29)
        Me.readProgressBar.Name = "readProgressBar"
        Me.readProgressBar.Size = New System.Drawing.Size(521, 22)
        Me.readProgressBar.TabIndex = 3
        '
        'btnRead
        '
        Me.btnRead.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRead.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnRead.Location = New System.Drawing.Point(441, 367)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(70, 47)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reader"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'ckAutoRead
        '
        Me.ckAutoRead.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ckAutoRead.AutoSize = True
        Me.ckAutoRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ckAutoRead.Location = New System.Drawing.Point(366, 367)
        Me.ckAutoRead.Name = "ckAutoRead"
        Me.ckAutoRead.Size = New System.Drawing.Size(75, 17)
        Me.ckAutoRead.TabIndex = 4
        Me.ckAutoRead.TabStop = False
        Me.ckAutoRead.Text = "Auto Read"
        Me.ckAutoRead.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.readProgressBar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.t_Citizenid)
        Me.GroupBox1.Controls.Add(Me.t_Th_Prefix)
        Me.GroupBox1.Controls.Add(Me.t_Th_Firstname)
        Me.GroupBox1.Controls.Add(Me.t_En_Prefix)
        Me.GroupBox1.Controls.Add(Me.t_addrHouseNo)
        Me.GroupBox1.Controls.Add(Me.t_addrVillageNo)
        Me.GroupBox1.Controls.Add(Me.t_En_Lastname)
        Me.GroupBox1.Controls.Add(Me.t_addrLane)
        Me.GroupBox1.Controls.Add(Me.t_addrProvince)
        Me.GroupBox1.Controls.Add(Me.t_addrRoad)
        Me.GroupBox1.Controls.Add(Me.t_Expire)
        Me.GroupBox1.Controls.Add(Me.t_Sex)
        Me.GroupBox1.Controls.Add(Me.t_addrAmphur)
        Me.GroupBox1.Controls.Add(Me.t_Th_Lastname)
        Me.GroupBox1.Controls.Add(Me.t_Issue)
        Me.GroupBox1.Controls.Add(Me.t_En_Firstname)
        Me.GroupBox1.Controls.Add(Me.t_Birthday)
        Me.GroupBox1.Controls.Add(Me.t_PhotoRaw)
        Me.GroupBox1.Controls.Add(Me.t_addrTambol)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 273)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'tErr
        '
        Me.tErr.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tErr.Location = New System.Drawing.Point(4, 305)
        Me.tErr.Name = "tErr"
        Me.tErr.Size = New System.Drawing.Size(356, 109)
        Me.tErr.TabIndex = 6
        Me.tErr.TabStop = False
        Me.tErr.Text = ""
        '
        'tStatus
        '
        Me.tStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.tStatus.Font = New System.Drawing.Font("Tahoma", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tStatus.Location = New System.Drawing.Point(0, 0)
        Me.tStatus.Name = "tStatus"
        Me.tStatus.Size = New System.Drawing.Size(518, 56)
        Me.tStatus.TabIndex = 7
        Me.tStatus.Text = "Label1"
        Me.tStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't_Port
        '
        Me.t_Port.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.t_Port.BackColor = System.Drawing.Color.White
        Me.t_Port.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.t_Port.Location = New System.Drawing.Point(366, 388)
        Me.t_Port.MaxLength = 5
        Me.t_Port.Name = "t_Port"
        Me.t_Port.Size = New System.Drawing.Size(72, 26)
        Me.t_Port.TabIndex = 2
        Me.t_Port.Text = "8000"
        Me.t_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "damrong"
        '
        'frmReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 420)
        Me.Controls.Add(Me.tStatus)
        Me.Controls.Add(Me.ckAutoRead)
        Me.Controls.Add(Me.tErr)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.t_api)
        Me.Controls.Add(Me.t_Port)
        Me.Controls.Add(Me.cbReader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReader"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThaiNationalIDCard Json WebServiceHost"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t_Citizenid As TextBox
    Friend WithEvents t_Th_Prefix As TextBox
    Friend WithEvents t_Th_Firstname As TextBox
    Friend WithEvents t_Th_Lastname As TextBox
    Friend WithEvents t_En_Prefix As TextBox
    Friend WithEvents t_En_Firstname As TextBox
    Friend WithEvents t_En_Lastname As TextBox
    Friend WithEvents t_Sex As TextBox
    Friend WithEvents t_Birthday As TextBox
    Friend WithEvents t_Issue As TextBox
    Friend WithEvents t_Expire As TextBox
    Friend WithEvents t_addrHouseNo As TextBox
    Friend WithEvents t_addrVillageNo As TextBox
    Friend WithEvents t_addrLane As TextBox
    Friend WithEvents t_addrRoad As TextBox
    Friend WithEvents t_addrTambol As TextBox
    Friend WithEvents t_addrAmphur As TextBox
    Friend WithEvents t_addrProvince As TextBox
    Friend WithEvents t_PhotoRaw As TextBox
    Friend WithEvents t_api As TextBox
    Friend WithEvents cbReader As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents readProgressBar As ProgressBar
    Friend WithEvents btnRead As Button
    Friend WithEvents ckAutoRead As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tErr As RichTextBox
    Friend WithEvents tStatus As Label
    Friend WithEvents t_Port As TextBox
    Friend WithEvents Label1 As Label
End Class
