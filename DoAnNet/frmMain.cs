﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DoAnNet.UserControls;

namespace DoAnNet
{
    public partial class frmMain : Form
    {
        private int count = 0;

        public delegate void functioncall(int i);
        private event functioncall formFunctionPointer;

        public frmMain()
        {
            InitializeComponent();

            btnCartCount.Text = "0";

            formFunctionPointer += new functioncall(increseCart);

            loadSanPham();
        }

        private void loadSanPham()
        {
            List<Products_DTO> lstProduct = Products_BLL
                .LoadProducts();
            int count = lstProduct.Count;
            Console.WriteLine("load xong, count: " + count);
            if (count > 0)
            {
                UC_SanPham_item[] lstItem = new UC_SanPham_item[count];
                for (int i = 0; i < count; i++)
                {
                    lstItem[i] = new UC_SanPham_item();
                    lstItem[i].Pname = lstProduct[i].Pd_name;
                    lstItem[i].Price = lstProduct[i].Pd_retail;
                    lstItem[i].Img = lstProduct[i].Pd_id;

                    lstItem[i].userFunctionPointer = formFunctionPointer;

                    flpSanPham.Controls.Add(lstItem[i]);
                }
            }
        }

        private void increseCart(int i)
        {
            count+=i;
            btnCartCount.Text = count.ToString();
        }

        private void addUserControl(UserControl uc)
        {
            pnMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            pnMain.Controls.Add(uc);
        }

        private void button_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadSanPham();
            //UC_Home uC_ = new UC_Home();
            //addUserControl(uC_);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {

        }

        //private void loadBtnCartCount()
        //{
        //    Console.WriteLine("cart.count: " + Cart.cart.Count.ToString());
        //    btnCartCount.Text = Cart.cart.Count.ToString();
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
