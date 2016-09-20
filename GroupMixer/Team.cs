using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMixer
{
    public class Team
    {
        public static IReadOnlyList<Team> Teams { get; private set; } = new List<Team>()
        {
            new Team("1k",
                new List<string>()
                {
                    "Amalie-Maria",
                    "Andreas",
                    "Camilla",
                    "Caroline",
                    "Cecilie",
                    "Dilan",
                    "Ditte",
                    "Emilia",
                    "Freja",
                    "Gabriela",
                    "Jakob",
                    "Jens",
                    "Johanne",
                    "Kristine M",
                    "Kristine R",
                    "Lærke",
                    "Matilde",
                    "Mia",
                    "Nicolai",
                    "Nikolaj",
                    "Rasmus",
                    "Rebecca",
                    "Richey",
                    "Signe M",
                    "Signe H",
                    "Simone",
                    "Stine",
                    "Ulrik",
                    "Viktoria",
                }),
            new Team("1q",
                new List<string>()
                {
                    "Amanda",
                    "Andreas",
                    "Anna",
                    "Caroline",
                    "Cecilie L",
                    "Cecilie W",
                    "Christinna",
                    "Emma",
                    "Freja",
                    "Helena",
                    "Ida B",
                    "Ida M",
                    "Julie",
                    "Kamilla",
                    "Line",
                    "Louise",
                    "Malu",
                    "Marcus",
                    "Mathilde",
                    "Michelle",
                    "Mikkel",
                    "Morten",
                    "Pernille",
                    "Sarah",
                    "Sasha",
                    "Tanja",
                    "Thea",
                    "Zuniku",
                }),
            new Team("2s",
                new List<string>()
                {
                    "Ann",
                    "Camilla",
                    "Cecilie",
                    "Christopher",
                    "Emma",
                    "Ester",
                    "Jannie",
                    "Joachim",
                    "Joakim C",
                    "Julie",
                    "Karoline",
                    "Kasper",
                    "Kristian",
                    "Louise",
                    "Lucas",
                    "Lykke",
                    "Mads",
                    "Marcus",
                    "Mathias",
                    "Mikke",
                    "Nanna",
                    "Oliver M",
                    "Oliver R",
                    "Rasmus",
                    "Sandra",
                    "Sofie",
                    "Stefan",
                    "Thomas",
                    "Van Sui",
                    "Veronica",
                }),
             new Team("3b",
                new List<string>()
                {
                    "Anna",
                    "Camilla",
                    "Cecilie L",
                    "Cecilie V",
                    "Christina",
                    "Daniel",
                    "Diana",
                    "Emma",
                    "Emmelie",
                    "Fie",
                    "Ida",
                    "Jeppe",
                    "Jonas G",
                    "Jonas V",
                    "Laura",
                    "Line",
                    "Mathias B",
                    "Mathias M",
                    "Michael",
                    "Nana",
                    "Sofie",
                })
        }.AsReadOnly();


        public string Name { get; private set; }

        public IReadOnlyList<string> Students { get; set; }

        public Team(string name, IEnumerable<string> students)
        {
            Name = name;
            Students = students.ToList().AsReadOnly();
        }
    }
}
