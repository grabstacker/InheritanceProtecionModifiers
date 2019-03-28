using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProtecionModifiers
{
    //Type of Techonology to confirgure
    public class Computer
    {
    }

    //Choose the type of pc to Configure
    public class PC : Computer
    {
        protected String Brand;
    }

    public class Mac : Computer
    {
        protected String Brand;
    }

    //Choose operating system

    public class Windows : PC
    {
        protected Decimal Version;
    }

    public class Unix : Mac
    {
        protected Decimal Version;
    }


    public class OSX : Mac
    {
        protected Decimal Version;
    }

    //After the user has picked its base  platforms we can choose 
    //The different hardware options for budget.
    public class hardware : Windows 
    {
        protected Decimal smallCost;
        protected Decimal mediumCost;
        protected Decimal largeCost;

        
    }

    // Combines all information for processing and printing the order 
    // to screen
    public class BuildPc : hardware
    {


        //Prints the entire Configuration to screen
        public void ConfigfurationPrint()
        {

        }

        //Notifies the user of the Current status of their order
        public void CurrentStatus()
        {

        }
    }


}
