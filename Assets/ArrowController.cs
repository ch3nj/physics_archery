using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float MAX_X = 10f;
    public float MAX_Y = 10f;
    public float MIN_X = -10f;
    public float MIN_Y = -10f;

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
      Vector3 pos = transform.position;
      arrow_velocity.y -= gravity*0.0001f;
      transform.rotation = Quaternion.LookRotation(Vector3.forward, new Vector3(-arrow_velocity.y, arrow_velocity.x, 0));
      pos += arrow_velocity;
      transform.position = pos;
      if (pos.x > MAX_X || pos.x < MIN_X || pos.y > MAX_Y || pos.y < MIN_Y) {

        Destroy(this.gameObject);
      }

      Invoke("Move", .01f);
    }
}
