using System;
using System.Xml.Linq;
using LinqToXml.SampleData;

namespace LinqToXml
{
    class Program
    {
        /// <summary>
        /// Vasim ukolem je implementovat nize uvedene metody Task01-04
        /// </summary>
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
            Task04();
        }

        /// <summary>
        /// Za pomocí Linq to Xml zjistěte všechny žánry filmů, které umístěte do jednoho řetězce a oddělte čárkami
        /// </summary>
        public static void Task01()
        {
            // TODO 
            // var allGenres = ...

            //Console.WriteLine($"All genres: {allGenres}" + Environment.NewLine);
        }

        /// <summary>
        /// Za pomocí Linq to Xml spočítejte průměrné hodnocení všech filmů
        /// </summary>
        public static void Task02()
        {
            // TODO...
            // var averageRating = ...

            //Console.WriteLine($"Average movie rating: {averageRating:N2}" + Environment.NewLine);
        }

        /// <summary>
        ///  Za pomocí Linq to Xml získejte z Movies.xml a MovieRatings.xml následující údaje:
        ///    název filmu,
        ///    jméno režiséra(spojte jméno a příjmení), 
        ///    veškerá hodnocení(stačí ve formě kolekce stringu, do výsledku zahrnujte pouze filmy, které mají alespoň jedno hodnocení)
        /// </summary>
        public static void Task03()
        {
            // TODO...
            // var moviesWithRatings = ...
            
        }

        /// <summary>
        /// I.    Do Movies.xml přidejte xml element "Movie" s filmem "Pulp Fiction"*, jako režiséra uveďte Quentina Tarantina, 
        ///       žánr nastavte na Thriller, jako rok vydání uveďte 1994 a vytvořte prozatím prázdný element "Cast"
        ///       * název filmu uveďte jako hodnotu atributu "MovieName" elementu "Movie"
        /// 
        /// II.   Dovnitř elementu "Cast" vložte všechny herce z ostatních filmů(zachovejte strukturu elementu "Actor")
        /// 
        /// III.  Při kontrole správnosti údajů se zjistilo, že kromě herce Samuela L.Jacksona v Pulp Fiction žádný z
        ///       uvedených herců nehraje, smažte tedy všechny herce, kteří ve filmu neučinkovali (použijte LinqToXml).
        /// 
        /// IV.   Element s filmem "Pulp Fiction" vypište na konzoly.
        /// </summary>
        public static void Task04()
        {
            // TODO...

        }
    }
}
