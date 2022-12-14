






using LineComprasionProblems;

class Program
{
    public static void main(String[] args)
    {

        // Get some Strings to compare
        String s1 = "A";
        String s2 = "A";
        String s3 = "A";
        String s4 = new String("A");

        // Compare s1 and s2
        // It should return true as they both
        // refer to same object in memory
        Console.WriteLine(s1 + " == " + s2
                         + ": " + (s1 == s2));

        // Compare s1 and s3
        // It should return true as they both
        // refer to same object in memory
        Console.WriteLine(s1 + " == " + s3
                         + ": " + (s1 == s3));

        // Compare s2 and s3
        // It should return true as they both
        // refer to same object in memory
        Console.WriteLine(s2 + " == " + s3
                         + ": " + (s2 == s3));

        // Compare s1 and s4
        // It should return false as they both
        // refer to different object in memory
        Console.WriteLine(s1 + " == " + s4
                         + ": " + (s1 == s4));
    }

}