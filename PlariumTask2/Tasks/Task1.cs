using System;

namespace PlariumTasks
{
    static public class Task1
    {
        /*
         * Task 1.1
         * Написать программу, которая введет 5 значений и посчитает произведение чисел, 
         * делящихся без остатка на 7 или 3. 
         * В том слуае, если таких чисел нет, метод вернет -1. 
         * UPDATE: Можно ввести больше 5 значенией.
         */
        static public int FindProduct(params int[] values)
        {
            var product = 1;

            foreach(var value in values)
            {
                if (value % 7 == 0 || value % 3 == 0)
                {
                    product *= value;
                }
            }

            return product == 1 ? -1 : product;
        }

        /*
         * Task 1.2
         * Предприниматель 1 марта открыл счет в банке, вложив 1000 руб. 
         * Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.
         */

        /*
         * Прирост суммы вклада за первый, второй, ..., десятый месяц;
         * Метод возвращает массив, с суммами прироста за каждый месяц.
         */
        static public decimal[] IncreaseAmount(decimal amount, decimal percent, uint months)
        {
            if (amount < 0 || percent < 0 || percent > 100)
                new ArgumentException();

            var incrementAmounts = new decimal[months];
            
            for(var i = 0; i < incrementAmounts.Length; i++)
            {
                amount += incrementAmounts[i] = amount * percent * 0.01m;
            }

            return incrementAmounts;
        }

        /*
         * Cуммы вклада через три, четыре, ..., двенадцать месяцев.
         * Метод возвращает массив, с суммами вклада через указанные месяца.
         */
        static public decimal[] DepositAmount(decimal amount, decimal percent, uint months)
        {
            if (amount < 0 || percent < 0 || percent > 100)
                throw new ArgumentException();

            var incrementAmounts = new decimal[months];
            var coefficient = percent * 0.01m;

            // Первые два месяца расчитываем отдельно
            amount = amount * (1.0m + coefficient) * (1.0m + coefficient);

            for (var i = 0; i < incrementAmounts.Length; i++)
            {
                incrementAmounts[i] = amount += amount * coefficient;
            }

            return incrementAmounts;
        }
    }
}
