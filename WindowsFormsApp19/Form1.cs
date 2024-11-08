using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text.Trim();
            if (!string.IsNullOrEmpty(item))
            {
                checkedListBoxItems.Items.Add(item, false); 
                textBoxItem.Clear();
            }
            else
            {
                MessageBox.Show("Введите название покупки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (checkedListBoxItems.SelectedItem != null)
            {
                checkedListBoxItems.Items.Remove(checkedListBoxItems.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выделите пункт для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            checkedListBoxItems.Items.Clear();
        }

        private void checkedListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxItems.SelectedItem != null)
            {
                textBoxItem.Text = checkedListBoxItems.SelectedItem.ToString();
            }
            else
            {
                textBoxItem.Clear();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (checkedListBoxItems.SelectedItem != null)
            {
                string newItem = textBoxItem.Text.Trim();
                if (!string.IsNullOrEmpty(newItem))
                {
                    int selectedIndex = checkedListBoxItems.SelectedIndex;
                    checkedListBoxItems.Items[selectedIndex] = newItem; 
                }
                else
                {
                    MessageBox.Show("Введите новое название покупки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выделите пункт для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
