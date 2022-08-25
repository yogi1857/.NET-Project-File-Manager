using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace fileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Go_Click(object sender, EventArgs e)
        {
           // String s = textBox1.Text;
            String s1 = comboBox1.Text;
         
            if (s1.Length != 0)
            {
                String[] array1 = Directory.GetDirectories(s1);
                foreach (String i in array1)
                {
                    listBox1.Items.Add(i);

                }
            }
            textBox1.Text = Directory.GetDirectoryRoot(comboBox1.Text);
      

        }
     

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            String str = listBox1.SelectedItem.ToString();
            
            webBrowser1.Navigate(str);
            textBox1.Text = str;
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] a = Directory.GetLogicalDrives();
            foreach(string i in a){
                comboBox1.Items.Add(i);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
    }
}
