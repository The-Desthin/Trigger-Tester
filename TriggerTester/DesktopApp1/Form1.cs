using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TriggerTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void testTriggerButton_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            System.Diagnostics.Debug.WriteLine(textBox1.Text);
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("-----Start of Log-----");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                //Time Format [Mon Sep 07 14:40:08 2020]
                sw.WriteLine(DateTime.Now.ToString("[ddd MMM dd HH:mm:ss yyy]") + " " + triggerString.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
