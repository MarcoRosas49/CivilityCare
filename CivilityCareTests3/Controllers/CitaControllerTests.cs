using Microsoft.VisualStudio.TestTools.UnitTesting;
using CivilityCare.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilityCare.Models;
using CivilityCare.ViewModels;
using Moq;

namespace CivilityCare.Controllers.Tests
{
    [TestClass()]
    public class CitaControllerTests
    {
        [TestMethod()]
        public void InscribirCitaTest()
        {
            Cita cita = new Cita();
            var mockServicioCita = new Mock<InscribirCitaViewModel>();
            
            Assert.Fail();
        }

      
}