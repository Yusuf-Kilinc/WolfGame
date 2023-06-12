using System.Collections.Generic;
using UnityEngine;

public class yemekler : MonoBehaviour
{
    charactherMovve cm;
    public List<GameObject> yemek;    
    public Transform zemin;
   

    void Update()
    {
        for (int i = 0; i < 1000; i++)
        {

        }
        Instantiate(yemek[Random.Range(0, yemek.Count)], zemin.transform);
    }
}
