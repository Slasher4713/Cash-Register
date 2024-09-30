using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //Global varibles
        double donut;
        double cookie;
        double cake;
        double subtotal;
        double tax;
        double taxAmount;
        double total;
        double tendered;
        double change;
        double order;
        double hidden;
        double bigboy;
        double changeneeded;
        
        //Global sound players
        SoundPlayer di = new SoundPlayer(Properties.Resources.ding);
        SoundPlayer print = new SoundPlayer(Properties.Resources.Printer);
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set varibles to equal one
            order = 1;
            hidden = 1;
            bigboy = 0;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Try and catch errors
            try
            {
                //Conver text boxes to doubles and store them in varibles
                donut = Convert.ToDouble(donutsInput.Text);
                cookie = Convert.ToDouble(cookiesInput.Text);
                cake = Convert.ToDouble(cakesInput.Text);
                // Donut price is $1.99
                // Cookie price is $1.25
                // Cake price is $8.99
                // Calculate subtotal price and display it
                subtotal = (donut * 1.99) + (cookie * 1.25) + (cake * 8.99);
                subtotalOutput.Text = $"{subtotal.ToString("C")}";

                //This line is in case the error goes off before, so it can reset
                subtotalLabel.Text = "Subtotal";

                //Calculate and display the amount of tax
                tax = 0.13;
                taxAmount = subtotal * tax;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                //Play the "ding" sound
                di.Play();

                //Calculate and display total
                total = taxAmount + subtotal;
                totalOutput.Text = $"{total.ToString("C")}";

                //Enable and show buttons and labels
                changeButton.Enabled = true;
                changeButton.Visible = true;
                subtotalLabel.Visible = true;
                taxLabel.Visible = true;
                totalLabel.Visible = true;
                tenderedLabel.Visible = true;
                tenderedInput.Visible = true;
                
            }
            catch
            // Try to catch the errors and display errors
            {
                subtotalLabel.Text = "Error";
                subtotalLabel.Visible = true;
            }



        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Try and catch errors
            try
            {
                //Convert tendred money into a double and store it in a varible
                tendered = Convert.ToDouble(tenderedInput.Text);
               
                //If the tendered is less than the amount required, output an error
                if (tendered >= total)
                {
                    //Calculate and display change
                    change = tendered - total;
                    changeOutput.Text = $"{change.ToString("C")}";
                    receiptButton.Enabled = true;
                    receiptButton.Visible = true;
                    changeLabel.Visible = true;
                    if (tendered >= 1000)
                    {

                        if (bigboy == 0)
                        {
                            achievementLabel.Text += "\n~Big Boy~";
                        }
                        bigboy = 1;
                    }
                        

                    //Play "ding sound
                    di.Play();
                }
                else {
                    //Display the change needed if it is not enough
                    changeneeded = total - tendered;
                    changeOutput.Text = $"{changeneeded.ToString("C")} Needed";
                }

            }
            catch
            {
                //Display error
                changeOutput.Text = $"Error";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptButton.Enabled = false;
            //Play reciept sound
            print.Play();
            recieptOutput.Visible = true;

            //Print reciept and print one line at a time

            recieptOutput.Text += $"\n\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n           Creamer's Pastries             ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\nOrder Number             #{order}";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n          September 24th 2024";
            Refresh();
            Thread.Sleep(250);

            // If a varible is valued at 0, don't print it on the receipt
            if (donut > 0)
            {
                recieptOutput.Text += $"\n\nDonuts                   x{donut} @ 1.99";
            }
            else
            {
                recieptOutput.Text += $"\n ";
            }
            Refresh();
            Thread.Sleep(250);
            if (cookie > 0)
            {
              recieptOutput.Text += $"\nCookies                  x{cookie} @ 1.25";
                Refresh();
                Thread.Sleep(250);
            }
            if (cake > 0)
            {
                recieptOutput.Text += $"\nCake                     x{cake} @ 8.99";
                Refresh();
                Thread.Sleep(250);
            }
            recieptOutput.Text += $"\n\nSubtotal                 {subtotal.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\nTax                      {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\nTotal                    {total.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n\nTendered                 {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\nChange                   {change.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n\nMay A Delightful Day You Ought Have Man";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n\n          ";
         
            Refresh();

            //Let new order button be usable
            secretButton.Visible = true;
            orderButton.Enabled = true;
            orderButton.Visible = true;
           




        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Reset textboxes and values
            donutsInput.Text = $"";
            cookiesInput.Text = $"";
            cakesInput.Text = $"";
            tenderedInput.Text = $"";
            recieptOutput.Text = $"";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            orderButton.Enabled = false;
            changeButton.Visible = false;
            receiptButton.Visible = false;
            orderButton.Visible = false;
            subtotalLabel.Visible = false;
            taxLabel.Visible = false;
            totalLabel.Visible = false;
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            changeLabel.Visible = false;
            recieptOutput.Visible = false;
            secretButton.Visible = false;
            order++;
            receiptButton.Enabled = true;



        }

        private void secretButton_Click(object sender, EventArgs e)
        {
            //display a face is secret button is found on the receipt
            recieptOutput.Visible = true;
            recieptOutput.Text = $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n     ~---~                         ~---~  ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n       O                             O    ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                    ^^                    ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                    OO                    ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n          _________________________       ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n               |            |             ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n               |            |             ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n               |____________|              ";
            Refresh();
            Thread.Sleep(250);
            recieptOutput.Text += $"\n                                          ";

        }

        private void logoLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //If you click the label, change the logo and play a joke
            hidden++;
            if (hidden == 2)
            {
                achievementLabel.Visible = false;
                logoLabel.Text = "What do you call a fish with no eye?";

            }
            if (hidden == 3)
            {
                logoLabel.Text = "FSHHHH";
            }
            else if (hidden == 4)
            {
                hidden = 1;
                logoLabel.Text = "Creamer's Pastries";
                achievementLabel.Visible = true;
            }

           
        }
    }
}
