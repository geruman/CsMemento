using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsMemento.Tests
{
    [TestClass()]
    public class CareTakerTests
    {
        private CareTaker careTaker;
        [TestInitialize()]
        public void Initialize()
        {
            careTaker = new CareTaker();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            careTaker = null;
        }
        
        [TestMethod()]
        public void GetMementoTest()
        {
            Memento memento = new Memento(new Point(0, 0), 10);
            careTaker.SaveMemento(memento);
            Assert.AreEqual(memento, careTaker.GetMemento(0));
        }

        
    }
}