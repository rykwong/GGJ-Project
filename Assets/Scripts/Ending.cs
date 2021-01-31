using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject[] people;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject person in people)
        {
            if (person.name == "Trucker" && PlayerPrefs.GetInt("trucker") == 1)
            {
                person.SetActive(true);
            }
            if (person.name == "OldLady" && PlayerPrefs.GetInt("oldlady") == 1)
            {
                person.SetActive(true);
            }

            if (person.name == "Girl" && PlayerPrefs.GetInt("oldlady") == 1)
            {
                person.SetActive(true);
            }
            if (person.name == "Math" && PlayerPrefs.GetInt("math") == 1)
            {
                person.SetActive(true);
            }
        }
    }
}
