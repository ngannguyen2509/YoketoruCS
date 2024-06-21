namespace YoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lableTitle = new Label();
            buttonStart = new Button();
            GAMEOVER = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lableTitle
            // 
            lableTitle.AutoSize = true;
            lableTitle.Font = new Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lableTitle.Location = new Point(464, 130);
            lableTitle.Name = "lableTitle";
            lableTitle.Size = new Size(189, 54);
            lableTitle.TabIndex = 0;
            lableTitle.Text = "よけとるVS";
            lableTitle.Click += labelStart_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(500, 229);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(100, 62);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "タイトルへ";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // GAMEOVER
            // 
            GAMEOVER.AutoSize = true;
            GAMEOVER.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            GAMEOVER.Location = new Point(488, 130);
            GAMEOVER.Name = "GAMEOVER";
            GAMEOVER.Size = new Size(165, 37);
            GAMEOVER.TabIndex = 2;
            GAMEOVER.Text = "GAME OVER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(GAMEOVER);
            Controls.Add(buttonStart);
            Controls.Add(lableTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lableTitle;
        private Button buttonStart;
        private Label GAMEOVER;
    }
}