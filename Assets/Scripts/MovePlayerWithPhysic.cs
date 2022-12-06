using UnityEngine;

public class MovePlayerWithPhysic : MonoBehaviour
{
    public float hspeed = 1000f;
    public float vspeed = 500f;
    public float _thrust = 500f;
    private Rigidbody _rb;
    private void Awake() {
       _rb = GetComponent<Rigidbody>(); 
    }
    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal")*hspeed*Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical")*hspeed*Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(v,_rb.velocity.y,-h));
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Block"){
            _rb.AddForce(new Vector3(_rb.velocity.x * -1,1,_rb.velocity.z*-1) * _thrust);
        }
        
    }
    private void OnCollisionStay(Collision other) {
        
    }
    private void OnCollisionExit(Collision other) {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "TriggerMain"){
            Debug.Log("Trigger is correct");
        }

    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "TriggerMain"){
               transform.localScale = new Vector3(transform.localScale.x*1.01f,transform.localScale.y*1.01f,transform.localScale.z*1.01f);
            }
    }
    private void OnTriggerExit(Collider other) {
            if (other.gameObject.name == "TriggerMain"){
                Destroy(gameObject);
            }
        
    }

}
