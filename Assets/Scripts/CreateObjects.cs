using UnityEngine;
using System;
using System.Collections;

public class CreateObjects : MonoBehaviour
{
    public GameObject[] obj;
    private void Awake() {
    Numbers numbers = new Numbers();
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }
    }
    private void Update() {
        // Invoke("Сreate3DObjects",3f);
        if (Input.GetKeyUp(KeyCode.U)){
        StartCoroutine(Create3DObjects(3f));
        }
    }
    private IEnumerator Create3DObjects(float time) {
        int i = 0;
        while(1==1){
        i++;
        // GameObject newObject = Instantiate(obj,new Vector3(0,5,0), Quaternion.Euler(12f,-15f,40f)) as GameObject;
        // newObject.GetComponent<Transform>.position = new Vector3(5,5,0);
        
        GameObject _temp = Instantiate (obj[UnityEngine.Random.Range(0,obj.Length)],new Vector3(RandomNumber(),RandomNumber(), RandomNumber()),Quaternion.Euler(12f,-15f,40f));
        _temp.name = "Auto-created"+i;
        yield return new WaitForSeconds(time);

        if (i>=5) break;
        }
    }
    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0,10);
    }
    
}

class Numbers
{
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return i * i;
        }
    }
}
