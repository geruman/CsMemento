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
    public class MementoTests
    {
        private Memento memento;
        [TestInitialize()]
        public void Initialize()
        {
            memento = new Memento(new Point(0, 0), 10);
        }
        [TestCleanup()]
        public void Cleanup()
        {
            memento = null;
        }
        [TestMethod()]
        public void MementoTest()
        {
            Assert.IsTrue(memento is Memento);
        }

        [TestMethod()]
        public void GetHealthTest()
        {
            Assert.AreEqual(10, memento.GetHealth());
        }

        [TestMethod()]
        public void GetPlayerPositionTest()
        {
            Assert.AreEqual(new Point(0, 0), memento.GetPlayerPosition());
        }
    }
}