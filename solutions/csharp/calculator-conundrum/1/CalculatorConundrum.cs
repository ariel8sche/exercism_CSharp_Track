public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            switch (operation)
            {
                case "+":
                    return OperationDescriptor(operand1, operand2, operation) + SimpleOperation.Addition(operand1, operand2).ToString();
                case "*":
                    return OperationDescriptor(operand1, operand2, operation) + SimpleOperation.Multiplication(operand1, operand2).ToString();
                case "/":
                    return OperationDescriptor(operand1, operand2, operation) + SimpleOperation.Division(operand1, operand2).ToString();
                default:
                    if (operation is null)
                    {
                        throw new ArgumentNullException();
                    }
                    else if (operation == "")
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    
            }
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
    }

    public static string OperationDescriptor(int operand1, int operand2, string? operation)
    {
        return operand1.ToString() + $" {operation} " + operand2.ToString() + " = ";
    }
}
