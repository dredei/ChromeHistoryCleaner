namespace ChromeHistoryCleaner
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudVisitCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDefDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMakeBackup = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу History:";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(3, 16);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(344, 20);
            this.tbFilePath.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFile.Location = new System.Drawing.Point(353, 14);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Удалить записи с количеством посещений менее чем";
            // 
            // nudVisitCount
            // 
            this.nudVisitCount.Location = new System.Drawing.Point(290, 38);
            this.nudVisitCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVisitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVisitCount.Name = "nudVisitCount";
            this.nudVisitCount.Size = new System.Drawing.Size(45, 20);
            this.nudVisitCount.TabIndex = 5;
            this.nudVisitCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "раз (а)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Защитить недавние записии за";
            // 
            // nudDefDays
            // 
            this.nudDefDays.Location = new System.Drawing.Point(174, 56);
            this.nudDefDays.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDefDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefDays.Name = "nudDefDays";
            this.nudDefDays.Size = new System.Drawing.Size(45, 20);
            this.nudDefDays.TabIndex = 8;
            this.nudDefDays.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "дней от удаления";
            // 
            // cbMakeBackup
            // 
            this.cbMakeBackup.AutoSize = true;
            this.cbMakeBackup.Checked = true;
            this.cbMakeBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMakeBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMakeBackup.Location = new System.Drawing.Point(3, 74);
            this.cbMakeBackup.Name = "cbMakeBackup";
            this.cbMakeBackup.Size = new System.Drawing.Size(161, 17);
            this.cbMakeBackup.TabIndex = 10;
            this.cbMakeBackup.Text = "Сделать резервную копию";
            this.cbMakeBackup.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(3, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(378, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(383, 122);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbMakeBackup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDefDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudVisitCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrome History Cleaner v1.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudVisitCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDefDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMakeBackup;
        private System.Windows.Forms.Button btnStart;
    }
}

