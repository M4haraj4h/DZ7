class Method2
{
    public double[] Write(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) {
                Console.Write("; ");
            }
        }

        return array;
    }
}