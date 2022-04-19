
namespace PPE_BelleTable
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddParticipant = new System.Windows.Forms.Button();
            this.buttonSearchParticipant = new System.Windows.Forms.Button();
            this.buttonLeaveApp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddParticipant
            // 
            this.buttonAddParticipant.Location = new System.Drawing.Point(289, 119);
            this.buttonAddParticipant.Name = "buttonAddParticipant";
            this.buttonAddParticipant.Size = new System.Drawing.Size(225, 29);
            this.buttonAddParticipant.TabIndex = 0;
            this.buttonAddParticipant.Text = "Ajouter un participant";
            this.buttonAddParticipant.UseVisualStyleBackColor = true;
            this.buttonAddParticipant.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchParticipant
            // 
            this.buttonSearchParticipant.Location = new System.Drawing.Point(289, 166);
            this.buttonSearchParticipant.Name = "buttonSearchParticipant";
            this.buttonSearchParticipant.Size = new System.Drawing.Size(225, 29);
            this.buttonSearchParticipant.TabIndex = 1;
            this.buttonSearchParticipant.Text = "Rechercher un participant";
            this.buttonSearchParticipant.UseVisualStyleBackColor = true;
            this.buttonSearchParticipant.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLeaveApp
            // 
            this.buttonLeaveApp.Location = new System.Drawing.Point(326, 222);
            this.buttonLeaveApp.Name = "buttonLeaveApp";
            this.buttonLeaveApp.Size = new System.Drawing.Size(144, 29);
            this.buttonLeaveApp.TabIndex = 2;
            this.buttonLeaveApp.Text = "Quitter";
            this.buttonLeaveApp.UseVisualStyleBackColor = true;
            this.buttonLeaveApp.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(615, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Déclarer un incident";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLeaveApp);
            this.Controls.Add(this.buttonSearchParticipant);
            this.Controls.Add(this.buttonAddParticipant);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "BelleTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddParticipant;
        private System.Windows.Forms.Button buttonSearchParticipant;
        private System.Windows.Forms.Button buttonLeaveApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button button1;
    }
}

