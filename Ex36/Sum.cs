class Method3
{
    static public int q = 0;
    public int[] Sum(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (i%2==0)
            {
                q = q + array[i];
            }
        }

        return(array);
    }
}