using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotfolioConsoleApp
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            //While loop ot keep program open.
            bool showMenu = true;
            while (showMenu)
            {
                //As long as true, app will stay open. if false, app will close.
                showMenu = MainMenu.WriteMainMenu();
            }
            
           
            
        }
    }
        




           
        

 
    

    

    


}
