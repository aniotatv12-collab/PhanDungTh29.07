Imports System.Data.SqlClient

Public Class FrmMain
    Inherits Form

    Dim connectionString As String = "Data Source=DESKTOP-683UULO;Initial Catalog=QUANLYNHANSU;Integrated Security=True"
    Dim conn As SqlConnection


    Dim tab As New TabControl()
    Dim tpLogin, tpPhongBan, tpNhanVien, tpHopDong As New TabPage()


    Dim txtUser As New TextBox()
    Dim txtPass As New TextBox()
    Dim btnLogin As New Button()


    Dim txtMaPB, txtTenPB, txtMoTa As New TextBox()
    Dim dgvPhongBan As New DataGridView()
    Dim btnThemPB, btnSuaPB, btnXoaPB As New Button()


    Dim txtMaNV, txtHoTen, txtDiaChi, txtSoDT As New TextBox()
    Dim dtpNgaySinh As New DateTimePicker()
    Dim cboGioiTinh As New ComboBox()
    Dim cboPhongBan As New ComboBox()
    Dim dgvNhanVien As New DataGridView()
    Dim btnThemNV, btnSuaNV, btnXoaNV As New Button()


    Dim txtMaHD, txtLuong As New TextBox()
    Dim cboLoaiHD As New ComboBox()
    Dim cboNhanVien As New ComboBox()
    Dim dtpBatDau, dtpKetThuc As New DateTimePicker()
    Dim dgvHopDong As New DataGridView()
    Dim btnThemHD, btnSuaHD, btnXoaHD As New Button()


    Private Sub OpenConnection()
        If conn Is Nothing Then conn = New SqlConnection(connectionString)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub


    Private Sub LoadComboPhongBan()
        OpenConnection()
        Dim da As New SqlDataAdapter("SELECT * FROM PhongBan", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        cboPhongBan.DataSource = dt
        cboPhongBan.DisplayMember = "TenPB"
        cboPhongBan.ValueMember = "MaPB"
        conn.Close()
    End Sub

    Private Sub LoadComboNhanVien()
        OpenConnection()
        Dim da As New SqlDataAdapter("SELECT * FROM NhanVien", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        cboNhanVien.DataSource = dt
        cboNhanVien.DisplayMember = "HoTen"
        cboNhanVien.ValueMember = "MaNV"
        conn.Close()
    End Sub


    Private Sub LoadPhongBan()
        OpenConnection()
        Dim da As New SqlDataAdapter("SELECT * FROM PhongBan", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvPhongBan.DataSource = dt
        conn.Close()
    End Sub

    Private Sub LoadNhanVien()
        OpenConnection()
        Dim da As New SqlDataAdapter("SELECT * FROM NhanVien", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvNhanVien.DataSource = dt
        conn.Close()
    End Sub

    Private Sub LoadHopDong()
        OpenConnection()
        Dim da As New SqlDataAdapter("SELECT * FROM HopDong", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvHopDong.DataSource = dt
        conn.Close()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        OpenConnection()
        Dim cmd As New SqlCommand("SELECT * FROM Users WHERE Username=@u AND Password=@p", conn)
        cmd.Parameters.AddWithValue("@u", txtUser.Text)
        cmd.Parameters.AddWithValue("@p", txtPass.Text)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If rd.HasRows Then
            MessageBox.Show("Đăng nhập thành công")
            tab.SelectedTab = tpPhongBan
            LoadPhongBan()
            LoadNhanVien()
            LoadHopDong()
            LoadComboPhongBan()
            LoadComboNhanVien()
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu")
        End If
        rd.Close()
        conn.Close()
    End Sub

    Private Sub btnThemPB_Click(sender As Object, e As EventArgs)
        OpenConnection()
        Dim cmd As New SqlCommand("INSERT INTO PhongBan VALUES(@ma,@ten,@mota)", conn)
        cmd.Parameters.AddWithValue("@ma", txtMaPB.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenPB.Text)
        cmd.Parameters.AddWithValue("@mota", txtMoTa.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadPhongBan()
    End Sub

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs)
        OpenConnection()
        Dim cmd As New SqlCommand("INSERT INTO NhanVien VALUES(@ma,@ten,@ngsinh,@gt,@dc,@sdt,@mapb)", conn)
        cmd.Parameters.AddWithValue("@ma", txtMaNV.Text)
        cmd.Parameters.AddWithValue("@ten", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@ngsinh", dtpNgaySinh.Value)
        cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text)
        cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text)
        cmd.Parameters.AddWithValue("@sdt", txtSoDT.Text)
        cmd.Parameters.AddWithValue("@mapb", cboPhongBan.SelectedValue)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadNhanVien()
    End Sub

    Private Sub btnThemHD_Click(sender As Object, e As EventArgs)
        OpenConnection()
        Dim cmd As New SqlCommand("INSERT INTO HopDong VALUES(@mahd,@manv,@loai,@ngbd,@ngkt,@luong)", conn)
        cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text)
        cmd.Parameters.AddWithValue("@manv", cboNhanVien.SelectedValue)
        cmd.Parameters.AddWithValue("@loai", cboLoaiHD.Text)
        cmd.Parameters.AddWithValue("@ngbd", dtpBatDau.Value)
        cmd.Parameters.AddWithValue("@ngkt", dtpKetThuc.Value)
        cmd.Parameters.AddWithValue("@luong", txtLuong.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadHopDong()
    End Sub


    Public Sub New()
        Me.Text = "Quản lý nhân sự"
        Me.Size = New Drawing.Size(900, 600)

        tab.Dock = DockStyle.Fill
        tpLogin.Text = "Đăng nhập"
        tpPhongBan.Text = "Phòng ban"
        tpNhanVien.Text = "Nhân viên"
        tpHopDong.Text = "Hợp đồng"
        tab.TabPages.AddRange({tpLogin, tpPhongBan, tpNhanVien, tpHopDong})
        Me.Controls.Add(tab)


        txtUser.Top = 50 : txtUser.Left = 100 : txtUser.Width = 200 : tpLogin.Controls.Add(txtUser)
        txtPass.Top = 90 : txtPass.Left = 100 : txtPass.Width = 200 : txtPass.PasswordChar = "*"c : tpLogin.Controls.Add(txtPass)
        btnLogin.Text = "Đăng nhập" : btnLogin.Top = 130 : btnLogin.Left = 100 : AddHandler btnLogin.Click, AddressOf btnLogin_Click : tpLogin.Controls.Add(btnLogin)


        txtMaPB.Top = 20 : txtMaPB.Left = 20 : tpPhongBan.Controls.Add(txtMaPB)
        txtTenPB.Top = 50 : txtTenPB.Left = 20 : tpPhongBan.Controls.Add(txtTenPB)
        txtMoTa.Top = 80 : txtMoTa.Left = 20 : tpPhongBan.Controls.Add(txtMoTa)
        btnThemPB.Text = "Thêm" : btnThemPB.Top = 110 : btnThemPB.Left = 20 : AddHandler btnThemPB.Click, AddressOf btnThemPB_Click : tpPhongBan.Controls.Add(btnThemPB)
        dgvPhongBan.Top = 150 : dgvPhongBan.Left = 20 : dgvPhongBan.Width = 800 : dgvPhongBan.Height = 300 : tpPhongBan.Controls.Add(dgvPhongBan)


        txtMaNV.Top = 20 : txtMaNV.Left = 20 : tpNhanVien.Controls.Add(txtMaNV)
        txtHoTen.Top = 50 : txtHoTen.Left = 20 : tpNhanVien.Controls.Add(txtHoTen)
        dtpNgaySinh.Top = 80 : dtpNgaySinh.Left = 20 : tpNhanVien.Controls.Add(dtpNgaySinh)
        cboGioiTinh.Top = 110 : cboGioiTinh.Left = 20 : cboGioiTinh.Items.AddRange({"Nam", "Nữ"}) : tpNhanVien.Controls.Add(cboGioiTinh)
        txtDiaChi.Top = 140 : txtDiaChi.Left = 20 : tpNhanVien.Controls.Add(txtDiaChi)
        txtSoDT.Top = 170 : txtSoDT.Left = 20 : tpNhanVien.Controls.Add(txtSoDT)
        cboPhongBan.Top = 200 : cboPhongBan.Left = 20 : tpNhanVien.Controls.Add(cboPhongBan)
        btnThemNV.Text = "Thêm" : btnThemNV.Top = 230 : btnThemNV.Left = 20 : AddHandler btnThemNV.Click, AddressOf btnThemNV_Click : tpNhanVien.Controls.Add(btnThemNV)
        dgvNhanVien.Top = 260 : dgvNhanVien.Left = 20 : dgvNhanVien.Width = 800 : dgvNhanVien.Height = 250 : tpNhanVien.Controls.Add(dgvNhanVien)


        txtMaHD.Top = 20 : txtMaHD.Left = 20 : tpHopDong.Controls.Add(txtMaHD)
        cboNhanVien.Top = 50 : cboNhanVien.Left = 20 : tpHopDong.Controls.Add(cboNhanVien)
        cboLoaiHD.Top = 80 : cboLoaiHD.Left = 20 : cboLoaiHD.Items.AddRange({"Chính thức", "Thử việc"}) : tpHopDong.Controls.Add(cboLoaiHD)
        dtpBatDau.Top = 110 : dtpBatDau.Left = 20 : tpHopDong.Controls.Add(dtpBatDau)
        dtpKetThuc.Top = 140 : dtpKetThuc.Left = 20 : tpHopDong.Controls.Add(dtpKetThuc)
        txtLuong.Top = 170 : txtLuong.Left = 20 : tpHopDong.Controls.Add(txtLuong)
        btnThemHD.Text = "Thêm" : btnThemHD.Top = 200 : btnThemHD.Left = 20 : AddHandler btnThemHD.Click, AddressOf btnThemHD_Click : tpHopDong.Controls.Add(btnThemHD)
        dgvHopDong.Top = 230 : dgvHopDong.Left = 20 : dgvHopDong.Width = 800 : dgvHopDong.Height = 250 : tpHopDong.Controls.Add(dgvHopDong)
    End Sub


    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New FrmMain())
    End Sub
End Class
