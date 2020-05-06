using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;
    private float timer = 0.0f;
    private float cooldown = 2.0f;
    private float stringCoeff = 0.8f;
    public float weight;
    public float angle;
    public float drawDistance;
    public int arrowsLeft = 3;

    public GameObject arrowsText;
    // Start is called before the first frame update
    void Start()
    {
      timer = cooldown;
      changeAngle(angle);

      arrowsText.GetComponent<TextMeshProUGUI>().text = "Arrows Left: " + arrowsLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
    }

    public void changeDraw(float newDraw) {
      drawDistance = newDraw;
    }

    public void changeAngle(float newAngle) {
      angle = newAngle;
      transform.rotation = Quaternion.LookRotation(Vector3.forward, Quaternion.Euler(0, 0, angle+90) * Vector3.right);
    }

    public void changeArrowWeight(float newWeight) {
      weight = newWeight;
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
      arrowsText.GetComponent<TextMeshProUGUI>().text = "Arrows Left: " + arrowsLeft.ToString();
      ArrowController controller = shot.GetComponent<ArrowController>();
      controller.arrow_velocity = Quaternion.Euler(0, 0, angle) * (stringCoeff/weight*drawDistance*Vector3.right);
      controller.arrow_weight = weight;
    }
}
