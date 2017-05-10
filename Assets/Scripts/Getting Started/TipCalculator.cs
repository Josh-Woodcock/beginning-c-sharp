using UnityEngine;

public class TipCalculator : MonoBehaviour {

    public int balance;
    public int tip_percentage;

    void OnDisable () {

        int tip = balance / tip_percentage;
        int total = balance + tip;

        Debug.Log(" The new balance is " + total);
        
    }
}