using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MobileControlScript : MonoBehaviour
{
    public GameObject userCamera;

    public float moveSpeed = 0;
    public float rotateSpeed = 0;
    public GameObject panController;

    private float movementX;
    private float movementY;
    private float panX;
    private float panControllerY;

    public GameObject sinkWater;

    void Start() {
        panControllerY = panController.GetComponent<RectTransform>().anchoredPosition.y;
    }

    void Update() {
        // move pan controller handle horizontally only
        float panControllerX = panController.GetComponent<RectTransform>().anchoredPosition.x;
        panController.GetComponent<RectTransform>().anchoredPosition = new Vector2(panControllerX, panControllerY);
    }

    void FixedUpdate()
    {
        // move player
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // rotate player horizontally only
        transform.Rotate(0.0f, panX * rotateSpeed, 0.0f);
        Vector3 playerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(0, playerRotation.y, 0);

        // move pan controller handle horizontally only
        float panControllerX = panController.GetComponent<RectTransform>().anchoredPosition.x;
        panController.GetComponent<RectTransform>().anchoredPosition = new Vector2(panControllerX, panControllerY);

        if (Input.touchCount > 0 && Input.touches[0].phase == UnityEngine.TouchPhase.Began) {
            RaycastHit hit;
            Ray ray = userCamera.GetComponent<Camera>().ScreenPointToRay(Input.touches[0].position);
            
            if (Physics.Raycast(ray, out hit)) {
                Transform objectHit = hit.transform;
                if (hit.collider.name == "Sink") { // name of the sink gameobject
                    toggleSink();
                }
            }
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void OnPan(InputValue value)
    {
        Vector2 panVector = value.Get<Vector2>();

        panX = panVector.x;
    }

    private void toggleSink() {
        sinkWater.SetActive(!sinkWater.activeSelf);
    }
}
