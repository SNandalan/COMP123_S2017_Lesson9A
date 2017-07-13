using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the SuperHuman class that extends to the Human class
 * Version: 0.5 - Added the overridden ToString() method to the SuperHuman class
 */
namespace COMP123_S2017_Lab24
{
    /// <summary>
    /// This is the SuperHuman sub class
    /// It intherits from the Human SuperClass
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS
        private List<Power> _powers;

        //PUBLIC PROPERTIES
       public List<Power> Powers
        {
            get
            {
                return this._powers; // returns a reference to the Powers List
            }
        }

        //CONSTRUCTORS
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This method initializes and assigns default values to the Class fields.
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        //PUBLIC METHODS
        /// <summary>
        /// This method adds a Power to the Power list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank: " +power.Rank);
            }
        }
        /// <summary>
        ///The ToString method overrides the built-in Object.ToString method.
        /// It outputs a string that displays the superhuman's name and their power list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "*****************************************************************************************\n";
            outputString += "Super Human Name: " + this.Name + "\n";
            outputString += "*****************************************************************************************\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + "Rank: " + power.Rank + "\n";
            }
            outputString += "*****************************************************************************************\n";
            return outputString;
        }
    }
}
