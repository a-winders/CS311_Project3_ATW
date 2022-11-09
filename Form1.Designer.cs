namespace CS311_Project3_ATW
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.picPizzaLogo = new System.Windows.Forms.PictureBox();
            this.cboPizzaSizes = new System.Windows.Forms.ComboBox();
            this.lblPizzaSizes = new System.Windows.Forms.Label();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdoRegularCrust = new System.Windows.Forms.RadioButton();
            this.rdoThickCrust = new System.Windows.Forms.RadioButton();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaLogo)).BeginInit();
            this.grpCrustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(221, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(476, 79);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nonni\'s Pizza";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // picPizzaLogo
            // 
            this.picPizzaLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picPizzaLogo.Image = global::CS311_Project3_ATW.Properties.Resources.PizzaLogo;
            this.picPizzaLogo.Location = new System.Drawing.Point(-4, 12);
            this.picPizzaLogo.Name = "picPizzaLogo";
            this.picPizzaLogo.Size = new System.Drawing.Size(250, 187);
            this.picPizzaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizzaLogo.TabIndex = 1;
            this.picPizzaLogo.TabStop = false;
            this.picPizzaLogo.Click += new System.EventHandler(this.picPizzaLogo_Click);
            // 
            // cboPizzaSizes
            // 
            this.cboPizzaSizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPizzaSizes.FormattingEnabled = true;
            this.cboPizzaSizes.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboPizzaSizes.Location = new System.Drawing.Point(91, 222);
            this.cboPizzaSizes.Name = "cboPizzaSizes";
            this.cboPizzaSizes.Size = new System.Drawing.Size(108, 29);
            this.cboPizzaSizes.TabIndex = 2;
            this.cboPizzaSizes.SelectedIndexChanged += new System.EventHandler(this.cboPizzaSizes_SelectedIndexChanged);
            // 
            // lblPizzaSizes
            // 
            this.lblPizzaSizes.AutoSize = true;
            this.lblPizzaSizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaSizes.Location = new System.Drawing.Point(40, 225);
            this.lblPizzaSizes.Name = "lblPizzaSizes";
            this.lblPizzaSizes.Size = new System.Drawing.Size(45, 21);
            this.lblPizzaSizes.TabIndex = 3;
            this.lblPizzaSizes.Text = "Size:";
            this.lblPizzaSizes.Click += new System.EventHandler(this.lblPizzaSizes_Click);
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.rdoRegularCrust);
            this.grpCrustType.Controls.Add(this.rdoThickCrust);
            this.grpCrustType.Controls.Add(this.rdoThinCrust);
            this.grpCrustType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCrustType.Location = new System.Drawing.Point(240, 222);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(392, 39);
            this.grpCrustType.TabIndex = 4;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type:";
            this.grpCrustType.Enter += new System.EventHandler(this.grpCrustType_Enter);
            // 
            // rdoRegularCrust
            // 
            this.rdoRegularCrust.AutoSize = true;
            this.rdoRegularCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRegularCrust.Location = new System.Drawing.Point(272, 2);
            this.rdoRegularCrust.Name = "rdoRegularCrust";
            this.rdoRegularCrust.Size = new System.Drawing.Size(87, 25);
            this.rdoRegularCrust.TabIndex = 5;
            this.rdoRegularCrust.TabStop = true;
            this.rdoRegularCrust.Text = "Regular";
            this.rdoRegularCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThickCrust
            // 
            this.rdoThickCrust.AutoSize = true;
            this.rdoThickCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThickCrust.Location = new System.Drawing.Point(187, 2);
            this.rdoThickCrust.Name = "rdoThickCrust";
            this.rdoThickCrust.Size = new System.Drawing.Size(69, 25);
            this.rdoThickCrust.TabIndex = 1;
            this.rdoThickCrust.TabStop = true;
            this.rdoThickCrust.Text = "Thick";
            this.rdoThickCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThinCrust.Location = new System.Drawing.Point(109, 2);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(62, 25);
            this.rdoThinCrust.TabIndex = 0;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(43, 278);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(84, 21);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPepperoni.Location = new System.Drawing.Point(133, 278);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(99, 24);
            this.ckbPepperoni.TabIndex = 6;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            this.ckbPepperoni.CheckedChanged += new System.EventHandler(this.ckbPepperoni_CheckedChanged);
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(133, 308);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(85, 24);
            this.ckbSausage.TabIndex = 7;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCanadianBacon.Location = new System.Drawing.Point(133, 340);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(139, 24);
            this.ckbCanadianBacon.TabIndex = 8;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(133, 371);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(173, 24);
            this.ckbSpicyItalianSausage.TabIndex = 9;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(314, 279);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(70, 24);
            this.ckbOnion.TabIndex = 10;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenPepper.Location = new System.Drawing.Point(314, 308);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(123, 24);
            this.ckbGreenPepper.TabIndex = 11;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            this.ckbGreenPepper.CheckedChanged += new System.EventHandler(this.ckbGreenPepper_CheckedChanged);
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackOlives.Location = new System.Drawing.Point(314, 340);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(111, 24);
            this.ckbBlackOlives.TabIndex = 12;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            this.ckbBlackOlives.CheckedChanged += new System.EventHandler(this.ckbBlackOlives_CheckedChanged);
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenOlives.Location = new System.Drawing.Point(314, 371);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(116, 24);
            this.ckbGreenOlives.TabIndex = 13;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaPeppers.Location = new System.Drawing.Point(462, 279);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(140, 24);
            this.ckbBananaPeppers.TabIndex = 14;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJalapeno.Location = new System.Drawing.Point(462, 308);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(90, 24);
            this.ckbJalapeno.TabIndex = 15;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraCheese.Location = new System.Drawing.Point(462, 338);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(117, 24);
            this.ckbExtraCheese.TabIndex = 16;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(462, 368);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(105, 24);
            this.ckbMushroom.TabIndex = 17;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(466, 455);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(81, 21);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(507, 494);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(40, 21);
            this.lblTax.TabIndex = 19;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(495, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 21);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(553, 455);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubTotal.TabIndex = 21;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(553, 494);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 22;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(553, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(512, 584);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 77);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rtfOutput
            // 
            this.rtfOutput.Location = new System.Drawing.Point(40, 433);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.Size = new System.Drawing.Size(420, 228);
            this.rtfOutput.TabIndex = 25;
            this.rtfOutput.Text = "";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderSummary.Location = new System.Drawing.Point(12, 409);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(135, 21);
            this.lblOrderSummary.TabIndex = 26;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 687);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.rtfOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbJalapeno);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenOlives);
            this.Controls.Add(this.ckbBlackOlives);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbPepperoni);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.lblPizzaSizes);
            this.Controls.Add(this.cboPizzaSizes);
            this.Controls.Add(this.picPizzaLogo);
            this.Name = "frmMain";
            this.Text = "Nonni\'s Pizza";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaLogo)).EndInit();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private PictureBox picPizzaLogo;
        private ComboBox cboPizzaSizes;
        private Label lblPizzaSizes;
        private GroupBox grpCrustType;
        private RadioButton rdoRegularCrust;
        private RadioButton rdoThickCrust;
        private RadioButton rdoThinCrust;
        private Label lblToppings;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbJalapeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
        private RichTextBox rtfOutput;
        private Label lblOrderSummary;
    }
}