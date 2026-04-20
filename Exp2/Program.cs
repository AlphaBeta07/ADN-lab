using Exp2;

class MainClass
{
    static void Main(String[] args)
    {
        //1.creating object
        Console.WriteLine("Creating Object:");
        Car.createObj();
        Console.WriteLine();

        //2.creating multiple object
        Console.WriteLine("Creating Multiple Object:");
        MultipleObj.multipleObj();
        Console.WriteLine();

        //3.class members
        Console.WriteLine("Class Members:");
        ClassMember.classMember();
        Console.WriteLine();

        //4.class functions
        Console.WriteLine("Class Functions:");
        ClassFunctions.classFunctions();
        Console.WriteLine();

        //5.constructors
        Console.WriteLine("Constructors:");
        Constructors.constructors();
        Console.WriteLine();

        //6.access modifiers
        Console.WriteLine("Access Modifiers:");
        AccessModifiers.accessModifiers();
        AccessModifiers.getModel();
        Console.WriteLine();

        //7.properties
        Console.WriteLine("Class Properties:");
        Program.propertiesCode();
        Console.WriteLine();

        //8.inheritance
        Console.WriteLine("Inheritance in C#:");
        Inheritance.inheritanceCode();
        Console.WriteLine();

        //9.polymorphism
        Console.WriteLine("Polymorphism in C#:");
        Polymorphism.polymorphismCode();
        Console.WriteLine();

        //10.abstract class
        Console.WriteLine("Abstractaion in C#:");
        AbstractClass.abstratClass();
        Console.WriteLine();

        //11.interface
        Console.WriteLine("Interface in C#:");
        InterfaceOOP.interfaceOOP();
        Console.WriteLine();

        //12.multiple interface
        Console.WriteLine("Multiple Interface in C#:");
        MultipleInterface.multipleInterface();
        Console.WriteLine();

        //13.enum code
        Console.WriteLine("Enum in C#:");
        EnumCode.enumCode();
        Console.WriteLine();

    }
}