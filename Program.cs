﻿using System;

namespace BasicCSharp
{
    class Program
    {
        
        //creating switch case statement

        static string SampleSwithchCase(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName="Sunday";
                    break;
                case 1:
                    dayName="Monday";
                    break;
                case 2:
                    dayName="Tuesday";
                    break;
                case 3:
                    dayName="Wednesday";
                    break;
                case 4:
                    dayName="Thursday";
                    break;
                case 5:
                    dayName="Friday";
                    break;
                case 6:
                    dayName="Saturday";
                    break;
                default:
                    dayName="Invalid Number";
                    break;
            }

            return dayName;

        }


        //creating method with ifelse statement
        static void SampleIfElse(){

            bool isMale= true;
            bool isTall=true;

            if (isMale&&isTall)// you can also use OR ||
            {   //if the value is true
                Console.WriteLine("You are tall male");
            } else
            {   
                Console.WriteLine("You are not tall male");
            }
        }

        static int GetMax(int num1,int num2)
        {
            int result;
            if (num1>num2)
            {
                result = num1; 
            }else
            {
                result= num2;
            }
            return result;
        }

        //creating methods with return statements
        static int CubeMethodWithReturn(int num)
        {
            int result = num*num*num;
            return result;    
        }


        //creating methods
        // you can pass any variables data type to methods
        static void SayHiToUser(string nameOfUser)
        {
            Console.WriteLine("Hello "+ nameOfUser);
        }

        static void AllAboutVariables()
        {
            //Variables = cotainer of specific data
            //string= variables store text value of data
            string stringName;
            string stringName2;
            string zhuyin;

            //set value of string
            stringName="Class and Method names should always be in Pascal Case";
            stringName2="Method argument and Local variables should always be in Camel Case";
            zhuyin="ㄅㄆㄇㄈ";

             // \n signifies new line
            Console.WriteLine("1. "+ stringName+"\n"+stringName2);
            Console.WriteLine("try zhuyin : "+zhuyin);
           
            // .toUpper =make the string print in uppercase
            Console.WriteLine("\n Make string Uppercase: "+stringName2.ToUpper());
            
            // find letter inside the value of string by index
            Console.WriteLine("\n Find index of 0: "+stringName2[0]);
            
            // find the index value of string
            Console.WriteLine("\n Find 'should' index: "+stringName2.IndexOf("should"));

            // get the substring value from string data using substring(start,to)
            // this code will start from char 10 upto the end of string value
            Console.WriteLine("substring start from indext 10: "+stringName.Substring(10));
            // this code only gets 6 character start from index 10
            Console.WriteLine("substring start from indext 10 get 6 char: " + stringName.Substring(10,6));
            //--END of strings, for more string method you can search on google cs string methods.
        }

        static void AllAboutNumbers()
        {
            // NUMBERS
            // convert numbers to Int32 or double or any number variables
            int num= Convert.ToInt32("65");
            Console.WriteLine("Converted to int: "+num);
        }

        static void AllAboutArrays()
        {
            //Array
            int[] luckyNumbers= { 1,2,3,4,5,3 };
            Console.WriteLine("Array index 0: "+luckyNumbers[0]);

            //String Array 
            string[] friends= new string[5];//this array can stored 5 data
            // Storing data to friends array
            friends[0]="Mike";
            friends[1]="Ben";
            friends[2]="Christine";
            friends[3]="Lysa";
            friends[4]="Eugene";
            Console.WriteLine("Array string 0: "+friends[0]);
        }


        static void Main(string[] args)
        {   
            //My first code in c# using vscode
            Console.WriteLine("Hello World!");
            
            //calling the return method
            Console.WriteLine("this from Method with return; "+CubeMethodWithReturn(5));

            //calling if else method
            SampleIfElse();
            Console.WriteLine("From Method IF else: "+GetMax(10,5));

            //calling switchcase 
             Console.WriteLine("From switchcase: "+SampleSwithchCase(4));

            //calling the method
            SayHiToUser("Mack");
            AllAboutVariables();
            AllAboutNumbers();
            AllAboutArrays();
            Console.ReadLine();


        }
    }
}

