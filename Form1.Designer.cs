namespace XDocument_Sample
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
            textBox1 = new TextBox();
            bt_clist_write = new Button();
            bt_delete = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lb_caliste = new ListBox();
            button6 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 40);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 35);
            textBox1.TabIndex = 0;
            // 
            // bt_clist_write
            // 
            bt_clist_write.Location = new Point(77, 101);
            bt_clist_write.Margin = new Padding(5, 6, 5, 6);
            bt_clist_write.Name = "bt_clist_write";
            bt_clist_write.Size = new Size(129, 46);
            bt_clist_write.TabIndex = 1;
            bt_clist_write.Text = "write";
            bt_clist_write.UseVisualStyleBackColor = true;
            bt_clist_write.Click += bt_clist_write_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(77, 168);
            bt_delete.Margin = new Padding(3, 4, 3, 4);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(130, 40);
            bt_delete.TabIndex = 2;
            bt_delete.Text = "delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += Bt_delete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(813, 144);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(221, 46);
            button4.TabIndex = 4;
            button4.Text = "create xml.xml";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Createxml_Click;
            // 
            // button5
            // 
            button5.Location = new Point(821, 252);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(262, 48);
            button5.TabIndex = 5;
            button5.Text = "replace entry with textbox";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Replace_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(855, 40);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 35);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1128, 252);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 35);
            textBox3.TabIndex = 7;
            textBox3.Text = "grafana";
            // 
            // lb_caliste
            // 
            lb_caliste.FormattingEnabled = true;
            lb_caliste.ItemHeight = 30;
            lb_caliste.Location = new Point(77, 281);
            lb_caliste.Margin = new Padding(5, 6, 5, 6);
            lb_caliste.Name = "lb_caliste";
            lb_caliste.Size = new Size(203, 184);
            lb_caliste.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(821, 328);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(129, 46);
            button6.TabIndex = 9;
            button6.Text = "add server to xml";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddServer_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(988, 494);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 35);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(988, 553);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 35);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(988, 615);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 35);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(988, 671);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(175, 35);
            textBox7.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(821, 386);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 14;
            button1.Text = "find server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button6);
            Controls.Add(lb_caliste);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(bt_delete);
            Controls.Add(bt_clist_write);
            Controls.Add(textBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button bt_clist_write;
        private Button bt_delete;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox lb_caliste;
        private Button button6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
    }
}
