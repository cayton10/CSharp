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
using System.Threading;

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

        //Global count variables
        int numOfSubDirs = 0;
        int numOfSubFiles = 0;
        int numOfFiles = 0;
        int numOfDirs = 0;
        int displayDir = 0;
        int displayFile = 0;
        int displaySubDir = 0;
        int displaySubFile = 0;


        private async void browseDirectory_Click(object sender, EventArgs e)
        {
            
            
            FolderBrowserDialog browser = new FolderBrowserDialog();
            
            TreeNode parent;
            
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Clear the tree view if a new directory has been selected
                treeView1.Nodes.Clear();
                string path = browser.SelectedPath;
                //Clear text boxes for counting information
                fileBox.Clear();
                directoryBox.Clear();



                if (File.Exists(path))//If no subdirectories within selected directory,
                {
                    //Count the number of files from selected directory
                    //Process to filter hidden files
                    List<string> fileInfo = await OmitHiddenFile(path);
                    //Count number of files in root directory
                    numOfFiles = fileInfo.Count();

                    //Pass value and reset
                    displayFile = numOfFiles;
                    numOfFiles = 0;


                    //Output file nodes
                    foreach (string fileName in fileInfo)
                    {
                        substringFile = Path.GetFileName(fileName);
                        TreeNode rootNode = new TreeNode(substringFile);
                        treeView1.Nodes.Add(rootNode);
                    }


                }
                else if (Directory.Exists(path)) //If 
                {

                    List<string> dirInfo = await OmitHiddenDirectory(path);

                    //Count the number of directories at root
                    numOfDirs = dirInfo.Count();

                    //Pass value and reset
                    displayDir = numOfDirs;
                    numOfDirs = 0;


                    foreach (string name in dirInfo)
                    {
                        substringDirectory = Path.GetFileName(name);

                        TreeNode rootNode = new TreeNode(substringDirectory);

                        treeView1.Nodes.Add(rootNode);

                        parent = treeView1.Nodes[rootIterator];

                        // This path is a directory
                        await ProcessDirectory(name, parent);

                        //Set iterator for root directory nodes
                        ++rootIterator;

                    }

                    //Process the files Last
                    List<string> fileInfo = await OmitHiddenFile(path);
                    numOfFiles = fileInfo.Count();

                    //Pass value and reset
                    displayFile = numOfFiles;
                    numOfFiles = 0;

                    foreach (string fileName in fileInfo)
                    {
                        substringFile = Path.GetFileName(fileName);

                        TreeNode rootNode = new TreeNode(substringFile);
                        treeView1.Nodes.Add(rootNode);
                    }

                    //Output root directory counts for files and folder
                    fileBox.AppendText(displayFile.ToString());
                    directoryBox.AppendText(displayDir.ToString());

                    //Pass values for subdir information and reset for next browse
                    displaySubDir = numOfSubDirs;
                    numOfSubDirs = 0;

                    displaySubFile = numOfSubFiles;
                    numOfSubFiles = 0;

                    //Reset all our information for next browse
                    rootIterator = 0;

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
        public async Task ProcessDirectory(string targetDirectory, TreeNode parent)
        {
           
            // Process the list of files found in the directory.
            try
            {

                List<string> fileEntries = await OmitHiddenFile(targetDirectory);

                //Count all files returned from hidden attribute filtering
                numOfSubFiles += fileEntries.Count();

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
                parent.Nodes.Add("No Access");

            }


            // Recurse into subdirectories of this directory.
            try
            {

                List<string> subdirectoryEntries = await OmitHiddenDirectory(targetDirectory);

                //Count all directories returned from hidden attribute filtering
                numOfSubDirs += subdirectoryEntries.Count();

                int i = 0;

                foreach (string subdirectory in subdirectoryEntries)
                {

                    substringDirectory = Path.GetFileNameWithoutExtension(subdirectory);
                    TreeNode myNode = new TreeNode(substringDirectory);

                    parent.Nodes.Add(myNode);

                    TreeNode subDirNode = parent.LastNode;
                    
                    await ProcessDirectory(subdirectory, subDirNode);

                    ++i;
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                parent.Nodes.Add("No Access"); 
            }
        }

        // Insert logic for processing found files here.
        public async void ProcessFile(string path)
        {
            List<string> files = await OmitHiddenFile(path);

            foreach(string fileName in files)
            {
                treeView1.Nodes.Add(fileName);
            }
            
        }

        //Used for omitting hidden directories from tree view controller
        public async Task<List<string>> OmitHiddenDirectory(string path)
        {
            try
            {
                //Instantiate these class objects to check for hidden directories
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] files = await Task.Run(() => directory.GetDirectories());

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
            catch (System.UnauthorizedAccessException)
            {

                throw;
            }
            
        }

        //Used for omitting hidden files from tree view controller
        public async Task<List<string>> OmitHiddenFile(string path)
        {
            try
            {
                //Instantiate these class objects to check for hidden directories
                DirectoryInfo directory = new DirectoryInfo(path);

                FileInfo[] files = await Task.Run(() => directory.GetFiles());


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
            catch (System.UnauthorizedAccessException)
            {
                throw;
            }
            
        }


        private void countSubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox state logic
            if(countSubCheckBox.Checked)
            {
                //Empty the text boxes containing count information
                fileBox.Text = String.Empty;
                directoryBox.Text = String.Empty;

                //Display counts of all files / directories from root
                directoryBox.AppendText(displaySubDir.ToString());
                fileBox.AppendText(displaySubFile.ToString());
            }
            else
            {
                fileBox.Clear();
                directoryBox.Clear();

                directoryBox.AppendText(displayDir.ToString());
                fileBox.AppendText(displayFile.ToString());
            }
            

        }

        private void fileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void directoryBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
