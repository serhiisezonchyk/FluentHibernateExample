namespace FluentHibernateTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBUtilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPoliceman = new System.Windows.Forms.GroupBox();
            this.dataGridViewPoliceman = new System.Windows.Forms.DataGridView();
            this.ColumnIdPoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstNamePoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastNamePoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgePoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexPoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartmentPoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRankPoliceman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripPoliceman = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxIntruder = new System.Windows.Forms.GroupBox();
            this.dataGridViewIntruder = new System.Windows.Forms.DataGridView();
            this.ColumnIdIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstNameIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastNameIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgeIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescriptionIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPolicemanIntruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripIntruder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxPoliceman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliceman)).BeginInit();
            this.contextMenuStripPoliceman.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxIntruder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntruder)).BeginInit();
            this.contextMenuStripIntruder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBUtilToolStripMenuItem,
            this.infoPageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBUtilToolStripMenuItem
            // 
            this.dBUtilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.dBUtilToolStripMenuItem.Name = "dBUtilToolStripMenuItem";
            this.dBUtilToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.dBUtilToolStripMenuItem.Text = "DB util";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxPoliceman);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 422);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxPoliceman
            // 
            this.groupBoxPoliceman.Controls.Add(this.dataGridViewPoliceman);
            this.groupBoxPoliceman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPoliceman.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPoliceman.Name = "groupBoxPoliceman";
            this.groupBoxPoliceman.Size = new System.Drawing.Size(266, 422);
            this.groupBoxPoliceman.TabIndex = 0;
            this.groupBoxPoliceman.TabStop = false;
            this.groupBoxPoliceman.Text = "Policeman";
            // 
            // dataGridViewPoliceman
            // 
            this.dataGridViewPoliceman.AllowUserToAddRows = false;
            this.dataGridViewPoliceman.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPoliceman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoliceman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdPoliceman,
            this.ColumnFirstNamePoliceman,
            this.ColumnLastNamePoliceman,
            this.ColumnAgePoliceman,
            this.ColumnSexPoliceman,
            this.ColumnDepartmentPoliceman,
            this.ColumnRankPoliceman});
            this.dataGridViewPoliceman.ContextMenuStrip = this.contextMenuStripPoliceman;
            this.dataGridViewPoliceman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPoliceman.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewPoliceman.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewPoliceman.MultiSelect = false;
            this.dataGridViewPoliceman.Name = "dataGridViewPoliceman";
            this.dataGridViewPoliceman.ReadOnly = true;
            this.dataGridViewPoliceman.RowHeadersVisible = false;
            this.dataGridViewPoliceman.RowHeadersWidth = 51;
            this.dataGridViewPoliceman.RowTemplate.Height = 24;
            this.dataGridViewPoliceman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPoliceman.Size = new System.Drawing.Size(260, 401);
            this.dataGridViewPoliceman.TabIndex = 0;
            this.dataGridViewPoliceman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoliceman_CellContentClick);
            // 
            // ColumnIdPoliceman
            // 
            this.ColumnIdPoliceman.HeaderText = "ID";
            this.ColumnIdPoliceman.MinimumWidth = 6;
            this.ColumnIdPoliceman.Name = "ColumnIdPoliceman";
            this.ColumnIdPoliceman.ReadOnly = true;
            this.ColumnIdPoliceman.Width = 50;
            // 
            // ColumnFirstNamePoliceman
            // 
            this.ColumnFirstNamePoliceman.HeaderText = "First name";
            this.ColumnFirstNamePoliceman.MinimumWidth = 6;
            this.ColumnFirstNamePoliceman.Name = "ColumnFirstNamePoliceman";
            this.ColumnFirstNamePoliceman.ReadOnly = true;
            this.ColumnFirstNamePoliceman.Width = 125;
            // 
            // ColumnLastNamePoliceman
            // 
            this.ColumnLastNamePoliceman.HeaderText = "Last name";
            this.ColumnLastNamePoliceman.MinimumWidth = 6;
            this.ColumnLastNamePoliceman.Name = "ColumnLastNamePoliceman";
            this.ColumnLastNamePoliceman.ReadOnly = true;
            this.ColumnLastNamePoliceman.Width = 125;
            // 
            // ColumnAgePoliceman
            // 
            this.ColumnAgePoliceman.HeaderText = "Age";
            this.ColumnAgePoliceman.MinimumWidth = 6;
            this.ColumnAgePoliceman.Name = "ColumnAgePoliceman";
            this.ColumnAgePoliceman.ReadOnly = true;
            this.ColumnAgePoliceman.Width = 125;
            // 
            // ColumnSexPoliceman
            // 
            this.ColumnSexPoliceman.HeaderText = "Sex";
            this.ColumnSexPoliceman.MinimumWidth = 6;
            this.ColumnSexPoliceman.Name = "ColumnSexPoliceman";
            this.ColumnSexPoliceman.ReadOnly = true;
            this.ColumnSexPoliceman.Width = 125;
            // 
            // ColumnDepartmentPoliceman
            // 
            this.ColumnDepartmentPoliceman.HeaderText = "Department";
            this.ColumnDepartmentPoliceman.MinimumWidth = 6;
            this.ColumnDepartmentPoliceman.Name = "ColumnDepartmentPoliceman";
            this.ColumnDepartmentPoliceman.ReadOnly = true;
            this.ColumnDepartmentPoliceman.Width = 125;
            // 
            // ColumnRankPoliceman
            // 
            this.ColumnRankPoliceman.HeaderText = "Rank";
            this.ColumnRankPoliceman.MinimumWidth = 6;
            this.ColumnRankPoliceman.Name = "ColumnRankPoliceman";
            this.ColumnRankPoliceman.ReadOnly = true;
            this.ColumnRankPoliceman.Width = 125;
            // 
            // contextMenuStripPoliceman
            // 
            this.contextMenuStripPoliceman.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPoliceman.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripPoliceman.Name = "contextMenuStripPoliceman";
            this.contextMenuStripPoliceman.Size = new System.Drawing.Size(128, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxIntruder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 422);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxIntruder
            // 
            this.groupBoxIntruder.Controls.Add(this.dataGridViewIntruder);
            this.groupBoxIntruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIntruder.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIntruder.Name = "groupBoxIntruder";
            this.groupBoxIntruder.Size = new System.Drawing.Size(530, 422);
            this.groupBoxIntruder.TabIndex = 0;
            this.groupBoxIntruder.TabStop = false;
            this.groupBoxIntruder.Text = "Intruder";
            // 
            // dataGridViewIntruder
            // 
            this.dataGridViewIntruder.AllowUserToAddRows = false;
            this.dataGridViewIntruder.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewIntruder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntruder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdIntruder,
            this.ColumnFirstNameIntruder,
            this.ColumnLastNameIntruder,
            this.ColumnAgeIntruder,
            this.ColumnSexIntruder,
            this.ColumnDescriptionIntruder,
            this.ColumnPhoneIntruder,
            this.ColumnPolicemanIntruder});
            this.dataGridViewIntruder.ContextMenuStrip = this.contextMenuStripIntruder;
            this.dataGridViewIntruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIntruder.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewIntruder.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIntruder.MultiSelect = false;
            this.dataGridViewIntruder.Name = "dataGridViewIntruder";
            this.dataGridViewIntruder.ReadOnly = true;
            this.dataGridViewIntruder.RowHeadersVisible = false;
            this.dataGridViewIntruder.RowHeadersWidth = 51;
            this.dataGridViewIntruder.RowTemplate.Height = 24;
            this.dataGridViewIntruder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIntruder.Size = new System.Drawing.Size(524, 401);
            this.dataGridViewIntruder.TabIndex = 0;
            // 
            // ColumnIdIntruder
            // 
            this.ColumnIdIntruder.HeaderText = "ID";
            this.ColumnIdIntruder.MinimumWidth = 6;
            this.ColumnIdIntruder.Name = "ColumnIdIntruder";
            this.ColumnIdIntruder.ReadOnly = true;
            this.ColumnIdIntruder.Visible = false;
            this.ColumnIdIntruder.Width = 125;
            // 
            // ColumnFirstNameIntruder
            // 
            this.ColumnFirstNameIntruder.HeaderText = "First name";
            this.ColumnFirstNameIntruder.MinimumWidth = 6;
            this.ColumnFirstNameIntruder.Name = "ColumnFirstNameIntruder";
            this.ColumnFirstNameIntruder.ReadOnly = true;
            this.ColumnFirstNameIntruder.Width = 125;
            // 
            // ColumnLastNameIntruder
            // 
            this.ColumnLastNameIntruder.HeaderText = "Last name";
            this.ColumnLastNameIntruder.MinimumWidth = 6;
            this.ColumnLastNameIntruder.Name = "ColumnLastNameIntruder";
            this.ColumnLastNameIntruder.ReadOnly = true;
            this.ColumnLastNameIntruder.Width = 125;
            // 
            // ColumnAgeIntruder
            // 
            this.ColumnAgeIntruder.HeaderText = "Age";
            this.ColumnAgeIntruder.MinimumWidth = 6;
            this.ColumnAgeIntruder.Name = "ColumnAgeIntruder";
            this.ColumnAgeIntruder.ReadOnly = true;
            this.ColumnAgeIntruder.Width = 125;
            // 
            // ColumnSexIntruder
            // 
            this.ColumnSexIntruder.HeaderText = "Sex";
            this.ColumnSexIntruder.MinimumWidth = 6;
            this.ColumnSexIntruder.Name = "ColumnSexIntruder";
            this.ColumnSexIntruder.ReadOnly = true;
            this.ColumnSexIntruder.Width = 125;
            // 
            // ColumnDescriptionIntruder
            // 
            this.ColumnDescriptionIntruder.HeaderText = "Description";
            this.ColumnDescriptionIntruder.MinimumWidth = 6;
            this.ColumnDescriptionIntruder.Name = "ColumnDescriptionIntruder";
            this.ColumnDescriptionIntruder.ReadOnly = true;
            this.ColumnDescriptionIntruder.Width = 125;
            // 
            // ColumnPhoneIntruder
            // 
            this.ColumnPhoneIntruder.HeaderText = "Phone";
            this.ColumnPhoneIntruder.MinimumWidth = 6;
            this.ColumnPhoneIntruder.Name = "ColumnPhoneIntruder";
            this.ColumnPhoneIntruder.ReadOnly = true;
            this.ColumnPhoneIntruder.Width = 125;
            // 
            // ColumnPolicemanIntruder
            // 
            this.ColumnPolicemanIntruder.HeaderText = "Policeman";
            this.ColumnPolicemanIntruder.MinimumWidth = 6;
            this.ColumnPolicemanIntruder.Name = "ColumnPolicemanIntruder";
            this.ColumnPolicemanIntruder.ReadOnly = true;
            this.ColumnPolicemanIntruder.Width = 125;
            // 
            // contextMenuStripIntruder
            // 
            this.contextMenuStripIntruder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripIntruder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuStripIntruder.Name = "contextMenuStripIntruder";
            this.contextMenuStripIntruder.Size = new System.Drawing.Size(128, 76);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // infoPageToolStripMenuItem
            // 
            this.infoPageToolStripMenuItem.Name = "infoPageToolStripMenuItem";
            this.infoPageToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.infoPageToolStripMenuItem.Text = "Info page";
            this.infoPageToolStripMenuItem.Click += new System.EventHandler(this.infoPageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NHibernate test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxPoliceman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliceman)).EndInit();
            this.contextMenuStripPoliceman.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxIntruder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntruder)).EndInit();
            this.contextMenuStripIntruder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBUtilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPoliceman;
        private System.Windows.Forms.DataGridView dataGridViewPoliceman;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxIntruder;
        private System.Windows.Forms.DataGridView dataGridViewIntruder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPoliceman;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIntruder;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstNamePoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastNamePoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgePoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexPoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentPoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRankPoliceman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstNameIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastNameIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgeIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescriptionIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPolicemanIntruder;
        private System.Windows.Forms.ToolStripMenuItem infoPageToolStripMenuItem;
    }
}

