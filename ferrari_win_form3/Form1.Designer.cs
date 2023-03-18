namespace ferrari_win_form3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelgp = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.picturePapaya = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePapaya)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.DodgerBlue;
            this.listView1.Font = new System.Drawing.Font("Formula1 TV--Monospaced", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(465, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labelgp
            // 
            this.labelgp.AutoSize = true;
            this.labelgp.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelgp.Location = new System.Drawing.Point(32, 12);
            this.labelgp.Name = "labelgp";
            this.labelgp.Size = new System.Drawing.Size(381, 40);
            this.labelgp.TabIndex = 1;
            this.labelgp.Text = "Gestione Prodotti";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(19, 92);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(101, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Location = new System.Drawing.Point(233, 92);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(101, 20);
            this.textBoxPrezzo.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Formula1 TV--Monospaced", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(15, 65);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(79, 24);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            // 
            // labelPrezzo
            // 
            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Font = new System.Drawing.Font("Formula1 TV--Monospaced", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrezzo.ForeColor = System.Drawing.Color.Black;
            this.labelPrezzo.Location = new System.Drawing.Point(229, 65);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(88, 24);
            this.labelPrezzo.TabIndex = 5;
            this.labelPrezzo.Text = "Prezzo:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Location = new System.Drawing.Point(19, 136);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 30);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Aggiungi";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonDel.Location = new System.Drawing.Point(340, 136);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(101, 30);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Cancella";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonMod.Location = new System.Drawing.Point(233, 136);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(101, 30);
            this.buttonMod.TabIndex = 8;
            this.buttonMod.Text = "Modifica";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonFind.Location = new System.Drawing.Point(126, 136);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(101, 30);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Ricerca";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // picturePapaya
            // 
            this.picturePapaya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePapaya.BackgroundImage")));
            this.picturePapaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePapaya.Location = new System.Drawing.Point(44, 237);
            this.picturePapaya.Name = "picturePapaya";
            this.picturePapaya.Size = new System.Drawing.Size(369, 173);
            this.picturePapaya.TabIndex = 10;
            this.picturePapaya.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Formula_1_2020_Semi_bold_POS_Ak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonExit.Location = new System.Drawing.Point(179, 408);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 30);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Uscita";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Formula1 TV--Monospaced", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPrice.ForeColor = System.Drawing.Color.Black;
            this.labelNewPrice.Location = new System.Drawing.Point(229, 184);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(132, 19);
            this.labelNewPrice.TabIndex = 15;
            this.labelNewPrice.Text = "Nuovo Prezzo:";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Font = new System.Drawing.Font("Formula1 TV--Monospaced", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewName.ForeColor = System.Drawing.Color.Black;
            this.labelNewName.Location = new System.Drawing.Point(15, 184);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(122, 19);
            this.labelNewName.TabIndex = 14;
            this.labelNewName.Text = "Nuovo Nome:";
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Location = new System.Drawing.Point(233, 211);
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(101, 20);
            this.textBoxNewPrice.TabIndex = 13;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(19, 211);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(101, 20);
            this.textBoxNewName.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.textBoxNewPrice);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.picturePapaya);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrezzo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxPrezzo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelgp);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePapaya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelgp;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPrezzo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPrezzo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.PictureBox picturePapaya;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxNewPrice;
        private System.Windows.Forms.TextBox textBoxNewName;
    }
}

