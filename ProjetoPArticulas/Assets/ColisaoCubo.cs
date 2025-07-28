using UnityEngine;

public class ColisaoCubo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Colisão com o Player detectada!");
    }
}
