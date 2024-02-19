using System;

namespace ChessRook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат ладьи и фигуры.
            Console.WriteLine("Введите координаты ладьи и фигуры в формате 'a1 b2':");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');

            // Проверка корректности введенных данных.
            if (coordinates.Length != 2 || !IsValidCoordinate(coordinates[0]) || !IsValidCoordinate(coordinates[1]))
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            // Получение координат ладьи и фигуры.
            char rookColomns = coordinates[0][0];
            int rookRows = int.Parse(coordinates[0][1].ToString());
            char figureColomnse = coordinates[1][0];
            int figureRows = int.Parse(coordinates[1][1].ToString());

            // Проверка бьёт ли ладья фигуру.
            if (rookColomns == figureColomnse || rookRows == figureRows)
            {
                Console.WriteLine("Ладья сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Ладья не сможет побить фигуру");
            }
        }

        // Проверка корректности координат.
        static bool IsValidCoordinate(string coordinate)
        {
            if (coordinate.Length != 2)
            {
                return false;
            }

            char colomns = coordinate[0];
            int rows = int.Parse(coordinate[1].ToString());

            return (colomns >= 'a' && colomns <= 'h') && (rows >= 1 && rows <= 8);
        }


    }
}