<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnMyBio = New Button()
        txtName = New TextBox()
        txtYearyouwereborn = New TextBox()
        txtSurname = New TextBox()
        txtTribe = New TextBox()
        txtGender = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnMyBio
        ' 
        btnMyBio.BackColor = Color.DarkSalmon
        btnMyBio.Location = New Point(246, 368)
        btnMyBio.Name = "btnMyBio"
        btnMyBio.Size = New Size(356, 70)
        btnMyBio.TabIndex = 0
        btnMyBio.Text = "My Bio"
        btnMyBio.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(452, 59)
        txtName.Name = "txtName"
        txtName.Size = New Size(212, 31)
        txtName.TabIndex = 1
        ' 
        ' txtYearyouwereborn
        ' 
        txtYearyouwereborn.Location = New Point(452, 167)
        txtYearyouwereborn.Name = "txtYearyouwereborn"
        txtYearyouwereborn.Size = New Size(212, 31)
        txtYearyouwereborn.TabIndex = 1
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(452, 119)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(212, 31)
        txtSurname.TabIndex = 1
        ' 
        ' txtTribe
        ' 
        txtTribe.Location = New Point(452, 219)
        txtTribe.Name = "txtTribe"
        txtTribe.Size = New Size(212, 31)
        txtTribe.TabIndex = 1
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(452, 268)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(212, 31)
        txtGender.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(246, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(246, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 2
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(246, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 25)
        Label3.TabIndex = 2
        Label3.Text = "Year you were born"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(246, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 2
        Label4.Text = "Tribe"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(246, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 2
        Label5.Text = "Gender"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSurname)
        Controls.Add(txtGender)
        Controls.Add(txtTribe)
        Controls.Add(txtYearyouwereborn)
        Controls.Add(txtName)
        Controls.Add(btnMyBio)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMyBio As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYearyouwereborn As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
