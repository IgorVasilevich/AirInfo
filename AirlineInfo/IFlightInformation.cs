using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    interface IFlightInformation
    {
        void Delete();
        void Edit();
        void Print();
        void PrintWithPrices();
        void SearchPrintByFNumber(string fnumber);
        void SearchPrintCityArrival(string cityArrival);
        void SearchPrintCityDeparture(string cityDeparture);

    }
}
