<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tpHopDong
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
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtLuong = New System.Windows.Forms.TextBox()
        Me.cboLoaiHD = New System.Windows.Forms.ComboBox()
        Me.dtpBatDau = New System.Windows.Forms.DateTimePicker()
        Me.dtpKetThuc = New System.Windows.Forms.DateTimePicker()
        Me.dgvHopDong = New System.Windows.Forms.DataGridView()
        Me.btnThemHD = New System.Windows.Forms.Button()
        Me.bttnSuaHD = New System.Windows.Forms.Button()
        Me.btnXoaHD = New System.Windows.Forms.Button()
        CType(Me.dgvHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hợp đồng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã nhân viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Loại hợp đồng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ngày bắt đầu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Lương cơ bản"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ngày kết thúc"
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.Location = New System.Drawing.Point(123, 44)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(438, 21)
        Me.txtMaHD.TabIndex = 1
        '
        'txtMaNV
        '
        Me.txtMaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(123, 79)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(438, 21)
        Me.txtMaNV.TabIndex = 1
        '
        'txtLuong
        '
        Me.txtLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuong.Location = New System.Drawing.Point(123, 191)
        Me.txtLuong.Name = "txtLuong"
        Me.txtLuong.Size = New System.Drawing.Size(166, 21)
        Me.txtLuong.TabIndex = 1
        '
        'cboLoaiHD
        '
        Me.cboLoaiHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoaiHD.FormattingEnabled = True
        Me.cboLoaiHD.Location = New System.Drawing.Point(123, 116)
        Me.cboLoaiHD.Name = "cboLoaiHD"
        Me.cboLoaiHD.Size = New System.Drawing.Size(121, 23)
        Me.cboLoaiHD.TabIndex = 2
        '
        'dtpBatDau
        '
        Me.dtpBatDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBatDau.Location = New System.Drawing.Point(123, 155)
        Me.dtpBatDau.Name = "dtpBatDau"
        Me.dtpBatDau.Size = New System.Drawing.Size(142, 21)
        Me.dtpBatDau.TabIndex = 3
        '
        'dtpKetThuc
        '
        Me.dtpKetThuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKetThuc.Location = New System.Drawing.Point(407, 155)
        Me.dtpKetThuc.Name = "dtpKetThuc"
        Me.dtpKetThuc.Size = New System.Drawing.Size(143, 21)
        Me.dtpKetThuc.TabIndex = 3
        '
        'dgvHopDong
        '
        Me.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHopDong.Location = New System.Drawing.Point(40, 273)
        Me.dgvHopDong.Name = "dgvHopDong"
        Me.dgvHopDong.Size = New System.Drawing.Size(536, 191)
        Me.dgvHopDong.TabIndex = 4
        '
        'btnThemHD
        '
        Me.btnThemHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemHD.Location = New System.Drawing.Point(80, 232)
        Me.btnThemHD.Name = "btnThemHD"
        Me.btnThemHD.Size = New System.Drawing.Size(75, 23)
        Me.btnThemHD.TabIndex = 5
        Me.btnThemHD.Text = "Thêm"
        Me.btnThemHD.UseVisualStyleBackColor = True
        '
        'bttnSuaHD
        '
        Me.bttnSuaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuaHD.Location = New System.Drawing.Point(169, 232)
        Me.bttnSuaHD.Name = "bttnSuaHD"
        Me.bttnSuaHD.Size = New System.Drawing.Size(75, 23)
        Me.bttnSuaHD.TabIndex = 5
        Me.bttnSuaHD.Text = "Sửa"
        Me.bttnSuaHD.UseVisualStyleBackColor = True
        '
        'btnXoaHD
        '
        Me.btnXoaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaHD.Location = New System.Drawing.Point(260, 232)
        Me.btnXoaHD.Name = "btnXoaHD"
        Me.btnXoaHD.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaHD.TabIndex = 5
        Me.btnXoaHD.Text = "Xoá"
        Me.btnXoaHD.UseVisualStyleBackColor = True
        '
        'tpHopDong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 508)
        Me.Controls.Add(Me.btnXoaHD)
        Me.Controls.Add(Me.bttnSuaHD)
        Me.Controls.Add(Me.btnThemHD)
        Me.Controls.Add(Me.dgvHopDong)
        Me.Controls.Add(Me.dtpKetThuc)
        Me.Controls.Add(Me.dtpBatDau)
        Me.Controls.Add(Me.cboLoaiHD)
        Me.Controls.Add(Me.txtLuong)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tpHopDong"
        Me.Text = "QUẢN LÝ HỢP ĐỒNG"
        CType(Me.dgvHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents txtLuong As TextBox
    Friend WithEvents cboLoaiHD As ComboBox
    Friend WithEvents dtpBatDau As DateTimePicker
    Friend WithEvents dtpKetThuc As DateTimePicker
    Friend WithEvents dgvHopDong As DataGridView
    Friend WithEvents btnThemHD As Button
    Friend WithEvents bttnSuaHD As Button
    Friend WithEvents btnXoaHD As Button
End Class
