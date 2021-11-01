
namespace PRV_Mandelbrot_set
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.oneTrheadButton = new System.Windows.Forms.Button();
            this.multiThreadButton = new System.Windows.Forms.Button();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 528);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // oneTrheadButton
            // 
            this.oneTrheadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.oneTrheadButton.Location = new System.Drawing.Point(12, 546);
            this.oneTrheadButton.Name = "oneTrheadButton";
            this.oneTrheadButton.Size = new System.Drawing.Size(60, 59);
            this.oneTrheadButton.TabIndex = 1;
            this.oneTrheadButton.Text = "🧨";
            this.oneTrheadButton.UseVisualStyleBackColor = true;
            this.oneTrheadButton.Click += new System.EventHandler(this.oneTrheadButton_Click);
            // 
            // multiThreadButton
            // 
            this.multiThreadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.multiThreadButton.Location = new System.Drawing.Point(78, 546);
            this.multiThreadButton.Name = "multiThreadButton";
            this.multiThreadButton.Size = new System.Drawing.Size(60, 59);
            this.multiThreadButton.TabIndex = 2;
            this.multiThreadButton.Text = "🧨🧨🧨🧨";
            this.multiThreadButton.UseVisualStyleBackColor = true;
            this.multiThreadButton.Click += new System.EventHandler(this.multiThreadButton_Click);
            // 
            // statisticLabel
            // 
            this.statisticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Location = new System.Drawing.Point(144, 546);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(145, 20);
            this.statisticLabel.TabIndex = 3;
            this.statisticLabel.Text = "statistic will be here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 617);
            this.Controls.Add(this.statisticLabel);
            this.Controls.Add(this.multiThreadButton);
            this.Controls.Add(this.oneTrheadButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button oneTrheadButton;
        private System.Windows.Forms.Button multiThreadButton;
        private System.Windows.Forms.Label statisticLabel;
    }
}

