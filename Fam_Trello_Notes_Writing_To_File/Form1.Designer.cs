namespace Fam_Trello_Notes_Writing_To_File
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.note_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.note_text = new System.Windows.Forms.RichTextBox();
            this.note_users_tagged = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.inpt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // note_title
            // 
            this.note_title.Location = new System.Drawing.Point(305, 55);
            this.note_title.Name = "note_title";
            this.note_title.Size = new System.Drawing.Size(100, 20);
            this.note_title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Users Tagged";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // note_text
            // 
            this.note_text.Location = new System.Drawing.Point(305, 112);
            this.note_text.Name = "note_text";
            this.note_text.Size = new System.Drawing.Size(100, 96);
            this.note_text.TabIndex = 4;
            this.note_text.Text = "";
            // 
            // note_users_tagged
            // 
            this.note_users_tagged.FormattingEnabled = true;
            this.note_users_tagged.Items.AddRange(new object[] {
            "Ely",
            "Nir",
            "Zion",
            "Yakov"});
            this.note_users_tagged.Location = new System.Drawing.Point(305, 246);
            this.note_users_tagged.Name = "note_users_tagged";
            this.note_users_tagged.Size = new System.Drawing.Size(120, 94);
            this.note_users_tagged.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(628, 53);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add To File";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(628, 112);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(92, 23);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "Read From File";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(628, 179);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(628, 235);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(13, 13);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(35, 13);
            this.lbl_notes.TabIndex = 10;
            this.lbl_notes.Text = "Notes";
            this.lbl_notes.Click += new System.EventHandler(this.label4_Click);
            // 
            // inpt_id
            // 
            this.inpt_id.Location = new System.Drawing.Point(735, 205);
            this.inpt_id.Name = "inpt_id";
            this.inpt_id.Size = new System.Drawing.Size(23, 20);
            this.inpt_id.TabIndex = 11;
            this.inpt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpt_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpt_id);
            this.Controls.Add(this.lbl_notes);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.note_users_tagged);
            this.Controls.Add(this.note_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox note_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox note_text;
        private System.Windows.Forms.CheckedListBox note_users_tagged;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.TextBox inpt_id;
        private System.Windows.Forms.Label label4;
    }
}

