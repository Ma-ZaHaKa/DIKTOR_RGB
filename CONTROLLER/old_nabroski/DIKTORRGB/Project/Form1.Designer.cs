
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
            this.set_color_dialog = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.LabelHead = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.indicator = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.indicator_log = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.anim_log = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.PanelMain.SuspendLayout();
            this.PanelHead.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.siticonePanel2);
            this.PanelMain.Controls.Add(this.siticonePanel1);
            this.PanelMain.Location = new System.Drawing.Point(0, 26);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(471, 146);
            this.PanelMain.TabIndex = 0;
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
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Transparent;
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Controls.Add(this.ButtonClose);
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(471, 35);
            this.PanelHead.TabIndex = 1;
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.LabelHead.Location = new System.Drawing.Point(12, 10);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(118, 13);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "ARDUINO DIKTOR RGB";
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.ButtonClose.Location = new System.Drawing.Point(435, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(33, 30);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.Red;
            this.siticonePanel1.BorderRadius = 5;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.indicator_log);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.indicator);
            this.siticonePanel1.Controls.Add(this.set_color_dialog);
            this.siticonePanel1.Location = new System.Drawing.Point(9, 15);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(220, 112);
            this.siticonePanel1.TabIndex = 2;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Black;
            this.indicator.Location = new System.Drawing.Point(8, 23);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(203, 17);
            this.indicator.TabIndex = 0;
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
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.Red;
            this.siticonePanel2.BorderRadius = 5;
            this.siticonePanel2.BorderThickness = 1;
            this.siticonePanel2.Controls.Add(this.anim_log);
            this.siticonePanel2.Controls.Add(this.label3);
            this.siticonePanel2.Controls.Add(this.siticoneRoundedButton1);
            this.siticonePanel2.Location = new System.Drawing.Point(239, 15);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(220, 112);
            this.siticonePanel2.TabIndex = 3;
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
            this.label3.Location = new System.Drawing.Point(50, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Set Animation Mode";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(54, 49);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(111, 25);
            this.siticoneRoundedButton1.TabIndex = 0;
            this.siticoneRoundedButton1.Text = "Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 172);
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
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelHead;
        private Siticone.UI.WinForms.SiticoneRoundedButton set_color_dialog;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label indicator_log;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label anim_log;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
    }
}

