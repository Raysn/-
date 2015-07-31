using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EraNameConverter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }
	
	UInt32 year;
	int i;
	int eraFlag = 5;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Era_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Era.SelectedIndex != -1) {
                i = Era.SelectedIndex;
                string era = Era.Items[i].ToString();
		eraFlag = 5;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
		if (textBox1.TextLength != 0)
		{
			year = (UInt32)int.Parse(textBox1.Text);
			if (year > 0)
			{
				convertYear();
				if (eraFlag == 1)
				{
					result.Text = "平成" + Convert.ToString(year);
				}
				else if (eraFlag == 2)
				{
					result.Text = "昭和" + Convert.ToString(year);
				}
				else if (eraFlag == 3)
				{
					result.Text = "大正" + Convert.ToString(year);
				}
				else if (eraFlag == 4)
				{
					result.Text = "明治" + Convert.ToString(year);
				}
				else if (eraFlag == 0)
				{
					result.Text = "Error";
				}
				else
				{
					result.Text = Convert.ToString(year);
				}
			}
		}
        }

	public void convertYear()
	{
		if (i == 0)
		{
			year = year + 1988;
		}
		else if (i == 1)
		{
			year = year + 1925;
		}
		else if (i == 2)
		{
			year = year + 1911;
		}
		else if (i == 3)
		{
			year = year + 1867;
		}
		else if (i == 4)
		{

			//元号毎の処理
			if (year >= 1989)
			{ //平成
				year = year - 1988;
				eraFlag = 1;
			}
			else if (year >= 1926)
			{ //昭和
				year = year - 1925;
				eraFlag = 2;
			}
			else if (year >= 1912)
			{ //大正
				year = year - 1911;
				eraFlag = 3;
			}
			else if (year >= 1868)
			{ //明治
				year = year - 1867;
				eraFlag = 4;
			}
			else
			{
				year = 0;
				eraFlag = 0;
			}
		}
		else
		{
			year = 0;
		}

		
	}

        private void Converter_Load(object sender, EventArgs e)
        {

	}

	

       

	
    }
}
