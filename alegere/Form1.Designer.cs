namespace alegere
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gestionare = new Button();
            note = new Button();
            SuspendLayout();
            // 
            // gestionare
            // 
            gestionare.Location = new Point(69, 95);
            gestionare.Name = "gestionare";
            gestionare.Size = new Size(178, 142);
            gestionare.TabIndex = 0;
            gestionare.Text = "Gestionare Studenti";
            gestionare.UseVisualStyleBackColor = true;
            gestionare.Click += gestionare_Click;
            // 
            // note
            // 
            note.Location = new Point(396, 95);
            note.Name = "note";
            note.Size = new Size(178, 142);
            note.TabIndex = 1;
            note.Text = "Note Studenti";
            note.UseVisualStyleBackColor = true;
            note.Click += note_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 317);
            Controls.Add(note);
            Controls.Add(gestionare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button gestionare;
        private Button note;
    }
}