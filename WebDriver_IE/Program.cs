using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_IE
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://localhost:56868/Acceso/Login");
            driver.Manage().Window.Maximize();
            //Console.Read();

            /*
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            IWebElement sel = driver.FindElement(By.Name("codigo"));
            sel.SendKeys("jmsant@civilitycare");
            IWebElement pas = driver.FindElement(By.Name("contrasena"));
            pas.SendKeys("1234" + Keys.Enter);
            */

            driver.FindElement(By.Name("codigo")).SendKeys("jmsant@civilitycare");
            driver.FindElement(By.Name("contrasena")).SendKeys("1234" + Keys.Enter);

            //driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/button")).Click();
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[1]/a")).Click();

            IList<IWebElement> citas = driver.FindElements(By.XPath("//table[@class='table table-striped table-hover']/a"));
            Console.WriteLine("Total de citas: " + citas.Count);

            for(int i=0;i<citas.Count;i++)
            {
                Console.WriteLine(citas[i].Text);
            }


        }
    }
}
