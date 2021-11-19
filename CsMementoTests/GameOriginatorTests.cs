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
    public class GameOriginatorTests
    {
        private GameOriginator originator;
        [TestInitialize()]
        public void Initialize()
        {
            originator = new GameOriginator();
        }
        [TestMethod()]
        public void GameOriginatorTest()
        {
            Assert.AreEqual(0, originator.PlayerPosition.X);
            Assert.AreEqual(0, originator.PlayerPosition.Y);
            Assert.AreEqual(10, originator.Health);
        }

        [TestMethod()]
        public void CreateMementoTest()
        {
            Memento memento = originator.CreateMemento();
            Assert.AreEqual(0, memento.GetPlayerPosition().X);
            Assert.AreEqual(0, memento.GetPlayerPosition().Y);
            Assert.AreEqual(10, memento.GetHealth());
        }

        [TestMethod()]
        public void SetMementoTest()
        {
            Memento memento = originator.CreateMemento();
            originator.PlayerPosition = new Point(25, 45);
            originator.Health = 56;
            originator.SetMemento(memento);
            Assert.AreEqual(0, memento.GetPlayerPosition().X);
            Assert.AreEqual(0, memento.GetPlayerPosition().Y);
            Assert.AreEqual(10, memento.GetHealth());
        }

        
    }
}