using UnityEngine;
using UnityEngine.UI;

public class PlayerCntrl : MonoBehaviour
{
    public Text scoreText;
    public int cubesCollected = 0;
    public float hspeed = 50f;
    public float _thrust = 500f;
    private Rigidbody _rb;
    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

       private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(h,_rb.velocity.y,v)*hspeed * Time.fixedDeltaTime);
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "CollectableObjects"){
        cubesCollected+=1;
        Destroy(other.gameObject);
        if (cubesCollected!=5){
        scoreText.text = "Score" + cubesCollected; 
        }    
        else if(cubesCollected==5) {
        scoreText.text = "You won!";    
        } else {
        scoreText.text = "You found more than intended!";    
        }   
        }
    }

}
