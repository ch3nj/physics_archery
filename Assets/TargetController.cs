using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{

    public GameObject victory;
    public Vector3 victoryPos = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
      print("target");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      print("collide");
      if (collision.gameObject.GetComponent<ArrowController>()) {
        ArrowController controller = collision.gameObject.GetComponent<ArrowController>();
        controller.CancelInvoke();
        Instantiate(victory, victoryPos, Quaternion.identity);
      }
    }
}
