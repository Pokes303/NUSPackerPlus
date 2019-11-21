namespace NUSPackerPlus
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.enckeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enckeyButton = new System.Windows.Forms.Button();
            this.comkeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comkeyCheckBut = new System.Windows.Forms.Button();
            this.comkeySaveBut = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.inputBFD = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBFD = new System.Windows.Forms.FolderBrowserDialog();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.outputOpenButton = new System.Windows.Forms.Button();
            this.inputOpenButton = new System.Windows.Forms.Button();
            this.loadsetButton = new System.Windows.Forms.Button();
            this.savepreButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUSPacker Plus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output directory";
            // 
            // outputTextBox
            // 
            this.outputTextBox.AllowDrop = true;
            this.outputTextBox.BackColor = System.Drawing.Color.Pink;
            this.outputTextBox.Location = new System.Drawing.Point(12, 114);
            this.outputTextBox.MaxLength = 400;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(243, 20);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "Click the button or drag and drop it here";
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            this.outputTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.outputTextBox_DragDrop);
            this.outputTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.outputTextBox_DragEnter);
            // 
            // enckeyTextBox
            // 
            this.enckeyTextBox.BackColor = System.Drawing.Color.Pink;
            this.enckeyTextBox.Location = new System.Drawing.Point(12, 166);
            this.enckeyTextBox.MaxLength = 32;
            this.enckeyTextBox.Name = "enckeyTextBox";
            this.enckeyTextBox.Size = new System.Drawing.Size(331, 20);
            this.enckeyTextBox.TabIndex = 0;
            this.enckeyTextBox.TextChanged += new System.EventHandler(this.enckeyTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encryption key";
            // 
            // inputTextBox
            // 
            this.inputTextBox.AllowDrop = true;
            this.inputTextBox.BackColor = System.Drawing.Color.Pink;
            this.inputTextBox.Location = new System.Drawing.Point(12, 63);
            this.inputTextBox.MaxLength = 400;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(243, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Click the button or drag and drop it here";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputTextBox_DragDrop);
            this.inputTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputTextBox_DragEnter);
            // 
            // enckeyButton
            // 
            this.enckeyButton.Location = new System.Drawing.Point(12, 192);
            this.enckeyButton.Name = "enckeyButton";
            this.enckeyButton.Size = new System.Drawing.Size(331, 23);
            this.enckeyButton.TabIndex = 5;
            this.enckeyButton.Text = "Generate random";
            this.enckeyButton.UseVisualStyleBackColor = true;
            this.enckeyButton.Click += new System.EventHandler(this.enckeyButton_Click);
            // 
            // comkeyTextBox
            // 
            this.comkeyTextBox.BackColor = System.Drawing.Color.Pink;
            this.comkeyTextBox.Location = new System.Drawing.Point(12, 246);
            this.comkeyTextBox.MaxLength = 32;
            this.comkeyTextBox.Name = "comkeyTextBox";
            this.comkeyTextBox.Size = new System.Drawing.Size(331, 20);
            this.comkeyTextBox.TabIndex = 0;
            this.comkeyTextBox.TextChanged += new System.EventHandler(this.comkeyTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Common key";
            // 
            // comkeyCheckBut
            // 
            this.comkeyCheckBut.Location = new System.Drawing.Point(12, 272);
            this.comkeyCheckBut.Name = "comkeyCheckBut";
            this.comkeyCheckBut.Size = new System.Drawing.Size(160, 23);
            this.comkeyCheckBut.TabIndex = 5;
            this.comkeyCheckBut.Text = "Check for a saved one";
            this.comkeyCheckBut.UseVisualStyleBackColor = true;
            this.comkeyCheckBut.Click += new System.EventHandler(this.comkeyCheckBut_Click);
            // 
            // comkeySaveBut
            // 
            this.comkeySaveBut.Enabled = false;
            this.comkeySaveBut.Location = new System.Drawing.Point(183, 272);
            this.comkeySaveBut.Name = "comkeySaveBut";
            this.comkeySaveBut.Size = new System.Drawing.Size(160, 23);
            this.comkeySaveBut.TabIndex = 5;
            this.comkeySaveBut.Text = "Save key";
            this.comkeySaveBut.UseVisualStyleBackColor = true;
            this.comkeySaveBut.Click += new System.EventHandler(this.comkeySaveBut_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 356);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(329, 46);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.consoleTextBox.Location = new System.Drawing.Point(349, 12);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(393, 392);
            this.consoleTextBox.TabIndex = 7;
            this.consoleTextBox.Text = "-- NUSPacker.jar output ---";
            this.consoleTextBox.WordWrap = false;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.ForeColor = System.Drawing.Color.Red;
            this.inputLabel.Location = new System.Drawing.Point(228, 46);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(115, 13);
            this.inputLabel.TabIndex = 8;
            this.inputLabel.Text = "Directory doesn\'t exists";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(228, 97);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(115, 13);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Directory doesn\'t exists";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(305, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.Location = new System.Drawing.Point(305, 12);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(38, 23);
            this.expandButton.TabIndex = 9;
            this.expandButton.Text = ">>";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Image = global::NUSPackerPlus.Properties.Resources.help;
            this.helpButton.Location = new System.Drawing.Point(208, 10);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(31, 26);
            this.helpButton.TabIndex = 10;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // outputOpenButton
            // 
            this.outputOpenButton.Enabled = false;
            this.outputOpenButton.Image = global::NUSPackerPlus.Properties.Resources.folder;
            this.outputOpenButton.Location = new System.Drawing.Point(261, 113);
            this.outputOpenButton.Name = "outputOpenButton";
            this.outputOpenButton.Size = new System.Drawing.Size(38, 22);
            this.outputOpenButton.TabIndex = 4;
            this.outputOpenButton.UseVisualStyleBackColor = true;
            this.outputOpenButton.Click += new System.EventHandler(this.outputOpenButton_Click);
            // 
            // inputOpenButton
            // 
            this.inputOpenButton.AllowDrop = true;
            this.inputOpenButton.Enabled = false;
            this.inputOpenButton.Image = global::NUSPackerPlus.Properties.Resources.folder;
            this.inputOpenButton.Location = new System.Drawing.Point(261, 62);
            this.inputOpenButton.Name = "inputOpenButton";
            this.inputOpenButton.Size = new System.Drawing.Size(38, 22);
            this.inputOpenButton.TabIndex = 4;
            this.inputOpenButton.UseVisualStyleBackColor = true;
            this.inputOpenButton.Click += new System.EventHandler(this.inputOpenButton_Click);
            // 
            // loadsetButton
            // 
            this.loadsetButton.Location = new System.Drawing.Point(12, 314);
            this.loadsetButton.Name = "loadsetButton";
            this.loadsetButton.Size = new System.Drawing.Size(160, 23);
            this.loadsetButton.TabIndex = 11;
            this.loadsetButton.Text = "Load preset";
            this.loadsetButton.UseVisualStyleBackColor = true;
            this.loadsetButton.Click += new System.EventHandler(this.loadsetButton_Click);
            // 
            // savepreButton
            // 
            this.savepreButton.Enabled = false;
            this.savepreButton.Location = new System.Drawing.Point(183, 314);
            this.savepreButton.Name = "savepreButton";
            this.savepreButton.Size = new System.Drawing.Size(160, 23);
            this.savepreButton.TabIndex = 11;
            this.savepreButton.Text = "Save preset";
            this.savepreButton.UseVisualStyleBackColor = true;
            this.savepreButton.Click += new System.EventHandler(this.savepreButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // Form1
            // 
            this.AcceptButton = this.startButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 416);
            this.Controls.Add(this.savepreButton);
            this.Controls.Add(this.loadsetButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.comkeySaveBut);
            this.Controls.Add(this.comkeyCheckBut);
            this.Controls.Add(this.enckeyButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outputOpenButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputOpenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comkeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enckeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NUSPacker Plus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox enckeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputOpenButton;
        private System.Windows.Forms.Button outputOpenButton;
        private System.Windows.Forms.Button enckeyButton;
        private System.Windows.Forms.TextBox comkeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button comkeyCheckBut;
        private System.Windows.Forms.Button comkeySaveBut;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.FolderBrowserDialog inputBFD;
        private System.Windows.Forms.FolderBrowserDialog outputBFD;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button loadsetButton;
        private System.Windows.Forms.Button savepreButton;
        private System.Windows.Forms.Label label7;
    }
}

