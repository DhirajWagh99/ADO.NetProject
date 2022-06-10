namespace ADO.NetProject
{
    partial class Course
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(166, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(56, 242);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(13, 39);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(66, 16);
            this.lblCid.TabIndex = 5;
            this.lblCid.Text = "Course ID";
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(-1, 81);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(90, 16);
            this.lblCname.TabIndex = 6;
            this.lblCname.Text = "Course Name";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Location = new System.Drawing.Point(19, 130);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(38, 16);
            this.lblfees.TabIndex = 7;
            this.lblfees.Text = "Fees";
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(95, 33);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(146, 22);
            this.txtcid.TabIndex = 8;
            // 
            // txtfees
            // 
            this.txtfees.Location = new System.Drawing.Point(95, 130);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(146, 22);
            this.txtfees.TabIndex = 9;
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(95, 75);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(146, 22);
            this.txtcname.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 214);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(523, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.txtfees);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblCname);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Name = "Course";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
    }
}