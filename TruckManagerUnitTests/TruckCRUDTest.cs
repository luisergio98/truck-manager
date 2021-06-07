using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TruckManager.Controllers;
using TruckManager.Models;
using TruckManager.Models.Context;

namespace TruckManagerUnitTests
{
    [TestClass]
    public class TruckCRUDTest
    {
        TrucksController _controller = new TrucksController(new TruckContext());

        [TestMethod]
        public void CreateTest()
        {
            var truck = new TruckModel { 
                Id = 0,
                Model = "FH",
                ManufactureYear = 2021,
                ModelYear = 2022
            };

           var result = _controller.Create(truck);
           Assert.AreEqual(result.Exception, null);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var truck = new TruckModel
            {
                Id = 3,
                Model = "FH",
                ManufactureYear = 2021,
                ModelYear = 2022
            };

            Task<IActionResult> result = _controller.Edit(truck.Id, truck);

            Assert.AreEqual(result.Exception, null);
        }

        [TestMethod]
        public void DeleteTest()
        {

            Task<IActionResult> result = _controller.Delete(3);

            Assert.AreEqual(result.Exception, null);
        }

        [TestMethod]
        public void ReadTest()
        {
           Task<IActionResult> result = _controller.Index();

           Assert.AreEqual(result.Exception, null);
        }

        public void DetailsTest()
        {
            Task<IActionResult> result = _controller.Details(1);

            Assert.AreEqual(result.Exception, null);
        }
    }
}
