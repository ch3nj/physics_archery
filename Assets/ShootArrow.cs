using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;
    private float stringCoeff = 0.05f;
    public float angle = 0.0f;
    public float drawDistance = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeDraw(float newDraw) {
      drawDistance = newDraw;
    }

    public void changeAngle(float newAngle) {
      angle = newAngle;
      transform.rotation = Quaternion.LookRotation(Vector3.forward, Quaternion.Euler(0, 0, angle+90) * Vector3.right);
    }

    public void Shoot()
    {
      print("shooting");
      Vector3 pos = transform.position;
      Instantiate(arrow, pos, Quaternion.identity);
      ArrowController controller = arrow.GetComponent<ArrowController>();
      controller.arrow_velocity = Quaternion.Euler(0, 0, angle) * (stringCoeff*drawDistance*drawDistance*Vector3.right);
    }
}
