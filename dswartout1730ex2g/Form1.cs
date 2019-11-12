using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dswartout1730ex2g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(inputBox1a.Text);

            // 1b) Separate 'if' statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(inputBox1a.Text);

            // 1c) if elseif
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(inputBox1a.Text);

            // 1d) Nested if-else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(inputBox1a.Text);

            // 1e) Switch w/ Default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(inputBox1a.Text);

            // 1f) Separate 'if' statements, default
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(inputBox1a.Text);

            // 1g) if elseif, default
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(inputBox1a.Text);

            // 1h) Nested if-else, default
            resultNestedIfElseDefault01TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(inputBox1a.Text);

            // 2a) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(inputBox2a.Text);

            // 2b) Separate 'if' statements
            resultIf02TextBox.Text = Ex2gCalculations.If02(inputBox2a.Text);

            // 2c) if elseif
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(inputBox2a.Text);

            // 2d) Nested if-else
            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElse02(inputBox2a.Text);
        }
    }
}
