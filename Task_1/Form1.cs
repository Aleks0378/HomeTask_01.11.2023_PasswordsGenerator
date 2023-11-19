using System.Text;
using Task_1.Models;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool textBoxFilled = false;

        bool[] Modifiers() => new bool[6]
        {
            checkBox2.Checked,
            checkBox3.Checked,
            checkBox4.Checked,
            checkBox5.Checked,
            checkBox6.Checked,
            textBoxFilled,
        };

        bool IsCheckNoRepetitions()
        {
            if (checkBox6.Checked)
            {
                bool[] options = Modifiers();
                int number = 0;
                if (options[0]) { number += 10; }
                if (options[1]) { number += 26; }
                if (options[2]) { number += 26; }
                if (options[3]) { number += 15; }
                if (options[5])
                {
                    var st = new StringBuilder();
                    for (int i = 0;i< textBox1.Text.Length;i++)
                    {
                        st.Append(textBox1.Text[i]);
                        if (st.Length > 1)
                        {
                            for (int j = 0; j < st.Length - 1; j++)
                            {
                                if (st[j].Equals(st[st.Length - 1]))
                                {
                                    st.Remove(st.Length - 1, 1);
                                    break;
                                }
                            }
                        }
                    }
                    number = st.Length;
                }
                int length = (int)PasswordLengthNumericUpDown.Value;
                return length <= number;
            }
            else { return true; }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = (int)PasswordLengthNumericUpDown.Value;
            if (length > 0)
            {
                if (!Array.TrueForAll(Modifiers(), e => e == false))
                {
                    if (IsCheckNoRepetitions())
                    {
                        listBox1.Items.Clear();
                        Generator generator = new Generator(length, Modifiers(), textBox1.Text);
                        for (int i = 0; i < 20; i++)
                        {
                            listBox1.Items.Add(generator.Generate());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно сгенерировать пароль из уникальных символов!\n(Символов недостаточно)");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните минимум 1 чекбокс!");
                }


            }
            else
            {
                MessageBox.Show("Длинна пароля не может быть меньше 1");
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = listBox1.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBoxFilled = true;
                foreach (var item in this.Controls.OfType<CheckBox>())
                {
                    if (item.Name != "checkBox6")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (var item in this.Controls.OfType<CheckBox>())
                {
                    item.Enabled = true;
                }
            }
        }
    }
}