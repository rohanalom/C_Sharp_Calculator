namespace Calculator
{
    public partial class Calculator : Form
    {
        private double _num1, _num2;
        private char _operator;
        public Calculator()
        {
            InitializeComponent();
            _num1 = _num2 = 0.0;
            _operator = '\0';
        }

        private void btn_digit_click(object sender, EventArgs e)
        {
            Button _btn = sender as Button;
            txt_display.Text += _btn.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void btn_operator_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            _num1 = Convert.ToDouble(txt_display.Text);
            _operator = Convert.ToChar(btn.Text);
            txt_display.Clear();

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_display.Clear();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            double _ans = 0.0;
            _num2 = Convert.ToDouble(txt_display.Text);
            switch (_operator)
            {
                case '+':
                    _ans = _num1 + _num2;
                    break;
                case '-':
                    _ans = _num1 - _num2;
                    break;
                case '*':
                    _ans = _num1 * _num2;
                    break;
                case '/':
                    _ans = _num1 / _num2;
                    break;
            }
            txt_display.Text = Convert.ToString(_ans);

        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (txt_display.Text.Length > 0)
            {
                txt_display.Text = txt_display.Text.Substring(0, txt_display.Text.Length - 1);
            }
        }

        private void CustomizeSpecialButtons()
        {
            btn_equals.FlatStyle = FlatStyle.Flat;
            btn_equals.BackColor = Color.OrangeRed;
            btn_equals.ForeColor = Color.White;
            btn_equals.FlatAppearance.MouseOverBackColor = Color.Red;


            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.BackColor = Color.Red;
            btn_clear.ForeColor = Color.White;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.DarkRed;

            btn_backspace.FlatStyle = FlatStyle.Flat;
            btn_backspace.BackColor = Color.Red;
            btn_backspace.ForeColor = Color.White;
            btn_backspace.FlatAppearance.MouseOverBackColor = Color.DarkRed;
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            CustomizeSpecialButtons();
            foreach (Control c in this.Controls)
            {
                if(c is Button btn)
                {
                    if (btn == btn_equals || btn == btn_clear || btn == btn_backspace)
                        continue;
                    if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.LightBlue;  // Give a distinct color to operators
                        btn.ForeColor = Color.Black;
                        btn.Font = new Font("Arial", 14, FontStyle.Bold);
                        btn.FlatAppearance.MouseOverBackColor = Color.SkyBlue; // Hover effect
                    }
                    else
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 1; // Thin border
                        btn.BackColor = Color.LightGray; // Light gray background
                        btn.ForeColor = Color.Black; // Black text color
                        btn.Font = new Font("Arial", 14, FontStyle.Bold); // Set font
                        btn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                    }

                }
            }

        }
        


    }
}
