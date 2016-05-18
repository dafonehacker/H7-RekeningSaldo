using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_RekeningSaldo
{
    class Rekening
    {
        //properties
        private List<Verrichting> _verrichtingen;

        public List<Verrichting> Verrichtingen
        {
            get { return _verrichtingen; }
            set { _verrichtingen = value; }
        }      
        //constructor
        public Rekening()
        {
            Verrichtingen = new List<Verrichting>();
        }
        //methods
        public void AddVerrichting(Verrichting verrichting)
        { 
            //code voor het toevoegen van een nieuwe verrichting
            //aan de verzameling Verrichtingen      
        }
        public double GetRekeningStand()
        {
            //geef de stand van de rekening terug
            return 0.0;
        }

        
    }
}
