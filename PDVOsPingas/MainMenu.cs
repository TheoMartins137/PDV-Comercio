namespace PDVOsPingas
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            lstTeste.View = View.Details;
            lstTeste.Scrollable = true;
            lstTeste.LabelEdit = true;
            lstTeste.GridLines = true;
            lstTeste.FullRowSelect = true;

            lstTeste.Columns.Add("Teste", 150, HorizontalAlignment.Left);
            lstTeste.Columns.Add("Teste2", 150, HorizontalAlignment.Left);
            lstTeste.Items.Add("Teste");
            lstTeste.Items.Add("Teste");
        }

        private void lstTeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PVDVenda form = new PVDVenda();
            form.ShowDialog();
        }

        private void lstTeste_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MessageBox.Show("TESTE");
        }
    }
}
