namespace WeightMeter
{
    public partial class Form1 : Form
    {
        private float gramms;
        private float call;
        private const float k = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            gramms = convertToFloat(grammsTextBox.Text);
            call = convertToFloat(callTextBox.Text);

            resultTextBox.Text = (gramms * call / k).ToString();
        }

        private float convertToFloat(string value)
        {
            float result;
            if (float.TryParse(value, out result)) 
            { 
                return result;
            }

            return float.NaN;
        }
    }
}