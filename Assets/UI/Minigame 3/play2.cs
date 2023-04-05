using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play2 : MonoBehaviour
{
    public GameObject[] choiceArray = new GameObject[6]; //{ accountManagement, chat, payment, product, registeration, userProfile };
    public GameObject first, second, third, fourth, fifth, sixth, seventh;

    public GameObject accountManagement, chat, payment, product, registeration, userProfile;

    public Vector2[] initttPos = new Vector2[6]; //accountInitPos, chatInitPos, paymentInitPos, productInitPos, regisInitPos, profileInitPos;
    public Vector2 accountInitPos, chatInitPos, paymentInitPos, productInitPos, regisInitPos, profileInitPos;
    public double yaccount, ychat, ypayment, yproduct, yregis, yprofile;
    public GameObject miniheart1, miniheart2, miniheart3, miniheart4 ,miniheart5;
    public GameObject Scrummaster,scrumwin,scrumhelp;
    public int score = 5;
    public Text scoreText;




    public void scrum()
    {
        Scrummaster.SetActive(true);
        Scrummaster.transform.SetAsLastSibling();

    }
    public void scrumclose()
    {

        Scrummaster.SetActive(false);
    }


    public void orderaccount(double yaxis)
    {
        if(yaxis == 781)
        {
            PlayerPrefs.SetInt("orderaccount", 1);
            Debug.Log("account"+1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderaccount", 2);
            Debug.Log("account" + 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderaccount", 3);
            Debug.Log("account" + 3);

        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderaccount", 4);
            Debug.Log("account" + 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderaccount", 5);
            Debug.Log("account" + 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderaccount", 6);
            Debug.Log("account" + 6);
        }
    }

    public void orderpayment(double yaxis)
    {
        if (yaxis == 781)
        {
            PlayerPrefs.SetInt("orderpayment", 1);
            Debug.Log("payment" + 1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderpayment", 2);
            Debug.Log("payment" + 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderpayment", 3);
            Debug.Log("payment" + 3);
        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderpayment", 4);
            Debug.Log("payment" + 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderpayment", 5);
            Debug.Log("payment" + 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderpayment", 6);
            Debug.Log("payment" + 6);
        }
    }
    public void orderprofile(double yaxis)
    {
        if (yaxis == 781)
        {
            PlayerPrefs.SetInt("orderprofile", 1);
            Debug.Log("profile" + 1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderprofile", 2);
            Debug.Log("profile" + 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderprofile", 3);
            Debug.Log("profile" + 3);
        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderprofile", 4);
            Debug.Log("profile" + 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderprofile", 5);
            Debug.Log("profile" + 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderprofile", 6);
            Debug.Log("profile" + 6);
        }
    }

    public void orderchat(double yaxis)
    {
        if (yaxis == 781)
        {
            PlayerPrefs.SetInt("orderchat", 1);
            Debug.Log("chat" + 1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderchat", 2);
            Debug.Log("chat" + 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderchat", 3);
            Debug.Log("chat" + 3);
        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderchat", 4);
            Debug.Log("chat" + 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderchat", 5);
            Debug.Log("chat" + 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderchat", 6);
            Debug.Log("chat" + 6);
        }
    }

    public void orderregis(double yaxis)
    {
        if (yaxis == 781)
        {
            PlayerPrefs.SetInt("orderregis", 1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderregis", 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderregis", 3);
        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderregis", 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderregis", 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderregis", 6);
        }
    }

    public void orderproduct(double yaxis)
    {
        if (yaxis == 781)
        {
            PlayerPrefs.SetInt("orderproduct", 1);
        }
        else if (yaxis == 664)
        {
            PlayerPrefs.SetInt("orderproduct", 2);
        }
        else if (yaxis >= 540 && yaxis <= 541)
        {
            PlayerPrefs.SetInt("orderproduct", 3);
        }
        else if (yaxis == 425)
        {
            PlayerPrefs.SetInt("orderproduct", 4);
        }
        else if (yaxis == 310)
        {
            PlayerPrefs.SetInt("orderproduct", 5);
        }
        else if (yaxis == 194)
        {
            PlayerPrefs.SetInt("orderproduct", 6);
        }
    }
    public void orderChoice()
    {
        yaccount = accountInitPos.y;
        ychat = chatInitPos.y;
        ypayment = paymentInitPos.y;
        yproduct = productInitPos.y;
        yregis = regisInitPos.y;
        yprofile = profileInitPos.y;

        orderaccount(yaccount);
        orderchat(ychat);
        orderpayment(ypayment);
        orderproduct(yproduct);
        orderprofile(yprofile);
        orderregis(yregis);

        
    }




    public void knowledge()
    {
        PlayerPrefs.SetInt("scDisplay", score);
        PlayerPrefs.SetInt("mini3", score);
        SceneManager.LoadScene("Mini 3 know");
    }



    public void scrumwinshow()
    {

        scrumwin.SetActive(true);
        scrumwin.transform.SetAsLastSibling();
    }

    public void nonehelp()
    {

        scrumhelp.SetActive(false);
       
    }


    public void checkPoint()
    {
        


        if (score <= 1)
        {
            score = 1;
        }

        if (product.transform.position == first.transform.position || payment.transform.position == second.transform.position
            && userProfile.transform.position == third.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
           
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();






        }

        else if (product.transform.position == first.transform.position || payment.transform.position == third.transform.position
           && userProfile.transform.position == second.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();

        }
        else if (product.transform.position == second.transform.position && payment.transform.position == first.transform.position
            && userProfile.transform.position == third.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();

        }
        else if (product.transform.position == second.transform.position && payment.transform.position == third.transform.position
           && userProfile.transform.position == first.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();

        }
        else if (product.transform.position == third.transform.position && payment.transform.position == second.transform.position
            && userProfile.transform.position == first.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();

        }
        else if (product.transform.position == third.transform.position && payment.transform.position == first.transform.position
           && userProfile.transform.position == second.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini3", score);
            scrumwinshow();

        }
        else
        {
            
            score--;
            scoreText.text = "Score: " + score.ToString();
            Debug.Log("product" + product.transform.position);
            Debug.Log("first" + first.transform.position);
            Debug.Log(payment.transform.position);
            Debug.Log(second.transform.position);
            Debug.Log(userProfile.transform.position);
            Debug.Log(third.transform.position);


            if(score <= 1)
            {
                score = 1;

            }
            if (score == 4)
            {
                scrum();
                miniheart5.SetActive(false);
            }
            else if (score == 3)
            {
                scrum();
                miniheart4.SetActive(false);
            }
            else if (score == 2)
            {
                scrum();
                miniheart3.SetActive(false);
            }
            else if (score == 1)
            {
                scrumhelp.SetActive(true);
                scrumhelp.transform.SetAsLastSibling();
                miniheart2.SetActive(false);
            }


        }

       


    }

    public void DragChoice(GameObject Choicex)
    {
        Choicex.transform.position = Input.mousePosition;
        Choicex.transform.SetAsLastSibling();

    }

    public void DropChoice()
    {
        Debug.Log(choiceArray);
        Debug.Log(initttPos);
        switchCalculator(choiceArray, initttPos);

       
    }



    public void switchCalculator(GameObject[] choice, Vector2[] b)
    {
        Vector2 Position1, Position2;


        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                float Distance = Vector2.Distance(choice[i].transform.position, choice[j].transform.position);

                if (Distance < 100)
                {

                    Position1 = b[i];
                    Position2 = b[j];

                    choice[j].transform.position = Position1;
                    choice[i].transform.position = Position2;

                    b[i] = Position2;
                    b[j] = Position1;


                }

                else
                    choice[i].transform.position = b[i];

            }



        }


    }





   

    public void DropChoiceProfile()
    {
        float Distance1 = Vector2.Distance(userProfile.transform.position, accountInitPos);
        float Distance2 = Vector2.Distance(userProfile.transform.position, chatInitPos);
        float Distance3 = Vector2.Distance(userProfile.transform.position, paymentInitPos);
        float Distance4 = Vector2.Distance(userProfile.transform.position, productInitPos);
        float Distance5 = Vector2.Distance(userProfile.transform.position, regisInitPos);


        Vector2 position;



        if (Distance1 < 50)
        {
            position = profileInitPos;

            userProfile.transform.position = accountInitPos;
            profileInitPos = accountInitPos;

            accountManagement.transform.position = position;
            accountInitPos = position;

        }

        else if (Distance2 < 50)
        {

            position = profileInitPos;

            userProfile.transform.position = chatInitPos;
            profileInitPos = chatInitPos;

            chat.transform.position = position;
            chatInitPos = position;



        }
        else if (Distance3 < 50)
        {
            position = profileInitPos;

            userProfile.transform.position = paymentInitPos;
            profileInitPos = paymentInitPos;
            payment.transform.position = position;
            paymentInitPos = position;


        }
        else if (Distance4 < 50)
        {

            position = profileInitPos;

            userProfile.transform.position = productInitPos;
            profileInitPos = productInitPos;
            product.transform.position = position;
            productInitPos = position;

        }
        else if (Distance5 < 50)
        {
            position = profileInitPos;

            userProfile.transform.position = regisInitPos;
            profileInitPos = regisInitPos;
            registeration.transform.position = position;
            regisInitPos = position;

        }


        else
        {
            userProfile.transform.position = profileInitPos;
        }


    }



    public void DropChoiceRegis()

    {
        float Distance1 = Vector2.Distance(registeration.transform.position, accountInitPos);
        float Distance2 = Vector2.Distance(registeration.transform.position, chatInitPos);
        float Distance3 = Vector2.Distance(registeration.transform.position, paymentInitPos);
        float Distance4 = Vector2.Distance(registeration.transform.position, productInitPos);
        float Distance6 = Vector2.Distance(registeration.transform.position, profileInitPos);

        Vector2 position;



        if (Distance1 < 50)
        {
            position = regisInitPos;

            registeration.transform.position = accountInitPos;
            regisInitPos = accountInitPos;

            accountManagement.transform.position = position;
            accountInitPos = position;

        }
        else if (Distance2 < 50)
        {
            Debug.Log(regisInitPos);
            position = regisInitPos;

            registeration.transform.position = chatInitPos;
            regisInitPos = chatInitPos;

            chat.transform.position = position;
            chatInitPos = position;



        }
        else if (Distance3 < 50)
        {
            position = regisInitPos;

            registeration.transform.position = paymentInitPos;
            regisInitPos = paymentInitPos;
            payment.transform.position = position;
            paymentInitPos = position;


        }
        else if (Distance4 < 50)
        {

            position = regisInitPos;

            registeration.transform.position = productInitPos;
            regisInitPos = productInitPos;
            product.transform.position = position;
            productInitPos = position;

        }

        else if (Distance6 < 50)
        {
            position = regisInitPos;

            registeration.transform.position = profileInitPos;
            regisInitPos = profileInitPos;
            userProfile.transform.position = position;
            profileInitPos = position;
        }

        else
        {
            registeration.transform.position = regisInitPos;
        }


    }

    
        public void DropChoiceAccount()
        {
            
            float Distance2 = Vector2.Distance(accountManagement.transform.position, chatInitPos);
            float Distance3 = Vector2.Distance(accountManagement.transform.position, paymentInitPos);
            float Distance4 = Vector2.Distance(accountManagement.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(accountManagement.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(accountManagement.transform.position, profileInitPos);

            Vector2 position;


             if (Distance2 < 50)
            {
                Debug.Log(accountInitPos);
                position = accountInitPos;

                accountManagement.transform.position = chatInitPos;
                accountInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
            else if (Distance3 < 50)
            {
                position = accountInitPos;

                accountManagement.transform.position = paymentInitPos;
                accountInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            else if (Distance4 < 50)
            {

                position = accountInitPos;

                accountManagement.transform.position = productInitPos;
                accountInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 50)
            {
                position = accountInitPos;

                accountManagement.transform.position = regisInitPos;
                accountInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 50)
            {
                position = accountInitPos;

                accountManagement.transform.position = profileInitPos;
                accountInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                accountManagement.transform.position = accountInitPos;
            }


        }
    
        public void DropChoiceChat()
        {
            float Distance1 = Vector2.Distance(chat.transform.position, accountInitPos);
            float Distance3 = Vector2.Distance(chat.transform.position, paymentInitPos);
            float Distance4 = Vector2.Distance(chat.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(chat.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(chat.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 50)
            {
                position = chatInitPos;

                chat.transform.position = accountInitPos;
                chatInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            
            else if (Distance3 < 50)
            {
                position = chatInitPos;

                chat.transform.position = paymentInitPos;
                chatInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            else if (Distance4 < 50)
            {

                position = chatInitPos;

                chat.transform.position = productInitPos;
                chatInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 50)
            {
                position = chatInitPos;

                chat.transform.position = regisInitPos;
                chatInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 50)
            {
                position = chatInitPos;

                chat.transform.position = profileInitPos;
                chatInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                chat.transform.position = chatInitPos;
            }


        }

    
        public void DropChoicePayment()
        {
            float Distance1 = Vector2.Distance(payment.transform.position, accountInitPos);
            float Distance2 = Vector2.Distance(payment.transform.position, chatInitPos);
            float Distance4 = Vector2.Distance(payment.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(payment.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(payment.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 50)
            {
                position = paymentInitPos;

                payment.transform.position = accountInitPos;
                paymentInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            else if (Distance2 < 50)
            {
                Debug.Log(paymentInitPos);
                position = paymentInitPos;

                payment.transform.position = chatInitPos;
                paymentInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
           
            else if (Distance4 < 50)
            {

                position = paymentInitPos;

                payment.transform.position = productInitPos;
                paymentInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 50)
            {
                position = paymentInitPos;

                payment.transform.position = regisInitPos;
                paymentInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 50)
            {
                position = paymentInitPos;

                payment.transform.position = profileInitPos;
                paymentInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                payment.transform.position = paymentInitPos;
            }


        }
    
        public void DropChoiceProduct()
        {
            float Distance1 = Vector2.Distance(product.transform.position, accountInitPos);
            float Distance2 = Vector2.Distance(product.transform.position, chatInitPos);
            float Distance3 = Vector2.Distance(product.transform.position, paymentInitPos);
            float Distance5 = Vector2.Distance(product.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(product.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 50)
            {
                position = productInitPos;

                product.transform.position = accountInitPos;
                productInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            else if (Distance2 < 50)
            {
                Debug.Log(productInitPos);
                position = productInitPos;

                product.transform.position = chatInitPos;
                productInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
            else if (Distance3 < 50)
            {
                position = productInitPos;

                product.transform.position = paymentInitPos;
                productInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            
            else if (Distance5 < 50)
            {
                position = productInitPos;

                product.transform.position = regisInitPos;
                productInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 50)
            {
                position = productInitPos;

                product.transform.position = profileInitPos;
                productInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                product.transform.position = productInitPos;
            }


        }


        


    // Start is called before the first frame update
    void Start()
    {


        

        for (int i = 0; i < 6; i++)
        {
            initttPos[i] = choiceArray[i].transform.position;



        }

        accountInitPos = accountManagement.transform.position;
        chatInitPos = chat.transform.position;
        paymentInitPos = payment.transform.position;
        productInitPos = product.transform.position;
        regisInitPos = registeration.transform.position;
        profileInitPos = userProfile.transform.position;

        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
    }



}
