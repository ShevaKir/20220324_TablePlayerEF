using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace _20220324_TablePlayerEF
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=DESKTOP-CBEBKS8\\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";

            using (DataContext db = new DataContext(connection))
            {
                db.Log = Console.Out;
                
                var players = db.GetTable<Player>();
                var teams = db.GetTable<Team>();

                players.InsertOnSubmit(new Player()
                {
                    NamePlayer = "Kyrylo",
                    SurnamePlayer = "Shevchenko",
                    DateOfBirth = new DateTime(2000, 10, 1),
                    IdCountry = 1,
                    IdTeam = 1,
                    PlayerNumber = 1
                }) ;

                Console.WriteLine("Id   Name   Stadion");
                foreach (var team in teams)
                {
                    Console.WriteLine(team);
                }

                //int idTeam = int.Parse(Console.ReadLine());

                //var tablePlayer = players.Where(x => x.IdTeam == idTeam);

                Console.WriteLine("idPlayer Name Surname idTeam");
                foreach (var player in players)
                {
                    Console.WriteLine(player);
                }

                Console.WriteLine();

                db.SubmitChanges();
            }

            Console.ReadKey();
        }
    }
}
