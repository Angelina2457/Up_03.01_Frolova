namespace AIS_Org_Teh
{
    partial class F_Zayavki
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
            this.b_del = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_dobav = new System.Windows.Forms.Button();
            this.dGV_teh = new System.Windows.Forms.DataGridView();
            this.menu_strip_org_teh = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TehToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VihodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIS_Org_Teh_full_DataSet = new AIS_Org_Teh.AIS_Org_Teh_full_DataSet();
            this.zayavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayavkiTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.ZayavkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).BeginInit();
            this.menu_strip_org_teh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(464, 286);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(198, 48);
            this.b_del.TabIndex = 13;
            this.b_del.Text = "Удалить";
            this.b_del.UseVisualStyleBackColor = true;
            // 
            // b_red
            // 
            this.b_red.Location = new System.Drawing.Point(243, 286);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(198, 48);
            this.b_red.TabIndex = 12;
            this.b_red.Text = "Редактировать";
            this.b_red.UseVisualStyleBackColor = true;
            // 
            // b_dobav
            // 
            this.b_dobav.Location = new System.Drawing.Point(19, 286);
            this.b_dobav.Name = "b_dobav";
            this.b_dobav.Size = new System.Drawing.Size(198, 48);
            this.b_dobav.TabIndex = 11;
            this.b_dobav.Text = "Добавить";
            this.b_dobav.UseVisualStyleBackColor = true;
            // 
            // dGV_teh
            // 
            this.dGV_teh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_teh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_teh.Location = new System.Drawing.Point(56, 39);
            this.dGV_teh.Name = "dGV_teh";
            this.dGV_teh.Size = new System.Drawing.Size(569, 228);
            this.dGV_teh.TabIndex = 10;
            // 
            // menu_strip_org_teh
            // 
            this.menu_strip_org_teh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menu_strip_org_teh.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_org_teh.Name = "menu_strip_org_teh";
            this.menu_strip_org_teh.Size = new System.Drawing.Size(694, 24);
            this.menu_strip_org_teh.TabIndex = 14;
            this.menu_strip_org_teh.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.VihodToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TehToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // TehToolStripMenuItem
            // 
            this.TehToolStripMenuItem.Name = "TehToolStripMenuItem";
            this.TehToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TehToolStripMenuItem.Text = "Оргтехника";
            this.TehToolStripMenuItem.Click += new System.EventHandler(this.TehToolStripMenuItem_Click);
            // 
            // VihodToolStripMenuItem
            // 
            this.VihodToolStripMenuItem.Name = "VihodToolStripMenuItem";
            this.VihodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VihodToolStripMenuItem.Text = "Выйти";
            // 
            // aIS_Org_Teh_full_DataSet
            // 
            this.aIS_Org_Teh_full_DataSet.DataSetName = "AIS_Org_Teh_full_DataSet";
            this.aIS_Org_Teh_full_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavkiBindingSource
            // 
            this.zayavkiBindingSource.DataMember = "Zayavki";
            this.zayavkiBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // zayavkiTableAdapter
            // 
            this.zayavkiTableAdapter.ClearBeforeFill = true;
            // 
            // F_Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 375);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.b_red);
            this.Controls.Add(this.b_dobav);
            this.Controls.Add(this.dGV_teh);
            this.Controls.Add(this.menu_strip_org_teh);
            this.Name = "F_Zayavki";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.F_Zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).EndInit();
            this.menu_strip_org_teh.ResumeLayout(false);
            this.menu_strip_org_teh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_dobav;
        public System.Windows.Forms.DataGridView dGV_teh;
        private System.Windows.Forms.MenuStrip menu_strip_org_teh;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TehToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VihodToolStripMenuItem;
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource zayavkiBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.ZayavkiTableAdapter zayavkiTableAdapter;
    }
}