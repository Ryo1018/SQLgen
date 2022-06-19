using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        Boolean checkFlag = false;
        int state;
        Boolean deduplicationFlag = false;


        private void selectbutton_CheckedChanged(object sender, EventArgs e)
        {
            checkFlag = true;
            state = 0;
        }
        private void insertbutton_CheckedChanged(object sender, EventArgs e)
        {
            checkFlag = true;
            state = 1;
        }

        private void updatebutton_CheckedChanged(object sender, EventArgs e)
        {
            checkFlag = true;
            state = 2;
        }

        private void deletebutton_CheckedChanged(object sender, EventArgs e)
        {
            checkFlag = true;
            state = 3;
        }

        private void run_setup(object sender, EventArgs e)
        {
            run_button.Enabled = true;
            run_button.Cursor = Cursors.Hand;
            run_button.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void not_run_setup(object sender, EventArgs e)
        {
            run_button.Enabled = false;
            run_button.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void select_column_text_changed(object sender, EventArgs e)
        {
            if (table_textbox.Text != "" && column_textbox.Text != "" && checkFlag == true)
            {
                run_setup(sender, e);
            }
            else
            {
                not_run_setup(sender, e);
            }
        }

        private void table_changed(object sender, EventArgs e)
        {
            if (table_textbox.Text != "" && column_textbox.Text != "" && checkFlag == true)
            {
                run_setup(sender, e);
            }
            else
            {
                not_run_setup(sender, e);
            }
        }
        private void is_deduplication_CheckedChanged(object sender, EventArgs e)
        {
            if (is_deduplication.Checked)
            {
                deduplication_column_textbox.ReadOnly = false;
                deduplication_column_textbox.Clear();
                deduplicationFlag = true;
            }
            else
            {
                deduplication_column_textbox.ReadOnly = true;
                deduplicationFlag = false;
                order_asc_button.Checked = false;
                order_desc_button.Checked = false;
            }
        }


        private void run_button_Click(object sender, EventArgs e)
        {
            if (state == 0) // SELECT
            {
                if (parameters_textbox.Text != "")
                {
                    result_text.Text = String.Format("SELECT {0} FROM {1}\r\nWHERE {2}", column_textbox.Text, table_textbox.Text, parameters_textbox.Text);
                }
                else
                {
                    result_text.Text = String.Format("SELECT {0} FROM {1}", column_textbox.Text, table_textbox.Text);
                }

                if (deduplicationFlag == true && order_desc_button.Checked)
                {
                    result_text.Text += String.Format("\r\nGROUP BY {0}\r\nORDER BY {0} DESC", deduplication_column_textbox.Text);
                }
                else if (deduplicationFlag == true && order_asc_button.Checked)
                {
                    result_text.Text += String.Format("\r\nGROUP BY {0}\r\nORDER BY {0} ASC", deduplication_column_textbox.Text);
                }
                else if (deduplicationFlag == true)
                {
                    result_text.Text += String.Format("\r\nGROUP BY {0}", deduplication_column_textbox.Text);
                }

            }
            else if (state == 1) // INSERT
            {
                result_text.Text = String.Format("INSERT INTO {0}({1})\r\nVALUES\r\n{2}", table_textbox.Text, column_textbox.Text, parameters_textbox.Text);
            }
            else if (state == 2) // UPDATE
            {
                result_text.Text = String.Format("UPDATE {0} SET {1} WHERE {2}", table_textbox.Text, column_textbox.Text, parameters_textbox.Text);
            }
            else if (state == 3) // DELETE
            {
                result_text.Text = String.Format("DELETE FROM {0} WHERE {1}", table_textbox.Text, parameters_textbox.Text);
            }
        }

        private void copy_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            string text = result_text.Text;

            if (text != "")
            {
                Clipboard.SetData = (DataFormats.Text, text);
            }
            */

            result_text.SelectAll();
            result_text.Copy();


        }

        private void builder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ryo1018");
        }
    }
}
