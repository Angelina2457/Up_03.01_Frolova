namespace AIS_Org_Teh
{
    partial class F_Sotr_adm
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
            this.dGV_Sotr = new System.Windows.Forms.DataGridView();
            this.b_del = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_dobav = new System.Windows.Forms.Button();
            this.aIS_Org_Teh_full_DataSet = new AIS_Org_Teh.AIS_Org_Teh_full_DataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.SotrudnikTableAdapter();
            this.menu_strip_org_teh = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TehToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParametrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProizvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VihodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.menu_strip_org_teh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Sotr
            // 
            this.dGV_Sotr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_Sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Sotr.Location = new System.Drawing.Point(31, 54);
            this.dGV_Sotr.Name = "dGV_Sotr";
            this.dGV_Sotr.Size = new System.Drawing.Size(743, 218);
            this.dGV_Sotr.TabIndex = 0;
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(476, 306);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(198, 48);
            this.b_del.TabIndex = 6;
            this.b_del.Text = "Удалить";
            this.b_del.UseVisualStyleBackColor = true;
            // 
            // b_red
            // 
            this.b_red.Location = new System.Drawing.Point(255, 306);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(198, 48);
            this.b_red.TabIndex = 5;
            this.b_red.Text = "Редактировать";
            this.b_red.UseVisualStyleBackColor = true;
            this.b_red.Click += new System.EventHandler(this.b_red_Click);
            // 
            // b_dobav
            // 
            this.b_dobav.Location = new System.Drawing.Point(31, 306);
            this.b_dobav.Name = "b_dobav";
            this.b_dobav.Size = new System.Drawing.Size(198, 48);
            this.b_dobav.TabIndex = 4;
            this.b_dobav.Text = "Добавить";
            this.b_dobav.UseVisualStyleBackColor = true;
            this.b_dobav.Click += new System.EventHandler(this.b_dobav_Click);
            // 
            // aIS_Org_Teh_full_DataSet
            // 
            this.aIS_Org_Teh_full_DataSet.DataSetName = "AIS_Org_Teh_full_DataSet";
            this.aIS_Org_Teh_full_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // menu_strip_org_teh
            // 
            this.menu_strip_org_teh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menu_strip_org_teh.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_org_teh.Name = "menu_strip_org_teh";
            this.menu_strip_org_teh.Size = new System.Drawing.Size(800, 24);
            this.menu_strip_org_teh.TabIndex = 13;
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
            this.TehToolStripMenuItem,
            this.ModelToolStripMenuItem,
            this.ParametrToolStripMenuItem,
            this.VidToolStripMenuItem,
            this.ProizvToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // TehToolStripMenuItem
            // 
            this.TehToolStripMenuItem.Name = "TehToolStripMenuItem";
            this.TehToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.TehToolStripMenuItem.Text = "Оргтехника";
            this.TehToolStripMenuItem.Click += new System.EventHandler(this.TehToolStripMenuItem_Click);
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ModelToolStripMenuItem.Text = "Модели";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // ParametrToolStripMenuItem
            // 
            this.ParametrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpParamToolStripMenuItem});
            this.ParametrToolStripMenuItem.Name = "ParametrToolStripMenuItem";
            this.ParametrToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ParametrToolStripMenuItem.Text = "Параметры";
            this.ParametrToolStripMenuItem.Click += new System.EventHandler(this.ParametrToolStripMenuItem_Click);
            // 
            // SpParamToolStripMenuItem
            // 
            this.SpParamToolStripMenuItem.Name = "SpParamToolStripMenuItem";
            this.SpParamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SpParamToolStripMenuItem.Text = "Список параметров";
            this.SpParamToolStripMenuItem.Click += new System.EventHandler(this.SpParamToolStripMenuItem_Click);
            // 
            // VidToolStripMenuItem
            // 
            this.VidToolStripMenuItem.Name = "VidToolStripMenuItem";
            this.VidToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.VidToolStripMenuItem.Text = "Виды техники";
            this.VidToolStripMenuItem.Click += new System.EventHandler(this.VidToolStripMenuItem_Click);
            // 
            // ProizvToolStripMenuItem
            // 
            this.ProizvToolStripMenuItem.Name = "ProizvToolStripMenuItem";
            this.ProizvToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ProizvToolStripMenuItem.Text = "Производители";
            this.ProizvToolStripMenuItem.Click += new System.EventHandler(this.ProizvToolStripMenuItem_Click);
            // 
            // VihodToolStripMenuItem
            // 
            this.VihodToolStripMenuItem.Name = "VihodToolStripMenuItem";
            this.VihodToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.VihodToolStripMenuItem.Text = "Выйти";
            // 
            // F_Sotr_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.menu_strip_org_teh);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.b_red);
            this.Controls.Add(this.b_dobav);
            this.Controls.Add(this.dGV_Sotr);
            this.Name = "F_Sotr_adm";
            this.Text = "Сотрудники (Администратор)";
            this.Load += new System.EventHandler(this.F_Sotr_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.menu_strip_org_teh.ResumeLayout(false);
            this.menu_strip_org_teh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_dobav;
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.MenuStrip menu_strip_org_teh;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TehToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParametrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProizvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VihodToolStripMenuItem;
        public System.Windows.Forms.DataGridView dGV_Sotr;
    }
}