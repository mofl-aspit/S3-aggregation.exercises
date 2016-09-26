using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Department
    {
        #region Fields
        private List<Employee> employees;
        private bool isBudgetExceeded;
        private decimal yearlyBudget;
        #endregion

        #region Constructor
        public Department(List<Employee> employees, decimal yearlyBudget)
        {
            this.employees = employees;
            this.yearlyBudget = yearlyBudget;
        }


        #endregion

        #region Properties needs some work
        public IReadOnlyList<Employee> Employees
        {
            get { return (IReadOnlyList<Employee>)employees; }

        }

        public bool IsBudgetExceeded
        {
            get { return isBudgetExceeded; }
            set
            {
                if (isBudgetExceeded != value)
                {
                    isBudgetExceeded = value;
                }
            }
        }


        public decimal MonthlyPayout
        {
            get { return CalculateMonthlyPayout(); }
        }

        //public decimal YearlyPayout
        //{
        //    get { return YearlyBudget; }
        //}



        public decimal YearlyBudget
        {
            get
            {
                return yearlyBudget;
            }

            set
            {

                if (yearlyBudget != value)
                {
                    yearlyBudget = value;
                }

            }
        }


        #endregion

        #region Methods needs some work
        public void Add(Employee employee)
        {

        }

        /// <summary>
        /// the emp is a placeholder till more work is done here
        /// </summary>
        /// <param name="ssn">takes in an, string ssn</param>
        /// <returns>an employee?</returns>
        //public Employee GetEmployeeBy(string ssn)
        //{
        //    Employee emp = new Employee();

        //    return emp;
        //}

        /// <summary>
        /// the emp is a placeholder till more work is done here
        /// </summary>
        /// <param name="firstnames">a string value for the Firstname</param>
        /// <param name="lastnames">a string value for the Lastname</param>
        /// <returns>an employee?</returns>
        //public Employee GetEmployeeBy(string firstnames, string lastnames)
        //{
        //    Employee emp = new Employee();

        //    return emp;
        //}


        public void Remove(Employee employee)
        {

        }

        private void CalculateBudgetExcession()
        {

        }

        /// <summary>
        /// placeholder for actual code
        /// </summary>
        /// <returns>a Double</returns>
        private decimal CalculateMonthlyPayout()
        {
            decimal placeholder = 0;

            return placeholder;
        }
        #endregion

    }
}
