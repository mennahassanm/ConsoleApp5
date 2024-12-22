using System.Diagnostics.Metrics;
using System.Drawing;

namespace A5
{
    #region Q1

    //enum WeekDays
    //{
    //Monday,
    //Tuesday,
    //Wednesday,
    //Thursday,
    //Friday,
    //Saturday,
    //Sunday
    //}

    #endregion

    #region Q2

    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    #endregion

    #region Q3

    //[Flags]

    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    #endregion

    #region Q4

    //enum Colors
    //{
    //    red,
    //    green,
    //    blue
    //}

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //1.Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members. Then, write a C# program
            //that prints out all the days of the week using this enum.

            //Console.WriteLine("The Days Of The Week :");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //The Days Of The Week:
            //Monday
            //Tuesday
            //Wednesday
            //Thursday
            //Friday
            //Saturday
            //Sunday

            #endregion

            #region Q2

            //2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter)
            //as its members. Write a C# program that takes a season name as input from the user and displays
            //the corresponding month range for that season. Note range for seasons
            //( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool IsValidInput = false;
            //string MonthRange = string.Empty;

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Available seasons:");
            //        foreach (Season season in Enum.GetValues(typeof(Season) ))
            //        {
            //            Console.WriteLine($"{season}");
            //        }

            //        Console.WriteLine("Enter a season : ");
            //        string input = Console.ReadLine();

            //        Season SelectedSeason = (Season)Enum.Parse(typeof(Season), input, true);

            //        MonthRange = SelectedSeason switch
            //        {
            //            Season.Spring => "March to May",
            //            Season.Summer => "June to August",
            //            Season.Autumn => "September to November",
            //            Season.Winter => "December to February",
            //        };

            //        IsValidInput = true;
            //        Console.WriteLine($"The months for {SelectedSeason} are: {MonthRange}");
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("Invalid Input. Please Enter a Valid Season.");
            //    }
            //    catch (Exception E)
            //    {
            //        Console.WriteLine($"An Unexpected Error Occurred: {E.Message}");
            //    }

            //} while (!IsValidInput);

            //Available seasons :
            //Spring
            //Summer
            //Autumn
            //Winter
            //Enter a season:
            //spring
            //The months for Spring are: March to May

            #endregion

            #region Q3

            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific
            //Permission is existed inside variable

            //Permissions UserPermissions = Permissions.None; 

            //UserPermissions |= Permissions.Read;
            //UserPermissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {UserPermissions}");

            //if ((UserPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("User has Read Permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Read Permission.");
            //}

            //if ((UserPermissions & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("User has Execute Permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Execute Permission.");
            //}

            //UserPermissions &= ~Permissions.Read;
            //Console.WriteLine($"Permissions After Removing Read: {UserPermissions}");

            //UserPermissions |= Permissions.Execute;
            //Console.WriteLine($"Permissions After Adding Execute: {UserPermissions}");

            //Console.WriteLine($"User Permissions: {UserPermissions}");

            //Current Permissions: Read, Write
            //User has Read Permission.
            //User does not have Execute Permission.
            //Permissions After Removing Read: Write
            //Permissions After Adding Execute: Write, Execute
            //User Permissions: Write, Execute

            #endregion

            #region Q4

            //4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message
            //indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color (Red, Green, Blue): ");
            //string Input = Console.ReadLine();

            //if (Enum.TryParse(Input, true, out Colors colors))
            //{
            //    Console.WriteLine($"{Input} : is a Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Input} : is Not Primary Color");
            //}

            //Enter a color (Red, Green, Blue) : Red
            //Red : is a Primary Color

            //Enter a color(Red, Green, Blue) : Yellow
            //Yellow : is Not Primary Color

            #endregion

        }
    }
}
