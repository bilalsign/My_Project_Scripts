using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ArrayAssending : MonoBehaviour
{
    // public string[] _sortalpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    public string[] Alpha;// used this to store Alphabets in unity Editor
    public Text[] text;

    public string[] _ReverseAlpha; // used this to store reverse string in unity editor.

    public string[] StoringTemporaryWords;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {

            int temp = UnityEngine.Random.Range(0, 26);
            // string myString = temp.ToString();
            text[i].text = Alpha[temp];


            //................................................................................................




            // used this to store rendomly generated words in new Array.


            //................................................................................................


            for (int k = 0; k < 1; k++)
            {

                StoringTemporaryWords[i] = text[i].text;

            }

        }
    }

    public void IfAssending()
    {
        for (int i = 0; i < 1; i++)
        {
            if (StoringTemporaryWords[i] != Alpha[i])
            {

                Debug.Log("Not Assending");

                //   ifDessending();
                //  Debug.Log(StoringTemporaryWords[i]);
                // Debug.Log(Alpha[i]);
            }

            else
            {
                Debug.Log("Assending");
            }



        }
    }

        public void ifDessending()
        {
            for (int i = 0; i < 1; i++)
            {
                if (StoringTemporaryWords[i] != _ReverseAlpha[i])
                {

                    Debug.Log("Not Desending");

                    //   ifDessending();
                    //  Debug.Log(StoringTemporaryWords[i]);
                    // Debug.Log(Alpha[i]);
                }

                else
                {
                    Debug.Log("Desending");
                }



            }






        }

        // public void ifDessending()
        // {
        //     for (int i = 0; i < 1; i++)
        //     {
        //         if (StoringTemporaryWords[i] != Alpha[i-1])
        //         {
        //             Debug.Log("Not Desending");
        //         }
        //         else
        //         {
        //             Debug.Log(" Desending ");
        //         }

        //     }

    }




// ................................   Used this code for comparing Logic ..................

// Boolean isArrayEqual = true;


// int[] arr1 = { 1, 2, 3, 4, 5 };
// int[] arr2 = { 1, 2, 3, 5 };

// if (arr1.Length == arr2.Length)
// {

//     for (int i = 0; i < arr2.Length; i++)
//     {
//         if (arr2[i] != arr1[i])
//         {
//             isArrayEqual = false;
//         }
//         else
//         {
//             isArrayEqual = false;
//         }
//         if(isArrayEqual)
//         {
//             Debug.Log("Both are equal");
//         }
//         else
//         {
//             Debug.Log("Both are not equal");
//         }

//     }


// }




// ................................................................................................................

//Alphabets through Ascii code

//.................................................................................................................


// public void GetAlphabets()
// {
//     string strAlphabets = " ";

//     for (int i= 65; i<=90;i++ )
//     {
//         strAlphabets += ((char)i).ToString()+ " ";

//     }
//    // Debug.Log (strAlphabets);

// }


//..........................................................................................................



//..........................................................................................................

//  Debug.Log(temp);

// for (int j = 0; j < 1; j++)
// {
//     int index = temp;

//     if (text[i].text == Alpha[i])
//     {
//         index = j;
//     }

//     // Debug.Log("Index   ===  >  " + index);
// }


// Used to get index and text in console :



//  Debug.Log(text[i].text + " is at " + temp);








//..........................................................................................................


//..........................................................................................................


//Used this code to print the index of random number.



//-------------------------------------------
//     for (int j = 0; j < 1; j++)
//     {
//         int index = temp;
//         if (text[i].text == Alpha[i])
//         {
//             index = j;
//         }
//         Debug.Log("Index" + temp);

//     }
// }

//...................................................


// for (int k = 0; k < StoringTemporaryWords.Length; k++)
// {
//      = StoringTemporaryWords[0];

// }


// Logic for copy the index from one array to another array




//.....................................................





// for (int k = 0; k < StoringTemporaryWords.Length; i++)
// {
//     string[] target = new string[4];
//     Array.Copy(text, StoringTemporaryWords, 4);

//     Debug.Log("Destination Array......");
//     foreach (string value in StoringTemporaryWords)
//     {
//         Debug.Log("index is " + value);
//     }

// }





//.................................................

//     for (int k = 0; k < 1; k++)
//     {
//         int _newRand = temp;
//         if (text[i].text == Alpha[i])
//         {
//             _newRand = k;
//         }

//         Debug.Log("Index is  " + _newRand);
//     }


//     for (int l = 0; l < Alpha.Length-1; l++)
//     {
//         if(Alpha[i] < text[temp])
//         {
//             Debug.Log("Assendign .......");
//         }


//     }
//     Debug.Log("Wrong ..........");
// }
// ...........................................................



