using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int count = 0;

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Strands must be equal!");
        }

        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                count++;
        }

        return count;
    }
}
