using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Begin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreatePictureRegion()
        {
           Form1 ff = new Form1();
           PictureBox[] PB1 = null; 
            PB1 = ff.PB;
           if (PB1 != null)
           {
               for (int i = 0; i < PB1.Length; i++)
               {
                   PB1[i].Dispose();
               }
               PB1 = null;
           }
           Assert.AreEqual(ff.PB, PB1);
        }

        [TestMethod]
        public void TestDrawPicture()
        {
            Form1 ff = new Form1();
            int countX1 = 0; // счетчик прямоугольников по координате Х в одном ряду
            int countY1 = 0; // счетчик прямоуголников по координате Y в одном столбце
            int LengthSides1 = 3;
            int num = LengthSides1;
            // Считаем прямоугольники по рядам и столбцам.
            countX1++;
            if (countX1 == num)
            {
                countX1 = 0;
                countY1++;
            }
            if (countX1 == 0)
                Assert.Fail("Мозаика не может быть собрана!");
        } 
    }
}
