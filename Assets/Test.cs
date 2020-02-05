using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 9, 7, 2, 5, 8 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length-1; 0 <= i; i--)
        {
            Debug.Log(array [i]);
        }
    }
}








