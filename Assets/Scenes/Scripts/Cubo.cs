using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool isGrounded;
    private bool isSecondJumpAvailable;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || isSecondJumpAvailable))
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            transform.position += Vector3.up * speed * Time.deltaTime;

            if(!isGrounded && isSecondJumpAvailable)
            {
                isSecondJumpAvailable = false;
            }
        }
        //new Vector3(x,y,z)
        //new Vector3(0f, 0f, 0f);
    }

    private void OnTriggerEnter(Collider collision) 
    {
        Debug.Log("CollisionEnter");
        isGrounded = true;
        isSecondJumpAvailable = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("CollisionExit");
        isGrounded = false;
    }
}
