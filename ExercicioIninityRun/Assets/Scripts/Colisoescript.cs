using UnityEngine;

public class Colisoescript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<InimigoScript>().ResetPosition();
            Debug.Log("Colidiu com o inimigo!");
            GameObject go = GameObject.FindWithTag("GameController");
            go.GetComponent<Statuscript>().PerdeVida();
        }
    }
}
