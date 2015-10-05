<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fsStudent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_studentid = New System.Windows.Forms.TextBox()
        Me.txt_StudentName = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.txt_classid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_nhaplai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sutdent ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sutdent Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'txt_studentid
        '
        Me.txt_studentid.Location = New System.Drawing.Point(109, 24)
        Me.txt_studentid.Name = "txt_studentid"
        Me.txt_studentid.Size = New System.Drawing.Size(147, 20)
        Me.txt_studentid.TabIndex = 4
        '
        'txt_StudentName
        '
        Me.txt_StudentName.Location = New System.Drawing.Point(109, 54)
        Me.txt_StudentName.Name = "txt_StudentName"
        Me.txt_StudentName.Size = New System.Drawing.Size(147, 20)
        Me.txt_StudentName.TabIndex = 5
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(109, 89)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(147, 20)
        Me.txt_phone.TabIndex = 6
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(109, 119)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(147, 20)
        Me.txt_address.TabIndex = 7
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(56, 201)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(75, 23)
        Me.btn_addnew.TabIndex = 8
        Me.btn_addnew.Text = "OK"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'txt_classid
        '
        Me.txt_classid.Location = New System.Drawing.Point(109, 145)
        Me.txt_classid.Name = "txt_classid"
        Me.txt_classid.Size = New System.Drawing.Size(147, 20)
        Me.txt_classid.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Class ID:"
        '
        'btn_nhaplai
        '
        Me.btn_nhaplai.Location = New System.Drawing.Point(168, 201)
        Me.btn_nhaplai.Name = "btn_nhaplai"
        Me.btn_nhaplai.Size = New System.Drawing.Size(75, 23)
        Me.btn_nhaplai.TabIndex = 8
        Me.btn_nhaplai.Text = "Cancel"
        Me.btn_nhaplai.UseVisualStyleBackColor = True
        '
        'fsStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txt_classid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_nhaplai)
        Me.Controls.Add(Me.btn_addnew)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_StudentName)
        Me.Controls.Add(Me.txt_studentid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fsStudent"
        Me.Text = "fsStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_studentid As System.Windows.Forms.TextBox
    Friend WithEvents txt_StudentName As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents txt_classid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_nhaplai As System.Windows.Forms.Button
End Class
