
    class ClassMember
    {
        string color;
        int maxSpeed;

        public static void classMember()
        {
            ClassMember myObj = new ClassMember();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine("Car Color:" + myObj.color);
            Console.WriteLine("Car Max Speed:" + myObj.maxSpeed);
        }
    }
