using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {


        static void Main(string[] args)
        {
            Unit CreateClass(Unit cl)
            {
                for (int i = 0; i < cl.len; i++)
                {
                    Passenger p = new Passenger();
                    if (cl.maxweight < p.weight)
                        Console.WriteLine("Passenger " + p.id +" Free luggage");
                    else
                        Console.WriteLine("Passenger " + p.id + " Not free luggage");
                    cl.weight += p.weight;
                    cl.addUnit(p, i);
                }
                return cl;
            }
            void deletePas(Unit cl, int i)
            {
                cl.deleteUnit(i);
            }

            FirstClass A = new FirstClass();
            BusinessClass B = new BusinessClass();
            EconomyClass C = new EconomyClass();
            List<Unit> AirPlane = new List<Unit>();
            int maxweightAir = 5200;
            A = (FirstClass)CreateClass(A);
            B = (BusinessClass)CreateClass(B);
            C = (EconomyClass)CreateClass(C);

            for (int i = 0; i < 2; i++)
                AirPlane.Add(new Pilot());
            for (int i = 0; i < 6; i++)
                AirPlane.Add(new Stewardess());
            AirPlane.Add(A);
            AirPlane.Add(B);
            AirPlane.Add(C);

            foreach (Unit item in AirPlane)
                item.info();

            Console.WriteLine("All Luggage" + (A.weight + B.weight + C.weight));
            if ((A.weight + B.weight + C.weight) > maxweightAir)
                Console.WriteLine("Luggage limit exceeded by "+ (A.weight + B.weight + C.weight - maxweightAir));
            int j = C.len-1;
            while((A.weight + B.weight + C.weight) > maxweightAir)
            {
                C.deleteLuggage(j);
                j--;
            }

            deletePas(A, 9);
            foreach (Unit item in AirPlane)
                item.info();
        }
    }
}
