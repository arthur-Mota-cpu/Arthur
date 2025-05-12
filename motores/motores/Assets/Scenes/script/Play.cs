using UnityEngine;

public class play : MonoBehaviour
{
    private int numero = 0;
    public float velocidade = 40;

    void Start()
    {
        numero = 0;
    }


    void Update()
    {
        //debug.log(numero0;
        //numero = numero  + 1;

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(- *Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
            
            gameObject.transform.position += new Vector3(+ Time.deltaTime, 0, 0);
            
    }
    }
    
    
    


