namespace GetPostAppGUI
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
            this.postbtn = new System.Windows.Forms.Button();
            this.getbtn = new System.Windows.Forms.Button();
            this.txtGetResults = new System.Windows.Forms.TextBox();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postbtn
            // 
            this.postbtn.BackColor = System.Drawing.Color.Transparent;
            this.postbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postbtn.Location = new System.Drawing.Point(316, 16);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(89, 29);
            this.postbtn.TabIndex = 1;
            this.postbtn.Text = "POST";
            this.postbtn.UseVisualStyleBackColor = false;
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // getbtn
            // 
            this.getbtn.BackColor = System.Drawing.Color.Transparent;
            this.getbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getbtn.Location = new System.Drawing.Point(529, 254);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(89, 35);
            this.getbtn.TabIndex = 2;
            this.getbtn.Text = "GET";
            this.getbtn.UseVisualStyleBackColor = false;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // txtGetResults
            // 
            this.txtGetResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetResults.Location = new System.Drawing.Point(89, 116);
            this.txtGetResults.Multiline = true;
            this.txtGetResults.Name = "txtGetResults";
            this.txtGetResults.Size = new System.Drawing.Size(529, 132);
            this.txtGetResults.TabIndex = 3;
            // 
            // txtPostData
            // 
            this.txtPostData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostData.Location = new System.Drawing.Point(411, 13);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.Size = new System.Drawing.Size(207, 32);
            this.txtPostData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblPostStatus
            // 
            this.lblPostStatus.AutoSize = true;
            this.lblPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostStatus.Location = new System.Drawing.Point(264, 67);
            this.lblPostStatus.Name = "lblPostStatus";
            this.lblPostStatus.Size = new System.Drawing.Size(0, 16);
            this.lblPostStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 301);
            this.Controls.Add(this.lblPostStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostData);
            this.Controls.Add(this.txtGetResults);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.postbtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.Button getbtn;
        private System.Windows.Forms.TextBox txtGetResults;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPostStatus;
    }
}

