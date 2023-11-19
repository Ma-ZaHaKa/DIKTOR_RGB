
using CustomButton;

namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.info_b = new Siticone.UI.WinForms.SiticoneButton();
            this.anim_num = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delay_color = new System.Windows.Forms.NumericUpDown();
            this.delay_anim = new System.Windows.Forms.NumericUpDown();
            this.anim_log = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.set_anim_b = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.panel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.indicator_log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.indicator = new System.Windows.Forms.Panel();
            this.set_color_dialog = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ButtonClose = new CustomButton.DiktorButtonNoFocus();
            this.ButtonMinimize = new CustomButton.DiktorButtonNoFocus();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.LabelHead = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_anim)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Location = new System.Drawing.Point(0, 22);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(522, 150);
            this.PanelMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.Red;
            this.panel2.BorderRadius = 5;
            this.panel2.BorderThickness = 1;
            this.panel2.Controls.Add(this.info_b);
            this.panel2.Controls.Add(this.anim_num);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.delay_color);
            this.panel2.Controls.Add(this.delay_anim);
            this.panel2.Controls.Add(this.anim_log);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.set_anim_b);
            this.panel2.Location = new System.Drawing.Point(239, 15);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(271, 112);
            this.panel2.TabIndex = 3;
            // 
            // info_b
            // 
            this.info_b.CheckedState.Parent = this.info_b;
            this.info_b.CustomImages.Parent = this.info_b;
            this.info_b.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.info_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.info_b.ForeColor = System.Drawing.Color.Black;
            this.info_b.HoveredState.Parent = this.info_b;
            this.info_b.Location = new System.Drawing.Point(15, 56);
            this.info_b.Name = "info_b";
            this.info_b.ShadowDecoration.Parent = this.info_b;
            this.info_b.Size = new System.Drawing.Size(26, 24);
            this.info_b.TabIndex = 8;
            this.info_b.Text = "?";
            this.info_b.Click += new System.EventHandler(this.info_b_Click);
            // 
            // anim_num
            // 
            this.anim_num.CausesValidation = false;
            this.anim_num.Location = new System.Drawing.Point(12, 26);
            this.anim_num.Name = "anim_num";
            this.anim_num.Size = new System.Drawing.Size(153, 21);
            this.anim_num.TabIndex = 7;
            this.anim_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anim_num_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(195, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "delay color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(196, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "delay anim";
            // 
            // delay_color
            // 
            this.delay_color.Location = new System.Drawing.Point(176, 72);
            this.delay_color.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delay_color.Name = "delay_color";
            this.delay_color.Size = new System.Drawing.Size(82, 21);
            this.delay_color.TabIndex = 4;
            // 
            // delay_anim
            // 
            this.delay_anim.Location = new System.Drawing.Point(174, 27);
            this.delay_anim.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delay_anim.Name = "delay_anim";
            this.delay_anim.Size = new System.Drawing.Size(82, 21);
            this.delay_anim.TabIndex = 3;
            // 
            // anim_log
            // 
            this.anim_log.AutoSize = true;
            this.anim_log.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anim_log.ForeColor = System.Drawing.Color.Orange;
            this.anim_log.Location = new System.Drawing.Point(9, 88);
            this.anim_log.Name = "anim_log";
            this.anim_log.Size = new System.Drawing.Size(51, 14);
            this.anim_log.TabIndex = 2;
            this.anim_log.Text = "- - - - - -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(68, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Set Anim";
            // 
            // set_anim_b
            // 
            this.set_anim_b.CheckedState.Parent = this.set_anim_b;
            this.set_anim_b.CustomImages.Parent = this.set_anim_b;
            this.set_anim_b.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.set_anim_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.set_anim_b.ForeColor = System.Drawing.Color.Black;
            this.set_anim_b.HoveredState.Parent = this.set_anim_b;
            this.set_anim_b.Location = new System.Drawing.Point(47, 56);
            this.set_anim_b.Name = "set_anim_b";
            this.set_anim_b.ShadowDecoration.Parent = this.set_anim_b;
            this.set_anim_b.Size = new System.Drawing.Size(111, 25);
            this.set_anim_b.TabIndex = 0;
            this.set_anim_b.Text = "Set";
            this.set_anim_b.Click += new System.EventHandler(this.set_anim_b_Click);
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Red;
            this.panel1.BorderRadius = 5;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.indicator_log);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.set_color_dialog);
            this.panel1.Location = new System.Drawing.Point(9, 15);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(220, 112);
            this.panel1.TabIndex = 2;
            // 
            // indicator_log
            // 
            this.indicator_log.AutoSize = true;
            this.indicator_log.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indicator_log.ForeColor = System.Drawing.Color.Orange;
            this.indicator_log.Location = new System.Drawing.Point(9, 88);
            this.indicator_log.Name = "indicator_log";
            this.indicator_log.Size = new System.Drawing.Size(51, 14);
            this.indicator_log.TabIndex = 2;
            this.indicator_log.Text = "- - - - - -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(64, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Color Mode";
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Black;
            this.indicator.Location = new System.Drawing.Point(8, 23);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(203, 17);
            this.indicator.TabIndex = 0;
            this.indicator.Click += new System.EventHandler(this.indicator_Click);
            // 
            // set_color_dialog
            // 
            this.set_color_dialog.CheckedState.Parent = this.set_color_dialog;
            this.set_color_dialog.CustomImages.Parent = this.set_color_dialog;
            this.set_color_dialog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.set_color_dialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.set_color_dialog.ForeColor = System.Drawing.Color.Black;
            this.set_color_dialog.HoveredState.Parent = this.set_color_dialog;
            this.set_color_dialog.Location = new System.Drawing.Point(54, 49);
            this.set_color_dialog.Name = "set_color_dialog";
            this.set_color_dialog.ShadowDecoration.Parent = this.set_color_dialog;
            this.set_color_dialog.Size = new System.Drawing.Size(111, 25);
            this.set_color_dialog.TabIndex = 0;
            this.set_color_dialog.Text = "Select";
            this.set_color_dialog.Click += new System.EventHandler(this.set_color_dialog_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.ButtonClose.Image = global::Project.Properties.Resources.night_close;
            this.ButtonClose.Location = new System.Drawing.Point(493, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 21);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.ButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.ButtonMinimize.Image = global::Project.Properties.Resources.night_minimize;
            this.ButtonMinimize.Location = new System.Drawing.Point(467, 0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.ButtonMinimize.Size = new System.Drawing.Size(24, 21);
            this.ButtonMinimize.TabIndex = 3;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.ButtonMinimize.MouseEnter += new System.EventHandler(this.ButtonMinimize_MouseEnter);
            this.ButtonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Transparent;
            this.PanelHead.Controls.Add(this.ButtonMinimize);
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Controls.Add(this.ButtonClose);
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(522, 21);
            this.PanelHead.TabIndex = 1;
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.LabelHead.Location = new System.Drawing.Point(7, 4);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(161, 13);
            this.LabelHead.TabIndex = 2;
            this.LabelHead.Text = "ARDUINO DIKTOR RGB (4 Dima)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 172);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.PanelMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARDUINO DIKTOR RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_anim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private Siticone.UI.WinForms.SiticoneRoundedButton set_color_dialog;
        private Siticone.UI.WinForms.SiticonePanel panel1;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label indicator_log;
        private Siticone.UI.WinForms.SiticonePanel panel2;
        private System.Windows.Forms.Label anim_log;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedButton set_anim_b;
        private System.Windows.Forms.Panel PanelHead;
        private DiktorButtonNoFocus ButtonClose;
        private System.Windows.Forms.Label LabelHead;
        private DiktorButtonNoFocus ButtonMinimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delay_color;
        private System.Windows.Forms.NumericUpDown delay_anim;
        private Siticone.UI.WinForms.SiticoneButton info_b;
        private System.Windows.Forms.ComboBox anim_num;
    }
}

