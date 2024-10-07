namespace AIS_Org_Teh
{
    partial class F_Teh_adm
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
            this.b_dobav = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_del = new System.Windows.Forms.Button();
            this.menu_strip_org_teh = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SotrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParametrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VidТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProizvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VihodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_del = new System.Windows.Forms.TextBox();
            this.ZayavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnicaBindingSource)).BeginInit();
            this.menu_strip_org_teh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_teh
            // 
            this.dGV_teh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_teh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_teh.Location = new System.Drawing.Point(26, 31);
            this.dGV_teh.Name = "dGV_teh";
            this.dGV_teh.Size = new System.Drawing.Size(934, 228);
            this.dGV_teh.TabIndex = 0;
            this.dGV_teh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGV_teh_MouseClick);
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
            // b_dobav
            // 
            this.b_dobav.Location = new System.Drawing.Point(27, 281);
            this.b_dobav.Name = "b_dobav";
            this.b_dobav.Size = new System.Drawing.Size(198, 48);
            this.b_dobav.TabIndex = 1;
            this.b_dobav.Text = "Добавить";
            this.b_dobav.UseVisualStyleBackColor = true;
            this.b_dobav.Click += new System.EventHandler(this.b_dobav_Click);
            // 
            // b_red
            // 
            this.b_red.Location = new System.Drawing.Point(251, 281);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(198, 48);
            this.b_red.TabIndex = 2;
            this.b_red.Text = "Редактировать";
            this.b_red.UseVisualStyleBackColor = true;
            this.b_red.Click += new System.EventHandler(this.b_red_Click);
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(472, 281);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(198, 48);
            this.b_del.TabIndex = 3;
            this.b_del.Text = "Удалить";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // menu_strip_org_teh
            // 
            this.menu_strip_org_teh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menu_strip_org_teh.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_org_teh.Name = "menu_strip_org_teh";
            this.menu_strip_org_teh.Size = new System.Drawing.Size(990, 24);
            this.menu_strip_org_teh.TabIndex = 4;
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
            this.SotrToolStripMenuItem,
            this.ModelToolStripMenuItem,
            this.ParametrToolStripMenuItem,
            this.VidТехникиToolStripMenuItem,
            this.ProizvToolStripMenuItem,
            this.ZayavToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // SotrToolStripMenuItem
            // 
            this.SotrToolStripMenuItem.Name = "SotrToolStripMenuItem";
            this.SotrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SotrToolStripMenuItem.Text = "Сотрудники";
            this.SotrToolStripMenuItem.Click += new System.EventHandler(this.SotrToolStripMenuItem_Click);
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModelToolStripMenuItem.Text = "Модели";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // ParametrToolStripMenuItem
            // 
            this.ParametrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpParamToolStripMenuItem});
            this.ParametrToolStripMenuItem.Name = "ParametrToolStripMenuItem";
            this.ParametrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ParametrToolStripMenuItem.Text = "Параметры";
            this.ParametrToolStripMenuItem.Click += new System.EventHandler(this.ParametrToolStripMenuItem_Click);
            this.ParametrToolStripMenuItem.DoubleClick += new System.EventHandler(this.ParametrToolStripMenuItem_DoubleClick);
            // 
            // SpParamToolStripMenuItem
            // 
            this.SpParamToolStripMenuItem.Name = "SpParamToolStripMenuItem";
            this.SpParamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SpParamToolStripMenuItem.Text = "Список параметров";
            this.SpParamToolStripMenuItem.Click += new System.EventHandler(this.SpParamToolStripMenuItem_Click);
            // 
            // VidТехникиToolStripMenuItem
            // 
            this.VidТехникиToolStripMenuItem.Name = "VidТехникиToolStripMenuItem";
            this.VidТехникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VidТехникиToolStripMenuItem.Text = "Виды техники";
            this.VidТехникиToolStripMenuItem.Click += new System.EventHandler(this.VidТехникиToolStripMenuItem_Click);
            // 
            // ProizvToolStripMenuItem
            // 
            this.ProizvToolStripMenuItem.Name = "ProizvToolStripMenuItem";
            this.ProizvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProizvToolStripMenuItem.Text = "Производители";
            this.ProizvToolStripMenuItem.Click += new System.EventHandler(this.производителиToolStripMenuItem_Click);
            // 
            // VihodToolStripMenuItem
            // 
            this.VihodToolStripMenuItem.Name = "VihodToolStripMenuItem";
            this.VihodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VihodToolStripMenuItem.Text = "Выйти";
            this.VihodToolStripMenuItem.Click += new System.EventHandler(this.VihodToolStripMenuItem_Click);
            // 
            // tb_del
            // 
            this.tb_del.Location = new System.Drawing.Point(1012, 281);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(100, 20);
            this.tb_del.TabIndex = 5;
            // 
            // ZayavToolStripMenuItem
            // 
            this.ZayavToolStripMenuItem.Name = "ZayavToolStripMenuItem";
            this.ZayavToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ZayavToolStripMenuItem.Text = "Заявки";
            this.ZayavToolStripMenuItem.Click += new System.EventHandler(this.ZayavToolStripMenuItem_Click);
            // 
            // F_Teh_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 370);
            this.Controls.Add(this.tb_del);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.b_red);
            this.Controls.Add(this.b_dobav);
            this.Controls.Add(this.dGV_teh);
            this.Controls.Add(this.menu_strip_org_teh);
            this.MainMenuStrip = this.menu_strip_org_teh;
            this.Name = "F_Teh_adm";
            this.Text = "Оргтехника (Администратор)";
            this.Load += new System.EventHandler(this.F_Teh_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnicaBindingSource)).EndInit();
            this.menu_strip_org_teh.ResumeLayout(false);
            this.menu_strip_org_teh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource tehnicaBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.TehnicaTableAdapter tehnicaTableAdapter;
        private System.Windows.Forms.Button b_dobav;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.MenuStrip menu_strip_org_teh;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VihodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SotrToolStripMenuItem;
        public System.Windows.Forms.DataGridView dGV_teh;
        private System.Windows.Forms.TextBox tb_del;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParametrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VidТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProizvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZayavToolStripMenuItem;
    }
}