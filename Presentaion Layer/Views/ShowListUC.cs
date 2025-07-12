using Domain_Layer;
using Microsoft.Data.SqlClient;
using Presentaion_Layer.Common_For_Coloring___Themes;
using Presentaion_Layer.Views;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Presentaion_Layer;

public partial class ShowListUC : UserControl, IShowListView
{
    public event EventHandler AddToList = delegate { };
    public event EventHandler RemoveFromList = delegate { };
    public event EventHandler EditItemInList = delegate { };

    public event EventHandler Search = delegate { };
    public event EventHandler ShowDetailsForItem = delegate { };

    public bool BasicEditOnly
    {
        get;
        set;
    }
    public Image? ImageForAddBtn
    {
        get => AddBtn.Image;
        set => AddBtn.Image = value;
    }
    public IList<string>? SearchBy
    {
        get => SearchByComboBox.DataSource as List<string> ?? new List<string>();
        set
        {
            if (value != null && !value.Any() && BasicEditOnly )
                throw new ArgumentException("DataSource cannot be empty.");
            SearchByComboBox.DataSource = value;
        }
    }
    public string ListName { get => HeaderLabel.Text; set => HeaderLabel.Text = value; }
    public string SearchByTxt { get => SearchTextBox.Text; set => SearchTextBox.Text = value; }
    public string SearchByCategory { get => SearchByComboBox.Text; }
    public string Head { set => HeaderLabel.Text = value; get => HeaderLabel.Text; }

    public int SelectedID { get => (int)DataGridView.CurrentCell.OwningRow.Cells[0].Value; }
    public int SelectedIndex { get => DataGridView.CurrentCell.OwningRow.Index; }




    public ShowListUC()
    {
        InitializeComponent();

        contextMenuStrip1.ForeColor = Color.FromArgb(242, 242, 242);

        DataGridView.DefaultCellStyle.BackColor = Themes.DarkMode().BackgroundColor;
        DataGridView.DefaultCellStyle.ForeColor = Themes.DarkMode().FontColor;
    }


    public void SetListBindingSource(BindingSource bs)
    {
        DataGridView.DataSource = bs;
    }


    private void AddBtn_Click(object sender, EventArgs e)
    {
        AddToList?.Invoke(this, e);
    }



    private void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        Search?.Invoke(this, e);
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RemoveFromList.Invoke(this, e);

    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EditItemInList.Invoke(this, e);
    }

    private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowDetailsForItem.Invoke(this, e);
    }

    private int ColumnsWidth()
    {
      int width = 0;
        foreach(DataGridViewColumn column in DataGridView.Columns)
            width += column.Width;

        return width;
    }

    private void ShowListUC_Load(object sender, EventArgs e)
    {
        if (BasicEditOnly) { SearchByLabel.Visible = false;
        SearchTextBox.Visible = false;
        SearchByComboBox.Visible = false;
        AddBtn.Visible = false;
            deleteToolStripMenuItem.Visible = false;
            showDetailsToolStripMenuItem.Visible = false;   
        }


        if (DataGridView.ClientSize.Width > ColumnsWidth())

            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
