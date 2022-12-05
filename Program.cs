using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());


            //if (a == b)
            //{
            //    Console.WriteLine("mutqagrvac tvery havasar en");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine("maximum = " + a);
            //}
            //else
            //{
            //    Console.WriteLine("maximum = " + b);
            //}



            /*Переменные и константы*/

            //string name = "bob";
            //Console.WriteLine(name);

            //name = "jhon";
            //Console.WriteLine(name);


            //Console.WriteLine("hello \nworld");
            //Console.WriteLine("hello \tworld");
            //Console.WriteLine("hello \\world");


            /*Типы данных*/

            //bool: хранит значение true или false(логические литералы).
            //bool alive = true;
            //bool isDead = false;

            //byte: хранит целое число от 0 до 255 и занимает 1 байт.
            //byte bit1 = 1;
            //byte bit2 = 102;

            //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
            //sbyte bit1 = -101;
            //sbyte bit2 = 102;

            //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
            //short n1 = 1;
            //short n2 = 102;

            //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
            //ushort n1 = 1;
            //ushort n2 = 102;

            //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            //Все целочисленные литералы по умолчанию представляют значения типа int:
            //int a = 10;
            //int b = 0b101;  // бинарная форма b =5
            //int c = 0xFF;   // шестнадцатеричная форма c = 255

            //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта.
            //uint a = 10;
            //uint b = 0b101;
            //uint c = 0xFF;
            //uint a = 10U;

            //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            //long a = -10;
            //long b = 0b101;
            //long c = 0xFF;
            //long b = 20L;

            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            //ulong a = 10;
            //ulong b = 0b101;
            //ulong c = 0xFF;
            //ulong c = 30UL;

            //float: хранит число с плавающей точкой от -3.4 * 1038 до 3.4 * 1038 и занимает 4 байта.
            //float a = 3.14F;
            //float b = 30.6f;
            //double: хранит число с плавающей точкой от ±5.0 * 10 - 324 до ±1.7 * 10308 и занимает 8 байта.
            //все вещественные литералы(дробные числа) рассматриваются как значения типа double.
            //decimal: хранит десятичное дробное число.
            //Если употребляется без десятичной запятой, имеет значение от ±1.0 * 10 - 28 до ±7.9228 * 1028,
            //может хранить 28 знаков после запятой и занимает 16 байт.
            //decimal c = 1005.8M;
            //decimal d = 334.8m;

            //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            //Этому типу соответствуют символьные литералы:
            //char a = 'A';
            //char b = '\x5A';
            //char c = '\u0420';

            //string: хранит набор символов Unicode.
            //Этому типу соответствуют строковые литералы.
            //string hello = "Hello";
            //string word = "world";

            //object: может хранить значение любого типа данных и занимает 4 байта на 32 - разрядной платформе
            //и 8 байт на 64 - разрядной платформе.
            //object a = 22;
            //object b = 3.14;
            //object c = "hello code";

            ////primer
            //string name = "Tom";
            //int age = 33;
            //bool isEmployed = false;
            //double weight = 78.65;
            //Console.WriteLine($"name: {name}");
            //Console.WriteLine($"age: {age}");
            //Console.WriteLine($"weight: {weight}");
            //Console.WriteLine($"isEmployed: {isEmployed}");


            /*(Консольный ввод - вывод)*/

            ////Console.WriteLine() (Консольный ввод-вывод)
            //string hello = "Hello World";
            //Console.WriteLine(hello);
            //Console.WriteLine("Welcom to C#!");
            //Console.WriteLine("Goodbay World...");
            //Console.WriteLine(24.5);

            //интерполяция
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.WriteLine($"name: {name}  age: {age}  height: {height}m");

            //плейсхолдер
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.WriteLine("name: {0}  age: {2}  height: {1}m", name, height, age);

            ////Console.Write()
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.Write($"name: {name}  age: {age}  height: {height}m");

            ////Console.ReadLine()
            //Console.Write("Your Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            ////Convert
            //Console.Write("Your Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Your Height: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Your Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"name: {name}  age: {age}  height: {height}m  salary: {salary}$");


            /* Арифметические операции языка C# */

            //1.Инкремент, декремент

            //2.Умножение, деление, получение остатка

            //3.Сложение, вычитание

            //++
            //Операция инкремента
            //Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1,
            //а потом ее значение возвращается в качестве результата операции.
            //И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается
            //в качестве результата операции, а затем к нему прибавляется 1.
            //int x1 = 5;
            //int z1 = ++x1; // z1=6; x1=6
            //Console.WriteLine($"{x1} - {z1}");

            //int x2 = 5;
            //int z2 = x2++; // z2=5; x2=6
            //Console.WriteLine($"{x2} - {z2}");


            //--
            //Операция декремента или уменьшения значения на единицу.
            //Также существует префиксная форма декремента(--x) и постфиксная(x--).
            //int x1 = 5;
            //int z1 = --x1; // z1=4; x1=4
            //Console.WriteLine($"{x1} - {z1}");

            //int x2 = 5;
            //int z2 = x2--; // z2=5; x2=4
            //Console.WriteLine($"{x2} - {z2}");


            //int x = 10;
            //int z = x / 5; // 2
            //Console.WriteLine(z);

            //double a = 10;
            //double b = 3;
            //double c = a / b; // 3.33333333
            //Console.WriteLine(c);

            //int a = 3;
            //int b = 5;
            //int c = 40;
            //int d = c-- - b * a;    // a=3  b=5  c=39  d=25
            //Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");

            //int a = 3;
            //int b = 5;
            //int c = 40;
            //int d = (c - (--b)) * a;    // a=3  b=4  c=40  d=108
            //Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");

            //int x = 10 / 5 * 2;     //x=4 Все арифметические операторы являются левоассоциативными
            //Console.WriteLine(x);


            /*Поразрядные операции*/
            ////Логические операции

            //// &(логическое умножение) 

            //int x1 = 2; //010
            //int y1 = 5; //101
            //Console.WriteLine(x1 & y1); // выведет 0 //Поразрядно умножим числа (0*1, 1*0, 0*1) = 000.

            //int x2 = 4; //100
            //int y2 = 5; //101
            //Console.WriteLine(x2 & y2); // выведет 4 //Поразрядно умножим числа (1*1, 0*0, 0 *1) = 100(2akan), то есть число 4(10akan)

            //// | (логическое сложение)

            //int x1 = 2; //010
            //int y1 = 5; //101
            //Console.WriteLine(x1 | y1); // выведет 7 - 111
            //int x2 = 4; //100
            //int y2 = 5; //101
            //Console.WriteLine(x2 | y2); // выведет 5 - 101

            //// ^(логическое исключающее ИЛИ) XOR

            //int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            //int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

            //int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            //Console.WriteLine($"Зашифрованное число: {encrypt}");

            //int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            //Console.WriteLine($"Расшифрованное число: {decrypt}");

            //// ~(логическое отрицание или инверсия) NOT

            //int x = 12;                 // 00001100
            //Console.WriteLine(~x);      // 11110011   или -13

            //int x = 12;
            //int y = ~x;
            //y += 1;
            //Console.WriteLine(y);   // -12

            //// Операции сдвига

            //int a = 16; // в двоичной форме 10000
            //int b = 2; // в двоичной форме
            //int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

            //Console.WriteLine($"{c}");    // 64

            //int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
            //Console.WriteLine($"{d}");    // 4

            //int a = 22; // в двоичной форме 10110
            //int b = 2; // в двоичной форме
            //int c = a << b; // Сдвиг числа 10110 влево на 2 разряда, равно 1011000 или 88 в десятичной системе

            //Console.WriteLine($"{c}");    // 88

            //int d = a >> b; // Сдвиг числа 10110 вправо на 2 разряда, равно 101 или 5 в десятичной системе
            //Console.WriteLine($"{d}");    // 5


            /*Операции присваивания*/

            //int number = 23;
            //Console.WriteLine(number);

            //int a, b, c;
            //a = b = c = 34 * 2 / 4; // 17
            //Console.WriteLine(a);

            //int a = 10;
            //a += 10;        // 20
            //a -= 4;         // 16
            //a *= 2;         // 32
            //a /= 8;         // 4
            //a <<= 4;        // 64
            //a >>= 2;        // 16
            //Console.WriteLine(a);

            //Операции присвоения являются правоассоциативными, то есть выполняются справа налево. Например:
            //int a = 8;                     
            //int b = 6;
            //int c = a += b -= 5;    // 9
            //Console.WriteLine(c);


            /*Условные выражения*/
            ////Операции сравнения

            //// ==
            //int a = 10;
            //int b = 4;
            //bool c = a == b; // false
            //Console.WriteLine(c);

            //// !=
            //int a = 10;
            //int b = 4;
            //bool c = a != b;    // true
            //bool d = a != 10;     // false
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //// <
            //int a = 10;
            //int b = 4;
            //bool c = a < b; // false
            //Console.WriteLine(c);

            //// >
            //int a = 10;
            //int b = 4;
            //bool c = a > b;     // true
            //bool d = a > 25;    // false
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //// <=
            //int a = 10;
            //int b = 4;
            //bool c = a <= b;     // false
            //bool d = a <= 25;    // true
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            ////>=
            //int a = 10;
            //int b = 4;
            //bool c = a >= b;     // true
            //bool d = a >= 25;    // false
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //// | OR //Возвращает true, если хотя бы один из операндов возвращает true.
            //bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            //bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //// & AND //Возвращает true, если оба операнда одновременно равны true.
            //bool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            //bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
            ////Console.WriteLine(x1);
            ////Console.WriteLine(x2);

            //// ! NOT
            //bool a = true;
            //bool b = !a;    // false
            //Console.WriteLine(b);

            //// ^ XOR
            //bool x5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            //bool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
            //Console.WriteLine(x5);
            //Console.WriteLine(x6);


            /*Конструкция if..else и тернарная операция*/

            ////Выражение if

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1 > num2);
            //}

            // или так

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2)
            //    Console.WriteLine(num1 > num2);

            // или так

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2) Console.WriteLine(num1 > num2);

            //Также мы можем соединить сразу несколько условий, используя логические операторы:
            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2 && num1 == 8)
            //{
            //    Console.WriteLine(num1 > num2);
            //}

            ////Выражение else

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1 > num2);
            //}
            //else
            //{
            //    Console.WriteLine(num1 < num2);
            //}

            // или так

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2)
            //    Console.WriteLine(num1 > num2);
            //else
            //    Console.WriteLine(num1 < num2);

            ////Выражение else if

            //int num1 = 8;
            //int num2 = 6;
            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1 > num2);
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine(num1 < num2);
            //}
            //else
            //{
            //    Console.WriteLine(num1 == num2);
            //}


            //string name = "Alex";

            //if (name == "Tom")
            //    Console.WriteLine("You ar Tomas");
            //else if (name == "Bob")
            //    Console.WriteLine("You ar Robert");
            //else if (name == "Mike")
            //    Console.WriteLine("You ar Michael");
            //else
            //    Console.WriteLine("unknown name");

            ////Тернарная операция
            //[первый операнд -условие] ? [второй операнд] : [третий операнд]
            //если условие равно true, то возвращается второй операнд; если условие равно false, то третий.

            //int x = 3;
            //int y = 2;
            //int z = x < y ? (x + y) : (x - y);
            //Console.WriteLine(z);   // 1

        }
    }
}
