using System.Management.Automation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Net.Sockets;

namespace PgDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_create_schema_Click(object sender, EventArgs e) => await RunTask("--encoding=utf8 --format=plain -s", "schema");
        private async void btn_create_data_Click(object sender, EventArgs e) => await RunTask("--data-only --encoding=utf8 --format=plain --inserts", "data");

        // create db
        // docker exec -i postgres2 psql -U postgres -c "CREATE DATABASE BranchDb;" && docker exec -i postgres2 psql -U postgres -c "\q"
        // docker cp C:\Users\UNAL\Desktop\db\BranchDb.schema.sql postgres2:/tmp/schema.sql
        // docker exec -i postgres2 psql -U postgres -d BranchDb -a -f /tmp/schema.sql
        private async Task RunTask(string command_arguments, string type)
        {
            (type == "schema" ? btn_create_schema : btn_create_data).Enabled = false;

            var db_names = txt_dbnames.Text.Split(' ').Select(x => x.Trim()).Where(x => string.IsNullOrEmpty(x) is false);

            var percentage_part = 100 / db_names.Count();

            foreach (var db_name in db_names)
            {
                var desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var sql_folder = Path.Combine(desktop_path, "db");

                if (Directory.Exists(sql_folder) is false) Directory.CreateDirectory(sql_folder);

                var file_path = Path.Combine(sql_folder, $"{db_name}.{type}.sql");
                var command = $"docker exec {txt_container_name.Text.Trim()} pg_dump -h {txt_host.Text.Trim()} -U {txt_username.Text.Trim()} {command_arguments} {db_name} > {file_path}";
                await RunCommand(command);

                var file_check = File.Exists(file_path);
                if (file_check)
                    (type == "schema" ? listBox1.Items : listBox2.Items).Add($"Created {Path.GetFileName(file_path)}");

                (type == "schema" ? progressBar1 : progressBar2).Value += percentage_part;
            }

            (type == "schema" ? progressBar1 : progressBar2).Value = 100;
            (type == "schema" ? btn_create_schema : btn_create_data).Enabled = true;
        }
        private async Task RunCommand(string command)
        {
            try
            {
                var ps = PowerShell.Create();
                ps.AddScript(command);
                await ps.InvokeAsync();
            }
            catch (Exception e)
            {
                $"{e.Message} {e.InnerException}".Split('\n').ToList().ForEach(item => listBox1.Items.Add(item));
            }
        }
    }
}
