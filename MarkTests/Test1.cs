using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Tests
{
    [TestClass()]
    public class Test1
    {
        [TestMethod()] 
        [DataRow(0, "No assolit")]
        [DataRow(4, "No assolit")]
        [DataRow(6, "Satisfactori")]
        [DataRow(8, "Notable")]
        [DataRow(9, "Excel·lent")]
        public void CalcularNotaTextTest(int num, string expected)
        {

            //Act
            string actual = Program.CalcularNotaText(num);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-6)]
        [DataRow(11)]
        [ExpectedException(typeof(Exception))]
        public void CalcularNotaText_Excepcions(int nota)
        {
            Program.CalcularNotaText(nota);
        }
        //private static bool CheckException(Func<object?> action)
        //{
        //    try { action.Invoke(); } catch (Exception ex) { return true; }
        //    return false;
        //}

        //[TestMethod]
        //public void CalcularNotaText_Excepcions()
        //{
        //    Assert.IsTrue(CheckException(() => Program.CalcularNotaText(-1)));
        //    Assert.IsTrue(CheckException(() => Program.CalcularNotaText(11)));
        //}

        //private static bool CheckException(Func<object?> action)
        //{
        //    try { action.Invoke(); } catch (Exception ex) { return true; }
        //    return false;
        //}

        //[TestMethod]
        //public void CalcularNotaText_Excepcions()
        //{
        //    Assert.IsTrue(CheckException(()=>Program.CalcularNotaText(-1)));
        //    Assert.IsTrue(CheckException(() => Program.CalcularNotaText(11)));
        //}

        //private static bool CheckException(Func<object?> action)
        //{
        //    try { action.Invoke(); } catch (Exception ex) { return true; }
        //    return false;
        //}

    }
}