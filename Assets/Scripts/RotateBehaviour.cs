using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 angles = new Vector3(45.0f, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.Rotate(angles*Time.deltaTime, Space.Self);
    }
}
