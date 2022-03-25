using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq.Mapping;

namespace _20220324_TablePlayerEF
{
    [Table(Name = "Teams")]
    class Team
    {
        [Column]
        public int IdTeam { get; set; }

        [Column]
        public string NameTeam { get; set; }

        [Column]
        public string Stadion { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", IdTeam, NameTeam, Stadion);
        }
    }
}
