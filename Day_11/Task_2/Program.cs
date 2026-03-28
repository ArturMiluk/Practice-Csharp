using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWeapon weapon = new BasicWeapon();
            Console.WriteLine($"Базовое состояние: {weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

            weapon = new FireEnhancementDecorator(weapon);
            Console.WriteLine($"Улучшение огненным атрибутом: {weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

            weapon = new IceEnhancementDecorator(weapon);
            Console.WriteLine($"Добавление ледяного атрибута: {weapon.GetDescription()}, Урон: {weapon.GetDamage()}");

            weapon = new CriticalHitDecorator(weapon);

            Console.WriteLine("\nИтоговые характеристики:");
            Console.WriteLine($"Описание: {weapon.GetDescription()}");
            Console.WriteLine($"Общий урон (c учётом реакции Таяние (огонь по льду): {weapon.GetDamage()}");

            Console.ReadKey();
        }
    }
}
