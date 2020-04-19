using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
      print("shooting");
      Vector3 pos = transform.position;
      Instantiate(arrow, pos, Quaternion.identity);
    }
}
