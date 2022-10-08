using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Глазки_ООП
{
    public partial class FORMA : Form
    {
        public FORMA()
        {
            InitializeComponent();
        }

        Queue<int> mystack = new Queue<int>(5);


        void richtextbox()
        {
            richTextBox.Clear();
            int[] mas = mystack.List();           
            
            for (int i = 0; i < mas.Length; i++)
            {
                richTextBox.Text += mas[i].ToString() + "\n";
            }
        }

        private void push_Click(object sender, EventArgs e)
        {

            try
            {
                mystack.Push(int.Parse(pushBox.Text));
                richtextbox();
                errorBox.Clear();
            }
            catch(Exception ex)
            {
                errorBox.Text = $"{ex.Message}"; 
            }
            topBox.Clear();
            popBox.Clear();
            pushBox.Clear();
            pushBox.Focus();

        }

        private void pop_Click(object sender, EventArgs e)
        {
            try
            {
                popBox.Text = (mystack.Pop()).ToString();
                richtextbox();
                errorBox.Clear();
            }
            catch (Exception ex)
            {
                errorBox.Text = $"{ex.Message}";
            }
            topBox.Clear();



        }

        private void top_Click(object sender, EventArgs e)
        {
            try
            {
                topBox.Text = (mystack.Top()).ToString();
                errorBox.Clear();
            }
            catch (Exception ex)
            {
                errorBox.Text = $"{ex.Message}";
            }
            popBox.Clear();
        }

    }
}
