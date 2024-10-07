namespace AIS_Org_Teh
{
    partial class F_Add_Teh
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
            this.tb_ID_Teh = new System.Windows.Forms.TextBox();
            this.tb_inv = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.tb_srok = new System.Windows.Forms.TextBox();
            this.cb_FIO = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIS_Org_Teh_full_DataSet = new AIS_Org_Teh.AIS_Org_Teh_full_DataSet();
            this.cb_Model = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Cabinet = new System.Windows.Forms.ComboBox();
            this.cabinetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_dob = new System.Windows.Forms.Button();
            this.b_otm = new System.Windows.Forms.Button();
            this.sotrudnikTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.SotrudnikTableAdapter();
            this.modelTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.ModelTableAdapter();
            this.cabinetTableAdapter = new AIS_Org_Teh.AIS_Org_Teh_full_DataSetTableAdapters.CabinetTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ID_Teh
            // 
            this.tb_ID_Teh.Location = new System.Drawing.Point(207, 40);
            this.tb_ID_Teh.Name = "tb_ID_Teh";
            this.tb_ID_Teh.Size = new System.Drawing.Size(62, 20);
            this.tb_ID_Teh.TabIndex = 0;
            // 
            // tb_inv
            // 
            this.tb_inv.Location = new System.Drawing.Point(207, 185);
            this.tb_inv.Name = "tb_inv";
            this.tb_inv.Size = new System.Drawing.Size(186, 20);
            this.tb_inv.TabIndex = 4;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(207, 221);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(138, 20);
            this.tb_data.TabIndex = 5;
            // 
            // tb_cena
            // 
            this.tb_cena.Location = new System.Drawing.Point(207, 258);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.Size = new System.Drawing.Size(138, 20);
            this.tb_cena.TabIndex = 6;
            // 
            // tb_srok
            // 
            this.tb_srok.Location = new System.Drawing.Point(207, 293);
            this.tb_srok.Name = "tb_srok";
            this.tb_srok.Size = new System.Drawing.Size(138, 20);
            this.tb_srok.TabIndex = 7;
            // 
            // cb_FIO
            // 
            this.cb_FIO.DataSource = this.sotrudnikBindingSource;
            this.cb_FIO.DisplayMember = "FIO";
            this.cb_FIO.FormattingEnabled = true;
            this.cb_FIO.Location = new System.Drawing.Point(207, 75);
            this.cb_FIO.Name = "cb_FIO";
            this.cb_FIO.Size = new System.Drawing.Size(186, 21);
            this.cb_FIO.TabIndex = 8;
            this.cb_FIO.ValueMember = "ID_Sotr";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // aIS_Org_Teh_full_DataSet
            // 
            this.aIS_Org_Teh_full_DataSet.DataSetName = "AIS_Org_Teh_full_DataSet";
            this.aIS_Org_Teh_full_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Model
            // 
            this.cb_Model.DataSource = this.modelBindingSource;
            this.cb_Model.DisplayMember = "name";
            this.cb_Model.FormattingEnabled = true;
            this.cb_Model.Location = new System.Drawing.Point(207, 112);
            this.cb_Model.Name = "cb_Model";
            this.cb_Model.Size = new System.Drawing.Size(186, 21);
            this.cb_Model.TabIndex = 9;
            this.cb_Model.ValueMember = "ID_Mod";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // cb_Cabinet
            // 
            this.cb_Cabinet.DataSource = this.cabinetBindingSource;
            this.cb_Cabinet.DisplayMember = "number";
            this.cb_Cabinet.FormattingEnabled = true;
            this.cb_Cabinet.Location = new System.Drawing.Point(207, 148);
            this.cb_Cabinet.Name = "cb_Cabinet";
            this.cb_Cabinet.Size = new System.Drawing.Size(186, 21);
            this.cb_Cabinet.TabIndex = 10;
            this.cb_Cabinet.ValueMember = "ID_Cab";
            // 
            // cabinetBindingSource
            // 
            this.cabinetBindingSource.DataMember = "Cabinet";
            this.cabinetBindingSource.DataSource = this.aIS_Org_Teh_full_DataSet;
            // 
            // b_dob
            // 
            this.b_dob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dob.Location = new System.Drawing.Point(51, 357);
            this.b_dob.Name = "b_dob";
            this.b_dob.Size = new System.Drawing.Size(134, 39);
            this.b_dob.TabIndex = 11;
            this.b_dob.Text = "Добавить";
            this.b_dob.UseVisualStyleBackColor = true;
            this.b_dob.Click += new System.EventHandler(this.b_dob_Click);
            // 
            // b_otm
            // 
            this.b_otm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_otm.Location = new System.Drawing.Point(239, 356);
            this.b_otm.Name = "b_otm";
            this.b_otm.Size = new System.Drawing.Size(134, 40);
            this.b_otm.TabIndex = 12;
            this.b_otm.Text = "Отмена";
            this.b_otm.UseVisualStyleBackColor = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // cabinetTableAdapter
            // 
            this.cabinetTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Дата покупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Инвентарный номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(42, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кабинет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(42, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Срок годности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(42, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цена";
            // 
            // F_Add_Teh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_otm);
            this.Controls.Add(this.b_dob);
            this.Controls.Add(this.cb_Cabinet);
            this.Controls.Add(this.cb_Model);
            this.Controls.Add(this.cb_FIO);
            this.Controls.Add(this.tb_srok);
            this.Controls.Add(this.tb_cena);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_inv);
            this.Controls.Add(this.tb_ID_Teh);
            this.Name = "F_Add_Teh";
            this.Text = "Добавить данные";
            this.Load += new System.EventHandler(this.F_Add_Teh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIS_Org_Teh_full_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID_Teh;
        private System.Windows.Forms.TextBox tb_inv;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.TextBox tb_srok;
        private System.Windows.Forms.ComboBox cb_FIO;
        private System.Windows.Forms.ComboBox cb_Model;
        private System.Windows.Forms.ComboBox cb_Cabinet;
        private System.Windows.Forms.Button b_dob;
        private System.Windows.Forms.Button b_otm;
        private AIS_Org_Teh_full_DataSet aIS_Org_Teh_full_DataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource cabinetBindingSource;
        private AIS_Org_Teh_full_DataSetTableAdapters.CabinetTableAdapter cabinetTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}