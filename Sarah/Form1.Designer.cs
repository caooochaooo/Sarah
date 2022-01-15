
namespace Sarah
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
            this.components = new System.ComponentModel.Container();
            this.tbsarahpresentation = new System.Windows.Forms.TextBox();
            this.tbsarahkeyboard = new System.Windows.Forms.TextBox();
            this.tbsarahprocess = new System.Windows.Forms.TextBox();
            this.sarahdashboardicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tbsarahpresentation
            // 
            this.tbsarahpresentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbsarahpresentation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsarahpresentation.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsarahpresentation.ForeColor = System.Drawing.Color.Fuchsia;
            this.tbsarahpresentation.Location = new System.Drawing.Point(130, 31);
            this.tbsarahpresentation.Multiline = true;
            this.tbsarahpresentation.Name = "tbsarahpresentation";
            this.tbsarahpresentation.Size = new System.Drawing.Size(394, 186);
            this.tbsarahpresentation.TabIndex = 0;
            this.tbsarahpresentation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbsarahkeyboard
            // 
            this.tbsarahkeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbsarahkeyboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsarahkeyboard.ForeColor = System.Drawing.Color.Fuchsia;
            this.tbsarahkeyboard.Location = new System.Drawing.Point(32, 295);
            this.tbsarahkeyboard.Multiline = true;
            this.tbsarahkeyboard.Name = "tbsarahkeyboard";
            this.tbsarahkeyboard.Size = new System.Drawing.Size(276, 110);
            this.tbsarahkeyboard.TabIndex = 1;
            // 
            // tbsarahprocess
            // 
            this.tbsarahprocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbsarahprocess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsarahprocess.ForeColor = System.Drawing.Color.Fuchsia;
            this.tbsarahprocess.Location = new System.Drawing.Point(330, 295);
            this.tbsarahprocess.Multiline = true;
            this.tbsarahprocess.Name = "tbsarahprocess";
            this.tbsarahprocess.Size = new System.Drawing.Size(276, 110);
            this.tbsarahprocess.TabIndex = 2;
            // 
            // sarahdashboardicon
            // 
            this.sarahdashboardicon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(652, 442);
            this.Controls.Add(this.tbsarahprocess);
            this.Controls.Add(this.tbsarahkeyboard);
            this.Controls.Add(this.tbsarahpresentation);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Sarah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsarahpresentation;
        private System.Windows.Forms.TextBox tbsarahkeyboard;
        private System.Windows.Forms.TextBox tbsarahprocess;
        private System.Windows.Forms.NotifyIcon sarahdashboardicon;
    }
}

