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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.SetPlan_HelpText1 = new System.Windows.Forms.Label();
            this.SetPlan_HelpText2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.PlanSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.monthCalendar1.Location = new System.Drawing.Point(9, 51);
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
            this.SetPlan_Absence.Location = new System.Drawing.Point(220, 108);
            this.SetPlan_Absence.Name = "SetPlan_Absence";
            this.SetPlan_Absence.Size = new System.Drawing.Size(151, 105);
            this.SetPlan_Absence.TabIndex = 4;
            this.SetPlan_Absence.Text = "内容";
            // 
            // SetPlan_Title
            // 
            this.SetPlan_Title.Location = new System.Drawing.Point(220, 83);
            this.SetPlan_Title.Name = "SetPlan_Title";
            this.SetPlan_Title.Size = new System.Drawing.Size(148, 19);
            this.SetPlan_Title.TabIndex = 5;
            this.SetPlan_Title.Text = "タイトル";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 51);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 19);
            this.numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(272, 51);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(31, 19);
            this.numericUpDown2.TabIndex = 7;
            // 
            // SetPlan_HelpText1
            // 
            this.SetPlan_HelpText1.AutoSize = true;
            this.SetPlan_HelpText1.Location = new System.Drawing.Point(255, 53);
            this.SetPlan_HelpText1.Margin = new System.Windows.Forms.Padding(0);
            this.SetPlan_HelpText1.Name = "SetPlan_HelpText1";
            this.SetPlan_HelpText1.Size = new System.Drawing.Size(17, 12);
            this.SetPlan_HelpText1.TabIndex = 8;
            this.SetPlan_HelpText1.Text = "時";
            // 
            // SetPlan_HelpText2
            // 
            this.SetPlan_HelpText2.AutoSize = true;
            this.SetPlan_HelpText2.Location = new System.Drawing.Point(303, 53);
            this.SetPlan_HelpText2.Margin = new System.Windows.Forms.Padding(0);
            this.SetPlan_HelpText2.Name = "SetPlan_HelpText2";
            this.SetPlan_HelpText2.Size = new System.Drawing.Size(31, 12);
            this.SetPlan_HelpText2.TabIndex = 9;
            this.SetPlan_HelpText2.Text = "分  -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "時";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(391, 51);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(31, 19);
            this.numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(339, 51);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(35, 19);
            this.numericUpDown4.TabIndex = 10;
            // 
            // PlanSave
            // 
            this.PlanSave.Location = new System.Drawing.Point(384, 190);
            this.PlanSave.Name = "PlanSave";
            this.PlanSave.Size = new System.Drawing.Size(75, 23);
            this.PlanSave.TabIndex = 14;
            this.PlanSave.Text = "完了";
            this.PlanSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "予定の確認";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(334, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 23);
            this.progressBar1.TabIndex = 16;
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
            this.checkBox1.Location = new System.Drawing.Point(384, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "事前予告";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 226);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlanSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.SetPlan_HelpText2);
            this.Controls.Add(this.SetPlan_HelpText1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label SetPlan_HelpText1;
        private System.Windows.Forms.Label SetPlan_HelpText2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button PlanSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

