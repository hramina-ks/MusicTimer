using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTimer
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
            //linklblvk.LinkClicked += linklblvk_LinkClicked;
        }

        private void AboutMe_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linklblVKpay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.me/moneysend/to/EA1r");
        }

        private void linklblmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:krist89@yandex.ru");
        }

        private void linklblYandex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://money.yandex.ru/to/41001164547609");
        }

        private void linklblQivi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://qiwi.com/n/HIRTH148");
        }

        private void linklblPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://paypal.me/kristall89");
        }

        private void linklblTlg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tlgg.ru/krist89");
        }
    }
}
