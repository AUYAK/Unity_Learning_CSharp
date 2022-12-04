using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class Test : MonoBehaviour
{
    [NonSerialized]
    public int _num = 5;
      
    public int [] numbers = new int[3];
    public List<string> words = new List<string>(); 
    
    private void Awake() {
      Debug.Log("Awake");
    }
    void Start()
    {
      numbers[1] = 2;
      words.Add("asd");
      Debug.Log("Hello there. Num:" + _num);
    }

    void Update() 
    {
      Debug.Log("Update");
    }

    private void LateUpdate() 
    {
      Debug.Log("LateUpdate");
    }

    private void FixedUpdate() 
    {
      Debug.Log("FixedUpdate");
    }
    private void OnDestroy() {
      Debug.Log("OnDestroy");
    }

    private void OnEnable() {
      Debug.Log("OnEnable");
    }
}
