using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBody : MonoBehaviour
{
    [SerializeField]
    private Vector3 angles = new Vector3(45.0f, 0, 0);
    public bool Rotate { get; set; } = true;

    private Rigidbody _body;
    // Start is called before the first frame update
    void Start()
    {
        _body = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _body.freezeRotation = Rotate;
        if (Rotate)
        {
            this.transform.Rotate(angles * Time.deltaTime);
        }
    }
}
