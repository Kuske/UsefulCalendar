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
        public static void DrawLine(Graphics DrawGraphics, int Thickness, Color DrawColor, int x1, int y1, int x2, int y2)
        {

            //pen作成
            Pen WritePen = new Pen(DrawColor, Thickness);

            //lineの始点と終点
            Point Start_point1 = new Point(x1, y1);
            Point End_point1 = new Point(x2, y2);

            //lineを描画
            DrawGraphics.DrawLine(WritePen, Start_point1, End_point1);

            //penを解放
            WritePen.Dispose();
        }
    }

    // 四角を描画する
    static class Box
    {
        public static void DrawBox(Graphics DrawGraphics, int Thickness, Color DrawColor, int x1, int y1, int x2, int y2, bool FillFlag)
        {
            //pen作成
            Pen WritePen = new Pen(DrawColor, Thickness);

            //外枠を描画
            DrawGraphics.DrawRectangle(WritePen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));

            // 塗りつぶし処理
            if (FillFlag == true)
            {
                // ブラシを用意
                SolidBrush DrawBrash = new SolidBrush(DrawColor);

                // 塗りつぶす
                DrawGraphics.FillRectangle(DrawBrash, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));

                // ブラシの消去
                DrawBrash.Dispose();
            }

            //penを解放
            WritePen.Dispose();
        }
    }

    // 丸
    static class Circle
    {
        // 楕円を描画
        public static void DrawEllipse(Graphics DrawGraphics, int Thickness, Color DrawColor, int x1, int y1, int x2, int y2, bool FillFlag)
        {
            // pen作成
            Pen WritePen = new Pen(DrawColor, Thickness);

            DrawGraphics.DrawEllipse(WritePen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));

            // 塗りつぶし処理
            if(FillFlag == true)
            {
                // ブラシを用意
                SolidBrush DrawBrash = new SolidBrush(DrawColor);

                // 塗りつぶす
                DrawGraphics.FillEllipse(DrawBrash, Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));

                // ブラシの消去
                DrawBrash.Dispose();
            }
            
            //penを解放
            WritePen.Dispose();
        }
    }
}