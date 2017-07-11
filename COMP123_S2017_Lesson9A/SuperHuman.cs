using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the SuperHuman class that derives from the Human class
 * Version: 0.2 - Added Private Initialize Method
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
    }
}
