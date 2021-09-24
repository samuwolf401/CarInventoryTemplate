using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carInventory = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(yearInput.Text);
            string make = makeInput.Text;
            string colour = colourInput.Text;
            int milage = Convert.ToInt32(mileageInput.Text);

            Car tempCar = new Car(year, make, colour, milage);
            carInventory.Add(tempCar);

            DisplayCars();
            yearInput.Text = "";
            makeInput.Text = "";
            colourInput.Text = "";
            mileageInput.Text = "";
        }
        public void DisplayCars()
        {
            outputLabel.Text = "";


            foreach (Car c in carInventory)
            {
                outputLabel.Text += $"\n{c.year} {c.make} {c.colour} {c.milage}";
            }
        }
    }
}
