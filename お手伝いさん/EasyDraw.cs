using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuske.UsefulCalender;
using Kuske.UsefulCalender.Main;

// 図形を描画する
namespace Kuske.UsefulCalender.DrawGeometry
{
    // 線を描画する
    static class Line
    {
        public static void DrawLine(Graphics Graph_Line, int Thickness, Color LineColor, int x1, int y1, int x2, int y2)
        {

            //pen作成
            Pen WritePen = new Pen(LineColor, Thickness);

            //lineの始点と終点
            Point Start_point1 = new Point(x1, y1);
            Point End_point1 = new Point(x2, y2);

            //lineを描画
            Graph_Line.DrawLine(WritePen, Start_point1, End_point1);

            //penを解放
            WritePen.Dispose();
        }
    }
}