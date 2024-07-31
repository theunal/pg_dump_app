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
            btn_create_schema_with_docker = new Button();
            txt_dbnames = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            btn_create_data_with_docker = new Button();
            listBox2 = new ListBox();
            progressBar2 = new ProgressBar();
            container_name = new TextBox();
            label9 = new Label();
            label10 = new Label();
            host = new TextBox();
            label11 = new Label();
            username = new TextBox();
            btn_create_data = new Button();
            btn_create_schema = new Button();
            label2 = new Label();
            password = new TextBox();
            label3 = new Label();
            txt_tablenames = new TextBox();
            label4 = new Label();
            txt_schema_name = new TextBox();
            SuspendLayout();
            // 
            // btn_create_schema_with_docker
            // 
            btn_create_schema_with_docker.Location = new Point(20, 139);
            btn_create_schema_with_docker.Name = "btn_create_schema_with_docker";
            btn_create_schema_with_docker.Size = new Size(184, 52);
            btn_create_schema_with_docker.TabIndex = 8;
            btn_create_schema_with_docker.Text = "Create Schema Sql With Docker";
            btn_create_schema_with_docker.UseVisualStyleBackColor = true;
            btn_create_schema_with_docker.Click += btn_create_schema_Click;
            // 
            // txt_dbnames
            // 
            txt_dbnames.Location = new Point(13, 43);
            txt_dbnames.Name = "txt_dbnames";
            txt_dbnames.Size = new Size(266, 27);
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
            listBox1.Location = new Point(14, 237);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(395, 144);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 213);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(395, 18);
            progressBar1.TabIndex = 12;
            // 
            // btn_create_data_with_docker
            // 
            btn_create_data_with_docker.Location = new Point(210, 139);
            btn_create_data_with_docker.Name = "btn_create_data_with_docker";
            btn_create_data_with_docker.Size = new Size(199, 52);
            btn_create_data_with_docker.TabIndex = 20;
            btn_create_data_with_docker.Text = "Create Data Sql With Docker";
            btn_create_data_with_docker.UseVisualStyleBackColor = true;
            btn_create_data_with_docker.Click += btn_create_data_Click;
            // 
            // listBox2
            // 
            listBox2.AutoScrollOffset = new Point(408, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(415, 237);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(408, 144);
            listBox2.TabIndex = 21;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(415, 213);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(408, 18);
            progressBar2.TabIndex = 22;
            // 
            // container_name
            // 
            container_name.Location = new Point(605, 87);
            container_name.Name = "container_name";
            container_name.Size = new Size(218, 27);
            container_name.TabIndex = 23;
            container_name.Text = "postgres";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(485, 90);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 24;
            label9.Text = "Container name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(698, 20);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 26;
            label10.Text = "Host";
            // 
            // host
            // 
            host.Location = new Point(698, 43);
            host.Name = "host";
            host.Size = new Size(125, 27);
            host.TabIndex = 25;
            host.Text = "localhost";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 87);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 28;
            label11.Text = "Username";
            // 
            // username
            // 
            username.Location = new Point(100, 84);
            username.Name = "username";
            username.Size = new Size(125, 27);
            username.TabIndex = 27;
            username.Text = "postgres";
            // 
            // btn_create_data
            // 
            btn_create_data.Location = new Point(617, 139);
            btn_create_data.Name = "btn_create_data";
            btn_create_data.Size = new Size(206, 52);
            btn_create_data.TabIndex = 30;
            btn_create_data.Text = "Create Data Sql";
            btn_create_data.UseVisualStyleBackColor = true;
            btn_create_data.Click += btn_create_data_Click_1;
            // 
            // btn_create_schema
            // 
            btn_create_schema.Location = new Point(415, 139);
            btn_create_schema.Name = "btn_create_schema";
            btn_create_schema.Size = new Size(196, 52);
            btn_create_schema.TabIndex = 29;
            btn_create_schema.Text = "Create Schema Sql";
            btn_create_schema.UseVisualStyleBackColor = true;
            btn_create_schema.Click += btn_create_schema_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 32;
            label2.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(323, 87);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 31;
            password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 20);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 34;
            label3.Text = "Table name(s)";
            // 
            // txt_tablenames
            // 
            txt_tablenames.Location = new Point(288, 43);
            txt_tablenames.Name = "txt_tablenames";
            txt_tablenames.Size = new Size(239, 27);
            txt_tablenames.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 20);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 36;
            label4.Text = "Schema Name";
            // 
            // txt_schema_name
            // 
            txt_schema_name.Location = new Point(533, 43);
            txt_schema_name.Name = "txt_schema_name";
            txt_schema_name.Size = new Size(159, 27);
            txt_schema_name.TabIndex = 35;
            txt_schema_name.Text = "public";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 395);
            Controls.Add(label4);
            Controls.Add(txt_schema_name);
            Controls.Add(label3);
            Controls.Add(txt_tablenames);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(btn_create_data);
            Controls.Add(btn_create_schema);
            Controls.Add(label11);
            Controls.Add(username);
            Controls.Add(label10);
            Controls.Add(host);
            Controls.Add(label9);
            Controls.Add(container_name);
            Controls.Add(progressBar2);
            Controls.Add(listBox2);
            Controls.Add(btn_create_data_with_docker);
            Controls.Add(progressBar1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(txt_dbnames);
            Controls.Add(btn_create_schema_with_docker);
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
        private Button btn_create_schema_with_docker;
        private TextBox txt_dbnames;
        private Label label1;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private Button btn_create_data_with_docker;
        private ListBox listBox2;
        private ProgressBar progressBar2;
        private TextBox container_name;
        private Label label9;
        private Label label10;
        private TextBox host;
        private Label label11;
        private TextBox username;
        private Button btn_create_data;
        private Button btn_create_schema;
        private Label label2;
        private TextBox password;
        private Label label3;
        private TextBox txt_tablenames;
        private Label label4;
        private TextBox txt_schema_name;
    }
}
