
namespace Word2Text
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_trans_txt = new System.Windows.Forms.Button();
            this.rdo_txt = new System.Windows.Forms.RadioButton();
            this.rdo_word = new System.Windows.Forms.RadioButton();
            this.btn_trans_word = new System.Windows.Forms.Button();
            this.lb_finish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(397, 40);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(30, 29);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "…";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 42);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(379, 27);
            this.txt_path.TabIndex = 1;
            // 
            // btn_trans_txt
            // 
            this.btn_trans_txt.Location = new System.Drawing.Point(433, 40);
            this.btn_trans_txt.Name = "btn_trans_txt";
            this.btn_trans_txt.Size = new System.Drawing.Size(94, 29);
            this.btn_trans_txt.TabIndex = 2;
            this.btn_trans_txt.Text = "入替";
            this.btn_trans_txt.UseVisualStyleBackColor = true;
            this.btn_trans_txt.Click += new System.EventHandler(this.btn_trans_txt_Click);
            // 
            // rdo_txt
            // 
            this.rdo_txt.AutoSize = true;
            this.rdo_txt.Checked = true;
            this.rdo_txt.Location = new System.Drawing.Point(12, 12);
            this.rdo_txt.Name = "rdo_txt";
            this.rdo_txt.Size = new System.Drawing.Size(56, 24);
            this.rdo_txt.TabIndex = 3;
            this.rdo_txt.TabStop = true;
            this.rdo_txt.Text = "Text";
            this.rdo_txt.UseVisualStyleBackColor = true;
            this.rdo_txt.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdo_word
            // 
            this.rdo_word.AutoSize = true;
            this.rdo_word.Location = new System.Drawing.Point(74, 12);
            this.rdo_word.Name = "rdo_word";
            this.rdo_word.Size = new System.Drawing.Size(66, 24);
            this.rdo_word.TabIndex = 4;
            this.rdo_word.Text = "Word";
            this.rdo_word.UseVisualStyleBackColor = true;
            this.rdo_word.Visible = false;
            this.rdo_word.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // btn_trans_word
            // 
            this.btn_trans_word.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_trans_word.Location = new System.Drawing.Point(433, 40);
            this.btn_trans_word.Name = "btn_trans_word";
            this.btn_trans_word.Size = new System.Drawing.Size(94, 29);
            this.btn_trans_word.TabIndex = 5;
            this.btn_trans_word.Text = "入替";
            this.btn_trans_word.UseVisualStyleBackColor = true;
            this.btn_trans_word.Visible = false;
            this.btn_trans_word.Click += new System.EventHandler(this.btn_trans_word_Click);
            // 
            // lb_finish
            // 
            this.lb_finish.AutoSize = true;
            this.lb_finish.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_finish.Location = new System.Drawing.Point(12, 75);
            this.lb_finish.Name = "lb_finish";
            this.lb_finish.Size = new System.Drawing.Size(226, 35);
            this.lb_finish.TabIndex = 6;
            this.lb_finish.Text = "ファイル保存しました。";
            this.lb_finish.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 126);
            this.Controls.Add(this.lb_finish);
            this.Controls.Add(this.btn_trans_word);
            this.Controls.Add(this.rdo_word);
            this.Controls.Add(this.rdo_txt);
            this.Controls.Add(this.btn_trans_txt);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_trans_txt;
        private System.Windows.Forms.RadioButton rdo_txt;
        private System.Windows.Forms.RadioButton rdo_word;
        private System.Windows.Forms.Button btn_trans_word;
        private System.Windows.Forms.Label lb_finish;
    }
}

