using System.Diagnostics;
using System.Text;

namespace C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String Formating 

            //String Formating
            //Equation : X + Y = 12

            //int X = 3 ; int Y = 4;

            //1. String Concatnation
            //string Massage = "Equation : " + X + " + " + Y + " = " + (X + Y);
            //Console.WriteLine(Massage); //Equation : 3 + 4 = 7

            // String : Imutable => Can't Change its Value After Creation

            //2. String Format
            //String Massage = string.Format(format: "Equation : X + Y  = 12 ");
            //Console.WriteLine(Massage); //Equation : X + Y  = 12

            //String Massage02 = string.Format(format: "Equation : {0} + {1}  = {2} ", X, Y, X + Y);
            //Console.WriteLine(Massage02); //Equation : 3 + 4 = 7

            //3. String Interpolution
            //$ : 
            //string Massage = $"Equation : {X} + {Y} = {X + Y}";
            //Console.WriteLine(Massage); //Equation : 3 + 4 = 7

            #endregion

            #region Conditional Statments -> If, Switch

            // Control Statements 

            // Control Statements : 1. Conditional Control Statements

            // 1. Using IF : 

            //Console.Write(value: " Enter The Number Of Month in The 1st Quarter : ");
            //int MonthNumber = int .Parse(Console.ReadLine());

            // 1 ==> Jan 
            // 2 ==> Feb
            // 3 ==> Mar

            //Console.WriteLine(value: "Jan");
            //Console.WriteLine(value: "Feb");
            //Console.WriteLine(value: "Mar");

            //if(/* Expression */ )
            //{ 
            //    // Code
            //    // This Code Will Be Executed When The Condition is True

            //}

            #region EX01

            //Ex01

            //if (MonthNumber == 1)
            //{

            //    Console.WriteLine(value: "Jon");

            //}

            //if (MonthNumber == 2)
            //{

            //    Console.WriteLine(value: "Feb");

            //}

            //if (MonthNumber == 3)
            //{

            //    Console.WriteLine(value: "Mar");

            //}


            //if (MonthNumber == 1)
            //{

            //    Console.WriteLine(value: "Jan");

            //}
            //else if (MonthNumber == 2)
            //{

            //    Console.WriteLine(value: "Feb");

            //}
            //else if (MonthNumber == 3)
            //{

            //    Console.WriteLine(value: "Mar");

            //}
            //else
            //{

            //    Console.WriteLine(value: " Invalid Month Number ");

            //}

            // 2. Using Switch

            //switch ( /* Expression */ )
            //{

            //   case 

            //}

            //Console.Write(value: " Enter The Number Of Month in The 1st Quarter : ");
            //int MonthNumber = int .Parse(Console.ReadLine());

            //Jump Table 

            //switch (MonthNumber)
            //{
            //    case 1:

            //        Console.WriteLine(value: "Jan");

            //    break;

            //    case 2:

            //        Console.WriteLine(value: "Feb");

            //    break;

            //    case 3:

            //        Console.WriteLine(value: "Mar");

            //    break;

            //    default:

            //         Console.WriteLine(value: " Invalid Month Number ");

            //    break;
            //} 

            #endregion

            #region EX02

            //EX02

            //Console.WriteLine(value: "Enter Your Name : ");
            //string Name = Console.ReadLine();

            ////Hi Ahmed

            //if (Name == "Ahmed" || Name == "ahmed")
            //{
            //    Console.WriteLine(value: "Hi Ahmed");
            //}
            //else if (Name == "Omar" || Name == "omar")
            //{
            //    Console.WriteLine(value: "Hi Omar");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine(value: "Hi Ali");
            //}
            //else if (Name == "Mariam" || Name == "mariam")
            //{
            //    Console.WriteLine(value: "Hi Mariam");
            //}
            //else
            //{
            //    Console.WriteLine(value: "Hi " + Name);
            //}

            //Console.WriteLine(value: "Enter Your Name : ");
            //string Name = Console.ReadLine();

            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine(value: "Hi Ahmed");
            //    break;

            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine(value:"Hi Omar");
            //    break;

            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine(value: "Hi Ali");
            //    break;

            //    case "Mariam":
            //    case "mariam":

            //        Console.WriteLine(value: "Hi Mariam ");
            //    break;

            //    default:
            //            Console.WriteLine(value: " Hi " + Name);
            //    break;

            #endregion

            #region EX03

            //Console.WriteLine(value: "Enter Your Age :");
            //int Age = int.Parse(Console.ReadLine());

            //// 1. Using If

            //if (Age > 18)
            //{
            //    Console.WriteLine(value: "Welcome :) ");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine(value: "Bye Bye :( ");
            //}
            //else
            //{
            //    Console.WriteLine(value: "Equal ~._.~");
            //}

            //// 2. Using Switch

            //Console.WriteLine(value: "Enter Your Age :");
            //int Age = int.Parse(Console.ReadLine());

            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine(value: "Welcom :) ");
            //    break;

            //    case < 18:
            //        Console.WriteLine(value: "Bye Bye :( ");
            //    break;

            //    default:
            //        Console.WriteLine(value: "Equal ~._.~ ");
            //    break;
            //} 

            #endregion

            #region C# 7.0

            //object Object = new object();
            //Object = "Ahmed";
            //Object = 1;

            //switch (Object)
            //{
            //    case int X when X > -12:
            //        Console.WriteLine(value: "Int Object");
            //    break;

            //    case string X when X.Length > 5:
            //        Console.WriteLine(value: "String Object");
            //    break;

            //    case int X when X <= 5:
            //        Console.WriteLine(value: "String Object ");
            //    break;
            //} 

            #endregion

            #region C# 8.0

            //C# 8.0
            //Switch Expression

            //string Input = Console.ReadLine();

            // 1
            // 2
            // 3

            //string Output = (Input switch
            // {
            //     "1" => "Option 1" ,
            //     "2" => "Option 2" ,
            //     "3" => "Option 3" ,
            //     _   => "Unsupport Option !! "
            // });

            // Console.WriteLine(Output);

            #endregion

            #endregion

            #region Loop Control Statements 

            // Control Statements : 2. Loop Control Statements  (for , foreach , while , do-while )

            // 1. For Loop

            //for(/*Statment*/ ; /*Expression*/ ; /*Statment*/ )
            //{
            //    //Code
            //    // That Code Will Be Repeated

            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // 2. Foreach

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}


            //foreach(int N in Numbers)
            //{
            //   Console.WriteLine(N);
            //}


            // While 

            //while (/*Expression*/)
            //{ 
            //   //Code 
            //   //That Code Will Be Repeted While The Expression is True
            //}

            //while (true)
            //{
            //    Console.WriteLine(value: "Hello World");
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(value: "Hello World");
            //    i++;
            //}

            //Console.WriteLine(i);//11


            // do - While 

            //do 
            //{ 
            //    //Code 
            //    //This Code Will Be Executed First 
            //}while (/*Expression*/);


            //int i = 1;
            //do
            //{
            //    Console.WriteLine(value: "Hello World");
            //    i++;
            //} while (i<= 10);

            //int Number;
            //bool Flag;

            //do
            //{
            //    Console.WriteLine(value: "Even Number :");

            //}while(!int.TryParse(Console.ReadLine(), out Number)||  Number %2 != 0  ) ;

            //Console.WriteLine(Number);



            #endregion

            #region String 

            //String : Reference Type : HEAP (Class)
            // Imutable Type : Can't Chagne Its Value After Creatation

            //string S01;
            //Declare For Reference (Pointer) From Type 'String'
            //S01 : Can Refer To Object From 'String'
            //S01 : Refer To Null 

            // 8 Bytes Will Be Allocated At Stack For Refernce 'S01'
            // 0 Bytes Will Be Allocated At HEAP


            ////S01 = new string(value: "Ahmed ");
            //S01 = "Ahmed "; //Syntax Sugar

            ////New :
            ////1. Allocate The Number Of Required Bytes For The Object At HEAP 
            ////2. Initialized The Allocated Bytes With The Default Value
            ////3. Call User-Defind Constructor is Exists
            ////4. Assign The Object To Reference

            //Console.WriteLine(S01.GetHashCode()); //Id :Idicate Address  

            //S01 = "Ali";

            ////1. Allocate The Number Of Required Bytes For The Object At HEAP 
            ////2. Initialized The Allocated Bytes With The Default Value
            ////3. Call User-Defind Constructor is Exists
            ////4. Assign The Object To Reference

            //Console.WriteLine(S01.GetHashCode());

            //S01 = "Yassmin";

            ////1. Allocate The Number Of Required Bytes For The Object At HEAP 
            ////2. Initialized The Allocated Bytes With The Default Value
            ////3. Call User-Defind Constructor is Exists
            ////4. Assign The Object To Reference

            //Console.WriteLine(S01.GetHashCode());

            //string Message = "Hello";
            //Console.WriteLine("Message : "  + Message);
            //Console.WriteLine("HashCode : " + Message.GetHashCode());
            //Console.WriteLine();

            //Message += "Ahmed";
            //Console.WriteLine("Massage : " + Message);
            //Console.WriteLine("HashCode : " + Message.GetHashCode());

            #endregion

            #region StringBuilder

            ////StringBuilder : Class (Reference Type) : HEAP
            ////Mutable Datatype : Can Change Its Value After Creatation


            //StringBuilder S01;

            ////Declare For Reference (Pointer) From Type 'StringBuilder'
            ////S01 : Can Refer To Object From 'String'
            ////S01 : Refer To Null 

            //S01 = new StringBuilder(value: "Hello");

            //////New :
            //////1. Allocate The Number Of Required Bytes For The Object At HEAP 
            //////2. Initialized The Allocated Bytes With The Default Value
            //////3. Call User-Defind Constructor is Exists
            //////4. Assign The Object To Reference

            //Console.WriteLine(format:"S01 : " + S01);
            //Console.WriteLine("S01HasCode : " + S01.GetHashCode());
            //Console.WriteLine();

            //S01.Append(value: " Ahmed");
            //Console.WriteLine(format: "S01 : " + S01);
            //Console.WriteLine("S01HasCode : " + S01.GetHashCode());
            //Console.WriteLine(); 

            #endregion

            #region String Methods

            //string S01 = "Hello World";
            ////string result = S01.Substring(S01.Length );
            ////bool result = S01.StartsWith(value: "H"); //True
            ////var result= S01.Replace(oldValue: "Hello ", newValue: " Welcom");
            ////bool result = S01.StartsWith(value:"h" ,ignoreCase: false , culture: null);//False
            ////bool result = S01.StartsWith(value: "h", ignoreCase: true, culture: null);//True
            //S01.ToCharArray();
            //int result = S01.IndexOf (value:'e');//1

            //Console.WriteLine(result);
            //Console.WriteLine(S01); 

            #endregion

        }


    }
}
