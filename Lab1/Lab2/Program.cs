using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil[] class1 = new Pupil[]
            {
                new BadPupil(){ Name = "Ivan"},
                new BadPupil(){ Name = "Alex"},
                new GoodPupil(){ Name = "Jeb"},
                new ExcellentPupil(){ Name = "Sir Mulich"},
                new ExcellentPupil(){ Name = "CJ"}
            };

            ClassRoom bmstu = new ClassRoom(class1);
            bmstu.ShowAllPupils();
            Console.WriteLine();

            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(12, 23, 10000, 80, 1999),
                new Ship(123, 321, 10000, 10, 1998, 17, "Novorossiysk"),
                new Plane(189, 48, 20000, 3000, 2007, 2000, 120)
            };

            VehicleYard.ShowVehicleStats(vehicles);


            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            if (password == "12345")
            {
                ProDocumentWorker worker = new ProDocumentWorker();
                worker.DocumentOpen();
                worker.EditDocument();
                worker.SaveDocument();
            }
            else if (password == "1234567")
            {
                ExpertDocumentWorker worker = new ExpertDocumentWorker();
                worker.DocumentOpen();
                worker.EditDocument();
                worker.SaveDocument();
            }
            else
            {
                DocumentWorker worker = new DocumentWorker();
                worker.DocumentOpen();
                worker.EditDocument();
                worker.SaveDocument();
            }
            


        }
    }
}