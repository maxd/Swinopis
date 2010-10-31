using System.Drawing;
using System.Windows.Forms;
using Swinopis.Models;
using Swinopis.Properties;

namespace Swinopis
{
    public class PigList : ListBox
    {
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            e.ItemHeight = 32;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            var g = e.Graphics;
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (DesignMode)
                return;

            if (e.Index != -1)
            {
                var pig = (Pig) Items[e.Index];

                g.DrawImage(Resources.pig_icon, IconRect(e.Bounds));

                g.DrawString(pig.Name, Font, Brushes.Black, NameRect(e.Bounds));
                g.DrawString(pig.Description, Font, Brushes.Gray, DescriptionRect(e.Bounds));

                g.DrawString(pig.DateOfBirth.ToString("D"), Font, Brushes.Black, DayOfBirthRect(e.Bounds));
                g.DrawString(string.Format("{0} kg", pig.Weight), Font, Brushes.Black, WeightRect(e.Bounds));
            }
        }

        private Rectangle IconRect(Rectangle itemRect)
        {
            return new Rectangle(itemRect.X, itemRect.Y, 32, 32);
        }

        private Rectangle NameRect(Rectangle itemRect)
        {
            return new Rectangle(itemRect.X + 37, itemRect.Y + 0, 250, 16);
        }

        private Rectangle DescriptionRect(Rectangle itemRect)
        {
            return new Rectangle(itemRect.X + 37, itemRect.Y + 16, 250, 32);
        }

        private Rectangle DayOfBirthRect(Rectangle itemRect)
        {
            return new Rectangle(NameRect(itemRect).Right, itemRect.Y, 150, 16);
        }

        private Rectangle WeightRect(Rectangle itemRect)
        {
            return new Rectangle(NameRect(itemRect).Right, itemRect.Y + 16, 150, 32);
        }
    }
}
