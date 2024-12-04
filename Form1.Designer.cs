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
            createXml = new Button();
            replaceClick = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lb_caliste = new ListBox();
            addServerXml = new Button();
            id = new TextBox();
            type = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            findServer = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // bt_clist_write
            // 
            bt_clist_write.Location = new Point(46, 50);
            bt_clist_write.Name = "bt_clist_write";
            bt_clist_write.Size = new Size(75, 23);
            bt_clist_write.TabIndex = 1;
            bt_clist_write.Text = "write";
            bt_clist_write.UseVisualStyleBackColor = true;
            bt_clist_write.Click += bt_clist_write_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(45, 84);
            bt_delete.Margin = new Padding(2);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(76, 20);
            bt_delete.TabIndex = 2;
            bt_delete.Text = "delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += Bt_delete_Click;
            // 
            // createXml
            // 
            createXml.Location = new Point(474, 72);
            createXml.Margin = new Padding(2);
            createXml.Name = "createXml";
            createXml.Size = new Size(129, 23);
            createXml.TabIndex = 4;
            createXml.Text = "create xml.xml";
            createXml.UseVisualStyleBackColor = true;
            createXml.Click += Createxml_Click;
            // 
            // replaceClick
            // 
            replaceClick.Location = new Point(479, 126);
            replaceClick.Margin = new Padding(2);
            replaceClick.Name = "replaceClick";
            replaceClick.Size = new Size(153, 24);
            replaceClick.TabIndex = 5;
            replaceClick.Text = "replace entry with textbox";
            replaceClick.UseVisualStyleBackColor = true;
            replaceClick.Click += Replace_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(499, 20);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(658, 126);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "grafana";
            // 
            // lb_caliste
            // 
            lb_caliste.FormattingEnabled = true;
            lb_caliste.ItemHeight = 15;
            lb_caliste.Location = new Point(45, 140);
            lb_caliste.Name = "lb_caliste";
            lb_caliste.Size = new Size(120, 94);
            lb_caliste.TabIndex = 8;
            // 
            // addServerXml
            // 
            addServerXml.Location = new Point(479, 164);
            addServerXml.Name = "addServerXml";
            addServerXml.Size = new Size(75, 23);
            addServerXml.TabIndex = 9;
            addServerXml.Text = "add server to xml";
            addServerXml.UseVisualStyleBackColor = true;
            addServerXml.Click += AddServer_Click;
            // 
            // id
            // 
            id.Location = new Point(576, 247);
            id.Margin = new Padding(2);
            id.Name = "id";
            id.Size = new Size(104, 23);
            id.TabIndex = 10;
            // 
            // type
            // 
            type.Location = new Point(576, 276);
            type.Margin = new Padding(2);
            type.Name = "type";
            type.Size = new Size(104, 23);
            type.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(576, 308);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(104, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(576, 336);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(104, 23);
            textBox7.TabIndex = 13;
            // 
            // findServer
            // 
            findServer.Location = new Point(479, 193);
            findServer.Name = "findServer";
            findServer.Size = new Size(75, 23);
            findServer.TabIndex = 14;
            findServer.Text = "find server";
            findServer.UseVisualStyleBackColor = true;
            findServer.Click += FindServer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(findServer);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(type);
            Controls.Add(id);
            Controls.Add(addServerXml);
            Controls.Add(lb_caliste);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(replaceClick);
            Controls.Add(createXml);
            Controls.Add(bt_delete);
            Controls.Add(bt_clist_write);
            Controls.Add(textBox1);
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
        private Button createXml;
        private Button replaceClick;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox lb_caliste;
        private Button addServerXml;
        private TextBox id;
        private TextBox type;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button findServer;
    }
}
