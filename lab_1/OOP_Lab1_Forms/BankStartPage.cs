﻿using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class BankStartPage : Form
    {
        public BankStartPage()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bsuirBankPicture_MouseHover(object sender, EventArgs e)
        {
            bsuirBankPicture.Width += 5;
            bsuirBankPicture.Height += 5;
        }

        private void bsuirBankPicture_MouseLeave(object sender, EventArgs e)
        {
            bsuirBankPicture.Width -= 5;
            bsuirBankPicture.Height -= 5;
        }

        private void betaBankPicture_MouseHover(object sender, EventArgs e)
        {
            betaBankPicture.Width += 5;
            betaBankPicture.Height += 5;
        }

        private void betaBankPicture_MouseLeave(object sender, EventArgs e)
        {
            betaBankPicture.Width -= 5;
            betaBankPicture.Height -= 5;
        }

        private void forestBankPicture_MouseHover(object sender, EventArgs e)
        {
            forestBankPicture.Width += 5;
            forestBankPicture.Height += 5;
        }

        private void forestBankPicture_MouseLeave(object sender, EventArgs e)
        {
            forestBankPicture.Width -= 5;
            forestBankPicture.Height -= 5;
        }

        private void bsuirBankPicture_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}