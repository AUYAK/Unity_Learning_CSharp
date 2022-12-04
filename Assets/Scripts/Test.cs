using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class Test : MonoBehaviour
{
    [NonSerialized]
    public int _num = 5;
    [SerializeField]
    private string Somestr = "Bla";
    
    public int [] numbers = new int[3];
    public List<string> words = new List<string>(); 
    void Start()
    {
      numbers[1] = 2;
      words.Add("asd");
      Debug.Log("Hello there. Num:" + _num);
    }

    void Update() 
    {
    
    }
}
