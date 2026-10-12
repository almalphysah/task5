using System;

class Program
{
    static void Main()
    {
        // 1. Объявить массив снаряжения путешественника expeditionGear из 5 предметов.
        string[] expeditionGear = { "Мачете", "Противомоскитная сетка", "Огниво", "Очищающие таблетки", "Полевой блокнот" };

        // 2. Создать 3 параллельных массива для опасностей джунглей: угроза, живучесть, штраф к скорости.
        string[] threats = { "Ядовитая гадюка", "Чёрный кайман", "Тропическая лихорадка" };

        int[] vitality = { 25, 70, 115 };
        int[] speedPenalty = { 2, 5, 4 };

        Console.WriteLine("=== ЭКСПЕДИЦИЯ ПО ДЖУНГЛЯМ АМАЗОНКИ ===");
        Console.WriteLine("");
        Console.WriteLine("Опасности:");

        for (int i = 0; i < threats.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {threats[i]} — {vitality[i]} HP, штраф к скорости: {speedPenalty[i]}");
        }

        // 3. Создать массив пройденных километров сквозь сельву kmWalked на 5 дней пути.
        int[] kmWalked = { 12, 9, 15, 7, 11 };

        // 4. Вывести содержимое походного ранца через цикл for.
        Console.WriteLine("");
        Console.WriteLine("Содержимое походного ранца:");

        for (int i = 0; i < expeditionGear.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {expeditionGear[i]}");
        }

        // 5. Использовать Array.IndexOf для поиска "Мачете" при расчистке тропы через заросли лиан.
        string itemToFind = "Мачете";
        int macheteIndex = Array.IndexOf(expeditionGear, itemToFind);

        if (macheteIndex != -1)
        {
            Console.WriteLine("");
            Console.WriteLine($"Предмет «{itemToFind}» найден в слоте {macheteIndex + 1}. Можно расчищать лианы.");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Предмет «{itemToFind}» не найден. Расчистить тропу не получится.");
        }

        // 6. Записать потери питьевой воды (в миллилитрах) в массив waterLossLog на 6 переходов.
        int[] waterLossLog = { 450, 600, 520, 700, 480, 650 };

        Console.WriteLine("");
        Console.WriteLine("Потери питьевой воды по переходам в мл:");

        for (int i = 0; i < waterLossLog.Length; i++)
        {
            Console.WriteLine($"Переход {i + 1}: {waterLossLog[i]} мл");
        }

        // 7. Найти самый тяжелый день перехода (максимум пройденных километров) в kmWalked.
        int maxKm = kmWalked[0];
        int hardestDay = 1;

        for (int i = 1; i < kmWalked.Length; i++)
        {
            if (kmWalked[i] > maxKm)
            {
                maxKm = kmWalked[i];
                hardestDay = i + 1;
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"Самый тяжёлый день перехода: день {hardestDay}, пройдено {maxKm} км.");

        // 8. Вычислить среднесуточную потерю воды путешественником.
        int totalWaterLoss = 0;

        for (int i = 0; i < waterLossLog.Length; i++)
        {
            totalWaterLoss += waterLossLog[i];
        }

        double averageWaterLoss =
            (double)totalWaterLoss / waterLossLog.Length;

        Console.WriteLine($"Всего потеряно воды: {totalWaterLoss} мл.");
        Console.WriteLine($"Средняя потеря воды за переход: {averageWaterLoss:F1} мл.");

        // 9. Отсортировать массив переходов kmWalked по возрастанию с помощью Array.Sort.
        Array.Sort(kmWalked);

        Console.WriteLine("");
        Console.WriteLine("Пройденные километры по возрастанию: " + string.Join(", ", kmWalked));

        // 10. Обнулить первые 2 слота припасов с помощью Array.Clear после переправы через реку.
        Console.WriteLine("");
        Console.WriteLine("Переправа через реку завершена. Первые два слота экипировки очищены.");

        Array.Clear(expeditionGear, 0, 2);

        Console.WriteLine("Содержимое ранца после переправы:");

        for (int i = 0; i < expeditionGear.Length; i++)
        {
            string slot;

            if (expeditionGear[i] == null)
            {
                slot = "Пусто";
            }
            else
            {
                slot = expeditionGear[i];
            }

            Console.WriteLine($"{i + 1}. {slot}");
        }
    }
}
