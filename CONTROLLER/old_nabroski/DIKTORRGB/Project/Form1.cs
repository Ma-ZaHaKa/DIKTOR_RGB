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

namespace Project
{
    // Наследуемся от FormShadow
    public partial class Form1 : FormShadow
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();
        public DiktorColorDialog dcd = new DiktorColorDialog();


        public Form1()
        {
            InitializeComponent();

            // Плавное закрытие программы
            async void Exit() { for (Opacity = 1; Opacity > .0; Opacity -= .2) await Task.Delay(7); Close(); }
            ButtonClose.Click += (s, a) => Exit();

            // Красим форму
            FormPaint(Color.FromArgb(44, 57, 67), Color.FromArgb(35, 44, 55));

            // Позволяем таскать за заголовок Label и Panel
            new List<Control> { LabelHead, PanelHead }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false; Capture = false; Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref m);
                };
            });
        }

        // Красим форму
        public void FormPaint(Color color1, Color color2)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                float c_point = 0.18f;
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, c_point, c_point, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
            //AllocConsole();
        }










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



            //for (int i = 0; i < 5; i++) { COM = FindCOMPort(ARDUINO_PROJECT); if (COM == "") { System.Threading.Thread.Sleep(1000); } else { break; } }
            ////COM = FindCOMPort(ARDUINO_PROJECT);
            //if (COM == "") { MessageBox.Show("ERROR! COM NOT FOUND"); this.Close(); }

            /*List<(string, int)> vals = GetVals(COM);
            int tmp_val = 0;
            tmp_val = vals.Find(p => (p.Item1 == "1")).Item2;*/

            SetColorLog(indicator.BackColor);
            SetAnimLog("1");
        }

        void set_color_dialog_Click(object sender, EventArgs e)
        {
            dcd.CurrentColorEvent += HandleColorChange;
            dcd.ShowDialog();
            dcd.CurrentColorEvent -= HandleColorChange;
        }

        void HandleColorChange(Color color)
        {
            indicator.BackColor = color;
            SetColorLog(color);
        }

        void SetColorLog(Color c)
        {
            indicator_log.Text = $"R:{c.R}  G:{c.G}  B:{c.B}";
        }
        void SetAnimLog(string mode)
        {
            anim_log.Text = $"MODE: {mode}";
        }
    }
}
