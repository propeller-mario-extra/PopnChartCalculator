namespace PopnChartCalculator
{
    partial class PopnChartCaluclatorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopnChartCaluclatorForm));
            this.pixel4thNoteLabel = new System.Windows.Forms.Label();
            this.pixel4thNoteTextBox = new System.Windows.Forms.TextBox();
            this.pxLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.DisplayPixelWidth_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DisplayPixelWidth__ExplainLabel = new System.Windows.Forms.Label();
            this.pixel128thNoteLabel = new System.Windows.Forms.Label();
            this.pixel16thNotesListBox = new System.Windows.Forms.ListBox();
            this.pixel16thNotesListBox_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPixel16thNotesListBoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixel128thNotesListBox = new System.Windows.Forms.ListBox();
            this.pixel128thNotesListBox_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPixel128thNotesListBoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixel16thNotesListBox_ExplainLabel = new System.Windows.Forms.Label();
            this.pixel128thNotesListBox_ExplainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPixelWidth_NumericUpDown)).BeginInit();
            this.pixel16thNotesListBox_ContextMenuStrip.SuspendLayout();
            this.pixel128thNotesListBox_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pixel4thNoteLabel
            // 
            this.pixel4thNoteLabel.AutoSize = true;
            this.pixel4thNoteLabel.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel4thNoteLabel.Location = new System.Drawing.Point(12, 28);
            this.pixel4thNoteLabel.Name = "pixel4thNoteLabel";
            this.pixel4thNoteLabel.Size = new System.Drawing.Size(128, 42);
            this.pixel4thNoteLabel.TabIndex = 0;
            this.pixel4thNoteLabel.Text = "4分 = ";
            // 
            // pixel4thNoteTextBox
            // 
            this.pixel4thNoteTextBox.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.pixel4thNoteTextBox.Location = new System.Drawing.Point(146, 25);
            this.pixel4thNoteTextBox.Name = "pixel4thNoteTextBox";
            this.pixel4thNoteTextBox.Size = new System.Drawing.Size(218, 49);
            this.pixel4thNoteTextBox.TabIndex = 1;
            this.pixel4thNoteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pxLabel
            // 
            this.pxLabel.AutoSize = true;
            this.pxLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pxLabel.Location = new System.Drawing.Point(370, 50);
            this.pxLabel.Name = "pxLabel";
            this.pxLabel.Size = new System.Drawing.Size(33, 24);
            this.pxLabel.TabIndex = 2;
            this.pxLabel.Text = "px";
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalcButton.Location = new System.Drawing.Point(409, 13);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(148, 61);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "計算";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DisplayPixelWidth_NumericUpDown
            // 
            this.DisplayPixelWidth_NumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayPixelWidth_NumericUpDown.Location = new System.Drawing.Point(563, 43);
            this.DisplayPixelWidth_NumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DisplayPixelWidth_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisplayPixelWidth_NumericUpDown.Name = "DisplayPixelWidth_NumericUpDown";
            this.DisplayPixelWidth_NumericUpDown.Size = new System.Drawing.Size(53, 27);
            this.DisplayPixelWidth_NumericUpDown.TabIndex = 4;
            this.DisplayPixelWidth_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisplayPixelWidth_NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // DisplayPixelWidth__ExplainLabel
            // 
            this.DisplayPixelWidth__ExplainLabel.AutoSize = true;
            this.DisplayPixelWidth__ExplainLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayPixelWidth__ExplainLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayPixelWidth__ExplainLabel.Location = new System.Drawing.Point(563, 13);
            this.DisplayPixelWidth__ExplainLabel.Name = "DisplayPixelWidth__ExplainLabel";
            this.DisplayPixelWidth__ExplainLabel.Size = new System.Drawing.Size(232, 17);
            this.DisplayPixelWidth__ExplainLabel.TabIndex = 5;
            this.DisplayPixelWidth__ExplainLabel.Text = "表示するピクセルの間隔（128分）";
            // 
            // pixel128thNoteLabel
            // 
            this.pixel128thNoteLabel.AutoSize = true;
            this.pixel128thNoteLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel128thNoteLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pixel128thNoteLabel.Location = new System.Drawing.Point(631, 40);
            this.pixel128thNoteLabel.Name = "pixel128thNoteLabel";
            this.pixel128thNoteLabel.Size = new System.Drawing.Size(150, 30);
            this.pixel128thNoteLabel.TabIndex = 6;
            this.pixel128thNoteLabel.Text = "128分 = px";
            this.pixel128thNoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pixel16thNotesListBox
            // 
            this.pixel16thNotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pixel16thNotesListBox.ContextMenuStrip = this.pixel16thNotesListBox_ContextMenuStrip;
            this.pixel16thNotesListBox.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel16thNotesListBox.FormattingEnabled = true;
            this.pixel16thNotesListBox.HorizontalScrollbar = true;
            this.pixel16thNotesListBox.ItemHeight = 37;
            this.pixel16thNotesListBox.Location = new System.Drawing.Point(12, 150);
            this.pixel16thNotesListBox.Name = "pixel16thNotesListBox";
            this.pixel16thNotesListBox.Size = new System.Drawing.Size(352, 596);
            this.pixel16thNotesListBox.TabIndex = 7;
            // 
            // pixel16thNotesListBox_ContextMenuStrip
            // 
            this.pixel16thNotesListBox_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pixel16thNotesListBox_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPixel16thNotesListBoxItem});
            this.pixel16thNotesListBox_ContextMenuStrip.Name = "contextMenuStrip";
            this.pixel16thNotesListBox_ContextMenuStrip.Size = new System.Drawing.Size(240, 28);
            // 
            // copyPixel16thNotesListBoxItem
            // 
            this.copyPixel16thNotesListBoxItem.Name = "copyPixel16thNotesListBoxItem";
            this.copyPixel16thNotesListBoxItem.Size = new System.Drawing.Size(239, 24);
            this.copyPixel16thNotesListBoxItem.Text = "クリップボードへ数値をコピー";
            this.copyPixel16thNotesListBoxItem.Click += new System.EventHandler(this.copyPixel16thNotesListBoxItem_Click);
            // 
            // pixel128thNotesListBox
            // 
            this.pixel128thNotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pixel128thNotesListBox.ContextMenuStrip = this.pixel128thNotesListBox_ContextMenuStrip;
            this.pixel128thNotesListBox.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel128thNotesListBox.FormattingEnabled = true;
            this.pixel128thNotesListBox.HorizontalScrollbar = true;
            this.pixel128thNotesListBox.ItemHeight = 37;
            this.pixel128thNotesListBox.Location = new System.Drawing.Point(409, 150);
            this.pixel128thNotesListBox.Name = "pixel128thNotesListBox";
            this.pixel128thNotesListBox.Size = new System.Drawing.Size(436, 596);
            this.pixel128thNotesListBox.TabIndex = 8;
            // 
            // pixel128thNotesListBox_ContextMenuStrip
            // 
            this.pixel128thNotesListBox_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pixel128thNotesListBox_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPixel128thNotesListBoxItem});
            this.pixel128thNotesListBox_ContextMenuStrip.Name = "pixel128thNotesListBox_ContextMenuStrip";
            this.pixel128thNotesListBox_ContextMenuStrip.Size = new System.Drawing.Size(225, 28);
            // 
            // copyPixel128thNotesListBoxItem
            // 
            this.copyPixel128thNotesListBoxItem.Name = "copyPixel128thNotesListBoxItem";
            this.copyPixel128thNotesListBoxItem.Size = new System.Drawing.Size(224, 24);
            this.copyPixel128thNotesListBoxItem.Text = "クリップボードへ値をコピー";
            this.copyPixel128thNotesListBoxItem.Click += new System.EventHandler(this.copyPixel128thNotesListBoxItem_Click);
            // 
            // pixel16thNotesListBox_ExplainLabel
            // 
            this.pixel16thNotesListBox_ExplainLabel.AutoSize = true;
            this.pixel16thNotesListBox_ExplainLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel16thNotesListBox_ExplainLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pixel16thNotesListBox_ExplainLabel.Location = new System.Drawing.Point(14, 113);
            this.pixel16thNotesListBox_ExplainLabel.Name = "pixel16thNotesListBox_ExplainLabel";
            this.pixel16thNotesListBox_ExplainLabel.Size = new System.Drawing.Size(243, 25);
            this.pixel16thNotesListBox_ExplainLabel.TabIndex = 9;
            this.pixel16thNotesListBox_ExplainLabel.Text = "16分が何個あるか（px）";
            // 
            // pixel128thNotesListBox_ExplainLabel
            // 
            this.pixel128thNotesListBox_ExplainLabel.AutoSize = true;
            this.pixel128thNotesListBox_ExplainLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pixel128thNotesListBox_ExplainLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pixel128thNotesListBox_ExplainLabel.Location = new System.Drawing.Point(390, 113);
            this.pixel128thNotesListBox_ExplainLabel.Name = "pixel128thNotesListBox_ExplainLabel";
            this.pixel128thNotesListBox_ExplainLabel.Size = new System.Drawing.Size(446, 25);
            this.pixel128thNotesListBox_ExplainLabel.TabIndex = 10;
            this.pixel128thNotesListBox_ExplainLabel.Text = "128分が何個あるか（何ドットのズレがあるか）";
            this.pixel128thNotesListBox_ExplainLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PopnChartCaluclatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 768);
            this.Controls.Add(this.pixel128thNotesListBox_ExplainLabel);
            this.Controls.Add(this.pixel16thNotesListBox_ExplainLabel);
            this.Controls.Add(this.pixel128thNotesListBox);
            this.Controls.Add(this.pixel16thNotesListBox);
            this.Controls.Add(this.pixel128thNoteLabel);
            this.Controls.Add(this.DisplayPixelWidth__ExplainLabel);
            this.Controls.Add(this.DisplayPixelWidth_NumericUpDown);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.pxLabel);
            this.Controls.Add(this.pixel4thNoteTextBox);
            this.Controls.Add(this.pixel4thNoteLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopnChartCaluclatorForm";
            this.Text = "ポップン譜面作成用計算機";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPixelWidth_NumericUpDown)).EndInit();
            this.pixel16thNotesListBox_ContextMenuStrip.ResumeLayout(false);
            this.pixel128thNotesListBox_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pixel4thNoteLabel;
        private System.Windows.Forms.TextBox pixel4thNoteTextBox;
        private System.Windows.Forms.Label pxLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.NumericUpDown DisplayPixelWidth_NumericUpDown;
        private System.Windows.Forms.Label DisplayPixelWidth__ExplainLabel;
        private System.Windows.Forms.Label pixel128thNoteLabel;
        private System.Windows.Forms.ListBox pixel16thNotesListBox;
        private System.Windows.Forms.ListBox pixel128thNotesListBox;
        private System.Windows.Forms.Label pixel16thNotesListBox_ExplainLabel;
        private System.Windows.Forms.Label pixel128thNotesListBox_ExplainLabel;
        private System.Windows.Forms.ContextMenuStrip pixel16thNotesListBox_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyPixel16thNotesListBoxItem;
        private System.Windows.Forms.ContextMenuStrip pixel128thNotesListBox_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyPixel128thNotesListBoxItem;
    }
}

