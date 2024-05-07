﻿using BusinessLayer;
using DataLayer;
using GUI.Admin.Customer;
using GUI.THUCDON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class ManageCustomer : Form
    {
        public Account _customer;
        public ManageCustomer()
        {
            InitializeComponent();
            _customer = new Account();

            LoadData();
        }
        public List<object> GetCustomerInfoList()
        {
            List<tb_Customer> customerList = _customer.GetAccountsFromTable("tb_Customer");

            List<object> selectedCustomerInfoList = new List<object>();

            foreach (var customer in customerList)
            {
                string gender = customer.Gender==true ? "Nữ" : "Nam";
                var customerInfo = new
                {
                    Mãkháchhàng = customer.CustomerID,
                    Tênkháchhàng = customer.Name,
                    Sốđiệnthoại = customer.PhoneNumber,
                    Giớitính = gender,
                    Ngàysinh = customer.Birthdate,
                    Địachỉ = customer.Address,
                    Điểmthưởng = customer.RewardPoints,
                    Mậtkhẩu = customer.Password
                };

                selectedCustomerInfoList.Add(customerInfo);
            }

            return selectedCustomerInfoList;
        }

        public void LoadData()
        {
            List<object> customerInfoList = GetCustomerInfoList();
            dataGridView1.DataSource = customerInfoList;
            dataGridView1.Columns["Mậtkhẩu"].Width = 0;
            dataGridView1.Columns["Điểmthưởng"].Width = 170;
            dataGridView1.Columns["Địachỉ"].Width = 170;
            dataGridView1.Columns["Ngàysinh"].Width = 120;
            dataGridView1.Columns["Giớitính"].Width = 90;
            dataGridView1.Columns["Sốđiệnthoại"].Width = 120;
            dataGridView1.Columns["Tênkháchhàng"].Width = 190;
            dataGridView1.Columns["Mãkháchhàng"].Width = 100;
            dataGridView1.RowTemplate.Height = 40;

        }
        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemMoiKH t = new ThemMoiKH();
            t.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maKH = selectedRow.Cells["Mãkháchhàng"].Value.ToString();
                string namekh = selectedRow.Cells["Tênkháchhàng"].Value.ToString();
                string sdt = selectedRow.Cells["Sốđiệnthoại"].Value.ToString();
                DateTime birth = Convert.ToDateTime(selectedRow.Cells["Ngàysinh"].Value);
                bool gioitinh = (selectedRow.Cells["Giớitính"].Value.ToString() == "Nam") ? true : false;

                string diachi = selectedRow.Cells["Địachỉ"].Value.ToString();
                int diemthuong = Convert.ToInt32(selectedRow.Cells["Điểmthưởng"].Value.ToString());
                string matkhau = selectedRow.Cells["Mậtkhẩu"].Value.ToString();


            

                ChinhSuaKH chinhSuaForm = new ChinhSuaKH(maKH, namekh, sdt, gioitinh,birth, diachi, diemthuong, matkhau);
                chinhSuaForm.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string masp = selectedRow.Cells["Mãkháchhàng"].Value.ToString();

            _customer.Delete(masp);

            DialogResult result = MessageBox.Show("Xóa khách hàng thành công! Bạn muốn quay lại trang chủ không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hide();
                MainViewAdmin f1 = new MainViewAdmin();
                f1.Show();
            }
            else
            {
                LoadData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                tb_Customer up = new tb_Customer();
                up.CustomerID = selectedRow.Cells["Mãkháchhàng"].Value.ToString();
                up.Name = selectedRow.Cells["Tênkháchhàng"].Value.ToString();
                up.PhoneNumber = selectedRow.Cells["Sốđiệnthoại"].Value.ToString();
                string gioitinh = selectedRow.Cells["Giớitính"].Value.ToString();

                up.Gender = gioitinh == "Nữ" ? true : false;

                up.Birthdate = Convert.ToDateTime(selectedRow.Cells["Ngàysinh"].Value);
                up.Address = selectedRow.Cells["Địachỉ"].Value.ToString();
                up.Password = selectedRow.Cells["Mãkháchhàng"].Value.ToString();
                _customer.Update(up);

                DialogResult result = MessageBox.Show("Cấp lại mật khẩu cho Khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {

                    LoadData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
