using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Tour
    {

        private int tailleMax { get;set; }
        private Anneau[] tab { get; set; }
        private int nbreAnx { get; set; }
        private char alias { get; set; }

        public Tour (int tailleMax, int nbreAnx ,char alias)
        {
            this.alias = alias;
            this.tailleMax = tailleMax;
            tab = new Anneau[tailleMax];
            this.nbreAnx = -1;
                        
        }
        public void push(Anneau x)
        {
            tab[++nbreAnx] = x;
        }
        public Anneau  pop()
        {
            return tab[nbreAnx--];
        }
        public Anneau peek()
        {
            return tab[nbreAnx];
        }
        public Boolean isEmpty()
        {
            return (nbreAnx == -1);
        }
        public Boolean isFull()
        {
            return (nbreAnx == tab.Length - 1);
        }
        public Boolean vider() {
            return nbreAnx == -1;
        }
        public String toString()
        {
            String con="";
            for (int a = nbreAnx; a >= 0; a--)
            {
                con+=tab[a].getDiametre;
            }  
            for(int a = nbreAnx++; a<=tab.Length; a++)
            {
                con += "-";
            }
            return alias+":"+con;
        }
    }
}
