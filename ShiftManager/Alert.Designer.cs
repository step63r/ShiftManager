namespace ShiftManager
{
    partial class Alert
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
            this.label1 = new System.Windows.Forms.Label();
            this.alchk = new System.Windows.Forms.CheckBox();
            this.OverWork = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OverWork)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "月の実働時間が";
            // 
            // alchk
            // 
            this.alchk.AutoSize = true;
            this.alchk.Location = new System.Drawing.Point(12, 12);
            this.alchk.Name = "alchk";
            this.alchk.Size = new System.Drawing.Size(133, 21);
            this.alchk.TabIndex = 1;
            this.alchk.Text = "アラートを有効にする";
            this.alchk.UseVisualStyleBackColor = true;
            this.alchk.CheckedChanged += new System.EventHandler(this.alchk_CheckedChanged);
            // 
            // OverWork
            // 
            this.OverWork.Location = new System.Drawing.Point(49, 66);
            this.OverWork.Maximum = new decimal(new int[] {
            744,
            0,
            0,
            0});
            this.OverWork.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OverWork.Name = "OverWork";
            this.OverWork.Size = new System.Drawing.Size(58, 24);
            this.OverWork.TabIndex = 2;
            this.OverWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OverWork.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "時間を超えたら通知";
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(12, 114);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(106, 29);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "O K";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(144, 114);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(106, 29);
            this.Cancelbutton.TabIndex = 5;
            this.Cancelbutton.Text = "キャンセル";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 155);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OverWork);
            this.Controls.Add(this.alchk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "アラートの設定";
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OverWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alchk;
        private System.Windows.Forms.NumericUpDown OverWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}