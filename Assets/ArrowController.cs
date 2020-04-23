using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float MAX_X = 10f;
    public float MAX_Y = 10f;
    public float MIN_X = -10f;
    public float MIN_Y = -10f;

    public float arrow_weight;
    public Vector3 arrow_velocity;
    public float gravity = 9.81f;
    public float airResistance = 0.0f;

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

    public void changeAirResistance(float newAR) {
      print("changing" + newAR.ToString());
      airResistance = newAR;
    }

    void Move()
    {
      Vector3 pos = transform.position;
      arrow_velocity.y -= gravity*0.0001f;
      arrow_velocity.x -= arrow_velocity.x*airResistance*0.0001f/arrow_weight;
      arrow_velocity.y -= arrow_velocity.y*airResistance*0.0001f/arrow_weight;
      transform.rotation = Quaternion.LookRotation(Vector3.forward, new Vector3(-arrow_velocity.y, arrow_velocity.x, 0));
      pos += arrow_velocity;
      transform.position = pos;
      if (pos.x > MAX_X || pos.x < MIN_X || pos.y > MAX_Y || pos.y < MIN_Y) {
        Destroy(this.gameObject);
      }

      Invoke("Move", .01f);
    }
}
