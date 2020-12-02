using System;
using UnityEngine;
public class ScaleCube : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    float scaleY;
    float scaleX;

    void FixedUpdate()
    {
        
        if (UIManager.instance.isStart)
        {
            if (InputManager.instance.input.y != 0)
            {
                scaleY = Mathf.Clamp(transform.localScale.y + InputManager.instance.input.y, .4f, 2f);
                scaleX = Mathf.Clamp(transform.localScale.x - InputManager.instance.input.y, .4f, 3f);
                transform.localScale = new Vector3(scaleX, scaleY, 0.3f);
            }
            transform.Translate(0, 0, .1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstracle"))
        {
            UIManager.instance.EndGame(false);
        }

        if (other.gameObject.CompareTag("finish"))
        {
            UIManager.instance.EndGame(true);
        }
    }




}
