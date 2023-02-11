using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private List<Material> colorList;

    private int i = 0;

    public void NewCube()
    {
        var newCube = GameObject.Instantiate(prefab, this.transform.position, Quaternion.identity);
        newCube.GetComponent<Renderer>().material = colorList[i];
        i = (i+1) % colorList.Count;

        Debug.Log(colorList.Count);
        Debug.Log(i);
    }
}
