using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Agency agency = new Agency("ArtemyCo.", 72522);
                Agency a1 = new Agency("", 123);

                Car a = new Car(new CarEngine(), 220, 200);
                Car c = new Car(new CarEngine(), -1, 200);
                Train b = new Train(new TrainEngine(), 220, 200);
                Train d = new Train(new TrainEngine(), 220, -1);

                agency.Add(a);
                agency.Add(b);


            }
            catch(AgencyException ex)
            {
                Console.WriteLine($"Error: {ex.Message} in {ex.ErrorClass}, actual: {ex.ErrorName}, with ID: {ex.ErrorId}");
            }
            catch(VehicleExсeption ex)
            {
                Console.WriteLine($"Error: {ex.Message} - {ex.ErrorWeight}");
            }
            catch(CustomException ex)
            {
                Console.WriteLine($"Error: {ex.Message}, in class {ex.ErrorClass}");
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("работает на блок finally");
            }
            Console.ReadKey();
        }
    }
}
