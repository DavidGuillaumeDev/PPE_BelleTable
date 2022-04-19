
namespace PPE_BelleTable
{
    partial class FormAdd
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNeedName = new System.Windows.Forms.Label();
            this.labelNeedLastname = new System.Windows.Forms.Label();
            this.labelNeedEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSaveSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(285, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Nom";
            this.textBoxName.Size = new System.Drawing.Size(253, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(285, 182);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.PlaceholderText = "Prenom";
            this.textBoxLastname.Size = new System.Drawing.Size(253, 27);
            this.textBoxLastname.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(285, 240);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Email";
            this.textBoxEmail.Size = new System.Drawing.Size(253, 27);
            this.textBoxEmail.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(359, 306);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNeedName
            // 
            this.labelNeedName.AutoSize = true;
            this.labelNeedName.Location = new System.Drawing.Point(285, 158);
            this.labelNeedName.Name = "labelNeedName";
            this.labelNeedName.Size = new System.Drawing.Size(162, 20);
            this.labelNeedName.TabIndex = 4;
            this.labelNeedName.Text = "Veuillez rentrer un nom";
            this.labelNeedName.Visible = false;
            this.labelNeedName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNeedLastname
            // 
            this.labelNeedLastname.AutoSize = true;
            this.labelNeedLastname.Location = new System.Drawing.Point(285, 217);
            this.labelNeedLastname.Name = "labelNeedLastname";
            this.labelNeedLastname.Size = new System.Drawing.Size(184, 20);
            this.labelNeedLastname.TabIndex = 5;
            this.labelNeedLastname.Text = "Veuillez rentrer un prénom";
            this.labelNeedLastname.Visible = false;
            // 
            // labelNeedEmail
            // 
            this.labelNeedEmail.AutoSize = true;
            this.labelNeedEmail.Location = new System.Drawing.Point(285, 270);
            this.labelNeedEmail.Name = "labelNeedEmail";
            this.labelNeedEmail.Size = new System.Drawing.Size(267, 20);
            this.labelNeedEmail.TabIndex = 6;
            this.labelNeedEmail.Text = "Veuillez rentrer une adresse mail valide";
            this.labelNeedEmail.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(615, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Déclarer un incident";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelSaveSuccess
            // 
            this.labelSaveSuccess.AutoSize = true;
            this.labelSaveSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelSaveSuccess.Location = new System.Drawing.Point(298, 347);
            this.labelSaveSuccess.Name = "labelSaveSuccess";
            this.labelSaveSuccess.Size = new System.Drawing.Size(229, 20);
            this.labelSaveSuccess.TabIndex = 8;
            this.labelSaveSuccess.Text = "Participant enregistré avec succès";
            this.labelSaveSuccess.Visible = false;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSaveSuccess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNeedEmail);
            this.Controls.Add(this.labelNeedLastname);
            this.Controls.Add(this.labelNeedName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAdd";
            this.Text = "Formulaire d\'ajout de participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelNeedName;
        private System.Windows.Forms.Label labelNeedLastname;
        private System.Windows.Forms.Label labelNeedEmail;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelSaveSuccess;
    }
}