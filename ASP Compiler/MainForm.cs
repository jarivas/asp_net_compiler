using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ASP_Compiler
{
    public partial class MainForm : Form
    {
        const string ASPNET_COMPILER_STRING_FORMAT = "C:/Windows/Microsoft.NET/Framework/v2.0.50727/aspnet_compiler -p {0} -v {1} {2}";
        const string TERMINAL_APP_NAME = "cmd.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Txt_Source_Enter(object sender, EventArgs e)
        {
            //Show folder browser dialog
            if (FDialog_Source.ShowDialog() == DialogResult.OK)
            {
                Txt_Source.Text = FDialog_Source.SelectedPath;
                Txt_VPath.Text = GetVirtualPath();
            }
        }

        private void Txt_Target_Enter(object sender, EventArgs e)
        {
            if (FDialog_Target.ShowDialog() == DialogResult.OK)
            {
                Txt_Target.Text = FDialog_Target.SelectedPath;
            }
        }

        private void Btn_Compile_Click(object sender, EventArgs e)
        {
            string tempDir = "C:\\aspnet_compiler";

            RTxt_Result.Text = "Start...";

            //Check if all it's ok before compile
            if( (!String.IsNullOrEmpty(FDialog_Source.SelectedPath))
                && (!String.IsNullOrEmpty(FDialog_Target.SelectedPath) )
                && (!String.IsNullOrEmpty(Txt_VPath.Text))
                && (Directory.Exists(FDialog_Source.SelectedPath))
                && (Directory.Exists(FDialog_Target.SelectedPath)) )
            {
                try
                {
                    //Clean a previous compilation from tempDir and FDialog_Target.SelectedPath
                    CleanDir(tempDir);
                    RTxt_Result.Text += "\r\nCleaning tempDir ok";

                    CleanDir(FDialog_Target.SelectedPath);
                    RTxt_Result.Text += "\r\nCleaning targetDir ok";

                    //Copy source to the temp dir
                    CopyDir(FDialog_Source.SelectedPath, tempDir);
                    RTxt_Result.Text += "\r\nCopying tempDir ok";

                    //Compile the temp dir
                    RTxt_Result.Text += "\r\n" + compileProject(tempDir, Txt_VPath.Text, FDialog_Target.SelectedPath);
                    RTxt_Result.Text += "\r\nCompiling tempDir ok";
                    Directory.Delete(tempDir, true);

                    //Copy to the target directory
                   RTxt_Result.Text += "\r\nFinish ok";
                }
                catch (Exception ex)
                {
                    RTxt_Result.Text = ex.Message;
                }
            }
        }

        private string compileProject(string compileDir, string iisApplicationPath, string targetDir)
        {
            string compileString = string.Format(ASPNET_COMPILER_STRING_FORMAT, compileDir, iisApplicationPath, targetDir);

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = TERMINAL_APP_NAME; //File name to execute
            p.StartInfo.Arguments = "/c " + compileString;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.Start(); // Execute process
            p.WaitForExit();

            string output = p.StandardOutput.ReadToEnd();// stdout
            string erroutput = p.StandardError.ReadToEnd();

            return output;
        }

        private void CleanDir(string dir)
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, true);
            }
            Directory.CreateDirectory(dir);
    }

        private void CopyDir(string source, string target)
        {
            string[] subDirectories = Directory.GetDirectories(source);
            string[] files = Directory.GetFiles(source);

            if (files.Length > 0)//Copy all the files
            {
                foreach(string file in files)
                {
                    File.Copy( file, Path.Combine( target, GetFileName(file) ) );
                }
            }

            if (subDirectories.Length > 0)//Copy all the subdirectories
            {
                foreach (string subdir in subDirectories)
                {
                    string subdir_Target = Path.Combine(target, GetFileName(subdir));

                    if (!Directory.Exists(subdir_Target))
                    {
                        Directory.CreateDirectory(subdir_Target);
                    }

                    CopyDir(Path.Combine(source, subdir), subdir_Target);

                }
            }
        }

        private string GetVirtualPath()
        {
            string result = GetFileName(FDialog_Source.SelectedPath);
            result = result.Replace(" ", "_");

            return result;
        }

        private string GetFileName(string file)
        {
            int index = file.LastIndexOf("\\") + 1;

            string result = file.Substring(index);
            return result;
        }

        private void Txt_Target_Leave(object sender, EventArgs e)
        {
            int index = FDialog_Target.SelectedPath.IndexOf(" ");
            if (index != -1)
            {
                MessageBox.Show("The folder target can not contain spaces in the name");
                FDialog_Target.SelectedPath = String.Empty;
                Txt_Target.Text = String.Empty;
            }
        }
    }
}
