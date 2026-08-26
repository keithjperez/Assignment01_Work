using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{

    // something weird I noticed was that
    // 0,0 is the place that Unity selects for the XR thing
    public BallPrefab ballPrefab;
    public TargetPrefab targetPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Touchscreen.current.press.isPressed)
        {
            if (Touchscreen.current.press.wasPressedThisFrame)
            {
                BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
                ball.transform.localPosition = transform.position;
                ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 2000);
            }
        }

    }
    public void spawnNewTarget()
    {
        
    }
}
