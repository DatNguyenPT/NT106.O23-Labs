using System.IO;
using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class EX7 : Form
    {
        public EX7()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                pathdisk = drive.Name;
                TreeNode root = new TreeNode(pathdisk);
                TreeDirectory.Nodes.Add(root);
                if (drive.Name == "E:\\")
                {
                    LoadExplorer(root);
                }
                root.Text = drive.VolumeLabel + " (" + pathdisk + ")";
                root.Name = drive.Name;
            }
        }

        string pathdisk;

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                DirectoryInfo[] listfolder = new DirectoryInfo(root.Text).GetDirectories();
                string[] listfile = Directory.GetFiles(root.Text);
                foreach (string item in listfile)
                {
                    FileInfo file = new FileInfo(item);
                    TreeNode filenode = new TreeNode(item);
                    root.Nodes.Add(filenode);
                    filenode.Name = item;
                    filenode.Text = file.Name;
                }
                foreach (DirectoryInfo item in listfolder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode folder = new TreeNode(item.FullName);
                        root.Nodes.Add(folder);
                        LoadExplorer(folder);
                        folder.Name = item.FullName;
                        folder.Text = item.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);

            // Check if the node represents a directory
            if (attr.HasFlag(FileAttributes.Directory))
            {
                // Clear the existing nodes under the clicked node
                node.Nodes.Clear();

                try
                {
                    // Get the directories and files within the clicked directory
                    DirectoryInfo[] directories = new DirectoryInfo(node.Name).GetDirectories();
                    string[] files = Directory.GetFiles(node.Name);

                    // Add directories as child nodes
                    foreach (DirectoryInfo directory in directories)
                    {
                        TreeNode directoryNode = new TreeNode(directory.Name);
                        directoryNode.Name = directory.FullName;
                        directoryNode.Text = directory.Name;
                        node.Nodes.Add(directoryNode);
                    }

                    // Add files as child nodes
                    foreach (string filePath in files)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        TreeNode fileNode = new TreeNode(fileInfo.Name);
                        fileNode.Name = filePath;
                        fileNode.Text = fileInfo.Name;
                        node.Nodes.Add(fileNode);
                    }
                    node.Expand();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void treeDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(node.Name);
                    if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        FilePictureContent.Visible = true;
                        txtFileContent.Visible = false;
                        FilePictureContent.Load(node.Name);
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        FilePictureContent.Visible = false;
                        txtFileContent.Visible = true;
                        FileStream fs = new FileStream(node.Name, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fs);
                        txtFileContent.Text = reader.ReadToEnd();
                        reader.Close();
                        fs.Close();
                    }
                    else if (fileInfo.Extension == ".docx" || fileInfo.Extension == ".doc")
                    {
                        FilePictureContent.Visible = false;
                        txtFileContent.Visible = true;
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Microsoft.Office.Interop.Word.Document fileword = app.Documents.Open(node.Name);
                        txtFileContent.Text = fileword.Content.Text;
                        app.Quit();
                    }

                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Not a picture file.", "Notice");
                }
            }
        }
    }
}
