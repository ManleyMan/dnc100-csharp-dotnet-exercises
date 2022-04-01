using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

       

        /* Alright - your turn now! */

      //  1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
            public static string SayHello(string name)
        {
            return "Hello John!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int x,int y) 
        { 
            return x + y;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static int Divide(int x, int y) 
        { 
            return x / y; 
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if( age >= 18)
            {
                return true;
            }
            else { return false; }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            int space = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, space);
            return firstName;
        }
       
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
       public static string ReverseStringHard(string quote)
        {
            string reversedString = "";
           for(int i = quote.Length - 1; i >= 0; i--)
            {
              reversedString += quote[i];
            }
           return reversedString;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string quote)
        {
            char[] stringArray = quote.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int x)
        {
            string result ="";
          
           for(int i=1; i <= 10 ; i++){
               
            result += ($"{x} * {i} = {x*i}");
            if(i < 10)
                {
                    result += "\r\n";
                }
            } 
           Console.WriteLine(result);
            return  result;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin){
            double fahrenheit = (kelvin - 273.15) * 9/5 + 32;
            return Math.Round(fahrenheit,2);
         }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] array)
        {
            double avg = 0;
            for(int i = 0; i < array.Length; i++)
            {
                avg += array[i];
           }
            avg = avg / array.Length;
          Console.WriteLine(avg);
         return avg;
      }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
         public static double GetAverageEasy(int[] array)
        {
          return Queryable.Average(array.AsQueryable());
            
      }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
         /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
       public static string DrawTriangle(int x, int y)
        {
         string result = "";      
         int i, j, k ;  
         for (i = 1; i <= y; i++)  
         {  
            for (j = 1; j <= y-i; j++)  
            {  
              
            }  
            for (k = 1; k <= j; k++)  
            {  
               result += ($"{x}");  
            } 
            if(i < y){ 
            result += "\r\n"; 
                }
         }  
         Console.WriteLine(result);
            return result;
        }
       
       

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int h, int m, int s)
        {
            double timeSec;
            double kph;
           // double mps;
            double mph;
            timeSec = h + (m*60) + s;
            mph = distance/timeSec;
             kph = (distance/1000.0f)/(timeSec/3600.0f);
            // mph = kph / 1.609f;
         //   double mph = distance / (h+m+s);
            Console.WriteLine(mph);
            return mph.ToString("MPH");
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char x)
        {
            if( x == 'a')
            {
                return true;
            }
             if( x == 'e')
            {
                return true;
            }
              if( x == 'o')
            {
                return true;
            }
               if( x == 'i')
            {
                return true;
            }
                if( x == 'u')
            {
                return true;
            }
            else { return false; }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char x)
        {
             if( x == 'a')
            {
                return false;
            }
             if( x == 'e')
            {
                return false;
            }
              if( x == 'o')
            {
                return false;
            }
               if( x == 'i')
            {
                return false;
            }
                if( x == 'u')
            {
                return false;
            }
            else { return true; }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int x)
        {
            int counter = 0;
            int result = 0;
            while (x > 1)
            {
                if(x == 1)
                {
                    break;
                }
                if((x % 2) == 0)
                {
                    result = x / 2;
                    x = result;
                    counter++;
                }
                else
                {
                    result = (x * 3) + 1;
                    x = result;
                    counter++;
                }
            }
            return counter;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime date)
        {
          DateTime[] Dates = new DateTime[7];
        for(int i = 0; i < 7; i++) { 
                 Dates[i] = new DateTime(date.Year, date.Month, date.Day + i); 
            }
         return Dates;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int year)
        {
           if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double p, double r, int n, int PayPeriod)
        {
             n = n* PayPeriod;
             r = r / 100 / PayPeriod;
            double x = Math.Pow((1+r),n);
            double mortgage = Math.Round((p*(r*x)/(x-1)),2);
            return mortgage;
        }
       

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        public static string DuckGoose(int x)
        {
            
            string result = "";
            for(int i = 1; i <= x; i++)
            {
                if( i % 3 == 0)
                {
                     result += "Duck";
                }
                if( i % 5 == 0)
                {
                     result += "Goose";
                }
                else if( i % 3 == 0 && i % 5 == 0)
                {
                    result += "DuckGoose";
                }
                if( i % 3 != 0 && i % 5 != 0 )
                {
                    result += $"{i}";
                }
                if( i < x)
                {
                    result += "\r\n";
                }
            }
            return result;
        }
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}