using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderText : MonoBehaviour
{
    public float startValue;
    public string units;
    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<TextMeshProUGUI>().text = startValue.ToString() 
            + " " + units;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText(float val) {
      gameObject.GetComponent<TextMeshProUGUI>().text = val.ToString() + units;
                  // + " " + units;
    }
}
