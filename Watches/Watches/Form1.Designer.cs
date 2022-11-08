
namespace Watches
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblhour = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.hourdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.Location = new System.Drawing.Point(339, 105);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(99, 33);
            this.lblhour.TabIndex = 0;
            this.lblhour.Text = "label1";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(339, 233);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(92, 31);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "label1";
            // 
            // hourdate
            // 
            this.hourdate.Enabled = true;
            this.hourdate.Tick += new System.EventHandler(this.hourdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblhour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer hourdate;
    }
}

