using ObserverPattern.Others;
namespace ObserverPattern
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ColorCombo = new ColorComboBoxApp.ColorComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Color";
            // 
            // ColorCombo
            // 
            this.ColorCombo.DataSource = ((object)(resources.GetObject("ColorCombo.DataSource")));
            this.ColorCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorCombo.FormattingEnabled = true;
            this.ColorCombo.Location = new System.Drawing.Point(28, 69);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.SelectedColor = System.Drawing.Color.WhiteSmoke;
            this.ColorCombo.Size = new System.Drawing.Size(166, 21);
            this.ColorCombo.TabIndex = 3;
            this.ColorCombo.SelectedIndexChanged += new System.EventHandler(this.ColorCombo_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(222, 172);
            this.Controls.Add(this.ColorCombo);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Observer Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ColorComboBoxApp.ColorComboBox ColorCombo;
    }
}

