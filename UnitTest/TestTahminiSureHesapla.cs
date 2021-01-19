using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class TestTahminiSureHesapla
    {
        YazilimSinamaProjeSon.Form2 form2 = new YazilimSinamaProjeSon.Form2();

        [TestMethod]
        public void test1()
        {
            int tahminiSure = form2.TahminiSureHesapla("tasarım olustur","","","","");
            Assert.AreEqual(1, tahminiSure);
        }

        [TestMethod]
        public void test2()
        {
            int tahminiSure = form2.TahminiSureHesapla("tasarım olustur", "sql baglantisi kur", "", "", "");
            Assert.AreEqual(2, tahminiSure);
        }

        [TestMethod]
        public void test3()
        {
            int tahminiSure = form2.TahminiSureHesapla("tasarım olustur", "sql baglantisi kur", "tablolara aktar", "", "");
            Assert.AreEqual(3, tahminiSure);
        }

        [TestMethod]
        public void test4()
        {
            int tahminiSure = form2.TahminiSureHesapla("tasarım olustur", "sql baglantisi kur", "tablolara aktar", "guncelle", "");
            Assert.AreEqual(4, tahminiSure);
        }

        [TestMethod]
        public void test5()
        {
            int tahminiSure = form2.TahminiSureHesapla("tasarım olustur", "sql baglantisi kur", "tablolara aktar", "guncelle", "son kontrolleri yap");
            Assert.AreEqual(5, form2.tahminiSure);
        }
    }
}
