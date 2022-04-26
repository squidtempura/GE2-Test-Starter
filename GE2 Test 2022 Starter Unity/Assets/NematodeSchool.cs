using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 500;
    private Constrain constrain;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // Put your code here
        for(int i = 0; i < count; i++)
        {
            GameObject g = Instantiate(prefab);
            constrain = g.gameObject.transform.GetChild(0).gameObject.AddComponent<Constrain>();
            constrain.radius = radius;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
