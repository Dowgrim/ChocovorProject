using UnityEngine;
using System.Collections;

public class ChocoControler : MonoBehaviour {

    [SerializeField]
    private int modality = 0;

    [SerializeField]
    private GameObject Choco;

    private Movement moveComponent;

    // Use this for initialization
    void Start () {
        moveComponent = Choco.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalTranslation = Input.GetAxis("Horizontal");
        float verticalTranslation = Input.GetAxis("Vertical");

        moveComponent.AddMovement(horizontalTranslation, verticalTranslation);
    }
}
