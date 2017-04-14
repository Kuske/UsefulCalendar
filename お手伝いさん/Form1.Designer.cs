namespace Kuske.UsefulCalender.Main
{
    partial class CheckPlan
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SetPlan_Absence = new System.Windows.Forms.RichTextBox();
            this.SetPlan_Title = new System.Windows.Forms.TextBox();
            this.Button_PlanSave = new System.Windows.Forms.Button();
            this.Button_CheckPlan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Button_CallSet = new System.Windows.Forms.Button();
            this.Button_TimeSet = new System.Windows.Forms.Button();
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
            this.DrawClock.Text = "現在時刻";
            this.DrawClock.UseVisualStyleBackColor = true;
            this.DrawClock.Click += new System.EventHandler(this.DrawClock_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 19);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // SetPlan_Absence
            // 
            this.SetPlan_Absence.Location = new System.Drawing.Point(6, 96);
            this.SetPlan_Absence.Name = "SetPlan_Absence";
            this.SetPlan_Absence.Size = new System.Drawing.Size(151, 109);
            this.SetPlan_Absence.TabIndex = 4;
            this.SetPlan_Absence.Text = "内容";
            // 
            // SetPlan_Title
            // 
            this.SetPlan_Title.Location = new System.Drawing.Point(9, 71);
            this.SetPlan_Title.Name = "SetPlan_Title";
            this.SetPlan_Title.Size = new System.Drawing.Size(148, 19);
            this.SetPlan_Title.TabIndex = 5;
            this.SetPlan_Title.Text = "タイトル";
            // 
            // Button_PlanSave
            // 
            this.Button_PlanSave.Location = new System.Drawing.Point(168, 182);
            this.Button_PlanSave.Name = "Button_PlanSave";
            this.Button_PlanSave.Size = new System.Drawing.Size(75, 23);
            this.Button_PlanSave.TabIndex = 14;
            this.Button_PlanSave.Text = "完了";
            this.Button_PlanSave.UseVisualStyleBackColor = true;
            // 
            // Button_CheckPlan
            // 
            this.Button_CheckPlan.Location = new System.Drawing.Point(168, 153);
            this.Button_CheckPlan.Name = "Button_CheckPlan";
            this.Button_CheckPlan.Size = new System.Drawing.Size(75, 23);
            this.Button_CheckPlan.TabIndex = 15;
            this.Button_CheckPlan.Text = "予定の確認";
            this.Button_CheckPlan.UseVisualStyleBackColor = true;
            this.Button_CheckPlan.Click += new System.EventHandler(this.Button_CheckPlan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "残りの一日";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(166, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "事前予告";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Button_CallSet
            // 
            this.Button_CallSet.Location = new System.Drawing.Point(166, 124);
            this.Button_CallSet.Name = "Button_CallSet";
            this.Button_CallSet.Size = new System.Drawing.Size(75, 23);
            this.Button_CallSet.TabIndex = 24;
            this.Button_CallSet.Text = "予告の設定";
            this.Button_CallSet.UseVisualStyleBackColor = true;
            // 
            // Button_TimeSet
            // 
            this.Button_TimeSet.Location = new System.Drawing.Point(163, 69);
            this.Button_TimeSet.Name = "Button_TimeSet";
            this.Button_TimeSet.Size = new System.Drawing.Size(75, 23);
            this.Button_TimeSet.TabIndex = 25;
            this.Button_TimeSet.Text = "時間の設定";
            this.Button_TimeSet.UseVisualStyleBackColor = true;
            // 
            // CheckPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 210);
            this.Controls.Add(this.Button_TimeSet);
            this.Controls.Add(this.Button_CallSet);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_CheckPlan);
            this.Controls.Add(this.Button_PlanSave);
            this.Controls.Add(this.SetPlan_Title);
            this.Controls.Add(this.SetPlan_Absence);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DrawClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CheckPlan";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Clock_Timer;
        private System.Windows.Forms.Button DrawClock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox SetPlan_Absence;
        private System.Windows.Forms.TextBox SetPlan_Title;
        private System.Windows.Forms.Button Button_PlanSave;
        private System.Windows.Forms.Button Button_CheckPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Button_CallSet;
        private System.Windows.Forms.Button Button_TimeSet;
    }
}

