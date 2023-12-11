namespace Balbada_BackPropagationNeuralNetwork
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
            neuralNetworkInitializeButton = new Button();
            learnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            resultLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label16 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            inputAZeroButton = new Button();
            inputAOneButton = new Button();
            inputAResult = new Label();
            inputBResult = new Label();
            inputCResult = new Label();
            inputDResult = new Label();
            inputBOneButton = new Button();
            inputBZeroButton = new Button();
            inputCOneButton = new Button();
            inputCZeroButton = new Button();
            inputDOneButton = new Button();
            inputDZeroButton = new Button();
            label25 = new Label();
            actualResultText = new Label();
            statusText = new Label();
            resetButton = new Button();
            SuspendLayout();
            // 
            // neuralNetworkInitializeButton
            // 
            neuralNetworkInitializeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            neuralNetworkInitializeButton.Location = new Point(12, 12);
            neuralNetworkInitializeButton.Name = "neuralNetworkInitializeButton";
            neuralNetworkInitializeButton.Size = new Size(175, 25);
            neuralNetworkInitializeButton.TabIndex = 0;
            neuralNetworkInitializeButton.Text = "Initalize Neural Network";
            neuralNetworkInitializeButton.UseVisualStyleBackColor = true;
            neuralNetworkInitializeButton.Click += neuralNetworkInitializeButton_Click;
            // 
            // learnButton
            // 
            learnButton.Enabled = false;
            learnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            learnButton.Location = new Point(201, 12);
            learnButton.Name = "learnButton";
            learnButton.Size = new Size(113, 25);
            learnButton.TabIndex = 1;
            learnButton.Text = "Learn";
            learnButton.UseVisualStyleBackColor = true;
            learnButton.Click += learnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(147, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Input A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(149, 153);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Input B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(148, 249);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "Input C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(148, 338);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Input D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(233, 87);
            label5.Name = "label5";
            label5.Size = new Size(257, 15);
            label5.TabIndex = 12;
            label5.Text = "--------------------------------------------------";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.MediumSeaGreen;
            resultLabel.Location = new Point(470, 197);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(33, 37);
            resultLabel.TabIndex = 13;
            resultLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(233, 182);
            label6.Name = "label6";
            label6.Size = new Size(257, 15);
            label6.TabIndex = 14;
            label6.Text = "--------------------------------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(233, 275);
            label7.Name = "label7";
            label7.Size = new Size(257, 15);
            label7.TabIndex = 15;
            label7.Text = "--------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(233, 361);
            label8.Name = "label8";
            label8.Size = new Size(257, 15);
            label8.TabIndex = 16;
            label8.Text = "--------------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(480, 96);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 17;
            label9.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(480, 109);
            label10.Name = "label10";
            label10.Size = new Size(10, 15);
            label10.TabIndex = 18;
            label10.Text = "|";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(480, 124);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 19;
            label11.Text = "|";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(480, 139);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 20;
            label12.Text = "|";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(480, 154);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 21;
            label13.Text = "|";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(480, 169);
            label14.Name = "label14";
            label14.Size = new Size(10, 15);
            label14.TabIndex = 22;
            label14.Text = "|";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(480, 183);
            label15.Name = "label15";
            label15.Size = new Size(10, 15);
            label15.TabIndex = 23;
            label15.Text = "|";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(480, 356);
            label17.Name = "label17";
            label17.Size = new Size(10, 15);
            label17.TabIndex = 28;
            label17.Text = "|";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(480, 341);
            label18.Name = "label18";
            label18.Size = new Size(10, 15);
            label18.TabIndex = 27;
            label18.Text = "|";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(480, 326);
            label19.Name = "label19";
            label19.Size = new Size(10, 15);
            label19.TabIndex = 26;
            label19.Text = "|";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F);
            label20.Location = new Point(480, 313);
            label20.Name = "label20";
            label20.Size = new Size(10, 15);
            label20.TabIndex = 25;
            label20.Text = "|";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(480, 276);
            label16.Name = "label16";
            label16.Size = new Size(10, 15);
            label16.TabIndex = 32;
            label16.Text = "|";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F);
            label21.Location = new Point(480, 261);
            label21.Name = "label21";
            label21.Size = new Size(10, 15);
            label21.TabIndex = 31;
            label21.Text = "|";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F);
            label22.Location = new Point(480, 246);
            label22.Name = "label22";
            label22.Size = new Size(10, 15);
            label22.TabIndex = 30;
            label22.Text = "|";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F);
            label23.Location = new Point(480, 233);
            label23.Name = "label23";
            label23.Size = new Size(10, 15);
            label23.TabIndex = 29;
            label23.Text = "|";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F);
            label24.Location = new Point(480, 294);
            label24.Name = "label24";
            label24.Size = new Size(10, 15);
            label24.TabIndex = 33;
            label24.Text = "|";
            // 
            // inputAZeroButton
            // 
            inputAZeroButton.Enabled = false;
            inputAZeroButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputAZeroButton.Location = new Point(27, 74);
            inputAZeroButton.Name = "inputAZeroButton";
            inputAZeroButton.Size = new Size(45, 43);
            inputAZeroButton.TabIndex = 34;
            inputAZeroButton.Text = "0";
            inputAZeroButton.UseVisualStyleBackColor = true;
            inputAZeroButton.Click += inputAZeroButton_Click;
            // 
            // inputAOneButton
            // 
            inputAOneButton.Enabled = false;
            inputAOneButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputAOneButton.Location = new Point(78, 74);
            inputAOneButton.Name = "inputAOneButton";
            inputAOneButton.Size = new Size(45, 43);
            inputAOneButton.TabIndex = 35;
            inputAOneButton.Text = "1";
            inputAOneButton.UseVisualStyleBackColor = true;
            inputAOneButton.Click += inputAOneButton_Click;
            // 
            // inputAResult
            // 
            inputAResult.AutoSize = true;
            inputAResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputAResult.ForeColor = Color.Teal;
            inputAResult.Location = new Point(149, 72);
            inputAResult.Name = "inputAResult";
            inputAResult.Size = new Size(38, 45);
            inputAResult.TabIndex = 36;
            inputAResult.Text = "0";
            // 
            // inputBResult
            // 
            inputBResult.AutoSize = true;
            inputBResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBResult.ForeColor = Color.Teal;
            inputBResult.Location = new Point(151, 169);
            inputBResult.Name = "inputBResult";
            inputBResult.Size = new Size(38, 45);
            inputBResult.TabIndex = 37;
            inputBResult.Text = "0";
            // 
            // inputCResult
            // 
            inputCResult.AutoSize = true;
            inputCResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputCResult.ForeColor = Color.Teal;
            inputCResult.Location = new Point(152, 264);
            inputCResult.Name = "inputCResult";
            inputCResult.Size = new Size(38, 45);
            inputCResult.TabIndex = 38;
            inputCResult.Text = "0";
            // 
            // inputDResult
            // 
            inputDResult.AutoSize = true;
            inputDResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputDResult.ForeColor = Color.Teal;
            inputDResult.Location = new Point(153, 356);
            inputDResult.Name = "inputDResult";
            inputDResult.Size = new Size(38, 45);
            inputDResult.TabIndex = 39;
            inputDResult.Text = "0";
            // 
            // inputBOneButton
            // 
            inputBOneButton.Enabled = false;
            inputBOneButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBOneButton.Location = new Point(78, 171);
            inputBOneButton.Name = "inputBOneButton";
            inputBOneButton.Size = new Size(45, 43);
            inputBOneButton.TabIndex = 41;
            inputBOneButton.Text = "1";
            inputBOneButton.UseVisualStyleBackColor = true;
            inputBOneButton.Click += inputBOneButton_Click;
            // 
            // inputBZeroButton
            // 
            inputBZeroButton.Enabled = false;
            inputBZeroButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBZeroButton.Location = new Point(27, 171);
            inputBZeroButton.Name = "inputBZeroButton";
            inputBZeroButton.Size = new Size(45, 43);
            inputBZeroButton.TabIndex = 40;
            inputBZeroButton.Text = "0";
            inputBZeroButton.UseVisualStyleBackColor = true;
            inputBZeroButton.Click += inputBZeroButton_Click;
            // 
            // inputCOneButton
            // 
            inputCOneButton.Enabled = false;
            inputCOneButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputCOneButton.Location = new Point(78, 266);
            inputCOneButton.Name = "inputCOneButton";
            inputCOneButton.Size = new Size(45, 43);
            inputCOneButton.TabIndex = 43;
            inputCOneButton.Text = "1";
            inputCOneButton.UseVisualStyleBackColor = true;
            inputCOneButton.Click += inputCOneButton_Click;
            // 
            // inputCZeroButton
            // 
            inputCZeroButton.Enabled = false;
            inputCZeroButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputCZeroButton.Location = new Point(27, 266);
            inputCZeroButton.Name = "inputCZeroButton";
            inputCZeroButton.Size = new Size(45, 43);
            inputCZeroButton.TabIndex = 42;
            inputCZeroButton.Text = "0";
            inputCZeroButton.UseVisualStyleBackColor = true;
            inputCZeroButton.Click += inputCZeroButton_Click;
            // 
            // inputDOneButton
            // 
            inputDOneButton.Enabled = false;
            inputDOneButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputDOneButton.Location = new Point(78, 356);
            inputDOneButton.Name = "inputDOneButton";
            inputDOneButton.Size = new Size(45, 43);
            inputDOneButton.TabIndex = 45;
            inputDOneButton.Text = "1";
            inputDOneButton.UseVisualStyleBackColor = true;
            inputDOneButton.Click += inputDOneButton_Click;
            // 
            // inputDZeroButton
            // 
            inputDZeroButton.Enabled = false;
            inputDZeroButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputDZeroButton.Location = new Point(27, 356);
            inputDZeroButton.Name = "inputDZeroButton";
            inputDZeroButton.Size = new Size(45, 43);
            inputDZeroButton.TabIndex = 44;
            inputDZeroButton.Text = "0";
            inputDZeroButton.UseVisualStyleBackColor = true;
            inputDZeroButton.Click += inputDZeroButton_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F);
            label25.Location = new Point(134, 426);
            label25.Name = "label25";
            label25.Size = new Size(79, 15);
            label25.TabIndex = 46;
            label25.Text = "Actual Result:";
            // 
            // actualResultText
            // 
            actualResultText.AutoSize = true;
            actualResultText.Font = new Font("Segoe UI", 9F);
            actualResultText.Location = new Point(215, 426);
            actualResultText.Name = "actualResultText";
            actualResultText.Size = new Size(0, 15);
            actualResultText.TabIndex = 47;
            // 
            // statusText
            // 
            statusText.Font = new Font("Segoe UI", 9F);
            statusText.ForeColor = Color.Green;
            statusText.Location = new Point(337, 17);
            statusText.Name = "statusText";
            statusText.Size = new Size(222, 15);
            statusText.TabIndex = 48;
            // 
            // resetButton
            // 
            resetButton.Enabled = false;
            resetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resetButton.Location = new Point(522, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(62, 25);
            resetButton.TabIndex = 49;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 450);
            Controls.Add(resetButton);
            Controls.Add(statusText);
            Controls.Add(actualResultText);
            Controls.Add(label25);
            Controls.Add(inputDOneButton);
            Controls.Add(inputDZeroButton);
            Controls.Add(inputCOneButton);
            Controls.Add(inputCZeroButton);
            Controls.Add(inputBOneButton);
            Controls.Add(inputBZeroButton);
            Controls.Add(inputDResult);
            Controls.Add(inputCResult);
            Controls.Add(inputBResult);
            Controls.Add(inputAResult);
            Controls.Add(inputAOneButton);
            Controls.Add(inputAZeroButton);
            Controls.Add(label24);
            Controls.Add(label16);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(resultLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(learnButton);
            Controls.Add(neuralNetworkInitializeButton);
            Name = "Form1";
            Text = "Balbada_BackPropagationNeuralNetwork";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button neuralNetworkInitializeButton;
        private Button learnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label resultLabel;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label16;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button inputAZeroButton;
        private Button inputAOneButton;
        private Label inputAResult;
        private Label inputBResult;
        private Label inputCResult;
        private Label inputDResult;
        private Button inputBOneButton;
        private Button inputBZeroButton;
        private Button inputCOneButton;
        private Button inputCZeroButton;
        private Button inputDOneButton;
        private Button inputDZeroButton;
        private Label label25;
        private Label actualResultText;
        private Label statusText;
        private Button resetButton;
    }
}
