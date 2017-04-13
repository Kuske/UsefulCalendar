using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 時計関係
namespace Kuske.UsefulCalender.Clock
{
    // 実際に時間を扱うクラス
    class TimeData
    {

        // 現在時刻を取得し、それをstring型で返してくれる
        public static string GetNowTime_string()
        {
            // 現在時を取得
            DateTime datetime = DateTime.Now;

            return datetime.ToString();
        }

        // (0時0分0秒からの)現在の秒数を取得し、それをint型で返してくれる
        public static int GetNowTime_int()
        {
            // 現在時を取得
            DateTime datetime = DateTime.Now;

            return datetime.Hour * 3600 + datetime.Minute * 60 + datetime.Second;
        }
    }

    // 時間データをアナログ時計の計算に使うクラス
    class AnalogSet
    {
        
    }

    // 大きい時計を描画するクラス
    class DrawBigClock
    {

    }
}