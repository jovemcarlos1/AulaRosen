using AulaRosen.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste01
{
    [TestClass]
    internal class TestConverteMilimetros
    {
        [TestMethod]
        public void Converter()
        {
            //cenário
            int metro = 3;
            
            int resultado = MetrosMilimetros.Converter(metro);
            
            Assert.AreEqual(metro, resultado);
            
            
        }
    }
}
