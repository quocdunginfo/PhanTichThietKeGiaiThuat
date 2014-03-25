namespace PhanTichThietKeGiaiThuat
{
    partial class BienDoiDeTriFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienDoiDeTriFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.tabHeapSort = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_qd_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_qd_n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_q = new System.Windows.Forms.Button();
            this.richTextBox_qd_output = new System.Windows.Forms.RichTextBox();
            this.richTextBox_qd_input = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabBienDoiDeTri = new System.Windows.Forms.TabControl();
            this.tabHeapSort.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabBienDoiDeTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabHeapSort
            // 
            this.tabHeapSort.Controls.Add(this.groupBox3);
            this.tabHeapSort.Controls.Add(this.groupBox4);
            this.tabHeapSort.Location = new System.Drawing.Point(4, 22);
            this.tabHeapSort.Name = "tabHeapSort";
            this.tabHeapSort.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeapSort.Size = new System.Drawing.Size(698, 401);
            this.tabHeapSort.TabIndex = 1;
            this.tabHeapSort.Text = "HeapSort";
            this.tabHeapSort.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSelection);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_qd_time);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_qd_n);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button_q);
            this.groupBox3.Controls.Add(this.richTextBox_qd_output);
            this.groupBox3.Controls.Add(this.richTextBox_qd_input);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(350, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 389);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Time SelectionSort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Time MergeSort";
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(120, 317);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(173, 20);
            this.txtSelection.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time (ms):";
            // 
            // textBox_qd_time
            // 
            this.textBox_qd_time.Location = new System.Drawing.Point(120, 291);
            this.textBox_qd_time.Name = "textBox_qd_time";
            this.textBox_qd_time.Size = new System.Drawing.Size(173, 20);
            this.textBox_qd_time.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập n:";
            // 
            // textBox_qd_n
            // 
            this.textBox_qd_n.Location = new System.Drawing.Point(168, 20);
            this.textBox_qd_n.Name = "textBox_qd_n";
            this.textBox_qd_n.Size = new System.Drawing.Size(53, 20);
            this.textBox_qd_n.TabIndex = 13;
            this.textBox_qd_n.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "OUTPUT:";
            // 
            // button_q
            // 
            this.button_q.Location = new System.Drawing.Point(227, 18);
            this.button_q.Name = "button_q";
            this.button_q.Size = new System.Drawing.Size(99, 23);
            this.button_q.TabIndex = 10;
            this.button_q.Text = "Tạo ngẫu nhiên";
            this.button_q.UseVisualStyleBackColor = true;
            this.button_q.Click += new System.EventHandler(this.button_qd_taongaunhien_Click);
            // 
            // richTextBox_qd_output
            // 
            this.richTextBox_qd_output.Location = new System.Drawing.Point(20, 172);
            this.richTextBox_qd_output.Name = "richTextBox_qd_output";
            this.richTextBox_qd_output.Size = new System.Drawing.Size(306, 113);
            this.richTextBox_qd_output.TabIndex = 8;
            this.richTextBox_qd_output.Text = "";
            // 
            // richTextBox_qd_input
            // 
            this.richTextBox_qd_input.Location = new System.Drawing.Point(20, 46);
            this.richTextBox_qd_input.Name = "richTextBox_qd_input";
            this.richTextBox_qd_input.Size = new System.Drawing.Size(306, 91);
            this.richTextBox_qd_input.TabIndex = 9;
            this.richTextBox_qd_input.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INPUT";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 389);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đề bài";
            // 
            // tabBienDoiDeTri
            // 
            this.tabBienDoiDeTri.Controls.Add(this.tabHeapSort);
            this.tabBienDoiDeTri.Location = new System.Drawing.Point(12, 12);
            this.tabBienDoiDeTri.Name = "tabBienDoiDeTri";
            this.tabBienDoiDeTri.SelectedIndex = 0;
            this.tabBienDoiDeTri.Size = new System.Drawing.Size(706, 427);
            this.tabBienDoiDeTri.TabIndex = 1;
            // 
            // BienDoiDeTriFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.tabBienDoiDeTri);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BienDoiDeTriFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biến đổi để trị";
            this.tabHeapSort.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabBienDoiDeTri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabHeapSort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_qd_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_qd_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_q;
        private System.Windows.Forms.RichTextBox richTextBox_qd_output;
        private System.Windows.Forms.RichTextBox richTextBox_qd_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabBienDoiDeTri;
    }
}