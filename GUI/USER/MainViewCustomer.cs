using BusinessLayer;
using DataLayer;
using GUI.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class MainViewCustomer : Form
    {
        private PBL3Entities db = new PBL3Entities();
        private string loggedInUsername;
        private string loggedInPassword;
        
        private void MainViewCustomer_Load()
        {
            LabelUser.Text = loggedInUsername;
        }
        public MainViewCustomer(string loggedInUsername, string loggedInPassword)
        {
            InitializeComponent();
            
            mdiProp();
            this.loggedInUsername = loggedInUsername;
            this.loggedInPassword = loggedInPassword;
            MainViewCustomer_Load();
        }
        

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        EditInformation editInformation;
        OrderTable orderTable;
        ViewOrderHistory viewOrderHistory;


        bool siebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(siebarExpand)
            {
                sidebar.Width = sidebar.Width + 20;
                if(sidebar.Width >= 285)
                {
                    sidebarTransition.Stop();
                    siebarExpand = false;
                    this.Refresh();
                }
            }
            else
            {
                sidebar.Width = sidebar.Width - 20;
                if(sidebar.Width <= 107)
                {
                    sidebarTransition.Stop();
                    siebarExpand = true;
                    this.Refresh();
                }
            }
        }

        private void btnham_Click(object sender, EventArgs e)
        {

            sidebarTransition.Start();
        }

        private void btnDatban_Click(object sender, EventArgs e)
        {
            if(orderTable == null)
            {
                orderTable = new OrderTable();
                orderTable.FormClosed += OrderTable_FormClosed;
                orderTable.MdiParent = this;
                orderTable.Dock = DockStyle.Fill;
                orderTable.Show();
            }
            else
            {
                orderTable.Activate();
            }
        }
        private void OrderTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderTable = null;
        }

        private void BtnXemlichsudatmon_Click(object sender, EventArgs e)
        {
            if(viewOrderHistory == null)
            {
                viewOrderHistory = new ViewOrderHistory();
                viewOrderHistory.FormClosed += ViewOrderHistory_FormClosed;
                viewOrderHistory.MdiParent = this;
                viewOrderHistory.Dock = DockStyle.Fill;
                viewOrderHistory.Show();
            }
            else
            {
                viewOrderHistory.Activate();
            }
        }
        private void ViewOrderHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewOrderHistory = null;
        }

        private void BtnChinhsuathongtin_Click(object sender, EventArgs e)
        {
            if(editInformation == null)
            {
                editInformation = new EditInformation(loggedInUsername,loggedInPassword);
                editInformation.FormClosed += EditInformation_FormClosed;
                editInformation.MdiParent = this;
                editInformation.Dock = DockStyle.Fill;
                editInformation.Show();
            }
            else
            {
                editInformation.Activate();
            }
        }

        private void EditInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            editInformation = null;
        }

        
        
    }
}
