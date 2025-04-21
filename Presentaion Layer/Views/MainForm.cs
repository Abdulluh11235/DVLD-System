using Presentaion_Layer.Views;

namespace Presentaion_Layer
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler ShowPeople = delegate { };

        public MainForm()
        {
            InitializeComponent();
        }
        public void SetControlInUse(Control control)
        {
            // TODO: if clicked on a btn twice  Dont Reload Again

            if (MainPanel.Controls.Count != 0)
            {
                foreach (Control c in MainPanel.Controls)
                    MainPanel.Controls.Remove(c);
            }
            control.Dock = DockStyle.Fill;  
            MainPanel.Controls.Add(control);
        }

        private void PeopleBtn_Click(object sender, EventArgs e)
        {
            ShowPeople?.Invoke(this, EventArgs.Empty);  
        }
    }
}
