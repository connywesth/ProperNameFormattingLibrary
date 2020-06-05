using ProperNameFormattingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperNameFormattingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Display("Test 111 from test data", "Smith-Wesson, Sandy Amanda Georgina");
            Display("Test 112 from test data", "Sandy Amanda Georgina Smith-Wesson");
            Display("Test 113 from test data", "Sven-Göran Gunnar torsten helmer Smith-Wesson");
            Display("Test 114 from test data", "Sven-Göran Gunnar torsten helmer af Smith-Wesson");
            Display("Test 115 from test data", "Sven-Göran Gunnar torsten helmer von Smith-Wesson");
            Display("Test 116 from test data", "Sven-Göran Gunnar torsten helmer den Smith-Wesson");
            Display("Test 117 from test data", "Sven-Göran Gunnar torsten helmer van der Smith-Wesson");
            Display("Test 118 from test data", "Smith-Wesson, Sven-Göran Gunnar torsten helmer");
            Display("Test 119 from test data", "af Smith-Wesson, Sven-Göran Gunnar torsten helmer");
            Display("Test 120 from test data", "von Smith-Wesson, Sven-Göran Gunnar torsten helmer");
            Display("Test 121 from test data", "den Smith-Wesson, Sven-Göran Gunnar torsten helmer");
            Display("Test 122 from test data", "van der Smith-Wesson, Sven-Göran Gunnar torsten helmer");
            Display("Test 123 from test data", "van der Holstein-Magdeburg-Wesson-Smith, Sven-Göran Gunnar torsten helmer");
            Display("Test 124 from test data", "Sven-Göran Gunnar torsten helmer van der Holstein-Magdeburg-Wesson-Smith");
        }

        public static void Display(string testCaption, string name)
        {
            ProperNameFormattingClass namer = new NameFactory().GetProperName(name);

            Console.WriteLine();
            Console.WriteLine(new String('-', name.Length));
            Console.WriteLine($"{testCaption}: {name}");
            Console.WriteLine(new String('-', name.Length));
            Console.WriteLine($"namer: {namer}");
            Console.WriteLine($"namer.LastAndFirstName(): {namer.LastAndFirstName()}");
            Console.WriteLine($"namer.FirstAndLastName(): {namer.FirstAndLastName()}");
        }
    }

}


