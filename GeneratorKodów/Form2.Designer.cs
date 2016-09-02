namespace GeneratorKodów
{
    partial class Form2
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
            this.bConnect = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbHasło = new System.Windows.Forms.Label();
            this.lbSerwer = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbDb = new System.Windows.Forms.TextBox();
            this.lbDataBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bConnect.Location = new System.Drawing.Point(99, 214);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(100, 25);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "Połącz";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 45);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(100, 135);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(100, 20);
            this.tbServer.TabIndex = 3;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(100, 30);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(102, 13);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Nazwa użytkownika";
            // 
            // lbHasło
            // 
            this.lbHasło.AutoSize = true;
            this.lbHasło.Location = new System.Drawing.Point(100, 75);
            this.lbHasło.Name = "lbHasło";
            this.lbHasło.Size = new System.Drawing.Size(36, 13);
            this.lbHasło.TabIndex = 5;
            this.lbHasło.Text = "Hasło";
            // 
            // lbSerwer
            // 
            this.lbSerwer.AutoSize = true;
            this.lbSerwer.Location = new System.Drawing.Point(100, 120);
            this.lbSerwer.Name = "lbSerwer";
            this.lbSerwer.Size = new System.Drawing.Size(40, 13);
            this.lbSerwer.TabIndex = 6;
            this.lbSerwer.Text = "Serwer";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(100, 90);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 2;
            // 
            // tbDb
            // 
            this.tbDb.Location = new System.Drawing.Point(100, 180);
            this.tbDb.Name = "tbDb";
            this.tbDb.Size = new System.Drawing.Size(100, 20);
            this.tbDb.TabIndex = 7;
            // 
            // lbDataBase
            // 
            this.lbDataBase.AutoSize = true;
            this.lbDataBase.Location = new System.Drawing.Point(100, 165);
            this.lbDataBase.Name = "lbDataBase";
            this.lbDataBase.Size = new System.Drawing.Size(71, 13);
            this.lbDataBase.TabIndex = 8;
            this.lbDataBase.Text = "Baza Danych";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbDataBase);
            this.Controls.Add(this.tbDb);
            this.Controls.Add(this.lbSerwer);
            this.Controls.Add(this.lbHasło);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.bConnect);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbHasło;
        private System.Windows.Forms.Label lbSerwer;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbDb;
        private System.Windows.Forms.Label lbDataBase;
    }
}