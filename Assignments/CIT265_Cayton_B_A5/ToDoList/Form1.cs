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

namespace ToDoList
{
    public partial class Form1 : Form
    {

        //Create a new list
        public List<Activity> activities = new List<Activity>();

        //Our file writer
        public StreamWriter fileWriter;

        //Our file reader
        public StreamReader fileReader;


        public Form1()
        {
            InitializeComponent();

            //On initialization of our form, read a file if it exists
            string fileName = "toDoList.txt";

            //Try catch for opening the file
            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileReader = new StreamReader(input);

                acceptList.Enabled = false;

                //Read from the file and load values as necessary
                try
                {
                    string line = null;
                    while ((line = fileReader.ReadLine()) != null)
                    {
 
                        //Declare a string array to store each piece of list info
                        string[] strArray;

                        //Split on specified delimiter
                        strArray = line.Split('-');

                        
                        var name = strArray[0];
                        var date = Convert.ToDateTime(strArray[1]);

                        //Add information to List
                        activities.Add(new Activity(name, date));

                    }

                    fileReader.Close();

                    //Process List and output to listbox
                    foreach(Activity a in activities)
                    {
                        listBox1.Items.Add($"{a.Name}: {a.Date}");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No file to load.");
            }

            fileReader?.Close();
        }

        
        //Methods to help our form with UX
        public void ClearControls()
        {
            //For clearing controls,
            //Clear activity name field
            nameField.Clear();

            //Reset the date / time in picker
            dateTimePicker1.Value = DateTime.Now;
        }

        


        /*ADD ACTIVITY BUTTON HANDLING */
        private void addActivity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameField.Text))
            {
                MessageBox.Show("Please enter a name for your activity.");
                return;
            }
            //Add the values in the form controls to the list
            activities.Add(new Activity(nameField.Text, dateTimePicker1.Value));
            //Add the activity to the List box for user to view
            listBox1.Items.Add($"{nameField.Text}: {dateTimePicker1.Value}");
            //Clear controls once the info has been added to the list
            ClearControls();

            //Set our removeActivity button control
            removeActivity.Enabled = true;
            removeActivity.TabStop = true;

            acceptList.Enabled = true;
            acceptList.TabStop = true;

        }

        private void removeActivity_Click(object sender, EventArgs e)
        {
            //Account for people not selecting an item prior to using the button
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
                return;
            }
            //Store the index of the selected item
            var listIndex = listBox1.SelectedIndex;
            //Remove that item from the listbox
            listBox1.Items.RemoveAt(listIndex);
            //Refresh the listbox
            listBox1.Refresh();
            //Remove that item from the List of Activities
            activities.RemoveAt(listIndex);

            //Check how many list items remain in listbox
            var num = checkList();
            //Use some control flow for appropriate button settings
            if(num == 0)
            {
                removeActivity.Enabled = false;
                removeActivity.TabStop = false;
            }

            acceptList.Enabled = true;
            acceptList.TabStop = true;
        }

        private void sortName_Click(object sender, EventArgs e)
        {
            //Use LINQ to sort our activities list by name
            var query = from activity in activities
                        orderby activity.Name
                        select activity;

            //Use LINQ query to store results of sorted list
            List<Activity> orderByName = query.ToList<Activity>();

            //Remove the list items from the listbox control
            listBox1.Items.Clear();
            //Refresh the listbox
            listBox1.Refresh();

            //Call function to print items back to listbox
            printList(orderByName);

            //Set our original list to reflect the sorted list
            activities = orderByName;
        }

        private void sortDate_Click(object sender, EventArgs e)
        {
            //Use LINQ to sort our activities list by date
            //Store LINQ query
            var query = from activity in activities
                        orderby activity.Date
                        select activity;

            //Use LINQ query to store results of sorted list
            List<Activity> orderByDate = query.ToList<Activity>();

            //Remove the list items from the listbox control
            listBox1.Items.Clear();
            //Refresh the listbox
            listBox1.Refresh();

            //Call function to print items back to listbox
            printList(orderByDate);

            //Set our original list to reflect our sorted list
            activities = orderByDate;


        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Date = dateTimePicker1.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //Used the try catch exception handling from our Bank Accounts example. 
            //Thanks!
            try
            {
                fileWriter?.Close();
            }
            catch (IOException)
            {

                MessageBox.Show("Can't close file.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acceptList_Click(object sender, EventArgs e)
        {

            string fileName = "toDoList.txt";

            

            //Save our list to a file in our project directory for convenience
            try
            {
                var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fileWriter = new StreamWriter(output);

                acceptList.Enabled = false;

                //Write our activity list to the toDoList.txt file
                foreach (Activity act in activities)
                {
                    fileWriter.WriteLine(act.ToString());
                }
            }
            catch (IOException)
            {

                throw;
            }


        }

        private void cancelList_Click(object sender, EventArgs e)
        {

        }

        //Method to print back to listbox
        public void printList(List<Activity> list)
        {
            foreach (Activity item in list)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        //Disable the remove button if no items are in the todo list
        public int checkList()
        {
            var num = listBox1.Items.Count;
            return num;
        }
    }
}
