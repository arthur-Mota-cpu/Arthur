using UnityEngine;

public class Play : MonoBehaviour
{
    private int numero = 0;
    public float velocidade = 40

    void Start()
    {
        numero = 0;
    }


    void Update()
    {
        //debug.log(numero0;
        //numero = numero + 1;

        if (Input.GetKey(KeyCode.A))
        {
            GameObject.transform.position += new Vector3(velocidade, 0, 0);
        }


    }
}

if (Input.GetKey(KeyCode.D))

}
