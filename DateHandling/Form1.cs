using Microsoft.VisualBasic;

namespace DateHandling;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculateDays_Click(object sender, EventArgs e)
    {
        DateTime todaysDate = DateTime.Today;
        DateTime futureDate = Convert.ToDateTime(txtFutureDate.Text);


        int currentDay = todaysDate.DayOfYear;
        int currentYear = todaysDate.Year;

        int futureDay = futureDate.DayOfYear;
        int futureYear = futureDate.Year;

        int difInYear = futureYear - currentYear;
        futureDay += (difInYear * 365);

        int daysUntilDue = futureDay - currentDay;

        string msg = "Current Date: " + todaysDate.ToShortDateString() + "\n" + "Future Date: " + futureDate.ToShortDateString() + "\n" + "Days Until Due: " + daysUntilDue;

        MessageBox.Show(msg, "Due Days Calculation");

    }

    private void btnCalculateAge_Click(object sender, EventArgs e)
    {
        DateTime todaysDate = DateTime.Today;
        DateTime birthDate = Convert.ToDateTime(txtBirthDate.Text);


        int currentDay = todaysDate.DayOfYear;
        int currentYear = todaysDate.Year;

        int birthDay = birthDate.DayOfYear;
        int birthYear = birthDate.Year;
        if (birthDay > currentDay) { birthYear += 1; }

        int curAge = currentYear - birthYear;

        string msg = "Current Date: " + todaysDate.ToShortDateString() + "\n" + "Future Date: " + birthDate.ToShortDateString() + "\n" + "Age: " + curAge;

        MessageBox.Show(msg, "Age Calculation");

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
