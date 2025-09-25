<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tpNhanVien
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.btnThemNV = New System.Windows.Forms.Button()
        Me.btnSuaNV = New System.Windows.Forms.Button()
        Me.btnXoaNV = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.cboPhongBan = New System.Windows.Forms.ComboBox()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã nhân viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nơi sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số điện thoại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Giới tính"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(317, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã phòng ban"
        '
        'txtMaNV
        '
        Me.txtMaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(134, 35)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(384, 21)
        Me.txtMaNV.TabIndex = 1
        '
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(134, 73)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(384, 21)
        Me.txtHoTen.TabIndex = 1
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(134, 156)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(384, 21)
        Me.txtDiaChi.TabIndex = 1
        '
        'txtSoDT
        '
        Me.txtSoDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDT.Location = New System.Drawing.Point(134, 200)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(159, 21)
        Me.txtSoDT.TabIndex = 1
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.Location = New System.Drawing.Point(131, 110)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(162, 21)
        Me.dtpNgaySinh.TabIndex = 2
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Location = New System.Drawing.Point(397, 113)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(121, 23)
        Me.cboGioiTinh.TabIndex = 3
        '
        'btnThemNV
        '
        Me.btnThemNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNV.Location = New System.Drawing.Point(47, 245)
        Me.btnThemNV.Name = "btnThemNV"
        Me.btnThemNV.Size = New System.Drawing.Size(75, 23)
        Me.btnThemNV.TabIndex = 4
        Me.btnThemNV.Text = "Thêm "
        Me.btnThemNV.UseVisualStyleBackColor = True
        '
        'btnSuaNV
        '
        Me.btnSuaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaNV.Location = New System.Drawing.Point(134, 245)
        Me.btnSuaNV.Name = "btnSuaNV"
        Me.btnSuaNV.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaNV.TabIndex = 4
        Me.btnSuaNV.Text = "Sửa "
        Me.btnSuaNV.UseVisualStyleBackColor = True
        '
        'btnXoaNV
        '
        Me.btnXoaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaNV.Location = New System.Drawing.Point(227, 245)
        Me.btnXoaNV.Name = "btnXoaNV"
        Me.btnXoaNV.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaNV.TabIndex = 4
        Me.btnXoaNV.Text = "Xoá"
        Me.btnXoaNV.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(480, 450)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Thoát"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Location = New System.Drawing.Point(47, 274)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.Size = New System.Drawing.Size(471, 170)
        Me.dgvNhanVien.TabIndex = 5
        '
        'cboPhongBan
        '
        Me.cboPhongBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhongBan.FormattingEnabled = True
        Me.cboPhongBan.Location = New System.Drawing.Point(410, 200)
        Me.cboPhongBan.Name = "cboPhongBan"
        Me.cboPhongBan.Size = New System.Drawing.Size(108, 23)
        Me.cboPhongBan.TabIndex = 3
        '
        'tpNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 485)
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnXoaNV)
        Me.Controls.Add(Me.btnSuaNV)
        Me.Controls.Add(Me.btnThemNV)
        Me.Controls.Add(Me.cboPhongBan)
        Me.Controls.Add(Me.cboGioiTinh)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.txtSoDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "tpNhanVien"
        Me.Text = "QUẢN LÝ NHÂN VIÊN"
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSoDT As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents btnThemNV As Button
    Friend WithEvents btnSuaNV As Button
    Friend WithEvents btnXoaNV As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvNhanVien As DataGridView
    Friend WithEvents cboPhongBan As ComboBox
End Class
