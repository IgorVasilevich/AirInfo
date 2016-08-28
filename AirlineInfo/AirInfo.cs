using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    public class AirInfo//:IFlightInformation,IPassenger
    {
        public int Count { get { return Passengers.Length; } }
        public Passenger[] Passengers = new Passenger[20];
        public FlightInformation FlightI;
        public AirInfo(FlightInformation flight, params Passenger[] passengers)
        {
            FlightI = flight;
            Passengers = passengers;
        }

        //void IPassenger.EditPassenger()
        //{
        //    //throw new NotImplementedException();
        //}

        //void IPassenger.DeletePassenger()
        //{
        //    //throw new NotImplementedException();
        //}

        //void IPassenger.PrintPassengers()
        //{
        //    //throw new NotImplementedException();
        //}

        //void IPassenger.SearchPrintByFirstName(string FName)
        //{
        //    //throw new NotImplementedException();
        //}

        //void IPassenger.SearchPrintBySecondName(string SName)
        //{
        //    //throw new NotImplementedException();
        //}

        //void IPassenger.SearchPrintByPassport(string passport)
        //{
        //    //throw new NotImplementedException();
        //}

        //public void Delete()
        //{
        //    //throw new NotImplementedException();
        //}

        //public void Edit()
        //{
        //    //throw new NotImplementedException();
        //}

        //public void Print()
        //{
        //    //throw new NotImplementedException();
        //}

        //public void PrintWithPrices()
        //{
        //    //throw new NotImplementedException();
        //}

        //public void SearchPrintByFNumber(string fnumber)
        //{
        //    //throw new NotImplementedException();
        //}

        //public void SearchPrintCityArrival(string cityArrival)
        //{
        //    //throw new NotImplementedException();
        //}

        //public void SearchPrintCityDeparture(string cityDeparture)
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
