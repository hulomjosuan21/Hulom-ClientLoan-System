namespace Hulom_ClientLoan_System.Forms
{
    partial class PaymentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PayButton = new System.Windows.Forms.Button();
            this.TransactionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchClientInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListOfLoanSchedTable = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListOfLoanTable = new System.Windows.Forms.DataGridView();
            this.loanIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivableAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfLoanSchedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfLoanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PayButton);
            this.panel1.Controls.Add(this.TransactionInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchClientInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 545);
            this.panel1.TabIndex = 0;
            // 
            // PayButton
            // 
            this.PayButton.AutoSize = true;
            this.PayButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.Location = new System.Drawing.Point(15, 123);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(75, 28);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            // 
            // TransactionInput
            // 
            this.TransactionInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionInput.Location = new System.Drawing.Point(15, 81);
            this.TransactionInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.TransactionInput.Name = "TransactionInput";
            this.TransactionInput.Size = new System.Drawing.Size(308, 27);
            this.TransactionInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Amount";
            // 
            // SearchClientInput
            // 
            this.SearchClientInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientInput.Location = new System.Drawing.Point(15, 26);
            this.SearchClientInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.SearchClientInput.Name = "SearchClientInput";
            this.SearchClientInput.Size = new System.Drawing.Size(308, 27);
            this.SearchClientInput.TabIndex = 1;
            this.SearchClientInput.TextChanged += new System.EventHandler(this.SearchClientInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListOfLoanSchedTable);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ListOfLoanTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(329, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(490, 545);
            this.panel2.TabIndex = 1;
            // 
            // ListOfLoanSchedTable
            // 
            this.ListOfLoanSchedTable.AllowUserToAddRows = false;
            this.ListOfLoanSchedTable.AllowUserToDeleteRows = false;
            this.ListOfLoanSchedTable.AutoGenerateColumns = false;
            this.ListOfLoanSchedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListOfLoanSchedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfLoanSchedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loanIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.collectablesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.ListOfLoanSchedTable.DataSource = this.scheduleBindingSource;
            this.ListOfLoanSchedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfLoanSchedTable.Location = new System.Drawing.Point(8, 276);
            this.ListOfLoanSchedTable.Name = "ListOfLoanSchedTable";
            this.ListOfLoanSchedTable.ReadOnly = true;
            this.ListOfLoanSchedTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListOfLoanSchedTable.Size = new System.Drawing.Size(474, 261);
            this.ListOfLoanSchedTable.TabIndex = 3;
            this.ListOfLoanSchedTable.SelectionChanged += new System.EventHandler(this.ListOfLoanSched_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectablesDataGridViewTextBoxColumn
            // 
            this.collectablesDataGridViewTextBoxColumn.DataPropertyName = "Collectables";
            this.collectablesDataGridViewTextBoxColumn.HeaderText = "Collectables";
            this.collectablesDataGridViewTextBoxColumn.Name = "collectablesDataGridViewTextBoxColumn";
            this.collectablesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(Hulom_ClientLoan_System.Entities.Schedule);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 22);
            this.panel3.TabIndex = 2;
            // 
            // ListOfLoanTable
            // 
            this.ListOfLoanTable.AllowUserToAddRows = false;
            this.ListOfLoanTable.AllowUserToDeleteRows = false;
            this.ListOfLoanTable.AutoGenerateColumns = false;
            this.ListOfLoanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListOfLoanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfLoanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn1,
            this.loanAmountDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.noOfPaymentsDataGridViewTextBoxColumn,
            this.paymentTermDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.interestedAmountDataGridViewTextBoxColumn,
            this.receivableAmountDataGridViewTextBoxColumn,
            this.totalPayableDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.ListOfLoanTable.DataSource = this.loanBindingSource;
            this.ListOfLoanTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListOfLoanTable.Location = new System.Drawing.Point(8, 8);
            this.ListOfLoanTable.Name = "ListOfLoanTable";
            this.ListOfLoanTable.ReadOnly = true;
            this.ListOfLoanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListOfLoanTable.Size = new System.Drawing.Size(474, 246);
            this.ListOfLoanTable.TabIndex = 0;
            this.ListOfLoanTable.SelectionChanged += new System.EventHandler(this.ListofScheduleTable_SelectionChanged);
            // 
            // loanIDDataGridViewTextBoxColumn1
            // 
            this.loanIDDataGridViewTextBoxColumn1.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn1.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn1.Name = "loanIDDataGridViewTextBoxColumn1";
            this.loanIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            this.clientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // loanAmountDataGridViewTextBoxColumn
            // 
            this.loanAmountDataGridViewTextBoxColumn.DataPropertyName = "LoanAmount";
            this.loanAmountDataGridViewTextBoxColumn.HeaderText = "LoanAmount";
            this.loanAmountDataGridViewTextBoxColumn.Name = "loanAmountDataGridViewTextBoxColumn";
            this.loanAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfPaymentsDataGridViewTextBoxColumn
            // 
            this.noOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "NoOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.HeaderText = "NoOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.Name = "noOfPaymentsDataGridViewTextBoxColumn";
            this.noOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfPaymentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentTermDataGridViewTextBoxColumn
            // 
            this.paymentTermDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.HeaderText = "PaymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.Name = "paymentTermDataGridViewTextBoxColumn";
            this.paymentTermDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTermDataGridViewTextBoxColumn.Visible = false;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionDataGridViewTextBoxColumn.Visible = false;
            // 
            // interestedAmountDataGridViewTextBoxColumn
            // 
            this.interestedAmountDataGridViewTextBoxColumn.DataPropertyName = "InterestedAmount";
            this.interestedAmountDataGridViewTextBoxColumn.HeaderText = "InterestedAmount";
            this.interestedAmountDataGridViewTextBoxColumn.Name = "interestedAmountDataGridViewTextBoxColumn";
            this.interestedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestedAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // receivableAmountDataGridViewTextBoxColumn
            // 
            this.receivableAmountDataGridViewTextBoxColumn.DataPropertyName = "ReceivableAmount";
            this.receivableAmountDataGridViewTextBoxColumn.HeaderText = "ReceivableAmount";
            this.receivableAmountDataGridViewTextBoxColumn.Name = "receivableAmountDataGridViewTextBoxColumn";
            this.receivableAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivableAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalPayableDataGridViewTextBoxColumn
            // 
            this.totalPayableDataGridViewTextBoxColumn.DataPropertyName = "TotalPayable";
            this.totalPayableDataGridViewTextBoxColumn.HeaderText = "TotalPayable";
            this.totalPayableDataGridViewTextBoxColumn.Name = "totalPayableDataGridViewTextBoxColumn";
            this.totalPayableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(Hulom_ClientLoan_System.Entities.Loan);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfLoanSchedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfLoanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListOfLoanTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchClientInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TransactionInput;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ListOfLoanSchedTable;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectablesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivableAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource loanBindingSource;
    }
}