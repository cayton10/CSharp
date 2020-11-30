using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string substringDirectory;
        string substringFile;
        int rootIterator = 0;
        int subIterator = 0;

        //RootNode
        string rootNode;
        string childNode;

        TreeNode parent;

        private void browseDirectory_Click(object sender, EventArgs e)
        {
            
            
            FolderBrowserDialog browser = new FolderBrowserDialog();
            OpenFileDialog openFile = new OpenFileDialog();
            TreeNode parent;
            
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Clear the tree view if a new directory has been selected
                treeView1.Nodes.Clear();
                string path = browser.SelectedPath;

                

                    if (File.Exists(path))
                    {
                        // This path is a file
                        ProcessFile(path);
                    }
                    else if (Directory.Exists(path))
                    {

                        List<string> dirInfo = OmitHiddenDirectory(path);
                        //Count the number of directories at root
                        int numberInRoot = dirInfo.Count() - 1;

                        foreach(string name in dirInfo)
                        {
                            substringDirectory = Path.GetFileName(name);

                            TreeNode rootNode = new TreeNode(substringDirectory);
                            Console.WriteLine(rootNode);
                            Console.WriteLine(rootNode.GetType());
                            treeView1.Nodes.Add(rootNode);

                            parent = treeView1.Nodes[rootIterator];
                            
                            // This path is a directory
                            ProcessDirectory(name, parent);
                            //Set iterator for root directory nodes
                            ++rootIterator;
                        }

                        
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", path);
                    }

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        // Process all files in the directory passed in, recurse on any directories
        // that are found, and process the files they contain.
        public void ProcessDirectory(string targetDirectory, TreeNode parent)
        {
           
            // Process the list of files found in the directory.
            try
            {

                List<string> fileEntries = OmitHiddenFile(targetDirectory);

                //string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                {
                    substringFile = Path.GetFileNameWithoutExtension(fileName);
                    TreeNode myNode = new TreeNode(substringFile);
                    //treeView1.Nodes[rootIterator].Nodes.Add(myNode);

                    parent.Nodes.Add(myNode);
                    
                }


            }
            catch (System.UnauthorizedAccessException)
            {

            }


            // Recurse into subdirectories of this directory.
            try
            {

                List<string> subdirectoryEntries = OmitHiddenDirectory(targetDirectory);

                int numOfSubDirs = subdirectoryEntries.Count();

                

                foreach (string subdirectory in subdirectoryEntries)
                {

                    substringDirectory = Path.GetFileNameWithoutExtension(subdirectory);
                    TreeNode myNode = new TreeNode(substringDirectory);

                    parent.Nodes.Add(myNode);

                    TreeNode subDirNode = parent.LastNode;

                    if (subIterator == numOfSubDirs)
                        parent = parent.LastNode;
                    
                    Console.WriteLine(parent); 
                    ProcessDirectory(subdirectory, subDirNode);
                    ++subIterator;
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                
            }
        }

        // Insert logic for processing found files here.
        public void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", Path.GetFileName(path));
        }

        //Used for omitting hidden directories from tree view controller
        public List<string> OmitHiddenDirectory(string path)
        {
            //Instantiate these class objects to check for hidden directories
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] files = directory.GetDirectories();

            //Create dynamic collection to store the valid directories
            List<string> dirInfo = new List<string>();

            //Use Lambda to filter out hidden directories
            var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));

            //Process them and store
            foreach (var f in filtered)
            {
                var dirName = f.ToString();
                dirInfo.Add($"{path}\\{dirName}");
                // This path is a directory
            }

            return dirInfo;
        }

        //Used for omitting hidden files from tree view controller
        public List<string> OmitHiddenFile(string path)
        {
            //Instantiate these class objects to check for hidden directories
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            //Create dynamic collection to store the valid directories
            List<string> dirInfo = new List<string>();

            //Use Lambda to filter out hidden directories
            var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));

            //Process them and store
            foreach (var f in filtered)
            {
                var dirName = f.ToString();
                dirInfo.Add($"{path}\\{dirName}");
                // This path is a directory
            }

            return dirInfo;
        }
        
    }
}
