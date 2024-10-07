namespace AIS_Org_Teh
{
    partial class F_Teh
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
            this.dGV_teh = new System.Windows.Forms.DataGridView();
            this.aIS_Org_Teh_full_DataSet = new AIS_Org_Teh.AIS_Org_Teh_full_DataSet();
            this.tehnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tehnicaTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.TehnicaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZayavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnicaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_teh
            // 
            this.dGV_teh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_teh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_teh.Location = new System.Drawing.Point(26, 36);
            this.dGV_teh.Name = "dGV_teh";
            this.dGV_teh.Size = new System.Drawing.Size(934, 228);
            this.dGV_teh.TabIndex = 4;
            // 
            // aIS_Org_Teh_full_DataSet
            // 
            this.aIS_Org_Teh_full_DataSet.DataSetName = "AIS_Org_Teh_full_DataSet";
            this.aIS_Org_Teh_full_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tehnicaBindingSource
            // 
            this.tehnicaBindingSource.DataMember = "Tehnica";
            this.tehnicaBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // tehnicaTableAdapter
            // 
            this.tehnicaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZayavToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // ZayavToolStripMenuItem
            // 
            this.ZayavToolStripMenuItem.Name = "ZayavToolStripMenuItem";
            this.ZayavToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ZayavToolStripMenuItem.Text = "Заявки";
            this.ZayavToolStripMenuItem.Click += new System.EventHandler(this.ZayavToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // F_Teh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 286);
            this.Controls.Add(this.dGV_teh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Teh";
            this.Text = "Оргтехника";
            this.Load += new System.EventHandler(this.F_Teh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnicaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGV_teh;
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource tehnicaBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.TehnicaTableAdapter tehnicaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZayavToolStripMenuItem;
    }
}