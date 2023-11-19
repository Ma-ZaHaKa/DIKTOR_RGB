using SimpleJSON;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomColorDialog;
using CustomButton;
using System.Reflection;
using Project.Properties;
using System.IO;
using System.Linq;

namespace Project
{
    // Наследуемся от FormShadow
    public partial class Form1 : FormShadow
    {
        //---FORM-SETTINGS
        //[DllImport("dwmapi.dll")] public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")] public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")] public static extern int DwmIsCompositionEnabled(ref int pfEnabled); readonly bool m_aeroEnabled;
        bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return enabled == 1;
            }
            return false;
        }

        //----------CONSOLE-----------//
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();





        //public DiktorColorDialog dcd = new DiktorColorDialog();
        bool Shadow = true; // тень формы by diktor
        string last_file = "last.ini"; // color status delay 1 dalay 2
        string available_anims_file = "anims.ini";
        int max_anims = 8;
        //Color LastColor = Color.Black;
        Color LastColor = Color.Red;

        public Form1()
        {
            InitializeComponent();
            Color shapka_panel_color = Color.FromArgb(36, 47, 61);
            Color main_panel_color = Color.FromArgb(14, 22, 33);

            // Плавное закрытие программы
            async void Exit() { for (Opacity = 1; Opacity > .0; Opacity -= .2) await Task.Delay(7); Close(); }
            ButtonClose.Click += (s, a) => Exit();
            m_aeroEnabled = Shadow ? CheckAeroEnabled() : false;

            // Красим форму
            PanelHead.BackColor = shapka_panel_color; //SHAPKA
            FormPaintI(shapka_panel_color, 0, main_panel_color); //SHAPKA + BODY
            //FormPaint(Color.FromArgb(44, 57, 67), Color.FromArgb(35, 44, 55));

            // Позволяем таскать за заголовок Label и Panel
            new List<Control> { LabelHead, PanelHead }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false; Capture = false; Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref m);
                };
            });

            //---double buffered panels by diktor
            new List<Panel> { PanelHead, PanelMain, panel1, panel2 }.ForEach(panel
               => typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true }));
        }



        // Красим форму
        void FormPaint(Color color_shapka, float center, Color color_body)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color_shapka, color_shapka, color_body, color_body }, Positions = new[] { 0, center, center, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }

        void FormPaintI(Color color_shapka, int pixel_shapka, Color color_body)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;
                float shapka_panel = (float)pixel_shapka / 600; //0.05f; //telegram   //shapka * 600 = count_pixel on screen

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color_shapka, color_shapka, color_body, color_body }, Positions = new[] { 0, shapka_panel, shapka_panel, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }

        //-----------------CFG--------------------
        void MkAnims()
        {
            //if(!File.Exists(available_anims_file))
            {
                string buffer = "";
                for (int i = 0; i <= max_anims; i++)
                {
                    buffer += (i >= max_anims) ? $"{i}" : $"{i}\r\n";
                }
                File.WriteAllText(available_anims_file, buffer);
            }
        }
        void Mklast(Color c, int last_anim, int delay_anim, int delay_color)
        {
            string buffer = $"{c.R}\r\n{c.G}\r\n{c.B}\r\n{last_anim}\r\n{delay_anim}\r\n{delay_color}";
            File.WriteAllText(last_file, buffer);
        }
        void UpdateRowLast(int index, string val) //0 1 2 RGB  3 index anims  4 DA   5 DC
        {
            if (val.Trim() == "") { return; }
            string[] rows = File.ReadAllLines(last_file); // 6 rows [0-5]
            rows[index] = val;
            File.WriteAllLines(last_file, rows);
        }
        void UpdateColorLast(Color color) //0 1 2 RGB  3 index anims  4 DA   5 DC
        {
            string[] rows = File.ReadAllLines(last_file); // 6 rows [0-5]
            rows[0] = $"{color.R}";
            rows[1] = $"{color.G}";
            rows[2] = $"{color.B}";
            File.WriteAllLines(last_file, rows);
        }
        (bool, List<string>) GetAnims()
        {
            if (!File.Exists(available_anims_file)) { return (false, new List<string>()); }
            return (true, File.ReadAllLines(available_anims_file).Where(x => (x.Trim() != "")).ToList());
        }
        (bool, Color, int, int, int) GetLastColor() // status, color, anim_num, delay_anim, delay_color
        {
            if (!File.Exists(last_file)) { return (false, Color.Black, 0, 0, 0); }
            string[] rows = File.ReadAllLines(last_file); // 6 rows [0-5]
            if (rows.Length < 6) { return (false, Color.Black, 0, 0, 0); }
            return (true, Color.FromArgb(int.Parse(rows[0]), int.Parse(rows[1]), int.Parse(rows[2])), int.Parse(rows[3]), int.Parse(rows[4]), int.Parse(rows[5]));
        }
        //---------------------------------------------------------------------






        public string COM = "";
        public string ARDUINO_PROJECT = "rgb_controller_diktor";
        async void Form1_Load(object sender, EventArgs e)
        {
            // Плавный запуск формы
            for (Opacity = 0; Opacity < 1; Opacity += .2) await Task.Delay(10);

            #region OLD
            //try  // inital
            //{
            //    int timeout = 10000;
            //   serialPort1.BaudRate = (9600);
            //    serialPort1.ReadTimeout = (timeout);
            //    serialPort1.WriteTimeout = (timeout);
            //    //portbox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //    //for (int i = 0; i < portbox.Items.Count; i++) { if (portbox.Items[i].ToString().Contains("3")) { portbox.SelectedIndex = i; } }
            //    if (portbox.Items.Count == 0) { throw new Exception("no com"); }
            //    portbox.SelectedIndex = 0;
            //    serialPort1.PortName = portbox.Items[0].ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ардуино подключи");
            //    Close();
            //}
            //try
            //{
            //    System.Threading.Thread.Sleep(500);
            //    string _out = SendData("get_data");
            //    var data = _out.Split(':');
            //    int l_perc = int.Parse(data[1]);
            //    int r_perc = int.Parse(data[3]);
            //    L.Text = $"{l_perc}";
            //    LV.Value = l_perc;
            //    R.Text = $"{r_perc}";
            //    RV.Value = r_perc;
            //}
            //catch
            //{
            //    L.Text = "0";
            //    LV.Value = 0;
            //    R.Text = "0";
            //    RV.Value = 0;
            //}
            #endregion

            //AllocConsole();

            for (int i = 0; i < 5; i++) { COM = FindCOMPort(ARDUINO_PROJECT); if (COM == "") { System.Threading.Thread.Sleep(1000); } else { break; } }
            ////COM = FindCOMPort(ARDUINO_PROJECT);
            if (COM == "") { MessageBox.Show("ERROR! COM NOT FOUND"); this.Close(); }

            /*List<(string, int)> vals = GetVals(COM);
            int tmp_val = 0;
            tmp_val = vals.Find(p => (p.Item1 == "1")).Item2;*/
            //SetAnimLog("1");


            if (!File.Exists(available_anims_file)) { MkAnims(); };
            if (!File.Exists(last_file)) { Mklast(LastColor, 0, 10, 1000); }

            anim_num.Items.AddRange(GetAnims().Item2.ToArray());
            anim_num.SelectedIndex = 0;
            (bool, Color, int, int, int) last_data = GetLastColor();

            //---RESTORE DATA
            LastColor = last_data.Item2;
            HandleColorChange(LastColor);
            //anim_num.SelectedIndex = anim_num.Items.IndexOf($"{last_data.Item3}");
            anim_num.SelectedIndex = last_data.Item3;
            SetAnimLog(anim_num.Text);
            delay_anim.Value = last_data.Item4;
            delay_color.Value = last_data.Item5;

            this.anim_num.SelectedIndexChanged += new System.EventHandler(this.anim_num_SelectedIndexChanged);
            //this.anim_num.TextChanged += new System.EventHandler(this.anim_num_TextChanged); // если вписать начало оно не может найти и индекса нет
            this.delay_anim.ValueChanged += new System.EventHandler(this.delay_anim_ValueChanged);
            this.delay_color.ValueChanged += new System.EventHandler(this.delay_color_ValueChanged);
        }

        void set_color_dialog_Click(object sender, EventArgs e) => OpenColorDialog();
        void indicator_Click(object sender, EventArgs e) => OpenColorDialog();
        /*void anim_num_TextChanged(object sender, EventArgs e) // ??
        {
            if ((anim_num.Text.Trim() != "") && (anim_num.SelectedIndex >= 0)) { UpdateRowLast(3, $"{anim_num.SelectedIndex}"); SetAnimLog(anim_num.Text); }
        }*/

        void anim_num_KeyPress(object sender, KeyPressEventArgs e) // на ентер без сохранениия
        {
            if (e.KeyChar == (char)Keys.Enter) { SetComAnimNum(anim_num.Text, $"{(int)delay_anim.Value}", $"{(int)delay_color.Value}"); }
        }

        void anim_num_SelectedIndexChanged(object sender, EventArgs e) { UpdateRowLast(3, $"{anim_num.SelectedIndex}"); SetAnimLog(anim_num.Text); }
        void delay_anim_ValueChanged(object sender, EventArgs e) => UpdateRowLast(4, $"{(int)delay_anim.Value}");
        void delay_color_ValueChanged(object sender, EventArgs e) => UpdateRowLast(5, $"{(int)delay_color.Value}");
        void set_anim_b_Click(object sender, EventArgs e) { SetComAnimNum(anim_num.Text, $"{(int)delay_anim.Value}", $"{(int)delay_color.Value}"); }


        //--ВРЕМЕННО!
        void info_b_Click(object sender, EventArgs e) { MessageBox.Show($"0 - ВЫКЛ\n1 - РАНДОМ ЦВЕТ\n2 - FULL\n3 - FADE\n8 - РАНДОМ ЦВЕТ АНИМАЦИЯ", "DIKTOR INFO"); }


        void OpenColorDialog()
        {
            using (DiktorColorDialog dcd = new DiktorColorDialog())
            {
                Color color_before = LastColor; // is press disable on dialog
                dcd.Color = LastColor; // if no clicked ok
                dcd.CurrentColorEvent += HandleColorChange;
                if (dcd.ShowDialog() != DialogResult.OK) { HandleColorChange(color_before); } // Last Rewrite in Handle
                dcd.CurrentColorEvent -= HandleColorChange;
            }
        }
        void HandleColorChange(Color color) // On ChangeColor
        {
            LastColor = color;
            indicator.BackColor = color;
            SetColorLog(color);
            UpdateColorLast(color);

            SetComColor(color);
            //Console.WriteLine("HandleColorChange");
        }



        //--------------SET--COLOR--COM
        void SetComColor(Color color)
        {
            SendMsgComNoResp(COM, GetJsonSetRGB(color.R, color.G, color.B), 9600);
        }
        void SetComAnimNum(string _anim_num, string _delay_anim, string _delay_color)
        {
            //SendMsgCom(COM, GetJsonSetAnimMode(_anim_num, _delay_anim, _delay_color), 9600);
            SendMsgComNoResp(COM, GetJsonSetAnimMode(_anim_num, _delay_anim, _delay_color), 9600);
        }
        //------------------------




        void SetColorLog(Color c)
        {
            indicator_log.Text = $"R:{c.R}  G:{c.G}  B:{c.B}";
        }
        void SetAnimLog(string mode)
        {
            anim_log.Text = $"MODE: {mode}";
        }


        #region Minimized Button
        void ButtonMinimize_MouseEnter(object sender, EventArgs e)
           => ButtonMinimize.Image = Resources.night_minimize_hover; // Minimize hover

        void ButtonMinimize_MouseLeave(object sender, EventArgs e)
           => ButtonMinimize.Image = Resources.night_minimize; // Minimize

        void ButtonMinimize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
        #endregion

        #region Maximized Button
        /*void ButtonMaximize_MouseEnter(object sender, EventArgs e)
          => ButtonMaximize.Image = IsMaximized ? current_buttons[5] : current_buttons[3]; //Maximize-minimize hover : Maximize hover

        void ButtonMaximize_MouseLeave(object sender, EventArgs e)
          => ButtonMaximize.Image = IsMaximized ? current_buttons[4] : current_buttons[2]; // Maximize-minimize : Maximize

        void ButtonMaximize_Click(object sender, EventArgs e)
        {
            bool IsMove = false;
            try { IsMove = (string)sender == "MOVE"; } catch { }
            if (IsMove) { ButtonMaximize.Image = !(IsMaximized = !IsMaximized) ? current_buttons[2] : current_buttons[4]; } // NOT HOVER
            else { ButtonMaximize.Image = !(IsMaximized = !IsMaximized) ? current_buttons[3] : current_buttons[5]; } //maximaze-hover : maximaze-minimaze hover
            if (IsMaximized) { Maximized(); } else { Normalized(); }
            CFGUpdate();
        }*/
        #endregion

        #region Close Button
        void ButtonClose_MouseEnter(object sender, EventArgs e)
           => ButtonClose.Image = Resources.night_close_hover; // close hover

        void ButtonClose_MouseLeave(object sender, EventArgs e)
           => ButtonClose.Image = Resources.night_close; // close

        void ButtonClose_Click(object sender, EventArgs e)
           => Close(); //Exit();
        #endregion
    }
}
