






using LineComprasionProblems;

class Program
{
    public static void main(String[] args)
    {

        String str1 = "Grand Theft Auto";
        String str2 = "Assassin Creed";
        String str3 = "Call of Duty";
        String str4 = "Need for Speed";
        String str5 = "Grand Theft Auto";

        Console.WriteLine(str1.CompareTo(str2));
        // Since 'A' is greater than 'G' by 6 characters, so it will return 6

        Console.WriteLine(str2.CompareTo(str3));
        // Since 'C' is smaller than 'A' by 2 characters, so it will return -2

        Console.WriteLine(str3.CompareTo(str4));
        //Since 'N' is smaller than 'C' by 11 characters, so it will return -11

        Console.WriteLine(str4.CompareTo(str1));
        //Since 'G' is Greater than 'N' by 7 characters, so it will return 7

        Console.WriteLine(str1.CompareTo(str5));
        //Strings are equal

    }

}