using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    /// Summary description for Employee.
    public abstract class Employee
    {
        //we can have fields and properties in the Abstract class
        protected String id;
        protected String lname;
        protected String fname;
        //properties
        public abstract String ID
        {
            get;
            set;
        }

        public abstract String FirstName
        {
            get;
            set;
        }
        public abstract String LastName
        {
            get;
            set;
        }
        //completed methods
        public String Update()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " updated";
        }
        //completed methods
        public String Add()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " added";
        }
        //completed methods


        public String Delete()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }
        //completed methods


        public String Search()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " found";
        }

        //abstract method that is different from Fulltime and Contractor therefore i keep it uncompleted and let each implementation 
        //complete it the way they calculate the wage.
        public abstract String CalculateWage();
    }
    /// <span class="code-SummaryComment"><summary></span>


    /// Summary description for IEmployee.

    /// <span class="code-SummaryComment"></summary></span>

    public interface IEmployee
    {
        //cannot have fields. uncommenting 
        //will raise error!
        //        protected String id;
        //        protected String lname;
        //        protected String fname;
        //just signature of the properties 
        //and methods.
        //setting a rule or contract to be 
        //followed by implementations.
        String ID
        {
            get;
            set;
        }
        String FirstName
        {
            get;
            set;
        }
        String LastName
        {
            get;
            set;
        }
        // cannot have implementation
        // cannot have modifiers public 
        // etc all are assumed public
        // cannot have virtual
        String Update();
        String Add();
        String Delete();
        String Search();
        String CalculateWage();
    }
    /// 
    /// Summary description for Emp_Fulltime.
    /// 
    //Inheriting from the Abstract class
    public class Emp_Fulltime : Employee
    {
        //uses all the properties of the 
        //Abstract class therefore no 
        //properties or fields here!
        public Emp_Fulltime()
        {
        }
        public override String ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public override String FirstName
        {
            get

            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public override String LastName
        {
            get

            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        //common methods that are 
        //implemented in the abstract class
        public new String Add()
        {
            return base.Add();
        }
        //common methods that are implemented 
        //in the abstract class
        public new String Delete()
        {
            return base.Delete();
        }
        //common methods that are implemented 
        //in the abstract class
        public new String Search()
        {
            return base.Search();
        }
        //common methods that are implemented 
        //in the abstract class
        public new String Update()
        {
            return base.Update();
        }
        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore I override it here.
        public override String CalculateWage()
        {
            return "Full time employee " +
                  base.fname + " is calculated " +
                  "using the Abstract class...";
        }
    }
    /// 
    /// Summary description for Emp_fulltime2.
    /// 
    //Implementing the interface
    public class Emp_fulltime2 : IEmployee
    {
        //All the properties and 
        //fields are defined here!
        protected String id;
        protected String lname;
        protected String fname;
        public Emp_fulltime2()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public String ID
        {
            get

            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public String FirstName
        {
            get
            {
                return fname;
            }
            set

            {
                fname = value;
            }
        }

        public String LastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        //all the manipulations including Add,Delete, 
        //Search, Update, Calculate are done
        //within the object as there are not 
        //implementation in the Interface entity.
        public String Add()
        {
            return "Fulltime Employee " +
                          fname + " added.";
        }

        public String Delete()
        {
            return "Fulltime Employee " +
                        fname + " deleted.";
        }
        public String Search()
        {
            return "Fulltime Employee " +
                       fname + " searched.";
        }
        public String Update()
        {
            return "Fulltime Employee " +
                        fname + " updated.";
        }
        //if you change to Calculatewage(). 
        //Just small 'w' it will raise 
        //error as in interface
        //it is CalculateWage() with capital 'W'.
        public String CalculateWage()
        {
            return "Full time employee " +
                  fname + " caluculated using " +
                  "Interface.";
        }
    }


class Interface
    {

    }
}
