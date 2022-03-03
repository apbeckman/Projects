using static System.Console;

namespace AidanBeckman.ProgrammingAssignment5
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            //calling first method
            InstructionsAndFirstScore();
        }

        //instructions and first test score
        public static void InstructionsAndFirstScore()
        {
            WriteLine("\tThis program will calculate your grade based on an average of your test scores." +
                "\n\n\tFirst, enter the name of your course.");
            var courseName = ReadLine();

            WriteLine("\n\t{0} Grade Calculator -", courseName);
            WriteLine();
            WriteLine("\tEnter your score for exam 1:");
            var score = ReadLine();
            var scoreTotal = double.Parse(score);
            GradeEntryLoop(scoreTotal, courseName); //passing first score to the loop 
        }

        /*   setting up a loop to allow user to enter as many scores after the first as 
 they need to, keep track of the total number of points, and divide by the number of 
 scores entered to average.   */

        public static void GradeEntryLoop(double scoreTotal, string courseName)
        {
            bool scoreEntry = true; // the "while" loop will execute as long as this bool is true
            int scoreCount = 1; //a counter for the number of times the user has entered a score
            while (scoreEntry) //checking if scoreEntry is true
            {
                WriteLine();
                WriteLine("\tEnter another test score? y/n");
                var keepGoing = ReadLine();
                if (keepGoing == "y" || keepGoing == "yes" || keepGoing == "Y" || keepGoing == "Yes")   //allowing for a variety of user responses to query, any of these will allow user to enter another grade

                {
                    scoreCount++; //increment counter by 1
                    WriteLine("\n\tEnter your score for exam {0}:", scoreCount); //asking for input
                    var score = ReadLine(); //recording input to string
                    scoreTotal += double.Parse(score); //parsing string as a double and adding it to the total number of points
                }
                else
                {
                    scoreEntry = false; //kills the loop if user gives a response other than the affirmatives included above
                }
            }
            Calculation(scoreTotal, scoreCount, courseName); //passing scoreTotal and scoreCount to the final calculation after the loop stops
        }

        //calculating grade
        public static void Calculation(double scoreTotal, int scoreCount, string courseName)
        {
            double currentGrade = (scoreTotal / scoreCount);
            WriteLine("\n\tYour current {0} grade is {1}\n", courseName, currentGrade.ToString("0.0")); //displaying output
            LetterGrade(currentGrade); //passing things off to the LetterGrade method
        }

        //Display a message to the user based on the letter grade the average represents
        public static void LetterGrade(double currentGrade)
        {
            switch (currentGrade)
            {
                case > 89.5:
                    {
                        string letterGrade = "A";
                        Message(letterGrade);
                        break;
                    }

                case > 79.5:
                    {
                        string letterGrade = "B";
                        Message(letterGrade);
                        break;
                    }

                case > 69.5:
                    {
                        string letterGrade = "C";
                        Message(letterGrade);
                        break;
                    }

                case > 59.5:
                    {
                        string letterGrade = "D";
                        Message(letterGrade);
                        break;
                    }

                case < 59.5:
                    {
                        string letterGrade = "F";
                        Message(letterGrade);
                        break;
                    }
            }
        }
        public static void Message(string letterGrade) //custom message for user based on the letter grade they received
        {
            switch (letterGrade)
            {
                case "A":
                    WriteLine("\tCongratulations on the A!");
                    break;

                case "B":
                    WriteLine("\tNice job on the B");
                    break;

                case "C":
                    WriteLine("\tI mean hey, Cs get degrees");
                    break;

                case "D":
                    WriteLine("\tA D :( At you're passing!");
                    break;

                case "F":
                    WriteLine("\tYou got an F.");
                    break;
            }
            ExitStageLeft();
        }

        public static void ExitStageLeft()
        {
            WriteLine("\tPress any key to exit.");
            ReadKey();
        }
    }
}