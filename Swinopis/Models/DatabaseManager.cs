using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Swinopis.Models
{
    public class DatabaseManager
    {
        private readonly string databaseDirectory;
        
        private readonly List<Pig> pigs = new List<Pig>();

        public DatabaseManager(string databaseDirectory)
        {
            this.databaseDirectory = databaseDirectory;
        }

        public void New()
        {
            File.WriteAllText(PigListFileName, "");
        }

        public void Load()
        {
            var lines = File.ReadLines(PigListFileName);
            foreach (var line in lines)
            {
                var items = line.Split(new[] {","}, StringSplitOptions.None);

                var pig = new Pig
                              {
                                  Name = items[0],
                                  Description = items[1],
                                  DateOfBirth = DateTime.Parse(items[2]),
                                  Weight = int.Parse(items[3]),
                                  Speed = int.Parse(items[4]),
                                  Fun = int.Parse(items[5]),
                                  Gluttony = int.Parse(items[6]),
                                  Image = items[7]
                              };
                pigs.Add(pig);
            }
        }

        public void Save()
        {
            var sb = new StringBuilder();

            foreach (var pig in pigs)
            {
                var items = new List<string>
                                {
                                    pig.Name,
                                    pig.Description,
                                    pig.DateOfBirth.ToString(),
                                    pig.Weight.ToString(),
                                    pig.Speed.ToString(),
                                    pig.Fun.ToString(),
                                    pig.Gluttony.ToString(),
                                    pig.Image
                                };

                sb.AppendLine(string.Join(",", items));
            }

            File.WriteAllText(PigListFileName, sb.ToString());
        }

        public string PigListFileName
        {
            get
            {
                return databaseDirectory + @"\pigs.list";
            }
        }

        public void AddPig(Pig pig)
        {
            pigs.Add(pig);
        }

        public void RemovePig(Pig pig)
        {
            pigs.Remove(pig);
        }

        public IEnumerable<Pig> Pigs
        {
            get { return pigs; }
        }
    }
}
