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
        public double getRekeningStand()
        {
            return _rekening.GetRekeningStand();
        }
        public List<string> getVerrichtingen()
        {
            List<string> temp = new List<string>();
            foreach (Verrichting item in _rekening.Verrichtingen)
            {
                temp.Add(item.ToString());
            }
            return temp;
        }
    }
}
