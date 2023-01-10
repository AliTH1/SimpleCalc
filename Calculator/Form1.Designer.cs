namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_number_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_number_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_addition = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Enter a number";
            // 
            // txtbox_number_1
            // 
            this.txtbox_number_1.Location = new System.Drawing.Point(232, 53);
            this.txtbox_number_1.Name = "txtbox_number_1";
            this.txtbox_number_1.Size = new System.Drawing.Size(198, 31);
            this.txtbox_number_1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Enter a number";
            // 
            // txtbox_number_2
            // 
            this.txtbox_number_2.Location = new System.Drawing.Point(232, 118);
            this.txtbox_number_2.Name = "txtbox_number_2";
            this.txtbox_number_2.Size = new System.Drawing.Size(198, 31);
            this.txtbox_number_2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(124, 177);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(28, 32);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "0";
            // 
            // btn_addition
            // 
            this.btn_addition.Location = new System.Drawing.Point(232, 175);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(45, 34);
            this.btn_addition.TabIndex = 3;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 255);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_number_2);
            this.Controls.Add(this.txtbox_number_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtbox_number_1;
        private Label label2;
        private TextBox txtbox_number_2;
        private Label label3;
        private Label lbl_result;
        private Button btn_addition;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}