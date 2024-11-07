namespace VacancyViewer1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewerTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.documentTable = new System.Windows.Forms.DataGridView();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.viewerTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.viewerTab);
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 971);
            this.tabControl1.TabIndex = 0;
            // 
            // viewerTab
            // 
            this.viewerTab.Controls.Add(this.chooseDepartmentComboBox);
            this.viewerTab.Controls.Add(this.richTextBox1);
            this.viewerTab.Location = new System.Drawing.Point(4, 22);
            this.viewerTab.Name = "viewerTab";
            this.viewerTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewerTab.Size = new System.Drawing.Size(1064, 945);
            this.viewerTab.TabIndex = 0;
            this.viewerTab.Text = "Анкета";
            this.viewerTab.UseVisualStyleBackColor = true;
            this.viewerTab.Click += new System.EventHandler(this.viewerTab_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1061, 911);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.documentTable);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(1064, 945);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "Информация";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // documentTable
            // 
            this.documentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creationDate,
            this.documentName,
            this.username,
            this.openDate,
            this.comment,
            this.result});
            this.documentTable.Location = new System.Drawing.Point(0, 0);
            this.documentTable.Name = "documentTable";
            this.documentTable.Size = new System.Drawing.Size(1058, 912);
            this.documentTable.TabIndex = 0;
            this.documentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "Дата создания";
            this.creationDate.Name = "creationDate";
            this.creationDate.ReadOnly = true;
            // 
            // documentName
            // 
            this.documentName.HeaderText = "Название";
            this.documentName.Name = "documentName";
            this.documentName.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Имя пользователя";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // openDate
            // 
            this.openDate.HeaderText = "Дата открытия";
            this.openDate.Name = "openDate";
            this.openDate.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            // 
            // result
            // 
            this.result.HeaderText = "Принятое решение";
            this.result.Name = "result";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // chooseDepartmentComboBox
            // 
            this.chooseDepartmentComboBox.FormattingEnabled = true;
            this.chooseDepartmentComboBox.Location = new System.Drawing.Point(6, 7);
            this.chooseDepartmentComboBox.Name = "chooseDepartmentComboBox";
            this.chooseDepartmentComboBox.Size = new System.Drawing.Size(263, 21);
            this.chooseDepartmentComboBox.TabIndex = 3;
            this.chooseDepartmentComboBox.Text = "Выбор подразделения";
            this.chooseDepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDepartmentComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 973);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.viewerTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.DataGridView documentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage viewerTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox chooseDepartmentComboBox;
    }
}

