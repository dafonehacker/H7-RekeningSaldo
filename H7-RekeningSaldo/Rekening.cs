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
        private List<Verrichting> _verrichtingen; //lijst met alle verrichtingen op de rekening

        public List<Verrichting> Verrichtingen
        {
            get { return _verrichtingen; }
            set { _verrichtingen = value; }
        }

        private double _rekeningstand;//variabele die de rekeningstand bijhoudt

        public double Rekeningstand
        {
            get { return _rekeningstand; }
            set { _rekeningstand = value; }
        }
        
        //constructor
        public Rekening()//bij het maken van een rekening wordt een lijst met alle verrichtingen gemaakt
        {
            Verrichtingen = new List<Verrichting>();
        }
        //methods
        public void AddVerrichting(Verrichting verrichting)
        { 
            //code voor het toevoegen van een nieuwe verrichting
            //aan de verzameling Verrichtingen  
            Verrichtingen.Add(verrichting);//de verrichting toevoegen aan de list
            Rekeningstand += verrichting.Bedrag;//de rekeningstand bijwerken
            
        }
        public string GetRekeningStand()
        {
            //geef de stand van de rekening terug

            return "€" + Rekeningstand.ToString("0.00");//Getal juist formatteren
        }

        
    }
}
