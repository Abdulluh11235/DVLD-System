using Presentaion_Layer.Views;

namespace Presentaion_Layer
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler ShowPeople = delegate { };
        public event EventHandler ShowUsers = delegate { };

        public MainForm()
        {
            InitializeComponent();
        }
        public void SetControlInUse(Control control)
        {
            if (MainPanel.Controls.Count > 0 && MainPanel.Controls[0] == control)
                return;

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

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ShowUsers?.Invoke(this, EventArgs.Empty);
        }
    }
}
