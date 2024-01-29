namespace App
{
    public partial class config : Form
    {

        public config()
        {
            InitializeComponent();
        }

        private void config_Load(object sender, EventArgs e)
        {
           farmerCount.SelectedIndex = spyCount.SelectedIndex = 0;
        }

    }
}