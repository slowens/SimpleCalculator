namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonTen = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFourteen = new System.Windows.Forms.Button();
            this.ButtonThirtin = new System.Windows.Forms.Button();
            this.ButtonTwelve = new System.Windows.Forms.Button();
            this.ButtonEleven = new System.Windows.Forms.Button();
            this.ButtonTwenty = new System.Windows.Forms.Button();
            this.ButtonNighteen = new System.Windows.Forms.Button();
            this.ButtonEighteen = new System.Windows.Forms.Button();
            this.ButtonSixteen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PoleOperacji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonOne.Location = new System.Drawing.Point(18, 116);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(55, 55);
            this.ButtonOne.TabIndex = 0;
            this.ButtonOne.Text = "7";
            this.ButtonOne.UseVisualStyleBackColor = false;
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTwo.Location = new System.Drawing.Point(79, 116);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(55, 55);
            this.ButtonTwo.TabIndex = 1;
            this.ButtonTwo.Text = "8";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonThree.Location = new System.Drawing.Point(140, 116);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(55, 55);
            this.ButtonThree.TabIndex = 2;
            this.ButtonThree.Text = "9";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFour.Location = new System.Drawing.Point(201, 116);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(55, 55);
            this.ButtonFour.TabIndex = 3;
            this.ButtonFour.Text = "/";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.KlawiszOperacji);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFive.Location = new System.Drawing.Point(262, 116);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(55, 55);
            this.ButtonFive.TabIndex = 4;
            this.ButtonFive.Text = "CE";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonTen
            // 
            this.ButtonTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTen.Location = new System.Drawing.Point(262, 177);
            this.ButtonTen.Name = "ButtonTen";
            this.ButtonTen.Size = new System.Drawing.Size(55, 55);
            this.ButtonTen.TabIndex = 9;
            this.ButtonTen.Text = "C";
            this.ButtonTen.UseVisualStyleBackColor = false;
            this.ButtonTen.Click += new System.EventHandler(this.ButtonTen_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonNine.Location = new System.Drawing.Point(201, 177);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(55, 55);
            this.ButtonNine.TabIndex = 8;
            this.ButtonNine.Text = "*";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.KlawiszOperacji);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEight.Location = new System.Drawing.Point(140, 177);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(55, 55);
            this.ButtonEight.TabIndex = 7;
            this.ButtonEight.Text = "6";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSeven.Location = new System.Drawing.Point(79, 177);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(55, 55);
            this.ButtonSeven.TabIndex = 6;
            this.ButtonSeven.Text = "5";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSix.Location = new System.Drawing.Point(18, 177);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(55, 55);
            this.ButtonSix.TabIndex = 5;
            this.ButtonSix.Text = "4";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonFourteen
            // 
            this.ButtonFourteen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFourteen.Location = new System.Drawing.Point(201, 238);
            this.ButtonFourteen.Name = "ButtonFourteen";
            this.ButtonFourteen.Size = new System.Drawing.Size(55, 55);
            this.ButtonFourteen.TabIndex = 13;
            this.ButtonFourteen.Text = "-";
            this.ButtonFourteen.UseVisualStyleBackColor = false;
            this.ButtonFourteen.Click += new System.EventHandler(this.KlawiszOperacji);
            // 
            // ButtonThirtin
            // 
            this.ButtonThirtin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonThirtin.Location = new System.Drawing.Point(140, 238);
            this.ButtonThirtin.Name = "ButtonThirtin";
            this.ButtonThirtin.Size = new System.Drawing.Size(55, 55);
            this.ButtonThirtin.TabIndex = 12;
            this.ButtonThirtin.Text = "3";
            this.ButtonThirtin.UseVisualStyleBackColor = false;
            this.ButtonThirtin.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonTwelve
            // 
            this.ButtonTwelve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTwelve.Location = new System.Drawing.Point(79, 238);
            this.ButtonTwelve.Name = "ButtonTwelve";
            this.ButtonTwelve.Size = new System.Drawing.Size(55, 55);
            this.ButtonTwelve.TabIndex = 11;
            this.ButtonTwelve.Text = "2";
            this.ButtonTwelve.UseVisualStyleBackColor = false;
            // 
            // ButtonEleven
            // 
            this.ButtonEleven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEleven.Location = new System.Drawing.Point(18, 238);
            this.ButtonEleven.Name = "ButtonEleven";
            this.ButtonEleven.Size = new System.Drawing.Size(55, 55);
            this.ButtonEleven.TabIndex = 10;
            this.ButtonEleven.Text = "1";
            this.ButtonEleven.UseVisualStyleBackColor = false;
            this.ButtonEleven.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonTwenty
            // 
            this.ButtonTwenty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTwenty.Location = new System.Drawing.Point(262, 238);
            this.ButtonTwenty.Name = "ButtonTwenty";
            this.ButtonTwenty.Size = new System.Drawing.Size(55, 116);
            this.ButtonTwenty.TabIndex = 19;
            this.ButtonTwenty.Text = "=";
            this.ButtonTwenty.UseVisualStyleBackColor = false;
            this.ButtonTwenty.Click += new System.EventHandler(this.KlawiszWyniku);
            // 
            // ButtonNighteen
            // 
            this.ButtonNighteen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonNighteen.Location = new System.Drawing.Point(201, 299);
            this.ButtonNighteen.Name = "ButtonNighteen";
            this.ButtonNighteen.Size = new System.Drawing.Size(55, 55);
            this.ButtonNighteen.TabIndex = 18;
            this.ButtonNighteen.Text = "+";
            this.ButtonNighteen.UseVisualStyleBackColor = false;
            this.ButtonNighteen.Click += new System.EventHandler(this.KlawiszOperacji);
            // 
            // ButtonEighteen
            // 
            this.ButtonEighteen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEighteen.Location = new System.Drawing.Point(140, 299);
            this.ButtonEighteen.Name = "ButtonEighteen";
            this.ButtonEighteen.Size = new System.Drawing.Size(55, 55);
            this.ButtonEighteen.TabIndex = 17;
            this.ButtonEighteen.Text = ",";
            this.ButtonEighteen.UseVisualStyleBackColor = false;
            this.ButtonEighteen.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonSixteen
            // 
            this.ButtonSixteen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSixteen.Location = new System.Drawing.Point(18, 299);
            this.ButtonSixteen.Name = "ButtonSixteen";
            this.ButtonSixteen.Size = new System.Drawing.Size(116, 55);
            this.ButtonSixteen.TabIndex = 15;
            this.ButtonSixteen.Text = "0";
            this.ButtonSixteen.UseVisualStyleBackColor = false;
            this.ButtonSixteen.Click += new System.EventHandler(this.ButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(19, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 61);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(18, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(79, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(79, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(79, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 11;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // PoleOperacji
            // 
            this.PoleOperacji.AutoSize = true;
            this.PoleOperacji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PoleOperacji.Location = new System.Drawing.Point(25, 9);
            this.PoleOperacji.Name = "PoleOperacji";
            this.PoleOperacji.Size = new System.Drawing.Size(0, 32);
            this.PoleOperacji.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(330, 369);
            this.Controls.Add(this.PoleOperacji);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonTwenty);
            this.Controls.Add(this.ButtonNighteen);
            this.Controls.Add(this.ButtonEighteen);
            this.Controls.Add(this.ButtonSixteen);
            this.Controls.Add(this.ButtonFourteen);
            this.Controls.Add(this.ButtonThirtin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ButtonTwelve);
            this.Controls.Add(this.ButtonEleven);
            this.Controls.Add(this.ButtonTen);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonTen;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFourteen;
        private System.Windows.Forms.Button ButtonThirtin;
        private System.Windows.Forms.Button ButtonTwelve;
        private System.Windows.Forms.Button ButtonEleven;
        private System.Windows.Forms.Button ButtonTwenty;
        private System.Windows.Forms.Button ButtonNighteen;
        private System.Windows.Forms.Button ButtonEighteen;
        private System.Windows.Forms.Button ButtonSixteen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label PoleOperacji;
    }
}

