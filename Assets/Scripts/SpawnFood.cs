using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabs;

    private int i = 0;

    public void NewFood()
    {
        var newCube = GameObject.Instantiate(prefabs[i], this.transform.position, Quaternion.identity);
        i = (i + 1) % prefabs.Count;
    }
}
