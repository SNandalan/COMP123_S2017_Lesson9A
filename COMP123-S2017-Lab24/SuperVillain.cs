using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Sushmita Nandalan
 * Date: July 18th 2017
 * Description: This is the SuperVillain class which inherits from SuperHuman Class and implements the IHasMalice interface
 * Version: 0.1 - Created SuperViallain class 
 */
namespace COMP123_S2017_Lab24
{
    class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        //PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }
        public SuperVillain(string name) : base(name)
        {

        }

    }
}
