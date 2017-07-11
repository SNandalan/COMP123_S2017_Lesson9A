using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the SuperHuman class that derives from the Human class
 * Version: 0.3 - Added Public AddPower Method
 */
namespace COMP123_S2017_Lesson9A
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

    }
}
