namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    partial class AddLoanForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CapitalInput = new System.Windows.Forms.TextBox();
            this.InterestInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoOfPaymentInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentTermInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OtherFeesInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(131, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 28);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital";
            // 
            // CapitalInput
            // 
            this.CapitalInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalInput.Location = new System.Drawing.Point(15, 26);
            this.CapitalInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.CapitalInput.Name = "CapitalInput";
            this.CapitalInput.Size = new System.Drawing.Size(306, 27);
            this.CapitalInput.TabIndex = 2;
            // 
            // InterestInput
            // 
            this.InterestInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestInput.Location = new System.Drawing.Point(15, 81);
            this.InterestInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.InterestInput.Name = "InterestInput";
            this.InterestInput.Size = new System.Drawing.Size(306, 27);
            this.InterestInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interest";
            // 
            // NoOfPaymentInput
            // 
            this.NoOfPaymentInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfPaymentInput.Location = new System.Drawing.Point(15, 191);
            this.NoOfPaymentInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.NoOfPaymentInput.Name = "NoOfPaymentInput";
            this.NoOfPaymentInput.Size = new System.Drawing.Size(306, 27);
            this.NoOfPaymentInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Term";
            // 
            // PaymentTermInput
            // 
            this.PaymentTermInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTermInput.FormattingEnabled = true;
            this.PaymentTermInput.Location = new System.Drawing.Point(15, 136);
            this.PaymentTermInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.PaymentTermInput.Name = "PaymentTermInput";
            this.PaymentTermInput.Size = new System.Drawing.Size(306, 27);
            this.PaymentTermInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. of Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Other Fees";
            // 
            // OtherFeesInput
            // 
            this.OtherFeesInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherFeesInput.Location = new System.Drawing.Point(15, 246);
            this.OtherFeesInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.OtherFeesInput.Name = "OtherFeesInput";
            this.OtherFeesInput.Size = new System.Drawing.Size(306, 27);
            this.OtherFeesInput.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.ReceiptLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(340, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(318, 332);
            this.panel1.TabIndex = 11;
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptLabel.Location = new System.Drawing.Point(8, 53);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Padding = new System.Windows.Forms.Padding(24);
            this.ReceiptLabel.Size = new System.Drawing.Size(302, 271);
            this.ReceiptLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "------------------------------------\r\nLoan\r\n------------------------------------";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OtherFeesInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentTermInput);
            this.Controls.Add(this.NoOfPaymentInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InterestInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CapitalInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLoanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Loan";
            this.Load += new System.EventHandler(this.AddLoanForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapitalInput;
        private System.Windows.Forms.TextBox InterestInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoOfPaymentInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PaymentTermInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OtherFeesInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ReceiptLabel;
    }
}