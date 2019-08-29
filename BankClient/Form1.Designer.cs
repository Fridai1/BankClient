namespace BankClient
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.FundsLabel = new System.Windows.Forms.Label();
            this.FundsValue = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(884, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 936);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 31);
            this.textBox1.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(87, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // FundsLabel
            // 
            this.FundsLabel.AutoSize = true;
            this.FundsLabel.Location = new System.Drawing.Point(87, 105);
            this.FundsLabel.Name = "FundsLabel";
            this.FundsLabel.Size = new System.Drawing.Size(72, 25);
            this.FundsLabel.TabIndex = 5;
            this.FundsLabel.Text = "Funds";
            // 
            // FundsValue
            // 
            this.FundsValue.AutoSize = true;
            this.FundsValue.Location = new System.Drawing.Point(253, 105);
            this.FundsValue.Name = "FundsValue";
            this.FundsValue.Size = new System.Drawing.Size(47, 25);
            this.FundsValue.TabIndex = 6;
            this.FundsValue.Text = "N/A";
            // 
            // NameValue
            // 
            this.NameValue.AutoSize = true;
            this.NameValue.Location = new System.Drawing.Point(253, 51);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(47, 25);
            this.NameValue.TabIndex = 7;
            this.NameValue.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 997);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.FundsValue);
            this.Controls.Add(this.FundsLabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label FundsLabel;
        private System.Windows.Forms.Label FundsValue;
        private System.Windows.Forms.Label NameValue;
    }
}

