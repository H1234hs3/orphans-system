using Microsoft.VisualStudio.TestTools.UnitTesting;
using orphan.Data.SqlServer;
using orphan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using orphan.Core.Model;

namespace orphan.Test
{
    [TestClass]
    public class NewOrphansEntityTest
    {
        IDataHelper<NewOrphan> dataHelper;
        public NewOrphansEntityTest()
        {
            dataHelper = new NewOrphansEntity();
        }
        [TestMethod]
        public void AddTest()
        {
            //Arrange(set)
            //NewOrphan NewOrphan = new NewOrphan
            //{
            //    NameOrphan = "mohamed saind ufcckls",
            //    OrphanClassification = "dcsdcdsc",
            //    Gender = "man",
            //    Country = "yemen",
               
            //    Village = "ds",
            //    EducationalLevel = "three",
            //    DateBirth = DateTime.Now,       

            //};
            //Act and expt(get)
            //int act = dataHelper.Add(NewOrphan);
            //int expt = 1;
            ////Assert(test)
            //Assert.AreEqual(expt, act);
        }


        [TestMethod]
        public void EditTest()
        {
            //Arrange(set)
            //NewOrphan NewOrphan = new NewOrphan
            //{
            //    Id = 2,
            //    NameOrphan = "hassan mo",
            //    OrphanClassification = "كافل ",
            //    Gender = "ذكر ",
            //    Country = "اليمن",
              
            //    Village = "الربيصة",
            //    EducationalLevel =" جامعه",
            //    DateBirth = DateTime.Now,

            //};
            ////Act and expt(get)
            //int act = dataHelper.Edit(NewOrphan);
            //int expt = 1;
            ////Assert(test)
            //Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void GetAllDataTest()
        {
            //Arrange(set)

            //Act and expt(get)
            var act = dataHelper.GetAllData();
          
            //Assert(test)
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void ShearchTest()
        {
            //Arrange(set)
            var searchitem = "hassan mo";
            //Act and expt(get)
            var act = dataHelper.Sherach(searchitem);

            //Assert(test)
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void FindTest()
        {
            //Arrange(set)
            var Id = 2;
            //Act and expt(get)
            var act = dataHelper.find(2);

            //Assert(test)
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void DeletTest()
        {
            //Arrange(set)
            var Id = 1;
            //Act and expt(get)
            var act = dataHelper.Delete(3);

            //Assert(test)
            Assert.AreEqual(1,act);
        }
    }
}