using System;
using System.IO;
using System.Linq;
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

            var defaultPigDb = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"..\..\..\PigDB"));
            dlgDatabase.SelectedPath = defaultPigDb;

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

            EditPig(pig);
        }

        private void lvPigs_DoubleClick(object sender, EventArgs e)
        {
            if (lvPigs.Items.Count != 0)
            {
                var p = lvPigs.PointToClient(Cursor.Position);
                var index = lvPigs.IndexFromPoint(p);

                var pig = (Pig) lvPigs.Items[index];

                EditPig(pig);
            }
        }

        private void EditPig(Pig pig)
        {
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

        private void actAvgWeight_Execute(object sender, EventArgs e)
        {
            var pigs = lvPigs.SelectedItems.Cast<Pig>().ToArray();

            var sum = pigs.Sum(pig => pig.Weight);
            var count = pigs.Count();

            var message = string.Format("Average weight is {0}", sum / count);
            MessageBox.Show(message, "Average Weight", MessageBoxButtons.OKCancel);
        }

        private void actMinWeight_Execute(object sender, EventArgs e)
        {
            var pig = lvPigs.SelectedItems.Cast<Pig>().OrderBy(p => p.Weight).First();

            var message = string.Format("The pig '{0}' have minimal weight {1}", pig.Name, pig.Weight);
            MessageBox.Show(message, "Average Weight", MessageBoxButtons.OK);
        }

        private void actMaxWeight_Execute(object sender, EventArgs e)
        {
            var pig = lvPigs.SelectedItems.Cast<Pig>().OrderByDescending(p => p.Weight).First();

            var message = string.Format("The pig '{0}' have maximal weight {1}", pig.Name, pig.Weight);
            MessageBox.Show(message, "Maximal Weight", MessageBoxButtons.OK);

        }

        private void actExport_Execute(object sender, EventArgs e)
        {
            MessageBox.Show("Зделаю завтра...");
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutBox();
            form.Show();
        }
    }
}
