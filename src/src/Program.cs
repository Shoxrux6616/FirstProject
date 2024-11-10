namespace src;

public class Program
{
    static void Main(string[] args)
    {
        /*// 11
        Console.Write("4 honali son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;
        var thousand = number / 1000;

        var resault = thousand * 1000 + hundreds * 100 + ones * 10 + tens;
        Console.WriteLine(resault);*/

        /*// 12
        Console.Write("3 honali son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;

        var resault = tens * 100 + hundreds * 10 + ones;

        Console.WriteLine(resault);*/

        /*// 13
        Console.Write("4 honali son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;
        var thousand = number / 1000;

        var resault = tens * 1000 + hundreds * 100 + thousand * 10 + ones ;
        Console.WriteLine(resault);*/

        /*// 14
        Console.WriteLine("GB kiriting = ");
        
        var gb = Convert.ToInt32(Console.ReadLine());
        var mb = gb * 1000;

        Console.WriteLine(mb + " mb");*/

        /*// 15
        Console.WriteLine("TB kiriting = ");

        var gb = Convert.ToInt64(Console.ReadLine());
        var bit = gb * 1000000;

        Console.WriteLine(bit + " bit");*/

        /*// 16
        Console.WriteLine("TB kiriting = ");

        var tb = Convert.ToInt32(Console.ReadLine());
        var gb = tb / 1000;

        Console.WriteLine(gb + " bit");*/

        /*// 17
        Console.WriteLine("Fleshka xotirasini kiriting =");
        var number = Convert.ToInt32(Console.ReadLine());

        var resault = number / 2;
        Console.WriteLine(resault + " ta kino ketadi");
        Main(args);*/

        ///////////////////////////////////////////

        /*// 2
        Console.Write("Son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var resault = number * number * number;
        resault = resault * resault;

        Console.WriteLine("Sonning 6 chi darajasi " + resault);*/

        /*// 3 
        Console.Write("Son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var resault = number * number;
        resault = resault * resault;
        resault = resault * resault;

        Console.WriteLine("Sonning 8 chi darajasi " + resault);*/

        //////////////////////////////////////////

        /*// 1
        Console.Write("Son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/

        /*// 2
        Console.Write("Son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/

        /*// 3
        Console.WriteLine("2 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 9 && number < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 4
        Console.WriteLine("4 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 999 && number < 10000)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 5
        Console.WriteLine("2 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 9 && number < 100 && number % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 6
        Console.WriteLine("3 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 99 && number < 1000 && number % 2 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 7
        Console.WriteLine("4 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 999 && number < 10000 && number % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 8
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if(numberOne % 2 != 0 && numberTwo % 2 != 0)
        {
            Console.WriteLine("True");
        }
        else 
        { 
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 9
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne % 2 == 0 && numberTwo % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 10
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne % 2 != 0 && numberTwo % 2 != 0 && numberOne > 9 && numberOne < 100 && numberTwo > 9 && numberTwo < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 11
        Console.WriteLine(" Son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10;

        if (ones == tens)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 12
        Console.WriteLine("2 son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10;

        if(ones + tens > 10 && number > 9 && number < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 13
        Console.WriteLine("2 son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10;

        if (ones * tens > 20 && number > 9 && number < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 14
        Console.WriteLine("2 son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10;

        if (ones % 2 != 0 && tens % 2 != 0 && number > 9 && number < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 15
        Console.WriteLine("2 son kiriting = ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10;

        if (ones > 5 && tens > 5 && number > 9 && number < 100)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 16
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if(a % 3 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 17
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if (a % 7 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 18
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if (a % 3 == 0 || a % 8 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 19
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if (a % 9 == 0 || a % 7 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 21
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if (a % 5 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 22
        Console.WriteLine("Son kiriting = ");
        var a = Convert.ToInt32(Console.ReadLine());

        if (a % 4 != 0 || a % 3 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 23
        Console.Write("1 son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/

        /*// 24
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/

        /*// 25
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c son : ");
        var c = Convert.ToInt32(Console.ReadLine());

        if (a > b || a > c || b > c || c < b || b == c)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 26
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c son : ");
        var c = Convert.ToInt32(Console.ReadLine());

        if (c > b || c > a || b > a || a > b || b == a)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 27
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c son : ");
        var c = Convert.ToInt32(Console.ReadLine());

        if (b < a || b < c || a > c || c < a || a == c)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 28
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        if (a >= 2 * b)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 29
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        if (b >= 5 * a)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        /*// 30
        Console.Write("a son : ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b son : ");
        var b = Convert.ToInt32(Console.ReadLine());

        if (a >= 4 * b || b >= 4 * a)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Main(args);*/

        ////////////////////////////////////

        /*// 10
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("1 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            Console.WriteLine("1 son kattasi " + numberOne);
        }
        else
        {
            Console.WriteLine("2 son kattasi " + numberTwo);
        }
        Main(args);*/

        /*// 11
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("1 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne < numberTwo)
        {
            Console.WriteLine("1 son kichigi " + numberOne);
        }
        else
        {
            Console.WriteLine("2 son kichigi " + numberTwo);
        }
        Main(args);*/

        /*// 12 
        Console.Write("birinchi son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("ikkinchi son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne > 9 && numberOne < 100 && numberTwo > 9 && numberTwo < 100)
        {
            Console.WriteLine("Yig'indisi : " + (numberOne + numberTwo));
        }
        else
        {
            Console.WriteLine("Ko'paytmasi : " + (numberOne * numberTwo));
        }
        Main(args);*/

        /*// 13
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("1 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne % 2 == 0 && numberTwo % 2 == 0)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
        else
        {
            Console.WriteLine(numberOne * numberTwo);
        }*/

        /*// 14
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne % 2 != 0 && numberTwo % 2 != 0)
        {
            Console.WriteLine(numberOne * numberTwo);
        }
        else
        {
            Console.WriteLine("1 son " + numberOne);
            Console.WriteLine("2 son " + numberTwo);
        }*/

        /*// 15
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.Write("3 son : ");
        var numberThree = Convert.ToInt32(Console.ReadLine());

        var count = 0;
        if (numberOne % 2 != 0) count++;
        if (numberTwo % 2 != 0) count++;
        if (numberThree % 2 != 0) count++;
        Console.WriteLine("Natija " + count + " ta");
        Main(args);*/

        /*// 16
        Console.Write("4 honali son kiriting : ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;
        var thousands = number / 1000;

        var count = 0;
        if (number > 999 && number < 10000)
        {
            if (ones % 2 == 0) count++;
            if (tens % 2 == 0) count++;
            if (hundreds % 2 == 0) count++;
            if (thousands % 2 == 0) count++;
            Console.WriteLine("Natija " + count + " ta");
        }
        else
        {
            Console.WriteLine("4 honali son kiriting?");
        }*/

        /*// 17
        Console.Write("1 son : ");
        var numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son : ");
        var numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.Write("3 son : ");
        var numberThree = Convert.ToInt32(Console.ReadLine());

        Console.Write("4 son : ");
        var numberFour = Convert.ToInt32(Console.ReadLine());

        Console.Write("4 son : ");
        var numberFive = Convert.ToInt32(Console.ReadLine());

        var count = 0;
        if (numberOne % 2 == 0) count++;
        if (numberTwo % 2 == 0) count++;
        if (numberThree % 2 == 0) count++;
        if (numberFour % 2 == 0) count++;
        if (numberFive % 2 == 0) count++;
        Console.WriteLine("Natija " + count + " ta");
        Main(args);*/

        /*// misol
        Console.Write(" son : ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;
        var thundreds = number / 1000;

        var resault = 0;
        if (number > 999 && number < 10000)
        {
            Console.WriteLine(ones + tens + hundreds + thundreds);
        }*/

        // Homework 3

        /*// 1
        Console.WriteLine("So'z kiriting : ");
        var stringValyu = Console.ReadLine();

        var replasedString = stringValyu.Replace(stringValyu, "Hello " + stringValyu + "!");

        Console.WriteLine(replasedString);*/

        /*// 2
        Console.WriteLine("1 so'z kiriting : ");
        var stringHi = Console.ReadLine();

        Console.WriteLine("2 so'z kiriting : ");
        var stringBye = Console.ReadLine();

        Console.WriteLine($"Natija : {stringHi}{stringBye}{stringBye}{stringHi}");*/

        /*// 3
        Console.WriteLine("1 so'z kiriting : ");
        var stringWordOne = Console.ReadLine();

        Console.WriteLine("2 so'z kiriting : ");
        var stringWordTwo = Console.ReadLine();

        if (stringWordOne.Length <= 4)
        {
            var resautOne = stringWordOne.Remove(2);
            var resautTwo = stringWordOne.Remove(0, 2);
            Console.WriteLine($"Natija : {resautOne}{stringWordTwo}{resautTwo}");

        }
        else
        {
            Console.WriteLine("Satirni uzunligi 4 dan oshmasligi kerak ?");
        }*/

        /*// 4
        Console.WriteLine("So'z kiriting : ");
        var stringWord = Console.ReadLine();

        var resaut = stringWord.Remove(0, stringWord.Length - 2);
        Console.WriteLine($"Natija : {resaut}{resaut}{resaut}");*/

        /*// 5
        Console.WriteLine("So'z kiriting : ");
        var stringWord = Console.ReadLine();

        if(stringWord.Length > 2)
        {
            var resaut = stringWord.Remove(2);
            Console.WriteLine($"Natija : {resaut}");
        }
        else
        {
            Console.WriteLine(stringWord);
        }
        Main(args);*/

        /*// 6
        Console.WriteLine("So'z kiriting : ");
        var stringWord = Console.ReadLine();

        if (stringWord.Length % 2 == 0)
        {
            var resaut = stringWord.Substring(0, stringWord.Length / 2);
            Console.WriteLine($"Natija : {resaut}");
        }
        else
        {
            Console.WriteLine("Faqat juft uzunlikdagi satr kiriting?");
        }*/

        /*// 7
        Console.WriteLine("So'z kiriting : ");
        var stringWord = Console.ReadLine();

        if (stringWord.Length >= 3)
        {
            var firstResaut = stringWord.Remove(0, 1);
            var secondResault = firstResaut.Remove(firstResaut.Length - 1, 1);
            Console.WriteLine($"Natija : {secondResault}");
        }
        else
        {
            Console.WriteLine("Satirlar soni 3 ta yoki 3 tadan ko'p bo'lishi kerak?");
        }*/

        /*// 8
        Console.WriteLine("1 so'z kiriting : ");
        var stringWordOne = Console.ReadLine();

        Console.WriteLine("2 so'z kiriting : ");
        var stringWordTwo = Console.ReadLine();

        var resaut = stringWordOne.Remove(0, 1);

        Console.WriteLine($" Natija : {resaut}{stringWordTwo}");*/

        /*// 9
        Console.WriteLine("1 so'z kiriting : ");
        var stringWordOne = Console.ReadLine();

        Console.WriteLine("2 so'z kiriting : ");
        var stringWordTwo = Console.ReadLine();

        if (stringWordOne.Length >= 2 && stringWordTwo.Length >= 2)
        {
            var firstResaut = stringWordOne.Remove(0, 1);
            var secondResaut = stringWordTwo.Remove(0, 1);
            Console.WriteLine($"Natija : {firstResaut}{secondResaut}");
        }
        else
        {
            Console.WriteLine("Satirlar soni 2 ta yoki 2 tadan ko'p bo'lishi kerak?");
        }*/

        /*// 10
        Console.WriteLine("2 so'z kiriting : ");
        var stringWord = Console.ReadLine();

        if (stringWord.Length >= 4)
        {
            var firstResaut = stringWord.Remove(0, 2);
            var secondResaut = stringWord.Remove(2);
            Console.WriteLine($"Natija : {firstResaut}{secondResaut}");
        }
        else
        {
            Console.WriteLine("Satirlar soni 4 ta yoki 4 tadan ko'p bo'lishi kerak?");
        }*/

        // 11

    }
}
