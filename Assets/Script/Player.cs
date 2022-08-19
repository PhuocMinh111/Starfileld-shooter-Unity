using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    Vector2 rawInput;
    Vector2 minBound;
    Vector2 maxBound;
    // Start is called before the first frame update
    public InputAction controls;
    [SerializeField] float movSpeed = 5f;
    // Update is called once per frame
    void Start()
    {
        initBound();
    }


    void initBound()
    {
        Camera camera = Camera.main;
        minBound = camera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBound = camera.ViewportToWorldPoint(new Vector2(1, 1));
    }
    void Update()
    {
        Vector2 delta = rawInput * movSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();
        newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBound.x, maxBound.x);
        newPos.y = Mathf.Clamp(transform.position.y + delta.y, minBound.y, maxBound.y);
        transform.position = newPos;
    }



    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        Debug.Log(rawInput);
    }

}
