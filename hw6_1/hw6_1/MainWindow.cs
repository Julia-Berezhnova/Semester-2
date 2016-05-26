using System;
using Gtk;
using hw6_1;

public partial class MainWindow: Gtk.Window
{
    public MainWindow()
        : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonOperationClick(object sender, EventArgs e)
    {
        var button = (Button)sender;
        if (input.Text == "")
        {
            input.Text = "0" + button.Label;
            return;
        }
        char lastSymbol = input.Text[input.Text.Length - 1];
        char firstSymbol = input.Text[0];
        if (input.Text[0] == 'd') //case 'division by zero is undefined'
        {
            input.Text = "";
        }
        else if (isOperation(lastSymbol) && input.Text.Length > 1) //cases like '7-'
        {
            input.Text = input.Text.Remove(input.Text.Length - 1); 
        }
        else 
        {
            int result;
            try
            {
                result = Calculator.Calculate(input.Text); //cases like '3+2', '-3+2', '3', '-3'  (OK cases)
            }
            catch (DivideByZeroException)
            {
                input.Text = "division by zero is undefined";
                return;
            }
            input.Text = Convert.ToString(result);
        }
        if (button.Label != "=")
        {
            input.Text += button.Label;
        }
    }

    protected void OnButtonClearClick(object sender, EventArgs e)
    {
        input.Text = "";
    }

    protected void OnButtonNumberClick(object sender, EventArgs e)
    {
        var button = (Button)sender;
        input.Text += button.Label;
    }

    private bool isOperation(char symbol) => (symbol == '/' || symbol == '*' || symbol == '-' || symbol == '+' || symbol == '=');
}
