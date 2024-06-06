using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Forms
{
    partial class MainForm
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

        private void LoadForm(Form form)
        {
            if (this.PanelMain.Controls.Count > 0)
            {
                this.PanelMain.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(f);
            this.PanelMain.Tag = f;
            f.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aside = new System.Windows.Forms.Panel();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.MemberButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.Aside.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aside.Controls.Add(this.PaymentButton);
            this.Aside.Controls.Add(this.MemberButton);
            this.Aside.Controls.Add(this.HomeButton);
            this.Aside.Controls.Add(this.panel1);
            this.Aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.Aside.Location = new System.Drawing.Point(0, 0);
            this.Aside.Name = "Aside";
            this.Aside.Size = new System.Drawing.Size(150, 545);
            this.Aside.TabIndex = 0;
            // 
            // PaymentButton
            // 
            this.PaymentButton.AutoSize = true;
            this.PaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Location = new System.Drawing.Point(0, 146);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.PaymentButton.Size = new System.Drawing.Size(150, 28);
            this.PaymentButton.TabIndex = 3;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // MemberButton
            // 
            this.MemberButton.AutoSize = true;
            this.MemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberButton.FlatAppearance.BorderSize = 0;
            this.MemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberButton.ForeColor = System.Drawing.Color.White;
            this.MemberButton.Location = new System.Drawing.Point(0, 118);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.MemberButton.Size = new System.Drawing.Size(150, 28);
            this.MemberButton.TabIndex = 2;
            this.MemberButton.Text = "Members";
            this.MemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberButton.UseVisualStyleBackColor = true;
            this.MemberButton.Click += new System.EventHandler(this.MemberButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSize = true;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 90);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(150, 28);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(150, 90);
            this.panel1.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(8, 8);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(134, 74);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Josuan";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(150, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(819, 545);
            this.PanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 545);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.Aside);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(985, 584);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Aside.ResumeLayout(false);
            this.Aside.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Aside;
        private Button HomeButton;
        private Panel panel1;
        private Button PaymentButton;
        private Button MemberButton;
        private Label UserLabel;
        private Panel PanelMain;
    }
}