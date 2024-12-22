using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    //Access Modifiers : C# Keywords Indicate Accessibility Scope
    // 1. Private 
    // 2. Private Prodected 
    // 3. Protected
    // 4. Internal
    // 5. Internal Prodected
    // 6. Public 



    // What Can Write Inside The Namespace 
    // 1. Class
    // 2. Struct 
    // 3. Interface
    // 4. Enum 


    // Access Modifiers Inside The Namespace : 
    // 1. Internal : Inside The Same Project
    // 2. Public   : Everywhere


    // Defult Access Modifiers Inside The Namespace "Internal"

    // What Can Write Iside The Class Or Struct ?
    // 1. Attributes [Filed - Member Variable]
    // 2. Properties [Full Property - Automatic Property - Special Property (Indexer) ]
    // 3. Methods - Function
    // 4. Event 


    // Access Modifiers Inside The Class : 
    // 1. Private 
    // 2. Private Prodected 
    // 3. Protected
    // 4. Internal
    // 5. Internal Prodected
    // 6. Public 

    // Access Modifiers Inside The Struct : 
    // 1. Private  : Inside The Same Class Only 
    // 2. Internal : Inside The Same Project
    // 3. Public   : Everywhere



    // Defult Access Modifiers Inside The Class or Struct "Private"


    // What Can Write Iside The Interface ?
    // 1. Signature Of Methoud [Return Type - Name - Parameter]
    // 2. Signature Of Property
    // 3. Default Implemented Methods [C# 8.0  .NET Core 3.1]


    // All Access Modifiers Except "Private"


    // Defult Access Modifiers Inside The Interface "Public"


    internal class TypeA
    {
        void Fun01()
        { 
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB(); //Valid

            //typeB.X = 12; // Invalid ==> Prived

            typeB.Y = 12; // Valid

            typeB.Z = 12; // Valid
                           


        }
    }
}
