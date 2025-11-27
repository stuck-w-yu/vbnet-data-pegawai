<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poppeg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnOK = New Button()
        TxtCari = New TextBox()
        TxtCounter = New TextBox()
        Label1 = New Label()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' BtnOK
        ' 
        BtnOK.Location = New Point(678, 405)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(75, 23)
        BtnOK.TabIndex = 0
        BtnOK.Text = "OK"
        BtnOK.UseVisualStyleBackColor = True
        ' 
        ' TxtCari
        ' 
        TxtCari.Location = New Point(119, 46)
        TxtCari.Name = "TxtCari"
        TxtCari.Size = New Size(228, 23)
        TxtCari.TabIndex = 1
        ' 
        ' TxtCounter
        ' 
        TxtCounter.Location = New Point(49, 406)
        TxtCounter.Name = "TxtCounter"
        TxtCounter.ReadOnly = True
        TxtCounter.Size = New Size(60, 23)
        TxtCounter.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 3
        Label1.Text = "Cari"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(49, 86)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(704, 304)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' poppeg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Controls.Add(TxtCounter)
        Controls.Add(TxtCari)
        Controls.Add(BtnOK)
        Name = "poppeg"
        Text = "poppeg"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents TxtCounter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
End Class
