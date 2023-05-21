using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckApp
{
    struct Check
    {
        public string ItemName;
        public int Quantity;
        public decimal UnitPrice;
        public decimal Discount;
        public decimal TotalCost;
        public string Note;

        public void PrintCheck()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("************ Чек ************");
            Console.WriteLine($"Наименование: {ItemName}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Цена за единицу: {UnitPrice}");
            Console.WriteLine($"Скидка: {Discount}");
            Console.WriteLine($"Общая стоимость: {TotalCost}");
            Console.WriteLine($"Пожелание: {Note}");

            Console.ResetColor();
        }
    }

    enum StudentGrade
    {
        EXCELLENT,
        GOOD,
        SATISFACTORY
    }

    class Program
    {
        static void Main(string[] args)
        {
            Check check;
            check.ItemName = "Ноутбук";
            check.Quantity = 2;
            check.UnitPrice = 30000;
            check.Discount = 5000;
            check.TotalCost = check.Quantity * check.UnitPrice - check.Discount;
            check.Note = "Спасибо за покупку!";

            check.PrintCheck();

            StudentGrade grade = StudentGrade.EXCELLENT;
            Console.WriteLine($"Оценка студента: {grade}");
        }
    }
}
