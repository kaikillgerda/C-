//На палиндром

int Reverse(int number)
{
    int answer = 0;
    while(number > 0)
    {
        answer = answer * 10 + number %10;
        number = number / 10;
    }
    return answer;
}

bool CheckPalindrome(int number)
{
    return Reverse(number) == number;
}
