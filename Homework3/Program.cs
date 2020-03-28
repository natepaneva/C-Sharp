using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise from class =============================

            //int[] numbers = new int[3];
            //int sum = 0;

            //Console.WriteLine("Write three numbers with pressing enter after every number:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    string input = Console.ReadLine();
            //    int num;
            //    bool parsedInput = Int32.TryParse(input, out num);

            //    if (parsedInput)
            //    {
            //        numbers[i] = num;
            //        sum += numbers[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is wrong, restart the program and try again.");
            //    }
            //}
            //Console.WriteLine($"Your sum is {sum}.");



            //Task 1 ==========================================


            //string[] studentsG1 = { "Ana", "Marko", "Marija", "Petar", "Ivan" };
            //string[] studentsG2 = { "Damjan", "Ivo", "Meri", "Nikola", "Luka" };


            //Console.WriteLine("Please enter student group number: (1 or 2)");
            //string input = Console.ReadLine();

            //while (input != "1" && input != "2")
            //{
            //    Console.WriteLine("Wrong input. Enter 1 or 2:");
            //    input = Console.ReadLine();
            //}

            //while (true)
            //{
            //    if (input == "1")
            //    {
            //        Console.WriteLine("The Students in G1 are:");

            //        for (int i = 0; i < studentsG1.Length; i++)
            //        {
            //            Console.WriteLine($"{i + 1} {studentsG1[i]}");

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("The Students in G2 are:");

            //        for (int i = 0; i < studentsG2.Length; i++)
            //        {
            //            Console.WriteLine($"{i + 1} {studentsG2[i]}");

            //        }
            //    }
            //    break;
            //}


            //Task 2 ===============================================


            //int[] numbers = new int[6];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter integer no.{i + 1}");
            //    string input = Console.ReadLine();
            //    int num;
            //    bool parsedInput = Int32.TryParse(input, out num);

            //    if (parsedInput)
            //    {
            //        numbers[i] = num;

            //        if (numbers[i] % 2 == 0)
            //        {
            //            sum += num;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is wrong, restart the program and try again.");
            //        break;
            //    }
            //}

            //Console.WriteLine($"The result is {sum}");



            //Task 3 =============================================



            //Console.WriteLine("Welcome to SEDC. Enter T for a trainer or S for student.");
            //string input = Console.ReadLine().ToLower();


            //string[] trainers = { "martin", "ivo", "dejan" };

            //string[] studentsG1 = { "marko", "luka", "viktor", "mihail", "simona" };
            //string[] studentsG2 = { "nate", "angela", "aleksandar", "petar", "stefan" };
            //string[] studentsG3 = { "damjan", "mia", "ivana", "marija", "kristijan" };


            //string[] annoucements = new string[2];
            //annoucements[0] = "The online meeting starts at 5.30 pm.";
            //annoucements[1] = "Strong internet is requered.";

            //int counter = annoucements.Length;

            //string[] subjects = { "HTML", "JavaScript", "C#" };

            //while (true)
            //{
            //    if (input == "t" || input == "s")
            //    {

            //        if (input == "t")
            //        {

            //            Console.WriteLine("Welcome trainer. What is your name?");
            //            string name = Console.ReadLine().ToLower();

            //            for (int i = 0; i < trainers.Length; i++)
            //            {
            //                while (name == trainers[i])
            //                {

            //                    Console.WriteLine($"Hello {name.ToUpper()}!. Press A to list all students from a group (G1, G2, G3) or press B to enter new announcement:");
            //                    string option = Console.ReadLine().ToLower();

            //                    if (option == "a")
            //                    {
            //                        Console.WriteLine("\nStudents from G1:");
            //                        for (i = 0; i < studentsG1.Length; i++)
            //                        {
            //                            Console.WriteLine($"{i + 1}. {studentsG1[i].ToUpper()} ");
            //                        }
            //                        Console.WriteLine("\nStudents from G2:");
            //                        for (i = 0; i < studentsG2.Length; i++)
            //                        {
            //                            Console.WriteLine($"{i + 1}. {studentsG2[i].ToUpper()} ");
            //                        }
            //                        Console.WriteLine("\nStudents from G3:");
            //                        for (i = 0; i < studentsG3.Length; i++)
            //                        {
            //                            Console.WriteLine($"{i + 1}. {studentsG3[i].ToUpper()} ");
            //                        }
            //                        Console.WriteLine("\nThank you for using our app. Good bye!");
            //                        break;
            //                    }

            //                    while (option == "b")
            //                    {
            //                        Console.WriteLine("Write an announcement:");
            //                        string newAnnouncement = Console.ReadLine();

            //                        Array.Resize(ref annoucements, annoucements.Length + 1);
            //                        annoucements[counter] = newAnnouncement;

            //                        Console.WriteLine("Your announcement is published!");

            //                        for (i = 0; i < annoucements.Length; i++)
            //                        {
            //                            Console.WriteLine($"{i+1}. {annoucements[i]}");
            //                        }

            //                        Console.WriteLine("If you want to write another announcement press YES, otherwise write NO");

            //                        string newAnn = Console.ReadLine().ToLower();
            //                        if (newAnn == "no")
            //                        {
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break; 
            //                        }

            //                        counter++;

            //                    }


            //                    if (option == "a" && option == "b")
            //                    {
            //                        Console.WriteLine("Wrong input! Press A to list all students from a group (G1, G2, G3) or press B to enter new announcement:");
            //                        option = Console.ReadLine().ToLower();

            //                    }

            //                    break;

            //                }
            //                if (name != trainers[0] && name != trainers[1] && name != trainers[2])
            //                {
            //                    Console.WriteLine("Sorry, apparently you are not a trainer of this group. Good bye!");
            //                    break;
            //                }


            //            }



            //        }

            //        if (input == "s")
            //        {

            //            Console.WriteLine("Please write which group are you at? (input G1, G2 or G3):");
            //            string choice = Console.ReadLine().ToLower();

            //            if (choice == "g1")
            //            {
            //                Console.WriteLine("Welcome student. What is your name:");
            //                string studentName = Console.ReadLine().ToLower();

            //                for (int i = 0; i < studentsG1.Length; i++)
            //                {
            //                    while (studentName == studentsG1[i])
            //                    {
            //                        Console.WriteLine($"Hello {studentName.ToUpper()}. Press A to list all academy subjects are press B to list all public announcement!");
            //                        string option2 = Console.ReadLine().ToLower();

            //                        if (option2 == "a")
            //                        {
            //                            Console.WriteLine("Your subjects are:");
            //                            for (i = 0; i < subjects.Length; i++)
            //                            {
            //                                Console.WriteLine($"{subjects[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");

            //                            break;
            //                        }
            //                        else if (option2 == "b")
            //                        {
            //                            Console.WriteLine("Current announcements are:");
            //                            for (i = 0; i < annoucements.Length; i++)
            //                            {
            //                                Console.WriteLine($"{i + 1}. {annoucements[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break;
            //                        }
            //                        else if (option2 != "a" && option2 != "b")
            //                        {
            //                            Console.WriteLine("Wrong input. Press A to list all academy subjects are press B to list all public announcement!");
            //                            option2 = Console.ReadLine().ToLower();

            //                        }
            //                    }
            //                    if (studentName != studentsG1[0] && studentName != studentsG1[1] && studentName != studentsG1[2] && studentName != studentsG1[3] && studentName != studentsG1[4])
            //                    {
            //                        Console.WriteLine("Sorry, apparently you are not a student of this group. Good bye!");
            //                        break;
            //                    }
            //                }
            //            }
            //            if (choice == "g2")
            //            {
            //                Console.WriteLine("Welcome student. What is your name:");
            //                string studentName = Console.ReadLine().ToLower();

            //                for (int i = 0; i < studentsG2.Length; i++)
            //                {
            //                    while (studentName == studentsG2[i])
            //                    {
            //                        Console.WriteLine($"Hi {studentName.ToUpper()}. Press A to list all academy subjects are press B to list all public announcement!");
            //                        string option2 = Console.ReadLine().ToLower();

            //                        if (option2 == "a")
            //                        {
            //                            Console.WriteLine("Your subjects are:");
            //                            for (i = 0; i < subjects.Length; i++)
            //                            {
            //                                Console.WriteLine($"{subjects[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break;
            //                        }
            //                        else if (option2 == "b")
            //                        {
            //                            Console.WriteLine("Current announcements are:");
            //                            for (i = 0; i < annoucements.Length; i++)
            //                            {
            //                                Console.WriteLine($"{i + 1}. {annoucements[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break;
            //                        }
            //                        else if (option2 != "a" && option2 != "b")
            //                        {
            //                            Console.WriteLine("Wrong input. Press A to list all academy subjects are press B to list all public announcement!");
            //                            option2 = Console.ReadLine().ToLower();

            //                        }
            //                    }
            //                    if (studentName != studentsG2[0] && studentName != studentsG2[1] && studentName != studentsG2[2] && studentName != studentsG2[3] && studentName != studentsG2[4])
            //                    {
            //                        Console.WriteLine("Sorry, apparently you are not a student of this group. Good bye!");
            //                        break;
            //                    }
            //                }
            //            }
            //            if (choice == "g3")
            //            {
            //                Console.WriteLine("Welcome student. What is your name:");
            //                string studentName = Console.ReadLine().ToLower();

            //                for (int i = 0; i < studentsG3.Length; i++)
            //                {
            //                    while (studentName == studentsG3[i])
            //                    {
            //                        Console.WriteLine($"Hi {studentName.ToUpper()}. Press A to list all academy subjects are press B to list all public announcement!");
            //                        string option2 = Console.ReadLine().ToLower();

            //                        if (option2 == "a")
            //                        {
            //                            Console.WriteLine("Your subjects are:");
            //                            for (i = 0; i < subjects.Length; i++)
            //                            {
            //                                Console.WriteLine($"{subjects[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break;
            //                        }
            //                        else if (option2 == "b")
            //                        {
            //                            Console.WriteLine("Current announcements are:");
            //                            for (i = 0; i < annoucements.Length; i++)
            //                            {
            //                                Console.WriteLine($"{i + 1}. {annoucements[i]}");
            //                            }
            //                            Console.WriteLine("\nThank you for using our app. Good bye!");
            //                            break;
            //                        }
            //                        else if (option2 != "a" && option2 != "b")
            //                        {
            //                            Console.WriteLine("Wrong input. Press A to list all academy subjects are press B to list all public announcement!");
            //                            option2 = Console.ReadLine().ToLower();

            //                        }
            //                    }
            //                    if (studentName != studentsG3[0] && studentName != studentsG3[1] && studentName != studentsG3[2] && studentName != studentsG3[3] && studentName != studentsG3[4])
            //                    {
            //                        Console.WriteLine("Sorry, apparently you are not a student of this group. Good bye!");
            //                        break;
            //                    }
            //                }
            //            }


            //        }

            //        break;

            //    }

            //    Console.WriteLine("Wrong input. Enter T for a trainer or S for student. ");
            //    input = Console.ReadLine().ToLower();
            //}



            //Console.ReadLine();
        }
    }
}

