namespace OrderPizza
{
    partial class FRM_OrderPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.BTN_Rest = new System.Windows.Forms.Button();
            this.LBL_Summary_Size = new System.Windows.Forms.Label();
            this.LBL_Summary_Topping = new System.Windows.Forms.Label();
            this.LBL_Summary_Crust = new System.Windows.Forms.Label();
            this.LBL_Summary_Where = new System.Windows.Forms.Label();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.LbL_MainTitle = new System.Windows.Forms.Label();
            this.LBL_Dollar_Sign = new System.Windows.Forms.Label();
            this.LBL_Value_Price = new System.Windows.Forms.Label();
            this.LBL_Value_Size = new System.Windows.Forms.Label();
            this.LBL_Value_Topping = new System.Windows.Forms.Label();
            this.LBL_Value_Crust = new System.Windows.Forms.Label();
            this.LBL_Value_Where = new System.Windows.Forms.Label();
            this.GB_Summary = new System.Windows.Forms.GroupBox();
            this.GB_Options = new System.Windows.Forms.GroupBox();
            this.GB_Size = new System.Windows.Forms.GroupBox();
            this.RB_Size_Small = new System.Windows.Forms.RadioButton();
            this.RB_Size_Meduim = new System.Windows.Forms.RadioButton();
            this.RB_Size_Large = new System.Windows.Forms.RadioButton();
            this.GB_Crust = new System.Windows.Forms.GroupBox();
            this.RB_Crust_Thick = new System.Windows.Forms.RadioButton();
            this.RB_Crust_Thin = new System.Windows.Forms.RadioButton();
            this.GB_Topping = new System.Windows.Forms.GroupBox();
            this.CHK_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.CHK_Olives = new System.Windows.Forms.CheckBox();
            this.CHK_Onion = new System.Windows.Forms.CheckBox();
            this.CHK_Tomatoes = new System.Windows.Forms.CheckBox();
            this.CHK_Mushrooms = new System.Windows.Forms.CheckBox();
            this.CHK_ExtraCheese = new System.Windows.Forms.CheckBox();
            this.GB_WhereToEat = new System.Windows.Forms.GroupBox();
            this.RB_TakeAway = new System.Windows.Forms.RadioButton();
            this.RB_EatIn = new System.Windows.Forms.RadioButton();
            this.GB_Summary.SuspendLayout();
            this.GB_Options.SuspendLayout();
            this.GB_Size.SuspendLayout();
            this.GB_Crust.SuspendLayout();
            this.GB_Topping.SuspendLayout();
            this.GB_WhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Confirm.ForeColor = System.Drawing.Color.Green;
            this.BTN_Confirm.Location = new System.Drawing.Point(272, 616);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(158, 72);
            this.BTN_Confirm.TabIndex = 27;
            this.BTN_Confirm.Text = "Confirm";
            this.BTN_Confirm.UseVisualStyleBackColor = true;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // BTN_Rest
            // 
            this.BTN_Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Rest.ForeColor = System.Drawing.Color.Red;
            this.BTN_Rest.Location = new System.Drawing.Point(533, 616);
            this.BTN_Rest.Name = "BTN_Rest";
            this.BTN_Rest.Size = new System.Drawing.Size(147, 72);
            this.BTN_Rest.TabIndex = 28;
            this.BTN_Rest.Text = "Rest";
            this.BTN_Rest.UseVisualStyleBackColor = true;
            this.BTN_Rest.Click += new System.EventHandler(this.BTN_Rest_Click);
            // 
            // LBL_Summary_Size
            // 
            this.LBL_Summary_Size.AutoSize = true;
            this.LBL_Summary_Size.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Summary_Size.ForeColor = System.Drawing.Color.Navy;
            this.LBL_Summary_Size.Location = new System.Drawing.Point(56, 39);
            this.LBL_Summary_Size.Name = "LBL_Summary_Size";
            this.LBL_Summary_Size.Size = new System.Drawing.Size(75, 31);
            this.LBL_Summary_Size.TabIndex = 17;
            this.LBL_Summary_Size.Text = "Size :";
            // 
            // LBL_Summary_Topping
            // 
            this.LBL_Summary_Topping.AutoSize = true;
            this.LBL_Summary_Topping.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.LBL_Summary_Topping.ForeColor = System.Drawing.Color.Navy;
            this.LBL_Summary_Topping.Location = new System.Drawing.Point(56, 114);
            this.LBL_Summary_Topping.Name = "LBL_Summary_Topping";
            this.LBL_Summary_Topping.Size = new System.Drawing.Size(130, 31);
            this.LBL_Summary_Topping.TabIndex = 19;
            this.LBL_Summary_Topping.Text = "Topping :";
            // 
            // LBL_Summary_Crust
            // 
            this.LBL_Summary_Crust.AutoSize = true;
            this.LBL_Summary_Crust.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.LBL_Summary_Crust.ForeColor = System.Drawing.Color.Navy;
            this.LBL_Summary_Crust.Location = new System.Drawing.Point(56, 229);
            this.LBL_Summary_Crust.Name = "LBL_Summary_Crust";
            this.LBL_Summary_Crust.Size = new System.Drawing.Size(78, 31);
            this.LBL_Summary_Crust.TabIndex = 21;
            this.LBL_Summary_Crust.Text = "Crust";
            // 
            // LBL_Summary_Where
            // 
            this.LBL_Summary_Where.AutoSize = true;
            this.LBL_Summary_Where.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.LBL_Summary_Where.ForeColor = System.Drawing.Color.Navy;
            this.LBL_Summary_Where.Location = new System.Drawing.Point(56, 308);
            this.LBL_Summary_Where.Name = "LBL_Summary_Where";
            this.LBL_Summary_Where.Size = new System.Drawing.Size(191, 31);
            this.LBL_Summary_Where.TabIndex = 23;
            this.LBL_Summary_Where.Text = "Where To Eat :";
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.LBL_Price.ForeColor = System.Drawing.Color.Green;
            this.LBL_Price.Location = new System.Drawing.Point(791, 522);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(87, 31);
            this.LBL_Price.TabIndex = 25;
            this.LBL_Price.Text = "Price :";
            // 
            // LbL_MainTitle
            // 
            this.LbL_MainTitle.AutoSize = true;
            this.LbL_MainTitle.Font = new System.Drawing.Font("Impact", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_MainTitle.ForeColor = System.Drawing.Color.Red;
            this.LbL_MainTitle.Location = new System.Drawing.Point(321, 9);
            this.LbL_MainTitle.Name = "LbL_MainTitle";
            this.LbL_MainTitle.Size = new System.Drawing.Size(299, 75);
            this.LbL_MainTitle.TabIndex = 20;
            this.LbL_MainTitle.Text = "Order Pizza";
            // 
            // LBL_Dollar_Sign
            // 
            this.LBL_Dollar_Sign.AutoSize = true;
            this.LBL_Dollar_Sign.Font = new System.Drawing.Font("Segoe Print", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Dollar_Sign.ForeColor = System.Drawing.Color.Fuchsia;
            this.LBL_Dollar_Sign.Location = new System.Drawing.Point(759, 583);
            this.LBL_Dollar_Sign.Name = "LBL_Dollar_Sign";
            this.LBL_Dollar_Sign.Size = new System.Drawing.Size(78, 105);
            this.LBL_Dollar_Sign.TabIndex = 29;
            this.LBL_Dollar_Sign.Text = "$";
            // 
            // LBL_Value_Price
            // 
            this.LBL_Value_Price.AutoSize = true;
            this.LBL_Value_Price.Font = new System.Drawing.Font("Segoe Print", 42F, System.Drawing.FontStyle.Bold);
            this.LBL_Value_Price.Location = new System.Drawing.Point(816, 590);
            this.LBL_Value_Price.Name = "LBL_Value_Price";
            this.LBL_Value_Price.Size = new System.Drawing.Size(182, 98);
            this.LBL_Value_Price.TabIndex = 30;
            this.LBL_Value_Price.Text = "Price";
            // 
            // LBL_Value_Size
            // 
            this.LBL_Value_Size.AutoSize = true;
            this.LBL_Value_Size.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.LBL_Value_Size.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Value_Size.Location = new System.Drawing.Point(95, 86);
            this.LBL_Value_Size.Name = "LBL_Value_Size";
            this.LBL_Value_Size.Size = new System.Drawing.Size(82, 22);
            this.LBL_Value_Size.TabIndex = 18;
            this.LBL_Value_Size.Text = "label1";
            // 
            // LBL_Value_Topping
            // 
            this.LBL_Value_Topping.AutoSize = true;
            this.LBL_Value_Topping.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_Value_Topping.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Value_Topping.Location = new System.Drawing.Point(27, 163);
            this.LBL_Value_Topping.Name = "LBL_Value_Topping";
            this.LBL_Value_Topping.Size = new System.Drawing.Size(61, 16);
            this.LBL_Value_Topping.TabIndex = 20;
            this.LBL_Value_Topping.Text = "label2";
            // 
            // LBL_Value_Crust
            // 
            this.LBL_Value_Crust.AutoSize = true;
            this.LBL_Value_Crust.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.LBL_Value_Crust.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Value_Crust.Location = new System.Drawing.Point(99, 270);
            this.LBL_Value_Crust.Name = "LBL_Value_Crust";
            this.LBL_Value_Crust.Size = new System.Drawing.Size(82, 22);
            this.LBL_Value_Crust.TabIndex = 22;
            this.LBL_Value_Crust.Text = "label3";
            // 
            // LBL_Value_Where
            // 
            this.LBL_Value_Where.AutoSize = true;
            this.LBL_Value_Where.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.LBL_Value_Where.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Value_Where.Location = new System.Drawing.Point(99, 364);
            this.LBL_Value_Where.Name = "LBL_Value_Where";
            this.LBL_Value_Where.Size = new System.Drawing.Size(82, 22);
            this.LBL_Value_Where.TabIndex = 24;
            this.LBL_Value_Where.Text = "label4";
            // 
            // GB_Summary
            // 
            this.GB_Summary.Controls.Add(this.LBL_Value_Where);
            this.GB_Summary.Controls.Add(this.LBL_Summary_Size);
            this.GB_Summary.Controls.Add(this.LBL_Value_Crust);
            this.GB_Summary.Controls.Add(this.LBL_Summary_Topping);
            this.GB_Summary.Controls.Add(this.LBL_Value_Topping);
            this.GB_Summary.Controls.Add(this.LBL_Summary_Crust);
            this.GB_Summary.Controls.Add(this.LBL_Value_Size);
            this.GB_Summary.Controls.Add(this.LBL_Summary_Where);
            this.GB_Summary.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.GB_Summary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GB_Summary.Location = new System.Drawing.Point(678, 87);
            this.GB_Summary.Name = "GB_Summary";
            this.GB_Summary.Size = new System.Drawing.Size(347, 435);
            this.GB_Summary.TabIndex = 16;
            this.GB_Summary.TabStop = false;
            this.GB_Summary.Text = "Summary";
            // 
            // GB_Options
            // 
            this.GB_Options.Controls.Add(this.GB_Size);
            this.GB_Options.Controls.Add(this.GB_Crust);
            this.GB_Options.Controls.Add(this.GB_Topping);
            this.GB_Options.Controls.Add(this.GB_WhereToEat);
            this.GB_Options.Location = new System.Drawing.Point(6, 87);
            this.GB_Options.Name = "GB_Options";
            this.GB_Options.Size = new System.Drawing.Size(666, 523);
            this.GB_Options.TabIndex = 32;
            this.GB_Options.TabStop = false;
            // 
            // GB_Size
            // 
            this.GB_Size.Controls.Add(this.RB_Size_Small);
            this.GB_Size.Controls.Add(this.RB_Size_Meduim);
            this.GB_Size.Controls.Add(this.RB_Size_Large);
            this.GB_Size.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GB_Size.Location = new System.Drawing.Point(24, 38);
            this.GB_Size.Name = "GB_Size";
            this.GB_Size.Size = new System.Drawing.Size(229, 225);
            this.GB_Size.TabIndex = 31;
            this.GB_Size.TabStop = false;
            this.GB_Size.Text = "Size";
            // 
            // RB_Size_Small
            // 
            this.RB_Size_Small.AutoSize = true;
            this.RB_Size_Small.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Size_Small.ForeColor = System.Drawing.Color.Maroon;
            this.RB_Size_Small.Location = new System.Drawing.Point(92, 58);
            this.RB_Size_Small.Name = "RB_Size_Small";
            this.RB_Size_Small.Size = new System.Drawing.Size(79, 29);
            this.RB_Size_Small.TabIndex = 1;
            this.RB_Size_Small.TabStop = true;
            this.RB_Size_Small.Tag = "5";
            this.RB_Size_Small.Text = "Small";
            this.RB_Size_Small.UseVisualStyleBackColor = true;
            // 
            // RB_Size_Meduim
            // 
            this.RB_Size_Meduim.AutoSize = true;
            this.RB_Size_Meduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Size_Meduim.ForeColor = System.Drawing.Color.Maroon;
            this.RB_Size_Meduim.Location = new System.Drawing.Point(92, 117);
            this.RB_Size_Meduim.Name = "RB_Size_Meduim";
            this.RB_Size_Meduim.Size = new System.Drawing.Size(100, 29);
            this.RB_Size_Meduim.TabIndex = 2;
            this.RB_Size_Meduim.TabStop = true;
            this.RB_Size_Meduim.Tag = "10";
            this.RB_Size_Meduim.Text = "Medium";
            this.RB_Size_Meduim.UseVisualStyleBackColor = true;
            // 
            // RB_Size_Large
            // 
            this.RB_Size_Large.AutoSize = true;
            this.RB_Size_Large.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Size_Large.ForeColor = System.Drawing.Color.Maroon;
            this.RB_Size_Large.Location = new System.Drawing.Point(92, 178);
            this.RB_Size_Large.Name = "RB_Size_Large";
            this.RB_Size_Large.Size = new System.Drawing.Size(80, 29);
            this.RB_Size_Large.TabIndex = 3;
            this.RB_Size_Large.TabStop = true;
            this.RB_Size_Large.Tag = "20";
            this.RB_Size_Large.Text = "Large";
            this.RB_Size_Large.UseVisualStyleBackColor = true;
            // 
            // GB_Crust
            // 
            this.GB_Crust.Controls.Add(this.RB_Crust_Thick);
            this.GB_Crust.Controls.Add(this.RB_Crust_Thin);
            this.GB_Crust.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.GB_Crust.ForeColor = System.Drawing.Color.Red;
            this.GB_Crust.Location = new System.Drawing.Point(24, 323);
            this.GB_Crust.Name = "GB_Crust";
            this.GB_Crust.Size = new System.Drawing.Size(229, 143);
            this.GB_Crust.TabIndex = 32;
            this.GB_Crust.TabStop = false;
            this.GB_Crust.Text = "Crust";
            // 
            // RB_Crust_Thick
            // 
            this.RB_Crust_Thick.AutoSize = true;
            this.RB_Crust_Thick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Crust_Thick.ForeColor = System.Drawing.Color.Teal;
            this.RB_Crust_Thick.Location = new System.Drawing.Point(74, 110);
            this.RB_Crust_Thick.Name = "RB_Crust_Thick";
            this.RB_Crust_Thick.Size = new System.Drawing.Size(86, 30);
            this.RB_Crust_Thick.TabIndex = 8;
            this.RB_Crust_Thick.TabStop = true;
            this.RB_Crust_Thick.Tag = "5";
            this.RB_Crust_Thick.Text = "Thick";
            this.RB_Crust_Thick.UseVisualStyleBackColor = true;
            // 
            // RB_Crust_Thin
            // 
            this.RB_Crust_Thin.AutoSize = true;
            this.RB_Crust_Thin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Crust_Thin.ForeColor = System.Drawing.Color.Teal;
            this.RB_Crust_Thin.Location = new System.Drawing.Point(74, 46);
            this.RB_Crust_Thin.Name = "RB_Crust_Thin";
            this.RB_Crust_Thin.Size = new System.Drawing.Size(75, 30);
            this.RB_Crust_Thin.TabIndex = 7;
            this.RB_Crust_Thin.TabStop = true;
            this.RB_Crust_Thin.Tag = "0";
            this.RB_Crust_Thin.Text = "Thin";
            this.RB_Crust_Thin.UseVisualStyleBackColor = true;
            // 
            // GB_Topping
            // 
            this.GB_Topping.Controls.Add(this.CHK_GreenPeppers);
            this.GB_Topping.Controls.Add(this.CHK_Olives);
            this.GB_Topping.Controls.Add(this.CHK_Onion);
            this.GB_Topping.Controls.Add(this.CHK_Tomatoes);
            this.GB_Topping.Controls.Add(this.CHK_Mushrooms);
            this.GB_Topping.Controls.Add(this.CHK_ExtraCheese);
            this.GB_Topping.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.GB_Topping.ForeColor = System.Drawing.Color.Green;
            this.GB_Topping.Location = new System.Drawing.Point(322, 38);
            this.GB_Topping.Name = "GB_Topping";
            this.GB_Topping.Size = new System.Drawing.Size(321, 225);
            this.GB_Topping.TabIndex = 33;
            this.GB_Topping.TabStop = false;
            this.GB_Topping.Text = "Topping";
            // 
            // CHK_GreenPeppers
            // 
            this.CHK_GreenPeppers.AutoSize = true;
            this.CHK_GreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CHK_GreenPeppers.ForeColor = System.Drawing.Color.Purple;
            this.CHK_GreenPeppers.Location = new System.Drawing.Point(172, 142);
            this.CHK_GreenPeppers.Name = "CHK_GreenPeppers";
            this.CHK_GreenPeppers.Size = new System.Drawing.Size(149, 24);
            this.CHK_GreenPeppers.TabIndex = 19;
            this.CHK_GreenPeppers.Tag = "1";
            this.CHK_GreenPeppers.Text = "Green Peppers";
            this.CHK_GreenPeppers.UseVisualStyleBackColor = true;
            // 
            // CHK_Olives
            // 
            this.CHK_Olives.AutoSize = true;
            this.CHK_Olives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CHK_Olives.ForeColor = System.Drawing.Color.Purple;
            this.CHK_Olives.Location = new System.Drawing.Point(172, 97);
            this.CHK_Olives.Name = "CHK_Olives";
            this.CHK_Olives.Size = new System.Drawing.Size(76, 24);
            this.CHK_Olives.TabIndex = 18;
            this.CHK_Olives.Tag = "2";
            this.CHK_Olives.Text = "Olives";
            this.CHK_Olives.UseVisualStyleBackColor = true;
            // 
            // CHK_Onion
            // 
            this.CHK_Onion.AutoSize = true;
            this.CHK_Onion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CHK_Onion.ForeColor = System.Drawing.Color.Purple;
            this.CHK_Onion.Location = new System.Drawing.Point(172, 59);
            this.CHK_Onion.Name = "CHK_Onion";
            this.CHK_Onion.Size = new System.Drawing.Size(75, 24);
            this.CHK_Onion.TabIndex = 17;
            this.CHK_Onion.Tag = "3";
            this.CHK_Onion.Text = "Onion";
            this.CHK_Onion.UseVisualStyleBackColor = true;
            // 
            // CHK_Tomatoes
            // 
            this.CHK_Tomatoes.AutoSize = true;
            this.CHK_Tomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CHK_Tomatoes.ForeColor = System.Drawing.Color.Purple;
            this.CHK_Tomatoes.Location = new System.Drawing.Point(21, 141);
            this.CHK_Tomatoes.Name = "CHK_Tomatoes";
            this.CHK_Tomatoes.Size = new System.Drawing.Size(107, 24);
            this.CHK_Tomatoes.TabIndex = 16;
            this.CHK_Tomatoes.Tag = "1";
            this.CHK_Tomatoes.Text = "Tomatoes";
            this.CHK_Tomatoes.UseVisualStyleBackColor = true;
            // 
            // CHK_Mushrooms
            // 
            this.CHK_Mushrooms.AutoSize = true;
            this.CHK_Mushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CHK_Mushrooms.ForeColor = System.Drawing.Color.Purple;
            this.CHK_Mushrooms.Location = new System.Drawing.Point(21, 97);
            this.CHK_Mushrooms.Name = "CHK_Mushrooms";
            this.CHK_Mushrooms.Size = new System.Drawing.Size(120, 24);
            this.CHK_Mushrooms.TabIndex = 15;
            this.CHK_Mushrooms.Tag = "2";
            this.CHK_Mushrooms.Text = "Mushrooms";
            this.CHK_Mushrooms.UseVisualStyleBackColor = true;
            // 
            // CHK_ExtraCheese
            // 
            this.CHK_ExtraCheese.AutoSize = true;
            this.CHK_ExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_ExtraCheese.ForeColor = System.Drawing.Color.Purple;
            this.CHK_ExtraCheese.Location = new System.Drawing.Point(21, 58);
            this.CHK_ExtraCheese.Name = "CHK_ExtraCheese";
            this.CHK_ExtraCheese.Size = new System.Drawing.Size(136, 24);
            this.CHK_ExtraCheese.TabIndex = 14;
            this.CHK_ExtraCheese.Tag = "1";
            this.CHK_ExtraCheese.Text = "Extra Cheese";
            this.CHK_ExtraCheese.UseVisualStyleBackColor = true;
            // 
            // GB_WhereToEat
            // 
            this.GB_WhereToEat.Controls.Add(this.RB_TakeAway);
            this.GB_WhereToEat.Controls.Add(this.RB_EatIn);
            this.GB_WhereToEat.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.GB_WhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GB_WhereToEat.Location = new System.Drawing.Point(322, 323);
            this.GB_WhereToEat.Name = "GB_WhereToEat";
            this.GB_WhereToEat.Size = new System.Drawing.Size(321, 159);
            this.GB_WhereToEat.TabIndex = 34;
            this.GB_WhereToEat.TabStop = false;
            this.GB_WhereToEat.Text = "Where To Eat?";
            // 
            // RB_TakeAway
            // 
            this.RB_TakeAway.AutoSize = true;
            this.RB_TakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_TakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RB_TakeAway.Location = new System.Drawing.Point(150, 63);
            this.RB_TakeAway.Name = "RB_TakeAway";
            this.RB_TakeAway.Size = new System.Drawing.Size(146, 30);
            this.RB_TakeAway.TabIndex = 17;
            this.RB_TakeAway.TabStop = true;
            this.RB_TakeAway.Text = "Take Away";
            this.RB_TakeAway.UseVisualStyleBackColor = true;
            // 
            // RB_EatIn
            // 
            this.RB_EatIn.AutoSize = true;
            this.RB_EatIn.BackColor = System.Drawing.Color.SeaShell;
            this.RB_EatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_EatIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RB_EatIn.Location = new System.Drawing.Point(24, 63);
            this.RB_EatIn.Name = "RB_EatIn";
            this.RB_EatIn.Size = new System.Drawing.Size(97, 33);
            this.RB_EatIn.TabIndex = 16;
            this.RB_EatIn.TabStop = true;
            this.RB_EatIn.Text = "Eat In";
            this.RB_EatIn.UseVisualStyleBackColor = false;
            // 
            // FRM_OrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 717);
            this.Controls.Add(this.LBL_Value_Price);
            this.Controls.Add(this.LBL_Dollar_Sign);
            this.Controls.Add(this.LbL_MainTitle);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.BTN_Rest);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.GB_Summary);
            this.Controls.Add(this.GB_Options);
            this.Name = "FRM_OrderPizza";
            this.Text = "Order Your Pizza";
            this.GB_Summary.ResumeLayout(false);
            this.GB_Summary.PerformLayout();
            this.GB_Options.ResumeLayout(false);
            this.GB_Size.ResumeLayout(false);
            this.GB_Size.PerformLayout();
            this.GB_Crust.ResumeLayout(false);
            this.GB_Crust.PerformLayout();
            this.GB_Topping.ResumeLayout(false);
            this.GB_Topping.PerformLayout();
            this.GB_WhereToEat.ResumeLayout(false);
            this.GB_WhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Button BTN_Rest;
        private System.Windows.Forms.Label LBL_Summary_Size;
        private System.Windows.Forms.Label LBL_Summary_Topping;
        private System.Windows.Forms.Label LBL_Summary_Crust;
        private System.Windows.Forms.Label LBL_Summary_Where;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.Label LbL_MainTitle;
        private System.Windows.Forms.Label LBL_Dollar_Sign;
        private System.Windows.Forms.Label LBL_Value_Price;
        private System.Windows.Forms.Label LBL_Value_Size;
        private System.Windows.Forms.Label LBL_Value_Topping;
        private System.Windows.Forms.Label LBL_Value_Crust;
        private System.Windows.Forms.Label LBL_Value_Where;
        private System.Windows.Forms.GroupBox GB_Summary;
        private System.Windows.Forms.GroupBox GB_Options;
        private System.Windows.Forms.GroupBox GB_Size;
        private System.Windows.Forms.RadioButton RB_Size_Small;
        private System.Windows.Forms.RadioButton RB_Size_Meduim;
        private System.Windows.Forms.RadioButton RB_Size_Large;
        private System.Windows.Forms.GroupBox GB_Crust;
        private System.Windows.Forms.RadioButton RB_Crust_Thick;
        private System.Windows.Forms.RadioButton RB_Crust_Thin;
        private System.Windows.Forms.GroupBox GB_Topping;
        private System.Windows.Forms.CheckBox CHK_GreenPeppers;
        private System.Windows.Forms.CheckBox CHK_Olives;
        private System.Windows.Forms.CheckBox CHK_Onion;
        private System.Windows.Forms.CheckBox CHK_Tomatoes;
        private System.Windows.Forms.CheckBox CHK_Mushrooms;
        private System.Windows.Forms.CheckBox CHK_ExtraCheese;
        private System.Windows.Forms.GroupBox GB_WhereToEat;
        private System.Windows.Forms.RadioButton RB_TakeAway;
        private System.Windows.Forms.RadioButton RB_EatIn;
    }
}

