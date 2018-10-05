namespace RoomRentalSystem
{
    partial class VehicleViewForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.btnVehicleDetail = new System.Windows.Forms.Button();
            this.btnVehicleNew = new System.Windows.Forms.Button();
            this.btnVehicleUpdate = new System.Windows.Forms.Button();
            this.btnVehicleDelete = new System.Windows.Forms.Button();
            this.btnVechicleSave = new System.Windows.Forms.Button();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.txtVehicleidSave = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 90);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 46);
            this.label5.TabIndex = 39;
            this.label5.Text = "Vehicle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(-5, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1010, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "_________________________________________________________________________________" +
    "___________________\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvVehicle);
            this.panel2.Controls.Add(this.btnVehicleDetail);
            this.panel2.Controls.Add(this.btnVehicleNew);
            this.panel2.Controls.Add(this.btnVehicleUpdate);
            this.panel2.Controls.Add(this.btnVehicleDelete);
            this.panel2.Controls.Add(this.btnVechicleSave);
            this.panel2.Controls.Add(this.cboVehicle);
            this.panel2.Controls.Add(this.txtVehicleidSave);
            this.panel2.Location = new System.Drawing.Point(61, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 525);
            this.panel2.TabIndex = 16;
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(70, 131);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.Size = new System.Drawing.Size(736, 226);
            this.dgvVehicle.TabIndex = 28;
            // 
            // btnVehicleDetail
            // 
            this.btnVehicleDetail.BackColor = System.Drawing.Color.Yellow;
            this.btnVehicleDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleDetail.ForeColor = System.Drawing.Color.White;
            this.btnVehicleDetail.Location = new System.Drawing.Point(681, 426);
            this.btnVehicleDetail.Name = "btnVehicleDetail";
            this.btnVehicleDetail.Size = new System.Drawing.Size(125, 44);
            this.btnVehicleDetail.TabIndex = 27;
            this.btnVehicleDetail.Text = "Detail";
            this.btnVehicleDetail.UseVisualStyleBackColor = false;
            // 
            // btnVehicleNew
            // 
            this.btnVehicleNew.BackColor = System.Drawing.Color.Lime;
            this.btnVehicleNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleNew.ForeColor = System.Drawing.Color.White;
            this.btnVehicleNew.Location = new System.Drawing.Point(70, 426);
            this.btnVehicleNew.Name = "btnVehicleNew";
            this.btnVehicleNew.Size = new System.Drawing.Size(125, 44);
            this.btnVehicleNew.TabIndex = 26;
            this.btnVehicleNew.Text = "New";
            this.btnVehicleNew.UseVisualStyleBackColor = false;
            this.btnVehicleNew.Click += new System.EventHandler(this.btnVehicleNew_Click);
            // 
            // btnVehicleUpdate
            // 
            this.btnVehicleUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVehicleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVehicleUpdate.Location = new System.Drawing.Point(269, 426);
            this.btnVehicleUpdate.Name = "btnVehicleUpdate";
            this.btnVehicleUpdate.Size = new System.Drawing.Size(125, 44);
            this.btnVehicleUpdate.TabIndex = 25;
            this.btnVehicleUpdate.Text = "Update";
            this.btnVehicleUpdate.UseVisualStyleBackColor = false;
            this.btnVehicleUpdate.Click += new System.EventHandler(this.btnVehicleUpdate_Click);
            // 
            // btnVehicleDelete
            // 
            this.btnVehicleDelete.BackColor = System.Drawing.Color.Red;
            this.btnVehicleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleDelete.ForeColor = System.Drawing.Color.White;
            this.btnVehicleDelete.Location = new System.Drawing.Point(483, 426);
            this.btnVehicleDelete.Name = "btnVehicleDelete";
            this.btnVehicleDelete.Size = new System.Drawing.Size(125, 44);
            this.btnVehicleDelete.TabIndex = 24;
            this.btnVehicleDelete.Text = "Delete";
            this.btnVehicleDelete.UseVisualStyleBackColor = false;
            // 
            // btnVechicleSave
            // 
            this.btnVechicleSave.BackColor = System.Drawing.Color.Gray;
            this.btnVechicleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVechicleSave.ForeColor = System.Drawing.Color.White;
            this.btnVechicleSave.Location = new System.Drawing.Point(681, 39);
            this.btnVechicleSave.Name = "btnVechicleSave";
            this.btnVechicleSave.Size = new System.Drawing.Size(125, 44);
            this.btnVechicleSave.TabIndex = 21;
            this.btnVechicleSave.Text = "Save";
            this.btnVechicleSave.UseVisualStyleBackColor = false;
            // 
            // cboVehicle
            // 
            this.cboVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Items.AddRange(new object[] {
            "Moto ",
            "Bicycle",
            "All"});
            this.cboVehicle.Location = new System.Drawing.Point(70, 45);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(201, 33);
            this.cboVehicle.TabIndex = 20;
            // 
            // txtVehicleidSave
            // 
            this.txtVehicleidSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleidSave.Location = new System.Drawing.Point(340, 45);
            this.txtVehicleidSave.Name = "txtVehicleidSave";
            this.txtVehicleidSave.Size = new System.Drawing.Size(318, 32);
            this.txtVehicleidSave.TabIndex = 13;
            // 
            // VehicleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "VehicleViewForm";
            this.Size = new System.Drawing.Size(1000, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Button btnVehicleDetail;
        private System.Windows.Forms.Button btnVehicleNew;
        private System.Windows.Forms.Button btnVehicleUpdate;
        private System.Windows.Forms.Button btnVehicleDelete;
        private System.Windows.Forms.Button btnVechicleSave;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.TextBox txtVehicleidSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}
