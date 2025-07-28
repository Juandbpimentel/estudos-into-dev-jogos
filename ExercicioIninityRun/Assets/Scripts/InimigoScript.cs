using UnityEngine;

public class InimigoScript : MonoBehaviour
{
    public float velocidade = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.Translate(new Vector3(Random.Range(-5, 5), 8f, 2.8f));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.up * velocidade * -1;
        if (gameObject.transform.position.y < -8f)
        {
            // Reset the position of the enemy to a random position at the top of the screen
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        gameObject.transform.position = new Vector3(Random.Range(-5, 5), 8f, 2.8f);
    }
}
