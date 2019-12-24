using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using UnitTestProject5;


namespace Stumped2
{
    class ImagesList
    {
        public string IMAGE { get; set; }
    }
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("cookiebtn")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/footer/section/div[2]/div/div[1]")).Click();
            Thread.Sleep(2000);
  
            string handle = driver.CurrentWindowHandle;

            FunctionalLib.MouseOver(driver, "/html/body/div[1]/div/myapp/section[4]/div/div/div/div[1]/div/section[1]/div/div/div[1]/div/a");

            for (int i = 2; i <= 4; i++)
            {
                FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span", "xpath");

                Thread.Sleep(2000);

                string title = driver.FindElement(By.XPath("/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span")).Text;

                Console.WriteLine(title);
                if (title.Contains("Cricket"))

                {
                    for (int j = 2; j <= 7; j++)
                    {
                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[" + j + "]/a", "xpath");
                        Thread.Sleep(2000);
                        string title2 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[" + j + "]/a")).Text;

                        Console.WriteLine(title2);
                    }

                }
                if (title.Contains("Football"))

                {
                    for (int k = 2; k <= 8; k++)
                    {

                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[" + k + "]/a", "xpath");


                        Thread.Sleep(2000);
                        string title3 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[" + k + "]/a")).Text;
                        Console.WriteLine(title3);
                        if(title3.Equals("Score Predictor"))
                            {
                            driver.Navigate().Back();
                        }
                    }

                }

                if (title.Contains("Kabaddi"))

                {
                    for (int a = 2; a <= 8; a++)
                    {
                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[" + a + "]/a", "xpath");
                        Thread.Sleep(2000);
                        string title4 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[" + a + "]/a")).Text;
                        Console.WriteLine(title4);

                    }

                }
            }
        }


        [TestMethod]
        public static void onetimesetup()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();



            driver.FindElement(By.Id("cookiebtn")).Click();
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("/html/body/div[1]/footer/section/div[2]/div/div[2]/div[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(2000);

            FunctionalLib.clickAction(driver, "identifierId", "Id");

            driver.FindElement(By.Id("identifierId")).SendKeys("testerppsi9@gmail.com");


            //click on nextbutton
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(4000);

            //pwdfield
            FunctionalLib.TypeAction(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input", "xpath", "ppsi1234");

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(5000);
        }
        public void Homepage()

        {
            onetimesetup();

            //Homepage
            for (int i = 1; i <= 12; i++)
            {
                FunctionalLib.MouseOver(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div[1]/div/section[" + i + "]/div/div/div[1]/div/a");
                Thread.Sleep(2000);
                FunctionalLib.clickAction(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div[1]/div/section[" + i + "]/div/div/div[1]/div/a", "xpath");
                driver.Navigate().Back();

            }
        }

        [TestMethod]

        public void Cricket()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("cookiebtn")).Click();
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("/html/body/div[1]/footer/section/div[2]/div/div[2]/div[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(2000);

            FunctionalLib.clickAction(driver, "identifierId", "Id");

            driver.FindElement(By.Id("identifierId")).SendKeys("testerppsi9@gmail.com");

            //click on nextbutton
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(4000);

            //pwdfield
            FunctionalLib.TypeAction(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input", "xpath", "ppsi1234");

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(5000);

            /*driver.FindElement(By.XPath("//*[@id='c1330d14-5a19-479b-b72b-e1c649a7fff6']/div/div[2]/div[2]/nav/ul/li[2]/a/span")).Click();
            Thread.Sleep(2000);


            FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div/section/div/div/div[1]/div/a");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(1000);

            for (int j = 2; j <= 5; j++)
            {
                Thread.Sleep(1000);

                FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[4]/div/div/div/div[1]/div/section[" + j + "]/div/div/div[1]/div/a");
                Thread.Sleep(1000);

                driver.Navigate().Back();
            }*/

        }

        [TestMethod]
        public void Football()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("cookiebtn")).Click();
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("/html/body/div[1]/footer/section/div[2]/div/div[2]/div[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(2000);

            FunctionalLib.clickAction(driver, "identifierId", "Id");

            driver.FindElement(By.Id("identifierId")).SendKeys("testerppsi9@gmail.com");

            //click on nextbutton
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(4000);

            //pwdfield
            FunctionalLib.WaitforElement(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input");
            FunctionalLib.TypeAction(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input", "xpath", "ppsi1234");

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[3]/a/span")).Click();
            Thread.Sleep(2000);

            FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div/section/div/div/div[1]/div/a");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(1000);

            for (int k = 5; k <= 8; k++)
            {
                Thread.Sleep(1000);

                FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[4]/div/div/div/div[1]/div/section[" + k + "]/div/div/div[1]/div/a");
                Thread.Sleep(1000);

                driver.Navigate().Back();
            }

        }

        [TestMethod]
        public void Kabaddi()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("cookiebtn")).Click();
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("/html/body/div[1]/footer/section/div[2]/div/div[2]/div[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(2000);

            FunctionalLib.clickAction(driver, "identifierId", "Id");

            driver.FindElement(By.Id("identifierId")).SendKeys("testerppsi9@gmail.com");

            //click on nextbutton
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(4000);

            //pwdfield
            FunctionalLib.WaitforElement(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input");
            FunctionalLib.TypeAction(driver, "/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input", "xpath", "ppsi1234");

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/span/span")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[4]/a/span")).Click();
            Thread.Sleep(2000);

            FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div/section/div/div/div[1]/div/a");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(1000);

            for (int a = 1; a <= 3; a++)
            {
                Thread.Sleep(1000);

                FunctionalLib.Scrollto(driver, "/html/body/div[1]/div/myapp/section[4]/div/div/div/div[1]/div/section[" + a + "]/div/div/div[1]/div/a");
                Thread.Sleep(1000);
                driver.Navigate().Back();

            }
        }

        [TestMethod]
        public void BrokenImage()
        {
            IWebDriver driver = new ChromeDriver();

            for (int k = 2; k <= 9; k++)
            {

                string url = FunctionalLib.ReadDataExcel(1, k, 1);

                driver.Navigate().GoToUrl(url);

                driver.Manage().Window.Maximize();
                int sum = (int)(driver.FindElements(By.TagName("img"))).Count;

                Console.WriteLine(sum);
                var Imageslist = new List<ImagesList>();
                var allImages = driver.FindElements(By.TagName("img"));
                foreach (var img in allImages)
                {
                    var imgSrc = img.GetAttribute("src");
                    Imageslist.Add(new ImagesList { IMAGE = imgSrc });
                    NUnit.Framework.TestContext.Out.WriteLine($"IMAGE:{imgSrc}");
                }
                foreach (var i in Imageslist)
                {
                    var link = i.IMAGE.ToString();

                    if (link == "")
                    {
                        Console.WriteLine("src empty");
                    }
                    else
                    {
                        string brokenlink = link.Substring(8, 2);
                        if (brokenlink.Equals("s3"))
                        {
                            Console.WriteLine(link);
                        }
                    }

                }

            }
            
        }
    }
}


    



    



    


