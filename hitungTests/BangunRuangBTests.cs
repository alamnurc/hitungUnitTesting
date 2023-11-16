using Microsoft.VisualStudio.TestTools.UnitTesting;
using hitung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitung.Tests
{
    [TestClass()]
    public class BangunRuangKTests
    {
        BangunRuangK Ku = new BangunRuangK();
        [TestMethod()]
        public void VolumeKubusTest()
        {
            double hasilvk = Ku.VolumeKubus(5);
            Assert.AreEqual(125, hasilvk);
        }

        [TestMethod()]
        public void LuasKubusTest()
        {
            double hasillk = Ku.LuasKubus(5);
            Assert.AreEqual(150, hasillk);
        }
    }

    [TestClass()]
    public class BangunRuangBTests
    {
        BangunRuangB Ba = new BangunRuangB();
        [TestMethod()]
        public void VolumeBalokTest()
        {
            double hasilvb = Ba.VolumeBalok(3, 4, 5);
            Assert.AreEqual(60, hasilvb);
        }

        [TestMethod()]
        public void LuasBalokTest()
        {
            double hasillb = Ba.LuasBalok(3, 4, 5);
            Assert.AreEqual(94, hasillb);
        }
    }
    [TestClass()]
    public class BangunRuangLSETests
    {
        BangunRuangLSE Le = new BangunRuangLSE();
        [TestMethod()]
        public void VolumeLimasSegiEmpatTest()
        {
            double hasilvl = Le.VolumeLimasSegiEmpat(6, 5);
            Assert.AreEqual(60, hasilvl);
        }

        [TestMethod()]
        public void LuasLimasSegiEmpatTest()
        {
            double hasilll = Le.LuasLimasSegiEmpat(6, 10);
            Assert.AreEqual(156, hasilll);
        }
    }
}