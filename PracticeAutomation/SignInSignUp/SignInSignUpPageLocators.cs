using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.SignInSignUp
{
    public partial class SignInSignUpPage
    {
        //For Sign In
        By loginButton = By.ClassName("login");
        By emailTxt = By.Id("email");
        By passwordTxt = By.Name("passwd");
        By submitButton = By.Name("SubmitLogin");

        //For Sign Out
        By logoutButton = By.ClassName("logout");

        //For Sign Up
        By signUpEmailCreateTxt = By.Id("email_create");
        By submitCreateButton = By.Name("SubmitCreate");
        By maleGenderRadio = By.Id("id_gender1");
        By femaleGenderRadio = By.Id("id_gender2");
        By customerFirstNameTxt = By.Name("customer_firstname");
        By customerLastNameTxt = By.Name("customer_lastname");
        By firstNameTxt = By.Name("firstname");
        By lastNameTxt = By.Name("lastname");
        By addressTxt = By.Name("address1");
        By cityTxt = By.Name("city");
        By stateSelect = By.Id("id_state");
        By countrySelect = By.Name("id_country");
        By postCodeTxt = By.Name("postcode");
        By mobileNoTxt = By.Name("phone_mobile");
        By addressReferenceTxt = By.Name("alias");
        By submitAccountButton = By.Name("submitAccount");
    }
}
