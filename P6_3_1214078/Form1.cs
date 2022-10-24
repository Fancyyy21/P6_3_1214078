using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //namespace tambahan

namespace P6_3_1214078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
            
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                }
            }
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul");
                }
                else
                {
                    epWarning.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
            
        }

        private void txtAngka1_Leave(object sender, EventArgs e) 
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);
            if (txtAngka1.Text == "")
            {
                string input = String.Empty;
                epCorrect.SetError(txtAngka1, "");
                epWarning.SetError(txtAngka1, "Textbox Angka 2 tidak boleh kosong");
                epWrong.SetError(txtAngka1, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka1, "Betul");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                }
            }
            if (Angka1 > Angka2)
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "Benar");

                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "Benar");
            }
            else
            {
                epWarning.SetError(txtAngka1, "Salah");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

                epWarning.SetError(txtAngka2, "Salah");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }

        }

       
        private void txtAngka2_Leave_1(object sender, EventArgs e)
        {
            {
                int Angka1 = int.Parse(txtAngka1.Text);
                int Angka2 = int.Parse(txtAngka2.Text);

                if (txtAngka2.Text == "")
                {
                    string input = String.Empty;

                    epWarning.SetError(txtAngka2, "Text Box tidak boleh kosong!");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
                else
                {
                    if ((txtAngka2.Text).All(Char.IsNumber))
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "Betul!");
                    }
                    else
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                        epCorrect.SetError(txtAngka2, "");
                    }
                }
                if (Angka1 > Angka2)
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Benar");

                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Benar");
                }
                else
                {
                    epWarning.SetError(txtAngka1, "Salah");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");

                    epWarning.SetError(txtAngka2, "Salah");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }
    }
}
