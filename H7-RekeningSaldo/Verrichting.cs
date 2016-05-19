using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_RekeningSaldo
{
    class Verrichting
    {
        //properties
        private Double _bedrag;//het bedrag van de verrichting
        public Double Bedrag
        {
            get { return _bedrag; }
            set { _bedrag = value; }
        }

        private DateTime _datum;//de datum van de verrichting
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        private String _omschrijving;//de omschrijving van de verrichting
        public String Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }       
        //constructor
        public Verrichting()//lege verrichting
        {

        }
        public Verrichting(Double bedrag, DateTime datum, String omschrijving) //Constructor voor verrichting met alle nodige eigenschappen
        {
            Omschrijving = omschrijving;
            Datum = datum;
            Bedrag = bedrag;
        }
        //methods       
        public override string ToString()
        {
            //herschrijven van de ToString() method
            string datumnieuw = Datum.Day + "-" + Datum.Month + "-" + Datum.Year; //datum juist formatteren
            return Omschrijving + " (€" + Bedrag.ToString("0.00") + ")" + " op " + datumnieuw; //De verrichting op een leesbare manier in de list verwerken
        }
    }
}
