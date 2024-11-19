namespace BreadInventory
{
	partial class Form2
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
			this.label6 = new System.Windows.Forms.Label();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.txtExpiration = new System.Windows.Forms.DateTimePicker();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.clrBtn = new System.Windows.Forms.Button();
			this.dgBreadData = new System.Windows.Forms.DataGridView();
			this.insertBtn = new System.Windows.Forms.Button();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtBread = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.logoutBtn = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgBread = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgBreadData)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(243, 16);
			this.label6.TabIndex = 31;
			this.label6.Text = "JULIES BREAD INVENTORY SYSTEM";
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(193, 419);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 29;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(112, 419);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 28;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// txtExpiration
			// 
			this.txtExpiration.Location = new System.Drawing.Point(138, 282);
			this.txtExpiration.Name = "txtExpiration";
			this.txtExpiration.Size = new System.Drawing.Size(220, 22);
			this.txtExpiration.TabIndex = 27;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(138, 340);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(220, 22);
			this.txtStatus.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 16);
			this.label5.TabIndex = 25;
			this.label5.Text = "Status";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 16);
			this.label4.TabIndex = 24;
			this.label4.Text = "Expiration Date";
			// 
			// clrBtn
			// 
			this.clrBtn.Location = new System.Drawing.Point(283, 419);
			this.clrBtn.Name = "clrBtn";
			this.clrBtn.Size = new System.Drawing.Size(75, 23);
			this.clrBtn.TabIndex = 30;
			this.clrBtn.Text = "Clear";
			this.clrBtn.UseVisualStyleBackColor = true;
			this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
			// 
			// dgBreadData
			// 
			this.dgBreadData.AllowUserToDeleteRows = false;
			this.dgBreadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBreadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgBread,
            this.dgQuantity,
            this.dgPrice,
            this.dgExpiration,
            this.dgStatus,
            this.dgCreatedAt});
			this.dgBreadData.Location = new System.Drawing.Point(418, 83);
			this.dgBreadData.Name = "dgBreadData";
			this.dgBreadData.ReadOnly = true;
			this.dgBreadData.RowHeadersWidth = 51;
			this.dgBreadData.RowTemplate.Height = 24;
			this.dgBreadData.Size = new System.Drawing.Size(1000, 550);
			this.dgBreadData.TabIndex = 23;
			this.dgBreadData.DoubleClick += new System.EventHandler(this.dgBreadData_DoubleClick);
			// 
			// insertBtn
			// 
			this.insertBtn.Location = new System.Drawing.Point(31, 419);
			this.insertBtn.Name = "insertBtn";
			this.insertBtn.Size = new System.Drawing.Size(65, 23);
			this.insertBtn.TabIndex = 22;
			this.insertBtn.Text = "Insert";
			this.insertBtn.UseVisualStyleBackColor = true;
			this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(138, 227);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(220, 22);
			this.txtPrice.TabIndex = 21;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(138, 172);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(220, 22);
			this.txtQuantity.TabIndex = 20;
			// 
			// txtBread
			// 
			this.txtBread.Location = new System.Drawing.Point(138, 116);
			this.txtBread.Name = "txtBread";
			this.txtBread.Size = new System.Drawing.Size(220, 22);
			this.txtBread.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 18;
			this.label3.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Quantity";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Bread";
			// 
			// logoutBtn
			// 
			this.logoutBtn.Location = new System.Drawing.Point(952, 21);
			this.logoutBtn.Name = "logoutBtn";
			this.logoutBtn.Size = new System.Drawing.Size(75, 35);
			this.logoutBtn.TabIndex = 32;
			this.logoutBtn.Text = "Logout";
			this.logoutBtn.UseVisualStyleBackColor = true;
			this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(717, 30);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(77, 16);
			this.lblName.TabIndex = 34;
			this.lblName.Text = "Login Label";
			this.lblName.Click += new System.EventHandler(this.lblName_Click);
			// 
			// dgId
			// 
			this.dgId.DataPropertyName = "Id";
			this.dgId.HeaderText = "This ID";
			this.dgId.MinimumWidth = 6;
			this.dgId.Name = "dgId";
			this.dgId.ReadOnly = true;
			this.dgId.Width = 125;
			// 
			// dgBread
			// 
			this.dgBread.DataPropertyName = "bread_name";
			this.dgBread.HeaderText = "This Bread";
			this.dgBread.MinimumWidth = 6;
			this.dgBread.Name = "dgBread";
			this.dgBread.ReadOnly = true;
			this.dgBread.Width = 125;
			// 
			// dgQuantity
			// 
			this.dgQuantity.DataPropertyName = "quantity";
			this.dgQuantity.HeaderText = "This Quantity";
			this.dgQuantity.MinimumWidth = 6;
			this.dgQuantity.Name = "dgQuantity";
			this.dgQuantity.ReadOnly = true;
			this.dgQuantity.Width = 125;
			// 
			// dgPrice
			// 
			this.dgPrice.DataPropertyName = "price";
			this.dgPrice.HeaderText = "This Price";
			this.dgPrice.MinimumWidth = 6;
			this.dgPrice.Name = "dgPrice";
			this.dgPrice.ReadOnly = true;
			this.dgPrice.Width = 125;
			// 
			// dgExpiration
			// 
			this.dgExpiration.DataPropertyName = "expiration_date";
			this.dgExpiration.HeaderText = "This Expiration Date";
			this.dgExpiration.MinimumWidth = 6;
			this.dgExpiration.Name = "dgExpiration";
			this.dgExpiration.ReadOnly = true;
			this.dgExpiration.Width = 125;
			// 
			// dgStatus
			// 
			this.dgStatus.DataPropertyName = "status";
			this.dgStatus.HeaderText = "This Status";
			this.dgStatus.MinimumWidth = 6;
			this.dgStatus.Name = "dgStatus";
			this.dgStatus.ReadOnly = true;
			this.dgStatus.Width = 125;
			// 
			// dgCreatedAt
			// 
			this.dgCreatedAt.DataPropertyName = "created_at";
			this.dgCreatedAt.HeaderText = "This Timestamp";
			this.dgCreatedAt.MinimumWidth = 6;
			this.dgCreatedAt.Name = "dgCreatedAt";
			this.dgCreatedAt.ReadOnly = true;
			this.dgCreatedAt.Width = 125;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 492);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.logoutBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.txtExpiration);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.clrBtn);
			this.Controls.Add(this.dgBreadData);
			this.Controls.Add(this.insertBtn);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtBread);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Bread Inventory";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgBreadData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.DateTimePicker txtExpiration;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button clrBtn;
		private System.Windows.Forms.DataGridView dgBreadData;
		private System.Windows.Forms.Button insertBtn;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtBread;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button logoutBtn;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgBread;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgExpiration;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCreatedAt;
	}
}