using System;

namespace Swinopis.Models
{
    public class Pig
    {
        private string name;
        private string description;
        private DateTime dateOfBirth = DateTime.Now;
        private decimal weight;
        
        private int speed;
        private int fun;
        private int gluttony;

        private string image;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Fun
        {
            get { return fun; }
            set { fun = value; }
        }

        public int Gluttony
        {
            get { return gluttony; }
            set { gluttony = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public void Assign(Pig pig)
        {
            name = pig.Name;
            description = pig.Description;
            dateOfBirth = pig.DateOfBirth;
            weight = pig.Weight;

            speed = pig.Speed;
            fun = pig.Fun;
            gluttony = pig.Gluttony;

            image = pig.Image;
        }
    }
}
