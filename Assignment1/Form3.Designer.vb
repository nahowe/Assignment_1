<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.CourseGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClassInstructorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClassroomTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClassTimeTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentMajorTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StudentFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InstructorGroupBox = New System.Windows.Forms.GroupBox()
        Me.InstructorLastTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InstructorFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.InstructorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StudentAgeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentGradeLevelTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CourseGroupBox.SuspendLayout()
        Me.StudentGroupBox.SuspendLayout()
        Me.InstructorGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CourseGroupBox
        '
        Me.CourseGroupBox.BackColor = System.Drawing.SystemColors.GrayText
        Me.CourseGroupBox.Controls.Add(Me.ClassInstructorIDTextBox)
        Me.CourseGroupBox.Controls.Add(Me.Label1)
        Me.CourseGroupBox.Controls.Add(Me.ClassroomTextBox)
        Me.CourseGroupBox.Controls.Add(Me.Label11)
        Me.CourseGroupBox.Controls.Add(Me.ClassTimeTextBox)
        Me.CourseGroupBox.Controls.Add(Me.ClassNameTextBox)
        Me.CourseGroupBox.Controls.Add(Me.Label3)
        Me.CourseGroupBox.Controls.Add(Me.Label2)
        Me.CourseGroupBox.ForeColor = System.Drawing.Color.LightGreen
        Me.CourseGroupBox.Location = New System.Drawing.Point(630, 12)
        Me.CourseGroupBox.Name = "CourseGroupBox"
        Me.CourseGroupBox.Size = New System.Drawing.Size(238, 211)
        Me.CourseGroupBox.TabIndex = 29
        Me.CourseGroupBox.TabStop = False
        Me.CourseGroupBox.Text = "Class"
        '
        'ClassInstructorIDTextBox
        '
        Me.ClassInstructorIDTextBox.Enabled = False
        Me.ClassInstructorIDTextBox.Location = New System.Drawing.Point(114, 101)
        Me.ClassInstructorIDTextBox.Name = "ClassInstructorIDTextBox"
        Me.ClassInstructorIDTextBox.ReadOnly = True
        Me.ClassInstructorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassInstructorIDTextBox.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Instructor ID:"
        '
        'ClassroomTextBox
        '
        Me.ClassroomTextBox.Location = New System.Drawing.Point(114, 75)
        Me.ClassroomTextBox.Name = "ClassroomTextBox"
        Me.ClassroomTextBox.ReadOnly = True
        Me.ClassroomTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassroomTextBox.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Classroom:"
        '
        'ClassTimeTextBox
        '
        Me.ClassTimeTextBox.Enabled = False
        Me.ClassTimeTextBox.Location = New System.Drawing.Point(114, 49)
        Me.ClassTimeTextBox.Name = "ClassTimeTextBox"
        Me.ClassTimeTextBox.ReadOnly = True
        Me.ClassTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassTimeTextBox.TabIndex = 16
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.Location = New System.Drawing.Point(114, 23)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassNameTextBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Class Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Class Time:"
        '
        'StudentGroupBox
        '
        Me.StudentGroupBox.BackColor = System.Drawing.SystemColors.GrayText
        Me.StudentGroupBox.Controls.Add(Me.StudentAgeTextBox)
        Me.StudentGroupBox.Controls.Add(Me.StudentGradeLevelTextBox)
        Me.StudentGroupBox.Controls.Add(Me.Label13)
        Me.StudentGroupBox.Controls.Add(Me.Label14)
        Me.StudentGroupBox.Controls.Add(Me.StudentMajorTextBox)
        Me.StudentGroupBox.Controls.Add(Me.Label4)
        Me.StudentGroupBox.Controls.Add(Me.StudentLastNameTextBox)
        Me.StudentGroupBox.Controls.Add(Me.Label5)
        Me.StudentGroupBox.Controls.Add(Me.StudentFirstNameTextBox)
        Me.StudentGroupBox.Controls.Add(Me.StudentIDTextBox)
        Me.StudentGroupBox.Controls.Add(Me.Label6)
        Me.StudentGroupBox.Controls.Add(Me.Label7)
        Me.StudentGroupBox.ForeColor = System.Drawing.Color.LightGreen
        Me.StudentGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StudentGroupBox.Name = "StudentGroupBox"
        Me.StudentGroupBox.Size = New System.Drawing.Size(238, 211)
        Me.StudentGroupBox.TabIndex = 30
        Me.StudentGroupBox.TabStop = False
        Me.StudentGroupBox.Text = "Student"
        '
        'StudentMajorTextBox
        '
        Me.StudentMajorTextBox.Enabled = False
        Me.StudentMajorTextBox.Location = New System.Drawing.Point(114, 101)
        Me.StudentMajorTextBox.Name = "StudentMajorTextBox"
        Me.StudentMajorTextBox.ReadOnly = True
        Me.StudentMajorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentMajorTextBox.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Major:"
        '
        'StudentLastNameTextBox
        '
        Me.StudentLastNameTextBox.Location = New System.Drawing.Point(114, 75)
        Me.StudentLastNameTextBox.Name = "StudentLastNameTextBox"
        Me.StudentLastNameTextBox.ReadOnly = True
        Me.StudentLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentLastNameTextBox.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Last Name:"
        '
        'StudentFirstNameTextBox
        '
        Me.StudentFirstNameTextBox.Enabled = False
        Me.StudentFirstNameTextBox.Location = New System.Drawing.Point(114, 49)
        Me.StudentFirstNameTextBox.Name = "StudentFirstNameTextBox"
        Me.StudentFirstNameTextBox.ReadOnly = True
        Me.StudentFirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentFirstNameTextBox.TabIndex = 16
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.Location = New System.Drawing.Point(114, 23)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Student ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "First Name:"
        '
        'InstructorGroupBox
        '
        Me.InstructorGroupBox.BackColor = System.Drawing.SystemColors.GrayText
        Me.InstructorGroupBox.Controls.Add(Me.InstructorLastTextBox)
        Me.InstructorGroupBox.Controls.Add(Me.Label9)
        Me.InstructorGroupBox.Controls.Add(Me.InstructorFirstNameTextBox)
        Me.InstructorGroupBox.Controls.Add(Me.InstructorIDTextBox)
        Me.InstructorGroupBox.Controls.Add(Me.Label10)
        Me.InstructorGroupBox.Controls.Add(Me.Label12)
        Me.InstructorGroupBox.ForeColor = System.Drawing.Color.LightGreen
        Me.InstructorGroupBox.Location = New System.Drawing.Point(321, 12)
        Me.InstructorGroupBox.Name = "InstructorGroupBox"
        Me.InstructorGroupBox.Size = New System.Drawing.Size(238, 211)
        Me.InstructorGroupBox.TabIndex = 31
        Me.InstructorGroupBox.TabStop = False
        Me.InstructorGroupBox.Text = "Instructor"
        '
        'InstructorLastTextBox
        '
        Me.InstructorLastTextBox.Location = New System.Drawing.Point(114, 75)
        Me.InstructorLastTextBox.Name = "InstructorLastTextBox"
        Me.InstructorLastTextBox.ReadOnly = True
        Me.InstructorLastTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorLastTextBox.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Last Name:"
        '
        'InstructorFirstNameTextBox
        '
        Me.InstructorFirstNameTextBox.Enabled = False
        Me.InstructorFirstNameTextBox.Location = New System.Drawing.Point(114, 49)
        Me.InstructorFirstNameTextBox.Name = "InstructorFirstNameTextBox"
        Me.InstructorFirstNameTextBox.ReadOnly = True
        Me.InstructorFirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorFirstNameTextBox.TabIndex = 16
        '
        'InstructorIDTextBox
        '
        Me.InstructorIDTextBox.Location = New System.Drawing.Point(114, 23)
        Me.InstructorIDTextBox.Name = "InstructorIDTextBox"
        Me.InstructorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorIDTextBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Instructor ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "First Name:"
        '
        'StudentAgeTextBox
        '
        Me.StudentAgeTextBox.Enabled = False
        Me.StudentAgeTextBox.Location = New System.Drawing.Point(114, 154)
        Me.StudentAgeTextBox.Name = "StudentAgeTextBox"
        Me.StudentAgeTextBox.ReadOnly = True
        Me.StudentAgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAgeTextBox.TabIndex = 46
        '
        'StudentGradeLevelTextBox
        '
        Me.StudentGradeLevelTextBox.Location = New System.Drawing.Point(114, 128)
        Me.StudentGradeLevelTextBox.Name = "StudentGradeLevelTextBox"
        Me.StudentGradeLevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentGradeLevelTextBox.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Grade Level:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Age:"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(389, 306)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(103, 28)
        Me.SubmitButton.TabIndex = 42
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 414)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.InstructorGroupBox)
        Me.Controls.Add(Me.StudentGroupBox)
        Me.Controls.Add(Me.CourseGroupBox)
        Me.Name = "Form3"
        Me.Text = "Insert Page"
        Me.CourseGroupBox.ResumeLayout(False)
        Me.CourseGroupBox.PerformLayout()
        Me.StudentGroupBox.ResumeLayout(False)
        Me.StudentGroupBox.PerformLayout()
        Me.InstructorGroupBox.ResumeLayout(False)
        Me.InstructorGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CourseGroupBox As GroupBox
    Friend WithEvents ClassInstructorIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClassroomTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ClassTimeTextBox As TextBox
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentGroupBox As GroupBox
    Friend WithEvents StudentAgeTextBox As TextBox
    Friend WithEvents StudentGradeLevelTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents StudentMajorTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StudentLastNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StudentFirstNameTextBox As TextBox
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents InstructorGroupBox As GroupBox
    Friend WithEvents InstructorLastTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents InstructorFirstNameTextBox As TextBox
    Friend WithEvents InstructorIDTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SubmitButton As Button
End Class
