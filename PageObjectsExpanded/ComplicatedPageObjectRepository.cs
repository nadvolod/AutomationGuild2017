using OpenQA.Selenium;
using PageObjectsExpanded.PageObject;

namespace PageObjectsExpanded
{
    public class ComplicatedPageObjectRepository : BasePageObjectRepository
    {
        public ComplicatedPageObjectRepository(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstTwitterButton => Driver.FindElements(By.XPath("//*[@title='Twitter']"))[0];
        public IWebElement SearchForm => Driver.FindElements(By.XPath("//form[@role='search']"))[1];
        public IWebElement SearchBox => Driver.FindElements(By.XPath("//form[@role='search']//input[@id='s']"))[0];
        public IWebElement SearchButton => SearchForm.FindElement(By.Id("searchsubmit"));
        //By.XPath("//h5[text()='A toggle']")
        public IWebElement Toggle => Driver.FindElement(By.ClassName("et_pb_toggle_title"));
        public By ToggleInnerTextLocator => By.XPath("//p[text()='Inside of toggle']");
        public IWebElement PostsSlider => Driver.FindElement(By.ClassName("et_pb_slide_content "));
    }
}