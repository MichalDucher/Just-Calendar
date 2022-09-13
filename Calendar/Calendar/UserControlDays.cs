using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday, bool today = false)
        {
            dayButton.Text = numday.ToString();

            if (today)
            {
                dayButton.BackColor = Color.FromArgb(230, 230, 250);
                dayButton.ForeColor = Color.Black;
            }
                
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
          // EventsFrm d = new EventsFrm();
         //   d.Show();
        }
    }
}
