using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public GameObject bombparent,bombradius,bombigniter;
    public float timetoexplode;

    void Start()
    {
        Invoke("ExplodeBomb",timetoexplode);
    }

    void ExplodeBomb()
    {
        MeshRenderer bombparentrenderer = gameObject.GetComponent<MeshRenderer>();
        bombparentrenderer.enabled = false;
        bombigniter.SetActive(false);
        bombradius.SetActive(true);
        Invoke("DeleteBomb",1f);
    }

    void DeleteBomb()
    {
        Destroy(bombparent);
    }
}
