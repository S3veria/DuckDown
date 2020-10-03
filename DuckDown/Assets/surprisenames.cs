using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class surprisenames : MonoBehaviour
{

    public Text name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12;
    int x;
    bool isonlist;
    List<string> nombress = new List<string>();
    List<string> nombres = new List<string>();
    string nombre1,nombre2,nombre3,nombre4,nombre5,nombre6,nombre7,nombre8,nombre9,nombre10,nombre11,nombre12;
    
    // Start is called before the first frame update
    void Start()
    {
        nombres.Add("Esteban Romero");
        nombres.Add("Jonathan Garcia");
        nombres.Add("Andres Ortiz");
        nombres.Add("Adan Galindo");
        nombres.Add("Michael McDaniel");
        nombres.Add("Daniel Cedillo");
        nombres.Add("Johanna Schindler");
        nombres.Add("Andrea Luna");
        nombres.Add("Daniela Partida");
        nombres.Add("Hector Castro");
        nombres.Add("Ximena Torres");
        nombres.Add("Toya Nuztas");
        nombres.Add("Vannesa Barragan");
        nombres.Add("Jorge Luis Chimal");
        nombres.Add("Arturo Saenz");
        nombres.Add("Andrea Reyes");
        nombres.Add("Rodolfo Flores");




        //1
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name1.text = nombres[x];

        //2
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name2.text = nombres[x];

        //3
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name3.text = nombres[x];


        //4
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name4.text = nombres[x];


        //5
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name5.text = nombres[x];


        //6
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name6.text = nombres[x];


        //7
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name7.text = nombres[x];



        //8
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name8.text = nombres[x];


        //9
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name9.text = nombres[x];


        //10
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name10.text = nombres[x];


        //11
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name11.text = nombres[x];


        //12
        x = Random.Range(0, 16);
        isonlist = nombress.Contains(nombres[x]);
        while (isonlist)
        {
            x = Random.Range(0, 16);
            isonlist = nombress.Contains(nombres[x]);
        }
        nombress.Add(nombres[x]);
        name12.text = nombres[x];




    }

    // Update is called once per frame
}
