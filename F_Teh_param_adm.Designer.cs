﻿namespace AIS_Org_Teh
{
    partial class F_Teh_param_adm
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
            this.dGV_teh_p = new System.Windows.Forms.DataGridView();
            this.aIS_Org_Teh_full_DataSet = new AIS_Org_Teh.AIS_Org_Teh_full_DataSet();
            this.tehparameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teh_parameterTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.Teh_parameterTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehparameterBindingSource)).BeginInit();
            this.menu_strip_org_teh.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(451, 184);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(198, 48);
            this.b_del.TabIndex = 8;
            this.b_del.Text = "Удалить";
            this.b_del.UseVisualStyleBackColor = true;
            // 
            // b_red
            // 
            this.b_red.Location = new System.Drawing.Point(451, 116);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(198, 48);
            this.b_red.TabIndex = 7;
            this.b_red.Text = "Редактировать";
            this.b_red.UseVisualStyleBackColor = true;
            // 
            // b_dobav
            // 
            this.b_dobav.Location = new System.Drawing.Point(451, 46);
            this.b_dobav.Name = "b_dobav";
            this.b_dobav.Size = new System.Drawing.Size(198, 48);
            this.b_dobav.TabIndex = 6;
            this.b_dobav.Text = "Добавить";
            this.b_dobav.UseVisualStyleBackColor = true;
            // 
            // dGV_teh_p
            // 
            this.dGV_teh_p.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_teh_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_teh_p.Location = new System.Drawing.Point(12, 46);
            this.dGV_teh_p.Name = "dGV_teh_p";
            this.dGV_teh_p.Size = new System.Drawing.Size(398, 187);
            this.dGV_teh_p.TabIndex = 5;
            // 
            // aIS_Org_Teh_full_DataSet
            // 
            this.aIS_Org_Teh_full_DataSet.DataSetName = "AIS_Org_Teh_full_DataSet";
            this.aIS_Org_Teh_full_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tehparameterBindingSource
            // 
            this.tehparameterBindingSource.DataMember = "Teh_parameter";
            this.tehparameterBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // teh_parameterTableAdapter
            // 
            this.teh_parameterTableAdapter.ClearBeforeFill = true;
            // 
            // menu_strip_org_teh
            // 
            this.menu_strip_org_teh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menu_strip_org_teh.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_org_teh.Name = "menu_strip_org_teh";
            this.menu_strip_org_teh.Size = new System.Drawing.Size(684, 24);
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
            this.SotrToolStripMenuItem,
            this.ModelToolStripMenuItem,
            this.ParametrToolStripMenuItem,
            this.VidТехникиToolStripMenuItem,
            this.ProizvToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // SotrToolStripMenuItem
            // 
            this.SotrToolStripMenuItem.Name = "SotrToolStripMenuItem";
            this.SotrToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.SotrToolStripMenuItem.Text = "Сотрудники";
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ModelToolStripMenuItem.Text = "Модели";
            // 
            // ParametrToolStripMenuItem
            // 
            this.ParametrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpParamToolStripMenuItem});
            this.ParametrToolStripMenuItem.Name = "ParametrToolStripMenuItem";
            this.ParametrToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ParametrToolStripMenuItem.Text = "Параметры";
            // 
            // SpParamToolStripMenuItem
            // 
            this.SpParamToolStripMenuItem.Name = "SpParamToolStripMenuItem";
            this.SpParamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SpParamToolStripMenuItem.Text = "Список параметров";
            // 
            // VidТехникиToolStripMenuItem
            // 
            this.VidТехникиToolStripMenuItem.Name = "VidТехникиToolStripMenuItem";
            this.VidТехникиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.VidТехникиToolStripMenuItem.Text = "Виды техники";
            // 
            // ProizvToolStripMenuItem
            // 
            this.ProizvToolStripMenuItem.Name = "ProizvToolStripMenuItem";
            this.ProizvToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ProizvToolStripMenuItem.Text = "Производители";
            // 
            // VihodToolStripMenuItem
            // 
            this.VihodToolStripMenuItem.Name = "VihodToolStripMenuItem";
            this.VihodToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.VihodToolStripMenuItem.Text = "Выйти";
            // 
            // F_Teh_param_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 278);
            this.Controls.Add(this.menu_strip_org_teh);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.b_red);
            this.Controls.Add(this.b_dobav);
            this.Controls.Add(this.dGV_teh_p);
            this.Name = "F_Teh_param_adm";
            this.Text = "Параметры техники (Администратор)";
            this.Load += new System.EventHandler(this.F_Teh_param_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_teh_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehparameterBindingSource)).EndInit();
            this.menu_strip_org_teh.ResumeLayout(false);
            this.menu_strip_org_teh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_dobav;
        public System.Windows.Forms.DataGridView dGV_teh_p;
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource tehparameterBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.Teh_parameterTableAdapter teh_parameterTableAdapter;
        private System.Windows.Forms.MenuStrip menu_strip_org_teh;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SotrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParametrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VidТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProizvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VihodToolStripMenuItem;
    }
}