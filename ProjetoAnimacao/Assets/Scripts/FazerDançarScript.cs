using UnityEditor.Animations;
using UnityEngine;

public class FazerDançarScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<Animator>().SetBool("pressed", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.gameObject.GetComponent<Animator>().SetBool("pressed", false);
        }
    }
}
