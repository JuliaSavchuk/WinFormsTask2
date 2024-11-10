using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeExplorer();
        }

        private void InitializeExplorer()
        {
            // Завантаження дисків у TreeView
            LoadDrives();

            // Встановлення подій
            treeView1.AfterSelect += TreeViewFolders_AfterSelect;
            listView1.DoubleClick += ListViewFiles_DoubleClick;
            textBox1.KeyDown += TextBoxAddress_KeyDown;
        }

        private void LoadDrives()
        {
            treeView1.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    var driveNode = new TreeNode(drive.Name) { Tag = drive.Name };
                    driveNode.Nodes.Add("..."); // Заглушка для можливості розгортання
                    treeView1.Nodes.Add(driveNode);
                }
            }
        }
        private void TreeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "...")
            {
                e.Node.Nodes.Clear();
                try
                {
                    foreach (var dir in Directory.GetDirectories(e.Node.Tag.ToString()))
                    {
                        var dirNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                        dirNode.Nodes.Add("..."); // Заглушка для розгортання
                        e.Node.Nodes.Add(dirNode);
                    }
                }
                catch { /* Обробка винятків */ }
            }
            DisplayFolderContents(e.Node.Tag.ToString());
        }

        private void DisplayFolderContents(string path)
        {
            listView1.Items.Clear();
            textBox1.Text = path;

            try
            {
                // Додаємо підпапки
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var item = new ListViewItem(Path.GetFileName(dir)) { Tag = dir };
                    item.SubItems.Add("Folder");
                    item.SubItems.Add("");
                    listView1.Items.Add(item);
                }

                // Додаємо файли
                foreach (var file in Directory.GetFiles(path))
                {
                    var fileInfo = new FileInfo(file);
                    var item = new ListViewItem(fileInfo.Name) { Tag = file };
                    item.SubItems.Add("File");
                    item.SubItems.Add(fileInfo.Length.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch { /* Обробка винятків */ }
        }

        private void ListViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string path = selectedItem.Tag.ToString();

                if (Directory.Exists(path))
                {
                    DisplayFolderContents(path);
                }
                else
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        private void TextBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = textBox1.Text;
                if (Directory.Exists(path))
                {
                    DisplayFolderContents(path);
                    SelectTreeNodeByPath(path);
                }
                else
                {
                    MessageBox.Show("The specified path does not exist.");
                }
            }
        }
        private void SelectTreeNodeByPath(string path)
        {
            // Реалізація для вибору TreeNode за заданим шляхом
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Tag.ToString() == Path.GetPathRoot(path))
                {
                    treeView1.SelectedNode = node;
                    return;
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
