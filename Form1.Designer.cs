namespace tablaformlgmm3c
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
            panel1princ = new Panel();
            richTextresul = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            label1 = new Label();
            tabla = new Label();
            label2 = new Label();
            panel1princ.SuspendLayout();
            SuspendLayout();
            // 
            // panel1princ
            // 
            panel1princ.BackColor = SystemColors.AppWorkspace;
            panel1princ.Controls.Add(label2);
            panel1princ.Controls.Add(richTextresul);
            panel1princ.Controls.Add(buttonver);
            panel1princ.Controls.Add(textBoxnum);
            panel1princ.Controls.Add(label1);
            panel1princ.Controls.Add(tabla);
            panel1princ.Location = new Point(2, 3);
            panel1princ.Name = "panel1princ";
            panel1princ.Size = new Size(786, 345);
            panel1princ.TabIndex = 0;
            // 
            // richTextresul
            // 
            richTextresul.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextresul.Location = new Point(339, 105);
            richTextresul.Name = "richTextresul";
            richTextresul.Size = new Size(100, 160);
            richTextresul.TabIndex = 4;
            richTextresul.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = SystemColors.GradientActiveCaption;
            buttonver.Location = new Point(97, 156);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(88, 127);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 23);
            textBoxnum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 94);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Cual tabla quieres?";
            // 
            // tabla
            // 
            tabla.AutoSize = true;
            tabla.Font = new Font("Lucida Bright", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabla.Location = new Point(72, 64);
            tabla.Name = "tabla";
            tabla.Size = new Size(135, 15);
            tabla.TabIndex = 0;
            tabla.Text = "Tabla de Multiplicar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 36);
            label2.Name = "label2";
            label2.Size = new Size(230, 15);
            label2.TabIndex = 5;
            label2.Text = "Luis Gustavo Martinez Munoz 3C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1princ);
            Name = "Form1";
            Text = "Form1";
            panel1princ.ResumeLayout(false);
            panel1princ.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1princ;
        private Label tabla;
        private RichTextBox richTextresul;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label label1;
        private Label label2;
    }
}
