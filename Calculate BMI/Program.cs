﻿namespace Calculate_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bmi(80, 1.80));
        }

        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi <= 18.5) return ("Underweight");
            else if (bmi <= 25.0) return ("Normal");
            else if (bmi <= 30.0) return ("Overweight");
            else return ("Obese");
        }
    }
}


/*
 Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
 */