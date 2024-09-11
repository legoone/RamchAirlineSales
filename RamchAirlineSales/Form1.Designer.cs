namespace RamchAirlineSales
{
    partial class Form1
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
            lblTitle = new Label();
            lblAirName = new Label();
            lblPrice = new Label();
            txtCusName = new TextBox();
            textBox2 = new TextBox();
            lstOut = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(374, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(357, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Airline Ticket Payment";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAirName
            // 
            lblAirName.AutoSize = true;
            lblAirName.Location = new Point(64, 254);
            lblAirName.Name = "lblAirName";
            lblAirName.Size = new Size(263, 32);
            lblAirName.TabIndex = 1;
            lblAirName.Text = "Airline Customer Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(154, 349);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(135, 32);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Ticket Price";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(364, 254);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(392, 39);
            txtCusName.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 39);
            textBox2.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(216, 441);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(613, 196);
            lstOut.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(53, 693);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(182, 118);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate Total Ticket Price";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(414, 692);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 120);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(743, 692);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(171, 120);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 822);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOut);
            Controls.Add(textBox2);
            Controls.Add(txtCusName);
            Controls.Add(lblPrice);
            Controls.Add(lblAirName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Tyler Ramcharan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAirName;
        private Label lblPrice;
        private TextBox txtCusName;
        private TextBox textBox2;
        private ListBox lstOut;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
    }
}
