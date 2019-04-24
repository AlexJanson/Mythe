using UnityEngine;

public static class Generator
{

    public static Vector3[] ShuffleArray(Vector3[] array)
    {

            Vector3[] shuffledArray = array;

            for (int i = 0; i < array.Length; i++)
            {

                int rndmIndex = Random.Range(0, array.Length);

                Vector3 savedValue = shuffledArray[i];

                shuffledArray[i] = shuffledArray[rndmIndex];

                shuffledArray[rndmIndex] = savedValue;

            }

        return shuffledArray;

    }

}
