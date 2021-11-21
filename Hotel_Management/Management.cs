using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        public void Movepic(Control btn)
        {
            PicSlide.Top = btn.Top;
            PicSlide.Height = btn.Height;
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Movepic(DashboardButton);
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Movepic(ReservationButton);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Movepic(ClientButton);
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            Movepic(RoomButton);
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
           
            
            
        }

        private void ServiesButton_Click(object sender, EventArgs e)
        {
            Movepic(ServiesButton);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Movepic(SettingButton);
        }
    }
}
