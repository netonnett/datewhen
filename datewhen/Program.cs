using System.Security.Cryptography.X509Certificates;

namespace datewhen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //avatr
            DateTime avatarrealisedate = new DateTime(2009, 12, 18, 0, 0, 0);
            DateTime avatarthesecond = new DateTime(2022, 12, 6, 0, 0, 0);
            TimeSpan howlongdiditgo = avatarthesecond - avatarrealisedate;
            Console.WriteLine(howlongdiditgo.TotalDays);

            //min f;delsedag
            DateTime mybday = new DateTime(2006, 9, 28, 5, 30, 0);
            TimeSpan oldie = DateTime.Now - mybday;
            Console.WriteLine(oldie.TotalDays);

            //double the age double the flavour
            DateTime agenow = new DateTime(2024, 4, 11, 13, 24, 0);
            DateTime agein17years = new DateTime(2041, 4, 11, 13, 24, 0);
            TimeSpan loong = agein17years - agenow;
            Console.WriteLine(loong.TotalDays);

            //double age again
            DateTime myybday = new DateTime(2006, 9, 28, 5, 30, 0);
            TimeSpan olldie = DateTime.Now - mybday;
            DateTime howlong = DateTime.Now + olldie;
            Console.WriteLine(howlong);

            //12 hours difference
            DateTime fiirstdate = new DateTime(2022, 3, 26, 12, 0, 0);
            DateTime seconddate = new DateTime(2022, 3, 27, 12, 0, 0);
            TimeSpan differencebetweentwo = seconddate - fiirstdate;
            Console.WriteLine(differencebetweentwo.TotalHours);
            //klocka omstellning?

            //dagar or smth
            DateTime whatever = new DateTime(2023, 1, 1, 0, 0, 0);
            DateTime whatever2 = new DateTime(2024, 1, 1, 0, 0, 0);
            TimeSpan whatever3 = whatever2 - whatever;
            Console.WriteLine(whatever3.TotalDays);

            //dagar or smth part 2
            DateTime okay = new DateTime(2024, 1, 1, 0, 0, 0);
            DateTime imdone = new DateTime(2025, 1, 1, 0, 0, 0);
            TimeSpan again = imdone - okay;
            Console.WriteLine(again.TotalDays);
            //skottor

            // sekunder
            DateTime sparklyqueen = new DateTime(2015, 7, 1, 13, 59, 30);
            DateTime shineyunicorn = new DateTime(2015, 7, 1, 14, 0, 30);
            TimeSpan rainboweatingbears = shineyunicorn - sparklyqueen;
            Console.WriteLine(rainboweatingbears.TotalSeconds);
            //det blev fel i think... leap second?
        }
       
    }
}