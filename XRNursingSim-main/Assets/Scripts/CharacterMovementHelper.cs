using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementHelper : MonoBehaviour
{
    private XRRig xRRig;
    private CharacterController CharacterController;
    private CharacterControllerDriver driver;

    // Start is called before the first frame update
    void Start()
    {
        xRRig = GetComponent<XRRig>();
        CharacterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    protected virtual void UpdateCharacterController()
    {
        if (xRRig == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(xRRig.cameraInRigSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = xRRig.cameraInRigSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}
