using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DariaHornikLab2Zadanie
{
    internal partial class FormStartsPage : Form
    {
        //pola klasy
        PetOwner petOwner;
        Animal animal;
        FormPark formPark;

        int listIndex = 0;
        int clock = 0;
        int messageTime = 20;

        /// <summary>
        /// konstruktor
        /// </summary>
        public FormStartsPage()
        {
            InitializeComponent();
            panelStartsPsge.Visible = true;
        }

        /// <summary>
        /// metoda włączająca nowy panel-główną strone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNewGame_Click(object sender, EventArgs e)
        {
            panelSignUp.Visible = true;
            panelStartsPsge.Visible = false;
        }

        /// <summary>
        /// rozpoczecie gry 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            petOwner = new PetOwner();
            formPark = new FormPark(petOwner);
            petOwner.setName(textBoxGamersNick.Text);
            petOwner.setPassword(textBoxGamersPassword.ToString());
            panelMainPage.Visible = true;
            panelSignUp.Visible = false;
            labelNickInInformations.Text = petOwner.name;
            textBoxYourMoney.Text = petOwner.money.ToString();
            pictureBoxActualAnimal.Image = null; 
            timer.Start();
        }

        /// <summary>
        /// etoda włączająca nowy panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click_1(object sender, EventArgs e)
        {
            panelMainPage.Visible = false;
            panelShop.Visible = true;
        }

        /// <summary>
        /// etoda włączająca nowy panel-weternarz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVet_Click(object sender, EventArgs e)
        {
            panelMainPage.Visible = false;
            panelVet.Visible = true;
        }

        /// <summary>
        /// etoda włączająca nowy panel-dom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            panelMainPage.Visible = false;
            panelHome.Visible = true;
            textBoxYourMoney.Text = petOwner.money.ToString();
        }

        /// <summary>
        /// etoda włączająca nowy panel-park
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPark_Click(object sender, EventArgs e)
        {
            if (animal == null)
            {
                MessageBox.Show("Musisz mieć zwierzątko ze sobą, wróć po nie do domu.");
                return;
            }
            this.formPark.Show();    
        }

        /// <summary>
        /// guzik wylogowujący
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLog_Click_1(object sender, EventArgs e)
        {
            panelMainPage.Visible = false;
            panelStartsPsge.Visible = true;
        }

        /// <summary>
        /// wyjscie od lekarz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetOutADoctor_Click(object sender, EventArgs e)
        {
            panelVet.Visible = false;
            panelMainPage.Visible = true;
        }

        /// <summary>
        /// etoda włączająca nowy panel-główną strone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoOut_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelMainPage.Visible = true;
        }

        /// <summary>
        /// etoda włączająca nowy panel-sklep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNextPageInShop_Click(object sender, EventArgs e)
        {
            panelCatsShop.Visible = true;
            panelShop.Visible = false;
        }

        /// <summary>
        /// etoda włączająca nowy panel-sklep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNextPageInShop2_Click(object sender, EventArgs e)
        {
            panelCatsShop.Visible = false;
            panelShop.Visible = true;
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDog1_Click(object sender, EventArgs e)
        {
            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog1.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new Dog(1), 1, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDog3_Click(object sender, EventArgs e)
        {

            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog3.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new Dog(3), 3, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDog2_Click(object sender, EventArgs e)
        {

            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog2.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new Dog(2), 2, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoOutOfTheShop_Click(object sender, EventArgs e)
        {
            panelShop.Visible = false;
            panelMainPage.Visible = true;
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoOutOfTheCatsShop_Click(object sender, EventArgs e)
        {
            panelCatsShop.Visible = false;
            panelMainPage.Visible = true;
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxcat3_Click(object sender, EventArgs e)
        {
            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog2.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new MixedBreedCat(3), 3, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCat1_Click(object sender, EventArgs e)
        {
            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog2.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new PurebredCat(1), 1, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// zakup zwierzaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCat2_Click(object sender, EventArgs e)
        {
            bool isBuy = petOwner.canAfford(Int32.Parse(labelPriceDog2.Text));
            if (isBuy)
            {
                petOwner.BuyAnimal(new MixedBreedCat(2), 2, Int32.Parse(labelPriceDog1.Text));
                MessageBox.Show("Zwierzątko zostało dostarczone do twojego domu. Opiekuj się nim dobrze!");
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
            else MessageBox.Show("Nie masz wystarczająco pieniędzy,by kupic to zwierzątko.");
        }

        /// <summary>
        /// metoda przełączająca nasze zwierzaki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextPet_Click(object sender, EventArgs e)
        {
            if (petOwner.myPets.Count != 0)
            {
                animal = petOwner.myPets[Math.Abs(listIndex++ % petOwner.myPets.Count)];
                labelAnimalsName.Text = animal.name.ToString();
                labelAge.Text = animal.age.ToString();
                labelHeath.Text = "Bardzo dobry";

                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (animal is Dog)
                {
                    if (((Dog)animal).nr == 1)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies1.png";
                    else if (((Dog)animal).nr == 2)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies2.png";
                    else
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies3.png";
                }
                else
                {
                    if (animal is PurebredCat)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot1.png";
                    else if (((MixedBreedCat)animal).nr == 2)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot2.png";
                    else pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot3.png";
                }
            }
            else
            {
                MessageBox.Show("Nie masz jeszcze żadnego zwierzątka, udaj się do sklepu.");
            }
        }


        /// <summary>
        /// metoda wyswietlająca komponenty do zmiany imienia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            textBoxChangeName.Visible = true;
            buttonConfirmName.Visible = true;
        }

        /// <summary>
        /// metoda wyswietlająca komponenty do zmiany imienia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmName_Click(object sender, EventArgs e)
        {
            animal.name = textBoxChangeName.Text;
            labelAnimalsName.Text = animal.name;
            textBoxChangeName.Text = "";
            textBoxChangeName.Visible = false;
            buttonConfirmName.Visible = false;
        }


        /// <summary>
        /// metoda wykonująca się co takt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarHungry.Increment(1);
            progressBarHungry.Minimum = 0;
            progressBarHungry.Maximum = 60;
            clock++;


            if(clock%1200 == 0)
            {
                animal.age++;
                labelAge.Text = animal.age.ToString();

            }

            //choroba
            if (clock % 30 == 0 && animal != null)
            {
                labelHeath.Text = "Zły";
                animal.bookHealth.Push(new Infection("Niezdrowe jedzenie"));
                MessageBox.Show("Twoje zwierzątko jest chore, udaj się z nim do lekarza");
            }

            //znikanie wiadomośći
            if(messageTime == 0)
            {
                labelMessageFromPet.Visible = false;
                labelDoctorDiagnosis.Visible = false;
            }
            if(messageTime > 0)
            {
                messageTime--;
            }

            //karmieni co 10min
            if(clock == 600)
            {
                animal.bookHealth.Push(new Malnutrition("Brak regularnych posiłków"));
                labelHeath.Text = "Zły";
                MessageBox.Show("Zapomniłeś nakarmić swoje zwirzątko. Przez ciebie jest teraz niedożywione, udaj się z nim do weterynarza");
            }
        }

        /// <summary>
        /// karmienie zwierząt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            
            labelMessageFromPet.Text = animal.Feed();
            labelMessageFromPet.Visible = true;
            progressBarHungry.Value = 0;
            
        }

        /// <summary>
        /// spanie zwierzat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrink_Click(object sender, EventArgs e)
        {
            labelMessageFromPet.Text = animal.Sleep();
            labelMessageFromPet.Visible = true;
            Thread.Sleep(6000);
        }

        /// <summary>
        /// metoda wyswielajaca poprzedniego zwierzaka z listy i ustawiająca obrazek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPreviousPet_Click(object sender, EventArgs e)
        {
            if (petOwner.myPets.Count != 0)
            {
                animal = petOwner.myPets[Math.Abs(listIndex-- % petOwner.myPets.Count)];
                labelAnimalsName.Text = animal.name.ToString();
                labelAge.Text = animal.age.ToString();
                labelHeath.Text = "Bardzo dobry";

                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (animal is Dog)
                {
                    if (((Dog)animal).nr == 1)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies1.png";
                    else if (((Dog)animal).nr == 2)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies2.png";
                    else
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\pies3.png";
                }
                else
                {
                    if (animal is PurebredCat)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot1.png";
                    else if (((MixedBreedCat)animal).nr == 2)
                        pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot2.png";
                    else pictureBoxActualAnimal.ImageLocation = path + "\\Grafika\\kot3.png";
                }
            }
            else
            {
                MessageBox.Show("Nie masz jeszcze żadnego zwierzątka, udaj się do sklepu.");
            }
        }

        /// <summary>
        /// metoda potwierdzająca wybór radiobuttonów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextStepInVet_Click(object sender, EventArgs e)
        {
            if (animal == null)
            {
                MessageBox.Show("Zapomniałeś zwierzaka, wróć do domu po niego.");
               return;
            }
            if (!petOwner.canAfford(100))
            {
                MessageBox.Show("Nie stać cię na na wizyte u weterynarza");
                return;
            }
            if (radioButtonControlVisit.Checked)
            {
                if(animal.bookHealth.Count != 0)
                {
                     Illness illness = animal.bookHealth.Peek();
                     if(illness.isCured)
                     {
                        labelDoctorDiagnosis.Visible = true;
                        labelDoctorDiagnosis.Text = "Wszystko w porządku z Pańskim zwierzątkiem";
                        messageTime = 10;
                     }
                     else
                    {
                        labelDoctorDiagnosis.Visible = true;
                        illness = animal.bookHealth.Pop();
                        illness.isCured = true;
                        animal.bookHealth.Push(illness);
                        labelDoctorDiagnosis.Text = "Pańskie zwirzątko było chore, " +
                            "ale prosze się nie martwić. Wykryłem u niego "+illness.name+
                            ", ale wystarczy "+illness.WayOfTreatment();
                        labelHeath.Text = "Bardzo dobry";
                        messageTime = 30;
                    }
                }
               
            }
            else
            {
                petOwner.money -= 100;
                textBoxYourMoney.Text = petOwner.money.ToString();
            }
        }

        
        /// <summary>
        /// Zapisanie danych w pliku i wyświetleni ich w messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonbuttonSaveData_Click(object sender, EventArgs e)
        {

            DirectoryInfo[] cDirs = new DirectoryInfo(Application.StartupPath).GetDirectories();
       
            using (StreamWriter sw = new StreamWriter("Data.txt"))
            {
                 sw.WriteLine(textBoxGamersNick.Text.ToString());
                sw.WriteLine(textBoxGamersPassword.Text.ToString());

                
            }

            string data = "";
            string line;
            using (StreamReader sr = new StreamReader(Application.StartupPath+"//Data.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    data += line+", ";
                } 
                MessageBox.Show("Witaj! Twoje dane to: "+data);
            }
        }
        
    }
}
