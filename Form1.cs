using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactorer
{
    public partial class Form1 : Form
    {

        private string DirFpath;
        private readonly List<string> Extensions = new List<string> {".php", ".txt", ".html", ".css", ".js", ".scss", ".ts", ".jsx"};

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDir(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirFpath = fbd.SelectedPath;
                    selected_txt.Text = Path.GetFileName(DirFpath);
                }
            }
        }

        private IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }

        private void StartRefactoring(object sender, EventArgs e)
        {
            string findtxt = find_txt.Text;
            string replacetxt = replace_txt.Text;

            if (String.IsNullOrEmpty(DirFpath) != true)
            {
                foreach (string file in GetFiles(DirFpath))
                {
                    string ext = Path.GetExtension(file);
                    if (Extensions.Contains(ext))
                    {
                        string text = File.ReadAllText(file);
                        text = text.Replace(findtxt, replacetxt);
                        File.WriteAllText(file, text);
                    }
                }

                MessageBox.Show("Done !");
            }
        }
    }
}
