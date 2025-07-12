using Presentaion_Layer.Views;

namespace Presentaion_Layer
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler ShowPeople = delegate { };
        public event EventHandler ShowUsers = delegate { };
        public event EventHandler ShowApplicationTypes = delegate { };
        public event EventHandler ShowTestTypes = delegate { };

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

        private void ApplicationBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(ApplicationBtn, ApplicationBtn.Size.Width + 1, 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApplicationTypes?.Invoke(this, EventArgs.Empty);
        }

        private void AccountSettingsBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(AccountSettingsBtn, AccountSettingsBtn.Size.Width + 1, 2);
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTestTypes?.Invoke(this, EventArgs.Empty);
        }
    }
}
