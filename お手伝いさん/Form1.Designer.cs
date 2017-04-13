namespace Kuske.UsefulCalender.Main
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Clock_Timer = new System.Windows.Forms.Timer(this.components);
            this.DrawClock = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SetPlan_Absence = new System.Windows.Forms.RichTextBox();
            this.SetPlan_Title = new System.Windows.Forms.TextBox();
            this.PlanSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clock_Timer
            // 
            this.Clock_Timer.Interval = 50;
            this.Clock_Timer.Tick += new System.EventHandler(this.Clock_Timer_Tick);
            // 
            // DrawClock
            // 
            this.DrawClock.AutoSize = true;
            this.DrawClock.Location = new System.Drawing.Point(9, 9);
            this.DrawClock.Margin = new System.Windows.Forms.Padding(0);
            this.DrawClock.Name = "DrawClock";
            this.DrawClock.Size = new System.Drawing.Size(85, 22);
            this.DrawClock.TabIndex = 1;
            this.DrawClock.Text = "button1";
            this.DrawClock.UseVisualStyleBackColor = true;
            this.DrawClock.Click += new System.EventHandler(this.DrawClock_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 19);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // SetPlan_Absence
            // 
            this.SetPlan_Absence.Location = new System.Drawing.Point(220, 122);
            this.SetPlan_Absence.Name = "SetPlan_Absence";
            this.SetPlan_Absence.Size = new System.Drawing.Size(151, 105);
            this.SetPlan_Absence.TabIndex = 4;
            this.SetPlan_Absence.Text = "内容";
            // 
            // SetPlan_Title
            // 
            this.SetPlan_Title.Location = new System.Drawing.Point(220, 97);
            this.SetPlan_Title.Name = "SetPlan_Title";
            this.SetPlan_Title.Size = new System.Drawing.Size(148, 19);
            this.SetPlan_Title.TabIndex = 5;
            this.SetPlan_Title.Text = "タイトル";
            // 
            // PlanSave
            // 
            this.PlanSave.Location = new System.Drawing.Point(384, 204);
            this.PlanSave.Name = "PlanSave";
            this.PlanSave.Size = new System.Drawing.Size(75, 23);
            this.PlanSave.TabIndex = 14;
            this.PlanSave.Text = "完了";
            this.PlanSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "予定の確認";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "残りの一日";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "事前予告";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(64, 19);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(230, 50);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(81, 19);
            this.dateTimePicker3.TabIndex = 20;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(297, 75);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(81, 19);
            this.dateTimePicker4.TabIndex = 22;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(384, 75);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.ShowUpDown = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(64, 19);
            this.dateTimePicker5.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "～";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "予告の設定";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "設定";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 233);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlanSave);
            this.Controls.Add(this.SetPlan_Title);
            this.Controls.Add(this.SetPlan_Absence);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.DrawClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Clock_Timer;
        private System.Windows.Forms.Button DrawClock;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox SetPlan_Absence;
        private System.Windows.Forms.TextBox SetPlan_Title;
        private System.Windows.Forms.Button PlanSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

