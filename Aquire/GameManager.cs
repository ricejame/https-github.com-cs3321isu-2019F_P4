using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Aquire
{
    // GameManager class used to control class instances used for game play. JR
    class GameManager
    {
        // Variables
        private static bool gameEnded;
        private Form gameForm;
        
        

        //Default Constructor. JR
        public GameManager(Form form)
        {
            gameForm = form;
            gameEnded = false;
            
        }

        // initializes GameManager variables. JR
        public void initialize(float width, float height)
        {
            gameEnded = false;
            

        }


    }
}
