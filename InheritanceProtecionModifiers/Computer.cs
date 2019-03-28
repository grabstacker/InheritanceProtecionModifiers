using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProtecionModifiers
{
    
    //Type of Techonology to confirgure
    public abstract class Computer
    {
            //Setup Configuration variables
        protected String _TechnologyChoosen = "Computer";
        protected String _Brand;
        protected double _Version;
        protected double _Budget;

            //Create a string used to keep track of the Computer build config
        protected string BuildConfigurationString;



    }

    // Combines all information for processing and printing the order 
    // to screen for a PC build
    public class PcBuild : Computer
    {
        protected string ComputerType = "PC";
        public void ConfigurationBuildAdd(string SavedConfigText)
        {
            BuildConfigurationString = SavedConfigText;
        }


        //Prints the entire Configuration to screen
        public void ConfigfurationPrint()
        {
            System.Windows.Forms.MessageBox.Show(BuildConfigurationString);
        }

        //Notifies the user of the Current status of their order
        public void CurrentStatus()
        {
            if (BuildConfigurationString != "")
            {
                System.Windows.Forms.MessageBox.Show("Your " + ComputerType + " order has been received and is currently being shipped!");
            }
            else {
                System.Windows.Forms.MessageBox.Show("We are still waiting on your " + ComputerType + " parts selection");
            }
            
        }
    }

    public class MacBuild : PcBuild
    {
         protected new string ComputerType = "Mac";
    }


}
