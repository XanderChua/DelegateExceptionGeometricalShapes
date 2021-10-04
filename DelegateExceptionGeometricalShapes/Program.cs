using System;
//write a c# program to find out from the given angle values whether a geometrical shape can be formed or not .
//if yes then what type of shape it is. Use anonymous method, event and delegate and exception handling
namespace DelegateExceptionGeometricalShape
{
    public delegate void EventHandler(int angle3, int angle4, int angle5);
    class Operation
    {
        public event EventHandler send;
        int a;
        int three;
        int four;
        int five;
        public void GetInput(int a)
        {
            this.a = a;
            cal3sided();
            cal4sided();
            cal5sided();
            Notify();
        }
        private void cal3sided()
        {
            three = a / 3;
        }
        private void cal4sided()
        {
            four = a / 4;
        }
        private void cal5sided()
        {
            five = a / 5;
        }
        private void Notify()
        {
            if (send != null)
            {
                send(three, four, five);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.WriteLine("Enter total angles in a shape:");
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                operation.send += Operation_send;
                operation.GetInput(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception handled: " + ex.Message);
            }
        }

        private static void Operation_send(int angle3, int angle4, int angle5)
        {
            if (angle3 == 60)
            {
                Console.WriteLine("Your shape has 3 sides and each side has an angle of: " + angle3);
            }
            else if (angle4 == 90)
            {
                Console.WriteLine("Your shape has 4 sides and each side has an angle of: " + angle4);
            }
            else if (angle5 == 108)
            {
                Console.WriteLine("Your shape has 5 sides and each side has an angle of: " + angle5);
            }
            else
            {
                Console.WriteLine("Your shape is not a geometrical shape");
            }
        }
    }
}
