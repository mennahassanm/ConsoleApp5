using System;
using System.Security.AccessControl;
using Common;
using DateTime = System.DateTime;

namespace ConsoleApp5
{

    //enum Season
    //{
    //    // 0 => 255

    //    Spring ,
    //    Winter ,
    //    Summer ,
    //    Autumn 
    //}

    //enum WeekDays
    //{
    //    Saturday,
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //}

    //enum Gender
    //{
    //    M = 1,
    //    F = 2,
    //    Male =1,
    //    Female =2 
    //}

    //class Employee
    //{
    //    private int id;
    //    private Gender G; 
    //}

    //Read , Write , Excecute , Delete 

    //[Flags]
    //enum Permissions
    //{
    //    Read = 8, 
    //    Write = 4,
    //    Excecute= 2,
    //    Delete =1 
    //}

    internal class Program
    {

        #region Exeption Handling And Protective Code

        //static void DoSumCode ()
        //{

        //    int X, Y, Z;
        //    X= int.Parse (Console.ReadLine ());
        //    Y= int.Parse (Console.ReadLine ());

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    Arr[99] = 10; 

        //}


        //static void DoSumCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());
        //        Y = int.Parse(Console.ReadLine());

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        Arr[99] = 10;
        //    }
        //    catch (Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        // Release | Deallocate | Disconnect | Dispose UnManged Resource

        //        Console.WriteLine("Finally");
        //    }
        //}


        //static void DoSumProtectiveCode ()
        //{
        //   try
        //   {
        //        int X, Y, Z;
        //        bool Flag;
        //        do
        //        {
        //            Console.WriteLine("Enter First Number : ");
        //            Flag = int.TryParse(Console.ReadLine(), out X);
        //        }
        //        while (Flag == false);

        //        do
        //        {
        //            Console.WriteLine("Enter Second Number : ");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);
        //        }
        //        while (Flag == false || Y == 0);

        //        Z = X / Y;
        //        int[] Arr = { 1, 2, 3 };

        //        if (99 < Arr?.Length)
        //        {
        //            Arr[99] = 10;
        //        }
        //   }
        //   catch (Exception E)
        //   {
        //        Console.WriteLine(E.Message);
        //   }



        //}

        #endregion




        static void Main(string[] args)
        {

            #region Boxing And UnBoxing
            ////Boxing And UnBoxing

            ////Boxing   : Casting From ValueType To ReferenceType
            ////UnBoxing : Casting From  ReferenceType To ValueType

            //object O1;

            //// O1 => Can Refer To Instance Of "Object" Or Any Instance Of Any Type 

            ////O1 = 1;
            ////O1 = "Ahmed";

            //O1 = (object) 3;        //Cast From ValueType[int] To ReferenceType [Object]        ==> Boxing
            //O1 = 1.5;               //Cast From ValueType[double] To ReferenceType [Object]     ==> Boxing          
            //O1 = "A";               //Cast From ValueType[char] To ReferenceType [Object]       ==> Boxing
            //O1 = true;              //Cast From ValueType[bool] To ReferenceType [Object]       ==> Boxing
            //O1 = new DateTime();    //Cast From ValueType[DataTime] To ReferenceType [Object]   ==> Boxing

            //int X = 5;
            //object O1 = /*(object)*/X;
            //// Implicit Casting 
            //// Safa Casting 
            //// Boxing 
            //// Parent = Child ==> Child is Parent 
            //// Animal = Dog ==> Dog is Animal 


            //object O1 = 3;
            //O1 = "Ahmed";
            //O1 = true;
            //O1 = 1.5;

            //int X =(int ) O1; 
            ////Explicit Casting 
            ////Unsafe Casting [May Throw Exception]
            ////UnBoxing 
            //// Dog = (Dog) Animal ==> Animal is Dog 
            //// Child = Parent ==> Parent is Child 

            #endregion

            #region Nullable Types

            // Nullable Types 

            // Value Type 
            // Reference Type 

            #region Nullable ValueTypes

            // Nullable Types 

            // Value Type 
            // Reference Type 

            //int X = 6;
            //X = null; // Not Valid

            // Nullbale Value Type => Value Type Allow Null as Valid Value 

            // Nullable <int> : Allow Int Value Or Null as Valid Value

            //int? Age = 20;
            //Age = null;

            //// Nullable <double> :Allow double Value Or Null as Valid Value
            //double? Salary = 4000.5;

            //Salary = null;



            //int X = 5;

            //// Y : Nullable <int>
            //// Y : Allow int Value Or Null 

            //int? Y = /*(int ?)*/ X;

            //// Implicit Casting 
            //// Safe Casting 

            //Console.WriteLine(Y);

            //int? X = 5;
            //X = null;


            //// Y : int 
            ////Y : Allow int Value Only 

            //int Y ;

            //Explicit Casting 
            //May Throw Exception 

            // Defensive Code '

            //if (X != null)
            //    Y = (int) X ;
            //else
            //    Y = 0;

            //======================================//

            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //======================================//

            //if (X.HasValue)

            //    Y = X.Value;

            //else 

            //    Y = 0;

            //======================================//


            //Y = X .HasValue ? X .Value : 0 ;


            //=====================================//

            //Y = X is not null ? X.Value : 0;

            //=====================================//

            // Null Colescing Operator ??

            //Y = X ?? 0; // Syntax Suger : Y = X is not null ? X.Value : 0;


            //Console.WriteLine(Y); 

            #endregion

            #region Nullable Reference Type ( C# 10.0  .NET 6.0 )

            //Nullable Reference ( C# 10.0  .NET 6.0 )

            //string Message = "Hello";
            //Message = null;

            //Console.WriteLine(Message);

            //string Message01 = null; // Required


            //string? Message02 = null; // Nullable

            //Console.WriteLine(Message01.Length); 
            //Console.WriteLine(Message02);


            #endregion

            #endregion

            #region Null Propagation Operator ?

            ////Null Propagation Operator ?

            ////double X = default; //0
            ////Console.WriteLine(X);

            ////char C = default; //Null , Spase 
            ////Console.WriteLine(C);

            ////bool E = default; //False 
            ////Console.WriteLine(E);

            //int[] Arr = default; //Null
            //                     //int[] Arr = { 1, 2, 3, 4, 5 };


            ////Best Practice

            ////if (Arr is not null)
            ////{
            ////    for (int i = 0; i < Arr.Length; i++)

            ////        Console.WriteLine(Arr[i]);

            ////}


            ////for (int i = 0; (Arr is not null) && i < Arr.Length; i++)

            ////    Console.WriteLine(Arr[i]);


            ////for (int i = 0;  i < Arr?.Length; i++)

            ////    Console.WriteLine(Arr[i]);


            //// E?.Department?.DeptName

            ////int Len = Arr is not null? Arr.Length : 0;

            ////int? Len = Arr? .Length;

            ////int Len = Arr ? .Length is not null ? Arr.Length : 0;

            //int? Len = Arr?.Length?? -1 ;


            //Console.WriteLine(Len); 

            #endregion

            #region Exeption Handling And Protective Code

            // Exeption Handling And Protective Code

            //DoSumCode ();

            //DoSumProtectiveCode();


            //Console.WriteLine("Hello After Exception");

            // Exception 
            // 1. SystemException
            // 1.1. FormatException
            // 1.2. IndexOutOf RangeException
            // 1.3. NullReferenceException
            // 1.4. ArithmeticException
            // 1.4.1. OverflowException 
            // 1.4.2. DivideByZeroException

            // 2. ApplicationException 

            #endregion

            #region Access Modifiers

            //Class Library 

            ////Common.TypeA typeA = new TypeA (); // Invalid TypeA is Internal  

            //Common.TypeB typeB = new Common.TypeB(); //Valid TypeB is Public 

            ////typeB.X = 12; // Invalid Private

            ////typeB.Y = 12; //Invalid Internal

            //typeB.Z = 12; // Valid Public

            #endregion

            #region Enum

            ////Enum : Value Type 
            //// STACK 

            //Season S01 = Season.Autumn;

            //S01 = Season.Spring;

            //Console.WriteLine(S01);

            ////CLR Represent Enum As Integer Value In Memory 

            //Gender G01 = Gender.M;
            //Console.WriteLine(G01); //M 

            //Gender G01 = (Gender)1;
            //Console.WriteLine(G01); //F


            //Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine() , true);

            //Gender  G01;

            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true ,out Object O1 );

            //G01 =(Gender) O1;

            //Console.WriteLine(G01);

            //Permissions Per01 = Permissions.Read;
            //Per01 ^= Permissions.Delete; //Toggle
            //                             ////Console.WriteLine((int)Per01); //9

            ////Console.WriteLine(Per01); //Delete , Read
            ////Per01 ^= Permissions.Delete; //Toggle


            //////Per01 |= Permission.Delete; //Add Permession
            ////Console.WriteLine(Per01); //Read

            //Console.WriteLine(Per01); //Delete, Read
            ////Per01 &= Permissions.Delete;

            ////Per01 &= ~(Permissions.Delete); //Read //~ Not Bitwise

            //// & => Check Perissions

            ////Console.WriteLine(Per01); //Delete

            //if ((Per01 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}  

            #endregion


        }
    }
}
