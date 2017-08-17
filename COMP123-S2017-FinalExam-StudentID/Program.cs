using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Linlin Fan
 * Date:August 17, 2017
 * StudentID:300923300
 * Description:The driver class of Pick Highest Card Application.
 * Version:0.1 
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    
    public static class Program
    {
        // Create Reference to Forms
        public static PickHighestCardForm pickHighestCardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate a new object of type PickHighestForm
            //pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new PickHighestCardForm());
            Application.Run(new SplashForm());
        }
    }
}
