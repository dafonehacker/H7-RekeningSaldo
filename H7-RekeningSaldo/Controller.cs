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
        public Controller()//lege constructor
        {
        }
        //methods
        public void addVerrichting(Double bedrag, DateTime datum, String omschrijving)//bedrag, datum en omschrijving worden opgehaald van het forum
        {
            Verrichting _verrichting = new Verrichting(bedrag, datum, omschrijving);
            _rekening.AddVerrichting(_verrichting);
        }
        public string getRekeningStand()
        {
            return _rekening.GetRekeningStand();//de rekeningstand wordt meegegeven naar het forum
        }
        public List<string> getVerrichtingen()
        {
            List<string> Lijst = new List<string>();//nieuwe lijst wordt aangemaakt
            foreach (Verrichting item in _rekening.Verrichtingen)
            {
                Lijst.Add(item.ToString());
            }//iedere verrichting wordt omgezet naar de juiste text
            return Lijst;//de lijst wordt meegegeven naar het forum
        }
    }
}
