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

namespace timerange
{
    public partial class Form1 : Form
    {
        private bool result = false;
        public Form1()
        {
            InitializeComponent();
            Input.SelectedIndex = 0;
            Start.SelectedIndex = 0;
            End.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int InputValue = int.Parse(Input.SelectedItem.ToString());
            int StartValue = int.Parse(Start.SelectedItem.ToString());
            int EndValue = int.Parse(End.SelectedItem.ToString());

            result = false;

            if (EndValue > StartValue)
            {
                if (InputValue >= StartValue && InputValue < EndValue)
                {
                    result = true;
                    //Console.WriteLine("案例１：" + result);
                }
            }

            if (EndValue < StartValue)
            {
                if (InputValue >= StartValue || InputValue < EndValue)
                {
                    result = true;
                    //Console.WriteLine("案例２：" + result);
                }
            }
            if (EndValue == StartValue && InputValue == StartValue)
            {
                result = true;
                //Console.WriteLine("案例３：" + result);
            }
            if (result==true)
            {
                ResultText.Text = "結果は：範囲内です。";
            }
            else
            {
                ResultText.Text = "結果は：範囲外です。";
            }
        }
    }
}
