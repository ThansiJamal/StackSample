using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackSample
{
    public partial class Form1 : Form
    {
        Stack<string> students = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            
             students.Push(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }
        private void btnPop_Click(object sender, EventArgs e)
        {
            
                listBox1.Items.Remove(students.Pop());
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           textBox1.Text = string.Empty;
        }

    }
}
