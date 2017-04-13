using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuske.UsefulCalender.Clock;
using Kuske.UsefulCalender.DrawGeometry;

namespace Kuske.UsefulCalender.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 変えてはいけない
            InitializeComponent();

            ////////////////////////////////////////////


            // 時計用のタイマーの起動
            Clock_Timer.Start();
        }

        private void Clock_Timer_Tick(object sender, EventArgs e)
        {

            DrawClock.Text = TimeData.GetNowTime_string();
        }

        // 常に上に表示しておく時計がクリックされた時の挙動
        private void Clock_Click(object sender, EventArgs e)
        {
            // 大きい時計画面を開く処理

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //オブジェクトの作成
            Graphics DrawGraphs = this.CreateGraphics();

            // 上と下の境界線を引く
            DrawGeometry.Line.DrawLine(DrawGraphs, 1, Color.Black, 0, 40, this.Width, 40);

            // 残りの一日の割合のバーを表示
            {
                // 外枠
                DrawGeometry.Box.DrawBox(DrawGraphs, 1, Color.Black, 334, 11, 459, 34, false);

                // バー
                DrawGeometry.Box.DrawBox(DrawGraphs, 1, Color.Blue, 334, 11, 334 + (125 * TimeData.GetNowTime_int()) / (24 * 3600) , 34, true);
            }
        }

        private void DrawClock_Click(object sender, EventArgs e)
        {
            // 大きい時計画面を開く処理

        }
    }
}
