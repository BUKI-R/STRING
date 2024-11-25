using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Сравненение и преобразование стихов");
string stih1 = "\r\nКлубника \r\nА клубника! А клубника!\r\nГладит длинные усы, -\r\n«Не найти вкуснее ягод –\r\nУгощайтесь малыши!»";
Console.WriteLine(stih1);
string stih2 = "\r\nАрбуз \r\nВсех главней арбуз на грядке -\r\nНаблюдает за порядком,\r\nЧтобы солнце всем светило\r\nИ воды на всех хватило!";
Console.WriteLine(stih2);
Console.WriteLine("\r\nСравнение и преобразования:");
Console.WriteLine($"Сравнение Compare = {String.Compare(stih1, stih2)}");
Console.WriteLine($"Сравнение методом '==' = {stih1 == stih2}");
Console.WriteLine($"Сравнение методом '!=' = {stih1 != stih2}");
Console.WriteLine($"Сравнение CompareOrdinal = {String.CompareOrdinal(stih1, stih2)}"); 
Console.WriteLine($"Нахождение индекса от стиха Клубника к стиху Арбуз = {stih1.IndexOf(stih2)}"); 
Console.WriteLine($"Нахождится ли подстрока в строке от стиха Арбуз к стиху Клубника = {stih2.Contains(stih1)}");