using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Light _mainLight;   

private void Update() 
{
        if (Input.GetKeyUp(KeyCode.L))
        {
            _mainLight.enabled = !_mainLight.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Down");
        }
}
}