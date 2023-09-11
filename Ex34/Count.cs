class Method3
{
    static public int q = 0;
    public int[] Count(int[] array)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                q = q + 1;
            }         
        }       
        return array;       
    }
}