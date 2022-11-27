using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_OOP
{
    internal class Circle
    {
      
        private double _Circle_Area;
        private double _Circle_Radius;
        private double _Circle_Circumference;

        public double Circle_Area
        {
                    
            set { _Circle_Area = value; }
         get { return _Circle_Area; }
            
        }

        public double Circle_Radius
        {
            set { _Circle_Radius = value; }
            get { return _Circle_Radius; }

        }

        public double Circle_Circumference
        {
            set { _Circle_Circumference = value; }
            get { return _Circle_Circumference; }

        }





        static (double , string ) Area(double radiAs, double pi )
        {
            double areA = pi * (radiAs * radiAs);
            String leka = " Tlamelo wa leka ";
            return (areA, leka);



        }

        static double Circumference(double radiaS, double pi)
        {
            double CircumferencE = 2 * pi *radiaS;
            return CircumferencE;
        }

        static void Main(string[] args)
        {
            int radiAS1 ;
            int radiAS2 ;
            double pi1 = 3.14159;
            
            gOexample:


            Console.Write("please enter Radius of circle 1 ->");
            radiAS1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter Radius of circle 2 ->");
            radiAS2 = Convert.ToInt32(Console.ReadLine());

            Circle Circle1 = new Circle();
            Circle Circle2 = new Circle();

            var KOKOTETSA = Area(radiAS1, pi1);

            Circle1.Circle_Radius = radiAS1;
            //Circle1.Circle_Area = Area( radiAS1 , pi1);
            Circle1.Circle_Area = KOKOTETSA.Item1;
          Circle1.Circle_Circumference = Circumference(radiAS1 , pi1);

            Circle2.Circle_Radius = radiAS2;
            //Circle2.Circle_Area = Area(radiAS2, pi1);
            Circle2.Circle_Area =  KOKOTETSA.Item1;

            Circle2.Circle_Circumference = Circumference(radiAS2 , pi1);


            //C:\Users\ns21-007\OneDrive - Botswana Accountancy College\Desktop\mys.txt

            //using (TextWriter writer = File.CreateText("e:\\f.txt"))
            using (TextWriter writer = File.CreateText("C:\\Users\\ns21-007\\OneDrive - Botswana Accountancy College\\Desktop\\mys1.txt"))
            {


                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine(" Circle 1 = " + Circle1.Circle_Radius);
                writer.WriteLine(" Circle Area = " + Circle1.Circle_Area + " " + KOKOTETSA.Item2);
                writer.WriteLine(" Circle Circumference = " + Circle1.Circle_Circumference);


                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine(" Circle 2 = " + Circle2.Circle_Radius);
                writer.WriteLine(" Circle Area = " + Circle2.Circle_Area + " " + KOKOTETSA.Item2);
                writer.WriteLine(" Circle Circumference = " + Circle2.Circle_Circumference);




            }


            using (TextWriter writer = File.CreateText("C:\\Users\\ns21-007\\OneDrive - Botswana Accountancy College\\Desktop\\mys1.txt"))
            {


                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");

            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(" Circle 1 = "+ Circle1.Circle_Radius);
            Console.WriteLine(" Circle Area = " + Circle1.Circle_Area +" "+ KOKOTETSA.Item2);
            Console.WriteLine(" Circle Circumference = " + Circle1.Circle_Circumference);


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(" Circle 2 = " + Circle2.Circle_Radius);
            Console.WriteLine(" Circle Area = " + Circle2.Circle_Area + " "+ KOKOTETSA.Item2 );
            Console.WriteLine(" Circle Circumference = " + Circle2.Circle_Circumference);

            Console.ReadKey();

            goto gOexample;










        }
    }
}
