using Entities;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntitiesTests
{
    [TestClass]
    public class EmployeeTests
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ChristmasBonusPropertyNegativeValueTest()
        {
            //Arrange
            decimal negativeChristmasBonus = -1.0m;
            string firstname = "Hansi";
            string lastname = "HinterSeer";
            string ssn = "2607921994";
            decimal monthlyBaseSalary = 467250m;
            decimal monthlyBonusSalary = 0m;
            decimal christmasBonus = 0m;

            Employee employee = new Employee(firstname, lastname, ssn, monthlyBaseSalary, monthlyBonusSalary,
            christmasBonus);

            //Act
            employee.MonthlyBaseSalary = negativeChristmasBonus;

            //Assert
        }

        [TestMethod]
        public void ChristmasBonusPropertyValidationTest()
        {
            //Arrang
            decimal christmasBonus = 10000m;
            string firstname = "Hansi";
            string lastname = "HinterSeer";
            string ssn = "2607921994";
            decimal monthlyBaseSalary = 467250m;
            decimal monthlyBonusSalary = 0m;


            Employee employee = new Employee(firstname, lastname, ssn, monthlyBaseSalary, monthlyBonusSalary,
            christmasBonus);
            //Act
            employee.ChristmasBonus = christmasBonus;

            //Assert
            Assert.AreEqual(christmasBonus, employee.ChristmasBonus);

        }

        [TestMethod]
        public void GetMonthlyPayoutTest()
        {
            decimal decExpectedPayout = 174401m;


            //Arrange
            decimal christmasBonus = 10000m;
            string firstname = "Hansi";
            string lastname = "HinterSeer";
            string ssn = "2607921994";
            decimal monthlyBaseSalary = 477300m;
            decimal monthlyBonusSalary = 0m;


            Employee employee = new Employee(firstname, lastname, ssn, monthlyBaseSalary, monthlyBonusSalary,
            christmasBonus);

            //Act
            employee.GetMonthlyPayout();

            //Assert
            Assert.AreEqual(decExpectedPayout, employee.GetMonthlyPayout());

        }
    }
}
