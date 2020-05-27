using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Title: HelpForm
 * 
 * Description:
 * This form just provides some useful information to the user about how to use the program in multiple door dec mode.
 * 
 */ 

namespace DoorDecCreator
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            // Removes the ability to change window size
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
