namespace CajeroATM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cero = new System.Windows.Forms.Label();
            this.tres = new System.Windows.Forms.Label();
            this.seis = new System.Windows.Forms.Label();
            this.dos = new System.Windows.Forms.Label();
            this.uno = new System.Windows.Forms.Label();
            this.ocho = new System.Windows.Forms.Label();
            this.siete = new System.Windows.Forms.Label();
            this.cinco = new System.Windows.Forms.Label();
            this.cuatro = new System.Windows.Forms.Label();
            this.nueve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumTarjeta.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.Location = new System.Drawing.Point(36, 213);
            this.txtNumTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(339, 29);
            this.txtNumTarjeta.TabIndex = 6;
            this.txtNumTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumTarjeta.TextChanged += new System.EventHandler(this.txtNumTarjeta_TextChanged);
            this.txtNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTarjeta_KeyPress);
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(399, 213);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(339, 29);
            this.txtPin.TabIndex = 7;
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.UseSystemPasswordChar = true;
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero de Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pin de Seguridad";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(109, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Vaciar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(297, 374);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 58);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(485, 374);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 58);
            this.button5.TabIndex = 15;
            this.button5.Text = "Aceptar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 91);
            this.label3.TabIndex = 10;
            this.label3.Text = "GenesysATM LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cero
            // 
            this.cero.AutoSize = true;
            this.cero.BackColor = System.Drawing.Color.Transparent;
            this.cero.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(78, 280);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(50, 54);
            this.cero.TabIndex = 16;
            this.cero.Text = "0";
            // 
            // tres
            // 
            this.tres.AutoSize = true;
            this.tres.BackColor = System.Drawing.Color.Transparent;
            this.tres.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(261, 280);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(50, 54);
            this.tres.TabIndex = 17;
            this.tres.Text = "3";
            // 
            // seis
            // 
            this.seis.AutoSize = true;
            this.seis.BackColor = System.Drawing.Color.Transparent;
            this.seis.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(458, 280);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(50, 54);
            this.seis.TabIndex = 18;
            this.seis.Text = "6";
            // 
            // dos
            // 
            this.dos.AutoSize = true;
            this.dos.BackColor = System.Drawing.Color.Transparent;
            this.dos.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(192, 280);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(50, 54);
            this.dos.TabIndex = 19;
            this.dos.Text = "2";
            // 
            // uno
            // 
            this.uno.AutoSize = true;
            this.uno.BackColor = System.Drawing.Color.Transparent;
            this.uno.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(131, 280);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(50, 54);
            this.uno.TabIndex = 20;
            this.uno.Text = "1";
            // 
            // ocho
            // 
            this.ocho.AutoSize = true;
            this.ocho.BackColor = System.Drawing.Color.Transparent;
            this.ocho.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(590, 280);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(50, 54);
            this.ocho.TabIndex = 21;
            this.ocho.Text = "8";
            // 
            // siete
            // 
            this.siete.AutoSize = true;
            this.siete.BackColor = System.Drawing.Color.Transparent;
            this.siete.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(522, 280);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(50, 54);
            this.siete.TabIndex = 22;
            this.siete.Text = "7";
            // 
            // cinco
            // 
            this.cinco.AutoSize = true;
            this.cinco.BackColor = System.Drawing.Color.Transparent;
            this.cinco.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(396, 280);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(50, 54);
            this.cinco.TabIndex = 23;
            this.cinco.Text = "5";
            // 
            // cuatro
            // 
            this.cuatro.AutoSize = true;
            this.cuatro.BackColor = System.Drawing.Color.Transparent;
            this.cuatro.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(326, 280);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(50, 54);
            this.cuatro.TabIndex = 24;
            this.cuatro.Text = "4";
            // 
            // nueve
            // 
            this.nueve.AutoSize = true;
            this.nueve.BackColor = System.Drawing.Color.Transparent;
            this.nueve.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(646, 280);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(50, 54);
            this.nueve.TabIndex = 25;
            this.nueve.Text = "9";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 484);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtNumTarjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cero;
        private System.Windows.Forms.Label tres;
        private System.Windows.Forms.Label seis;
        private System.Windows.Forms.Label dos;
        private System.Windows.Forms.Label uno;
        private System.Windows.Forms.Label ocho;
        private System.Windows.Forms.Label siete;
        private System.Windows.Forms.Label cinco;
        private System.Windows.Forms.Label cuatro;
        private System.Windows.Forms.Label nueve;
    }
}