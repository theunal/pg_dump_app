using System.Management.Automation;
using System.Reflection;

namespace PgDump;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void btn_create_schema_Click(object sender, EventArgs e) => await RunTask("--encoding=utf8 --format=plain -s", "schema", true);
    private async void btn_create_data_Click(object sender, EventArgs e) => await RunTask("--data-only --encoding=utf8 --format=plain --inserts", "data", true);

    private async void btn_create_schema_Click_1(object sender, EventArgs e) => await RunTask("--encoding=utf8 --format=plain -s", "schema", false);
    private async void btn_create_data_Click_1(object sender, EventArgs e) => await RunTask("--data-only --encoding=utf8 --format=plain --inserts", "data", false);

    // create db
    // docker exec -i postgres2 psql -U postgres -c "CREATE DATABASE BranchDb;" && docker exec -i postgres2 psql -U postgres -c "\q"
    // docker cp C:\Users\UNAL\Desktop\db\BranchDb.schema.sql postgres2:/tmp/schema.sql
    // docker exec -i postgres2 psql -U postgres -d BranchDb -a -f /tmp/schema.sql

    private async Task RunTask(string command_arguments, string type, bool isDocker)
    {
        if (string.IsNullOrEmpty(txt_dbnames.Text)) return;

        try
        {
            (type == "schema" ? btn_create_schema_with_docker : btn_create_data_with_docker).Enabled = false;
            var db_names = txt_dbnames.Text.Split(' ').Select(x => x.Trim()).Where(x => string.IsNullOrEmpty(x) is false);
            var table_names = txt_tablenames.Text.Split(' ').Select(x => x.Trim()).Where(x => string.IsNullOrEmpty(x) is false);
            var percentage_part = 100 / db_names.Count();

            var desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var sql_folder = Path.Combine(desktop_path, "db");

            if (Directory.Exists(sql_folder) is false) Directory.CreateDirectory(sql_folder);

            if (isDocker)
            {
                foreach (var db_name in db_names)
                {
                    var file_path = Path.Combine(sql_folder, $"docker.{db_name}.{type}.sql");
                    var command = $"docker exec {container_name.Text.Trim()} pg_dump -h {host.Text.Trim()} -U {username.Text.Trim()} {command_arguments} {db_name} > {file_path}";
                    await RunCommand(command);

                    WriteLog(file_path, type, percentage_part);
                }
            }
            else
            {
                foreach (var db_name in db_names)
                {
                    var file_path = Path.Combine(sql_folder, $"{db_name}.{type}.sql");
                    string pg_dump_path =
                        Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\")), "pg_files", "pg_dump.exe");
                    //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pg_files", "pg_dump.exe");

                    var base_command = $"$env:PGPASSWORD = \"{password.Text.Trim()}\"; & \"{pg_dump_path}\" -h {host.Text.Trim()} -U {username.Text.Trim()} {command_arguments} {db_name}";
                    var command = type == "schema" ? $"{base_command} | Out-File -FilePath \"{file_path}\"" : $"{base_command} > {file_path}";

                    if (table_names.Any())
                    {
                        if (txt_schema_name.Text == "")
                        {
                            listBox2.Items.Add("Schename name is empty.");
                            return;
                        }

                        foreach (var table_name in table_names)
                        {
                            var new_file_path = file_path.Replace(".sql", $".{table_name}.sql");
                            var file_name_text = @"\" + "\"" + table_name + @"\" + "\"";
                            // 'public.\"AgentSshApps\"' 
                            await RunCommand(type == "schema" ? "" : command.Replace($"{db_name} >", $"-t '{txt_schema_name.Text.Trim()}.{file_name_text}' {db_name} >").Replace(file_path, new_file_path));
                        }
                    }
                    else
                        await RunCommand(command);

                    WriteLog(file_path, type, percentage_part);
                }
            }
        }
        catch (Exception e)
        {
            throw;
        }

        (type == "schema" ? progressBar1 : progressBar2).Value = 100;
        (type == "schema" ? btn_create_schema_with_docker : btn_create_data_with_docker).Enabled = true;
    }


    private void WriteLog(string file_path, string type, int percentage_part)
    {
        var file_check = File.Exists(file_path);
        if (file_check)
            (type == "schema" ? listBox1.Items : listBox2.Items).Add($"Created {Path.GetFileName(file_path)}");

        if (percentage_part == 100)
            (type == "schema" ? progressBar1 : progressBar2).Value = 100;
        else
            (type == "schema" ? progressBar1 : progressBar2).Value += percentage_part;
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

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Clipboard.SetText(listBox2.Text);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Clipboard.SetText(listBox1.Text);
    }
}
