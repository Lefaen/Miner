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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelNumOfBomb = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonNewField = new System.Windows.Forms.Button();
            this.labelNumBombLeft = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.textBoxNumOfBomb);
            this.panelMenu.Controls.Add(this.buttonStartGame);
            this.panelMenu.Controls.Add(this.labelNumOfBomb);
            this.panelMenu.Controls.Add(this.labelX);
            this.panelMenu.Controls.Add(this.textBoxHeight);
            this.panelMenu.Controls.Add(this.textBoxWidth);
            this.panelMenu.Controls.Add(this.labelSize);
            this.panelMenu.Location = new System.Drawing.Point(10, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 79);
            this.panelMenu.TabIndex = 0;
            // 
            // textBoxNumOfBomb
            // 
            this.textBoxNumOfBomb.Location = new System.Drawing.Point(205, 16);
            this.textBoxNumOfBomb.Name = "textBoxNumOfBomb";
            this.textBoxNumOfBomb.Size = new System.Drawing.Size(20, 20);
            this.textBoxNumOfBomb.TabIndex = 5;
            this.textBoxNumOfBomb.Text = "15";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(64, 49);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(90, 25);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // labelNumOfBomb
            // 
            this.labelNumOfBomb.AutoSize = true;
            this.labelNumOfBomb.Location = new System.Drawing.Point(130, 0);
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
            // buttonNewField
            // 
            this.buttonNewField.Location = new System.Drawing.Point(181, 78);
            this.buttonNewField.Name = "buttonNewField";
            this.buttonNewField.Size = new System.Drawing.Size(90, 25);
            this.buttonNewField.TabIndex = 1;
            this.buttonNewField.Text = "Новое поле";
            this.buttonNewField.UseVisualStyleBackColor = true;
            this.buttonNewField.Visible = false;
            this.buttonNewField.Click += new System.EventHandler(this.ButtonNewField_Click);
            // 
            // labelNumBombLeft
            // 
            this.labelNumBombLeft.AutoSize = true;
            this.labelNumBombLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumBombLeft.Location = new System.Drawing.Point(115, 90);
            this.labelNumBombLeft.Name = "labelNumBombLeft";
            this.labelNumBombLeft.Size = new System.Drawing.Size(18, 20);
            this.labelNumBombLeft.TabIndex = 6;
            this.labelNumBombLeft.Text = "0";
            this.labelNumBombLeft.Visible = false;
            // 
            // FormMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 101);
            this.Controls.Add(this.labelNumBombLeft);
            this.Controls.Add(this.buttonNewField);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMiner";
            this.Text = "Miner";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonNewField;
        private System.Windows.Forms.Label labelNumBombLeft;
    }
}

