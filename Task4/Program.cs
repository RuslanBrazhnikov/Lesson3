string text = "- Я думаюб - сказал князь, улыбаясьб - что "
                + "ежели бы вас послали виесто нашего милого Винцегордцйу,"
                + "вы бы взяли приступом согласие пруиусского короля."
                + "Вы так красноречивыф. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, 'к', 'К');
Console.Write(newText);
