namespace CS311_Project3_ATW
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        } // end frmMain

        private void frmMain_Load(object sender, EventArgs e)
        {

        } // end frmMain_Load

        private void lblPizzaSizes_Click(object sender, EventArgs e)
        {

        } // end lblPizzaSlices

        private void cboPizzaSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        } // end cboPizzaSlices

        private void picPizzaLogo_Click(object sender, EventArgs e)
        {

        } // end picPizzaLogo

        private void lblName_Click(object sender, EventArgs e)
        {

        } // end lblName

        private void ckbBlackOlives_CheckedChanged(object sender, EventArgs e)
        {

        } // end ckbBlackOlives

        private void ckbPepperoni_CheckedChanged(object sender, EventArgs e)
        {

        } // end ckbPepperonit

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();

        } // end btnCalculate

        private void ckbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {

        } // end ckbGreenPepper

        private void Summarize()
        {
            // cost variables
            const double taxRate = 0.06;
            double tax = 0;
            double subtotal = 0;
            double total = 0;

            // size prices
            const double small = 2.00;
            const double medium = 5.00;
            const double large = 10.00;
            const double xLarge = 15.00;

            // toppings prices
            const double pepperoni = 2.00;
            const double sausage = 2.00;
            const double canadian_bacon = 2.00;
            const double spicyItalianSausage = 2.00;
            const double onion = 1.00;
            const double greenPepper = 1.00;
            const double blackOlives = 1.00;
            const double greenOlives = 1.00;
            const double bananaPeppers = 1.00;
            const double jalapeno = 1.00;
            const double extraCheese = 1.00;
            const double mushroom = 1.00;


            /* ----------------------------------------------------------------------
            ------------------- Output statements w/crusts --------------------------
            ------------------------------------------------------------------------- */

            String data = cboPizzaSizes.GetItemText(cboPizzaSizes.SelectedItem);
            rtfOutput.Text = data;

            // rdo Thin
            if (rdoThinCrust.Checked)
                rtfOutput.SelectedText = "You ordered a " + data + " pizza with Thin crust and the following toppings:\n";

            // rdo Thick
            if (rdoThickCrust.Checked)
                rtfOutput.SelectedText = "You ordered a " + data + " pizza with Thick crust and the following toppings:\n";

            // rdo Regular
            if (rdoRegularCrust.Checked)
                rtfOutput.SelectedText = "You ordered a " + data + " pizza with Regular crust and the following toppings:\n";



            /* ----------------------------------------------------------------------
            ------------------- Toppings --------------------------------------------
            ------------------------------------------------------------------------- */

            rtfOutput.SelectionBullet = true; // turns on the bullet point formatting

            // properly formats each topping in the output window with bullet points

            if (ckbPepperoni.Checked)
                subtotal += pepperoni;
                rtfOutput.SelectedText = "Pepperoni\n";

            if (ckbSausage.Checked)
                subtotal += sausage;
                rtfOutput.SelectedText = "Sausage\n";

            if (ckbCanadianBacon.Checked)
                subtotal += canadian_bacon;
                rtfOutput.SelectedText = "Canadian Bacon\n";

            if (ckbSpicyItalianSausage.Checked)
                subtotal += spicyItalianSausage;
                rtfOutput.SelectedText = "Spicy Italian Sausage\n";

            if (ckbOnion.Checked)
                subtotal += onion;
                rtfOutput.SelectedText = "Onion\n";

            if (ckbGreenPepper.Checked)
                subtotal += greenPepper;
                rtfOutput.SelectedText = "Green Pepper\n";

            if (ckbBlackOlives.Checked)
                subtotal += blackOlives;
                rtfOutput.SelectedText = "Black Olives \n";

            if (ckbGreenOlives.Checked)
                subtotal += greenOlives;
                rtfOutput.SelectedText = "Green Olives\n";

            if (ckbBananaPeppers.Checked)
                subtotal += bananaPeppers;
                rtfOutput.SelectedText = "Banana Peppers\n";

            if (ckbJalapeno.Checked)
                subtotal += jalapeno;
                rtfOutput.SelectedText = "Jalapeno\n";

            if (ckbExtraCheese.Checked)
                subtotal += extraCheese;
                rtfOutput.SelectedText = "Extra Cheese\n";

            if (ckbMushroom.Checked)
                subtotal += mushroom;
                rtfOutput.SelectedText = "Mushroom\n";

            rtfOutput.SelectionBullet = false; // turns off bullet point formatting

            /* ----------------------------------------------------------------------
           ------------------- Price Totals -----------------------------------------
           -------------------------------------------------------------------------- */

            // subtotal price
            txtSubTotal.Text= subtotal.ToString("C");

            // sales tax price
            tax = taxRate * subtotal;
            txtTax.Text = tax.ToString("C");

            // total price
            total = subtotal + tax; 
            txtTotal.SelectedText = total.ToString("C");
           

        } // end Summarize()

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCrustType_Enter(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    } // end class

} // end namespace