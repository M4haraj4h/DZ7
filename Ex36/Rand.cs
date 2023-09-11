class Method1
{
    Random rnd = new Random();
    public int[] Rand(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100);
        }

        return(array);
    }
}