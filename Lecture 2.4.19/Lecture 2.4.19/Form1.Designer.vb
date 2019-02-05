<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(40, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(132, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Enter Your Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.Window
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(31, 43)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(156, 24)
        Me.txtInput.TabIndex = 1
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(71, 86)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 20)
        Me.lblGreeting.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(669, 510)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 44)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Location = New System.Drawing.Point(75, 134)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(70, 44)
        Me.btnShowGreeting.TabIndex = 5
        Me.btnShowGreeting.Text = "Show Greeting"
        Me.btnShowGreeting.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShowGreeting)
        Me.GroupBox1.Controls.Add(Me.lblGreeting)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 260)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.lblSum)
        Me.GroupBox2.Controls.Add(Me.txtSum)
        Me.GroupBox2.Controls.Add(Me.txtSecond)
        Me.GroupBox2.Controls.Add(Me.lblSecond)
        Me.GroupBox2.Controls.Add(Me.txtFirst)
        Me.GroupBox2.Controls.Add(Me.lblFirst)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 280)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(25, 165)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(42, 20)
        Me.lblSum.TabIndex = 14
        Me.lblSum.Text = "Sum"
        '
        'txtSum
        '
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSum.Location = New System.Drawing.Point(103, 165)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(147, 24)
        Me.txtSum.TabIndex = 13
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(103, 98)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(147, 24)
        Me.txtSecond.TabIndex = 12
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(25, 102)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(64, 20)
        Me.lblSecond.TabIndex = 11
        Me.lblSecond.Text = "Second"
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(103, 37)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(147, 24)
        Me.txtFirst.TabIndex = 10
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(25, 37)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(40, 20)
        Me.lblFirst.TabIndex = 9
        Me.lblFirst.Text = "First"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(126, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 44)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClearAdd
        '
        Me.btnClearAdd.Location = New System.Drawing.Point(272, 421)
        Me.btnClearAdd.Name = "btnClearAdd"
        Me.btnClearAdd.Size = New System.Drawing.Size(98, 44)
        Me.btnClearAdd.TabIndex = 16
        Me.btnClearAdd.Text = "Clear"
        Me.btnClearAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 638)
        Me.Controls.Add(Me.btnClearAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "Greeting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShowGreeting As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClearAdd As System.Windows.Forms.Button

End Class
