using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
    [SerializeField] GameObject pinSelectionUI;
    [SerializeField] GameObject pinPrefab;
    [SerializeField] Transform pinPositionOne;
    [SerializeField] Transform pinPositionTwo;
    [SerializeField] Transform pinPositionThree;
    [SerializeField] List<PinSO> deck;

    GameObject pinOne, pinTwo, pinThree;

    List<PinSO> alreadySelectedPins = new List<PinSO>();

    public void RandomizeNewPin()
    {
        if(pinOne != null) Destroy(pinOne);
        if(pinTwo != null) Destroy(pinTwo);
        if(pinThree != null) Destroy(pinThree);

        List<PinSO> randomizedPins = new List<PinSO>();
        List<PinSO> availablePins = new List<PinSO>();
        availablePins.RemoveAll(pin => pin.isUnique && alreadySelectedPins.Contains(pin));
        //|| pin.unlockLevel > GameManager.Instance.GetCurrentLevel()

        if(availablePins.Count < 3)
        {
            Debug.Log("not enough available pins");
            return;
        }

        while(randomizedPins.Count < 3)
        {
            PinSO randomPin = availablePins[Random.Range(0, availablePins.Count)];
            if(!alreadySelectedPins.Contains(randomPin))
            {
                randomizedPins.Add(randomPin);
            }
        }

        pinOne = InstantiatePin(randomizedPins[0], pinPositionOne);
        pinTwo = InstantiatePin(randomizedPins[1], pinPositionTwo);
        pinThree = InstantiatePin(randomizedPins[3], pinPositionThree);

        GameObject InstantiatePin(PinSO pinSO, Transform position)
        {
            GameObject pinGo = Instantiate(pinPrefab, position.position, Quaternion.identity, position);
            Pin pin = pinGo.GetComponent<Pin>();
            pin.Setup(pinSO);
            return pinGo; 
        }
    }
}
