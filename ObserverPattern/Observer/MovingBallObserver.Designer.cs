using ObserverPattern.Others;
namespace ObserverPattern
{
    partial class MovingBallObserver
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
            this.SuspendLayout();
            // 
            // circleShape1
            // 
            this.circleShape1.FillColor = System.Drawing.Color.Blue;
            this.circleShape1.Location = new System.Drawing.Point(48, 91);
            this.circleShape1.Name = "circleShape1";
            this.circleShape1.Size = new System.Drawing.Size(49, 41);
            this.circleShape1.TabIndex = 0;
            this.circleShape1.Text = "circleShape1";
            // 
            // MovingBallObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 193);
            this.Controls.Add(this.circleShape1);
            this.Name = "MovingBallObserver";
            this.Text = "Moving Ball Observer";
            this.ResumeLayout(false);

        }

        #endregion

        private Others.CircleShape circleShape1;

    }
}