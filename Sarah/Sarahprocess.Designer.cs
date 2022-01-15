
namespace Sarah
{
    partial class Sarahprocess
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
            this.lstsarahprocesscommand = new System.Windows.Forms.ListView();
            this.lstcurrentprocessname = new System.Windows.Forms.ListView();
            this.lstusualprocessname = new System.Windows.Forms.ListView();
            this.tbsarahinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstsarahprocesscommand
            // 
            this.lstsarahprocesscommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstsarahprocesscommand.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsarahprocesscommand.ForeColor = System.Drawing.Color.White;
            this.lstsarahprocesscommand.HideSelection = false;
            this.lstsarahprocesscommand.Location = new System.Drawing.Point(12, 77);
            this.lstsarahprocesscommand.Name = "lstsarahprocesscommand";
            this.lstsarahprocesscommand.Size = new System.Drawing.Size(260, 421);
            this.lstsarahprocesscommand.TabIndex = 0;
            this.lstsarahprocesscommand.UseCompatibleStateImageBehavior = false;
            this.lstsarahprocesscommand.View = System.Windows.Forms.View.List;
            // 
            // lstcurrentprocessname
            // 
            this.lstcurrentprocessname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstcurrentprocessname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstcurrentprocessname.ForeColor = System.Drawing.Color.White;
            this.lstcurrentprocessname.HideSelection = false;
            this.lstcurrentprocessname.Location = new System.Drawing.Point(545, 77);
            this.lstcurrentprocessname.Name = "lstcurrentprocessname";
            this.lstcurrentprocessname.Size = new System.Drawing.Size(260, 421);
            this.lstcurrentprocessname.TabIndex = 1;
            this.lstcurrentprocessname.UseCompatibleStateImageBehavior = false;
            this.lstcurrentprocessname.View = System.Windows.Forms.View.List;
            // 
            // lstusualprocessname
            // 
            this.lstusualprocessname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstusualprocessname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstusualprocessname.ForeColor = System.Drawing.Color.White;
            this.lstusualprocessname.HideSelection = false;
            this.lstusualprocessname.Location = new System.Drawing.Point(278, 77);
            this.lstusualprocessname.Name = "lstusualprocessname";
            this.lstusualprocessname.Size = new System.Drawing.Size(260, 421);
            this.lstusualprocessname.TabIndex = 2;
            this.lstusualprocessname.UseCompatibleStateImageBehavior = false;
            this.lstusualprocessname.View = System.Windows.Forms.View.List;
            // 
            // tbsarahinput
            // 
            this.tbsarahinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbsarahinput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsarahinput.ForeColor = System.Drawing.Color.White;
            this.tbsarahinput.Location = new System.Drawing.Point(512, 12);
            this.tbsarahinput.Name = "tbsarahinput";
            this.tbsarahinput.Size = new System.Drawing.Size(293, 27);
            this.tbsarahinput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(559, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Process name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usual Process name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sarah Process command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(372, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sarah input";
            // 
            // Sarahprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(817, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsarahinput);
            this.Controls.Add(this.lstusualprocessname);
            this.Controls.Add(this.lstcurrentprocessname);
            this.Controls.Add(this.lstsarahprocesscommand);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sarahprocess";
            this.Text = "Sarahprocess";
            this.Load += new System.EventHandler(this.Sarahprocess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstsarahprocesscommand;
        private System.Windows.Forms.ListView lstcurrentprocessname;
        private System.Windows.Forms.ListView lstusualprocessname;
        private System.Windows.Forms.TextBox tbsarahinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}