using System.Resources;

namespace PgDump
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
            txt_container_name = new TextBox();
            txt_host = new TextBox();
            txt_username = new TextBox();
            label44 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_create_schema = new Button();
            txt_dbnames = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            btn_create_data = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_username2 = new TextBox();
            txt_host2 = new TextBox();
            txt_container_name2 = new TextBox();
            listBox2 = new ListBox();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // txt_container_name
            // 
            txt_container_name.Location = new Point(123, 105);
            txt_container_name.Name = "txt_container_name";
            txt_container_name.Size = new Size(125, 27);
            txt_container_name.TabIndex = 0;
            txt_container_name.Text = "postgres";
            // 
            // txt_host
            // 
            txt_host.Location = new Point(350, 105);
            txt_host.Name = "txt_host";
            txt_host.Size = new Size(125, 27);
            txt_host.TabIndex = 1;
            txt_host.Text = "localhost";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(512, 105);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 27);
            txt_username.TabIndex = 2;
            txt_username.Text = "postgres";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(14, 108);
            label44.Name = "label44";
            label44.Size = new Size(103, 20);
            label44.TabIndex = 3;
            label44.Text = "docker exec -t";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 108);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "pg_dump -h";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 108);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 5;
            label3.Text = "-U";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 140);
            label4.Name = "label4";
            label4.Size = new Size(498, 20);
            label4.TabIndex = 6;
            label4.Text = "--encoding=utf8 --format=plain -s <db_name> > <db_name>.schema.sql";
            // 
            // btn_create_schema
            // 
            btn_create_schema.Location = new Point(659, 108);
            btn_create_schema.Name = "btn_create_schema";
            btn_create_schema.Size = new Size(164, 52);
            btn_create_schema.TabIndex = 8;
            btn_create_schema.Text = "Create Schema Sql";
            btn_create_schema.UseVisualStyleBackColor = true;
            btn_create_schema.Click += btn_create_schema_Click;
            // 
            // txt_dbnames
            // 
            txt_dbnames.Location = new Point(13, 43);
            txt_dbnames.Name = "txt_dbnames";
            txt_dbnames.Size = new Size(810, 27);
            txt_dbnames.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 10;
            label1.Text = "Database name(s)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(14, 314);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(395, 104);
            listBox1.TabIndex = 11;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 290);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(395, 18);
            progressBar1.TabIndex = 12;
            // 
            // btn_create_data
            // 
            btn_create_data.Location = new Point(659, 195);
            btn_create_data.Name = "btn_create_data";
            btn_create_data.Size = new Size(164, 52);
            btn_create_data.TabIndex = 20;
            btn_create_data.Text = "Create Data Sql";
            btn_create_data.UseVisualStyleBackColor = true;
            btn_create_data.Click += btn_create_data_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 227);
            label5.Name = "label5";
            label5.Size = new Size(600, 20);
            label5.TabIndex = 19;
            label5.Text = "--data-only --encoding=utf8 --format=plain --inserts <db_name> > <db_name>.data.sql";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 195);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 18;
            label6.Text = "-U";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 195);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 17;
            label7.Text = "pg_dump -h";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 195);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 16;
            label8.Text = "docker exec -t";
            // 
            // txt_username2
            // 
            txt_username2.Location = new Point(512, 192);
            txt_username2.Name = "txt_username2";
            txt_username2.Size = new Size(125, 27);
            txt_username2.TabIndex = 15;
            txt_username2.Text = "postgres";
            // 
            // txt_host2
            // 
            txt_host2.Location = new Point(350, 192);
            txt_host2.Name = "txt_host2";
            txt_host2.Size = new Size(125, 27);
            txt_host2.TabIndex = 14;
            txt_host2.Text = "localhost";
            // 
            // txt_container_name2
            // 
            txt_container_name2.Location = new Point(123, 192);
            txt_container_name2.Name = "txt_container_name2";
            txt_container_name2.Size = new Size(125, 27);
            txt_container_name2.TabIndex = 13;
            txt_container_name2.Text = "postgres";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(415, 314);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(408, 104);
            listBox2.TabIndex = 21;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(415, 290);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(408, 18);
            progressBar2.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 430);
            Controls.Add(progressBar2);
            Controls.Add(listBox2);
            Controls.Add(btn_create_data);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txt_username2);
            Controls.Add(txt_host2);
            Controls.Add(txt_container_name2);
            Controls.Add(progressBar1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(txt_dbnames);
            Controls.Add(btn_create_schema);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label44);
            Controls.Add(txt_username);
            Controls.Add(txt_host);
            Controls.Add(txt_container_name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Pg Dump";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_container_name;
        private TextBox txt_host;
        private TextBox txt_username;
        private Label label44;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_create_schema;
        private TextBox txt_dbnames;
        private Label label1;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private Button btn_create_data;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_username2;
        private TextBox txt_host2;
        private TextBox txt_container_name2;
        private ListBox listBox2;
        private ProgressBar progressBar2;
    }
}
