namespace igra_kakoeto
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
            this.world_map = new System.Windows.Forms.PictureBox();
            this.player_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Game_butt = new System.Windows.Forms.Button();
            this.Mailn_lbl = new System.Windows.Forms.Label();
            this.Contin_butt = new System.Windows.Forms.Button();
            this.Settings_butt = new System.Windows.Forms.Button();
            this.Exit_butt = new System.Windows.Forms.Button();
            this.setting_lbl = new System.Windows.Forms.Label();
            this.window_type_box = new System.Windows.Forms.ComboBox();
            this.form_lbl = new System.Windows.Forms.Label();
            this.size_lbl = new System.Windows.Forms.Label();
            this.window_size_box = new System.Windows.Forms.ComboBox();
            this.accept_set_butt = new System.Windows.Forms.Button();
            this.back_sett_but = new System.Windows.Forms.Button();
            this.save_lbl = new System.Windows.Forms.Label();
            this.one_save_butt = new System.Windows.Forms.Button();
            this.two_save_butt = new System.Windows.Forms.Button();
            this.tree_save_butt = new System.Windows.Forms.Button();
            this.four_save_butt = new System.Windows.Forms.Button();
            this.five_save_butt = new System.Windows.Forms.Button();
            this.back_load_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.world_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).BeginInit();
            this.SuspendLayout();
            // 
            // world_map
            // 
            this.world_map.Location = new System.Drawing.Point(956, 12);
            this.world_map.Name = "world_map";
            this.world_map.Size = new System.Drawing.Size(100, 50);
            this.world_map.TabIndex = 0;
            this.world_map.TabStop = false;
            // 
            // player_box
            // 
            this.player_box.Location = new System.Drawing.Point(1020, 68);
            this.player_box.Name = "player_box";
            this.player_box.Size = new System.Drawing.Size(36, 33);
            this.player_box.TabIndex = 1;
            this.player_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Start_Game_butt
            // 
            this.Start_Game_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Start_Game_butt.Location = new System.Drawing.Point(732, 68);
            this.Start_Game_butt.Name = "Start_Game_butt";
            this.Start_Game_butt.Size = new System.Drawing.Size(151, 37);
            this.Start_Game_butt.TabIndex = 3;
            this.Start_Game_butt.Text = "Начать игру ";
            this.Start_Game_butt.UseVisualStyleBackColor = true;
            this.Start_Game_butt.Click += new System.EventHandler(this.Start_Game_butt_Click);
            // 
            // Mailn_lbl
            // 
            this.Mailn_lbl.AutoSize = true;
            this.Mailn_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Mailn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Mailn_lbl.Location = new System.Drawing.Point(703, 18);
            this.Mailn_lbl.Name = "Mailn_lbl";
            this.Mailn_lbl.Size = new System.Drawing.Size(224, 47);
            this.Mailn_lbl.TabIndex = 4;
            this.Mailn_lbl.Text = "Main menu";
            // 
            // Contin_butt
            // 
            this.Contin_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Contin_butt.Location = new System.Drawing.Point(732, 111);
            this.Contin_butt.Name = "Contin_butt";
            this.Contin_butt.Size = new System.Drawing.Size(151, 37);
            this.Contin_butt.TabIndex = 5;
            this.Contin_butt.Text = "Загрузить";
            this.Contin_butt.UseVisualStyleBackColor = true;
            this.Contin_butt.Click += new System.EventHandler(this.Contin_butt_Click);
            // 
            // Settings_butt
            // 
            this.Settings_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Settings_butt.Location = new System.Drawing.Point(732, 154);
            this.Settings_butt.Name = "Settings_butt";
            this.Settings_butt.Size = new System.Drawing.Size(151, 37);
            this.Settings_butt.TabIndex = 6;
            this.Settings_butt.Text = "Настройки";
            this.Settings_butt.UseVisualStyleBackColor = true;
            this.Settings_butt.Click += new System.EventHandler(this.Settings_butt_Click);
            // 
            // Exit_butt
            // 
            this.Exit_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Exit_butt.Location = new System.Drawing.Point(732, 197);
            this.Exit_butt.Name = "Exit_butt";
            this.Exit_butt.Size = new System.Drawing.Size(151, 37);
            this.Exit_butt.TabIndex = 7;
            this.Exit_butt.Text = "Выход";
            this.Exit_butt.UseVisualStyleBackColor = true;
            this.Exit_butt.Click += new System.EventHandler(this.Exit_butt_Click);
            // 
            // setting_lbl
            // 
            this.setting_lbl.AutoSize = true;
            this.setting_lbl.BackColor = System.Drawing.Color.Transparent;
            this.setting_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.setting_lbl.Location = new System.Drawing.Point(703, 261);
            this.setting_lbl.Name = "setting_lbl";
            this.setting_lbl.Size = new System.Drawing.Size(226, 47);
            this.setting_lbl.TabIndex = 8;
            this.setting_lbl.Text = "Настройки";
            // 
            // window_type_box
            // 
            this.window_type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.window_type_box.FormattingEnabled = true;
            this.window_type_box.Location = new System.Drawing.Point(831, 350);
            this.window_type_box.Name = "window_type_box";
            this.window_type_box.Size = new System.Drawing.Size(149, 21);
            this.window_type_box.TabIndex = 9;
            // 
            // form_lbl
            // 
            this.form_lbl.AutoSize = true;
            this.form_lbl.BackColor = System.Drawing.Color.Transparent;
            this.form_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.form_lbl.Location = new System.Drawing.Point(665, 346);
            this.form_lbl.Name = "form_lbl";
            this.form_lbl.Size = new System.Drawing.Size(138, 25);
            this.form_lbl.TabIndex = 10;
            this.form_lbl.Text = "Фомат окна ";
            // 
            // size_lbl
            // 
            this.size_lbl.AutoSize = true;
            this.size_lbl.BackColor = System.Drawing.Color.Transparent;
            this.size_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.size_lbl.Location = new System.Drawing.Point(665, 392);
            this.size_lbl.Name = "size_lbl";
            this.size_lbl.Size = new System.Drawing.Size(144, 25);
            this.size_lbl.TabIndex = 12;
            this.size_lbl.Text = "Разрешение ";
            // 
            // window_size_box
            // 
            this.window_size_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.window_size_box.FormattingEnabled = true;
            this.window_size_box.Location = new System.Drawing.Point(831, 396);
            this.window_size_box.Name = "window_size_box";
            this.window_size_box.Size = new System.Drawing.Size(149, 21);
            this.window_size_box.TabIndex = 11;
            // 
            // accept_set_butt
            // 
            this.accept_set_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.accept_set_butt.Location = new System.Drawing.Point(739, 451);
            this.accept_set_butt.Name = "accept_set_butt";
            this.accept_set_butt.Size = new System.Drawing.Size(137, 39);
            this.accept_set_butt.TabIndex = 13;
            this.accept_set_butt.Text = "принять";
            this.accept_set_butt.UseVisualStyleBackColor = true;
            this.accept_set_butt.Click += new System.EventHandler(this.accept_set_butt_Click);
            // 
            // back_sett_but
            // 
            this.back_sett_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.back_sett_but.Location = new System.Drawing.Point(739, 496);
            this.back_sett_but.Name = "back_sett_but";
            this.back_sett_but.Size = new System.Drawing.Size(137, 39);
            this.back_sett_but.TabIndex = 14;
            this.back_sett_but.Text = "назад";
            this.back_sett_but.UseVisualStyleBackColor = true;
            this.back_sett_but.Click += new System.EventHandler(this.back_sett_but_Click);
            // 
            // save_lbl
            // 
            this.save_lbl.AutoSize = true;
            this.save_lbl.BackColor = System.Drawing.Color.Transparent;
            this.save_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.save_lbl.Location = new System.Drawing.Point(185, 144);
            this.save_lbl.Name = "save_lbl";
            this.save_lbl.Size = new System.Drawing.Size(265, 47);
            this.save_lbl.TabIndex = 15;
            this.save_lbl.Text = "Сохранения ";
            // 
            // one_save_butt
            // 
            this.one_save_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.one_save_butt.Location = new System.Drawing.Point(232, 213);
            this.one_save_butt.Name = "one_save_butt";
            this.one_save_butt.Size = new System.Drawing.Size(169, 37);
            this.one_save_butt.TabIndex = 16;
            this.one_save_butt.Text = "Сохранение 1 ";
            this.one_save_butt.UseVisualStyleBackColor = true;
            // 
            // two_save_butt
            // 
            this.two_save_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.two_save_butt.Location = new System.Drawing.Point(232, 256);
            this.two_save_butt.Name = "two_save_butt";
            this.two_save_butt.Size = new System.Drawing.Size(169, 37);
            this.two_save_butt.TabIndex = 17;
            this.two_save_butt.Text = "Сохранение 2 ";
            this.two_save_butt.UseVisualStyleBackColor = true;
            // 
            // tree_save_butt
            // 
            this.tree_save_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tree_save_butt.Location = new System.Drawing.Point(232, 299);
            this.tree_save_butt.Name = "tree_save_butt";
            this.tree_save_butt.Size = new System.Drawing.Size(169, 37);
            this.tree_save_butt.TabIndex = 18;
            this.tree_save_butt.Text = "Сохранение 3";
            this.tree_save_butt.UseVisualStyleBackColor = true;
            // 
            // four_save_butt
            // 
            this.four_save_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.four_save_butt.Location = new System.Drawing.Point(232, 342);
            this.four_save_butt.Name = "four_save_butt";
            this.four_save_butt.Size = new System.Drawing.Size(169, 37);
            this.four_save_butt.TabIndex = 19;
            this.four_save_butt.Text = "Сохранение 4";
            this.four_save_butt.UseVisualStyleBackColor = true;
            // 
            // five_save_butt
            // 
            this.five_save_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.five_save_butt.Location = new System.Drawing.Point(232, 385);
            this.five_save_butt.Name = "five_save_butt";
            this.five_save_butt.Size = new System.Drawing.Size(169, 37);
            this.five_save_butt.TabIndex = 20;
            this.five_save_butt.Text = "Сохранение 5 ";
            this.five_save_butt.UseVisualStyleBackColor = true;
            // 
            // back_load_butt
            // 
            this.back_load_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.back_load_butt.Location = new System.Drawing.Point(241, 451);
            this.back_load_butt.Name = "back_load_butt";
            this.back_load_butt.Size = new System.Drawing.Size(151, 37);
            this.back_load_butt.TabIndex = 21;
            this.back_load_butt.Text = "назад";
            this.back_load_butt.UseVisualStyleBackColor = true;
            this.back_load_butt.Click += new System.EventHandler(this.back_load_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 646);
            this.Controls.Add(this.back_load_butt);
            this.Controls.Add(this.five_save_butt);
            this.Controls.Add(this.four_save_butt);
            this.Controls.Add(this.tree_save_butt);
            this.Controls.Add(this.two_save_butt);
            this.Controls.Add(this.one_save_butt);
            this.Controls.Add(this.save_lbl);
            this.Controls.Add(this.back_sett_but);
            this.Controls.Add(this.accept_set_butt);
            this.Controls.Add(this.size_lbl);
            this.Controls.Add(this.window_size_box);
            this.Controls.Add(this.form_lbl);
            this.Controls.Add(this.window_type_box);
            this.Controls.Add(this.setting_lbl);
            this.Controls.Add(this.Exit_butt);
            this.Controls.Add(this.Settings_butt);
            this.Controls.Add(this.Contin_butt);
            this.Controls.Add(this.Mailn_lbl);
            this.Controls.Add(this.Start_Game_butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player_box);
            this.Controls.Add(this.world_map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.world_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox world_map;
        private System.Windows.Forms.PictureBox player_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Game_butt;
        private System.Windows.Forms.Label Mailn_lbl;
        private System.Windows.Forms.Button Contin_butt;
        private System.Windows.Forms.Button Settings_butt;
        private System.Windows.Forms.Button Exit_butt;
        private System.Windows.Forms.Label setting_lbl;
        private System.Windows.Forms.ComboBox window_type_box;
        private System.Windows.Forms.Label form_lbl;
        private System.Windows.Forms.Label size_lbl;
        private System.Windows.Forms.ComboBox window_size_box;
        private System.Windows.Forms.Button accept_set_butt;
        private System.Windows.Forms.Button back_sett_but;
        private System.Windows.Forms.Label save_lbl;
        private System.Windows.Forms.Button one_save_butt;
        private System.Windows.Forms.Button two_save_butt;
        private System.Windows.Forms.Button tree_save_butt;
        private System.Windows.Forms.Button four_save_butt;
        private System.Windows.Forms.Button five_save_butt;
        private System.Windows.Forms.Button back_load_butt;
    }
}

