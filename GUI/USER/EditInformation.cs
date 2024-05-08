using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace GUI.USER
{
    public partial class EditInformation : Form
    {
        string username;
        string password;
        private PBL3Entities db = new PBL3Entities();
        public EditInformation(string usermame, string password)
        {
            InitializeComponent();
            this.username = usermame;
            this.password = password;
        }

        private void setInfo()
        {
            
            var customer = db.tb_Employee.FirstOrDefault(e => e.EmployeeID.Trim() == username && e.Password.Trim() == password);
            txtName.Text = username;
            txtphone.Text = customer.PhoneNumber;
           
        }
    }
}
