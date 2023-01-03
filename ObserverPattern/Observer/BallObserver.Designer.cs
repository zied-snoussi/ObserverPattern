using ObserverPattern.Others;
namespace ObserverPattern
{
    partial class BallObserver
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
            this.circleShape1 = new CircleShape();
            this.circleShape2 = new CircleShape();
            this.circleShape3 = new CircleShape();
            this.SuspendLayout();
            // 
            // circleShape1
            // 
            this.circleShape1.Location = new System.Drawing.Point(12, 12);
            this.circleShape1.Name = "circleShape1";
            this.circleShape1.Size = new System.Drawing.Size(42, 38);
            this.circleShape1.TabIndex = 0;
            this.circleShape1.Text = "circleShape1";
            // 
            // circleShape2
            // 
            this.circleShape2.Location = new System.Drawing.Point(170, 23);
            this.circleShape2.Name = "circleShape2";
            this.circleShape2.Size = new System.Drawing.Size(94, 89);
            this.circleShape2.TabIndex = 1;
            this.circleShape2.Text = "circleShape2";
            // 
            // circleShape3
            // 
            this.circleShape3.Location = new System.Drawing.Point(68, 116);
            this.circleShape3.Name = "circleShape3";
            this.circleShape3.Size = new System.Drawing.Size(57, 48);
            this.circleShape3.TabIndex = 2;
            this.circleShape3.Text = "circleShape3";
            // 
            // BallObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 193);
            this.Controls.Add(this.circleShape3);
            this.Controls.Add(this.circleShape2);
            this.Controls.Add(this.circleShape1);
            this.Name = "BallObserver";
            this.Text = "Ball Observer";
            this.ResumeLayout(false);

        }

        #endregion

        private Others.CircleShape circleShape1;
        private Others.CircleShape circleShape2;
        private Others.CircleShape circleShape3;

    }
}