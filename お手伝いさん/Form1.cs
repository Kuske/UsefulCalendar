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

namespace UsefulCarender
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

            Clock.Text = TimeData.GetNowTime_string();
        }

        // 常に上に表示しておく時計がクリックされた時の挙動
        private void Clock_Click(object sender, EventArgs e)
        {
            // 大きい時計画面を開く処理

        }
    }
}
