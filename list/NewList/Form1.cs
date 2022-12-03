using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewList
{
    public partial class Form1 : Form
    {
        MyList<int> listik = new MyList<int>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Append_button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                listik.Append(int.Parse(Append_box.Text));

                for (int i = 0; i < listik.ToArray().Length; i++)
                {
                    richTextBox1.Text += listik.ToArray()[i].ToString() + "\n";
                }    
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                listik.Remove(int.Parse(Remove_box.Text));
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
            ToArray();
        }
         void ToArray()
        {
            try
            {
                richTextBox1.Text = "";
                foreach (int i in listik)
                {
                    richTextBox1.Text += i + "\n";
                }
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
        }

        private void Prepend_button_Click(object sender, EventArgs e)
        {
            try
            {
                listik.Prepend(int.Parse(Append_box.Text));
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
            ToArray();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    listik.Insert(int.Parse(Index_Box.Text),int.Parse(Append_box.Text));
                }
                catch (Exception le)
                {
                    error_Box.Text = le.Message;
                }
                ToArray();
            }
        }

        private void Remove_index_button_Click(object sender, EventArgs e)
        {
            try
            {
                listik.RemoveIndex(Convert.ToInt32(Index_Box.Text));
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
            ToArray();
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = listik.FindRef(Convert.ToInt32(Find_Box.Text)).ToString();
            }
            catch (Exception le)
            {
                textBox.Text = le.Message;
            }
            ToArray();
        }

        private void Find_index_button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = listik.FindRefIndex(Convert.ToInt32(Find_Index_Box.Text)).ToString();
            }
            catch (Exception le)
            {
                error_Box.Text = le.Message;
            }
            ToArray();
        }

    }
    
}
