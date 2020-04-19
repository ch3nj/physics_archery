using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Vector3 arrow_velocity;
    public float gravity = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeGravity(float newGravity) {
      print("changing" + newGravity.ToString());
      gravity = newGravity;
    }

    void Move()
    {
      print(arrow_velocity.ToString());
      print(gravity);
      Vector3 pos = transform.position;
      arrow_velocity.y -= gravity*0.0001f;
      transform.rotation = Quaternion.LookRotation(new Vector3(0,0,1), new Vector3(-arrow_velocity.y, arrow_velocity.x, 0));
      pos += arrow_velocity;
      transform.position = pos;

      Invoke("Move", .01f);
    }
}
