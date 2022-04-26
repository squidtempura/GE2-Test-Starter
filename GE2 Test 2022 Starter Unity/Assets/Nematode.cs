using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;
    public Material material;
    public GameObject sphere;
    private float Half;
    public float x = 0f;
    void Awake()
    {
    
        sphere.AddComponent<NoiseWander>();
        length = Random.Range(7,20);
        Half = (int)(length/2);
        // Put your code here!
        for(int i = 0; i < length; i++){
            GameObject g = GameObject.Instantiate<GameObject>(sphere);
            g.transform.SetParent(this.transform);
            g.transform.position = new Vector3(x + i, 0, 0);
            if (i < Half) {
                g.transform.localScale = new Vector3(0.2f * (i + 1), 0.2f * (i + 1), 0.2f * (i + 1));
                g.transform.position = new Vector3(x + i/4, 0, 0);
            }
            else
            {
                g.transform.localScale = new Vector3(0.2f * (length - i), 0.2f * (length - i), 0.2f * (length - i));
                g.transform.position = new Vector3(x +i/4, 0, 0);
            }
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
