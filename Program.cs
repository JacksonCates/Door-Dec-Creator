using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Title: Door Dec Creator
 * Last update: 5/26/2020
 * Author: Jackson Cates
 * 
 * Description:
 * This program's purpose is to create door decs used for RA's. This speeds the process of making individual door decs to each resident in the RA's hall.
 * 
 * This program has two modes, single door dec creator and multiple door dec creator. Both modes allow the user to control the dimensions and various other
 * options (boarder thickness, font size, font type, etc...). Where they differ is how they process names and images. While the single mode allows the user
 * to directly input the image and name, the multiple door dec is a bit more automated. The multiple door dec takes the images from the directory and names
 * from a spreadsheet.
 * 
 */

namespace DoorDecCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
