namespace Miner
{
    partial class FormMiner
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBoxNumOfBomb = new System.Windows.Forms.TextBox();
            this.labelNumOfBomb = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.textBoxNumOfBomb);
            this.panelMenu.Controls.Add(this.labelNumOfBomb);
            this.panelMenu.Controls.Add(this.labelX);
            this.panelMenu.Controls.Add(this.textBoxHeight);
            this.panelMenu.Controls.Add(this.textBoxWidth);
            this.panelMenu.Controls.Add(this.labelSize);
            this.panelMenu.Controls.Add(this.buttonStartGame);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(98, 112);
            this.panelMenu.TabIndex = 0;
            // 
            // textBoxNumOfBomb
            // 
            this.textBoxNumOfBomb.Location = new System.Drawing.Point(6, 55);
            this.textBoxNumOfBomb.Name = "textBoxNumOfBomb";
            this.textBoxNumOfBomb.Size = new System.Drawing.Size(20, 20);
            this.textBoxNumOfBomb.TabIndex = 5;
            this.textBoxNumOfBomb.Text = "20";
            // 
            // labelNumOfBomb
            // 
            this.labelNumOfBomb.AutoSize = true;
            this.labelNumOfBomb.Location = new System.Drawing.Point(3, 39);
            this.labelNumOfBomb.Name = "labelNumOfBomb";
            this.labelNumOfBomb.Size = new System.Drawing.Size(95, 13);
            this.labelNumOfBomb.TabIndex = 4;
            this.labelNumOfBomb.Text = "Количество бомб";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(32, 19);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(52, 16);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(20, 20);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.Text = "12";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(6, 16);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(20, 20);
            this.textBoxWidth.TabIndex = 1;
            this.textBoxWidth.Text = "10";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(3, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(73, 13);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Размер поля";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(3, 81);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(90, 25);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // FormMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 460);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMiner";
            this.Text = "Miner";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox textBoxNumOfBomb;
        private System.Windows.Forms.Label labelNumOfBomb;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonStartGame;
    }
}

