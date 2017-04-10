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
namespace Clock
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
    }

    // 時間データをアナログ時計の計算に使うクラス
    class AnalogSet
    {

    }
}