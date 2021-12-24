
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
            this.btn = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnSystemSet = new System.Windows.Forms.Button();
            this.btnBillsStatistic = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnTomatoStatistic = new System.Windows.Forms.Button();
            this.btnTomato = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
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
            this.labeltitle.Font = new System.Drawing.Font("幼圆", 18F);
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
            this.label4.Font = new System.Drawing.Font("幼圆", 18F);
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
            this.label1.Text = "宇峰管理系统";
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
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Orange;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("幼圆", 12F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(7, 596);
            this.btn.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(229, 60);
            this.btn.TabIndex = 25;
            this.btn.Text = "     暂定";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.Orange;
            this.btnManager.FlatAppearance.BorderSize = 0;
            this.btnManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Location = new System.Drawing.Point(7, 536);
            this.btnManager.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(229, 60);
            this.btnManager.TabIndex = 26;
            this.btnManager.Text = "     用户管理";
            this.btnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnSystemSet
            // 
            this.btnSystemSet.BackColor = System.Drawing.Color.Orange;
            this.btnSystemSet.FlatAppearance.BorderSize = 0;
            this.btnSystemSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSystemSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSet.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnSystemSet.ForeColor = System.Drawing.Color.White;
            this.btnSystemSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemSet.Image")));
            this.btnSystemSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemSet.Location = new System.Drawing.Point(7, 476);
            this.btnSystemSet.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSystemSet.Name = "btnSystemSet";
            this.btnSystemSet.Size = new System.Drawing.Size(229, 60);
            this.btnSystemSet.TabIndex = 27;
            this.btnSystemSet.Text = "     系统主题";
            this.btnSystemSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemSet.UseVisualStyleBackColor = false;
            this.btnSystemSet.Click += new System.EventHandler(this.btnsystemset_Click);
            // 
            // btnBillsStatistic
            // 
            this.btnBillsStatistic.BackColor = System.Drawing.Color.Orange;
            this.btnBillsStatistic.FlatAppearance.BorderSize = 0;
            this.btnBillsStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBillsStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsStatistic.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnBillsStatistic.ForeColor = System.Drawing.Color.White;
            this.btnBillsStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnBillsStatistic.Image")));
            this.btnBillsStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillsStatistic.Location = new System.Drawing.Point(7, 416);
            this.btnBillsStatistic.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnBillsStatistic.Name = "btnBillsStatistic";
            this.btnBillsStatistic.Size = new System.Drawing.Size(229, 60);
            this.btnBillsStatistic.TabIndex = 28;
            this.btnBillsStatistic.Text = "     账单统计";
            this.btnBillsStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillsStatistic.UseVisualStyleBackColor = false;
            this.btnBillsStatistic.Click += new System.EventHandler(this.btnqueryinfo_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Orange;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(7, 356);
            this.btnBills.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(229, 60);
            this.btnBills.TabIndex = 29;
            this.btnBills.Text = "     账单";
            this.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // btnTomatoStatistic
            // 
            this.btnTomatoStatistic.BackColor = System.Drawing.Color.Orange;
            this.btnTomatoStatistic.FlatAppearance.BorderSize = 0;
            this.btnTomatoStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTomatoStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomatoStatistic.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnTomatoStatistic.ForeColor = System.Drawing.Color.White;
            this.btnTomatoStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnTomatoStatistic.Image")));
            this.btnTomatoStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomatoStatistic.Location = new System.Drawing.Point(7, 296);
            this.btnTomatoStatistic.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTomatoStatistic.Name = "btnTomatoStatistic";
            this.btnTomatoStatistic.Size = new System.Drawing.Size(229, 60);
            this.btnTomatoStatistic.TabIndex = 30;
            this.btnTomatoStatistic.Text = "     番茄统计";
            this.btnTomatoStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTomatoStatistic.UseVisualStyleBackColor = false;
            this.btnTomatoStatistic.Click += new System.EventHandler(this.btnreader_Click);
            // 
            // btnTomato
            // 
            this.btnTomato.BackColor = System.Drawing.Color.Orange;
            this.btnTomato.FlatAppearance.BorderSize = 0;
            this.btnTomato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTomato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomato.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnTomato.ForeColor = System.Drawing.Color.White;
            this.btnTomato.Image = ((System.Drawing.Image)(resources.GetObject("btnTomato.Image")));
            this.btnTomato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomato.Location = new System.Drawing.Point(7, 236);
            this.btnTomato.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTomato.Name = "btnTomato";
            this.btnTomato.Size = new System.Drawing.Size(229, 60);
            this.btnTomato.TabIndex = 31;
            this.btnTomato.Text = "     番茄钟";
            this.btnTomato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTomato.UseVisualStyleBackColor = false;
            this.btnTomato.Click += new System.EventHandler(this.btnbookmanage_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Orange;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("幼圆", 12F);
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(7, 176);
            this.btnMain.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(229, 60);
            this.btnMain.TabIndex = 32;
            this.btnMain.Text = "     主页";
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Orange;
            this.panelLeft.Controls.Add(this.flowLayoutPanel3);
            this.panelLeft.Controls.Add(this.btnMain);
            this.panelLeft.Controls.Add(this.btnTomato);
            this.panelLeft.Controls.Add(this.btnTomatoStatistic);
            this.panelLeft.Controls.Add(this.btnBills);
            this.panelLeft.Controls.Add(this.btnBillsStatistic);
            this.panelLeft.Controls.Add(this.btnSystemSet);
            this.panelLeft.Controls.Add(this.btnManager);
            this.panelLeft.Controls.Add(this.btn);
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
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnSystemSet;
        private System.Windows.Forms.Button btnBillsStatistic;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnTomatoStatistic;
        private System.Windows.Forms.Button btnTomato;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnfold;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panelmain;
    }
}