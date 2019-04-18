using System;

namespace myApp
{
    class Program
    {
        //Methods / Functions
        // this method return nothing. becaue of void
        static void SayHi(string name , int age)
        {
            Console.WriteLine("Hello " + name + " You Are " + age);
        }

        // this method returns int
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if(num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
        static int GetMaxThree(int num1, int num2, int num3)
        {
            int result;
            if(num1 >= num2 && num1>= num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } 
            else{
                result = num3;
            }
            return result;
        }


        static string GetDay (int dayNum)
        {   
            string dayName;

            switch(dayNum){
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName="Invalid Day Number";
                    break;

            }
            return dayName;
        }


        static void Main(string[] args)
        {
            // string phrase = "C-Sharp is awesome";
            // char grade = 'c';
            // int age = 30;
            // // double gpa = 3.0;

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase + " " + age);
            Console.WriteLine(phrase.Contains("is"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("is"));
            Console.WriteLine(phrase.IndexOf("bad"));
            Console.WriteLine(phrase.Substring(11));
            Console.WriteLine(phrase.Substring(11,3));
            
            // int num = 6;
            Console.WriteLine(num);   //6
            Console.WriteLine(num++); //6
            Console.WriteLine(++num); //8
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Sqrt(36));

            //Getting info from User
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", You Are " + age);
            
            // Convert string to integer
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 20);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            string color, pluralNoun,celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            //Arrays
            int [] luckyNumbers = { 7, 12, 4, 8, 15, 16, 32, 43};
            Console.WriteLine(luckyNumbers[0]);
            luckyNumbers[2] = 13;
            Console.WriteLine(luckyNumbers[2]);

            string [] friends = new string[5];
            friends[0] = "Steve";
            friends[1] = "Mike";
            friends[2] = "Mario";
            Console.WriteLine(friends[2]);

            //calling methods
            SayHi("Ahmad", 30);
            SayHi("John",29);
            SayHi("Mark",27);

            Console.WriteLine(cube(5));

            // if statements
            bool isMale = true;
            bool isTall = true;
            // && - ||
            if(isMale && isTall)
            {
                Console.WriteLine("You are Tall Male");
            } else
            {
                Console.WriteLine("is not Male");
            }

            Console.WriteLine(GetMax(20,4));
            Console.WriteLine(GetMaxThree(3,30,4));

            
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator:");
            String op = Console.ReadLine();
            Console.Write("Enter a Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if(op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else if(op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else{
                Console.WriteLine("Invalid Operator");
            }


            Console.WriteLine(GetDay(0));

            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else{
                    outOfGuesses = true;
                }
                
            }
            if(outOfGuesses)
            {
                Console.Write("You Lose!");    
            } else{
                Console.Write("You Won!");
            }



            Console.ReadLine();
        }
    }
}
