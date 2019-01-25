namespace FolderMaker {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFolderList = new System.Windows.Forms.DataGridView();
            this.folderitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowseList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkSeq = new System.Windows.Forms.CheckBox();
            this.udDigit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeparater = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupPos = new System.Windows.Forms.GroupBox();
            this.rdoSuffix = new System.Windows.Forms.RadioButton();
            this.rdoPrefix = new System.Windows.Forms.RadioButton();
            this.folderItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.folderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDigit)).BeginInit();
            this.groupPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(97, 12);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(215, 19);
            this.txtDest.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Location = new System.Drawing.Point(318, 10);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDest.TabIndex = 1;
            this.btnBrowseDest.Text = "参照...(&B)";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作成先(&D):";
            // 
            // dgvFolderList
            // 
            this.dgvFolderList.AllowUserToOrderColumns = true;
            this.dgvFolderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderitem});
            this.dgvFolderList.Location = new System.Drawing.Point(14, 76);
            this.dgvFolderList.Name = "dgvFolderList";
            this.dgvFolderList.RowTemplate.Height = 21;
            this.dgvFolderList.Size = new System.Drawing.Size(460, 291);
            this.dgvFolderList.TabIndex = 3;
            // 
            // folderitem
            // 
            this.folderitem.HeaderText = "フォルダ名";
            this.folderitem.Name = "folderitem";
            this.folderitem.Width = 300;
            // 
            // btnBrowseList
            // 
            this.btnBrowseList.Location = new System.Drawing.Point(318, 45);
            this.btnBrowseList.Name = "btnBrowseList";
            this.btnBrowseList.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseList.TabIndex = 4;
            this.btnBrowseList.Text = "参照...(&R)";
            this.btnBrowseList.UseVisualStyleBackColor = true;
            this.btnBrowseList.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "一覧ファイル(&L):";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 420);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "作成(&G)";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkSeq
            // 
            this.chkSeq.AutoSize = true;
            this.chkSeq.Location = new System.Drawing.Point(14, 384);
            this.chkSeq.Name = "chkSeq";
            this.chkSeq.Size = new System.Drawing.Size(96, 16);
            this.chkSeq.TabIndex = 7;
            this.chkSeq.Text = "連番を付す(&S):";
            this.chkSeq.UseVisualStyleBackColor = true;
            // 
            // udDigit
            // 
            this.udDigit.Location = new System.Drawing.Point(113, 382);
            this.udDigit.Name = "udDigit";
            this.udDigit.Size = new System.Drawing.Size(45, 19);
            this.udDigit.TabIndex = 9;
            this.udDigit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "桁";
            // 
            // txtSeparater
            // 
            this.txtSeparater.Location = new System.Drawing.Point(275, 382);
            this.txtSeparater.Name = "txtSeparater";
            this.txtSeparater.Size = new System.Drawing.Size(55, 19);
            this.txtSeparater.TabIndex = 11;
            this.txtSeparater.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "区切り文字(&E):";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(97, 47);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(215, 19);
            this.txtList.TabIndex = 13;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(399, 45);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "読み込み";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(138, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "リストのクリア(&C)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupPos
            // 
            this.groupPos.Controls.Add(this.rdoSuffix);
            this.groupPos.Controls.Add(this.rdoPrefix);
            this.groupPos.Location = new System.Drawing.Point(350, 384);
            this.groupPos.Name = "groupPos";
            this.groupPos.Size = new System.Drawing.Size(124, 59);
            this.groupPos.TabIndex = 18;
            this.groupPos.TabStop = false;
            this.groupPos.Text = "位置";
            // 
            // rdoSuffix
            // 
            this.rdoSuffix.AutoSize = true;
            this.rdoSuffix.Location = new System.Drawing.Point(73, 27);
            this.rdoSuffix.Name = "rdoSuffix";
            this.rdoSuffix.Size = new System.Drawing.Size(35, 16);
            this.rdoSuffix.TabIndex = 19;
            this.rdoSuffix.Text = "後";
            this.rdoSuffix.UseVisualStyleBackColor = true;
            // 
            // rdoPrefix
            // 
            this.rdoPrefix.AutoSize = true;
            this.rdoPrefix.Checked = true;
            this.rdoPrefix.Location = new System.Drawing.Point(21, 27);
            this.rdoPrefix.Name = "rdoPrefix";
            this.rdoPrefix.Size = new System.Drawing.Size(35, 16);
            this.rdoPrefix.TabIndex = 18;
            this.rdoPrefix.TabStop = true;
            this.rdoPrefix.Text = "前";
            this.rdoPrefix.UseVisualStyleBackColor = true;
            // 
            // folderItemBindingSource2
            // 
            this.folderItemBindingSource2.DataSource = typeof(FolderMaker.FolderItem);
            // 
            // folderItemBindingSource
            // 
            this.folderItemBindingSource.DataSource = typeof(FolderMaker.FolderItem);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(FolderMaker.Program);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(FolderMaker.Form1);
            // 
            // folderItemBindingSource1
            // 
            this.folderItemBindingSource1.DataSource = typeof(FolderMaker.FolderItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 485);
            this.Controls.Add(this.groupPos);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeparater);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udDigit);
            this.Controls.Add(this.chkSeq);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseList);
            this.Controls.Add(this.dgvFolderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseDest);
            this.Controls.Add(this.txtDest);
            this.Name = "Form1";
            this.Text = "FolderMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDigit)).EndInit();
            this.groupPos.ResumeLayout(false);
            this.groupPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFolderList;
        private System.Windows.Forms.Button btnBrowseList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkSeq;
        private System.Windows.Forms.NumericUpDown udDigit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeparater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.BindingSource folderItemBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource folderItemBindingSource2;
        private System.Windows.Forms.BindingSource folderItemBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderitem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupPos;
        private System.Windows.Forms.RadioButton rdoSuffix;
        private System.Windows.Forms.RadioButton rdoPrefix;
    }
}

