using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu

{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //DoubleOlivePictureBox
        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //CheesyRonPictureBox
        }


        private void label2_Click_2(object sender, EventArgs e)
        {
            //LabelforBeveragesText
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //WaterPictureBox
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //LabelforWater
        }






        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //FantaPictureBox
        }



        private void label4_Click(object sender, EventArgs e)
        {
            //LabelforFanta
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //SpritePictureBox
        }



        private void label7_Click(object sender, EventArgs e)
        {
            //LabelforPepsi
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //LemonadePictureBox
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //LabelforLemonade
        }



        private void label9_Click(object sender, EventArgs e)
        {
            //LabelforPizzaSizes and Toppings
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //LabelforBeveragesSizes
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form   
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.Show();
        }

        private void GardenPizzaPictureBox_Click(object sender, EventArgs e)
        {
            //GardenPizzaPictureBox
        }

        private void DeluxePizzaPictureBox_Click(object sender, EventArgs e)
        {
            //DeluxePizzaPictureBox
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //PespiPictureBox
        }

        private void CheesyRonText_Click(object sender, EventArgs e)
        {
            //LabelforCheesyRon
        }

        private void DoubleOliveText_Click(object sender, EventArgs e)
        {
            //LabelforDoubleOlive
        }

        private void GardenText_Click(object sender, EventArgs e)
        {
            //LabelforGarden
        }

        private void DeluxePizzaText_Click(object sender, EventArgs e)
        {
            //LabelforDeluxe
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //LabelforSprite
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //LabelforshowingCustomizeYourPizza
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //LabelforMenutext
        }
    }
}
