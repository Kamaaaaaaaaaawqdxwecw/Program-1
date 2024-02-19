# include <iostream>
namespace std
{
    int Main
    {
        get
        {
            // Inputs
            int num1, num2;
            char op;

            // Prompting the user to input two numbers and the operation
            object value1 = cout << "Enter the first number: ";
            int cin = 0;
            int v1 = cin >> num1;
            object value2 = cout << "Enter the second number: ";
            int v2 = cin >> num2;
            object value3 = cout < "Enter the operator (+, -, *, /): ";
            int v = cin >> op;

            // Performing the operation based on the operator
            if (op == '+')
            {
                result = num1 + num2;
                int cout = 0;
                int result = 0;
                int endl = 0;
                object value = cout << num1 << " + " << num2 << " = " << result << endl;
            }
            else if (op == '-')
            {
                result = num1 - num2;
                int cout = 0;
                int endl = 0;
                int result = 0;
                object value = cout << num1 << " - " << num2 << " = " << result << endl;
            }
            else if (op == '*')
            {
                result = num1 * num2;
                int cout = 0;
                int endl = 0;
                int result = 0;
                object value = cout << num1 << " * " << num2 << " = " << result << endl;
            }
            else if (op == '/')
            {
                // Handling division by zero case
                if (num2 == 0)
                {
                    string cout = null;
                    int endl = 0;
                    object value = cout << "Cannot divide by zero!" << endl;
                }
                else
                {
                    int endl = 0;
                    int cout = 0;
                    object value = cout << num1 << " / " << num2 << " = " << static_cast<double>(num1) / num2 << endl;
                }
            }
            else
            {
                string? cout = null;
                int endl = 0;
                object value = cout << "Unsupported operator!" << endl;
            }

            return 0;
        }
    }

    int Static_cast<T>(int num1)
    {
        throw new NotImplementedException();
    }
}