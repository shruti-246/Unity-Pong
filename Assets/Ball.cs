using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public float startingSpeed;
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1f;
        if (isRight == true)
        {
            xVelocity = 1f;
        }
        float yVelocity = UnityEngine.Random.Range(-1, 1);
        rb.linearVelocity = new Vector2(x:xVelocity * startingSpeed, y:yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
