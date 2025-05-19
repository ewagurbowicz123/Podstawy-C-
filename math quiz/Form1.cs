using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_quiz
{
    
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;
        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusleftlabel.Text = addend1.ToString();
            plusrightlabe.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            suma.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusleftlabel.Text = minuend.ToString();
            minusrightlabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesleftlabel.Text = multiplicand.ToString();
            timesrightlabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            devidedleftlabel.Text = dividend.ToString();
            devidedrightlabel.Text = divisor.ToString();
            iloraz.Value = 0;

            
            }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startbutton.Enabled = false;
        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == suma.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == iloraz.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft1.Tick += new EventHandler(timer1_Tick);
            
            {
                if (CheckTheAnswer())
                {
                    // If CheckTheAnswer() returns true, then the user 
                    // got the answer right. Stop the timer  
                    // and show a MessageBox.
                    timeleft1.Stop();
                    MessageBox.Show("You got all the answers right!",
                                    "Congratulations!");
                    startbutton.Enabled = true;
                }
                else if (timeLeft > 0)
                {
                    // If CheckTheAnswer() returns false, keep counting
                    // down. Decrease the time left by one second and 
                    // display the new time left by updating the 
                    // Time Left label.
                    timeLeft = timeLeft - 1;
                    timelabel.Text = timeLeft + " seconds";
                }
                else
                {
                    // If the user ran out of time, stop the timer, show
                    // a MessageBox, and fill in the answers.
                    timeleft1.Stop();
                    timelabel.Text = "Time's up!";
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                    suma.Value = addend1 + addend2;
                    difference.Value = minuend - subtrahend;
                    product.Value = multiplicand * multiplier;
                    iloraz.Value = dividend / divisor;
                    startbutton.Enabled = true;
                }
            }
        }
    }
}
