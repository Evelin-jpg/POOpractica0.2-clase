namespace POOpractica0._2_clase_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MensajePorChat = new System.Windows.Forms.Button();
            this.btn_MensajeDeRegresoPorChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MensajePorChat
            // 
            this.btn_MensajePorChat.Location = new System.Drawing.Point(227, 81);
            this.btn_MensajePorChat.Name = "btn_MensajePorChat";
            this.btn_MensajePorChat.Size = new System.Drawing.Size(344, 113);
            this.btn_MensajePorChat.TabIndex = 0;
            this.btn_MensajePorChat.Text = "MensajePorChat";
            this.btn_MensajePorChat.UseVisualStyleBackColor = true;
            this.btn_MensajePorChat.Click += new System.EventHandler(this.btn_MensajePorChat_Click);
            // 
            // btn_MensajeDeRegresoPorChat
            // 
            this.btn_MensajeDeRegresoPorChat.Location = new System.Drawing.Point(227, 254);
            this.btn_MensajeDeRegresoPorChat.Name = "btn_MensajeDeRegresoPorChat";
            this.btn_MensajeDeRegresoPorChat.Size = new System.Drawing.Size(344, 124);
            this.btn_MensajeDeRegresoPorChat.TabIndex = 1;
            this.btn_MensajeDeRegresoPorChat.Text = "MensajeDeRegresoPorChat";
            this.btn_MensajeDeRegresoPorChat.UseVisualStyleBackColor = true;
            this.btn_MensajeDeRegresoPorChat.Click += new System.EventHandler(this.btn_MensajeDeRegresoPorChat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MensajeDeRegresoPorChat);
            this.Controls.Add(this.btn_MensajePorChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MensajePorChat;
        private System.Windows.Forms.Button btn_MensajeDeRegresoPorChat;
    }
}

