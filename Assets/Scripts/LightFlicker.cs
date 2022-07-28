using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float OFF_RANGE = 0f;
    public float ON_RANGE = 10f;
    public float MIN_TIME_BETWEEN_FLICKERS = 5f;
    public float MAX_TIME_BETWEEN_FLICKERS = 7f;
    public float FLICKER_LENGTH = 0.1f;
    public int MAX_FLICKER_AMOUNT = 3;
    public int MIN_FLICKER_AMOUNT = 3;
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        // Getting compontent and starting the coroutine
        lightComponent = GetComponent<Light>();
        StartCoroutine(flicker());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator flicker() {
        float waitTime;
        int flickers;
        // The flickers will last as long as the script is enabled
        while (true) 
        {
            // The light range when the light is on is given by ON_RANGE
            lightComponent.range = ON_RANGE;

            // Randomized wait time between flickers
            waitTime = Random.Range(MIN_TIME_BETWEEN_FLICKERS, MAX_TIME_BETWEEN_FLICKERS);
            yield return new WaitForSeconds(waitTime);

            // Randomized amount of flickers
            flickers = Random.Range(MIN_FLICKER_AMOUNT, MAX_FLICKER_AMOUNT + 1);
            for (int i = 1; i <= flickers; i++) {
                // The light range when the light is off is given by OFF_RANGE
                lightComponent.range = OFF_RANGE;
                yield return new WaitForSeconds(FLICKER_LENGTH);
                lightComponent.range = ON_RANGE;
                yield return new WaitForSeconds(FLICKER_LENGTH);
            }
        }
    }
}
