using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showthermometer : MonoBehaviour
{
   public GameObject thermometerPicture;

private void Start()
{
    thermometerPicture.SetActive(false);

}

public void Pressed()
{
    thermometerPicture.SetActive(true);
}
}
