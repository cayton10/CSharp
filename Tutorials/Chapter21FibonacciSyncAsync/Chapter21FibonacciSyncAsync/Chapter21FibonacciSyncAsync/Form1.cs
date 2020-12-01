using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter21FibonacciSyncAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSequential_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = "Starting to compute Fibonacci(46)";
            textBoxResults.Refresh();
            DateTime startTime1 = DateTime.Now;
            long result1 = Fibonacci(46);
            DateTime endTime1 = DateTime.Now;

            textBoxResults.AppendText($"Fibonacci(46) = {result1}\r\n");
            double totalTime1 = (endTime1 - startTime1).TotalMinutes;
            textBoxResults.AppendText($"Calculation time = {totalTime1:F6}\r\n");

            
            textBoxResults.AppendText($"Starting to compute Fibonacci(45)\r\n");
            textBoxResults.Refresh();
            DateTime startTime2 = DateTime.Now;
            long result2 = Fibonacci(45);
            DateTime endTime2 = DateTime.Now;

            textBoxResults.AppendText($"Fibonacci(45) = {result2}\r\n");
            double totalTime2 = (endTime2 - startTime2).TotalMinutes;
            textBoxResults.AppendText($"Calculation time = {totalTime2:F6}\r\n");

            textBoxResults.Refresh();
            double totalTime = (endTime2 - startTime1).TotalMinutes;
            textBoxResults.AppendText($"Total Calculation time = {totalTime:F6}\r\n");

        }

        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }

        public TimeData StartFibonacci(int n)
        {
            AppendText($"Starting Fibonacci({n})");
            var result = new TimeData();
            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(n);
            AppendText($"Fibonacci({n})={fibonacciValue}");
            result.EndTime = DateTime.Now;
            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Total Calculation time = {minutes:F6}\r\n");
            return result;
        }

        private void AppendText(string v)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(()=>AppendText(v)));
            }
            else
            {
                textBoxResults.AppendText(v + "\r\n");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //textBoxResults.Text = "Starting to compute Fibonacci(46)";
            textBoxResults.Refresh();
            //DateTime startTime1 = DateTime.Now;
            //long result1 = Fibonacci(46);
            //DateTime endTime1 = DateTime.Now;
            Task<TimeData> task1 = Task.Run(() => StartFibonacci(46));
           // textBoxResults.AppendText("Starting to compute Fibonacci(45)");
            Task<TimeData> task2 = Task.Run(() => StartFibonacci(45));
            //textBoxResults.AppendText($"Fibonacci(46) = {result1}\r\n");
            //double totalTime1 = (endTime1 - startTime1).TotalMinutes;
            //textBoxResults.AppendText($"Calculation time = {totalTime1:F6}\r\n");

            await Task.WhenAll(task1, task2);

            DateTime startTime = (task1.Result.StartTime< task2.Result.StartTime)? task1.Result.StartTime: task2.Result.StartTime;
            DateTime endTime = (task1.Result.EndTime > task2.Result.EndTime) ? task1.Result.EndTime : task2.Result.EndTime;
            double totalMinutes = (endTime - startTime).TotalMinutes;
            textBoxResults.AppendText($"Total Calculation time = {totalMinutes:F6}\r\n");

        }
    }
}
