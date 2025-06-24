using UnityEngine;

public class PLAYER : MonoBehaviour
{
    private int numero;
    public float velocidade = 0.7f;

    void Start()
    {
        numero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(numero);
        //numero = numero + 1;

        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += new Vector3(0, -velocidade * Time.deltaTime, 0); // Corrigido a linha aqui

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += new Vector3(0, velocidade * Time.deltaTime, 0); // Corrigido a linha aqui
    }
}