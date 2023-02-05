
class Program{
    static void Main(string[] args)
    {
        int operationNumber;
        bool flag = true;
        bool radiusFlag = false;

        Circle circle = new();


        while (!radiusFlag)
        {
            Console.Write("Please Enter Circle Radius :");
            int radius = Convert.ToInt16(Console.ReadLine());
            if (radius > 0) { 
                radiusFlag= true;
                circle.SetRadius(radius);
                flag= false;
            }
            else
            {
                Console.WriteLine("Enter valid radius value");
            }
        }

        
        while (!flag) 
        { 
            try
            {
                Console.WriteLine("\n=========================\n");
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Please select operation from above :");
                operationNumber = Convert.ToInt16(Console.ReadLine());

                if (operationNumber == 1)
                {
                    getCircleRadius();
                }
                else if (operationNumber == 2)
                {
                    changeCircleRadius();
                }
                else if (operationNumber == 3)
                {
                    getCircleCircumference();
                }
                else if (operationNumber == 4)
                {
                    getCircleArea();
                } else if (operationNumber == 5)
                {
                    flag = true;
                }
            }
            catch
            {

            }
        }
        void getCircleRadius()
        {
            Console.WriteLine(circle.GetRadius().ToString());
        }

        void changeCircleRadius()
        {
            Console.Write("Please Enter New Circle Radius :");
            int radius = Convert.ToInt16(Console.ReadLine());
            circle.SetRadius(radius);
        }

        void getCircleCircumference()
        {
            Console.WriteLine(circle.GetCircumference().ToString());
        }
        
        void getCircleArea()
        {
            Console.WriteLine(circle.GetArea().ToString());
        }
    }
}