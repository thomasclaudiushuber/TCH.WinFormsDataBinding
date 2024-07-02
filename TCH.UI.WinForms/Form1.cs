using TCH.ViewModels;

namespace TCH.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var viewModel = new MainViewModel();
            viewModel.Load();
            mainViewModelBindingSource.DataSource = viewModel;
        }
    }
}