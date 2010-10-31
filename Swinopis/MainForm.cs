using System;
using System.Windows.Forms;
using Swinopis.Models;

namespace Swinopis
{
    public partial class MainForm : Form
    {
        private DatabaseManager databaseManager;
        private PigEditorForm pigEditorForm;

        public MainForm()
        {
            InitializeComponent();

            pigEditorForm = new PigEditorForm();
        }

        private void actExit_Execute(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actNew_Execute(object sender, EventArgs e)
        {
            if (dlgDatabase.ShowDialog() == DialogResult.OK)
            {
                databaseManager = new DatabaseManager(dlgDatabase.SelectedPath);
                databaseManager.New();
                UpdateList();
            }
        }

        private void actOpen_Execute(object sender, EventArgs e)
        {
            if (dlgDatabase.ShowDialog() == DialogResult.OK)
            {
                databaseManager = new DatabaseManager(dlgDatabase.SelectedPath);
                databaseManager.Load();
                UpdateList();
            }
        }

        private void actSave_Execute(object sender, EventArgs e)
        {
            databaseManager.Save();
        }

        private void actNewItem_Execute(object sender, EventArgs e)
        {
            pigEditorForm.Pig = new Pig();
            if (pigEditorForm.ShowDialog() == DialogResult.OK)
            {
                databaseManager.AddPig(pigEditorForm.Pig);
                UpdateList();
            }
        }

        private void actEditItem_Execute(object sender, EventArgs e)
        {
            var pig = (Pig) lvPigs.SelectedItem;

            if (pig != null)
            {
                pigEditorForm.Pig = pig;
                if (pigEditorForm.ShowDialog() == DialogResult.OK)
                {
                    pig.Assign(pigEditorForm.Pig);
                    UpdateList();
                }
            }
        }

        private void actDeleteItem_Execute(object sender, EventArgs e)
        {
            var pig = (Pig)lvPigs.SelectedItem;

            if (pig != null)
            {
                databaseManager.RemovePig(pig);
                UpdateList();
            }
        }

        private void UpdateList()
        {
            lvPigs.Items.Clear();

            foreach (var pig in databaseManager.Pigs)
                lvPigs.Items.Add(pig);

            lblPigCount.Text = string.Format("Pigs:{0}", lvPigs.Items.Count);
        }
    }
}
