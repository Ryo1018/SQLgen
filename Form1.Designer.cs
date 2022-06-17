namespace SQLgenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.table_textbox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.RadioButton();
            this.updatebutton = new System.Windows.Forms.RadioButton();
            this.deletebutton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectbutton = new System.Windows.Forms.RadioButton();
            this.result_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.select_menu = new System.Windows.Forms.GroupBox();
            this.deduplication_column_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parameters_textbox = new System.Windows.Forms.TextBox();
            this.order_desc_button = new System.Windows.Forms.RadioButton();
            this.order_asc_button = new System.Windows.Forms.RadioButton();
            this.is_deduplication = new System.Windows.Forms.CheckBox();
            this.column_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.LinkLabel();
            this.builder = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.select_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "WHAT\'S TABLE?";
            // 
            // table_textbox
            // 
            this.table_textbox.Location = new System.Drawing.Point(132, 17);
            this.table_textbox.Name = "table_textbox";
            this.table_textbox.Size = new System.Drawing.Size(256, 19);
            this.table_textbox.TabIndex = 1;
            this.table_textbox.TextChanged += new System.EventHandler(this.table_changed);
            // 
            // insertbutton
            // 
            this.insertbutton.AutoSize = true;
            this.insertbutton.Location = new System.Drawing.Point(112, 18);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(63, 16);
            this.insertbutton.TabIndex = 3;
            this.insertbutton.TabStop = true;
            this.insertbutton.Text = "INSERT";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.CheckedChanged += new System.EventHandler(this.insertbutton_CheckedChanged);
            // 
            // updatebutton
            // 
            this.updatebutton.AutoSize = true;
            this.updatebutton.Location = new System.Drawing.Point(207, 18);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(68, 16);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.TabStop = true;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.CheckedChanged += new System.EventHandler(this.updatebutton_CheckedChanged);
            // 
            // deletebutton
            // 
            this.deletebutton.AutoSize = true;
            this.deletebutton.Location = new System.Drawing.Point(303, 18);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(65, 16);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.TabStop = true;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.CheckedChanged += new System.EventHandler(this.deletebutton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectbutton);
            this.groupBox1.Controls.Add(this.insertbutton);
            this.groupBox1.Controls.Add(this.deletebutton);
            this.groupBox1.Controls.Add(this.updatebutton);
            this.groupBox1.Location = new System.Drawing.Point(20, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WHAT DO YOU WANT TO DO?";
            // 
            // selectbutton
            // 
            this.selectbutton.AutoSize = true;
            this.selectbutton.Location = new System.Drawing.Point(15, 18);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(65, 16);
            this.selectbutton.TabIndex = 6;
            this.selectbutton.TabStop = true;
            this.selectbutton.Text = "SELECT";
            this.selectbutton.UseVisualStyleBackColor = true;
            this.selectbutton.CheckedChanged += new System.EventHandler(this.selectbutton_CheckedChanged);
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.result_text.Location = new System.Drawing.Point(20, 403);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.result_text.Size = new System.Drawing.Size(386, 93);
            this.result_text.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "RESULT";
            // 
            // select_menu
            // 
            this.select_menu.Controls.Add(this.deduplication_column_textbox);
            this.select_menu.Controls.Add(this.label4);
            this.select_menu.Controls.Add(this.parameters_textbox);
            this.select_menu.Controls.Add(this.order_desc_button);
            this.select_menu.Controls.Add(this.order_asc_button);
            this.select_menu.Controls.Add(this.is_deduplication);
            this.select_menu.Controls.Add(this.column_textbox);
            this.select_menu.Controls.Add(this.label3);
            this.select_menu.Location = new System.Drawing.Point(20, 112);
            this.select_menu.Name = "select_menu";
            this.select_menu.Size = new System.Drawing.Size(386, 227);
            this.select_menu.TabIndex = 9;
            this.select_menu.TabStop = false;
            this.select_menu.Text = "MENU";
            // 
            // deduplication_column_textbox
            // 
            this.deduplication_column_textbox.Location = new System.Drawing.Point(134, 197);
            this.deduplication_column_textbox.Name = "deduplication_column_textbox";
            this.deduplication_column_textbox.ReadOnly = true;
            this.deduplication_column_textbox.Size = new System.Drawing.Size(111, 19);
            this.deduplication_column_textbox.TabIndex = 7;
            this.deduplication_column_textbox.Text = "COLUMN";
            this.deduplication_column_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "PARAMETERS";
            // 
            // parameters_textbox
            // 
            this.parameters_textbox.Location = new System.Drawing.Point(16, 77);
            this.parameters_textbox.Multiline = true;
            this.parameters_textbox.Name = "parameters_textbox";
            this.parameters_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.parameters_textbox.Size = new System.Drawing.Size(353, 100);
            this.parameters_textbox.TabIndex = 5;
            // 
            // order_desc_button
            // 
            this.order_desc_button.AutoSize = true;
            this.order_desc_button.Location = new System.Drawing.Point(315, 197);
            this.order_desc_button.Name = "order_desc_button";
            this.order_desc_button.Size = new System.Drawing.Size(53, 16);
            this.order_desc_button.TabIndex = 4;
            this.order_desc_button.TabStop = true;
            this.order_desc_button.Text = "DESC";
            this.order_desc_button.UseVisualStyleBackColor = true;
            // 
            // order_asc_button
            // 
            this.order_asc_button.AutoSize = true;
            this.order_asc_button.Location = new System.Drawing.Point(263, 197);
            this.order_asc_button.Name = "order_asc_button";
            this.order_asc_button.Size = new System.Drawing.Size(46, 16);
            this.order_asc_button.TabIndex = 3;
            this.order_asc_button.TabStop = true;
            this.order_asc_button.Text = "ASC";
            this.order_asc_button.UseVisualStyleBackColor = true;
            // 
            // is_deduplication
            // 
            this.is_deduplication.AutoSize = true;
            this.is_deduplication.Location = new System.Drawing.Point(15, 198);
            this.is_deduplication.Name = "is_deduplication";
            this.is_deduplication.Size = new System.Drawing.Size(113, 16);
            this.is_deduplication.TabIndex = 2;
            this.is_deduplication.Text = "DEDUPLICATION";
            this.is_deduplication.UseVisualStyleBackColor = true;
            this.is_deduplication.CheckedChanged += new System.EventHandler(this.is_deduplication_CheckedChanged);
            // 
            // column_textbox
            // 
            this.column_textbox.Location = new System.Drawing.Point(76, 26);
            this.column_textbox.Name = "column_textbox";
            this.column_textbox.Size = new System.Drawing.Size(292, 19);
            this.column_textbox.TabIndex = 1;
            this.column_textbox.TextChanged += new System.EventHandler(this.select_column_text_changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "COLUMN";
            // 
            // run_button
            // 
            this.run_button.BackColor = System.Drawing.Color.White;
            this.run_button.Cursor = System.Windows.Forms.Cursors.No;
            this.run_button.Enabled = false;
            this.run_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.run_button.Location = new System.Drawing.Point(298, 354);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(108, 32);
            this.run_button.TabIndex = 10;
            this.run_button.Text = "RUN";
            this.run_button.UseVisualStyleBackColor = false;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // copy_button
            // 
            this.copy_button.AutoSize = true;
            this.copy_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_button.Location = new System.Drawing.Point(94, 388);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(35, 12);
            this.copy_button.TabIndex = 11;
            this.copy_button.TabStop = true;
            this.copy_button.Text = "COPY";
            this.copy_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copy_button_LinkClicked);
            // 
            // builder
            // 
            this.builder.AutoSize = true;
            this.builder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.builder.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.builder.Location = new System.Drawing.Point(334, 499);
            this.builder.Name = "builder";
            this.builder.Size = new System.Drawing.Size(83, 11);
            this.builder.TabIndex = 12;
            this.builder.TabStop = true;
            this.builder.Text = "build by Ryo1018";
            this.builder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.builder_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 517);
            this.Controls.Add(this.builder);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.select_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 556);
            this.MinimumSize = new System.Drawing.Size(445, 556);
            this.Name = "Form1";
            this.Text = "SQLgenerator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.select_menu.ResumeLayout(false);
            this.select_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox table_textbox;
        private System.Windows.Forms.RadioButton insertbutton;
        private System.Windows.Forms.RadioButton updatebutton;
        private System.Windows.Forms.RadioButton deletebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selectbutton;
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox select_menu;
        private System.Windows.Forms.TextBox deduplication_column_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parameters_textbox;
        private System.Windows.Forms.RadioButton order_desc_button;
        private System.Windows.Forms.RadioButton order_asc_button;
        private System.Windows.Forms.CheckBox is_deduplication;
        private System.Windows.Forms.TextBox column_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.LinkLabel copy_button;
        private System.Windows.Forms.LinkLabel builder;
    }
}

