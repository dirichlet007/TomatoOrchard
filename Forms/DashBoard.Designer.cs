
namespace Management.Forms
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.toppanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btnusermanage = new System.Windows.Forms.Button();
            this.btnbillmanage = new System.Windows.Forms.Button();
            this.btnsystemset = new System.Windows.Forms.Button();
            this.btnqueryinfo = new System.Windows.Forms.Button();
            this.btnborrow = new System.Windows.Forms.Button();
            this.btnreader = new System.Windows.Forms.Button();
            this.btnbookmanage = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnfold = new System.Windows.Forms.Button();
            this.panelmain = new System.Windows.Forms.Panel();
            this.toppanel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toppanel.BackColor = System.Drawing.Color.Orange;
            this.toppanel.Controls.Add(this.labeltitle);
            this.toppanel.Controls.Add(this.label4);
            this.toppanel.Location = new System.Drawing.Point(252, 90);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1336, 83);
            this.toppanel.TabIndex = 2;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.BackColor = System.Drawing.Color.Orange;
            this.labeltitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labeltitle.Location = new System.Drawing.Point(3, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(252, 44);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "欢迎！";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(261, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "权限";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "峰悦管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Orange;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1524, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(64, 64);
            this.btnclose.TabIndex = 22;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button10_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(587, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 41);
            this.label3.TabIndex = 23;
            this.label3.Text = "HH:MM:SS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btnusermanage
            // 
            this.btnusermanage.BackColor = System.Drawing.Color.Orange;
            this.btnusermanage.FlatAppearance.BorderSize = 0;
            this.btnusermanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnusermanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusermanage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusermanage.ForeColor = System.Drawing.Color.White;
            this.btnusermanage.Image = ((System.Drawing.Image)(resources.GetObject("btnusermanage.Image")));
            this.btnusermanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusermanage.Location = new System.Drawing.Point(7, 596);
            this.btnusermanage.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnusermanage.Name = "btnusermanage";
            this.btnusermanage.Size = new System.Drawing.Size(229, 60);
            this.btnusermanage.TabIndex = 25;
            this.btnusermanage.Text = "     暂定";
            this.btnusermanage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnusermanage.UseVisualStyleBackColor = false;
            // 
            // btnbillmanage
            // 
            this.btnbillmanage.BackColor = System.Drawing.Color.Orange;
            this.btnbillmanage.FlatAppearance.BorderSize = 0;
            this.btnbillmanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbillmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbillmanage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillmanage.ForeColor = System.Drawing.Color.White;
            this.btnbillmanage.Image = ((System.Drawing.Image)(resources.GetObject("btnbillmanage.Image")));
            this.btnbillmanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbillmanage.Location = new System.Drawing.Point(7, 536);
            this.btnbillmanage.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnbillmanage.Name = "btnbillmanage";
            this.btnbillmanage.Size = new System.Drawing.Size(229, 60);
            this.btnbillmanage.TabIndex = 26;
            this.btnbillmanage.Text = "     暂定";
            this.btnbillmanage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbillmanage.UseVisualStyleBackColor = false;
            // 
            // btnsystemset
            // 
            this.btnsystemset.BackColor = System.Drawing.Color.Orange;
            this.btnsystemset.FlatAppearance.BorderSize = 0;
            this.btnsystemset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsystemset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsystemset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystemset.ForeColor = System.Drawing.Color.White;
            this.btnsystemset.Image = ((System.Drawing.Image)(resources.GetObject("btnsystemset.Image")));
            this.btnsystemset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystemset.Location = new System.Drawing.Point(7, 476);
            this.btnsystemset.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnsystemset.Name = "btnsystemset";
            this.btnsystemset.Size = new System.Drawing.Size(229, 60);
            this.btnsystemset.TabIndex = 27;
            this.btnsystemset.Text = "     系统主题";
            this.btnsystemset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsystemset.UseVisualStyleBackColor = false;
            this.btnsystemset.Click += new System.EventHandler(this.btnsystemset_Click);
            // 
            // btnqueryinfo
            // 
            this.btnqueryinfo.BackColor = System.Drawing.Color.Orange;
            this.btnqueryinfo.FlatAppearance.BorderSize = 0;
            this.btnqueryinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnqueryinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqueryinfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqueryinfo.ForeColor = System.Drawing.Color.White;
            this.btnqueryinfo.Image = ((System.Drawing.Image)(resources.GetObject("btnqueryinfo.Image")));
            this.btnqueryinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqueryinfo.Location = new System.Drawing.Point(7, 416);
            this.btnqueryinfo.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnqueryinfo.Name = "btnqueryinfo";
            this.btnqueryinfo.Size = new System.Drawing.Size(229, 60);
            this.btnqueryinfo.TabIndex = 28;
            this.btnqueryinfo.Text = "     账单统计";
            this.btnqueryinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnqueryinfo.UseVisualStyleBackColor = false;
            this.btnqueryinfo.Click += new System.EventHandler(this.btnqueryinfo_Click);
            // 
            // btnborrow
            // 
            this.btnborrow.BackColor = System.Drawing.Color.Orange;
            this.btnborrow.FlatAppearance.BorderSize = 0;
            this.btnborrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.ForeColor = System.Drawing.Color.White;
            this.btnborrow.Image = ((System.Drawing.Image)(resources.GetObject("btnborrow.Image")));
            this.btnborrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrow.Location = new System.Drawing.Point(7, 356);
            this.btnborrow.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(229, 60);
            this.btnborrow.TabIndex = 29;
            this.btnborrow.Text = "     账单";
            this.btnborrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrow.UseVisualStyleBackColor = false;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // btnreader
            // 
            this.btnreader.BackColor = System.Drawing.Color.Orange;
            this.btnreader.FlatAppearance.BorderSize = 0;
            this.btnreader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnreader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreader.ForeColor = System.Drawing.Color.White;
            this.btnreader.Image = ((System.Drawing.Image)(resources.GetObject("btnreader.Image")));
            this.btnreader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreader.Location = new System.Drawing.Point(7, 296);
            this.btnreader.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnreader.Name = "btnreader";
            this.btnreader.Size = new System.Drawing.Size(229, 60);
            this.btnreader.TabIndex = 30;
            this.btnreader.Text = "     番茄统计";
            this.btnreader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreader.UseVisualStyleBackColor = false;
            this.btnreader.Click += new System.EventHandler(this.btnreader_Click);
            // 
            // btnbookmanage
            // 
            this.btnbookmanage.BackColor = System.Drawing.Color.Orange;
            this.btnbookmanage.FlatAppearance.BorderSize = 0;
            this.btnbookmanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbookmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbookmanage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookmanage.ForeColor = System.Drawing.Color.White;
            this.btnbookmanage.Image = ((System.Drawing.Image)(resources.GetObject("btnbookmanage.Image")));
            this.btnbookmanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbookmanage.Location = new System.Drawing.Point(7, 236);
            this.btnbookmanage.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnbookmanage.Name = "btnbookmanage";
            this.btnbookmanage.Size = new System.Drawing.Size(229, 60);
            this.btnbookmanage.TabIndex = 31;
            this.btnbookmanage.Text = "     番茄钟";
            this.btnbookmanage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbookmanage.UseVisualStyleBackColor = false;
            this.btnbookmanage.Click += new System.EventHandler(this.btnbookmanage_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(7, 176);
            this.btnHome.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(229, 60);
            this.btnHome.TabIndex = 32;
            this.btnHome.Text = "     主页";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Orange;
            this.panelLeft.Controls.Add(this.flowLayoutPanel3);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.btnbookmanage);
            this.panelLeft.Controls.Add(this.btnreader);
            this.panelLeft.Controls.Add(this.btnborrow);
            this.panelLeft.Controls.Add(this.btnqueryinfo);
            this.panelLeft.Controls.Add(this.btnsystemset);
            this.panelLeft.Controls.Add(this.btnbillmanage);
            this.panelLeft.Controls.Add(this.btnusermanage);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 900);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.btnfold);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(213, 170);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 94);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(197, 0);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btnfold
            // 
            this.btnfold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnfold.BackColor = System.Drawing.Color.Orange;
            this.btnfold.FlatAppearance.BorderSize = 0;
            this.btnfold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfold.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfold.ForeColor = System.Drawing.Color.White;
            this.btnfold.Image = ((System.Drawing.Image)(resources.GetObject("btnfold.Image")));
            this.btnfold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfold.Location = new System.Drawing.Point(0, 97);
            this.btnfold.Margin = new System.Windows.Forms.Padding(0);
            this.btnfold.Name = "btnfold";
            this.btnfold.Size = new System.Drawing.Size(84, 64);
            this.btnfold.TabIndex = 3;
            this.btnfold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfold.UseVisualStyleBackColor = false;
            this.btnfold.Click += new System.EventHandler(this.button9_Click);
            // 
            // panelmain
            // 
            this.panelmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelmain.Location = new System.Drawing.Point(252, 179);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1336, 721);
            this.panelmain.TabIndex = 24;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnclose);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.toppanel.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel toppanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button btnusermanage;
        private System.Windows.Forms.Button btnbillmanage;
        private System.Windows.Forms.Button btnsystemset;
        private System.Windows.Forms.Button btnqueryinfo;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Button btnreader;
        private System.Windows.Forms.Button btnbookmanage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnfold;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}