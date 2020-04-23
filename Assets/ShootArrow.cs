using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;
    private float timer = 0.0f;
    private float cooldown = 2.0f;
    private float stringCoeff = 0.2f;
    public float angle = 0.0f;
    public float drawDistance = 1.0f;
    public int arrowsLeft = 3;
    // Start is called before the first frame update
    void Start()
    {
      timer = cooldown;
      angle = 0.0f;
      drawDistance = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
    }

    public void changeDraw(float newDraw) {
      print(newDraw);
      drawDistance = newDraw;
    }

    public void changeAngle(float newAngle) {
      print(newAngle);
      angle = newAngle;
      transform.rotation = Quaternion.LookRotation(Vector3.forward, Quaternion.Euler(0, 0, angle+90) * Vector3.right);
    }

    public void Shoot()
    {
      if (timer < cooldown || arrowsLeft <= 0) {
        return;
      }
      timer = 0.0f;
      print("shooting");
      print("draw " + drawDistance.ToString());
      print("angle" + angle.ToString());
      Vector3 pos = transform.position;
      GameObject shot = Instantiate(arrow, pos, Quaternion.identity);
      arrowsLeft -= 1;
      ArrowController controller = shot.GetComponent<ArrowController>();
      controller.arrow_velocity = Quaternion.Euler(0, 0, angle) * (stringCoeff*drawDistance*Vector3.right);
    }
}
