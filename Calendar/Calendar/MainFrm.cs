using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace Calendar
{
    public partial class MainFrm : Form
    {
        int month; 
        int year;
        int today;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        public void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();
            yearLabel.Text = year.ToString();

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
             
            for(int i = 1; i < dayoftheweek; i++)
            {
                blank blank = new blank();
                dayContainer.Controls.Add(blank);
            }

            for(int i = 1; i <=days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();

                if(i == now.Day && month == now.Month && year == now.Year)
                    userControlDays.days(i, true);
                else
                    userControlDays.days(i);

                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dayContainer.Controls.Clear();

            month++;
            if (month == 13)
            {
                year++;
                month = 1;
            }
            DateTime startofthemonth = new DateTime(year, month, 1);
            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();

            yearLabel.Text = year.ToString();

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                blank blank = new blank();
                dayContainer.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();

                if (i == now.Day && month == now.Month && year == now.Year)
                    userControlDays.days(i, true);
                else
                    userControlDays.days(i);

                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dayContainer.Controls.Clear();

            month--;
            if(month == 0)
            {
                year--;
                month = 12;
            }

            DateTime startofthemonth = new DateTime(year, month, 1);
            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();
            yearLabel.Text = year.ToString();

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                blank blank = new blank();
                dayContainer.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();

                if (i == now.Day && month == now.Month && year == now.Year)
                    userControlDays.days(i, true);
                else
                    userControlDays.days(i);

                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {

        }
    }
}