using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomBrowser
{
    public partial class BrowserForm : Form
    {
        List<string> Favorites = new List<string>();

        public BrowserForm()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.msn.com/es-xl");
            tbSearch.Text = "https://www.msn.com/es-xl";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            tbSearch.Text = "https://www.msn.com/es-xl";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tbSearch.Text);
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            Favorites.Add(webBrowser1.Url.ToString());
            UpdateFavorites();
        }

        private void UpdateFavorites()
        {
            foreach(string url in Favorites)
            {
                cbxFavorites.Items.Add(url);
            }
        }

        private void cbxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cbxFavorites.SelectedItem.ToString());
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                webBrowser1.Navigate(tbSearch.Text);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrowserForm_Load(object sender, PaintEventArgs e)
        {

        }
    }
}
