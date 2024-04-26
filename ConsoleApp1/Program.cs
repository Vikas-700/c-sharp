
// 1) Write a Program in C# to print Hello World.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


// 2) Write a program in C# to show addition, multiplication, subtraction and division.
using System;
class Program
{
    static void Main(string[] args)
    {
        int x=10;
        int y=2;
        System.Console.WriteLine("Addition:"+(x+y));
        System.Console.WriteLine("Multiplication:"+(x*y));
        System.Console.WriteLine("Subtraction:"+(x-y));
        System.Console.WriteLine("Division:"+(x/y));
    }
}



// 3) Write a program in C# to show implicit and explicit casting.
using System;
class Program
{
    static void Main(string[] args)
    {
       //implicit type casting
       int x=10;
       double y=x;
       System.Console.WriteLine(y);
       //Explicit type casting
       double a=10.0;
       int b=(int)a;
       System.Console.WriteLine(y);
    }
}



// 4) Write a program in C# to show Boxing and Unboxing. 
using System;
class Program
{
    static void Main(string[] args)
    {
        
        int x=10;
        //boxing
        object boxingX=x;
        System.Console.WriteLine(boxingX);
        //Unboxing
        int unboxingX=(int) boxingX;
        System.Console.WriteLine(unboxingX);
    }
}


// 5) Write a program in C# to check whether the entered number is palindrome or not.
using System;
class Program
{
    static void Main(string[] args)
    {
      System.Console.WriteLine("Enter A Number:");
      int numInput=Convert.ToInt32(Console.ReadLine());
      int num=numInput;
      int reverceNumver=0;
      while(num>0){
        int digit=num%10;
        reverceNumver=reverceNumver*10+digit;
        num/=10;
      }
      if(numInput==reverceNumver){
        System.Console.WriteLine("Palindrone");
      }
      else{
        System.Console.WriteLine("Not a Palindrone");
      }
    }
}



// 6) Write a program in C# to check whether the entered number is even, odd or a prime number.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter A Number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0 || num < 0)
        {
            Console.WriteLine("less then 0 or 0.");
        }
        else if(num==1){
            System.Console.WriteLine("Odd Number.");
        }
        else if (num == 2)
        {
            Console.WriteLine("Prime number.");
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("Even Number.");
        }
        else
        {
            bool prime = true;
            for (int x = 3; x < num; x += 2)
            {
                if (num % x == 0)
                {
                    prime = false;
                    Console.WriteLine("Odd number.");
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime number.");
            }
        }
    }
}





// 7) Write a program in C# to check whether the entered number is an Armstrong number or not.
using System;
class Program{
    static void Main(string [] args){
        System.Console.WriteLine("Enter a Number");
        int num=Convert.ToInt32(Console.ReadLine());
        int realNumber=num;
        int digits=num.ToString().Length;
        int armstrong=0;
        while(num>0){
            int x=num%10;
            armstrong +=(int)Math.Pow(x,digits);
            num/=10;
        }
        if(realNumber==armstrong){
            System.Console.WriteLine("Armstrong Number.");
        }
        else{
            System.Console.WriteLine("Not A Armstrong Number.");
        }
    }
}


// 8) Write a program in C# to find the factorial of a number.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number:");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num<0){
            System.Console.WriteLine("Enter Positive Number.");
        }
        else if(num==1 || num==0){
            System.Console.WriteLine("Factorial="+1);
        }
        else{
        int factorial=1;
        for (int i = num; i > 1; i--)
        {
            factorial*=i; 
        }
        System.Console.WriteLine("Factorial="+factorial);
        }
    }
}



// 9) Write a program in C# to reverse a string.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        char[] stringAsCharArray = inputString.ToCharArray();
        Array.Reverse(stringAsCharArray);

        string reversedString = new string(stringAsCharArray);

        Console.WriteLine("Reversed string: " + reversedString);
    }
}



// 10) Write a program in C# to check whether the entered year is a leap year or not.
using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Year:");
        int year=Convert.ToInt32(Console.ReadLine());
        if( year%4==0 && year%100!=0 ||year%400==0){
            System.Console.WriteLine("It is a Leep year.");
        }
        else{
            System.Console.WriteLine("Not A Leep Year.");
        }

    }
}



// 11) Write a program in C# to declare an array and add 2 to each element of the array.
using System;
class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Array Size:");
        int size=Convert.ToInt32(Console.ReadLine());
        int [] arr= new int [size];
        for (int i = 0; i<size; i++)
        {
            System.Console.WriteLine("Enter for index: "+i);
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine("Add 2 to Each Elsement:");
        for (int i = 0; i<10; i++)
        {
            System.Console.Write(arr[i]+2+"\t");
        }
    }
}



// 12) Write a program in C# to Show addition of two arrays
using System;
class Program
{
    private static void Main(string[] args)
    {
        int [] arr1={1,2,3,4,5,6,7,8,9,10};
        int [] arr2={2,4,6,8,10,12,14,16,18,20};
        int [] arr3=new int[10];
        for (int i =0;i<10;i++){
            arr3[i]=arr1[i]+arr2[i];
        }
        System.Console.WriteLine("First Array:");
        foreach(int i in arr1){
            System.Console.Write(i+" ");
        }
        System.Console.WriteLine("\nSecond Array:");
        foreach(int i in arr2){
            System.Console.Write(i+" ");
        }
        System.Console.WriteLine("\nAfter Addition Array:");
        foreach(int num in arr3){
            System.Console.Write(num+" ");
        }
    }
}



// 13) Write a program in C# to show multiplication in arrays.
using System;
class Program
{
    private static void Main(string[] args)
    {
        int [] arr1={1,2,3,4,5,6,7,8,9,10};
        int [] arr2={2,4,6,8,10,12,14,16,18,20};
        int [] arr3=new int[10];
        for (int i =0;i<10;i++){
            arr3[i]=arr1[i]*arr2[i];
        }
        System.Console.WriteLine("First Array:");
        foreach(int i in arr1){
            System.Console.Write(i+" ");
        }
        System.Console.WriteLine("\nSecond Array:");
        foreach(int i in arr2){
            System.Console.Write(i+" ");
        }
        System.Console.WriteLine("\nAfter Multiplication Array:");
        foreach(int num in arr3){
            System.Console.Write(num+" ");
        }
    }
}




// 14) Write a program in C# to check whether an array element is even or odd.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {11, 20, 33, 44, 57, 68, 79, 87, 96, 108};
        Console.WriteLine("Array elements and their parity:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"{arr[i]} is even");
            }
            else
            {
                Console.WriteLine($"{arr[i]} is odd");
            }
        }
    }
}



// 15) Write a program in C# to show method overloading.
using System;
class Program
{
    static void Main(string[] args)
    {
        int result1 = Add(2, 3);
        int result2 = Add(2, 3, 4);
        double result3 = Add(2.5, 3.5);
        Console.WriteLine("Result 1: " + result1);
        Console.WriteLine("Result 2: " + result2);
        Console.WriteLine("Result 3: " + result3);
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Add(double a, double b)
    {
        return a + b;
    }
}



// 16) Write a program in C# to show method overriding.
using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog();
        animal.MakeSound();

        Dog dog=new Dog();
        dog.MakeSound();
    }
}




// 17) Write a program in C# to print numbers in a given range.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the start of the range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the end of the range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        if (start > end)
        {
            Console.WriteLine("Numbers in the range:");

            for (int i = start; i >= end; i--)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Numbers in the range:");

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}




// 18) Write a C# program to find the largest of two numbers.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else
        {
            Console.WriteLine("The largest number is: " + num2);
        }
    }
}



// 19) Write a C# programs to find the sum of all the multiples of 3 and 5.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("The sum of all the multiples of 3 and 5 up to " + limit + " is: " + sum);
    }
}


// 20) Write a C# program to find sum of digits of a number.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("The sum of the digits of is: " + sum);
    }
}


// 21) Write a C# program to find sum of two binary numbers
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first binary number: ");
        string binNum1 = Console.ReadLine();

        Console.Write("Enter the second binary number: ");
        string binNum2 = Console.ReadLine();

        int decimalNum1 = Convert.ToInt32(binNum1, 2);
        int decimalNum2 = Convert.ToInt32(binNum2, 2);

        int sum = decimalNum1 + decimalNum2;

        Console.WriteLine("The sum of the two binary numbers in decimal is: " + sum);

        string binSum = Convert.ToString(sum, 2);

        Console.WriteLine("The sum of the two binary numbers in binary is: " + binSum);
    }
}




// 22) Write a C# program to print multiplication table.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the table: ");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
    }
}

// 23) Write a C# program to demonstrate the use of conditional logical operators.
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int c = 30;

        if (a > b && a > c)
        {
            Console.WriteLine("a is greater than both b and c");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("b is greater than both a and c");
        }
        else
        {
            Console.WriteLine("c is greater than both a and b");
        }

        if (a > b || a > c)
        {
            Console.WriteLine("a is greater than either b or c");
        }
        else
        {
            Console.WriteLine("a is not greater than either b or c");
        }

        if (!(a > b))
        {
            Console.WriteLine("a is not greater than b");
        }

        if (a > b || a > c && b > c)
        {
            Console.WriteLine("a is greater than c or b is greater than c");
        }
    }
}




// 24) Write a C# program to generate Fibonacci series.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of terms in the Fibonacci series: ");
        int numTerms = Convert.ToInt32(Console.ReadLine());

        int num1 = 0;
        int num2 = 1;

        Console.WriteLine("Fibonacci series:");

        for (int i = 0; i < numTerms; i++)
        {
            Console.Write(num1 + " ");

            int num3 = num2 + num1;
            num1 = num2;
            num2 = num3;
        }
    }
}



//25) Write a C# program to print all the Prime numbers between 1 to 100
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}



// 26) Write a C# program to print sum of first 50 natural numbers using for loop.
using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 1; i <= 50; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of first 50 natural numbers: " + sum);
    }
}