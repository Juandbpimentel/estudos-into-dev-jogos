using System.Collections;
using UnityEngine;

public class GerenciadorDoGame : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public int numeroDeInimigos = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnInimigos(2f));
    }

    private IEnumerator SpawnInimigos(float intervalo)
    {
        for (int i = 0; i < numeroDeInimigos; i++)
        {
            Instantiate(inimigoPrefab, new Vector3(Random.Range(-5, 5), 8f, 2.8f), Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
