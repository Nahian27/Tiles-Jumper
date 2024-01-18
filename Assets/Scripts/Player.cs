using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody playerCube;
    public Slider frameRateSlider;
    public TextMeshProUGUI frameRateSliderText;
    public float jumpForce, verticalForce;


    private void Start()
    {
        Application.targetFrameRate = 160;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCube.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerCube.AddForce(new Vector3(-verticalForce, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerCube.AddForce(new Vector3(verticalForce, 0, 0), ForceMode.Impulse);
        }

    }
    private void LateUpdate()
    {
        Application.targetFrameRate = (int)frameRateSlider.value;
        frameRateSliderText.text = frameRateSlider.value.ToString();
    }
}
