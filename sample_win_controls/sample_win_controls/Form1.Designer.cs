namespace sample_win_controls
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.medicalControl2 = new sample_win_controls.controls.MedicalControl();
            this.medicalControl1 = new sample_win_controls.controls.MedicalControl();
            this.SuspendLayout();
            // 
            // medicalControl2
            // 
            this.medicalControl2.Location = new System.Drawing.Point(41, 234);
            this.medicalControl2.Name = "medicalControl2";
            this.medicalControl2.Size = new System.Drawing.Size(559, 139);
            this.medicalControl2.TabIndex = 1;
            // 
            // medicalControl1
            // 
            this.medicalControl1.Location = new System.Drawing.Point(41, 40);
            this.medicalControl1.Name = "medicalControl1";
            this.medicalControl1.Size = new System.Drawing.Size(559, 139);
            this.medicalControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.medicalControl2);
            this.Controls.Add(this.medicalControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MedicalControl medicalControl1;
        private controls.MedicalControl medicalControl2;
    }
}

