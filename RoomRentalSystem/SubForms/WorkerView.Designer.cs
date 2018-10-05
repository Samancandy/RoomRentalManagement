namespace RoomRentalSystem
{
    partial class WorkerView
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
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.btnCustomerNew = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 46);
            this.label5.TabIndex = 40;
            this.label5.Text = "Worker";
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
            this.label11.TabIndex = 39;
            this.label11.Text = "_________________________________________________________________________________" +
    "___________________\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 90);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dgvWorker);
            this.panel2.Controls.Add(this.btnCustomerNew);
            this.panel2.Controls.Add(this.btnCustomerUpdate);
            this.panel2.Controls.Add(this.btnCustomerDelete);
            this.panel2.Controls.Add(this.btnCustomerSearch);
            this.panel2.Controls.Add(this.txtCustomerSearch);
            this.panel2.Location = new System.Drawing.Point(61, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 493);
            this.panel2.TabIndex = 26;
            // 
            // dgvWorker
            // 
            this.dgvWorker.AllowUserToAddRows = false;
            this.dgvWorker.AllowUserToDeleteRows = false;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(39, 93);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.ReadOnly = true;
            this.dgvWorker.Size = new System.Drawing.Size(803, 306);
            this.dgvWorker.TabIndex = 28;
            // 
            // btnCustomerNew
            // 
            this.btnCustomerNew.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCustomerNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustomerNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCustomerNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCustomerNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerNew.ForeColor = System.Drawing.Color.White;
            this.btnCustomerNew.Location = new System.Drawing.Point(39, 430);
            this.btnCustomerNew.Name = "btnCustomerNew";
            this.btnCustomerNew.Size = new System.Drawing.Size(125, 35);
            this.btnCustomerNew.TabIndex = 26;
            this.btnCustomerNew.Text = "New";
            this.btnCustomerNew.UseVisualStyleBackColor = false;
            this.btnCustomerNew.Click += new System.EventHandler(this.btnCustomerNew_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustomerUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomerUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(194, 430);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(125, 35);
            this.btnCustomerUpdate.TabIndex = 25;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCustomerDelete.BackColor = System.Drawing.Color.Red;
            this.btnCustomerDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDelete.Location = new System.Drawing.Point(350, 430);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(125, 35);
            this.btnCustomerDelete.TabIndex = 24;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustomerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSearch.Location = new System.Drawing.Point(717, 37);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(125, 35);
            this.btnCustomerSearch.TabIndex = 21;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(333, 39);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(366, 32);
            this.txtCustomerSearch.TabIndex = 13;
            // 
            // WorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "WorkerView";
            this.Size = new System.Drawing.Size(1000, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.Button btnCustomerNew;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
    }
}
