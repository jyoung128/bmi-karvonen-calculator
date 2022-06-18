/* BMI + Karvonen Calculator
 * ----
 * Jonah Young
 * 9/16/2020
 * CSCI 1630
 */

using System;

namespace BmiKarvonenCalcJRY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jonah's BMI and Karvonen calculator");
            Console.WriteLine("");
            Console.WriteLine("Please enter the following user info:");
            Console.WriteLine("");

            //User inputs height in inches
            Console.Write("Height in inches: ");
            String userHeight = Console.ReadLine();
            Int32.TryParse(userHeight, out int heightInches);

            //User inputs weight in pounds
            Console.Write("Weight in pounds: ");
            String userWeight = Console.ReadLine();
            Int32.TryParse(userWeight, out int weightPounds);

            //User inputs age in years
            Console.Write("Age: ");
            String userAge = Console.ReadLine();
            Int32.TryParse(userAge, out int ageYears);

            //User inputs resting heartrate
            Console.Write("Resting Heart Rate: ");
            String userRestingHeartRate = Console.ReadLine();
            Int32.TryParse(userRestingHeartRate, out int restingHeartRate);

            Console.WriteLine("");
            Console.WriteLine("Calculating your Results...");

            //Convert user height to square meters
            double heightM2 = (heightInches / 39.37) * (heightInches / 39.37);

            //Convert user weight to kilograms
            double weightKilos = weightPounds / 2.205;

            //User's BMI number
            double bmi = weightKilos / heightM2;
            String bmiClassification;

            //BMI classification calculation via if/else statements
            if (bmi < 18.5)
            {
                bmiClassification = "Underweight";
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                bmiClassification = "Normal weight";
            }
            else if (bmi > 24.9 && bmi <= 29.9)
            {
                bmiClassification = "Overweight";
            }
            else
            {
                bmiClassification = "Obese";
            }

            //Prints out user BMI number + classification
            Console.WriteLine($"Your BMI is: {Math.Round(bmi, 2)} -- {bmiClassification}");
            Console.WriteLine("");

            Console.WriteLine("Exercise Intensity Heart Rates:");
            Console.WriteLine("");
            Console.WriteLine("Intensity        Max Heart Rate");
            Console.WriteLine("");

            int maxHeartRate = 220 - ageYears;
            int heartRateReserve = maxHeartRate - restingHeartRate;

            //loop for calculating/printing intensity levels and their respective target heart rates
            for (double i = 0.5; i <= 1; i += 0.05) {
                double maxTargetZone = heartRateReserve * i;
                double targetTrainingZone = Math.Round(maxTargetZone + restingHeartRate);
                double iDisplay = Math.Round(i * 100);
                Console.WriteLine($"{iDisplay}%      --      {targetTrainingZone}");
            }

        }
    }
}
