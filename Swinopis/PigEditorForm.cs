using System.Drawing;
using System.Windows.Forms;
using Swinopis.Models;

namespace Swinopis
{
    public partial class PigEditorForm : Form
    {
        private Pig pig;

        public PigEditorForm()
        {
            InitializeComponent();
        }

        public Pig Pig
        {
            get
            {
                pig.Name = txtName.Text;
                pig.Description = txtDescription.Text;
                pig.DateOfBirth = ctlDateOfBirth.Value;
                pig.Weight = udWeight.Value;
                pig.Fun = srSpeed.Rating;
                pig.Speed = srFunny.Rating;
                pig.Gluttony = srGluttony.Rating;
                pig.Image = txtImage.Text;

                return pig;
            }
            set
            {
                pig = value;

                txtName.Text = pig.Name;
                txtDescription.Text = pig.Description;
                ctlDateOfBirth.Value = pig.DateOfBirth;
                udWeight.Value = pig.Weight;
                srSpeed.Rating = pig.Fun;
                srFunny.Rating = pig.Speed;
                if (!string.IsNullOrEmpty(pig.Image))
                    picPicture.Load(pig.Image);
            }
        }

        private void llblBrowseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = string.Join(",", openFileDialog.FileNames);
                picPicture.Load(openFileDialog.FileName);
            }
        }
    }
}
