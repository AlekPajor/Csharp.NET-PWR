namespace WinFormsApp1
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
            label1 = new Label();
            txtbNumberOfItems = new TextBox();
            txtbSeed = new TextBox();
            label2 = new Label();
            txtbCapacity = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            txtbInstance = new TextBox();
            txtbResults = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Number of Items";
            // 
            // txtbNumberOfItems
            // 
            txtbNumberOfItems.BorderStyle = BorderStyle.FixedSingle;
            txtbNumberOfItems.Location = new Point(12, 37);
            txtbNumberOfItems.Name = "txtbNumberOfItems";
            txtbNumberOfItems.Size = new Size(150, 31);
            txtbNumberOfItems.TabIndex = 1;
            txtbNumberOfItems.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbSeed
            // 
            txtbSeed.BorderStyle = BorderStyle.FixedSingle;
            txtbSeed.Location = new Point(12, 99);
            txtbSeed.Name = "txtbSeed";
            txtbSeed.Size = new Size(150, 31);
            txtbSeed.TabIndex = 3;
            txtbSeed.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "Seed";
            // 
            // txtbCapacity
            // 
            txtbCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtbCapacity.Location = new Point(12, 161);
            txtbCapacity.Name = "txtbCapacity";
            txtbCapacity.Size = new Size(150, 31);
            txtbCapacity.TabIndex = 5;
            txtbCapacity.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 4;
            label3.Text = "Capacity";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 243);
            button1.Name = "button1";
            button1.Size = new Size(184, 90);
            button1.TabIndex = 7;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 37);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 9;
            label4.Text = "Instance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 371);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 10;
            label5.Text = "Result";
            // 
            // txtbInstance
            // 
            txtbInstance.BackColor = SystemColors.Window;
            txtbInstance.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtbInstance.Location = new Point(307, 65);
            txtbInstance.Multiline = true;
            txtbInstance.Name = "txtbInstance";
            txtbInstance.ReadOnly = true;
            txtbInstance.Size = new Size(332, 582);
            txtbInstance.TabIndex = 11;
            // 
            // txtbResults
            // 
            txtbResults.BackColor = SystemColors.Window;
            txtbResults.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtbResults.Location = new Point(12, 399);
            txtbResults.Multiline = true;
            txtbResults.Name = "txtbResults";
            txtbResults.ReadOnly = true;
            txtbResults.Size = new Size(266, 248);
            txtbResults.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 659);
            Controls.Add(txtbResults);
            Controls.Add(txtbInstance);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtbCapacity);
            Controls.Add(label3);
            Controls.Add(txtbSeed);
            Controls.Add(label2);
            Controls.Add(txtbNumberOfItems);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "BackpackProblem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbNumberOfItems;
        private TextBox txtbSeed;
        private Label label2;
        private TextBox txtbCapacity;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox txtbInstance;
        private TextBox txtbResults;
    }
}
