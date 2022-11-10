namespace OBKS_Blockchain
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
            this.button_create = new System.Windows.Forms.Button();
            this.button_nods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_nulls = new System.Windows.Forms.NumericUpDown();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_check_chain = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.check_ex_1 = new System.Windows.Forms.CheckBox();
            this.check_ex_2 = new System.Windows.Forms.CheckBox();
            this.check_ex_3 = new System.Windows.Forms.CheckBox();
            this.check_ex_4 = new System.Windows.Forms.CheckBox();
            this.check_ex_5 = new System.Windows.Forms.CheckBox();
            this.check_nod_5 = new System.Windows.Forms.CheckBox();
            this.check_nod_4 = new System.Windows.Forms.CheckBox();
            this.check_nod_3 = new System.Windows.Forms.CheckBox();
            this.check_nod_2 = new System.Windows.Forms.CheckBox();
            this.check_nod_1 = new System.Windows.Forms.CheckBox();
            this.check_chain_5 = new System.Windows.Forms.CheckBox();
            this.check_chain_4 = new System.Windows.Forms.CheckBox();
            this.check_chain_3 = new System.Windows.Forms.CheckBox();
            this.check_chain_2 = new System.Windows.Forms.CheckBox();
            this.check_chain_1 = new System.Windows.Forms.CheckBox();
            this.button_delete_chain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_nulls)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(26, 27);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(221, 23);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Создать исходные файлы";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_nods
            // 
            this.button_nods.Location = new System.Drawing.Point(26, 156);
            this.button_nods.Name = "button_nods";
            this.button_nods.Size = new System.Drawing.Size(221, 23);
            this.button_nods.TabIndex = 1;
            this.button_nods.Text = "Определить нодсы";
            this.button_nods.UseVisualStyleBackColor = true;
            this.button_nods.Click += new System.EventHandler(this.button_nods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество нулей в начале хэша";
            // 
            // num_nulls
            // 
            this.num_nulls.Location = new System.Drawing.Point(36, 115);
            this.num_nulls.Name = "num_nulls";
            this.num_nulls.Size = new System.Drawing.Size(120, 22);
            this.num_nulls.TabIndex = 14;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(161, 115);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 15;
            this.button_ok.Text = "Ок";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_check_chain
            // 
            this.button_check_chain.Location = new System.Drawing.Point(26, 215);
            this.button_check_chain.Name = "button_check_chain";
            this.button_check_chain.Size = new System.Drawing.Size(221, 51);
            this.button_check_chain.TabIndex = 16;
            this.button_check_chain.Text = "Проверить целостность цепочки";
            this.button_check_chain.UseVisualStyleBackColor = true;
            this.button_check_chain.Click += new System.EventHandler(this.button_check_chain_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(26, 310);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(221, 23);
            this.button_delete.TabIndex = 22;
            this.button_delete.Text = "Удалить исходные файлы";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // check_ex_1
            // 
            this.check_ex_1.AutoSize = true;
            this.check_ex_1.Enabled = false;
            this.check_ex_1.Location = new System.Drawing.Point(37, 56);
            this.check_ex_1.Name = "check_ex_1";
            this.check_ex_1.Size = new System.Drawing.Size(36, 20);
            this.check_ex_1.TabIndex = 23;
            this.check_ex_1.Text = "1";
            this.check_ex_1.UseVisualStyleBackColor = true;
            // 
            // check_ex_2
            // 
            this.check_ex_2.AutoSize = true;
            this.check_ex_2.Enabled = false;
            this.check_ex_2.Location = new System.Drawing.Point(76, 56);
            this.check_ex_2.Name = "check_ex_2";
            this.check_ex_2.Size = new System.Drawing.Size(36, 20);
            this.check_ex_2.TabIndex = 24;
            this.check_ex_2.Text = "2";
            this.check_ex_2.UseVisualStyleBackColor = true;
            // 
            // check_ex_3
            // 
            this.check_ex_3.AutoSize = true;
            this.check_ex_3.Enabled = false;
            this.check_ex_3.Location = new System.Drawing.Point(117, 56);
            this.check_ex_3.Name = "check_ex_3";
            this.check_ex_3.Size = new System.Drawing.Size(36, 20);
            this.check_ex_3.TabIndex = 25;
            this.check_ex_3.Text = "3";
            this.check_ex_3.UseVisualStyleBackColor = true;
            // 
            // check_ex_4
            // 
            this.check_ex_4.AutoSize = true;
            this.check_ex_4.Enabled = false;
            this.check_ex_4.Location = new System.Drawing.Point(158, 56);
            this.check_ex_4.Name = "check_ex_4";
            this.check_ex_4.Size = new System.Drawing.Size(36, 20);
            this.check_ex_4.TabIndex = 26;
            this.check_ex_4.Text = "4";
            this.check_ex_4.UseVisualStyleBackColor = true;
            // 
            // check_ex_5
            // 
            this.check_ex_5.AutoSize = true;
            this.check_ex_5.Enabled = false;
            this.check_ex_5.Location = new System.Drawing.Point(199, 56);
            this.check_ex_5.Name = "check_ex_5";
            this.check_ex_5.Size = new System.Drawing.Size(36, 20);
            this.check_ex_5.TabIndex = 27;
            this.check_ex_5.Text = "5";
            this.check_ex_5.UseVisualStyleBackColor = true;
            // 
            // check_nod_5
            // 
            this.check_nod_5.AutoSize = true;
            this.check_nod_5.Enabled = false;
            this.check_nod_5.Location = new System.Drawing.Point(199, 185);
            this.check_nod_5.Name = "check_nod_5";
            this.check_nod_5.Size = new System.Drawing.Size(36, 20);
            this.check_nod_5.TabIndex = 32;
            this.check_nod_5.Text = "5";
            this.check_nod_5.UseVisualStyleBackColor = true;
            // 
            // check_nod_4
            // 
            this.check_nod_4.AutoSize = true;
            this.check_nod_4.Enabled = false;
            this.check_nod_4.Location = new System.Drawing.Point(158, 185);
            this.check_nod_4.Name = "check_nod_4";
            this.check_nod_4.Size = new System.Drawing.Size(36, 20);
            this.check_nod_4.TabIndex = 31;
            this.check_nod_4.Text = "4";
            this.check_nod_4.UseVisualStyleBackColor = true;
            // 
            // check_nod_3
            // 
            this.check_nod_3.AutoSize = true;
            this.check_nod_3.Enabled = false;
            this.check_nod_3.Location = new System.Drawing.Point(117, 185);
            this.check_nod_3.Name = "check_nod_3";
            this.check_nod_3.Size = new System.Drawing.Size(36, 20);
            this.check_nod_3.TabIndex = 30;
            this.check_nod_3.Text = "3";
            this.check_nod_3.UseVisualStyleBackColor = true;
            // 
            // check_nod_2
            // 
            this.check_nod_2.AutoSize = true;
            this.check_nod_2.Enabled = false;
            this.check_nod_2.Location = new System.Drawing.Point(76, 185);
            this.check_nod_2.Name = "check_nod_2";
            this.check_nod_2.Size = new System.Drawing.Size(36, 20);
            this.check_nod_2.TabIndex = 29;
            this.check_nod_2.Text = "2";
            this.check_nod_2.UseVisualStyleBackColor = true;
            // 
            // check_nod_1
            // 
            this.check_nod_1.AutoSize = true;
            this.check_nod_1.Enabled = false;
            this.check_nod_1.Location = new System.Drawing.Point(37, 185);
            this.check_nod_1.Name = "check_nod_1";
            this.check_nod_1.Size = new System.Drawing.Size(36, 20);
            this.check_nod_1.TabIndex = 28;
            this.check_nod_1.Text = "1";
            this.check_nod_1.UseVisualStyleBackColor = true;
            // 
            // check_chain_5
            // 
            this.check_chain_5.AutoSize = true;
            this.check_chain_5.Enabled = false;
            this.check_chain_5.Location = new System.Drawing.Point(192, 272);
            this.check_chain_5.Name = "check_chain_5";
            this.check_chain_5.Size = new System.Drawing.Size(47, 20);
            this.check_chain_5.TabIndex = 37;
            this.check_chain_5.Text = "4-5";
            this.check_chain_5.UseVisualStyleBackColor = true;
            // 
            // check_chain_4
            // 
            this.check_chain_4.AutoSize = true;
            this.check_chain_4.Enabled = false;
            this.check_chain_4.Location = new System.Drawing.Point(139, 272);
            this.check_chain_4.Name = "check_chain_4";
            this.check_chain_4.Size = new System.Drawing.Size(47, 20);
            this.check_chain_4.TabIndex = 36;
            this.check_chain_4.Text = "3-4";
            this.check_chain_4.UseVisualStyleBackColor = true;
            // 
            // check_chain_3
            // 
            this.check_chain_3.AutoSize = true;
            this.check_chain_3.Enabled = false;
            this.check_chain_3.Location = new System.Drawing.Point(86, 272);
            this.check_chain_3.Name = "check_chain_3";
            this.check_chain_3.Size = new System.Drawing.Size(47, 20);
            this.check_chain_3.TabIndex = 35;
            this.check_chain_3.Text = "2-3";
            this.check_chain_3.UseVisualStyleBackColor = true;
            // 
            // check_chain_2
            // 
            this.check_chain_2.AutoSize = true;
            this.check_chain_2.Enabled = false;
            this.check_chain_2.Location = new System.Drawing.Point(33, 272);
            this.check_chain_2.Name = "check_chain_2";
            this.check_chain_2.Size = new System.Drawing.Size(47, 20);
            this.check_chain_2.TabIndex = 34;
            this.check_chain_2.Text = "1-2";
            this.check_chain_2.UseVisualStyleBackColor = true;
            // 
            // check_chain_1
            // 
            this.check_chain_1.AutoSize = true;
            this.check_chain_1.Enabled = false;
            this.check_chain_1.Location = new System.Drawing.Point(26, 246);
            this.check_chain_1.Name = "check_chain_1";
            this.check_chain_1.Size = new System.Drawing.Size(36, 20);
            this.check_chain_1.TabIndex = 33;
            this.check_chain_1.Text = "1";
            this.check_chain_1.UseVisualStyleBackColor = true;
            this.check_chain_1.Visible = false;
            // 
            // button_delete_chain
            // 
            this.button_delete_chain.Location = new System.Drawing.Point(26, 339);
            this.button_delete_chain.Name = "button_delete_chain";
            this.button_delete_chain.Size = new System.Drawing.Size(221, 23);
            this.button_delete_chain.TabIndex = 38;
            this.button_delete_chain.Text = "Удалить файлы цепочки";
            this.button_delete_chain.UseVisualStyleBackColor = true;
            this.button_delete_chain.Click += new System.EventHandler(this.button_delete_chain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 389);
            this.Controls.Add(this.button_delete_chain);
            this.Controls.Add(this.check_chain_5);
            this.Controls.Add(this.check_chain_4);
            this.Controls.Add(this.check_chain_3);
            this.Controls.Add(this.check_chain_2);
            this.Controls.Add(this.check_nod_5);
            this.Controls.Add(this.check_nod_4);
            this.Controls.Add(this.check_nod_3);
            this.Controls.Add(this.check_nod_2);
            this.Controls.Add(this.check_nod_1);
            this.Controls.Add(this.check_ex_5);
            this.Controls.Add(this.check_ex_4);
            this.Controls.Add(this.check_ex_3);
            this.Controls.Add(this.check_ex_2);
            this.Controls.Add(this.check_ex_1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_check_chain);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.num_nulls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_nods);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.check_chain_1);
            this.Name = "Form1";
            this.Text = "Блокчейн";
            ((System.ComponentModel.ISupportInitialize)(this.num_nulls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_nods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_nulls;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_check_chain;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.CheckBox check_ex_1;
        private System.Windows.Forms.CheckBox check_ex_2;
        private System.Windows.Forms.CheckBox check_ex_3;
        private System.Windows.Forms.CheckBox check_ex_4;
        private System.Windows.Forms.CheckBox check_ex_5;
        private System.Windows.Forms.CheckBox check_nod_5;
        private System.Windows.Forms.CheckBox check_nod_4;
        private System.Windows.Forms.CheckBox check_nod_3;
        private System.Windows.Forms.CheckBox check_nod_2;
        private System.Windows.Forms.CheckBox check_nod_1;
        private System.Windows.Forms.CheckBox check_chain_5;
        private System.Windows.Forms.CheckBox check_chain_4;
        private System.Windows.Forms.CheckBox check_chain_3;
        private System.Windows.Forms.CheckBox check_chain_2;
        private System.Windows.Forms.CheckBox check_chain_1;
        private System.Windows.Forms.Button button_delete_chain;
    }
}

