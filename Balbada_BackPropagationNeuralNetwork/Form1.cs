using Backprop;

/*
 JOHN MARC G. BALBADA - BSCS - 3 - F1         INTELLIGENT SYSTEMS 1
 BACK PROPAGATION NEURAL NETWORK USING 'AND' GATE
        A   B   C   D   Result (A AND B AND C AND D)
        0	0	0	0	0
        0	0	0	1	0
        0	0	1	0	0
        0	0	1	1	0
        0	1	0	0	0
        0	1	0	1	0
        0	1	1	0	0
        0	1	1	1	0
        1	0	0	0	0
        1	0	0	1	0
        1	0	1	0	0
        1	0	1	1	0
        1	1	0	0	0
        1	1	0	1	0
        1	1	1	0	0
        1	1	1	1	1
 */

namespace Balbada_BackPropagationNeuralNetwork
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        private int learning;
        public Form1()
        {
            InitializeComponent();
        }

        private void neuralNetworkInitializeButton_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 16, 1);
            neuralNetworkInitializeButton.Enabled = false;
            statusText.Text = "Initialized!";
            learnButton.Enabled = true;
            inputAZeroButton.Enabled = true;
            inputAOneButton.Enabled = true;
            inputBZeroButton.Enabled = true;
            inputBOneButton.Enabled = true;
            inputCZeroButton.Enabled = true;
            inputCOneButton.Enabled = true;
            inputDZeroButton.Enabled = true;
            inputDOneButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            statusText.Text = "Learning " + learning + " times!";
            Console.WriteLine("LEARNING = " + learning);
            for (int i = 0; i < 100; i++)
            {
                // CASE 0000
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0001
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0010
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0011
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0100
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0101
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0110
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 0111
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1000
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1001
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1010
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1011
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1100
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1101
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1110
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // CASE 1111
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
                learning++;
            }
        }

        private void inputAZeroButton_Click(object sender, EventArgs e)
        {
            inputAResult.Text = 0 + "";
            runNeuron();
        }

        private void inputAOneButton_Click(object sender, EventArgs e)
        {
            inputAResult.Text = 1 + "";
            runNeuron();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            learning = 0;
        }

        private void inputBZeroButton_Click(object sender, EventArgs e)
        {
            inputBResult.Text = 0 + "";
            runNeuron();
        }

        private void inputBOneButton_Click(object sender, EventArgs e)
        {
            inputBResult.Text = 1 + "";
            runNeuron();
        }

        private void inputCZeroButton_Click(object sender, EventArgs e)
        {
            inputCResult.Text = 0 + "";
            runNeuron();
        }

        private void inputCOneButton_Click(object sender, EventArgs e)
        {
            inputCResult.Text = 1 + "";
            runNeuron();
        }

        private void inputDZeroButton_Click(object sender, EventArgs e)
        {
            inputDResult.Text = 0 + "";
            runNeuron();
        }

        private void inputDOneButton_Click(object sender, EventArgs e)
        {
            inputDResult.Text = 1 + "";
            runNeuron();
        }

        public void runNeuron()
        {
            statusText.Text = "";
            nn.setInputs(0, Convert.ToDouble(inputAResult.Text));
            nn.setInputs(1, Convert.ToDouble(inputBResult.Text));
            nn.setInputs(2, Convert.ToDouble(inputCResult.Text));
            nn.setInputs(3, Convert.ToDouble(inputDResult.Text));
            nn.run();

            double rawOutput = (double)nn.getOuputData(0);
            double binaryOutput = (rawOutput < 0.5) ? 0 : 1;

            actualResultText.Text = rawOutput.ToString();
            resultLabel.Text = binaryOutput.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            learning = 0;
            statusText.Text = "Reset!";
            learnButton.Enabled = false;
            inputAZeroButton.Enabled = false;
            inputAOneButton.Enabled = false;
            inputBZeroButton.Enabled = false;
            inputBOneButton.Enabled = false;
            inputCZeroButton.Enabled = false;
            inputCOneButton.Enabled = false;
            inputDZeroButton.Enabled = false;
            inputDOneButton.Enabled = false;
            neuralNetworkInitializeButton.Enabled = true;
            resetButton.Enabled = false;
            actualResultText.Text = "";
            resultLabel.Text = "0";
            inputAResult.Text = "0";
            inputBResult.Text = "0";
            inputCResult.Text = "0";
            inputDResult.Text = "0";
        }
    }
}
