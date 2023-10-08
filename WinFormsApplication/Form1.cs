namespace WinFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Customer> customers = new List<Customer>();

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            Form2 yeniMusteriForm = new Form2();
            yeniMusteriForm.ShowDialog();


            Customer yeniMusteri = yeniMusteriForm.Customer;
            customers.Add(yeniMusteri);


            lstClients.Items.Add($"{yeniMusteri.IsimSoyisim}");
        }
        
        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstClients.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < customers.Count)
            {
                Customer secilenMusteri = customers[selectedIndex];
                MessageBox.Show($"Ýsim: {secilenMusteri.IsimSoyisim}\r\nYaþ: {secilenMusteri.Yas}\r\nTelefon: {secilenMusteri.Telefon}\r\nAdres: {secilenMusteri.Adres}");
            }

        }

    }
}