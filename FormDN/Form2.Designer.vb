<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tpPhongBan
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
        Me.txtMaPB = New System.Windows.Forms.TextBox()
        Me.txtTenPB = New System.Windows.Forms.TextBox()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.btnThemPB = New System.Windows.Forms.Button()
        Me.btnSuaPB = New System.Windows.Forms.Button()
        Me.btnXoaPB = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvPhongBan = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPhongBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã phòng ban"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên phòng ban"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mô tả"
        '
        'txtMaPB
        '
        Me.txtMaPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaPB.Location = New System.Drawing.Point(150, 53)
        Me.txtMaPB.Multiline = True
        Me.txtMaPB.Name = "txtMaPB"
        Me.txtMaPB.Size = New System.Drawing.Size(328, 30)
        Me.txtMaPB.TabIndex = 1
        '
        'txtTenPB
        '
        Me.txtTenPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenPB.Location = New System.Drawing.Point(150, 111)
        Me.txtTenPB.Multiline = True
        Me.txtTenPB.Name = "txtTenPB"
        Me.txtTenPB.Size = New System.Drawing.Size(328, 30)
        Me.txtTenPB.TabIndex = 1
        '
        'txtMoTa
        '
        Me.txtMoTa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoTa.Location = New System.Drawing.Point(150, 172)
        Me.txtMoTa.Multiline = True
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(328, 30)
        Me.txtMoTa.TabIndex = 1
        '
        'btnThemPB
        '
        Me.btnThemPB.Location = New System.Drawing.Point(58, 233)
        Me.btnThemPB.Name = "btnThemPB"
        Me.btnThemPB.Size = New System.Drawing.Size(75, 23)
        Me.btnThemPB.TabIndex = 2
        Me.btnThemPB.Text = "Thêm"
        Me.btnThemPB.UseVisualStyleBackColor = True
        '
        'btnSuaPB
        '
        Me.btnSuaPB.Location = New System.Drawing.Point(150, 233)
        Me.btnSuaPB.Name = "btnSuaPB"
        Me.btnSuaPB.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaPB.TabIndex = 2
        Me.btnSuaPB.Text = "Sửa"
        Me.btnSuaPB.UseVisualStyleBackColor = True
        '
        'btnXoaPB
        '
        Me.btnXoaPB.Location = New System.Drawing.Point(243, 233)
        Me.btnXoaPB.Name = "btnXoaPB"
        Me.btnXoaPB.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaPB.TabIndex = 2
        Me.btnXoaPB.Text = "Xoá"
        Me.btnXoaPB.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(468, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Thoát"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgvPhongBan
        '
        Me.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhongBan.Location = New System.Drawing.Point(49, 262)
        Me.dgvPhongBan.Name = "dgvPhongBan"
        Me.dgvPhongBan.Size = New System.Drawing.Size(452, 169)
        Me.dgvPhongBan.TabIndex = 3
        '
        'tpPhongBan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 484)
        Me.Controls.Add(Me.dgvPhongBan)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnXoaPB)
        Me.Controls.Add(Me.btnSuaPB)
        Me.Controls.Add(Me.btnThemPB)
        Me.Controls.Add(Me.txtMoTa)
        Me.Controls.Add(Me.txtTenPB)
        Me.Controls.Add(Me.txtMaPB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tpPhongBan"
        Me.Text = "QUẢN LÝ PHÒNG BAN"
        CType(Me.dgvPhongBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaPB As TextBox
    Friend WithEvents txtTenPB As TextBox
    Friend WithEvents txtMoTa As TextBox
    Friend WithEvents btnThemPB As Button
    Friend WithEvents btnSuaPB As Button
    Friend WithEvents btnXoaPB As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvPhongBan As DataGridView
End Class
