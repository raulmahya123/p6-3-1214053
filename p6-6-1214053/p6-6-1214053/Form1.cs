using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace p6_6_1214053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul");

            }
            else
            {
                epWrong.SetError(txtHuruf, "inputan hanya boleh huruf!");
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {

            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");

            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul");
                }

                else
                {
                    epWarning.SetError(txtAngka, "Inputan hanya bole satu");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }


            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }

                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya bole satu");
                    epCorrect.SetError(txtAngka1, "");
                }
                if (txtAngka2.Text == "")
                {
                    epWarning.SetError(txtAngka, "Inputan hanya bole satu");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);

            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka2, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }

                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya bole satu");
                    epCorrect.SetError(txtAngka2, "");
                }
                if (Angka1 > Angka2)
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");

                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "benar");
                }
                else
                {

                    epWarning.SetError(txtAngka1, "wrong");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");

                    epWarning.SetError(txtAngka2, "wrong");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }
    }
}
