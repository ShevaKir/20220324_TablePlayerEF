using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq.Mapping;

namespace _20220324_TablePlayerEF
{
    [Table(Name = "Players")]
    class Player
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdPlayer { get; set; }

        [Column]
        public string NamePlayer { get; set; }

        [Column]
        public string SurnamePlayer { get; set; }

        [Column]
        public DateTime DateOfBirth { get; set; }

        [Column]
        public int IdCountry { get; set; }

        [Column]
        public int IdTeam { get; set; }

        [Column]
        public byte PlayerNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", IdPlayer, NamePlayer, SurnamePlayer, IdTeam);
        }
    }
}
