using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class Field
    {
        public const int fieldLength = 100, fieldWidth = 15;
        const char fieldTile = '#';
        public string line = string.Concat(Enumerable.Repeat(fieldTile, fieldLength));

        public void CreateField()
        {
            Console.SetCursorPosition(0, fieldWidth);
            Console.WriteLine(line);

            Console.SetCursorPosition(6, fieldWidth);
            Console.WriteLine("_");

            Console.SetCursorPosition(23, fieldWidth);
            Console.WriteLine("_");

            Console.SetCursorPosition(55, fieldWidth);
            Console.WriteLine("_");

            Console.SetCursorPosition(70, fieldWidth);
            Console.WriteLine("_");

            Console.SetCursorPosition(96, fieldWidth - 1);
            Console.WriteLine("|");

            Console.SetCursorPosition(96, fieldWidth + 1);
            Console.WriteLine("Finish");
        }
    }
}
