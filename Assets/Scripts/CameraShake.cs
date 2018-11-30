//Code provided by: https://github.com/ftvs
using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 1000f; //infinite

    // Amplitude of the shake. A larger value shakes the camera harder.
    public static float shakeAmount = 0f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    public void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    public void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {

        shakeAmount = GameManager.measureTotal / 200f;

        if (shakeDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            camTransform.localPosition = originalPos;
        }
    }
}