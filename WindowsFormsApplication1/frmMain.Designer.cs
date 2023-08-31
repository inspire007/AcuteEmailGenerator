namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.countryListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.keywordsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailProviderBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dots = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // countryListBox
            // 
            this.countryListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryListBox.FormattingEnabled = true;
            this.countryListBox.Location = new System.Drawing.Point(134, 85);
            this.countryListBox.Name = "countryListBox";
            this.countryListBox.Size = new System.Drawing.Size(207, 21);
            this.countryListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acute Email Address Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Email Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keywordsBox
            // 
            this.keywordsBox.Location = new System.Drawing.Point(134, 150);
            this.keywordsBox.Name = "keywordsBox";
            this.keywordsBox.Size = new System.Drawing.Size(207, 21);
            this.keywordsBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keywords";
            // 
            // emailProviderBox
            // 
            this.emailProviderBox.Location = new System.Drawing.Point(134, 214);
            this.emailProviderBox.Name = "emailProviderBox";
            this.emailProviderBox.Size = new System.Drawing.Size(207, 21);
            this.emailProviderBox.TabIndex = 6;
            this.emailProviderBox.Text = "gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email Provider";
            // 
            // dots
            // 
            this.dots.AutoSize = true;
            this.dots.Location = new System.Drawing.Point(137, 255);
            this.dots.Name = "dots";
            this.dots.Size = new System.Drawing.Size(191, 17);
            this.dots.TabIndex = 8;
            this.dots.Text = "Add dots or underscores randomly";
            this.dots.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(137, 287);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(204, 17);
            this.numbers.TabIndex = 9;
            this.numbers.Text = "Add numbers after address randomly";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 399);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.dots);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailProviderBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keywordsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryListBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Acute Email Address Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox keywordsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailProviderBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dots;
        private System.Windows.Forms.CheckBox numbers;
    }
}

