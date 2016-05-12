using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_RekeningSaldo
{
    public class Controller
    {
        //communicatie met andere classes
        Rekening _rekening = new Rekening();

        
        //constructor
        public Controller()
        {

        }
        //methods
        public void addVerrichting(Double bedrag, DateTime datum, String omschrijving)
        {
            Verrichting _verrichting = new Verrichting(bedrag, datum, omschrijving);
        }
        
    }
}
