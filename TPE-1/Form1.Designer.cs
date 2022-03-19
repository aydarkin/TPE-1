namespace TPE_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.nudFactors = new System.Windows.Forms.NumericUpDown();
            this.nudVar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbPFE = new System.Windows.Forms.RadioButton();
            this.rbDFE = new System.Windows.Forms.RadioButton();
            this.nudEffects = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffects)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(16, 15);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 60;
            this.grid.Size = new System.Drawing.Size(797, 524);
            this.grid.TabIndex = 0;
            // 
            // nudFactors
            // 
            this.nudFactors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFactors.Location = new System.Drawing.Point(853, 52);
            this.nudFactors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFactors.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFactors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFactors.Name = "nudFactors";
            this.nudFactors.Size = new System.Drawing.Size(137, 22);
            this.nudFactors.TabIndex = 1;
            this.nudFactors.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudVar
            // 
            this.nudVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVar.Location = new System.Drawing.Point(855, 273);
            this.nudVar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudVar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVar.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVar.Name = "nudVar";
            this.nudVar.Size = new System.Drawing.Size(137, 22);
            this.nudVar.TabIndex = 2;
            this.nudVar.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Факторов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Варьирований";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(853, 464);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(160, 28);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Построить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rbPFE
            // 
            this.rbPFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPFE.AutoSize = true;
            this.rbPFE.Checked = true;
            this.rbPFE.Location = new System.Drawing.Point(865, 331);
            this.rbPFE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPFE.Name = "rbPFE";
            this.rbPFE.Size = new System.Drawing.Size(59, 20);
            this.rbPFE.TabIndex = 5;
            this.rbPFE.TabStop = true;
            this.rbPFE.Text = "ПФЭ";
            this.rbPFE.UseVisualStyleBackColor = true;
            this.rbPFE.CheckedChanged += new System.EventHandler(this.rbPFE_CheckedChanged);
            // 
            // rbDFE
            // 
            this.rbDFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDFE.AutoSize = true;
            this.rbDFE.Location = new System.Drawing.Point(866, 359);
            this.rbDFE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDFE.Name = "rbDFE";
            this.rbDFE.Size = new System.Drawing.Size(58, 20);
            this.rbDFE.TabIndex = 6;
            this.rbDFE.Text = "ДФЭ";
            this.rbDFE.UseVisualStyleBackColor = true;
            this.rbDFE.CheckedChanged += new System.EventHandler(this.rbPFE_CheckedChanged);
            // 
            // nudEffects
            // 
            this.nudEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEffects.Location = new System.Drawing.Point(853, 130);
            this.nudEffects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudEffects.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEffects.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEffects.Name = "nudEffects";
            this.nudEffects.Size = new System.Drawing.Size(137, 22);
            this.nudEffects.TabIndex = 1;
            this.nudEffects.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEffects.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Эффектов";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rbDFE);
            this.Controls.Add(this.rbPFE);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudVar);
            this.Controls.Add(this.nudEffects);
            this.Controls.Add(this.nudFactors);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(394, 358);
            this.Name = "Form1";
            this.Text = "ТПЭ 1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.NumericUpDown nudFactors;
        private System.Windows.Forms.NumericUpDown nudVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbPFE;
        private System.Windows.Forms.RadioButton rbDFE;
        private System.Windows.Forms.NumericUpDown nudEffects;
        private System.Windows.Forms.Label label3;
    }
}

