using System;

namespace ClassLibraryLesson5
{
    public class ArrayWorker
    {

        public int[] Invert(ref int[] array)
        {
            int[] newArray = new int[array.Length];

            int count = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[count];
                count--;
            }
            return array = newArray;
        }

        public int[] MassiveChanger(ref int[] source, int index, int newValue)
        {
            int[] newSource = new int[source.Length + 1];

            for (int i = 0; i < newSource.Length; i++)
            {
                if (i < index)
                {
                    newSource[i] = source[i];
                }
                else if (i == index)
                {
                    newSource[i] = newValue;
                }
                else
                {
                    newSource[i] = source[i - 1];
                }
            }
            return source = newSource;
        }
    }
   
}
