using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        #region Constants
        private const decimal TopTaxLimit = 467300m;
        private const double TopTaxRate = 0.15;
        private const double NormalTaxRate = 0.37;
        #endregion


        #region Fields
        private decimal christmasBonus;
        private string firstname;
        private string lastname;
        private decimal monthlyBaseSalary;
        private decimal monthlyBonusSalary;
        private string ssn;
        #endregion

        #region Constructor
        public Employee(string firstname, string lastname, string ssn, decimal monthlyBaseSalary, decimal monthlyBonusSalary,
            decimal christmasBonus)
        {
            try
            {
                Firstname = firstname;
                Lastname = lastname;
                Ssn = ssn;
                MonthlyBaseSalary = monthlyBaseSalary;
                MonthlyBonusSalary = monthlyBonusSalary;
                ChristmasBonus = christmasBonus;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }



        #endregion


        #region Properties
        public decimal ChristmasBonus
        {
            get { return christmasBonus; }
            set
            {
                if (!IsValidMonitarianValue(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (christmasBonus != value)
                {
                    christmasBonus = value;
                }

            }
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (!IsValidString(value))
                {
                    throw new ArgumentException();
                }
                if (firstname != value)
                {
                    firstname = value;
                }

            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (!IsValidString(value))
                {
                    throw new ArgumentException();
                }
                if (lastname != value)
                {
                    lastname = value;
                }

            }
        }

        public decimal MonthlyBaseSalary
        {
            get { return monthlyBaseSalary; }
            set
            {
                if (!IsValidMonitarianValue(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (monthlyBaseSalary != value)
                {
                    monthlyBaseSalary = value;
                }

            }
        }

        public decimal MonthlyBonusSalary
        {
            get { return monthlyBonusSalary; }
            set
            {
                if (!IsValidMonitarianValue(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (monthlyBonusSalary != value)
                {
                    monthlyBonusSalary = value;
                }

            }
        }

        public string Ssn
        {
            get { return ssn; }
            set
            {
                if (!IsValidNumericalString(value))
                {
                    throw new ArgumentException();
                }
                if (ssn != value)
                {
                    ssn = value;
                }

            }
        }


        #endregion



        #region Methods
        /// <summary>
        /// method which returns a calculated monthly payout
        /// </summary>
        /// <returns>a decimal</returns>
        public decimal GetMonthlyPayout()
        {
            decimal decMonthlyPayout = monthlyBaseSalary;

            decimal decTopTaxCalculated;
            decimal decNormalTaxCalculated;

            decimal decHighTaxRate = Convert.ToDecimal(TopTaxRate);
            decimal decNormalTaxRate = Convert.ToDecimal(NormalTaxRate);


            if (decMonthlyPayout < TopTaxLimit)
            {
                decMonthlyPayout = decMonthlyPayout * decNormalTaxRate;
            }
            else if (decMonthlyPayout > TopTaxLimit)
            {


                decTopTaxCalculated = decMonthlyPayout - TopTaxLimit;
                decTopTaxCalculated = decTopTaxCalculated * decHighTaxRate;

                //decNormalTaxCalculated = 0 - TopTaxLimit + decMonthlyPayout;
                decNormalTaxCalculated = TopTaxLimit * decNormalTaxRate;

                decMonthlyPayout = decTopTaxCalculated + decNormalTaxCalculated;
            }

            return decMonthlyPayout;
        }

        /// <summary>
        /// method which returns calculated yearly payout
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlyPayout()
        {
            decimal YearlyPayout = GetMonthlyPayout() * 12;

            return YearlyPayout;

        }

        /// <summary>
        /// method for controlling strings
        /// </summary>
        /// <param name="s">takes in a string</param>
        /// <returns>a boolean</returns>
        private static bool IsValidString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            else if (s.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// controls the numerical value of a string
        /// </summary>
        /// <param name="s">takes in a string</param>
        /// <returns>and returns a boolean</returns>
        private static bool IsValidNumericalString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            else if (!s.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// so weird, basicaly the same as the previous one set up in another way
        /// => means returns
        /// "d < 0.0m" = if(d < 0.0m)false
        /// else true
        /// </summary>
        /// <param name="d">accepts a decimal</param>
        /// <returns>returns a boolean</returns>
        private bool IsValidMonitarianValue(decimal d) => d < 0.0m ? false : true;

        #endregion

    }
}
