<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        TxtNIP = New TextBox()
        CmbBagian = New ComboBox()
        RBblmkwn = New RadioButton()
        RBkwn = New RadioButton()
        DateTglLhr = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        BtnExit = New Button()
        BtnCancel = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        BtnSave = New Button()
        TxtNama = New TextBox()
        TxtAlamat = New TextBox()
        CmbPendidikan = New ComboBox()
        BtnCari = New Button()
        BtnList = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' TxtNIP
        ' 
        TxtNIP.Location = New Point(179, 44)
        TxtNIP.Name = "TxtNIP"
        TxtNIP.Size = New Size(119, 23)
        TxtNIP.TabIndex = 1
        ' 
        ' CmbBagian
        ' 
        CmbBagian.FormattingEnabled = True
        CmbBagian.Location = New Point(177, 131)
        CmbBagian.Name = "CmbBagian"
        CmbBagian.Size = New Size(121, 23)
        CmbBagian.TabIndex = 2
        ' 
        ' RBblmkwn
        ' 
        RBblmkwn.AutoSize = True
        RBblmkwn.Location = New Point(179, 375)
        RBblmkwn.Name = "RBblmkwn"
        RBblmkwn.Size = New Size(108, 19)
        RBblmkwn.TabIndex = 3
        RBblmkwn.TabStop = True
        RBblmkwn.Text = "Belum Menikah"
        RBblmkwn.UseVisualStyleBackColor = True
        ' 
        ' RBkwn
        ' 
        RBkwn.AutoSize = True
        RBkwn.Location = New Point(331, 375)
        RBkwn.Name = "RBkwn"
        RBkwn.Size = New Size(107, 19)
        RBkwn.TabIndex = 4
        RBkwn.TabStop = True
        RBkwn.Text = "Sudah Menikah"
        RBkwn.UseVisualStyleBackColor = True
        ' 
        ' DateTglLhr
        ' 
        DateTglLhr.Location = New Point(177, 175)
        DateTglLhr.Name = "DateTglLhr"
        DateTglLhr.Size = New Size(200, 23)
        DateTglLhr.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nama Pegawai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 7
        Label3.Text = "Bagian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 8
        Label4.Text = "Tgl Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 9
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(36, 320)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 10
        Label6.Text = "Pendidikan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 374)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 11
        Label7.Text = "Status"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnExit)
        GroupBox1.Controls.Add(BtnCancel)
        GroupBox1.Controls.Add(BtnDelete)
        GroupBox1.Controls.Add(BtnEdit)
        GroupBox1.Controls.Add(BtnSave)
        GroupBox1.Location = New Point(575, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(138, 332)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Control Panel"
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(34, 279)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(75, 23)
        BtnExit.TabIndex = 4
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(34, 119)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(75, 23)
        BtnCancel.TabIndex = 3
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(34, 89)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(34, 60)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(75, 23)
        BtnEdit.TabIndex = 1
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(34, 31)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 0
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(179, 85)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(119, 23)
        TxtNama.TabIndex = 13
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(177, 217)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(269, 87)
        TxtAlamat.TabIndex = 14
        ' 
        ' CmbPendidikan
        ' 
        CmbPendidikan.FormattingEnabled = True
        CmbPendidikan.Location = New Point(179, 317)
        CmbPendidikan.Name = "CmbPendidikan"
        CmbPendidikan.Size = New Size(121, 23)
        CmbPendidikan.TabIndex = 15
        ' 
        ' BtnCari
        ' 
        BtnCari.Location = New Point(321, 44)
        BtnCari.Name = "BtnCari"
        BtnCari.Size = New Size(75, 23)
        BtnCari.TabIndex = 16
        BtnCari.Text = "Cari"
        BtnCari.UseVisualStyleBackColor = True
        ' 
        ' BtnList
        ' 
        BtnList.Location = New Point(411, 43)
        BtnList.Name = "BtnList"
        BtnList.Size = New Size(48, 23)
        BtnList.TabIndex = 17
        BtnList.Text = ". . . "
        BtnList.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnList)
        Controls.Add(BtnCari)
        Controls.Add(CmbPendidikan)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtNama)
        Controls.Add(GroupBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DateTglLhr)
        Controls.Add(RBkwn)
        Controls.Add(RBblmkwn)
        Controls.Add(CmbBagian)
        Controls.Add(TxtNIP)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Data Pegawai"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNIP As TextBox
    Friend WithEvents CmbBagian As ComboBox
    Friend WithEvents RBblmkwn As RadioButton
    Friend WithEvents RBkwn As RadioButton
    Friend WithEvents DateTglLhr As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CmbPendidikan As ComboBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnCari As Button
    Friend WithEvents BtnList As Button

End Class
