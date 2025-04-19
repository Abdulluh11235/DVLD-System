using Presentaion_Layer.Views;

namespace Presentaion_Layer
{
    public partial class MainForm : Form,IMainView
    {
        public event EventHandler ShowPeople;
    
        public MainForm()
        {
            InitializeComponent();
            
        }


        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
