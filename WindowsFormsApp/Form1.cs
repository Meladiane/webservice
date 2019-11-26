using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        #region FIELDS
        private string textBoxValue;
        #endregion



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Asynchronously call the Web service Fibonacci(10)
            // on your localhost
            ComputationWebServiceReference.ComputationWebServiceSoapClient client =
                new ComputationWebServiceReference.ComputationWebServiceSoapClient();
            int result = client.Fibonacci(6);

            // Web service returns the result
            MessageBox.Show(result.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComputationWebServiceReference.ComputationWebServiceSoapClient client =
                new ComputationWebServiceReference.ComputationWebServiceSoapClient();
            string str = textBox1.Text;
            string result = client.XmlToJson(str);

            // Web service returns the result
            MessageBox.Show(result.ToString());
        }
    }
}
