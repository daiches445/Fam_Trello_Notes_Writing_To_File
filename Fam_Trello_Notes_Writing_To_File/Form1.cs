using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fam_Trello_Notes_Writing_To_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            List<string> usersTagged = new List<string>();
            foreach (var item in note_users_tagged.CheckedItems)
            {
                usersTagged.Add(item.ToString());
            }

            string note = $"Created: {DateTime.Now}  Title: {note_title.Text}  Text: {note_text.Text} Users Tagged: ";
            foreach (var item in usersTagged)
            {
                note += usersTagged.IndexOf(item) == 0 ? item : ", " + item;

            }

            if (File.Exists(@"D:\temp\Notes.txt"))
            {
                StreamWriter sw = File.AppendText(@"D:\temp\Notes.txt");
                sw.WriteLine(note.TrimEnd());
                MessageBox.Show("File was appended! ");
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(@"D:\temp\Notes.txt");
                sw.WriteLine(note.TrimEnd());
                sw.Close();
                MessageBox.Show("File was created! ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\temp\Notes.txt");

            string[] lines = File.ReadAllLines(@"D:\temp\Notes.txt");

            int notes_index = 0;
            lbl_notes.Text = "Notes\n";
            for (int i = 0; i < lines.Length; i++)
            {

                lbl_notes.Text += i + 1 + ". " + lines[i] + "\n";
            }

            sr.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (inpt_id.Text == "")
            {
                {
                    MessageBox.Show("No note selected!");
                    return;
                }
            }

            StreamReader sr = new StreamReader(@"D:\temp\Notes.txt");


            string[] lines = File.ReadAllLines(@"D:\temp\Notes.txt");
            string newText = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if (!((i + 1).ToString() == inpt_id.Text))
                {
                    newText += lines[i] + "\n";
                }

            }


            sr.Close();
            StreamWriter sw = new StreamWriter(@"D:\temp\Notes.txt");

            sw.Write(newText);

            sw.Close();
            MessageBox.Show("Note No. " + inpt_id.Text + " was deleted!");

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (inpt_id.Text == "")
            {
                {
                    MessageBox.Show("No note selected!");
                    return;
                }
            }

            List<string> usersTagged = new List<string>();
            foreach (var item in note_users_tagged.CheckedItems)
            {
                usersTagged.Add(item.ToString());
            }

            string note = $"Created: {DateTime.Now}  Title: {note_title.Text}  Text: {note_text.Text} Users Tagged: ";
            foreach (var item in usersTagged)
            {
                note += usersTagged.IndexOf(item) == 0 ? item : ", " + item;

            }
            StreamReader sr = new StreamReader(@"D:\temp\Notes.txt");


            string[] lines = File.ReadAllLines(@"D:\temp\Notes.txt");
            string newText = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if ((i + 1).ToString() == inpt_id.Text)
                {
                    newText += note + "\n";
                }
                else
                    newText += lines[i] + "\n";
            }


            sr.Close();
            StreamWriter sw = new StreamWriter(@"D:\temp\Notes.txt");

            sw.Write(newText);

            sw.Close();
            MessageBox.Show("Note No. " + inpt_id.Text + " was updated!");
        }

        private void inpt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
