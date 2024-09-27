namespace Cash_Register
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoLabel = new System.Windows.Forms.Label();
            this.donutsInput = new System.Windows.Forms.TextBox();
            this.donutsLabel = new System.Windows.Forms.Label();
            this.cookiesInput = new System.Windows.Forms.TextBox();
            this.cookiesLabel = new System.Windows.Forms.Label();
            this.cakesLabel = new System.Windows.Forms.Label();
            this.cakesInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.recieptOutput = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.secretButton = new System.Windows.Forms.Button();
            this.achievementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.logoLabel.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.logoLabel.Location = new System.Drawing.Point(-2, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(803, 45);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Creamer\'s Pastries";
            this.logoLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.logoLabel_MouseDoubleClick);
            // 
            // donutsInput
            // 
            this.donutsInput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donutsInput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.donutsInput.Location = new System.Drawing.Point(158, 76);
            this.donutsInput.Name = "donutsInput";
            this.donutsInput.Size = new System.Drawing.Size(100, 28);
            this.donutsInput.TabIndex = 1;
            // 
            // donutsLabel
            // 
            this.donutsLabel.AutoSize = true;
            this.donutsLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donutsLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.donutsLabel.Location = new System.Drawing.Point(34, 79);
            this.donutsLabel.Name = "donutsLabel";
            this.donutsLabel.Size = new System.Drawing.Size(121, 17);
            this.donutsLabel.TabIndex = 2;
            this.donutsLabel.Text = "Number of Donuts";
            // 
            // cookiesInput
            // 
            this.cookiesInput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookiesInput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cookiesInput.Location = new System.Drawing.Point(158, 107);
            this.cookiesInput.Name = "cookiesInput";
            this.cookiesInput.Size = new System.Drawing.Size(100, 28);
            this.cookiesInput.TabIndex = 3;
            // 
            // cookiesLabel
            // 
            this.cookiesLabel.AutoSize = true;
            this.cookiesLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookiesLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cookiesLabel.Location = new System.Drawing.Point(34, 110);
            this.cookiesLabel.Name = "cookiesLabel";
            this.cookiesLabel.Size = new System.Drawing.Size(121, 17);
            this.cookiesLabel.TabIndex = 4;
            this.cookiesLabel.Text = "Number of Cookies";
            // 
            // cakesLabel
            // 
            this.cakesLabel.AutoSize = true;
            this.cakesLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakesLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cakesLabel.Location = new System.Drawing.Point(34, 141);
            this.cakesLabel.Name = "cakesLabel";
            this.cakesLabel.Size = new System.Drawing.Size(110, 17);
            this.cakesLabel.TabIndex = 5;
            this.cakesLabel.Text = "Number of Cakes";
            // 
            // cakesInput
            // 
            this.cakesInput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakesInput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cakesInput.Location = new System.Drawing.Point(158, 138);
            this.cakesInput.Name = "cakesInput";
            this.cakesInput.Size = new System.Drawing.Size(100, 28);
            this.cakesInput.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.calcButton.Location = new System.Drawing.Point(56, 168);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(161, 34);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate Totals";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.subtotalLabel.Location = new System.Drawing.Point(34, 222);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(60, 17);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.taxLabel.Location = new System.Drawing.Point(36, 253);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 17);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            this.taxLabel.Visible = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.totalLabel.Location = new System.Drawing.Point(36, 284);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(39, 17);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            this.totalLabel.Visible = false;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.subtotalOutput.Location = new System.Drawing.Point(129, 222);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(14, 17);
            this.subtotalOutput.TabIndex = 12;
            this.subtotalOutput.Text = " ";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.taxOutput.Location = new System.Drawing.Point(129, 253);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(14, 17);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.Text = " ";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.totalOutput.Location = new System.Drawing.Point(129, 284);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(14, 17);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.Text = " ";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tenderedLabel.Location = new System.Drawing.Point(36, 315);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(61, 17);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.Visible = false;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tenderedInput.Location = new System.Drawing.Point(110, 312);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 28);
            this.tenderedInput.TabIndex = 16;
            this.tenderedInput.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.changeButton.Location = new System.Drawing.Point(56, 347);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(122, 37);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.changeLabel.Location = new System.Drawing.Point(53, 396);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(48, 17);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            this.changeLabel.Visible = false;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.changeOutput.Location = new System.Drawing.Point(130, 396);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(14, 17);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.Text = " ";
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.receiptButton.Location = new System.Drawing.Point(37, 424);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(137, 34);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // recieptOutput
            // 
            this.recieptOutput.AutoSize = true;
            this.recieptOutput.BackColor = System.Drawing.Color.White;
            this.recieptOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recieptOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptOutput.ForeColor = System.Drawing.Color.Black;
            this.recieptOutput.Location = new System.Drawing.Point(332, 60);
            this.recieptOutput.Name = "recieptOutput";
            this.recieptOutput.Size = new System.Drawing.Size(2, 15);
            this.recieptOutput.TabIndex = 22;
            this.recieptOutput.Visible = false;
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.orderButton.Location = new System.Drawing.Point(359, 414);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(155, 35);
            this.orderButton.TabIndex = 23;
            this.orderButton.Text = "New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // secretButton
            // 
            this.secretButton.BackColor = System.Drawing.Color.PaleGreen;
            this.secretButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secretButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.secretButton.Location = new System.Drawing.Point(346, 403);
            this.secretButton.Name = "secretButton";
            this.secretButton.Size = new System.Drawing.Size(184, 55);
            this.secretButton.TabIndex = 24;
            this.secretButton.UseVisualStyleBackColor = false;
            this.secretButton.Visible = false;
            this.secretButton.Click += new System.EventHandler(this.secretButton_Click);
            // 
            // achievementLabel
            // 
            this.achievementLabel.AutoSize = true;
            this.achievementLabel.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievementLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.achievementLabel.Location = new System.Drawing.Point(430, 9);
            this.achievementLabel.Name = "achievementLabel";
            this.achievementLabel.Size = new System.Drawing.Size(75, 16);
            this.achievementLabel.TabIndex = 25;
            this.achievementLabel.Text = "Achievements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(643, 470);
            this.Controls.Add(this.achievementLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.recieptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.cakesInput);
            this.Controls.Add(this.cakesLabel);
            this.Controls.Add(this.cookiesLabel);
            this.Controls.Add(this.cookiesInput);
            this.Controls.Add(this.donutsLabel);
            this.Controls.Add(this.donutsInput);
            this.Controls.Add(this.secretButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Creamer\'s Pastries";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox donutsInput;
        private System.Windows.Forms.Label donutsLabel;
        private System.Windows.Forms.TextBox cookiesInput;
        private System.Windows.Forms.Label cookiesLabel;
        private System.Windows.Forms.Label cakesLabel;
        private System.Windows.Forms.TextBox cakesInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label recieptOutput;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button secretButton;
        private System.Windows.Forms.Label achievementLabel;
    }
}

