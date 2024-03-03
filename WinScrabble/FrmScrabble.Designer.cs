
namespace WinScrabble
{
    partial class FrmScrabble
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnValJ1 = new System.Windows.Forms.Button();
            this.btnValJ2 = new System.Windows.Forms.Button();
            this.txtMotJ1 = new System.Windows.Forms.TextBox();
            this.txtMotJ2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.scoreJ1 = new System.Windows.Forms.Label();
            this.scoreJ2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(41, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Joueur 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(41, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Joueur 2";
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(205, 109);
            this.txtJ1.Margin = new System.Windows.Forms.Padding(4);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(132, 22);
            this.txtJ1.TabIndex = 2;
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(205, 152);
            this.txtJ2.Margin = new System.Windows.Forms.Padding(4);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(132, 22);
            this.txtJ2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(392, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commencer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Joueur qui commence : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(40, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Joueur 1 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(460, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Joueur 2 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label6.Location = new System.Drawing.Point(299, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "SCRABBLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(41, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lettres imposées : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(461, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lettres imposées : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(39, 363);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mot : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(460, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mot : ";
            // 
            // btnValJ1
            // 
            this.btnValJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnValJ1.Location = new System.Drawing.Point(117, 421);
            this.btnValJ1.Margin = new System.Windows.Forms.Padding(4);
            this.btnValJ1.Name = "btnValJ1";
            this.btnValJ1.Size = new System.Drawing.Size(121, 31);
            this.btnValJ1.TabIndex = 14;
            this.btnValJ1.Text = "Valider";
            this.btnValJ1.UseVisualStyleBackColor = true;
            this.btnValJ1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnValJ2
            // 
            this.btnValJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnValJ2.Location = new System.Drawing.Point(534, 421);
            this.btnValJ2.Margin = new System.Windows.Forms.Padding(4);
            this.btnValJ2.Name = "btnValJ2";
            this.btnValJ2.Size = new System.Drawing.Size(121, 31);
            this.btnValJ2.TabIndex = 15;
            this.btnValJ2.Text = "Valider";
            this.btnValJ2.UseVisualStyleBackColor = true;
            this.btnValJ2.Click += new System.EventHandler(this.btnValJ2_Click);
            // 
            // txtMotJ1
            // 
            this.txtMotJ1.Location = new System.Drawing.Point(113, 366);
            this.txtMotJ1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotJ1.Name = "txtMotJ1";
            this.txtMotJ1.Size = new System.Drawing.Size(132, 22);
            this.txtMotJ1.TabIndex = 16;
            // 
            // txtMotJ2
            // 
            this.txtMotJ2.Location = new System.Drawing.Point(534, 363);
            this.txtMotJ2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotJ2.Name = "txtMotJ2";
            this.txtMotJ2.Size = new System.Drawing.Size(132, 22);
            this.txtMotJ2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 310);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(630, 310);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 19;
            // 
            // scoreJ1
            // 
            this.scoreJ1.AutoSize = true;
            this.scoreJ1.BackColor = System.Drawing.SystemColors.Info;
            this.scoreJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.scoreJ1.Location = new System.Drawing.Point(109, 482);
            this.scoreJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreJ1.Name = "scoreJ1";
            this.scoreJ1.Size = new System.Drawing.Size(72, 22);
            this.scoreJ1.TabIndex = 20;
            this.scoreJ1.Text = "Score : ";
            // 
            // scoreJ2
            // 
            this.scoreJ2.AutoSize = true;
            this.scoreJ2.BackColor = System.Drawing.SystemColors.Info;
            this.scoreJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.scoreJ2.Location = new System.Drawing.Point(530, 482);
            this.scoreJ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreJ2.Name = "scoreJ2";
            this.scoreJ2.Size = new System.Drawing.Size(72, 22);
            this.scoreJ2.TabIndex = 21;
            this.scoreJ2.Text = "Score : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(345, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gagnant : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 82);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(-2, 581);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 226);
            this.panel2.TabIndex = 24;
            // 
            // btnRes
            // 
            this.btnRes.Enabled = false;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRes.Location = new System.Drawing.Point(340, 534);
            this.btnRes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(121, 31);
            this.btnRes.TabIndex = 25;
            this.btnRes.Text = "Résultat";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 65);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(800, 63);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(328, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Meilleur mot : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(-2, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 332);
            this.panel3.TabIndex = 26;
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 800);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scoreJ2);
            this.Controls.Add(this.scoreJ1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMotJ2);
            this.Controls.Add(this.txtMotJ1);
            this.Controls.Add(this.btnValJ2);
            this.Controls.Add(this.btnValJ1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJ2);
            this.Controls.Add(this.txtJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJ1;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnValJ1;
        private System.Windows.Forms.Button btnValJ2;
        private System.Windows.Forms.TextBox txtMotJ1;
        private System.Windows.Forms.TextBox txtMotJ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label scoreJ1;
        private System.Windows.Forms.Label scoreJ2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
    }
}

