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
            TimeSpan differencebetweentwo = fiirstdate - seconddate;
            Console.WriteLine(differencebetweentwo.TotalHours);
            //klocka omstellning?

            //dagar or smth

        }
       
    }
}