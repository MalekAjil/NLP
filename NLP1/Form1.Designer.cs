namespace NLP1
{
    partial class Form1
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
            this.btnFindDerev = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDerev = new System.Windows.Forms.Button();
            this.btnFindOrign = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnPronounDerev = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPronoun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindDerev
            // 
            this.btnFindDerev.Enabled = false;
            this.btnFindDerev.Location = new System.Drawing.Point(14, 118);
            this.btnFindDerev.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnFindDerev.Name = "btnFindDerev";
            this.btnFindDerev.Size = new System.Drawing.Size(167, 40);
            this.btnFindDerev.TabIndex = 0;
            this.btnFindDerev.Text = "إيجاد المشتق";
            this.btnFindDerev.UseVisualStyleBackColor = true;
            this.btnFindDerev.Click += new System.EventHandler(this.btnFindDerev_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Andalus", 14F);
            this.lblInput.Location = new System.Drawing.Point(14, 77);
            this.lblInput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(82, 30);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "أدخل كلمة:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 32);
            this.textBox1.TabIndex = 2;
            // 
            // btnDerev
            // 
            this.btnDerev.Location = new System.Drawing.Point(14, 21);
            this.btnDerev.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnDerev.Name = "btnDerev";
            this.btnDerev.Size = new System.Drawing.Size(167, 40);
            this.btnDerev.TabIndex = 4;
            this.btnDerev.Text = "تحميل المشتقات";
            this.btnDerev.UseVisualStyleBackColor = true;
            this.btnDerev.Click += new System.EventHandler(this.btnDerev_Click);
            // 
            // btnFindOrign
            // 
            this.btnFindOrign.Enabled = false;
            this.btnFindOrign.Location = new System.Drawing.Point(189, 118);
            this.btnFindOrign.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnFindOrign.Name = "btnFindOrign";
            this.btnFindOrign.Size = new System.Drawing.Size(140, 40);
            this.btnFindOrign.TabIndex = 7;
            this.btnFindOrign.Text = "ايجاد الأصل";
            this.btnFindOrign.UseVisualStyleBackColor = true;
            this.btnFindOrign.Click += new System.EventHandler(this.btnFindOrign_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(14, 246);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(535, 285);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // btnPronounDerev
            // 
            this.btnPronounDerev.Enabled = false;
            this.btnPronounDerev.Location = new System.Drawing.Point(14, 183);
            this.btnPronounDerev.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnPronounDerev.Name = "btnPronounDerev";
            this.btnPronounDerev.Size = new System.Drawing.Size(167, 40);
            this.btnPronounDerev.TabIndex = 10;
            this.btnPronounDerev.Text = "إيجاد تصريفات الضمائر";
            this.btnPronounDerev.UseVisualStyleBackColor = true;
            this.btnPronounDerev.Click += new System.EventHandler(this.btnPronounDerev_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(14, 551);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(315, 40);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "بــحــث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "التحليل النحوي";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPronoun
            // 
            this.btnPronoun.Location = new System.Drawing.Point(191, 21);
            this.btnPronoun.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnPronoun.Name = "btnPronoun";
            this.btnPronoun.Size = new System.Drawing.Size(135, 40);
            this.btnPronoun.TabIndex = 13;
            this.btnPronoun.Text = "تحميل الضمائر";
            this.btnPronoun.UseVisualStyleBackColor = true;
            this.btnPronoun.Click += new System.EventHandler(this.btnPronoun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(457, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "مسح النص";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(191, 183);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(138, 40);
            this.btnSearch1.TabIndex = 16;
            this.btnSearch1.Text = "بحث";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 603);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPronoun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPronounDerev);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnFindOrign);
            this.Controls.Add(this.btnDerev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnFindDerev);
            this.Font = new System.Drawing.Font("Andalus", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المحلل الصرفي";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDerev;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDerev;
        private System.Windows.Forms.Button btnFindOrign;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnPronounDerev;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPronoun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch1;
    }
}

