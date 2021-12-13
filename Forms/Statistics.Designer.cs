namespace Management.Forms
{
    partial class Statistics
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
            this.managementDataSet = new Management.ManagementDataSet();
            this.tomatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tomatoTableAdapter = new Management.ManagementDataSetTableAdapters.tomatoTableAdapter();
            this.tableAdapterManager = new Management.ManagementDataSetTableAdapters.TableAdapterManager();
            this.managementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tomatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tomatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // managementDataSet
            // 
            this.managementDataSet.DataSetName = "ManagementDataSet";
            this.managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tomatoBindingSource
            // 
            this.tomatoBindingSource.DataMember = "tomato";
            this.tomatoBindingSource.DataSource = this.managementDataSet;
            // 
            // tomatoTableAdapter
            // 
            this.tomatoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.billsTableAdapter = null;
            this.tableAdapterManager.tomatoTableAdapter = this.tomatoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Management.ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userinfoTableAdapter = null;
            // 
            // managementDataSetBindingSource
            // 
            this.managementDataSetBindingSource.DataSource = this.managementDataSet;
            this.managementDataSetBindingSource.Position = 0;
            // 
            // tomatoBindingSource1
            // 
            this.tomatoBindingSource1.DataMember = "tomato";
            this.tomatoBindingSource1.DataSource = this.managementDataSet;
            // 
            // tomatoBindingSource2
            // 
            this.tomatoBindingSource2.DataMember = "tomato";
            this.tomatoBindingSource2.DataSource = this.managementDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.managementDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1336, 721);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.ShowInTaskbar = false;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ManagementDataSet managementDataSet;
        private System.Windows.Forms.BindingSource tomatoBindingSource;
        private ManagementDataSetTableAdapters.tomatoTableAdapter tomatoTableAdapter;
        private ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tomatoBindingSource2;
        private System.Windows.Forms.BindingSource managementDataSetBindingSource;
        private System.Windows.Forms.BindingSource tomatoBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}