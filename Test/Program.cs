using MotorcycleRacingModel;
using ViewModel;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region
            BrandDB bdb = new();
            BrandList bList = bdb.SelectAll();
            Console.WriteLine("Brand: ");
            foreach (Brand b in bList)
                Console.WriteLine($"{"ID: "}{b.Id}{", Brand: "}{b.BrandName}{", Brand Description: "}{b.BrandDescription}");
            #endregion

            #region
            Console.WriteLine("");
            ModelDB mdb = new();
            ModelList mList = mdb.SelectAll();
            Console.WriteLine("Model: ");
            foreach (Model m in mList)
                Console.WriteLine($" {"ID: "}{m.Id}{", Model Description: "}{m.ModelDescription}");
            #endregion

            #region
            Console.WriteLine("");
            MotorcyclesDB motordb = new();
            MotorcyclesList motorList = motordb.SelectAll();
            Console.WriteLine("Motorcycles: ");
            int count = 0;
            foreach (Motorcycles m in motorList)
            {
                count++;
                Console.WriteLine($" {"ID: "}{m.Id}{", Rider ID: "}{m.RiderID.Id}{", Brand: "}{m.Brand}{", Model: "}{m.Model}{", Year; "}{m.Year}{", Number of Owners: "}{m.NumberOfOwners}");
            }
            Console.WriteLine(count);  


            #endregion

            #region
            Console.WriteLine("");
            RacesDB rdb = new();
            RacesList rList = rdb.SelectAll();
            Console.WriteLine("Races: ");
            foreach (Races r in rList)
                Console.WriteLine($" {"ID: "}{r.Id}{", Race Name: "}{r.RaceName}{", Race Date: "}{r.RaceDate}{", Track ID: "}{r.TrackID.Id}");
            #endregion


            #region
            Console.WriteLine("");
            ResultsDB resdb = new();
            ResultsList resList = resdb.SelectAll();
            Console.WriteLine("Results: ");
            foreach (Results r in resList)
                Console.WriteLine($"{"ID: "}{r.Id}{", First: "}{r.First}{", Second: "}{r.Second}{", Third: "}{r.Third}");
            #endregion

            #region
            Console.WriteLine("");
            RidersDB ridb = new();
            RidersList riList = ridb.SelectAll();
            Console.WriteLine("Riders: ");
            foreach (Riders r in riList)
                Console.WriteLine($"{"ID: "}{r.Id}{", Start Year: "}{r.StartYear}{", Is Active?: "}{r.IsActive}");
            #endregion

            #region
            Console.WriteLine("");
            TeamMembersDB teambdb = new();
            TeamMembersList teambList = teambdb.SelectAll();
            Console.WriteLine("Team Members: ");
            foreach (TeamMembers t in teambList)
                Console.WriteLine($"{"ID: "}{t.Id}{", Team ID: "}{t.TeamID.Id}{", Rider ID: "}{t.RiderID.Id}");
            #endregion

            #region
            Console.WriteLine("");
            TeamsDB teamdb = new();
            TeamsList teamList = teamdb.SelectAll();
            Console.WriteLine("Team: ");
            foreach (Teams t in teamList)
                Console.WriteLine($"{"ID: "}{t.Id}{", Team Name: "}{t.TeamName}{", Establish Date: "}{t.EstablishDate}");
            #endregion

            #region
            Console.WriteLine("");
            TeamsForRaceDB tfrdb = new();
            TeamsForRaceList tfrList = tfrdb.SelectAll();
            Console.WriteLine("Teams for Race: ");
            foreach (TeamsForRace t in tfrList)
                Console.WriteLine($"{"ID: "}{t.Id}{", Team ID: "}{t.TeamID.Id}{", Race ID: "}{t.RaceID.Id}");
            #endregion

            #region
            Console.WriteLine("");
            TracksDB tdb = new();
            TracksList tList = tdb.SelectAll();
            Console.WriteLine("Tracks: ");
            foreach (Tracks t in tList)
                Console.WriteLine($" {"ID: "}{t.Id}{", Track Description: "}{t.TrackDescription}");
            #endregion

            #region
            Console.WriteLine("");
            UsersDB udb = new();
            UsersList uList = udb.SelectAll();
            Console.WriteLine("Users: ");
            foreach (Users u in uList)
                Console.WriteLine($"{"ID: "}{u.Id}{", Email: "}{u.Email}{", First Name:"}{u.FirstName}{", Last Name:"}{u.LastName}{", Is Admin?: "}{u.IsAdmin}{", Password: "}{u.Pass}{", Phone: "}{u.Phone}");
            #endregion

        }
    }
}
