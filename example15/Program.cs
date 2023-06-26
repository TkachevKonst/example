Console.Clear();
string text1 = "Ах, простите, что я в пылу нашей ученой беседы забыл представиться. Профессор черной магии Воланд."
+ "Приглашен в Москву для консультации. Здесь в государственной библиотеке обнаружены подлинные рукописи чернокнижника Герберта Аврилакского,"
+ "десятого века. Требуется, чтобы я их разобрал. Я единственный специалист в мире. Тш-ш! Имейте в виду: Иисус — существовал.";
Console.WriteLine(text1);
string Replace(string text, char Oldsim, char Newsim)
{
    string rezult = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == Oldsim)
        {
            rezult = rezult + Newsim;
        }
        else
        {
            rezult = rezult + text[i];
        }
    }
    return rezult;
}
string newtext = Replace(text1, ' ', '_');
Console.WriteLine(newtext);
string newtext1 = Replace(newtext, 'п', 'П');
Console.WriteLine(newtext1);
string newtext2 = Replace(newtext1, 'о', 'О');
Console.WriteLine(newtext2);