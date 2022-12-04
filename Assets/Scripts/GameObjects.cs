using UnityEngine;

public class GameObjects : MonoBehaviour
{
    // public GameObject[] Objects = new GameObject[3];
    public Transform[] transformers = new Transform[3];
    public Transform targetpos;

    public Light _light;
    public float speed = 0.5f, rotateSpeed = 10f;

    private void Start() {
      // obj.SetActive(false);
      //obj.GetComponent<Transform>().position = new Vector3(10,0,5); 
        targetpos.position = new Vector3(10,0,5);
        _light.intensity = 0.5f;

        // for (int i=0; i<Objects.Length ;i++)
        // {
        //     Objects[i].SetActive(false);
        // }
    }

    private void Update() {
        for (int i=0; i< transformers.Length;i++){
            if (transformers[i] == null) {
                continue;
            }
            transformers[i].Translate(new Vector3(1,1,1) * speed * Time.deltaTime);
            transformers[i].Rotate(new Vector3(4,0,0) * rotateSpeed * Time.deltaTime);
            float posX = transformers[i].position.x;

            if (posX>100f && transformers[i].gameObject.name == "Cube") 
            {
                Destroy(transformers[i].gameObject);
            }

        }
    }
}
