using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    interface IPassenger
    {
        void EditPassenger();
        
        void DeletePassenger();
        void PrintPassengers();
        void SearchPrintByFirstName(string FName);
        void SearchPrintBySecondName(string SName);
        void SearchPrintByPassport(string passport);
    }
}
