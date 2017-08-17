using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Linlin Fan
 * Date:August 17, 2017
 * StudentID:300923300
 * Description:The SplashForm class of Pick Highest Card Application.
 * Version:0.1 
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        // PUBLIC PROPERTIES
        public PickHighestCardForm PickHighestCardForm
        {

            get
            {
                return Program.pickHighestCardForm;
            }

        }
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();

            this.Hide();

            SplashTimer.Enabled = false; // turn timer off
        }
    }
}
