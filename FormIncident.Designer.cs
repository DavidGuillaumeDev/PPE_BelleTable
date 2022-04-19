
namespace PPE_BelleTable
{
    partial class FormIncident
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonSendIncident = new System.Windows.Forms.Button();
            this.labelNeedDescription = new System.Windows.Forms.Label();
            this.labelNeedObjet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objet de l\'incident :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description de l\'incident : ";
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Location = new System.Drawing.Point(158, 70);
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(525, 27);
            this.textBoxObjet.TabIndex = 2;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(158, 167);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(525, 190);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonSendIncident
            // 
            this.buttonSendIncident.Location = new System.Drawing.Point(366, 393);
            this.buttonSendIncident.Name = "buttonSendIncident";
            this.buttonSendIncident.Size = new System.Drawing.Size(94, 29);
            this.buttonSendIncident.TabIndex = 4;
            this.buttonSendIncident.Text = "Envoyer";
            this.buttonSendIncident.UseVisualStyleBackColor = true;
            this.buttonSendIncident.Click += new System.EventHandler(this.buttonSendIncident_Click);
            // 
            // labelNeedDescription
            // 
            this.labelNeedDescription.AutoSize = true;
            this.labelNeedDescription.Location = new System.Drawing.Point(158, 360);
            this.labelNeedDescription.Name = "labelNeedDescription";
            this.labelNeedDescription.Size = new System.Drawing.Size(204, 20);
            this.labelNeedDescription.TabIndex = 5;
            this.labelNeedDescription.Text = "Il faut ajouter une description";
            this.labelNeedDescription.Visible = false;
            // 
            // labelNeedObjet
            // 
            this.labelNeedObjet.AutoSize = true;
            this.labelNeedObjet.Location = new System.Drawing.Point(158, 104);
            this.labelNeedObjet.Name = "labelNeedObjet";
            this.labelNeedObjet.Size = new System.Drawing.Size(157, 20);
            this.labelNeedObjet.TabIndex = 6;
            this.labelNeedObjet.Text = "Il faut ajouter un objet";
            this.labelNeedObjet.Visible = false;
            // 
            // FormIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNeedObjet);
            this.Controls.Add(this.labelNeedDescription);
            this.Controls.Add(this.buttonSendIncident);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxObjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIncident";
            this.Text = "Déclaration d\'incidents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonSendIncident;
        private System.Windows.Forms.Label labelNeedDescription;
        private System.Windows.Forms.Label labelNeedObjet;
    }
}