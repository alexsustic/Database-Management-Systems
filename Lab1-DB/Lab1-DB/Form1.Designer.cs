
namespace Lab1_DB
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
            this.gridManager = new System.Windows.Forms.DataGridView();
            this.gridHotel = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelID_txt = new System.Windows.Forms.TextBox();
            this.managerID_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.capacity_txt = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.managerID = new System.Windows.Forms.Label();
            this.hotelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridManager
            // 
            this.gridManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManager.Location = new System.Drawing.Point(21, 33);
            this.gridManager.Name = "gridManager";
            this.gridManager.RowHeadersWidth = 51;
            this.gridManager.RowTemplate.Height = 24;
            this.gridManager.Size = new System.Drawing.Size(420, 182);
            this.gridManager.TabIndex = 0;
            // 
            // gridHotel
            // 
            this.gridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHotel.Location = new System.Drawing.Point(21, 255);
            this.gridHotel.Name = "gridHotel";
            this.gridHotel.RowHeadersWidth = 51;
            this.gridHotel.RowTemplate.Height = 24;
            this.gridHotel.Size = new System.Drawing.Size(420, 183);
            this.gridHotel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(666, 276);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(666, 335);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 34);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(666, 392);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 31);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manager:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hotel:";
            // 
            // hotelID_txt
            // 
            this.hotelID_txt.Location = new System.Drawing.Point(565, 70);
            this.hotelID_txt.Name = "hotelID_txt";
            this.hotelID_txt.Size = new System.Drawing.Size(193, 22);
            this.hotelID_txt.TabIndex = 7;
            // 
            // managerID_txt
            // 
            this.managerID_txt.Location = new System.Drawing.Point(565, 111);
            this.managerID_txt.Name = "managerID_txt";
            this.managerID_txt.Size = new System.Drawing.Size(193, 22);
            this.managerID_txt.TabIndex = 8;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(565, 154);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(193, 22);
            this.name_txt.TabIndex = 9;
            // 
            // capacity_txt
            // 
            this.capacity_txt.Location = new System.Drawing.Point(565, 192);
            this.capacity_txt.Name = "capacity_txt";
            this.capacity_txt.Size = new System.Drawing.Size(193, 22);
            this.capacity_txt.TabIndex = 10;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(493, 195);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(66, 17);
            this.capacity.TabIndex = 14;
            this.capacity.Text = "Capacity:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(510, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 17);
            this.name.TabIndex = 13;
            this.name.Text = "Name:";
            // 
            // managerID
            // 
            this.managerID.AutoSize = true;
            this.managerID.Location = new System.Drawing.Point(478, 114);
            this.managerID.Name = "managerID";
            this.managerID.Size = new System.Drawing.Size(81, 17);
            this.managerID.TabIndex = 12;
            this.managerID.Text = "ManagerID:";
            // 
            // hotelID
            // 
            this.hotelID.AutoSize = true;
            this.hotelID.Location = new System.Drawing.Point(501, 73);
            this.hotelID.Name = "hotelID";
            this.hotelID.Size = new System.Drawing.Size(58, 17);
            this.hotelID.TabIndex = 11;
            this.hotelID.Text = "HotelID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.managerID);
            this.Controls.Add(this.hotelID);
            this.Controls.Add(this.capacity_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.managerID_txt);
            this.Controls.Add(this.hotelID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.gridHotel);
            this.Controls.Add(this.gridManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridManager;
        private System.Windows.Forms.DataGridView gridHotel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hotelID_txt;
        private System.Windows.Forms.TextBox managerID_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox capacity_txt;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label managerID;
        private System.Windows.Forms.Label hotelID;
    }
}

