class Method1
{
    Random rnd = new Random();
    public double[] Rand(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
             array[i] = Math.Round(rnd.NextDouble() * 100, 2);
        }

        return(array);
    }
}