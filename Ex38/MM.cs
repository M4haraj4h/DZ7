class Method3
{
    static public double diff = 0;
    public double[] MM(double[] array)
    {
        double max = 0;
        double min = array[0];
        

        for (int i = 0; i < (array.Length); i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
            if (array[i]<min)
            {
                min = array[i];
            }
        }

        diff = max - min;
        diff = Math.Round(diff, 2);

        return array;
    }
}