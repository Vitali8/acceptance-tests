using System;
using System.Collections.Generic;

namespace AcceptanceTests
{
    class TaskSeven
    {
        public static List<Tuple<int, int>> getQueenPossiblePoints(int coordX, int coordY)
        {
            //список кортежів по два цілочисельні елементи - колекція пар
            List<Tuple<int, int>> coordinates = new List<Tuple<int, int>>();
            //оскільки можливі координати в межах від 1 до 8
            for (int i = 1; i < 8; i++)
            {
                //зміщуємо координати у восьми напрямках
                //якщо зміщені координати в межах "дошки" 
                if (coordX + i < 9 && coordY + i < 9)
                    coordinates.Add(Tuple.Create(coordX + i, coordY + i));
                if (coordX + i < 9)
                    coordinates.Add(Tuple.Create(coordX + i, coordY));
                if (coordY + i < 9)
                    coordinates.Add(Tuple.Create(coordX, coordY + i));
                if (coordX - i > 0 && coordY + i < 9)
                    coordinates.Add(Tuple.Create(coordX - i, coordY + i));
                if (coordX + i < 9 && coordY - i > 0)
                    coordinates.Add(Tuple.Create(coordX + i, coordY - i));
                if (coordY - i > 0)
                    coordinates.Add(Tuple.Create(coordX, coordY - i));
                if (coordX - i > 0)
                    coordinates.Add(Tuple.Create(coordX - i, coordY));
                if (coordX - i > 0 && coordY - i > 0)
                    coordinates.Add(Tuple.Create(coordX - i, coordY - i));
            }
            return coordinates;
        }
    }
}
