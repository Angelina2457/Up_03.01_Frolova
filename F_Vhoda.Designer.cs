namespace AIS_Org_Teh
{
    partial class F_Vhoda
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
            this.b_vhod = new System.Windows.Forms.Button();
            this.b_otmena = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.tb_parol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_vhod
            // 
            this.b_vhod.Location = new System.Drawing.Point(48, 182);
            this.b_vhod.Name = "b_vhod";
            this.b_vhod.Size = new System.Drawing.Size(212, 46);
            this.b_vhod.TabIndex = 0;
            this.b_vhod.Text = "Войти";
            this.b_vhod.UseVisualStyleBackColor = true;
            this.b_vhod.Click += new System.EventHandler(this.b_vhod_Click);
            // 
            // b_otmena
            // 
            this.b_otmena.Location = new System.Drawing.Point(48, 247);
            this.b_otmena.Name = "b_otmena";
            this.b_otmena.Size = new System.Drawing.Size(212, 46);
            this.b_otmena.TabIndex = 1;
            this.b_otmena.Text = "Отмена";
            this.b_otmena.UseVisualStyleBackColor = true;
            // 
            // tb_log
            // 
            this.tb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_log.Location = new System.Drawing.Point(107, 80);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(162, 26);
            this.tb_log.TabIndex = 2;
            // 
            // tb_parol
            // 
            this.tb_parol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_parol.Location = new System.Drawing.Point(104, 136);
            this.tb_parol.Multiline = true;
            this.tb_parol.Name = "tb_parol";
            this.tb_parol.Size = new System.Drawing.Size(165, 26);
            this.tb_parol.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите логин и пароль";
            // 
            // F_Vhoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_parol);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.b_otmena);
            this.Controls.Add(this.b_vhod);
            this.Name = "F_Vhoda";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_vhod;
        private System.Windows.Forms.Button b_otmena;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.TextBox tb_parol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

