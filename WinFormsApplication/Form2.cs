using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Customer Customer { get; private set; }
        public Form1 form1;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string telefon = txtTelephone.Text;
            string isimSoyisim = txtNameSurname.Text;
            int yas = (int)numericUpDownAge.Value;
            string adres = rtxtAddress.Text;


            Customer = new Customer(telefon, isimSoyisim, yas, adres);


            txtNameSurname.Clear();
            txtTelephone.Clear();
            rtxtAddress.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
