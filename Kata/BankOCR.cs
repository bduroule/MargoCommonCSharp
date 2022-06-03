namespace Kata;
public class BankOCR
{
    const int ACCOUNT_NUMBER_SIZE = 27;

    public string DefineStatusCode(string number)
    {
        if (number.Contains('?'))
            return number + ' ' + "ILL";
        if (!IsValidAccountNumber(number))
            return number + ' ' + "ERR";
        return number;
    }

    public char SortNumber(string[] A, int start)
    {
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == ' '&& A[1][start + 2] == '|' &&
            A[2][start] == '|' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '0';
        if (A[0][start] == ' ' && A[0][start + 1] == ' '&& A[0][start + 2] == ' ' &&
            A[1][start] == ' ' && A[1][start + 1] == ' '&& A[1][start + 2] == '|' &&
            A[2][start] == ' ' && A[2][start + 1] == ' '&& A[2][start + 2] == '|')
                return '1';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == ' ' && A[1][start + 1] == '_'&& A[1][start + 2] == '|' &&
            A[2][start] == '|' && A[2][start + 1] == '_'&& A[2][start + 2] == ' ')
                return '2';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == ' ' && A[1][start + 1] == '_'&& A[1][start + 2] == '|' &&
            A[2][start] == ' ' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '3';
        if (A[0][start] == ' ' && A[0][start + 1] == ' '&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == '_'&& A[1][start + 2] == '|' &&
            A[2][start] == ' ' && A[2][start + 1] == ' '&& A[2][start + 2] == '|')
            return '4';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == '_'&& A[1][start + 2] == ' ' &&
            A[2][start] == ' ' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '5';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == '_'&& A[1][start + 2] == ' ' &&
            A[2][start] == '|' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '6';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == ' ' && A[1][start + 1] == ' '&& A[1][start + 2] == '|' &&
            A[2][start] == ' ' && A[2][start + 1] == ' '&& A[2][start + 2] == '|')
            return '7';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == '_'&& A[1][start + 2] == '|' &&
            A[2][start] == '|' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '8';
        if (A[0][start] == ' ' && A[0][start + 1] == '_'&& A[0][start + 2] == ' ' &&
            A[1][start] == '|' && A[1][start + 1] == '_'&& A[1][start + 2] == '|' &&
            A[2][start] == ' ' && A[2][start + 1] == '_'&& A[2][start + 2] == '|')
            return '9';
        return '?';
    }
    public string ConvertFileToNumber(string[] fileAccountNumber)
    {
        if (fileAccountNumber.Length != 3 || fileAccountNumber[0].Length != ACCOUNT_NUMBER_SIZE ||
        fileAccountNumber[1].Length != ACCOUNT_NUMBER_SIZE || fileAccountNumber[2].Length != ACCOUNT_NUMBER_SIZE)
            return "";
        char[] numbers = new char[9];

        for (int i = 0; i < ACCOUNT_NUMBER_SIZE; i++) {
            if (i % 3 == 0)
                numbers[i / 3] = SortNumber(fileAccountNumber, i);
        }
        return new string(numbers);
    }

    public bool IsValidAccountNumber(string number)
    {
        return CalculateValidAccountNum(number) % 11 == 0;
    }

    public int CalculateValidAccountNum(string number)
    {
        int size = number.Length;
        int result = 0;

        for (int i = 0; i < number.Length; i++) {
            result += size * (int)Char.GetNumericValue(number[i]);
            size--;
        }
        return result;
    }
}
