using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMixer
{
    public class Team
    {
        public string Name { get; private set; }

        public IReadOnlyList<string> Students { get; set; }

        public Team(string name, IEnumerable<string> students)
        {
            Name = name;
            Students = students.ToList().AsReadOnly();
        }
    }
}
