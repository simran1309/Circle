using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondInstantiator : MonoBehaviour
{
    Transform[] childTransform;
    public GameObject DiamondPrefab;
    // Start is called before the first frame update
    void Awake()
    {
        childTransform = new Transform[transform.childCount];
        for (int i = 0; i < childTransform.Length; i++)
        {
            childTransform[i] = transform.GetChild(i);
        }
        InstantiateDiamond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateDiamond()
    {
        for (int i = 0; i < childTransform.Length; i++)
        {
            if(Random.value > 0.4f)
            {
                Instantiate(DiamondPrefab, childTransform[i].position, Quaternion.identity);
            }
        }
    }
}
