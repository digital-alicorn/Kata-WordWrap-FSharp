using System;

namespace FSharp.Kata.WordWrap.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Word Stays On 1 Line ->");
            Console.WriteLine();
            Console.WriteLine(Core.Do("Test", 80));
            Console.WriteLine();
            Console.WriteLine("Short Line Stays Unbroken ->");
            Console.WriteLine();
            Console.WriteLine(Core.Do("Test Test", 80));
            Console.WriteLine();
            Console.WriteLine("Long Text Gets Broken ->");
            Console.WriteLine();
            Console.WriteLine(Core.Do(@"Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.", 80));
            Console.WriteLine();
            Console.WriteLine("Single Long Word Gets Broken ->");
            Console.WriteLine(Core.Do("Loremipsumdolorsitamet,consetetursadipscingelitr,seddiamnonumyeirmodtemporinviduntutlaboreetdoloremagna", 20));
            Console.WriteLine();
            Console.WriteLine("Long Word In Text Gets Broken ->");
            Console.WriteLine(Core.Do("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, Loremipsumdolorsitamet,consetetursadipscingelitr,seddiamnonumyeirmodtemporinviduntutlaboreetdoloremagna Lorem ipsum dolor sit amet, consetetur sadipscing elitr,", 20));
        }
    }
}
