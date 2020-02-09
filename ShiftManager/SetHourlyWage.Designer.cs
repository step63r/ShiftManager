namespace ShiftManager
{
    partial class SetHourlyWage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppliedList = new System.Windows.Forms.ListBox();
            this.weekcombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eMin = new System.Windows.Forms.NumericUpDown();
            this.eHour = new System.Windows.Forms.NumericUpDown();
            this.sHour = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.sMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppliedList
            // 
            this.AppliedList.Dock = System.Windows.Forms.DockStyle.Right;
            this.AppliedList.FormattingEnabled = true;
            this.AppliedList.ItemHeight = 17;
            this.AppliedList.Location = new System.Drawing.Point(257, 0);
            this.AppliedList.Name = "AppliedList";
            this.AppliedList.Size = new System.Drawing.Size(179, 242);
            this.AppliedList.TabIndex = 0;
            // 
            // weekcombo
            // 
            this.weekcombo.FormattingEnabled = true;
            this.weekcombo.Items.AddRange(new object[] {
            "日曜日",
            "月曜日",
            "火曜日",
            "水曜日",
            "木曜日",
            "金曜日",
            "土曜日",
            "祝日"});
            this.weekcombo.Location = new System.Drawing.Point(12, 12);
            this.weekcombo.Name = "weekcombo";
            this.weekcombo.Size = new System.Drawing.Size(104, 25);
            this.weekcombo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "まで";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "から";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = ":";
            // 
            // eMin
            // 
            this.eMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eMin.Location = new System.Drawing.Point(74, 96);
            this.eMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.eMin.Name = "eMin";
            this.eMin.Size = new System.Drawing.Size(40, 24);
            this.eMin.TabIndex = 13;
            // 
            // eHour
            // 
            this.eHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eHour.Location = new System.Drawing.Point(12, 96);
            this.eHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.eHour.Name = "eHour";
            this.eHour.Size = new System.Drawing.Size(40, 24);
            this.eHour.TabIndex = 12;
            // 
            // sHour
            // 
            this.sHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sHour.Location = new System.Drawing.Point(12, 66);
            this.sHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.sHour.Name = "sHour";
            this.sHour.Size = new System.Drawing.Size(40, 24);
            this.sHour.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = ":";
            // 
            // sMin
            // 
            this.sMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sMin.Location = new System.Drawing.Point(74, 66);
            this.sMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.sMin.Name = "sMin";
            this.sMin.Size = new System.Drawing.Size(40, 24);
            this.sMin.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 24);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "時給";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "円";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(154, 66);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 27);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = ">> 追加 >>";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(154, 128);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 27);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "<< 削除 <<";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "呼び出し";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(115, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 27);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SetHourlyWage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 242);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.eMin);
            this.Controls.Add(this.eHour);
            this.Controls.Add(this.sHour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sMin);
            this.Controls.Add(this.weekcombo);
            this.Controls.Add(this.AppliedList);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetHourlyWage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "給与体系の設定";
            this.Load += new System.EventHandler(this.SetHourlyWage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AppliedList;
        private System.Windows.Forms.ComboBox weekcombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown eMin;
        private System.Windows.Forms.NumericUpDown eHour;
        private System.Windows.Forms.NumericUpDown sHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sMin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
    }
}