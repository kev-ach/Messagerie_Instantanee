namespace Chat_messenger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.champsTextePseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enregistrerPseudo = new System.Windows.Forms.Button();
            this.pseudoAfficher = new System.Windows.Forms.Label();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(12, 418);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(480, 20);
            this.textMessage.TabIndex = 0;
            this.textMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSend.Location = new System.Drawing.Point(535, 412);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(253, 30);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Envoyé";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // champsTextePseudo
            // 
            this.champsTextePseudo.BackColor = System.Drawing.Color.White;
            this.champsTextePseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.champsTextePseudo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.champsTextePseudo.Location = new System.Drawing.Point(130, 21);
            this.champsTextePseudo.Name = "champsTextePseudo";
            this.champsTextePseudo.Size = new System.Drawing.Size(100, 26);
            this.champsTextePseudo.TabIndex = 3;
            this.champsTextePseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enregistrerPseudo
            // 
            this.enregistrerPseudo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.enregistrerPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerPseudo.ForeColor = System.Drawing.SystemColors.Control;
            this.enregistrerPseudo.Location = new System.Drawing.Point(240, 21);
            this.enregistrerPseudo.Name = "enregistrerPseudo";
            this.enregistrerPseudo.Size = new System.Drawing.Size(146, 26);
            this.enregistrerPseudo.TabIndex = 5;
            this.enregistrerPseudo.Text = "Valider";
            this.enregistrerPseudo.UseVisualStyleBackColor = false;
            this.enregistrerPseudo.Click += new System.EventHandler(this.enregistrerPseudo_Click);
            // 
            // pseudoAfficher
            // 
            this.pseudoAfficher.AutoSize = true;
            this.pseudoAfficher.BackColor = System.Drawing.SystemColors.Control;
            this.pseudoAfficher.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoAfficher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pseudoAfficher.Location = new System.Drawing.Point(12, 378);
            this.pseudoAfficher.Name = "pseudoAfficher";
            this.pseudoAfficher.Size = new System.Drawing.Size(0, 27);
            this.pseudoAfficher.TabIndex = 7;
            this.pseudoAfficher.Click += new System.EventHandler(this.label2_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(12, 12);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(480, 264);
            this.listMessage.TabIndex = 8;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.champsTextePseudo);
            this.groupBox1.Controls.Add(this.enregistrerPseudo);
            this.groupBox1.Location = new System.Drawing.Point(57, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textLocalPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textLocalIp);
            this.groupBox2.Location = new System.Drawing.Point(525, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 128);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textLocalPort
            // 
            this.textLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocalPort.Location = new System.Drawing.Point(69, 90);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(146, 26);
            this.textLocalPort.TabIndex = 2;
            this.textLocalPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textLocalIp
            // 
            this.textLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocalIp.Location = new System.Drawing.Point(69, 38);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(146, 26);
            this.textLocalIp.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textRemotePort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textRemoteIp);
            this.groupBox3.Location = new System.Drawing.Point(525, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 127);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Utilisateur distant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemotePort.Location = new System.Drawing.Point(69, 90);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(146, 26);
            this.textRemotePort.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "IP";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemoteIp.Location = new System.Drawing.Point(69, 38);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(146, 26);
            this.textRemoteIp.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(619, 279);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connexion";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.pseudoAfficher);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chat_Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox champsTextePseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enregistrerPseudo;
        private System.Windows.Forms.Label pseudoAfficher;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Button buttonConnect;
    }
}

