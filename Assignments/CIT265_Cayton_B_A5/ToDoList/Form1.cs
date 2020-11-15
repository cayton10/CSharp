using System;
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
        public Form1()
        {
            InitializeComponent();
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

        //Create a new list
        public List<Activity> activities = new List<Activity>();



        /*ADD ACTIVITY BUTTON HANDLING */
        private void addActivity_Click(object sender, EventArgs e)
        { 

            //Add the values in the form controls to the list
            activities.Add(new Activity(nameField.Text, dateTimePicker1.Value));
            //Add the activity to the List box for user to view
            listBox1.Items.Add($"{nameField.Text}: {dateTimePicker1.Value}");
            //Clear controls once the info has been added to the list
            ClearControls();

        }

        private void removeActivity_Click(object sender, EventArgs e)
        {
            //Store the index of the selected item
            var listIndex = listBox1.SelectedIndex;
            //Remove that item from the listbox
            listBox1.Items.RemoveAt(listIndex);
            //Refresh the listbox
            listBox1.Refresh();
            //Remove that item from the List of Activities
            activities.RemoveAt(listIndex);
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
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acceptList_Click(object sender, EventArgs e)
        {
            //If we accept the list, then add all list items to List Structure to save to file
            foreach(String str in listBox1.Items)
            {
                MessageBox.Show($"Data type of listbox index items: {str.GetType()}");
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
    }
}
