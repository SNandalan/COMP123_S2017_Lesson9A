using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the driver class for my project
 * Version: 0.2 - Added SuperHuman object and displayed it
 */
namespace COMP123_S2017_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Cloning", 50));
            superHuman.Powers.Add(new Power("Teleporting", 40));
            Console.WriteLine(superHuman.ToString());
        }
    }
}
