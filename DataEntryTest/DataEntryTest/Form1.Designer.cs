namespace DataEntryTest
{
    partial class frmdataentry
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfirstrec = new System.Windows.Forms.Button();
            this.btnprerec = new System.Windows.Forms.Button();
            this.btnnextrec = new System.Windows.Forms.Button();
            this.btnlastrec = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearchmessage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(10, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(10, 52);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(57, 13);
            this.lblfirstname.TabIndex = 1;
            this.lblfirstname.Text = "First Name";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(10, 80);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(49, 13);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zip";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(78, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(117, 20);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(78, 52);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(235, 20);
            this.txtfirstname.TabIndex = 7;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(78, 80);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(235, 20);
            this.txtsurname.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(78, 114);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(235, 20);
            this.txtaddress.TabIndex = 9;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(78, 143);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(117, 20);
            this.txtcity.TabIndex = 10;
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(78, 175);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(117, 20);
            this.txtzip.TabIndex = 11;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(330, 13);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 12;
            this.btnload.Text = "Load Data";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(330, 44);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(75, 23);
            this.btnupload.TabIndex = 13;
            this.btnupload.Text = "Upload Data";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(330, 107);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(330, 135);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(330, 165);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfirstrec
            // 
            this.btnfirstrec.Location = new System.Drawing.Point(106, 207);
            this.btnfirstrec.Name = "btnfirstrec";
            this.btnfirstrec.Size = new System.Drawing.Size(40, 23);
            this.btnfirstrec.TabIndex = 17;
            this.btnfirstrec.Text = "|<";
            this.btnfirstrec.UseVisualStyleBackColor = true;
            this.btnfirstrec.Click += new System.EventHandler(this.btnfirstrec_Click);
            // 
            // btnprerec
            // 
            this.btnprerec.Location = new System.Drawing.Point(152, 207);
            this.btnprerec.Name = "btnprerec";
            this.btnprerec.Size = new System.Drawing.Size(40, 23);
            this.btnprerec.TabIndex = 18;
            this.btnprerec.Text = "<";
            this.btnprerec.UseVisualStyleBackColor = true;
            this.btnprerec.Click += new System.EventHandler(this.btnprerec_Click);
            // 
            // btnnextrec
            // 
            this.btnnextrec.Location = new System.Drawing.Point(238, 207);
            this.btnnextrec.Name = "btnnextrec";
            this.btnnextrec.Size = new System.Drawing.Size(40, 23);
            this.btnnextrec.TabIndex = 19;
            this.btnnextrec.Text = ">";
            this.btnnextrec.UseVisualStyleBackColor = true;
            this.btnnextrec.Click += new System.EventHandler(this.btnnextrec_Click);
            // 
            // btnlastrec
            // 
            this.btnlastrec.Location = new System.Drawing.Point(284, 207);
            this.btnlastrec.Name = "btnlastrec";
            this.btnlastrec.Size = new System.Drawing.Size(40, 23);
            this.btnlastrec.TabIndex = 20;
            this.btnlastrec.Text = ">|";
            this.btnlastrec.UseVisualStyleBackColor = true;
            this.btnlastrec.Click += new System.EventHandler(this.btnlastrec_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(12, 242);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(106, 244);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(119, 20);
            this.txtsearch.TabIndex = 22;
            // 
            // btnsearchmessage
            // 
            this.btnsearchmessage.Location = new System.Drawing.Point(12, 272);
            this.btnsearchmessage.Name = "btnsearchmessage";
            this.btnsearchmessage.Size = new System.Drawing.Size(75, 23);
            this.btnsearchmessage.TabIndex = 23;
            this.btnsearchmessage.Text = "Search 2";
            this.btnsearchmessage.UseVisualStyleBackColor = true;
            this.btnsearchmessage.Click += new System.EventHandler(this.btnsearchmessage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tspLoading});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(408, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 17);
            this.tssStatus.Text = "Status";
            // 
            // tspLoading
            // 
            this.tspLoading.Name = "tspLoading";
            this.tspLoading.Size = new System.Drawing.Size(100, 16);
            // 
            // frmdataentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnsearchmessage);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnlastrec);
            this.Controls.Add(this.btnnextrec);
            this.Controls.Add(this.btnprerec);
            this.Controls.Add(this.btnfirstrec);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblid);
            this.Name = "frmdataentry";
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.frmdataentry_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfirstrec;
        private System.Windows.Forms.Button btnprerec;
        private System.Windows.Forms.Button btnnextrec;
        private System.Windows.Forms.Button btnlastrec;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearchmessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripProgressBar tspLoading;
    }
}

