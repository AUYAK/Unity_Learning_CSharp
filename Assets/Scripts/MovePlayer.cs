using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
 private void Update() {
    // if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
    // {
    //     transform.Translate(new Vector3(1,0,0)*Time.deltaTime * speed);
    // }
    // if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
    // {
    //     transform.Translate(new Vector3(1,0,0)*Time.deltaTime * -speed);
    // }
    //  if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    // {
    //     transform.Translate(new Vector3(0,0,1)*Time.deltaTime * speed);
    // }
    //   if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    // {
    //     transform.Translate(new Vector3(0,0,-1)*Time.deltaTime * speed);
    // }

    float v = Input.GetAxis("Vertical");
    float h = Input.GetAxis("Horizontal");
    transform.Translate(new Vector3(1,0,0)*v*speed*Time.deltaTime);
    transform.Translate(new Vector3(0,0,-1)*h*speed*Time.deltaTime);
    
 }
}
