
namespace Management.Forms
{
    partial class Home
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tomatoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tomatoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tomatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementDataSet = new Management.ManagementDataSet();
            this.tomatoTableAdapter = new Management.ManagementDataSetTableAdapters.tomatoTableAdapter();
            this.tableAdapterManager = new Management.ManagementDataSetTableAdapters.TableAdapterManager();
            this.tdcounterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdlenthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingNavigator)).BeginInit();
            this.tomatoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.ForeColor = System.Drawing.Color.Coral;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1325, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1325, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主页";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1333, 718);
            this.tabControl1.TabIndex = 0;
            // 
            // tomatoBindingNavigator
            // 
            this.tomatoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tomatoBindingNavigator.BindingSource = this.tomatoBindingSource;
            this.tomatoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tomatoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tomatoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tomatoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tomatoBindingNavigatorSaveItem});
            this.tomatoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tomatoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tomatoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tomatoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tomatoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tomatoBindingNavigator.Name = "tomatoBindingNavigator";
            this.tomatoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tomatoBindingNavigator.Size = new System.Drawing.Size(1336, 27);
            this.tomatoBindingNavigator.TabIndex = 1;
            this.tomatoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tomatoBindingNavigatorSaveItem
            // 
            this.tomatoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tomatoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tomatoBindingNavigatorSaveItem.Image")));
            this.tomatoBindingNavigatorSaveItem.Name = "tomatoBindingNavigatorSaveItem";
            this.tomatoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tomatoBindingNavigatorSaveItem.Text = "保存数据";
            this.tomatoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tomatoBindingNavigatorSaveItem_Click);
            // 
            // tomatoBindingSource
            // 
            this.tomatoBindingSource.DataMember = "tomato";
            this.tomatoBindingSource.DataSource = this.managementDataSet;
            // 
            // managementDataSet
            // 
            this.managementDataSet.DataSetName = "ManagementDataSet";
            this.managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tdcounterDataGridViewTextBoxColumn
            // 
            this.tdcounterDataGridViewTextBoxColumn.DataPropertyName = "tdcounter";
            this.tdcounterDataGridViewTextBoxColumn.HeaderText = "完成次数";
            this.tdcounterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdcounterDataGridViewTextBoxColumn.Name = "tdcounterDataGridViewTextBoxColumn";
            this.tdcounterDataGridViewTextBoxColumn.Width = 160;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "代办账号";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Width = 160;
            // 
            // tdtimeDataGridViewTextBoxColumn
            // 
            this.tdtimeDataGridViewTextBoxColumn.DataPropertyName = "tdtime";
            this.tdtimeDataGridViewTextBoxColumn.HeaderText = "     代办创建时间";
            this.tdtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdtimeDataGridViewTextBoxColumn.Name = "tdtimeDataGridViewTextBoxColumn";
            this.tdtimeDataGridViewTextBoxColumn.Width = 320;
            // 
            // tdlenthDataGridViewTextBoxColumn
            // 
            this.tdlenthDataGridViewTextBoxColumn.DataPropertyName = "tdlenth";
            this.tdlenthDataGridViewTextBoxColumn.HeaderText = "代办时长";
            this.tdlenthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdlenthDataGridViewTextBoxColumn.Name = "tdlenthDataGridViewTextBoxColumn";
            this.tdlenthDataGridViewTextBoxColumn.Width = 160;
            // 
            // tdtypeDataGridViewTextBoxColumn
            // 
            this.tdtypeDataGridViewTextBoxColumn.DataPropertyName = "tdtype";
            this.tdtypeDataGridViewTextBoxColumn.HeaderText = "代办类型";
            this.tdtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdtypeDataGridViewTextBoxColumn.Name = "tdtypeDataGridViewTextBoxColumn";
            this.tdtypeDataGridViewTextBoxColumn.Width = 160;
            // 
            // tdnameDataGridViewTextBoxColumn
            // 
            this.tdnameDataGridViewTextBoxColumn.DataPropertyName = "tdname";
            this.tdnameDataGridViewTextBoxColumn.HeaderText = "代办名称";
            this.tdnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdnameDataGridViewTextBoxColumn.Name = "tdnameDataGridViewTextBoxColumn";
            this.tdnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // tdnumDataGridViewTextBoxColumn
            // 
            this.tdnumDataGridViewTextBoxColumn.DataPropertyName = "tdnum";
            this.tdnumDataGridViewTextBoxColumn.HeaderText = "代办编号";
            this.tdnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdnumDataGridViewTextBoxColumn.Name = "tdnumDataGridViewTextBoxColumn";
            this.tdnumDataGridViewTextBoxColumn.Width = 160;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdnumDataGridViewTextBoxColumn,
            this.tdnameDataGridViewTextBoxColumn,
            this.tdtypeDataGridViewTextBoxColumn,
            this.tdlenthDataGridViewTextBoxColumn,
            this.tdtimeDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.tdcounterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tomatoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 683);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tomatoBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1336, 721);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingNavigator)).EndInit();
            this.tomatoBindingNavigator.ResumeLayout(false);
            this.tomatoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tomatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private ManagementDataSet managementDataSet;
        private System.Windows.Forms.BindingSource tomatoBindingSource;
        private ManagementDataSetTableAdapters.tomatoTableAdapter tomatoTableAdapter;
        private ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tomatoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tomatoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdlenthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdcounterDataGridViewTextBoxColumn;
    }
}
