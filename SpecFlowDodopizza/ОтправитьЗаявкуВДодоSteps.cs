using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using 

namespace SpecFlowDodopizza
{

    [Binding]
    public class ОтправитьЗаявкуВДодоSteps
    {
     
        [Given(@"Перешел на сайт работы в додо")]
        
        public void GivenПерешелНаСайтРаботыВДодо()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://rabotavdodo.ru/ ");
            driver.FindElement(By.TagName("button")).Click();
        }
        
        [When(@"Заполнил все поля")]
        public void WhenЗаполнилВсеПоля()
        {
            
            
            var driver = WebDriver.CreateChromeDriver();
            driver = new ChromeDriver();
            

            var option = driver.FindElement(By.Name("localityId"));
            var selectElement = new SelectElement(option);
            selectElement.SelectByValue("11");

            driver.FindElement(By.Id("name_01")).SendKeys("Килюшев");
            driver.FindElement(By.Id("name_02")).SendKeys("Евгений");

            var option1 = driver.FindElement(By.Id("birthday_day"));
            var selectElement1 = new SelectElement(option1);
            selectElement1.SelectByValue("1");

            var option2 = driver.FindElement(By.Id("birthday_month"));
            var selectElement2 = new SelectElement(option2);
            selectElement2.SelectByValue("9");

            var option4 = driver.FindElement(By.Id("birthday_year"));
            var selectElement4 = new SelectElement(option4);
            selectElement4.SelectByValue("1991");

            driver.FindElement(By.Id("address")).SendKeys("г.Сыктывкар, ул. Клары Цеткин 50-156");

            driver.FindElement(By.Id("phonenumber")).SendKeys(" 9042222145");

            driver.FindElement(By.Id("unit_3")).Click();

            driver.FindElement(By.Id("worktime_02")).Click(); //утро 
            driver.FindElement(By.Id("worktime_04")).Click();

            driver.FindElement(By.Id("position_2")).Click();
            driver.FindElement(By.Id("position_3")).Click();

            driver.FindElement(By.Name("MedicalBook")).Click();

            var option5 = driver.FindElement(By.Id("applicantSource"));
            var selectElement5 = new SelectElement(option5);
            selectElement5.SelectByValue("Other");

            driver.FindElement(By.Id("applicantSourceDescription")).SendKeys("Другое-другое-другое");
            driver.FindElement(By.Id("workExperience")).SendKeys("Есть-есть-есть");
            driver.FindElement(By.Id("hobby")).SendKeys("Много-много-много");
            driver.FindElement(By.Id("socialLink")).SendKeys("evg612");

            var option6 = driver.FindElement(By.Id("expectedWorkPeriod"));
            var selectElement6 = new SelectElement(option6);
            selectElement6.SelectByValue("Always");

            driver.FindElement(By.Name("Oferta")).Click();
        }
        
        [When(@"Нажал кнопку Отправить")]
        public void WhenНажалКнопкуОтправить()
        {
            var driver = new ChromeDriver();
            
            driver.FindElement(By.Id("send")).Click();
            
        }
        
        [Then(@"открылась страница с подтверждением отправки анкеты")]
        public void ThenОткрыласьСтраницаСПодтверждениемОтправкиАнкеты()
        {
            var driver = WebDriver.CreateChromeDriver();
            driver.FindElement(By.Id("send")).Click();
            //  Assert.AreEqual("Спасибо!",Element.Text.Tostring())
        }
    }
}
