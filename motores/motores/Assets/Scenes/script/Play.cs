using UnityEngine;
    
    public class Play : MonoBehaviour
    {
        private int _numero = 0; 
        public float velocidade = 5f; 
    
        void Start()
        {
            _numero = 0;
        }
    
        void Update()
        {
            
    
            float movimento = 0;
    
            if (Input.GetKey(KeyCode.A))
            {
                movimento -= 1;
            }
    
            if (Input.GetKey(KeyCode.D))
            {
                movimento += 1;
            }
    
            
            transform.position += new Vector3(movimento, 0, 0) * velocidade * Time.deltaTime;
        }
    }
    
        
        
    


