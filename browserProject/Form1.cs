using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserProject
{
    public partial class WrCorp : Form
    {


        List<string> Favoritas = new List<string>();
        public WrCorp()
        {
            InitializeComponent();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txturl.Text);


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favoritas.Add(webBrowser1.Url.ToString());
            actializarcb();
        }
        private void actializarcb()
        {
            foreach(string direcion in Favoritas)
            {
                cmbFavo.Items.Add(direcion);
            }
        }
    }
}
