using MSCLoader;
using UnityEngine;
using System.Collections;

namespace FireplaceFlicker
{
    public class CottageGrill : MonoBehaviour
    {
        private Light FireplaceLight;
        private bool Flicker = false;
        private float Delay;
        private GameObject LightObject;

        void Update()
        {
            LightObject = GameObject.Find("COTTAGE/Grill/Fireplace/Flame/FireEffects/Light");
            FireplaceLight = GameObject.Find("COTTAGE/Grill/Fireplace/Flame/FireEffects/Light").GetComponent<Light>();
            FireplaceLight.shadows = LightShadows.Hard;
            if (Flicker == false && LightObject.activeSelf == true)
            {
                StartCoroutine(FlickerControl());
            }
            else
            {
                StopCoroutine(FlickerControl());
            }
        }

        IEnumerator FlickerControl()
        {
            Flicker = true;
            FireplaceLight.intensity = Random.Range(0.5f, 1.5f);
            Delay = Random.Range(0.1f, 0.3f);
            yield return new WaitForSeconds(Delay);
            Flicker = false;
        }
    }
}