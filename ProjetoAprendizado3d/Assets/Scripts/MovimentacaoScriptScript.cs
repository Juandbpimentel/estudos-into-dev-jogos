using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimentacaoScript : MonoBehaviour
{

    public GameObject bullet;
    public float velocity = 0.05f;
    public float sprintVelocity = 0.1f;
    public float forcaProjetil = 1000;
    public float jumpVelocity = 0.25f;
    public float jumpForce = 10f;
    bool isDoubleJumped = false;
    bool isGrounded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sprintVelocity = velocity * 2;
    }

    // Update is called once per frame
    void Update()
    {
        verifyJump();
        verifyXMoviment();
        verifyXRotation();
        // verifyYRotation();
        verifyZMoviment();
        verifyFire();
        // verifyFlyUp();
        // verifyFlyDown();
        verifySprint();
    }

    void verifyXMoviment()
    {
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += this.gameObject.transform.right * -velocity;
        }
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += this.gameObject.transform.right * velocity;
        }
    }

    void verifyZMoviment()
    {
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += this.gameObject.transform.forward * velocity;
        }
        else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += this.gameObject.transform.forward * -velocity;
        }
    }

    void verifyXRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            // this.gameObject.transform.position = this.gameObject.transform.position + gameObject.transform.up * velocity;
            this.gameObject.transform.Rotate(Vector3.up, -1);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(Vector3.up, 1);
        }
    }

    void verifyYRotation()
    {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Rotate(Vector3.right, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.Rotate(Vector3.right, -1);
        }
    }

    void verifyJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, jumpForce, 0);
                isDoubleJumped = false;
            }
            else if (!isDoubleJumped)
            {
                isDoubleJumped = true;
                gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, jumpForce, 0);
                return;
            }
        }
    }

    // void verifyFlyUp()
    // {
    //     if (Input.GetKey(KeyCode.Space) && !isGrounded)
    //         gameObject.transform.position += jumpVelocity * Vector3.up;
    // }

    // void verifyFlyDown()
    // {
    //     if (Input.GetKey(KeyCode.LeftControl) && !isGrounded)
    //         gameObject.transform.position += -jumpVelocity * Vector3.up;
    // }

    void verifySprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            velocity = sprintVelocity;
        else
            velocity = sprintVelocity / 2;
    }

    void verifyFire()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // create a bullet da forma rápida:
            // GameObject bullet = GameObject.FindGameObjectWithTag("Bala");
            // GameObject balaCopia = Instantiate(bullet, this.gameObject.transform.position, this.gameObject.transform.rotation);
            // empurrar a bala pra frente
            // balaCopia.transform.position += this.gameObject.transform.forward * 0.5f;
            // add force to the bullet
            // Rigidbody rb = balaCopia.GetComponent<Rigidbody>();
            // rb.AddForce(this.gameObject.transform.forward * 1000);
            // destroy the bullet after 2 seconds
            // Destroy(balaCopia, 2);
            // print to console
            // Debug.Log("Fire!");

            // create a bullet da forma simples:
            // GameObject bullet = GameObject.FindWithTag("Bala");
            GameObject balaCopia = Instantiate(bullet);
            balaCopia.transform.position = this.gameObject.transform.position + this.gameObject.transform.forward * 0.5f;
            balaCopia.transform.rotation = this.gameObject.transform.rotation;

            // add force to the bullet
            Rigidbody rb = balaCopia.GetComponent<Rigidbody>();
            balaCopia.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * forcaProjetil);
            // destroy the bullet after 1 second
            Destroy(balaCopia, 1);
            // print to console
            Debug.Log("Fire!");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            isGrounded = true;
            isDoubleJumped = false;
        }

        if (other.gameObject.CompareTag("Inimigo"))
        {
            Destroy(this.gameObject);
            Debug.Log("Você morreu!");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            isGrounded = false;
        }
    }
}
