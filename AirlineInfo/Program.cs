using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WindowWidth = 159;
            Console.WindowHeight = 50;
            Console.SetWindowPosition(0, 0);

            AirInfo[] AirLineinfo = new AirInfo[10];
            AirLineinfo[0] = new AirInfo(new FlightInformation(DateTime.Parse("27/08/2016 10:02:00"), DateTime.Parse("27/08/2016 08:10:00"),
               "KH8", "Kyiv", "Kharkov", "A", Status.Arrived, "86-10", new FlyClass(FlyC.Business) { Price = 1400 }, new FlyClass(FlyC.Ecocnomy) { Price = 700 }),
               new Passenger("Petr", "Ivanov", "Ukraine", "098765", DateTime.Parse("01/08/1982").Date, Sex.Male, new FlyClass(FlyC.Ecocnomy)),
               new Passenger("Olga", "Petrova", "Ukraine", "123456", DateTime.Parse("20/09/1984").Date, Sex.Famale, new FlyClass(FlyC.Business))
               );
            AirLineinfo[1] = new AirInfo(new FlightInformation(DateTime.Parse("28/08/2016 22:08:00"), DateTime.Parse("28/08/2016 16:45:00"),
               "KY7", "Kyiv", "Paris", "B", Status.InFlight, "56-10", new FlyClass(FlyC.Business) { Price = 1600 }, new FlyClass(FlyC.Ecocnomy) { Price = 800 }),
               new Passenger("Ivan", "Petrov", "Ukraine", "876543", DateTime.Parse("30/01/1992").Date, Sex.Male, new FlyClass(FlyC.Ecocnomy)),
               new Passenger("Tanya", "Lomonos", "Ukraine", "987654", DateTime.Parse("01/10/1986").Date, Sex.Famale, new FlyClass(FlyC.Business))
               );
            AirLineinfo[2] = new AirInfo(new FlightInformation(DateTime.Parse("28/08/2016 16:04:00"), DateTime.Parse("28/08/2016 12:16:00"),
               "PS9", "Lviv", "Milan", "C", Status.Arrived, "42-10", new FlyClass(FlyC.Business) { Price = 2000 }, new FlyClass(FlyC.Ecocnomy) { Price = 1100 }),
               new Passenger("Sergey", "Kapinos", "Russia", "333333", DateTime.Parse("08/03/1991").Date, Sex.Male, new FlyClass(FlyC.Ecocnomy)),
               new Passenger("Irina", "Sergeeva", "Ukraine", "444444", DateTime.Parse("21/07/1984").Date, Sex.Famale, new FlyClass(FlyC.Business))
               );
            int choise = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("1.View data about flight");
                Console.WriteLine("2.View data about passengers in Fligths");
                Console.WriteLine("3.Edit data about Flights");
                Console.WriteLine("4.Edit data about Passengers");
                Console.WriteLine("5.Search");
                Console.WriteLine("0. Exit");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("1.View information about Fligts");
                            Console.WriteLine("2.View information about Flights woth prices");
                            Console.WriteLine("0.Back");
                            int choiseCase1 = int.Parse(Console.ReadLine());
                            if (choiseCase1 == 1)
                            {
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        
                                        Console.Write(i + 1+" ");
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.ReadLine();
                            }
                            if (choiseCase1 == 2)
                            {
                                PrintWithPriceTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        
                                        Console.Write(i + 1);
                                        AirLineinfo[i].FlightI.PrintWithPrices();
                                    }
                                }
                                Console.ReadLine();
                            }
                            break;
                            //Console.ReadLine();
                            if (choiseCase1 == 0)
                                break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            
                            for (int i = 0; i < AirLineinfo.Length; i++)
                            {
                                if (AirLineinfo[i] != null)
                                {
                                    PrintTableHead();
                                    Console.Write("{0} ",i + 1);
                                    AirLineinfo[i].FlightI.Print();
                                    Console.WriteLine("Passengers in Fligth");
                                    PrintPassTableHead();
                                    for (int j = 0; j < AirLineinfo[i].Passengers.Length; j++)
                                    {

                                        
                                        Console.Write("{0} ", j + 1);
                                        AirLineinfo[i].Passengers[j].PrintPassengers();
                                    }
                                    Console.ReadLine();
                                }
                            }
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("1. Add new Flight");
                            Console.WriteLine("2. Edit  Flight");
                            Console.WriteLine("3. Delete Flight");
                            Console.WriteLine("0. Back");
                            int choiseCase3 = int.Parse(Console.ReadLine());
                            int iter = 0;
                            if (choiseCase3 == 1)
                            {
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] == null)
                                    {
                                        iter = i;
                                        break;
                                    }
                                }
                                Console.WriteLine("Enter new date and time arrival(dd/mm/yyyy hh:mm:ss)");
                                DateTime dTArrival = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Enter new date and time departure(dd/mm/yyyy hh:mm:ss)");
                                DateTime dTDeparture = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Enter new FlightNumber:");
                                string flightN = Console.ReadLine();
                                Console.WriteLine("Enter new city of arrival:");
                                string cityArrival = Console.ReadLine();
                                Console.WriteLine("Enter new city of departure:");
                                string cityDeparture = Console.ReadLine();
                                Console.WriteLine("Enter new terminal:");
                                string terminal = Console.ReadLine();
                                Console.WriteLine("Enter new flight status:");
                                Status flightStatus = (Status)Enum.Parse(typeof(Status), Console.ReadLine());
                                Console.WriteLine("Enter new gate:");
                                string gate = Console.ReadLine();
                                FlyClass[] fClass = new FlyClass[2];
                                fClass[0] = new FlyClass(FlyC.Business);
                                fClass[1] = new FlyClass(FlyC.Ecocnomy);
                                for (int i = 0; i < fClass.Length; i++)
                                {

                                    Console.WriteLine("Enter price for{0}", fClass[i].Flyclass);
                                    fClass[i].Price = float.Parse(Console.ReadLine());
                                }
                                AirLineinfo[iter] = new AirInfo(new FlightInformation(dTArrival, dTDeparture, flightN, cityArrival, cityDeparture,
                                terminal, flightStatus, gate, fClass), new Passenger(null, null, null, null, new DateTime(), Sex.Male, new FlyClass(FlyC.Ecocnomy)));
                                
                            }
                            if (choiseCase3 == 2)
                            {
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo != null)
                                    {
                                        
                                        Console.Write((i + 1)+" ");
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.WriteLine("Enter number position to edit");
                                int iter2 = int.Parse(Console.ReadLine());
                                AirLineinfo[iter - 1].FlightI.Edit();
                            }
                            if (choiseCase3 == 3)
                            {
                                PrintPassTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo != null)
                                    {
                                        
                                        Console.WriteLine((i + 1)+" ");
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.WriteLine("Enter number position to delete");
                                int iter2 = int.Parse(Console.ReadLine());
                                AirLineinfo[iter - 1].FlightI.Delete();
                            }
                            if (choiseCase3 == 0)
                                break;
                        }

                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("1.Add passengers to Flight");
                            Console.WriteLine("2.Edit information about passengers in Flight");
                            Console.WriteLine("3. Delete passenger from Fligth");
                            Console.WriteLine("0. Back");
                            int choiseCase4 = int.Parse(Console.ReadLine());
                            if (choiseCase4 == 1)
                            {
                                int choiseFlight = 0;
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        
                                       Console.WriteLine((i + 1)+" ");
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.WriteLine("Enter N position");
                                choiseFlight = int.Parse(Console.ReadLine());
                                choiseFlight--;
                                int choisePassenger = 0;
                                for (int j = 0; j < AirLineinfo[choiseFlight].Passengers.Length; j++)
                                {
                                    if (AirLineinfo[choiseFlight].Passengers[j] == null)
                                    {
                                        choisePassenger = j;
                                        break;
                                    }
                                }
                                AirLineinfo[choiseFlight].Passengers[choisePassenger].Add();
                            }
                            if (choiseCase4 == 2)
                            {
                                int choiseFlight = 0;
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo != null)
                                    {
                             
                                        Console.WriteLine(i + 1);
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.WriteLine("Enter N position");
                                choiseFlight = int.Parse(Console.ReadLine()) - 1;
                                int choisePassenger = 0;
                                PrintPassTableHead();
                                for (int i = 0; i < AirLineinfo[choiseFlight].Passengers.Length; i++)
                                {
                                    if (AirLineinfo[choiseFlight].Passengers[i] != null)
                                    {
                                        
                                        Console.WriteLine(i + 1);
                                        AirLineinfo[choiseFlight].Passengers[i].PrintPassengers();
                                    }
                                }
                                Console.WriteLine("Choise number of passenger");
                                choisePassenger = int.Parse(Console.ReadLine());
                                AirLineinfo[choisePassenger].Passengers[choisePassenger].EditPassenger();

                            }
                            if (choiseCase4 == 3)
                            {
                                int choiseFlight = 0;
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo != null)
                                    {
                                        
                                        Console.WriteLine(i + 1);
                                        AirLineinfo[i].FlightI.Print();
                                    }
                                }
                                Console.WriteLine("Enter N position");
                                choiseFlight = int.Parse(Console.ReadLine()) - 1;
                                int choisePassenger = 0;
                                PrintPassTableHead();
                                for (int i = 0; i < AirLineinfo[choiseFlight].Passengers.Length; i++)
                                {
                                    if (AirLineinfo[choiseFlight].Passengers[i] != null)
                                    {
                                        
                                        Console.WriteLine(i + 1);
                                        AirLineinfo[choiseFlight].Passengers[i].PrintPassengers();
                                    }
                                }
                                Console.WriteLine("Choise number of passenger to delete");
                                choisePassenger = int.Parse(Console.ReadLine());
                                AirLineinfo[choisePassenger].Passengers[choisePassenger].DeletePassenger();

                            }
                            if (choiseCase4 == 1)
                                break;
                            break;

                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("1.Search by Flight number");
                            Console.WriteLine("2.Search by city Arrived");
                            Console.WriteLine("3.Search by city Departure");
                            Console.WriteLine("4.Search by price of Fligth");
                            Console.WriteLine("5.Search by Firstname of passenger");
                            Console.WriteLine("6.Search by SecondName of passenger");
                            Console.WriteLine("7.Search by passport of passenger");
                            Console.WriteLine("0.Back");
                            int choiseCase5 = int.Parse(Console.ReadLine());

                            if (choiseCase5 == 1)
                            {
                                Console.WriteLine("Enter Flight number");
                                string choiseFlightNumber = Console.ReadLine();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        if (AirLineinfo[i].FlightI.FlightN == choiseFlightNumber)
                                        {
                                            PrintTableHead();
                                            Console.Write("{0} ", i + 1);
                                            AirLineinfo[i].FlightI.SearchPrintByFNumber(choiseFlightNumber);
                                        }
                                    }
                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 2)
                            {
                                Console.WriteLine("Enter city Arrival");
                                string choiseCityArrived = Console.ReadLine();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        if (AirLineinfo[i].FlightI.CityArrival == choiseCityArrived)
                                        {
                                            PrintTableHead();
                                            Console.Write("{0} ", i + 1);
                                            AirLineinfo[i].FlightI.SearchPrintCityArrival(choiseCityArrived);
                                        }
                                    }
                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 3)
                            {
                                Console.WriteLine("Enter city Departure");
                                string choiseCityDeparture = Console.ReadLine();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        if (AirLineinfo[i].FlightI.CityDeparture == choiseCityDeparture)
                                        {
                                            PrintTableHead();
                                            Console.Write("{0} ", i + 1);
                                            AirLineinfo[i].FlightI.SearchPrintCityDeparture(choiseCityDeparture);
                                        }
                                    }
                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 4)
                            {
                                Console.WriteLine("Enter min price");
                                float minPrice = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter max price");
                                float maxPrice = float.Parse(Console.ReadLine());

                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        PrintWithPriceTableHead();
                                        Console.Write("{0} ", i + 1);
                                        AirLineinfo[i].FlightI.SearchByPrice(minPrice, maxPrice);
                                    }
                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 5)
                            {
                                Console.WriteLine("Enter FirstName");
                                string searchFirstName = Console.ReadLine();
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        for (int j = 0; j < AirLineinfo[i].Passengers.Length; j++)
                                        {
                                            if (AirLineinfo[i].Passengers[j].FirstName == searchFirstName)
                                            {
                                                Console.Write("{0} ", i + 1);
                                                AirLineinfo[i].FlightI.Print();
                                                PrintPassTableHead();
                                                AirLineinfo[i].Passengers[j].SearchPrintByFirstName(searchFirstName);
                                            }
                                        }
                                    }

                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 6)
                            {
                                Console.WriteLine("Enter SecondName");
                                string searchSecondName = Console.ReadLine();
                                PrintPassTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {

                                        for (int j = 0; j < AirLineinfo[i].Passengers.Length; j++)
                                        {
                                            if (AirLineinfo[i].Passengers[j].SecondName == searchSecondName)
                                            {
                                                Console.Write("{0} ", i + 1);
                                                AirLineinfo[i].FlightI.Print();
                                                PrintPassTableHead();
                                                AirLineinfo[i].Passengers[j].SearchPrintBySecondName(searchSecondName);
                                            }
                                        }
                                    }

                                }
                                Console.ReadLine();
                            }
                            if (choiseCase5 == 7)
                            {
                                Console.WriteLine("Enter Passport number");
                                string searchPassport = Console.ReadLine();
                                PrintTableHead();
                                for (int i = 0; i < AirLineinfo.Length; i++)
                                {
                                    if (AirLineinfo[i] != null)
                                    {
                                        for (int j = 0; j < AirLineinfo[i].Passengers.Length; j++)
                                        {
                                            if (AirLineinfo[i].Passengers[j].Passport == searchPassport)
                                            {
                                                Console.Write("{0} ", i + 1);
                                                AirLineinfo[i].FlightI.Print();
                                                PrintPassTableHead();
                                                AirLineinfo[i].Passengers[j].SearchPrintByPassport(searchPassport);
                                            }
                                        }
                                    }
                                }
                                if (choiseCase5 == 6)
                                    break;
                            }
                            Console.ReadLine();
                        }
                        break;

                }
            }
            while (choise != 0);




        }

        static void PrintWithPriceTableHead()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("N| Date Arrival        | Date Departed         |Fligh N |City Arrival   | City Departured |");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        static void PrintTableHead()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("N |Date Arrival         | Date Departed         |Fligh N |City Arrival   | City Departured |Terminal|Flight Status|Gate");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        static void PrintPassTableHead()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("N |First Name           | Second Name         |Nationality     | Passport       | Date of Birth     | Sex     | Flight Class  ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

    }
    }
