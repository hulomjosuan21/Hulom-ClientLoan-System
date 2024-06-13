namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    partial class AddEditClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FnameInput = new System.Windows.Forms.TextBox();
            this.LnameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BdayInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderMInput = new System.Windows.Forms.RadioButton();
            this.GenderFInput = new System.Windows.Forms.RadioButton();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactNumInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // FnameInput
            // 
            this.FnameInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameInput.Location = new System.Drawing.Point(11, 24);
            this.FnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.FnameInput.Name = "FnameInput";
            this.FnameInput.Size = new System.Drawing.Size(171, 27);
            this.FnameInput.TabIndex = 1;
            this.FnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.FnameInput_Validating);
            // 
            // LnameInput
            // 
            this.LnameInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameInput.Location = new System.Drawing.Point(191, 24);
            this.LnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LnameInput.Name = "LnameInput";
            this.LnameInput.Size = new System.Drawing.Size(171, 27);
            this.LnameInput.TabIndex = 3;
            this.LnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.LnameInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // BdayInput
            // 
            this.BdayInput.Location = new System.Drawing.Point(11, 77);
            this.BdayInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BdayInput.Name = "BdayInput";
            this.BdayInput.Size = new System.Drawing.Size(203, 21);
            this.BdayInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // GenderMInput
            // 
            this.GenderMInput.AutoSize = true;
            this.GenderMInput.Location = new System.Drawing.Point(220, 81);
            this.GenderMInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.GenderMInput.Name = "GenderMInput";
            this.GenderMInput.Size = new System.Drawing.Size(49, 17);
            this.GenderMInput.TabIndex = 7;
            this.GenderMInput.TabStop = true;
            this.GenderMInput.Text = "Male";
            this.GenderMInput.UseVisualStyleBackColor = true;
            // 
            // GenderFInput
            // 
            this.GenderFInput.AutoSize = true;
            this.GenderFInput.Location = new System.Drawing.Point(275, 81);
            this.GenderFInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.GenderFInput.Name = "GenderFInput";
            this.GenderFInput.Size = new System.Drawing.Size(60, 17);
            this.GenderFInput.TabIndex = 8;
            this.GenderFInput.TabStop = true;
            this.GenderFInput.Text = "Female";
            this.GenderFInput.UseVisualStyleBackColor = true;
            // 
            // AddressInput
            // 
            this.AddressInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInput.Location = new System.Drawing.Point(11, 124);
            this.AddressInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(351, 27);
            this.AddressInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // ContactNumInput
            // 
            this.ContactNumInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumInput.Location = new System.Drawing.Point(191, 177);
            this.ContactNumInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ContactNumInput.Name = "ContactNumInput";
            this.ContactNumInput.Size = new System.Drawing.Size(171, 27);
            this.ContactNumInput.TabIndex = 14;
            this.ContactNumInput.Validating += new System.ComponentModel.CancelEventHandler(this.ContactNumInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact Number";
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(11, 177);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(171, 27);
            this.EmailInput.TabIndex = 12;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(149, 226);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 28);
            this.Button.TabIndex = 16;
            this.Button.Text = "Add";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 276);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ContactNumInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenderFInput);
            this.Controls.Add(this.GenderMInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BdayInput);
            this.Controls.Add(this.LnameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FnameInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditClientForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.AddEditClientForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.AddEditClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FnameInput;
        private System.Windows.Forms.TextBox LnameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BdayInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton GenderMInput;
        private System.Windows.Forms.RadioButton GenderFInput;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContactNumInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.ToolTip helpToolTip;
    }
}