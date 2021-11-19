using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsMemento
{
    public class CareTaker
    {
        private List<Memento> mementos;
        public CareTaker()
        {
            mementos = new List<Memento>();
        }
        public Memento GetMemento(int position)
        {
            return mementos.ElementAt(position);
        }
        public void SaveMemento(Memento memento)
        {
            mementos.Add(memento);
        }
    }
}
